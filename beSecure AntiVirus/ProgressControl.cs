using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using beSecure.BLL;
using System.Threading;
using System.IO;

namespace beSecure_AntiVirus
{
    public partial class ProgressControl : UserControl
    {
        public AVengine avEngine;
        string path;
        bool isQuickScan;
        public processing process;
        public ProgressControl()
        {
            InitializeComponent();
        }

        public ProgressControl(bool isQuickScane)
        {
            InitializeComponent();
            this.isQuickScan = isQuickScane;
            //avEngine = new AVengine();
        }


        public ProgressControl(string path)
        {
            InitializeComponent();
           // avEngine = new AVengine();
            this.path = path;
        }
        
        public void StartScannig()
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void AvEngine_updateForm(int id, string file)
        {
            this.lblFiles.Text = file;
            int b = avEngine.noOfFiles;
            int na = id * 100 / avEngine.noOfFiles;
            lblnoFiles.Text = id.ToString();
            CircularBar.Text = na.ToString() + "%";
            CircularBar.Value = na;
        }

        public void updateVirusList()
        {
            try
            {
                string data = "";
                foreach (var item in avEngine.getBlackListedFiles())
                {
                    data += item.name.Split('\\').Last() + "," + item.name + "," + item.time.ToString() + "\n";
                }
                
                File.AppendAllText("Viruses.txt", data);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
       //ChromeSetup.exe


        private void ProgressControl_Load(object sender, EventArgs e)
        {
            //this.BeginInvoke((MethodInvoker)this.SomeMethod);
            this.StartScannig();
        }

        

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                
                avEngine = new AVengine();
                if (isQuickScan)
                {
                    avEngine.QuickScan();
                    //avEngine.path = path;
                }
                else
                {
                    avEngine.path = path;
                }
                
                filetimer.Start();
                avEngine.getAllFiles();

                lblProcessing.Text = "File Scannning is In Progress....";
                //filetimer.Stop();
                WaitProgress.Visible = false;

                avEngine.updateForm += AvEngine_updateForm;
                if (!isQuickScan)
                {
                    avEngine.CustomScan();
                }
                //Thread scanThread = new Thread(new ThreadStart(avEngine.CustomScan));
                //scanThread.Start();

            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //scanThread.Abort();
        }

        private void stopTimer()
        {
            lblProcessing.Text = "File Scannning is In Progress....";
            filetimer.Stop();
            WaitProgress.Visible = false;
        }

        private void Filetimer_Tick(object sender, EventArgs e)
        {
            WaitProgress.Value += 1;
            if (WaitProgress.Value >= 99)
            {
                WaitProgress.Value = 1;
            }
        }
    }
}
