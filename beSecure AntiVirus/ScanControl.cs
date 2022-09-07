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
using System.IO;

namespace beSecure_AntiVirus
{
    public partial class ScanControl : UserControl
    {

        AVengine avEngine;
        public scanDelegate scDel; 
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

            ProgressControl progress = new ProgressControl(true);
            addUserControl(progress);


            /*
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

            MessageBox.Show(n);*/
        }

        private void PicCustomscan_Click(object sender, EventArgs e)
        {
            // sir this is the starting code at which user selects directory
            using(var fbd=new FolderBrowserDialog())
            {
                DialogResult resultdir = fbd.ShowDialog();
                if(resultdir==DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    ProgressControl progress = new ProgressControl(fbd.SelectedPath);
                    addUserControl(progress);
                }

            }

        }

        

        private void addUserControl(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }


    }
}
