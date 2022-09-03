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
            avEngine = new AVengine();
        }


        public ProgressControl(string path)
        {
            InitializeComponent();
            avEngine = new AVengine();
            StartScannig(@path);
        }
        
        public void StartScannig(string path)
        {
            try
            {
                
                //avEngine.updateForm += AvEngine_updateForm;
                avEngine.path = path;
                avEngine.CustomScan();
                //Thread myThread = new Thread(new ThreadStart(avEngine.CustomScan));
                //myThread.Join();
                //myThread.Start();
                
                string temp = "";
                string prevTemp = "";
                


                String s = "White Listed \n";
                String b = "Black Listed\n";
                String n = "Not Listed\n";
                String a = "Scanned Listed\n";

                foreach (var i in avEngine.getWhiteListedFiles())
                {
                    s += i.name + "\n";
                }

                MessageBox.Show(s);

                foreach (var i in avEngine.getBlackListedFiles())
                {
                    b += i.name + "\n";
                }

                MessageBox.Show(b);

                foreach (var i in avEngine.getnoSignedFiles())
                {
                    n += i.name + "\n";
                }

                MessageBox.Show(n);

                foreach (var i in avEngine.getScannedFile())
                {
                    a += i.name + "\n";
                }

                MessageBox.Show(a);
                updateVirusList();

               // myThread.Abort();
            }
            catch (Exception e)
            {
                throw (e);
            }




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
            
        }

        public void setCurrentFile(String f)
        {
            lblFiles.Text = f;
        }


    }
}
