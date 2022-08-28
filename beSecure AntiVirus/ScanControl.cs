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

namespace beSecure_AntiVirus
{
    public partial class ScanControl : UserControl
    {
        AVengine avEngine;
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
            MessageBox.Show("Quick scan");
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
                    avEngine.CustomScan(fbd.SelectedPath);
                    String s = "";
                    foreach (var i in avEngine.getScannedFile())
                    {
                        s += i.name + "\n";
                    }

                    MessageBox.Show(s);
                }
                {

                }


            }


        }
    }
}
