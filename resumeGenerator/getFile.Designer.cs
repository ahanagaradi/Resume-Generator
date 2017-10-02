namespace resumeGenerator
{
    partial class getFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(12, 19);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(80, 13);
            this.Label.TabIndex = 0;
            this.Label.Text = "Click to Browse";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(15, 51);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(15, 100);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(257, 20);
            this.filePath.TabIndex = 2;
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(15, 152);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 3;
            this.OKbutton.Text = "Done!";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // getFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.Label);
            this.Name = "getFile";
            this.Text = "getFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button OKbutton;
    }
}