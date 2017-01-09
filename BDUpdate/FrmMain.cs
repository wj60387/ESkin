using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BDUpdate
{
    public partial class FrmMain : Form
    {
         private bool isMouseDown = false;
        private Point FormLocation;     //form的location
        private Point mouseOffset;      //鼠标的按下位置
        public FrmMain()
        {
            InitializeComponent();
            this.Load += FrmMain_Load;
        }

        void FrmMain_Load(object sender, EventArgs e)
        {
            Down();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            var point = PointToScreen(MousePosition);
            this.MaximumSize = Screen.FromPoint(point).WorkingArea.Size;
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                FormLocation = this.Location;
                mouseOffset = Control.MousePosition;
            }
        }
        string SN = "90E52F4D-BCA5-422F-897A-A8D3CEF35DBF";//System.Configuration.ConfigurationManager.AppSettings["SN"];
        string MAC = "20:47:47:C8:CB:42";//System.Configuration.ConfigurationManager.AppSettings["MAC"];
        string MainExeName = System.Configuration.ConfigurationManager.AppSettings["MainExeName"];
        public   AuscultationService.AuscultationServiceClient remoteService = new AuscultationService.AuscultationServiceClient("WSHttpBinding_IAuscultationService");
        void Down()
        {
            ExecuteProcess += FrmMain_ExecuteProcess;
            ToltlProcess += FrmMain_ToltlProcess;
            Thread thread = new Thread(() =>
            {
                using (OperationContextScope scope = new OperationContextScope(remoteService.InnerChannel))
                {
                    MessageHeader header = MessageHeader.CreateHeader("SN", "http://tempuri.org", SN);
                    OperationContext.Current.OutgoingMessageHeaders.Add(header);
                    header = MessageHeader.CreateHeader("MAC", "http://tempuri.org", MAC);
                    OperationContext.Current.OutgoingMessageHeaders.Add(header);
                    string sql = @"SELECT  Version FROM VersionMajor WHERE Enable=1";
                    var ds = remoteService.ExecuteDataset(sql, null);
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        var banben = ds.Tables[0].Rows[0][0] + "";
                        sql = @"SELECT Value FROM SysConst WHERE KeyName='VersionFileDir'";
                        var Dir = remoteService.ExecuteScalar(sql, null);
                        var majorDir = Dir + "\\" + banben;

                        sql = "select * from VersionFile where Version={0}";
                        var dsFile = remoteService.ExecuteDataset(sql, new string[] { banben });
                        int i = 0;
                        foreach (DataRow row in dsFile.Tables[0].Rows)
                        {
                            i++;
                            var hash = row["FileHash"] + "";
                            var fileName = row["FileName"] + "";
                            var fileRelativePath = row["FileRelativePath"] + "";
                            if (ToltlProcess != null)
                            {
                                ToltlProcess(fileName);
                            }
                            var localFilePath = Path.Combine(Application.StartupPath, fileRelativePath);
                            var remoteFilePath = Path.Combine(majorDir, fileRelativePath);
                            var fileSize = remoteService.GetFileLength(remoteFilePath);
                            //下载文件
                            if (!Directory.Exists(Path.GetDirectoryName(localFilePath)))
                            {
                                Directory.CreateDirectory(Path.GetDirectoryName(localFilePath));
                            }
                            using (var stream = new FileStream(localFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
                            {
                                long position = 0;
                                while (position < fileSize)
                                {
                                    var bytes = remoteService.DownLoadFile(remoteFilePath, position, 24 * 1024);
                                    position += bytes.Length;
                                    stream.Write(bytes, 0, bytes.Length);

                                    if (ExecuteProcess != null)
                                        ExecuteProcess((int)(position * 100 / fileSize), 100, i, dsFile.Tables[0].Rows.Count);
                                }
                                stream.Close();

                            }
                            
                        }
                    }
                }


            });
            thread.Start();
        }

       
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            int _x = 0;
            int _y = 0;
            if (isMouseDown)
            {
                Point pt = Control.MousePosition;
                _x = mouseOffset.X - pt.X;
                _y = mouseOffset.Y - pt.Y;

                this.Location = new Point(FormLocation.X - _x, FormLocation.Y - _y);
            }

        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public event Action<int, int,int,int> ExecuteProcess;
        public event Action<string> ToltlProcess;
        private void btnDown_Click(object sender, EventArgs e)
        {
           
           //Process[] ps = Process.GetProcessesByName(MainExeName);
           //foreach (Process p in ps)
           //{
           //    p.WaitForExit();
           //}
           Down();
        }

        void FrmMain_ExecuteProcess(int value,int maxvalue,  int tvalue, int total)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                this.processBarEx1.Value = maxvalue;
                this.processBarEx1.Value = value;
                this.lblProcess.Text = string.Format("当前进度:{0}/{1},总进度:{2}/{3}", value, maxvalue, tvalue,total);

                if (value == maxvalue&&tvalue == total)
                {
                    var exe = Path.Combine(Application.StartupPath, "BDAuscultation.exe");
                    System.Diagnostics.Process.Start(exe);
                    this.Close();
                    Application.Exit();
                }
            }));
        }
        void FrmMain_ToltlProcess(string fileName)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                this.lblMsg.Text = string.Format("正在更新文件:{0}...",fileName);
               

            }));
        }
        private void btnMin_Click(object sender, EventArgs e)
        {

        }

        

         
    }
}
