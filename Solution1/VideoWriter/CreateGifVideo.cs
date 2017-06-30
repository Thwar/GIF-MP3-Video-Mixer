using AForge.Video;
using AForge.Video.FFMPEG;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace VideoWriter
{
    public class CreateGifVideo
    {

        public void CreateGifVideoStart()
        {
            //  Bitmap image = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            //GET GIF
            var gif = Bitmap.FromFile(Form1.gifFilename);
            int width = Form1.customWidth == 0 ? gif.Width : Form1.customWidth;
            int height = Form1.customHeight == 0 ? gif.Height : Form1.customHeight;

            //Adjust size
            if (width % 2 == 1)
                width = width + 1;

            if (height % 2 == 1)
                height = height + 1;


            //Create Black frame
            Bitmap blackFrame = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(blackFrame);
            g.FillRectangle(Brushes.Black, 0, 0, width, height);


            //Get Gif frames
            PropertyItem item = gif.GetPropertyItem(20736);
            FrameDimension dim = new FrameDimension(gif.FrameDimensionsList[0]);
            int frames = gif.GetFrameCount(dim);

            //Video container
            VideoFileWriter writer = new VideoFileWriter();


            writer.Open(Form1.outputFile + ".avi", width, height, Form1.fps, VideoCodec.MPEG4, 1000000);

            float delay = 0;
            int index = 0;
            int rounded = 0;

            // write 1000 video frames
            for (int videoFrames = 0; videoFrames < Form1.totalFrames; )  // 1000 / 60 = seconds duration video
            {
                if (videoFrames >= 0)
                {
                    //CREATE GIF
                    for (int i = 0; i < frames; i++)
                    {
                        gif.SelectActiveFrame(dim, i);

                        delay = BitConverter.ToInt32(item.Value, index);
                        delay = (delay * Form1.fps) / 100;
                        rounded = (int)Math.Round(delay, 0); //how many times will still frame write to video frame 

                        for (int x = 0; x < rounded; x++)
                        {
                            var img = new Bitmap(gif, width, height);
                            writer.WriteVideoFrame(img);
                            videoFrames++;
                         //   if (Form1.NoMP3)
                                Form1.CreateVideoWorker.ReportProgress(videoFrames);

                            if (videoFrames == Form1.totalFrames)
                                goto Exit; //no more writing we are done
                            if (Form1.cancelProcess == true)
                            {
                                goto Exit;
                            }
                        }
                        index += 4;
                    }
                    index = 0;
                }
                else
                {
                    writer.WriteVideoFrame(blackFrame);
                    videoFrames++;
                    Form1.CreateVideoWorker.ReportProgress(videoFrames);
                }
            }
        Exit:
            writer.Close();
        }

    }
}
