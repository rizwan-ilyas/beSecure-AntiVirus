﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beSecure_AntiVirus
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// this is to check github
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
            // testing commit
        }
    }
}
