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
        public ProgressControl()
        {
            InitializeComponent();
        }
        string path;
   

        public ProgressControl(string path)
        {
            InitializeComponent();
            avEngine = new AVengine();
            //StartScannig(@path);
            this.path = path;
        }
        
        public void StartScannig(string path)
        {

            backgroundWorker1.RunWorkerAsync();



        }

        private void AvEngine_updateForm1(int id, string Folder)
        {
            this.lblFiles.Text = Folder;
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

        private void AvEngine_updateForm(int id, string Folder)
        {
            lblFiles.Text = Folder;
        }

      
        private void ProgressControl_updateForm(int progress, string folderName)
        {
            this.lblFiles.Text = folderName;
        }

        private void ProgressControl_Load(object sender, EventArgs e)
        {

            //this.BeginInvoke((MethodInvoker)this.SomeMethod);

            this.StartScannig(this.path);
            
        }

        public void setCurrentFile(String f)
        {
            lblFiles.Text = f;
        }

        private void CircularBar_Click(object sender, EventArgs e)
        {

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                avEngine = new AVengine();
                //avEngine.updateForm += AvEngine_updateForm;
                avEngine.path = path;
                avEngine.updateForm += AvEngine_updateForm1;
                avEngine.CustomScan();
                //Thread myThread = new Thread(new ThreadStart(avEngine.CustomScan));
                //myThread.Join();
                //myThread.Start();

                while (Thread.CurrentThread.IsAlive)
                {
                    this.lblFiles.Text += avEngine.getCurrentFile();
                }


                string temp = "";
                string prevTemp = "";



                //String s = "White Listed \n";
                //String b = "Black Listed\n";
                //String n = "Not Listed\n";
                //String a = "Scanned Listed\n";

                //foreach (var i in avEngine.getWhiteListedFiles())
                //{
                //    s += i.name + "\n";
                //}

                //MessageBox.Show(s);

                //foreach (var i in avEngine.getBlackListedFiles())
                //{
                //    b += i.name + "\n";
                //}

                //MessageBox.Show(b);

                //foreach (var i in avEngine.getnoSignedFiles())
                //{
                //    n += i.name + "\n";
                //}

                //MessageBox.Show(n);

                //foreach (var i in avEngine.getScannedFile())
                //{
                //    a += i.name + "\n";
                //}

                //MessageBox.Show(a);
                //updateVirusList();

            }
            catch (Exception eee)
            {
                throw (eee);
            }
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
