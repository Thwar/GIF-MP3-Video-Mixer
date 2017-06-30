using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VideoWriter
{

    public class MuxVideoAudio 
    {
        //  Thread waitThread;
        Process myProcess;
        BackgroundWorker MuxVideoAudioWorker;
        private Form1 formParent;

        public MuxVideoAudio(Form1 form) 
        {
            MuxVideoAudioWorker = new BackgroundWorker();
            MuxVideoAudioWorker.DoWork += new DoWorkEventHandler(MuxVideoAudioWorker_DoWork);
            MuxVideoAudioWorker.ProgressChanged += new ProgressChangedEventHandler(MuxVideoAudioWorker_ProgressChanged);
            MuxVideoAudioWorker.RunWorkerCompleted += MuxVideoAudioWorker_RunWorkerCompleted;
            formParent = form;  
        }

        private void MuxVideoAudioWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            formParent.progressBar1.Style = ProgressBarStyle.Continuous;
            formParent.progressBar1.Value = formParent.progressBar1.Maximum;    
            formParent.resetForm();
            formParent.statusText.Text = "Complete";
            SetText("\r\nDone!", formParent.textBox1);
            SetText("\r\nVideo saved as: " + Form1.outputFile +".webm", formParent.textBox1);
        }

        private void MuxVideoAudioWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MuxVideoAudioWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            myProcess.WaitForExit();       
            myProcess.Close();
        }
   

        public void MuxVideoAudioStart()
        {
            string fileargs;
            //VIDEO + AUDIO
            if (Form1.NoMP3 == false)
            {
                //fileargs = "-i   \"" + Form1.mp3Filename.ToString() + "\" -i " + Form1.outputFile + ".avi -vcodec libvpx -acodec libvorbis -cpu-used 5 -threads 8 -y " + Form1.outputFile + ".webm";   
                   fileargs = "-i   \"" + Form1.mp3Filename.ToString() + "\" -i " + Form1.outputFile + ".avi -vcodec libvpx -acodec libvorbis -cpu-used 5 -threads 8 -y " + Form1.outputFile + ".webm";
                //-ss 0  -->start from 0 seconds
              //  fileargs = "-ss 60 -t 100  -i   \"" + Form1.mp3Filename.ToString() + "\" -i " + Form1.outputFile + ".avi -codec copy -shortest " + Form1.outputFile + "+.webm";

            }
            else
            {
                fileargs = "-i " + Form1.outputFile + ".avi -vcodec libvpx -acodec libvorbis -cpu-used 5 -threads 8 -y " + Form1.outputFile + ".webm";       
            }

            myProcess = new Process();
            myProcess.StartInfo.FileName = @"ffmpeg\ffmpeg.exe";
            myProcess.StartInfo.Arguments = fileargs;
            myProcess.StartInfo.UseShellExecute = false;
            myProcess.StartInfo.CreateNoWindow = true;
            myProcess.EnableRaisingEvents = true;
            //myProcess.Exited += VideoFinished;

            //read data hopefully
            myProcess.StartInfo.RedirectStandardOutput = true;
            myProcess.StartInfo.RedirectStandardError = true;
            myProcess.StartInfo.RedirectStandardInput = true;

            myProcess.OutputDataReceived += new DataReceivedEventHandler(ReadOutput);
            myProcess.ErrorDataReceived += new DataReceivedEventHandler(ReadOutput);

            myProcess.Start();

            myProcess.BeginOutputReadLine();
            myProcess.BeginErrorReadLine();

            MuxVideoAudioWorker.WorkerReportsProgress = true;
            MuxVideoAudioWorker.WorkerSupportsCancellation = true;
            MuxVideoAudioWorker.RunWorkerAsync();
            //  var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
            //  ffMpeg.ConvertMedia("final_video.avi", null, "myvideoweb.webm", Format.webm, null);
        }

        private void ReadOutput(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                var stdout = e.Data + "\r\n";
                SetText(stdout, formParent.textBox1);
            }
        }


        delegate void SetTextCallback(string text, TextBox txt);
        private void SetText(string text, TextBox txt)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (txt.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                txt.Invoke(d, new object[] { text, txt });
            }
            else
            {
                txt.Text += text;
                txt.SelectionStart = txt.Text.Length - 1;
                txt.ScrollToCaret();
            }
        }
    }
}
