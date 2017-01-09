using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //90E52F4D-BCA5-422F-897A-A8D3CEF35DBF","MachineCode":"20:47:47:C8:CB:42
        }
        string SN = "90E52F4D-BCA5-422F-897A-A8D3CEF35DBF";
        string MAC = "20:47:47:C8:CB:42";
        public   AuscultationService.AuscultationServiceClient remoteService = new AuscultationService.AuscultationServiceClient("WSHttpBinding_IAuscultationService");
        void Down()
        {
            using (OperationContextScope scope = new OperationContextScope(remoteService.InnerChannel))
            {
                MessageHeader header = MessageHeader.CreateHeader("SN", "http://tempuri.org", SN);
                OperationContext.Current.OutgoingMessageHeaders.Add(header);
                header = MessageHeader.CreateHeader("MAC", "http://tempuri.org", MAC);
                OperationContext.Current.OutgoingMessageHeaders.Add(header);
                string sql = "";
            }
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
        public event Action<int> ExecuteProcess;
        private void btnDown_Click(object sender, EventArgs e)
        {
            ExecuteProcess += FrmMain_ExecuteProcess;

            Thread thread = new Thread(() =>
            {
               
                for (int i = 1; i <= 100; i++)
                {
                    Thread.Sleep(100);
                    if (ExecuteProcess != null)
                        ExecuteProcess(i);
                }

            });
            thread.Start();
            
        }

        void FrmMain_ExecuteProcess(int i)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                 this.processBarEx1.Value = i;
            }));
        }

         
    }
}
