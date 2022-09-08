using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beSecure_AntiVirus
{
    public partial class mainForm : Form
    {
        public Image normalImg { get { return normalImg; } set { normalImg = value; } }
        public Image hoverImg { get { return hoverImg; } set { hoverImg = value; } }


        public mainForm()
        {
            InitializeComponent();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //setTimeNow();
            //lbldays.Text = getDays();
        }

        //private static string getDays()
        //{
            
        //    return Convert.ToDateTime("date").ToString();
        //    //return  (DateTime.Now - Convert.ToDateTime(ConfigurationManager.AppSettings.Get("date"))).Days;
        //}

        //public static void setTimeNow()
        //{
        //    Configuration configration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        //    configration.AppSettings.Settings["date"].Value = "10/09/2022";
        //    configration.Save(ConfigurationSaveMode.Modified);
        //    //ConfigurationManager.RefreshSection("appSettings");
        //}




        private void Label4_Click(object sender, EventArgs e)
        {

        }
        //where is code o

        private void addUserControl(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }

        private void BtnScan_Click(object sender, EventArgs e)
        {
            ScanControl scan = new ScanControl();
            addUserControl(scan);
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            HistoryControl history = new HistoryControl();
            addUserControl(history);
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            SettingsControl settings = new SettingsControl();
            addUserControl(settings);
        }
    }
}
