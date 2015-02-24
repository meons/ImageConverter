using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

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

        /// <summary>
        /// Converts any imagae(s) to a tiff image.
        /// </summary>
        /// <param name="fileNames">
        /// String array having full name to selected images.
        /// </param>
        /// <returns>
        /// String array having full name of tiff image.
        /// </returns>
        public static string[] MergeToMultipleImagesToTiff(string[] fileNames)
        {
            EncoderParameters encoderParams = new EncoderParameters(1);
            ImageCodecInfo tiffCodecInfo = ImageCodecInfo.GetImageEncoders()
                .First(ie => ie.MimeType == "image/tiff");

            string[] tiffPaths = null; 

            tiffPaths = new string[1];
            Image tiffImg = null;
            try
            {
                for (int i = 0; i < fileNames.Length; i++)
                {
                    if (i == 0)
                    {
                        tiffPaths[i] = String.Format("{0}\\{1}{2}.tif",
                            Path.GetDirectoryName(fileNames[i]),
                            Path.GetFileNameWithoutExtension(fileNames[i]),
                            i);

                        // Initialize the first frame of multipage tiff.
                        tiffImg = Image.FromFile(fileNames[i]);
                        encoderParams.Param[0] = new EncoderParameter(
                           Encoder.SaveFlag, (long)EncoderValue.MultiFrame);
                        tiffImg.Save(tiffPaths[i], tiffCodecInfo, encoderParams);
                    }
                    else
                    {
                        // Add additional frames.
                        encoderParams.Param[0] = new EncoderParameter(
                            Encoder.SaveFlag, (long)EncoderValue.FrameDimensionPage);
                        using (Image frame = Image.FromFile(fileNames[i]))
                        {
                            tiffImg.SaveAdd(frame, encoderParams);
                        }
                    }

                    if (i == fileNames.Length - 1)
                    {
                        // When it is the last frame, flush the resources and closing.
                        encoderParams.Param[0] = new EncoderParameter(
                            Encoder.SaveFlag, (long)EncoderValue.Flush);
                        tiffImg.SaveAdd(encoderParams);
                    }
                }
            }
            finally
            {
                if (tiffImg != null)
                {
                    tiffImg.Dispose();
                    tiffImg = null;
                }
            }
            return tiffPaths;
        }
    
    }
}
