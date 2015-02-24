using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSTiffImageConverter
{
    public partial class NewForm : Form
    {
        public string selectedFormat;

        public NewForm()
        {
            InitializeComponent();
            selectedFormat = "";
        }

        private void NewForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            dlgOpenFileDialog.Multiselect = false;
            dlgOpenFileDialog.Filter = "Image files (.jpg, .bmp, .tif, .gif)|*.jpg;*.bmp;*.tif;*.gif";
            if (dlgOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(dlgOpenFileDialog.FileName);
                Console.WriteLine(Path.GetExtension(dlgOpenFileDialog.FileName));

                lblStatus.Text = dlgOpenFileDialog.FileName + " selected";

                // Clear combobox items on each image opening
                cmbOutput.Text = "";
                cmbOutput.Items.Clear();
                
                // Get image format extention
                selectedFormat = Path.GetExtension(dlgOpenFileDialog.FileName);

                // Switch case to set the corrects output formats in combobox
                switch (Path.GetExtension(dlgOpenFileDialog.FileName))
                {
                    case ".jpg":
                        Console.WriteLine("JPG");
                        cmbOutput.Items.Add("bmp");
                        cmbOutput.Items.Add("gif");
                        cmbOutput.Items.Add("tif");
                        break;
                    case ".bmp":
                        Console.WriteLine("BMP");
                        cmbOutput.Items.Add("jpg");
                        cmbOutput.Items.Add("gif");
                        cmbOutput.Items.Add("tif");
                        break;
                    case ".tif":
                        Console.WriteLine("TIF");
                        cmbOutput.Items.Add("bmp");
                        cmbOutput.Items.Add("jpg");
                        cmbOutput.Items.Add("gif");
                        break;
                    case ".gif":
                        Console.WriteLine("GIF");
                        cmbOutput.Items.Add("bmp");
                        cmbOutput.Items.Add("jpg");
                        cmbOutput.Items.Add("tif");
                        break;
                    default:
                        Console.WriteLine("Select a supported image format !");
                        break;
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string inFormat = selectedFormat;
            string outFormat = cmbOutput.Text;

            // Do nothing if image wasn't selected
            if (cmbOutput.Text != "")
            {
                Converter.Convert(dlgOpenFileDialog.FileName, outFormat);
                lblStatus.Text = " Convertion from " + selectedFormat + " to " + outFormat + " done !";
            }
        }

        private void btnChooseImages_Click(object sender, EventArgs e)
        {
            dlgOpenMultipleFilesDialog.Multiselect = true;
            dlgOpenMultipleFilesDialog.Filter = "Image files (.jpg, .bmp, .tif, .gif)|*.jpg;*.bmp;*.tif;*.gif";

            if (dlgOpenMultipleFilesDialog.ShowDialog() == DialogResult.OK)
            {
                lblStatusMultipageConversion.Text = dlgOpenMultipleFilesDialog.FileNames.Length.ToString() + " Files selected.";
            }
        }

        private void btnMergeToTiff_Click(object sender, EventArgs e)
        {
            try
            {
                Converter.MergeToMultipleImagesToTiff(dlgOpenMultipleFilesDialog.FileNames);
                lblStatusMultipageConversion.Text = "Tiff merging completed.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }
    }
}
