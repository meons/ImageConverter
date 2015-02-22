using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace CSTiffImageConverter
{
    class Converter
    {
        public static string[] Convert(string fileName, string outFormat)
        {
            using (Image imageFile = Image.FromFile(fileName))
            {
                FrameDimension frameDimensions = new FrameDimension(imageFile.FrameDimensionsList[0]);

                // Gets the number of pages from the source image (if multipage)
                int frameNum = imageFile.GetFrameCount(frameDimensions);
                string[] paths = new string[frameNum];

                for (int frame = 0; frame < frameNum; frame++)
                {
                    // Selects one frame at a time and save as destinsation format
                    imageFile.SelectActiveFrame(frameDimensions, frame);

                    using (Bitmap bmp = new Bitmap(imageFile))
                    {
                        paths[frame] = String.Format("{0}\\{1}{2}." + outFormat,
                                                     Path.GetDirectoryName(fileName),
                                                     Path.GetFileNameWithoutExtension(fileName),
                                                     frame);
                        bmp.Save(paths[frame]);
                    }
                }

                return paths;
            }
        }
    }
}
