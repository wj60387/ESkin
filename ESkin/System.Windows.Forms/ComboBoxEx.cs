using Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace System.Windows.Forms
{
    public class ComboBoxEx :  ComboBox
    {
        private Image dwonImage = ESkin.Properties.Resources.下拉箭头;

        public ComboBoxEx()
            : base()
        {
            base.SetStyle(
     ControlStyles.UserPaint |                      // 控件将自行绘制，而不是通过操作系统来绘制  
     ControlStyles.OptimizedDoubleBuffer |          // 该控件首先在缓冲区中绘制，而不是直接绘制到屏幕上，这样可以减少闪烁  
     ControlStyles.AllPaintingInWmPaint |           // 控件将忽略 WM_ERASEBKGND 窗口消息以减少闪烁  
    // ControlStyles.ResizeRedraw |                   // 在调整控件大小时重绘控件  
     ControlStyles.SupportsTransparentBackColor,    // 控件接受 alpha 组件小于 255 的 BackColor 以模拟透明  
     true);                                         // 设置以上值为 true  
            base.UpdateStyles();
            //设置为手动绘制
            this.DrawMode = DrawMode.OwnerDrawFixed;
            //设置固定的DropDownList样式
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.UpdateStyles();
            this.BackColor = Color.Transparent;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (this.Items.Count != 0)
            {
                this.DropDownHeight = this.Items.Count * 17;
            }
        }

        const int WM_ERASEBKGND = 0x14;
        const int WM_PAINT = 0xF;
        const int WM_NC_HITTEST = 0x84;
        const int WM_NC_PAINT = 0x85;
        const int WM_PRINTCLIENT = 0x318;
        const int WM_SETCURSOR = 0x20;

        protected override void WndProc(ref Message m)
        {
            IntPtr hDC = IntPtr.Zero;
            Graphics gdc = null;

            switch (m.Msg)
            {
                case 133:
                    hDC = Win32.GetWindowDC(m.HWnd);
                    gdc = Graphics.FromHdc(hDC);
                    Win32.SendMessage(this.Handle, WM_ERASEBKGND, hDC.ToInt32(), 0);
                    SendPrintClientMsg();
                    Win32.SendMessage(this.Handle, WM_PAINT, 0, 0);
                   // OverrideControlBorder(gdc);
                    m.Result = (IntPtr)1;    // indicate msg has been processed
                    Win32.ReleaseDC(m.HWnd, hDC);
                    gdc.Dispose();
                    break;
                case WM_PAINT:
                    base.WndProc(ref m);
                    hDC = Win32.GetWindowDC(m.HWnd);
                    gdc = Graphics.FromHdc(hDC);
                    OverrideDropDown(gdc);
                   // OverrideControlBorder(gdc);
                    Win32.ReleaseDC(m.HWnd, hDC);
                    gdc.Dispose();
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        int right =12;
        private static int DropDownButtonWidth = 17;

        private void OverrideDropDown(Graphics g)
        {
            //if (DesignMode) return;
            Rectangle rect = new Rectangle(this.Width - DropDownButtonWidth, 0, DropDownButtonWidth, this.Height);

           
            // g.FillRectangle(new SolidBrush(Color.Red), rect);
            if (this.Enabled)
            {
                g.DrawImage(ESkin.Properties.Resources.按钮右半椭圆, ClientRectangle);
                g.DrawImage(dwonImage, new Rectangle(this.Width - dwonImage.Width - right, this.Height / 2 - dwonImage.Height / 2, dwonImage.Width, dwonImage.Height));

               // g.DrawImage(dwonImage, new Rectangle(this.Width - dwonImage.Width - right, this.Height / 2 - dwonImage.Height / 2, dwonImage.Width, dwonImage.Height));
            }
        }

        /// <summary>
        /// 画边框
        /// </summary>
        /// <param name="g"></param>
        private void OverrideControlBorder(Graphics g)
        {
             //ControlPaint.DrawBorder
            //g.DrawImage(ESkin.Properties.Resources.按钮右半椭圆, ClientRectangle);
            //g.DrawImage(dwonImage, new Rectangle(this.Width - dwonImage.Width - right, this.Height / 2 - dwonImage.Height / 2, dwonImage.Width, dwonImage.Height));

        }

        private void SendPrintClientMsg()
        {
            // We send this message for the control to redraw the client area
            Graphics gClient = this.CreateGraphics();
            IntPtr ptrClientDC = gClient.GetHdc();
            Win32.SendMessage(this.Handle, WM_PRINTCLIENT, ptrClientDC.ToInt32(), 0);
            gClient.ReleaseHdc(ptrClientDC);
            gClient.Dispose();
        }


        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            if ((e.State & DrawItemState.Selected) != 0)
            {
                //渐变画刷
                LinearGradientBrush brush = new LinearGradientBrush(e.Bounds, Color.FromArgb(255, 251, 237),
                                                 Color.FromArgb(255, 236, 181), LinearGradientMode.Vertical);
                //填充区域
                Rectangle borderRect = new Rectangle(0, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
                e.Graphics.FillRectangle(brush, borderRect);
                //画边框
                Pen pen = new Pen(Color.FromArgb(229, 195, 101));
                e.Graphics.DrawRectangle(pen, borderRect);
            }
            else
            {
                SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 255));
                e.Graphics.FillRectangle(brush, e.Bounds);
            }
            //获得项图片,绘制图片
            Image img = ESkin.Properties.Resources.听诊小图标;
            //图片绘制的区域
            Rectangle imgRect = new Rectangle(3, e.Bounds.Y + 3, this.ItemHeight - 6, this.ItemHeight - 6);
            e.Graphics.DrawImage(img, imgRect);
            //文本内容显示区域
            Rectangle textRect =
                    new Rectangle(imgRect.Right + 2, imgRect.Y, e.Bounds.Width - imgRect.Width, e.Bounds.Height - 2);
            //获得项文本内容,绘制文本
            //文本格式垂直居中
            //StringFormat strFormat = new StringFormat();
            //strFormat.LineAlignment = StringAlignment.Center;
            StringFormat sfn = new StringFormat();
            sfn.Alignment = StringAlignment.Near;
            sfn.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(this.Items[e.Index] + "", this.Font, new SolidBrush(this.ForeColor), textRect, sfn);
        }

        private bool _mouseEnter = false;

        protected override void OnMouseEnter(EventArgs e)
        {
            //_mouseEnter = true;

            //IntPtr hDC = IntPtr.Zero;
            //Graphics gdc = null;
            //hDC = Win32.GetWindowDC(this.Handle);
            //gdc = Graphics.FromHdc(hDC);
            //gdc.DrawImage(dwonImage, new Rectangle(this.Width - dwonImage.Width - right, this.Height / 2 - dwonImage.Height / 2, dwonImage.Width, dwonImage.Height));
            //Win32.ReleaseDC(this.Handle, hDC);
            //gdc.Dispose();
           // base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
             
           // _mouseEnter = false;
           // IntPtr hDC = IntPtr.Zero;
           // Graphics gdc = null;
           // hDC = Win32.GetWindowDC(this.Handle);
           // gdc = Graphics.FromHdc(hDC);
           //// gdc.DrawImage(dwonImage, new Rectangle(this.Width - 20, 3, 16, 16));
           // gdc.DrawImage(dwonImage, new Rectangle(this.Width - dwonImage.Width - right, this.Height / 2 - dwonImage.Height / 2, dwonImage.Width, dwonImage.Height));
           // Win32.ReleaseDC(this.Handle, hDC);
            //base.OnMouseLeave(e);
        }

        

        
        public Image DwonImage
        {
            get
            {
                return dwonImage;
            }
            set
            {
                dwonImage = value;
            }
        }
        
    }
}
   
 
