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
using beSecure.Common;

namespace beSecure_AntiVirus
{
    public partial class ProgressControl : UserControl
    {
        public AVengine avEngine;
        string path;
        int scanType;
        public processing process;
        public ProgressControl()
        {
            InitializeComponent();
            scanType = 0;
        }

        public ProgressControl(int scanType)
        {
            InitializeComponent();
            this.scanType=scanType;

        }


        public ProgressControl(string path)
        {
            InitializeComponent();
           // avEngine = new AVengine();
            this.path = path;
            scanType = 0;
        }
        
        public void StartScannig()
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void AvEngine_updateForm(int id, string file)
        {
            this.label1.Text = avEngine.noOfFiles.ToString();
            this.lblFiles.Text = file;
            int nFile = avEngine.noOfFiles-1;
            int na = id * 100 / nFile;
            lblnoFiles.Text = (id-1).ToString();
            CircularBar.Text = na.ToString() + "%";
            if (na <= 100)
            {
                CircularBar.Value = na;
            }
            
        }

        public List<VirusInfo> updateVirusList()
        {
            try
            {
                List<VirusInfo> viruses = new List<VirusInfo>();
                string data = "";
                foreach (var item in avEngine.getBlackListedFiles())
                {
                    data += item.name.Split('\\').Last() + "," + item.name + "," + item.time.ToString() + "\n";
                    viruses.Add(new VirusInfo() { name = item.name.Split('\\').Last(), previousLocation = item.name, date = item.time.ToString() });
                }
                
                File.AppendAllText("Viruses.txt", data);
                return viruses;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }
       //ChromeSetup.exe


        private void ProgressControl_Load(object sender, EventArgs e)
        {
            this.StartScannig();

        }

        

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                
                avEngine = new AVengine();
                process += filetimer.Start;
               

                if (scanType==1)
                {
                    String drive = "";
                    //DriveInfo.GetDrives()
                    //string[] s ={ "E:\\", "D:\\" } ;
                    foreach (var d in DriveInfo.GetDrives())
                    {
                        drive = @d.ToString();
                        if (drive != "C:\\")
                        {
                            process += filetimer.Start;
                            avEngine.path = drive;
                            avEngine.getAllFiles(true);

                            //process += stopTimer;
                            Invoke((MethodInvoker)(() => {
                                stopTimer();
                                Invalidate();
                                Refresh();
                            }));

                            avEngine.updateForm += AvEngine_updateForm;
                            avEngine.QuickScan();
                        }

                    }

                }
                else if (scanType==2)
                {
                    String drive = "";
                    
                    //string[] s = { "E:\\", "D:\\" };
                    foreach (var d in DriveInfo.GetDrives())
                    {
                        process += filetimer.Start;
                        drive = @d.ToString();
                        if (drive != "C:\\")
                        {
                            process += filetimer.Start;
                            avEngine.path = drive;
                            avEngine.getAllFiles();
                            Invoke((MethodInvoker)(() => {
                                stopTimer();
                                Invalidate();
                                Refresh();
                            }));

                            avEngine.updateForm += AvEngine_updateForm;
                            avEngine.CompleteScan();
                        }

                    }
                }
                else
                {
                    avEngine.path = path;
                    avEngine.getAllFiles();
                    Invoke((MethodInvoker)(() => {
                        stopTimer();
                        Invalidate();
                        Refresh();
                        avEngine.updateForm += AvEngine_updateForm;
                    }));
                    
                    avEngine.CustomScan();
                }

                
                

            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sesnder, RunWorkerCompletedEventArgs e)
        {
            //scanThread.Abort();

            CircularBar.Text = "Scanning Done";
            Thread.Sleep(100);
            HistoryControl history = new HistoryControl();
            addUserControl(history);
        }

        public void addUserControl(UserControl usrcontrl)
        {
            usrcontrl.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(usrcontrl);
            usrcontrl.BringToFront();
        }


        public void stopTimer()
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
