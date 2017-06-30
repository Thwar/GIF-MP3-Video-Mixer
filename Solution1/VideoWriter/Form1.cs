

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using VideoWriter.Properties;

namespace VideoWriter
{
    public partial class Form1 : Form
    {

        //CONST VALUES
        static public int totalFrames = 100; //duration of video in frames  / 60 = seconds duration video
        public const int fps = 30;

        static public bool cancelProcess;
        static public string gifFilename;
        static public string mp3Filename;
        static public string videoName;
        static public string outputFile;
        static public string OutputFolder = "C:/Videos";
        bool hasError;
        public static bool NoMP3 = false;
        public readonly static BackgroundWorker CreateVideoWorker = new BackgroundWorker();

        public static int customWidth ;//= 500;
        public static int customHeight;// = 500;
      
        public Form1()
        {
            InitializeComponent();
            resetForm();
            CreateVideoWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork_1);
            CreateVideoWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged_1);
            CreateVideoWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
            textBox1.Text = "Default folder video output location: \r\n" + OutputFolder;
            FolderOutputPath.Text = OutputFolder;
        }

        private void buttonCreateVideo_Click(object sender, EventArgs e)
        {
            //Create default path
            System.IO.Directory.CreateDirectory(OutputFolder);

           // if (NoMP3)
              //  totalFrames = 200; //duration of video if no audio

            hasError = false;
            if (gifFilename == null)
            {
                GifLabel.Text = "Select a GIF file!";
                hasError = true;
                statusText.Text = "Error";
                statusText.ForeColor = Color.Red;
                GifLabel.ForeColor = Color.Red;
            }

            if (mp3Filename == null && NoMP3 == false)
            {
                MP3Label.Text = "Select an MP3 file!";
                hasError = true;
                statusText.Text = "Error";
                statusText.ForeColor = Color.Red;
                MP3Label.ForeColor = Color.Red;
            }


            if (!CreateVideoWorker.IsBusy && hasError == false)
            {
                textBox1.Text = "";
                resetForm();
                totalFramesLabel.Text = totalFrames.ToString();
                GIFButton.Enabled = false;
                MP3Button.Enabled = false;
                CreateVideoButton.Enabled = false; 
                statusText.Text = "Converting GIF to MP4...";
                statusText.ForeColor = Color.Black;
                statusText2.Text = "Converting GIF to MP4...";
                label2.Text = "frames out of "; 
                cancelProcess = false;

                progressBar1.Maximum = totalFrames;
                progressBar1.Step = 1;
                progressBar1.Value = 0;
                CreateVideoWorker.WorkerReportsProgress = true;
                CreateVideoWorker.WorkerSupportsCancellation  = true;

                CreateVideoWorker.RunWorkerAsync();
            }
        }


        #region createGifVideo Worker
        public void backgroundWorker_DoWork_1(object sender, DoWorkEventArgs e)
        {
            CreateGifVideo create = new CreateGifVideo();

           // File.Create(Form1.outputFile + ".avi").Dispose();

            create.CreateGifVideoStart();        
        }

        public  void backgroundWorker_ProgressChanged_1(object sender, ProgressChangedEventArgs e)
        {
           // percentage = 100 * (e.ProgressPercentage) / totalFrames;
            progressBar1.Value = e.ProgressPercentage;
            label1.Text = e.ProgressPercentage.ToString();
        }


        public void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {            
            if (cancelProcess == false )
            {

                statusText.Text = "Muxing video and mp3 audio...";
                statusText2.Text = "Muxing video and mp3 audio...";
                CancelButton.Enabled = false;
                MuxVideoAudio m = new MuxVideoAudio(this);
                 m.MuxVideoAudioStart();
                 progressBar1.Style = ProgressBarStyle.Marquee;
                 progressBar1.MarqueeAnimationSpeed = 30;
            }
        }

        #endregion


        delegate void SetLabelCallback(string text);
        private void SetStatusText(string text)
        {
            if (InvokeRequired)
            {
                SetLabelCallback d = new SetLabelCallback(SetStatusText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                statusText.Text = text;
            }
        }


        private void CancelButtonClick(object sender, EventArgs e)
        {
            resetForm();
            cancelProcess = true;
            statusText.Text = "Canceled";           
        }

        public  void resetForm()
        {
            statusText2.Text = "";
            statusText.Text = "";
            GifLabel.Text = "";
            MP3Label.Text = "";
            totalFramesLabel.Text = "";
            label1.Text = "";
            GifLabel.Text = "";
            MP3Label.Text = "";
            GIFButton.Enabled = true;
            CancelButton.Enabled = true;
            CreateVideoButton.Enabled = true;
            label2.Text = "";

            if (!NoMP3)
                MP3Button.Enabled = true; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select your GIF image";
            openFileDialog1.Filter = "gif files (*.gif)|*.gif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                gifTextbox.Text = openFileDialog1.FileName;
                gifFilename = openFileDialog1.FileName;
                videoName = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName);

                outputFile = OutputFolder + "\\" + videoName ;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog2.Title = "Select your MP3 file";
            openFileDialog2.Filter = "mp3 files (*.mp3)|*.mp3";

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                mp3Textbox.Text = openFileDialog2.FileName;
                mp3Filename = openFileDialog2.FileName;
                CalculateMP3 mp3 = new CalculateMP3();
                totalFrames = (int)mp3.getTotalFrames(mp3Filename) * fps;
                
            }
        }

        private void gifSoundVideoConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thomas Rosales 2014 mon mon", "GifMusicWebm Converter v1.0",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            NoMP3 = checkBox1.Checked ? true : false;
            MP3Button.Enabled = checkBox1.Checked ? false : true;
            videoDuration.Enabled = checkBox1.Checked ? true : false; 
        }

        private void button1_Click(object sender, EventArgs e)
        {       
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                OutputFolder = folderBrowserDialog1.SelectedPath;
                textBox1.Text = "Default folder video output location: \r\n" + OutputFolder;
                outputFile = OutputFolder + "\\" + videoName;
                FolderOutputPath.Text = OutputFolder;
            }
        }

        private void videoDuration_ValueChanged(object sender, EventArgs e)
        {
            totalFrames = (int)videoDuration.Value * fps; 


            
        }
    }
}
