namespace CSTiffImageConverter
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkIsMultipage = new System.Windows.Forms.CheckBox();
            this.btnConvertToTiff = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnConvertToJpeg = new System.Windows.Forms.Button();
            this.dlgOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.chkIsMultipage);
            this.groupBox1.Controls.Add(this.btnConvertToTiff);
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(465, 169);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jpeg";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(29, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(404, 46);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Click on \"Convert To Tiff\" button to browse the jpeg images & also converts them " +
    "into tiff file & saves @ the same location.";
            // 
            // chkIsMultipage
            // 
            this.chkIsMultipage.AutoSize = true;
            this.chkIsMultipage.Checked = true;
            this.chkIsMultipage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsMultipage.Location = new System.Drawing.Point(29, 80);
            this.chkIsMultipage.Margin = new System.Windows.Forms.Padding(4);
            this.chkIsMultipage.Name = "chkIsMultipage";
            this.chkIsMultipage.Size = new System.Drawing.Size(286, 21);
            this.chkIsMultipage.TabIndex = 2;
            this.chkIsMultipage.Text = "Check to create multipage tiff (single) file";
            this.chkIsMultipage.UseVisualStyleBackColor = true;
            // 
            // btnConvertToTiff
            // 
            this.btnConvertToTiff.Location = new System.Drawing.Point(93, 123);
            this.btnConvertToTiff.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvertToTiff.Name = "btnConvertToTiff";
            this.btnConvertToTiff.Size = new System.Drawing.Size(239, 28);
            this.btnConvertToTiff.TabIndex = 0;
            this.btnConvertToTiff.Text = "Jpeg To Tiff";
            this.btnConvertToTiff.UseVisualStyleBackColor = true;
            this.btnConvertToTiff.Click += new System.EventHandler(this.btnConvertToTiff_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.btnConvertToJpeg);
            this.groupBox2.Location = new System.Drawing.Point(11, 185);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(465, 188);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiff -> Jpeg";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(31, 39);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(404, 46);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Click on \"Convert To Jpeg\" button to browse the tiff images & also converts them " +
    "into jpeg file & saves @ the same location.";
            // 
            // btnConvertToJpeg
            // 
            this.btnConvertToJpeg.Location = new System.Drawing.Point(93, 122);
            this.btnConvertToJpeg.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvertToJpeg.Name = "btnConvertToJpeg";
            this.btnConvertToJpeg.Size = new System.Drawing.Size(239, 28);
            this.btnConvertToJpeg.TabIndex = 1;
            this.btnConvertToJpeg.Text = "Tiff To Jpeg";
            this.btnConvertToJpeg.UseVisualStyleBackColor = true;
            this.btnConvertToJpeg.Click += new System.EventHandler(this.btnConvertToJpeg_Click);
            // 
            // dlgOpenFileDialog
            // 
            this.dlgOpenFileDialog.Filter = "Image files (.jpg, .jpeg, .tif)|*.jpg;*.jpeg;*.tif;*.tiff";
            this.dlgOpenFileDialog.Multiselect = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(628, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 165);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 383);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "CSTiffImageConverter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkIsMultipage;
        private System.Windows.Forms.Button btnConvertToTiff;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnConvertToJpeg;
        private System.Windows.Forms.OpenFileDialog dlgOpenFileDialog;
        private System.Windows.Forms.GroupBox groupBox3;

    }
}

