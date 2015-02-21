using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace CSTiffImageConverter
{
    class TiffConverter
    {

        // Function to convert from Tiff to Jpg
        public static string[] ConvertTiffToJpg(string fileName)
        {
            using (Image imageFile = Image.FromFile(fileName))
            {
                FrameDimension frameDimensions = new FrameDimension(imageFile.FrameDimensionsList[0]);

                // Gets the number of pages from the tiff image (if multipage)
                int frameNum = imageFile.GetFrameCount(frameDimensions);
                string[] paths = new string[frameNum];

                for (int frame = 0; frame < frameNum; frame++)
                {
                    // Selects one frame at a time and save as jpeg.
                    imageFile.SelectActiveFrame(frameDimensions, frame);

                    using (Bitmap bmp = new Bitmap(imageFile))
                    {
                        paths[frame] = String.Format("{0}\\{1}{2}.jpg",
                                                     Path.GetDirectoryName(fileName),
                                                     Path.GetFileNameWithoutExtension(fileName),
                                                     frame);
                        bmp.Save(paths[frame], ImageFormat.Jpeg);
                    }
                }

                return paths;
            }
        }

        // Function to convert from Tiff to Gif
        public static string[] ConvertTiffToGif(string fileName)
        {
            using (Image imageFile = Image.FromFile(fileName))
            {
                FrameDimension frameDimensions = new FrameDimension(imageFile.FrameDimensionsList[0]);

                // Gets the number of pages from the tiff image (if multipage)
                int frameNum = imageFile.GetFrameCount(frameDimensions);
                string[] paths = new string[frameNum];

                for (int frame = 0; frame < frameNum; frame++)
                {
                    // Selects one frame at a time and save as gif.
                    imageFile.SelectActiveFrame(frameDimensions, frame);

                    using (Bitmap bmp = new Bitmap(imageFile))
                    {
                        paths[frame] = String.Format("{0}\\{1}{2}.gif",
                                                     Path.GetDirectoryName(fileName),
                                                     Path.GetFileNameWithoutExtension(fileName),
                                                     frame);
                        bmp.Save(paths[frame], ImageFormat.Gif);
                    }
                }

                return paths;
            }
        }

        // Function to convert from Tiff to Bmp
        public static string[] ConvertTiffToBmp(string fileName)
        {
            using (Image imageFile = Image.FromFile(fileName))
            {
                FrameDimension frameDimensions = new FrameDimension(imageFile.FrameDimensionsList[0]);

                // Gets the number of pages from the tiff image (if multipage)
                int frameNum = imageFile.GetFrameCount(frameDimensions);
                string[] paths = new string[frameNum];

                for (int frame = 0; frame < frameNum; frame++)
                {
                    // Selects one frame at a time and save as bmp.
                    imageFile.SelectActiveFrame(frameDimensions, frame);

                    using (Bitmap bmp = new Bitmap(imageFile))
                    {
                        paths[frame] = String.Format("{0}\\{1}{2}.bmp",
                                                     Path.GetDirectoryName(fileName),
                                                     Path.GetFileNameWithoutExtension(fileName),
                                                     frame);
                        bmp.Save(paths[frame], ImageFormat.Bmp);
                    }
                }

                return paths;
            }
        }
    }
}
