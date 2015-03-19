using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CSTiffImageConverter
{
    class Resizer
    {
        // Resize proportionaly an image by max width and height parameters
        public static Bitmap Resize(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width; // Width ratio
            var ratioY = (double)maxHeight / image.Height; // Height ratio
            // Choose the min ratio for never crop the image
            var ratio = Math.Min(ratioX, ratioY);

            // Set new dimensions with min ratio
            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            // Create new sized image
            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }
    }
}
