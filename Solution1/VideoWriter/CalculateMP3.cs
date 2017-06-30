using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoWriter
{
    public class CalculateMP3
    {
        public double getTotalFrames(string mp3Filename)
        {
            ShellFile so = ShellFile.FromFilePath(mp3Filename);
            double nanoseconds;
            double seconds;
            double.TryParse(so.Properties.System.Media.Duration.Value.ToString(),
            out nanoseconds);
         
            if (nanoseconds > 0)
            {
                seconds = Convert100NanosecondsToMilliseconds(nanoseconds) / 1000;
                return seconds;
            }

            return 0;
        }

        public static double Convert100NanosecondsToMilliseconds(double nanoseconds)
        {
            // One million nanoseconds in 1 millisecond, 
            // but we are passing in 100ns units...
            return nanoseconds * 0.0001;
        }
    }
}
