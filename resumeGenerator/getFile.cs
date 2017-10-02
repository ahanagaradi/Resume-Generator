using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resumeGenerator
{
    public partial class getFile : Form
    {
        public string filename = "";
        public getFile()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            getFileName();
            setFileName();
        }

        private void setFileName()
        {
            filePath.Text = filename;
            filePath.Visible = true;
        }

        private void getFileName()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Multiselect = false;
                System.Windows.Forms.DialogResult res = ofd.ShowDialog();
                if (res == DialogResult.OK)
                {
                    filename = ofd.FileName;
                }
            }
            catch(Exception e)
            {
                throw new System.ArgumentException("Unable to Browse for files : " + e.Message);
            }
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            generateFiles pdf = new generateFiles(filename);
            this.Close();
        }
    }
}
