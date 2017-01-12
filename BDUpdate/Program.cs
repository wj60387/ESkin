using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BDUpdate
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string [] Args)
        {
            if (Args == null || Args.Length != 2)
                return;
            string SN = Args[0];
            string MAC = Args[1];
            //MessageBox.Show("SN="+SN+",MAC="+MAC);
            //return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain(SN, MAC));
        }
    }
}
