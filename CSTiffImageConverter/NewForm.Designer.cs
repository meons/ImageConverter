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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbOutput = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dlgOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenPicture);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnOpenPicture
            // 
            this.btnOpenPicture.Location = new System.Drawing.Point(30, 39);
            this.btnOpenPicture.Name = "btnOpenPicture";
            this.btnOpenPicture.Size = new System.Drawing.Size(177, 47);
            this.btnOpenPicture.TabIndex = 0;
            this.btnOpenPicture.Text = "Open a picture";
            this.btnOpenPicture.UseVisualStyleBackColor = true;
            this.btnOpenPicture.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.cmbOutput);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Convert";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmbOutput
            // 
            this.cmbOutput.FormattingEnabled = true;
            this.cmbOutput.Location = new System.Drawing.Point(30, 44);
            this.cmbOutput.Name = "cmbOutput";
            this.cmbOutput.Size = new System.Drawing.Size(177, 24);
            this.cmbOutput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status :";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dlgOpenFileDialog
            // 
            this.dlgOpenFileDialog.Filter = "Image files (.jpg, .jpeg, .tif)|*.jpg;*.jpeg;*.tif;*.tiff";
            this.dlgOpenFileDialog.Multiselect = true;
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewForm";
            this.Text = "NewForm";
            this.Load += new System.EventHandler(this.NewForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenPicture;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbOutput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog dlgOpenFileDialog;
    }
}