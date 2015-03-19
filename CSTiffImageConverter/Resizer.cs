using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CSTiffImageConverter
{
    class Resizer
    {
        public static Bitmap Resize(Bitmap image, string option)
        {
            int newHeigth = 1024;
            int newWidth = 768;
            int ratio = 0;

            // If image is smaller than new dimension, it will not be converted to preserve quality
            if (image.Height < newHeigth && image.Width < newWidth)
            {
                Console.WriteLine("Image is already smaller than 1024x728 !");
                return image;
            }

            // If image heigth is smaller than 1024
            if (image.Height < newHeigth)
            {
                ratio = newWidth/image.Width;
                return (Bitmap) (new Bitmap(image, new Size(ratio * image.Height, newWidth)));
            }

            // If image width is smaller than 768
            if (image.Width < newWidth)
            {
                ratio = newHeigth / image.Height;
                return (Bitmap) (new Bitmap(image, new Size(newHeigth, ratio * image.Width)));
            }

            // propH = proportions based on heigth -> 1024
            // propW = proportions based on width -> 768
            switch(option)
            {
                case "propH":

                    break;
                case "propW":
                    break;
                default:
                    break;
            }

            return image;
        }
    }
}
