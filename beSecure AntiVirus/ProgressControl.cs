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

namespace beSecure_AntiVirus
{
    public partial class ProgressControl : UserControl
    {
        public AVengine avEngine;
        public ProgressControl()
        {
            InitializeComponent();
            
        }


        public ProgressControl(string path)
        {

            avEngine = new AVengine();
            StartScannig(@path);
        }

        public void StartScannig(string path)
        {
            try
            {
                avEngine = new AVengine();
                avEngine.path = path;

                Thread myThread = new Thread(new ThreadStart(avEngine.CustomScan));
                //myThread.Join();
                myThread.Start();
                
                string temp = "";
                string prevTemp = "";


               /* while (myThread.IsAlive)
                {
                    temp = avEngine.getCurrentFile();
                    if (temp != prevTemp)
                    {
                        lblFiles.Text = temp;
                        prevTemp = temp;
                    }
                    Thread.Sleep(1000);
                }*/


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


                myThread.Abort();
            }
            catch (Exception e)
            {
                throw (e);
            }




        }




    }
}
