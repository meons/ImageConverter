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
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnOpenPicture = new System.Windows.Forms.Button();
            this.cmbOutput = new System.Windows.Forms.ComboBox();
            this.dlgOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblStatusMultipageConversion = new System.Windows.Forms.Label();
            this.btnChooseFiles = new System.Windows.Forms.Button();
            this.btnMergeToTiff = new System.Windows.Forms.Button();
            this.dlgOpenMultipleFilesDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSelectPictures2 = new System.Windows.Forms.Button();
            this.openFileDialogResizer = new System.Windows.Forms.OpenFileDialog();
            this.txb_newWidth = new System.Windows.Forms.TextBox();
            this.txb_newHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(237, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change picture format";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(29, 155);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(177, 44);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(27, 207);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            this.lblStatus.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnOpenPicture
            // 
            this.btnOpenPicture.Location = new System.Drawing.Point(29, 39);
            this.btnOpenPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenPicture.Name = "btnOpenPicture";
            this.btnOpenPicture.Size = new System.Drawing.Size(177, 47);
            this.btnOpenPicture.TabIndex = 0;
            this.btnOpenPicture.Text = "Open a picture";
            this.btnOpenPicture.UseVisualStyleBackColor = true;
            this.btnOpenPicture.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // cmbOutput
            // 
            this.cmbOutput.FormattingEnabled = true;
            this.cmbOutput.Location = new System.Drawing.Point(31, 113);
            this.cmbOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOutput.Name = "cmbOutput";
            this.cmbOutput.Size = new System.Drawing.Size(177, 24);
            this.cmbOutput.TabIndex = 0;
            this.cmbOutput.Text = "Choose format";
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
            this.groupBox3.Location = new System.Drawing.Point(12, 274);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(237, 197);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create multipage TIFF";
            // 
            // lblStatusMultipageConversion
            // 
            this.lblStatusMultipageConversion.AutoSize = true;
            this.lblStatusMultipageConversion.Location = new System.Drawing.Point(27, 164);
            this.lblStatusMultipageConversion.Name = "lblStatusMultipageConversion";
            this.lblStatusMultipageConversion.Size = new System.Drawing.Size(48, 17);
            this.lblStatusMultipageConversion.TabIndex = 2;
            this.lblStatusMultipageConversion.Text = "Status";
            this.lblStatusMultipageConversion.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnChooseFiles
            // 
            this.btnChooseFiles.Location = new System.Drawing.Point(31, 32);
            this.btnChooseFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChooseFiles.Name = "btnChooseFiles";
            this.btnChooseFiles.Size = new System.Drawing.Size(177, 47);
            this.btnChooseFiles.TabIndex = 0;
            this.btnChooseFiles.Text = "Select pictures";
            this.btnChooseFiles.UseVisualStyleBackColor = true;
            this.btnChooseFiles.Click += new System.EventHandler(this.btnChooseImages_Click);
            // 
            // btnMergeToTiff
            // 
            this.btnMergeToTiff.Location = new System.Drawing.Point(31, 103);
            this.btnMergeToTiff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMergeToTiff.Name = "btnMergeToTiff";
            this.btnMergeToTiff.Size = new System.Drawing.Size(177, 44);
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
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txb_newHeight);
            this.groupBox4.Controls.Add(this.txb_newWidth);
            this.groupBox4.Controls.Add(this.btnSelectPictures2);
            this.groupBox4.Location = new System.Drawing.Point(283, 14);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(237, 237);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resize pictures";
            // 
            // btnSelectPictures2
            // 
            this.btnSelectPictures2.Location = new System.Drawing.Point(29, 111);
            this.btnSelectPictures2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectPictures2.Name = "btnSelectPictures2";
            this.btnSelectPictures2.Size = new System.Drawing.Size(177, 47);
            this.btnSelectPictures2.TabIndex = 1;
            this.btnSelectPictures2.Text = "Choose pictures";
            this.btnSelectPictures2.UseVisualStyleBackColor = true;
            this.btnSelectPictures2.Click += new System.EventHandler(this.btnSelectPictures2_Click);
            // 
            // openFileDialogResizer
            // 
            this.openFileDialogResizer.FileName = "openFileDialogResizer";
            // 
            // txb_newWidth
            // 
            this.txb_newWidth.Location = new System.Drawing.Point(122, 37);
            this.txb_newWidth.Name = "txb_newWidth";
            this.txb_newWidth.ReadOnly = true;
            this.txb_newWidth.Size = new System.Drawing.Size(84, 22);
            this.txb_newWidth.TabIndex = 2;
            this.txb_newWidth.Text = "1024";
            this.txb_newWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txb_newWidth.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txb_newHeight
            // 
            this.txb_newHeight.Location = new System.Drawing.Point(122, 65);
            this.txb_newHeight.Name = "txb_newHeight";
            this.txb_newHeight.ReadOnly = true;
            this.txb_newHeight.Size = new System.Drawing.Size(84, 22);
            this.txb_newHeight.TabIndex = 3;
            this.txb_newHeight.Text = "768";
            this.txb_newHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "New width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "New height";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 485);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.OpenFileDialog openFileDialogResizer;
        private System.Windows.Forms.TextBox txb_newHeight;
        private System.Windows.Forms.TextBox txb_newWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}