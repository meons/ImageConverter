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
        public NewForm()
        {
            InitializeComponent();
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
            dlgOpenFileDialog.Multiselect = true;
            dlgOpenFileDialog.Filter = "Image files (.jpg, .bmp, .tif, .gif)|*.jpg;*.bmp;*.tif;*.gif";
            if (dlgOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(dlgOpenFileDialog.FileName);
                Console.WriteLine(Path.GetExtension(dlgOpenFileDialog.FileName));
                cmbOutput.Items.Clear();
                switch (Path.GetExtension(dlgOpenFileDialog.FileName))
                {
                    case ".jpg":
                        Console.WriteLine("JPG");
                        cmbOutput.Items.Add(ImageFormat.Bmp);
                        cmbOutput.Items.Add(ImageFormat.Gif);
                        cmbOutput.Items.Add(ImageFormat.Tiff);
                        break;
                    case ".bmp":
                        Console.WriteLine("BMP");
                        cmbOutput.Items.Add(ImageFormat.Jpeg);
                        cmbOutput.Items.Add(ImageFormat.Gif);
                        cmbOutput.Items.Add(ImageFormat.Tiff);
                        break;
                    case ".tif":
                        Console.WriteLine("TIF");
                        cmbOutput.Items.Add(ImageFormat.Bmp);
                        cmbOutput.Items.Add(ImageFormat.Jpeg);
                        cmbOutput.Items.Add(ImageFormat.Gif);
                        break;
                    case ".gif":
                        Console.WriteLine("GIF");
                        cmbOutput.Items.Add(ImageFormat.Bmp);
                        cmbOutput.Items.Add(ImageFormat.Jpeg);
                        cmbOutput.Items.Add(ImageFormat.Tiff);
                        break;
                    default:
                        Console.WriteLine("Format de l'image non pris en charge");
                        break;
                }
            }
        }
    }
}
