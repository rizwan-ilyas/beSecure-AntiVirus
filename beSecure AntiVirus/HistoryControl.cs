using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace beSecure_AntiVirus
{
    public partial class HistoryControl : UserControl
    {
        public HistoryControl()
        {
            InitializeComponent();
        }

        private void HistoryControl_Load(object sender, EventArgs e)
        {
            try
            {
                string data = File.ReadAllText("Viruses.txt");
                string[] viruses = data.Split('\n');
                string[] header = { "Name", "Previous Location", "Date" };

                DataTable dt = new DataTable();

                foreach(var i in header)
                {
                    dt.Columns.Add(i);
                }

                foreach (var item in viruses.Reverse())
                {
                    
                    if (item != "")
                    {
                        DataRow row = dt.NewRow();
                        string[] tokens = item.Split(',');
                        for (int i = 0; i < tokens.Length; i++)
                        {
                            row[i] = tokens[i];
                        }
                        dt.Rows.Add(row);
                    }
                    
                }
                
                dataGridHistory.DataSource = dt;
                dataGridHistory.Columns[0].Width = 200;
                dataGridHistory.Columns[1].Width = 300;
                dataGridHistory.Columns[2].Width = 170;
                dataGridHistory.CurrentRow.Selected = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
