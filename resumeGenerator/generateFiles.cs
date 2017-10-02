using System;
using System.Collections.Generic;
using System.IO;

namespace resumeGenerator
{
    internal class generateFiles
    {
        private string filename;

        public generateFiles(string filename)
        {
            this.filename = filename;
            loadAddresses();
        }

        private void loadAddresses()
        {
            Dictionary<string, string> address = new Dictionary<string, string>();
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