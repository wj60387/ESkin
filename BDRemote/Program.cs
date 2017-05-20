using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BDRemote
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string [] args)
        {

            if (args != null && args.Length>1)
            {

                string location = System.Configuration.ConfigurationManager.AppSettings["startPoint"];
                var ps = location.Split(',');
                ;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                var mainForm=new   FrmMain(args[0], !string.IsNullOrEmpty(args[1]));
                mainForm.StartPosition = FormStartPosition.Manual;
                mainForm.Location = new Point(int.Parse(ps[0]), int.Parse(ps[1]));
                Application.Run(mainForm);
                try
                {   //程序退出时，关闭连接的蓝牙听诊器
                    foreach (var stethoscope in StethoscopeManager.StethoscopeList)
                    {
                        if (stethoscope != null && stethoscope.IsConnected)
                        {
                            stethoscope.Disconnect();
                        }
                    }
                }
                catch { }
            }
           
        }
    }
}
