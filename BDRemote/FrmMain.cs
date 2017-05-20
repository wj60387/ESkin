using BDAuscultation.Commucation;
using BDRemote.Forms;
using ProtocalData.Protocol;
using ProtocalData.Protocol.Derive;
using ProtocalData.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BDRemote
{

    //消息 Code
    //事件 就绪 开启音频 接收音频 关闭音频 


    public partial class FrmMain : Form
        , IHandleMessage<RYHDLCode>
        , IHandleMessage<RYHXXCode>
        , IHandleMessage<RMessageCode>
        , IHandleMessage<RReadyCode>
        , IHandleMessage<RStartAudioCode>
        , IHandleMessage<RTransAudioCode>
        , IHandleMessage<RStopAudioCode>
        , IHandleMessage<RExitCode>
    {
        public void HandleMessage(RMessageCode message)
        {
            ShowMsg(message.Msg);
        }

        public void HandleMessage(RReadyCode message)
        {
            if (isOrder)
            {
                SuperSocket.Send(new RStartAudioCode());
                ShowMsg("马上开始发送数据...");
                Thread.Sleep(100);
                Thread thread = new Thread(() =>
                {
                    var stethoscope = StethoscopeManager.StethoscopeList.Where(s => s.IsConnected).First();
                    while (!isStop)
                    {

                        byte[] packet = new byte[128];
                        int bytesRead = stethoscope.AudioInputStream.Read(packet, 0, packet.Length);
                        if (bytesRead <= 0)
                        {
                            Thread.Sleep(1);
                            continue;
                        }
                        var rcsypCode = new RCSYPCode();
                        rcsypCode.bytes = packet.Take(bytesRead).ToArray();
                        var rcsypBytes = ProtocalData.Utilities.SerializaHelper.Serialize(rcsypCode);
                        SuperSocket.Send(rcsypBytes);
                        Thread.Sleep(1);
                    }
                });
                thread.Start();
            }
            else
            {
                ShowMsg("马上开始接收数据...");
            }
        }
        public void HandleMessage(RStartAudioCode message)
        {
            ShowMsg(string.Format("远程听诊开始接收数据..."));

            this.Invoke(new MethodInvoker(() =>
                {
                    var stethoscope = StethoscopeManager.StethoscopeList.Where(s => s.IsConnected).First();
                    stethoscope.StartAudioOutput();
                }));
        }
        public void HandleMessage(RTransAudioCode message)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                var stethoscope = StethoscopeManager.StethoscopeList.Where(s => s.IsConnected).First();
                stethoscope.AudioOutputStream.Write(message.Bytes, 0, message.Bytes.Length);
            }));
        }
        public void HandleMessage(RStopAudioCode message)
        {
        }
        public void HandleMessage(RExitCode message)
        {
            ShowMsg(string.Format("远程听诊停止接收数据..."));
            this.Invoke(new MethodInvoker(() =>
               {
                   var stethoscope = StethoscopeManager.StethoscopeList.Where(s => s.IsConnected).First();
                   stethoscope.StopAudioOutput();
               }));
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            SuperSocket.Send(new  RExitCode());

        }
        private bool isMouseDown = false;
        private Point FormLocation;     //form的location
        private Point mouseOffset;      //鼠标的按下位置
        public static string serverUrl = System.Configuration.ConfigurationManager.AppSettings["serverUrl"];
        public SupSocket SuperSocket = new SupSocket(serverUrl);
        public FrmMain(string remoteID, bool isRequest)
        {
            base.SetStyle(
                    ControlStyles.UserPaint |                      // 控件将自行绘制，而不是通过操作系统来绘制
                    ControlStyles.OptimizedDoubleBuffer |          // 该控件首先在缓冲区中绘制，而不是直接绘制到屏幕上，这样可以减少闪烁
                    ControlStyles.AllPaintingInWmPaint |           // 控件将忽略 WM_ERASEBKGND 窗口消息以减少闪烁
                    ControlStyles.ResizeRedraw |                   // 在调整控件大小时重绘控件
                    ControlStyles.SupportsTransparentBackColor,    // 控件接受 alpha 组件小于 255 的 BackColor 以模拟透明
                    true);                                         // 设置以上值为 true
            base.UpdateStyles();
            InitializeComponent();
            this.Load += FrmMain_Load;
            this.LocationChanged += FrmMain_LocationChanged;
            SuperSocket.MessageReceived += SuperSocket_MessageReceived;
            SuperSocket.DataReceived += SuperSocket_DataReceived;
            SuperSocket.Closed += SuperSocket_Closed;
            SuperSocket.Opened += SuperSocket_Opened;

            SuperSocket.OpenSocket(remoteID);
            //ucTextBoxEx1.Text = StethoscopeManager.StethoscopeList.First().Name;
            radioButtonEx1.Checked = isRequest;
            radioButtonEx2.Checked = !isRequest;
            foreach (var item in StethoscopeManager.StethoscopeList)
            {
                ucTextBoxEx1.Items.Add(item.Name);
            }
        }

        void SuperSocket_Opened(object sender, EventArgs e)
        {
            ShowMsg("服务器连接成功...", false);
        }

        void SuperSocket_Closed(object sender, EventArgs e)
        {
            ShowMsg("服务器连接失败...", true);
        }

        void SuperSocket_DataReceived(object sender, WebSocket4Net.DataReceivedEventArgs e)
        {
            try
            {
                var code = SerializaHelper.DeSerialize<CodeBase>(e.Data);
                if (code == null) ShowMsg("无法处理的未知消息类型");
                //消息分发处理
                var interFaces = this.GetType().GetInterfaces().Where(iface => iface.Name == "IHandleMessage`1");
                foreach (var interFace in interFaces)
                {
                    var codeType = code.GetType();
                    var argTypes = interFace.GetGenericArguments();
                    if (argTypes != null && argTypes.Length == 1 && argTypes[0].Name == codeType.Name)
                    {
                        System.Reflection.MethodInfo methodInfo = interFace.GetMethod("HandleMessage");
                        var result = methodInfo.Invoke(this, new object[] { code });
                    }
                }
            }
            catch
            {

            }
        }

        void SuperSocket_MessageReceived(object sender, WebSocket4Net.MessageReceivedEventArgs e)
        {
            ShowMsg(e.Message, false);
        }

        void FrmMain_LocationChanged(object sender, EventArgs e)
        {
            ucTextBoxEx1.Invalidate();
            ucTextBoxEx2.Invalidate();
            ucTextBoxEx3.Invalidate();
            btnConn.Invalidate();

        }
        void FrmMain_Load(object sender, EventArgs e)
        {
            OnSetehoscopeConnect += FrmMain_OnSetehoscopeConnect;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnConn_Click(object sender, EventArgs e)
        {
            if (isConnect())
            {
                return;
            }
            var stetNo = ucTextBoxEx1.Text.Trim();
            if (!string.IsNullOrEmpty(stetNo))
            {
                var b = StethoscopeManager.StethoscopeList.Where(s => s.Name == stetNo && s.IsConnected).Any();
                if (!b)
                    OpenStethoscope(stetNo);
                else
                    CloseStethoscope(stetNo);
            }
        }
        /// <summary>
        ///设备连接成功事件
        /// </summary>
        event Action OnSetehoscopeConnect;
        bool OpenStethoscope(string stethoscopeName)
        {
            var stethoscopes = StethoscopeManager.StethoscopeList.Where(s => s.Name == stethoscopeName);
            if (!stethoscopes.Any()) return false;
            var stethoscope = stethoscopes.First();
            var formProcessBar = new FrmProcessBar(false, string.Format("正在开启设备{0}连接！", stethoscopeName))
            {
                CancelBtnVisible = false
            }; ;
            Thread pairThread = new Thread(() =>
            {
                try
                {
                    if (!stethoscope.IsConnected)
                    {
                        stethoscope.Connect();
                        ShowMsg(string.Format("听诊器 {0} 连接成功...", stethoscopeName), false);
                        Invoke(new MethodInvoker(() =>
                        {
                            btnConn.ForeColor = Color.Red;
                            btnConn.Text = "断开";
                        }));
                        if (OnSetehoscopeConnect != null)
                        {
                            OnSetehoscopeConnect();
                        }
                        //Mediator.ShowMsg(string.Format("听诊器{0}连接成功", stethoscope.Name));
                    }

                }
                catch (Exception ex)
                {
                    ShowMsg(string.Format("听诊器 {0} 连接失败...", stethoscopeName));

                }
                finally
                {
                    Invoke(new MethodInvoker(() =>
                    {
                        formProcessBar.Close();
                    }));

                }

            });
            pairThread.Start();
            formProcessBar.ShowDialog();
            return stethoscope.IsConnected;
        }
        void ShowMsg(string Msg, bool isError = true)
        {
            Invoke(new MethodInvoker(() =>
            {
                richTextBox1.Select(richTextBox1.TextLength, 0);
                //滚动到控件光标处   
                richTextBox1.ScrollToCaret();
                richTextBox1.AppendText(Msg + "\r\n");
                //this.lblMsg.Text = Msg;
            }));
        }
        bool CloseStethoscope(string stethoscopeName)
        {
            var stethoscopes = StethoscopeManager.StethoscopeList.Where(s => s.Name == stethoscopeName);
            if (!stethoscopes.Any()) return false;
            var stethoscope = stethoscopes.First();

            var formProcessBar = new FrmProcessBar(false, string.Format("正在断设备 {0} 连接！", stethoscopeName))
            {
                CancelBtnVisible = false
            };
            Thread pairThread = new Thread(() =>
            {
                try
                {
                    if (stethoscope.IsConnected)
                    {
                        stethoscope.Disconnect();
                        ShowMsg(string.Format("听诊器 {0} 断开连接...", stethoscopeName), false);
                        Invoke(new MethodInvoker(delegate()
                        {
                            btnConn.ForeColor = Color.FromArgb(60, 135, 251);
                            btnConn.Text = "连接";
                        }));
                    }
                }
                catch (Exception ex)
                {
                    //好像从来没有进来过
                }
                finally
                {
                    Invoke(new MethodInvoker(() =>
                    {
                        formProcessBar.Close();
                    }));
                }
            });
            pairThread.Start();
            formProcessBar.ShowDialog();
            return stethoscope.IsConnected;
        }
       
        bool isStop = false;
        /// <summary>
        /// 设备连接事件
        /// </summary>
        void FrmMain_OnSetehoscopeConnect()
        {
            //告诉对方
            var code = new RReadyCode();
            SuperSocket.Send(code);
        }
        /// <summary>
        /// 发起方
        /// </summary>
        bool isOrder
        {
            get
            {
                bool order = false;
                Invoke(new MethodInvoker(() =>
                {
                    order = radioButtonEx1.Checked;
                }));
                return order;
            }
        }

        /// <summary>
        /// 用户上线,触发发起远程
        /// </summary>
        /// <param name="message"></param>
        public void HandleMessage(RYHDLCode message)
        {
            ShowMsg("你的小伙伴上线了", false);
            if (isOrder)
            {
                ShowMsg("我们是发起方,正在向他发起远程听诊了...", false);
                ShowMsg("请先连接你的听诊设备...", false);

            }
            else
            {
                ShowMsg("我们是被叫方,正在等待小伙伴发起远程听诊...", false);
                ShowMsg("在等待的过程中,请先连接你的听诊设备 ...", false);


            }
            //发起
        }
        bool isConnect()
        {
            return StethoscopeManager.StethoscopeList.Where(s => s.IsConnected).Any();
        }

        public void HandleMessage(RYHXXCode message)
        {
            ShowMsg("你的小伙伴退出了,你可以关闭程序了...");
        }

       


        



    }
}
