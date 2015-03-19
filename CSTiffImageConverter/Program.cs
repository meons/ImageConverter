using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CSTiffImageConverter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NewForm());

            //TEST
            using (Image imageFile = Image.FromFile("C:/Users/Simeon/Desktop/Projet Test Unit/ImageConverter/Debug/Untitled.bmp"))
            {
                using(Bitmap bmp = new Bitmap(imageFile))
                {
                    Bitmap outImg = new Bitmap(Resizer.Resize(bmp, "propH"));
                    outImg.Save("C:/Users/Simeon/Desktop/Projet Test Unit/ImageConverter/Debug/OUTPUT.bmp");
                }
            }
        }
    }
}
