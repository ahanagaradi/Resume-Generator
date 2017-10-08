using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Win32;
using Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Diagnostics;

namespace resumeGenerator
{
    class generateFiles
    {
        public Microsoft.Office.Interop.Word.Document wordDocument { get; set; }
       // public Microsoft.Office.Interop.Word.Document newDocument { get; set; }
        private string filename;
        Dictionary<string, string> address = new Dictionary<string, string>();

        public generateFiles(string filename)
        {
            this.filename = filename;
            loadAddresses();
            createCopy();
        }

        private void createCopy()
        {
            object missing = System.Reflection.Missing.Value;
            string newFilename = "";
            string timeStamp = String.Format("{0:f}", DateTime.Now);
            timeStamp = timeStamp.Replace(':', ' ');
            string destinationFolder = @"C:\VSProject\resumeGenerator\" + timeStamp;
            
            try
            {
                if (Directory.Exists(destinationFolder))
                {
                    destinationFolder += " 2";
                }
                DirectoryInfo di = Directory.CreateDirectory(destinationFolder);
                string searchText = "Address";
                foreach (KeyValuePair<string, string> replaceAddress in address)
                {
                    newFilename = destinationFolder + @"\" + replaceAddress.Key + ".pdf";

                    //replacing Address
                    Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application();
                    wordDocument = application.Documents.Open(this.filename, ref missing, false, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);

                    Microsoft.Office.Interop.Word.Find findObject = application.Selection.Find;
                    findObject.ClearFormatting();
                    findObject.Text = searchText;
                    findObject.Replacement.ClearFormatting();
                    findObject.Replacement.Text = replaceAddress.Value;
                    object replace = Microsoft.Office.Interop.Word.WdReplace.wdReplaceOne;
                    findObject.Execute(ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref replace, ref missing, ref missing, ref missing, ref missing);
                    //done replacing
                    
                    if (File.Exists(newFilename))
                        File.Delete(newFilename);

                    wordDocument.ExportAsFixedFormat(newFilename, WdExportFormat.wdExportFormatPDF);
                    ((_Document) wordDocument).Close();
                    ((_Application) application).Quit();

                    searchText = replaceAddress.Value;
                }
                
            }
            catch(Exception e)
            {
                throw new System.ArgumentException("Error in generating copies " + e.Message);
            }
        }

        private void loadAddresses()
        {
            string addressesPath = "C:\\pdfGenerator\\addresses.csv";
            try
            {
                StreamReader reader = new StreamReader(File.OpenRead(addressesPath));

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    address.Add(values[0], values[1]);
                }
            }            
            catch(Exception e)
            {
                throw new System.ArgumentException("Error Loading addresses : " + e.Message);
            }
        }
    }
}