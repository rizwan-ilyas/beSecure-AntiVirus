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
using beSecure.Common;
using System.Threading;

namespace beSecure_AntiVirus
{
    public partial class ScanControl : UserControl
    {
        AVengine avEngine;
       // Thread quickScanThread;
        //Thread customScanThread;
        public ScanControl()
        {
            InitializeComponent();
            
            avEngine = new AVengine();
            
        }

        private void PicFullscan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Full scan");
        }

        private void PicQuickscan_Click(object sender, EventArgs e)
        {
            avEngine.QuickScan();
            String s = "White Listed \n";
            String b = "Black Listed\n";
            String n = "Not Listed\n";
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
        }

        private void PicCustomscan_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Custom scan");

            using(var fbd=new FolderBrowserDialog())
            {
                DialogResult resultdir = fbd.ShowDialog();
                if(resultdir==DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    //MessageBox.Show(fbd.SelectedPath);
                    //int noFiles = System.IO.Directory.GetFileSystemEntries(fbd.SelectedPath, ".", System.IO.SearchOption.AllDirectories).Length;
                    MessageBox.Show(noFiles.ToString());
                    avEngine.CustomScan(fbd.SelectedPath);

                    String s = "White Listed \n";
                    String b = "Black Listed\n";
                    String n = "Not Listed\n";
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



                }
                


            }


        }
    }
}
