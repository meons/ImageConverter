namespace CSTiffImageConverter
{
    partial class NewForm
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
            this.btnOpenPicture = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.cmbOutput = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dlgOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblStatusMultipageConversion = new System.Windows.Forms.Label();
            this.btnChooseFiles = new System.Windows.Forms.Button();
            this.btnMergeToTiff = new System.Windows.Forms.Button();
            this.dlgOpenMultipleFilesDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSelectPictures2 = new System.Windows.Forms.Button();
            this.radioBtnFixWidth = new System.Windows.Forms.RadioButton();
            this.radioBtnFixHeight = new System.Windows.Forms.RadioButton();
            this.lblStatusResizer = new System.Windows.Forms.Label();
            this.openFileDialogResizer = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConvert);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.btnOpenPicture);
            this.groupBox1.Controls.Add(this.cmbOutput);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(178, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change picture format";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnOpenPicture
            // 
            this.btnOpenPicture.Location = new System.Drawing.Point(22, 32);
            this.btnOpenPicture.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenPicture.Name = "btnOpenPicture";
            this.btnOpenPicture.Size = new System.Drawing.Size(133, 38);
            this.btnOpenPicture.TabIndex = 0;
            this.btnOpenPicture.Text = "Open a picture";
            this.btnOpenPicture.UseVisualStyleBackColor = true;
            this.btnOpenPicture.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(22, 126);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(133, 36);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // cmbOutput
            // 
            this.cmbOutput.FormattingEnabled = true;
            this.cmbOutput.Location = new System.Drawing.Point(23, 92);
            this.cmbOutput.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOutput.Name = "cmbOutput";
            this.cmbOutput.Size = new System.Drawing.Size(134, 21);
            this.cmbOutput.TabIndex = 0;
            this.cmbOutput.Text = "Choose format";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 168);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            this.lblStatus.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dlgOpenFileDialog
            // 
            this.dlgOpenFileDialog.Filter = "Image files (.jpg, .jpeg, .tif)|*.jpg;*.jpeg;*.tif;*.tiff";
            this.dlgOpenFileDialog.Multiselect = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblStatusMultipageConversion);
            this.groupBox3.Controls.Add(this.btnChooseFiles);
            this.groupBox3.Controls.Add(this.btnMergeToTiff);
            this.groupBox3.Location = new System.Drawing.Point(9, 223);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(178, 160);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create multipage TIFF";
            // 
            // lblStatusMultipageConversion
            // 
            this.lblStatusMultipageConversion.AutoSize = true;
            this.lblStatusMultipageConversion.Location = new System.Drawing.Point(20, 133);
            this.lblStatusMultipageConversion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusMultipageConversion.Name = "lblStatusMultipageConversion";
            this.lblStatusMultipageConversion.Size = new System.Drawing.Size(37, 13);
            this.lblStatusMultipageConversion.TabIndex = 2;
            this.lblStatusMultipageConversion.Text = "Status";
            this.lblStatusMultipageConversion.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnChooseFiles
            // 
            this.btnChooseFiles.Location = new System.Drawing.Point(23, 26);
            this.btnChooseFiles.Margin = new System.Windows.Forms.Padding(2);
            this.btnChooseFiles.Name = "btnChooseFiles";
            this.btnChooseFiles.Size = new System.Drawing.Size(133, 38);
            this.btnChooseFiles.TabIndex = 0;
            this.btnChooseFiles.Text = "Select pictures";
            this.btnChooseFiles.UseVisualStyleBackColor = true;
            this.btnChooseFiles.Click += new System.EventHandler(this.btnChooseImages_Click);
            // 
            // btnMergeToTiff
            // 
            this.btnMergeToTiff.Location = new System.Drawing.Point(23, 84);
            this.btnMergeToTiff.Margin = new System.Windows.Forms.Padding(2);
            this.btnMergeToTiff.Name = "btnMergeToTiff";
            this.btnMergeToTiff.Size = new System.Drawing.Size(133, 36);
            this.btnMergeToTiff.TabIndex = 0;
            this.btnMergeToTiff.Text = "Merge to single TIFF";
            this.btnMergeToTiff.Click += new System.EventHandler(this.btnMergeToTiff_Click);
            // 
            // dlgOpenMultipleFilesDialog
            // 
            this.dlgOpenMultipleFilesDialog.Filter = "Image files (.jpg, .bmp, .tif, .gif)|*.jpg;*.bmp;*.tif;*.gif";
            this.dlgOpenMultipleFilesDialog.Multiselect = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblStatusResizer);
            this.groupBox4.Controls.Add(this.radioBtnFixHeight);
            this.groupBox4.Controls.Add(this.radioBtnFixWidth);
            this.groupBox4.Controls.Add(this.btnSelectPictures2);
            this.groupBox4.Location = new System.Drawing.Point(212, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(178, 369);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resize pictures";
            // 
            // btnSelectPictures2
            // 
            this.btnSelectPictures2.Location = new System.Drawing.Point(22, 31);
            this.btnSelectPictures2.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectPictures2.Name = "btnSelectPictures2";
            this.btnSelectPictures2.Size = new System.Drawing.Size(133, 38);
            this.btnSelectPictures2.TabIndex = 1;
            this.btnSelectPictures2.Text = "Choose pictures";
            this.btnSelectPictures2.UseVisualStyleBackColor = true;
            this.btnSelectPictures2.Click += new System.EventHandler(this.btnSelectPictures2_Click);
            // 
            // radioBtnFixWidth
            // 
            this.radioBtnFixWidth.AutoSize = true;
            this.radioBtnFixWidth.Location = new System.Drawing.Point(22, 95);
            this.radioBtnFixWidth.Name = "radioBtnFixWidth";
            this.radioBtnFixWidth.Size = new System.Drawing.Size(119, 17);
            this.radioBtnFixWidth.TabIndex = 2;
            this.radioBtnFixWidth.TabStop = true;
            this.radioBtnFixWidth.Text = "Fix width at 1024 px";
            this.radioBtnFixWidth.UseVisualStyleBackColor = true;
            // 
            // radioBtnFixHeight
            // 
            this.radioBtnFixHeight.AutoSize = true;
            this.radioBtnFixHeight.Location = new System.Drawing.Point(22, 125);
            this.radioBtnFixHeight.Name = "radioBtnFixHeight";
            this.radioBtnFixHeight.Size = new System.Drawing.Size(117, 17);
            this.radioBtnFixHeight.TabIndex = 2;
            this.radioBtnFixHeight.TabStop = true;
            this.radioBtnFixHeight.Text = "Fix heigth at 768 px";
            this.radioBtnFixHeight.UseVisualStyleBackColor = true;
            // 
            // lblStatusResizer
            // 
            this.lblStatusResizer.AutoSize = true;
            this.lblStatusResizer.Location = new System.Drawing.Point(19, 167);
            this.lblStatusResizer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusResizer.Name = "lblStatusResizer";
            this.lblStatusResizer.Size = new System.Drawing.Size(37, 13);
            this.lblStatusResizer.TabIndex = 3;
            this.lblStatusResizer.Text = "Status";
            // 
            // openFileDialogResizer
            // 
            this.openFileDialogResizer.FileName = "openFileDialogResizer";
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 394);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewForm";
            this.Text = "Image Converter Bobylev & Germann";
            this.Load += new System.EventHandler(this.NewForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenPicture;
        private System.Windows.Forms.ComboBox cmbOutput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.OpenFileDialog dlgOpenFileDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMergeToTiff;
        private System.Windows.Forms.Label lblStatusMultipageConversion;
        private System.Windows.Forms.Button btnChooseFiles;
        private System.Windows.Forms.OpenFileDialog dlgOpenMultipleFilesDialog;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSelectPictures2;
        private System.Windows.Forms.RadioButton radioBtnFixHeight;
        private System.Windows.Forms.RadioButton radioBtnFixWidth;
        private System.Windows.Forms.Label lblStatusResizer;
        private System.Windows.Forms.OpenFileDialog openFileDialogResizer;
    }
}