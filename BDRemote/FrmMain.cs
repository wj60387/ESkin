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
    public partial class FrmMain : Form
        , IHandleMessage<RQQLJCode>
        , IHandleMessage<RHYLJCode>
        , IHandleMessage<RYHDLCode>
        , IHandleMessage<RYHXXCode>
        , IHandleMessage<RKQYPCode>
        , IHandleMessage<RGBYPCode>
        , IHandleMessage<RCSYPCode>
    {
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
            btnStart.Text = isRequest ? "发起听诊" : "接受远程";
            btnStart.Visible = isRequest;
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
            btnStart.Invalidate();
            btnConn.Invalidate();

        }
        void FrmMain_Load(object sender, EventArgs e)
        {

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
                lblMsg.ForeColor = isError ? Color.Red : Color.Green;
                this.lblMsg.Text = Msg;
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
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (radioButtonEx1.Checked)//发起请求
            {
                var stethoscopeArr = StethoscopeManager.StethoscopeList.Where(s => s.Name == this.ucTextBoxEx1.Text);
                if (!stethoscopeArr.Any())
                    throw new Exception("目前没有检测到听诊器,请检测设备设置！");
                var stethoscope = stethoscopeArr.First();
                if (!stethoscope.IsConnected)
                {
                    ShowMsg(string.Format("听诊器 {0} 尚未连接", stethoscope.Name));
                    return;
                }

                var code = new ProtocalData.Protocol.Derive.RQQLJCode();
                var bytes = ProtocalData.Utilities.SerializaHelper.Serialize(code);
                SuperSocket.Send(bytes);

            }
            else//接受请求
            {
                var code = new RHYLJCode();
                var bytes = ProtocalData.Utilities.SerializaHelper.Serialize(code);
                SuperSocket.Send(bytes);
            }

        }

        public void HandleMessage(RQQLJCode message)
        {
            Invoke(new MethodInvoker(() =>
            {
                btnStart.Visible = true;
            }));
            ShowMsg("你有一个远程听诊请求,请点击接受", false);
        }

        bool isStart = false;
        bool isStop = false;
        public void HandleMessage(RHYLJCode message)
        {
            ShowMsg("你的小伙伴接受了你的远程请求,现在开始听诊了...", false);
            #region
            //开始听诊
            Invoke(new MethodInvoker(()=>
            {
                var stethoscopeArr = StethoscopeManager.StethoscopeList.Where(s => s.Name == this.ucTextBoxEx1.Text);
                if (!stethoscopeArr.Any())
                    throw new Exception("目前没有检测到听诊器,请检测设备设置！");
                var stethoscope = stethoscopeArr.First();
                if (!stethoscope.IsConnected)
                {
                    ShowMsg(string.Format("听诊器 {0} 尚未连接", stethoscope.Name));
                    return;
                }
                var code = new RKQYPCode();
                var bytes = ProtocalData.Utilities.SerializaHelper.Serialize(code);
                this.SuperSocket.Send(bytes);
                Thread.Sleep(1000);
                var formProcessBar = new FrmProcessBar(true)
                {
                    BtnText = "停止远程"
                };
                formProcessBar.StartPosition = FormStartPosition.CenterParent;
                Thread pairThread = new Thread(() =>
                {
                    formProcessBar.TimerCallBackEvent += () =>
                    {
                        Invoke(new MethodInvoker(delegate()
                        {
                            formProcessBar.Title = string.Format("远程教学中... {0} 秒", formProcessBar.Times);
                        }));
                    };
                    stethoscope.StartAudioInput();
                    ShowMsg(string.Format("听诊器 {0} 开始远程教学...", stethoscope.Name));
                    // Stream audio from the stethoscope to the computer.
                    while (formProcessBar.DialogResult != System.Windows.Forms.DialogResult.Cancel
                        && !isStop)
                    {
                        byte[] packet = new byte[128];
                        int bytesRead = stethoscope.AudioInputStream.Read(packet, 0, packet.Length);
                        //Send to Remote
                        if (bytesRead <= 0)
                        {
                            Thread.Sleep(1);
                            continue;
                        }
                        var rcsypCode = new RCSYPCode();
                        rcsypCode.bytes = packet.Take(bytesRead).ToArray();
                        var rcsypBytes = ProtocalData.Utilities.SerializaHelper.Serialize(rcsypCode);
                        SuperSocket.Send(bytes);
                        Thread.Sleep(1);
                    }
                    ShowMsg(string.Format("听诊器 {0} 远程听诊完毕，时长 {1} 秒", stethoscope.Name, formProcessBar.Times));
                    Invoke(new MethodInvoker(delegate()
                    {
                        formProcessBar.Close();
                    }));
                });
                pairThread.Start();
                formProcessBar.ShowDialog();
                formProcessBar.TimerEnable = false;
                if (stethoscope.IsConnected)
                    stethoscope.StopAudioInput();
                //Send Over To Remote
                var rgbypCode = new RGBYPCode();
                var rgbypBytes = ProtocalData.Utilities.SerializaHelper.Serialize(rgbypCode);
                SuperSocket.Send(rgbypBytes);
                ShowMsg("远程听诊完毕...");
            }));
            #endregion
        }

        public void HandleMessage(RYHDLCode message)
        {
            ShowMsg("你的小伙伴上线了,可以像他发起听诊了...", false);
        }

        public void HandleMessage(RYHXXCode message)
        {
            ShowMsg("你的小伙伴退出了,你可以关闭程序了...");
        }

        public void HandleMessage(RGBYPCode message)
        {
            ShowMsg(string.Format("远程听诊停止接收数据..."));
            Invoke(new MethodInvoker(() =>
            {
                if (!isStart) return;
                if (!isStop) return;
                var stethoscopeArr = StethoscopeManager.StethoscopeList.Where(s => s.Name == ucTextBoxEx1.Text);
                if (!stethoscopeArr.Any())
                    throw new Exception("目前没有检测到听诊器,请检测设备设置！");
                var stethoscope = stethoscopeArr.First();
                if (!stethoscope.IsConnected)
                {
                    ShowMsg(string.Format("听诊器 {0} 尚未连接", stethoscope.Name));
                    return;
                }
                else
                    stethoscope.StopAudioOutput();
            }));
        }
        //private event Action<bool> OnReceivedEvent;
        //private bool isReceived = false;
        //private bool IsReceived
        //{
        //    get
        //    {
        //        return isReceived;
        //    }
        //    set
        //    {
        //        isReceived = value;
        //        if (OnReceivedEvent != null)
        //            OnReceivedEvent(value);
        //    }
        //}
        public void HandleMessage(RKQYPCode message)
        {
            Thread thread = new Thread(() =>
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    var formProcessBar = new FrmProcessBar(true)
                    {
                        BtnText = "停止远程",
                        CancelBtnVisible = true
                    };
                    formProcessBar.OnActiveClose += () =>
                    {
                        this.Invoke(new MethodInvoker(() =>
                        {
                            var stethoscopeArr = StethoscopeManager.StethoscopeList.Where(s => s.Name == ucTextBoxEx1.Text);
                            if (!stethoscopeArr.Any())
                                throw new Exception("目前没有检测到听诊器,请检测设备设置！");
                            var stethoscope = stethoscopeArr.First();
                            if (!stethoscope.IsConnected)
                            {
                                ShowMsg(string.Format("听诊器 {0} 尚未连接", stethoscope.Name));
                                return;
                            }
                            else
                                stethoscope.StopAudioOutput();
                            var stopCode = new RGBYPCode();
                            var stopBytes = ProtocalData.Utilities.SerializaHelper.Serialize(stopCode);
                            SuperSocket.Send(stopBytes);

                        }));
                    };
                    formProcessBar.TimerCallBackEvent += () =>
                    {
                        Invoke(new MethodInvoker(() =>
                        {
                            formProcessBar.Title = string.Format("远程教学中... {0} 秒", formProcessBar.Times);
                        }));
                    };
                    formProcessBar.ShowDialog();
                }));
            });
            thread.Start();
        }
        public void HandleMessage(RCSYPCode message)
        {
            if (this.IsDisposed || this.Disposing) return;
            this.Invoke(new MethodInvoker(() =>
            {
                var stethoscopeArr = StethoscopeManager.StethoscopeList.Where(s => s.Name == ucTextBoxEx1.Text);
                if (!stethoscopeArr.Any())
                    throw new Exception("目前没有检测到听诊器,请检测设备设置！");
                var stethoscope = stethoscopeArr.First();
                if (!stethoscope.IsConnected)
                {
                    ShowMsg(string.Format("听诊器 {0} 尚未连接", stethoscope.Name));
                    return;
                }
                else
                {
                    stethoscope.AudioOutputStream.Write(message.bytes, 0, message.bytes.Length);
                }
            }));
        }

         
    }
}
