using Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms
{
    public class FormEx : Form, IDisposable
    {
        private ButtonEx btnClose;
        private ButtonEx btnMin;
        private ButtonEx btnMax;
        private ToolTip toolTip1;      //鼠标的按下位置
        private System.ComponentModel.IContainer components = null;
        public FormEx()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.SuspendLayout();
            this.components = new System.ComponentModel.Container();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.Name = "ESkinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打开指标文档所在目录";
            this.ResumeLayout(false);
            this.SetStyle(ControlStyles.UserPaint, true);//自绘
            this.SetStyle(ControlStyles.DoubleBuffer, true);// 双缓冲
            this.SetStyle(ControlStyles.ResizeRedraw, true);//调整大小时重绘
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);// 双缓冲
            //this.SetStyle(ControlStyles.Opaque, true);//如果为真，控件将绘制为不透明，不绘制背景
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);   //透明效果
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            
            //base.OnMouseClick(e);
        }
        
        public override Rectangle DisplayRectangle
        {
            get
            {

                Rectangle rect = base.DisplayRectangle;
                return new Rectangle(rect.Left - 8, rect.Top - 4, rect.Width + 8, rect.Height + 7);
            }
        }
         
        protected override void WndProc(ref Message m)
        {
            try
            {

                switch (m.Msg)
                {
                    //禁止双击标题栏关闭窗体
                    case 0xF063:
                    case 0xF093:
                        m.WParam = IntPtr.Zero;
                        break;
                    //禁止拖拽标题栏还原窗体
                    case 0xF012:
                    case 0xF010:
                        m.WParam = IntPtr.Zero;
                        break;
                    //禁止双击标题栏
                    case 0xf122:
                        m.WParam = IntPtr.Zero;
                        break;
                    //禁止最大化按钮
                    case 0xf020:
                        m.WParam = IntPtr.Zero;
                        return;
                    //禁止最小化按钮
                    case 0xf030:
                        m.WParam = IntPtr.Zero;
                        return;
                    //用户选择最大化按钮，最小化按钮，复原按钮或关闭按钮时，窗口将会接收该消息
                    case Win32.WM_SYSCOMMAND:
                        #region
                        if ((m.WParam != (IntPtr)Win32.SC_MAXIMIZE) && (m.WParam.ToInt32() != 0xf032))
                        {
                            if ((m.WParam == (IntPtr)Win32.SC_RESTORE) || (m.WParam.ToInt32() == 0xf122))
                            {
                                base.Size = this.oldSize;
                            }
                            else if ((m.WParam == (IntPtr)Win32.SC_MINIMIZE) || (m.WParam.ToInt32() == 0xf022))
                            {
                                if (this.oldSize.Width == 0)
                                {
                                    this.oldSize = base.Size;
                                }
                            }
                            break;
                        }
                        this.oldSize = base.Size;
                        #endregion
                        break;
                    //在需要计算窗口客户区的大小和位置时发送。通过处理这个消息，应用程序可以在窗口大小或位置改变时控制客户区的内容
                    case Win32.WM_NCCALCSIZE:
                    //窗体客户区以外的重绘消息,一般是由系统负责处理
                    case Win32.WM_NCPAINT:
                        return;
                    //鼠标移动,按下或释放都会执行该消息
                    case Win32.WM_NCHITTEST:
                        WM_NCHITTEST(ref m);
                        return;
                    //画窗体被激活或者没有被激活时的样子//http://blog.csdn.net/commandos/archive/2007/11/27/1904558.aspx
                    case Win32.WM_NCACTIVATE:
                        #region
                        if (m.WParam == (IntPtr)Win32.WM_FALSE)
                        {
                            m.Result = (IntPtr)Win32.WM_TRUE;
                        }
                        #endregion
                        return;
                    default:
                        base.WndProc(ref m);
                        return;
                }
                base.WndProc(ref m);
            }
            catch { }

        }
        private Size oldSize;
        protected override void OnResizeEnd(EventArgs e)
        {
            
            base.OnResizeEnd(e);
            this.oldSize = base.Size;
        } 
        private bool _IsResize = true;
        public bool IsResize
        {
            get { return this._IsResize; }
            set { _IsResize = value; }
        }
        private void WM_NCHITTEST(ref Message m)
        {
            int wparam = m.LParam.ToInt32();
            Point point = new Point(Win32.LOWORD(wparam), Win32.HIWORD(wparam));
            point = PointToClient(point);
            if (_IsResize)
            {
                if (point.X <= 8)
                {
                    if (point.Y <= 8)
                        m.Result = (IntPtr)Win32.HTTOPLEFT;
                    else if (point.Y > Height - 8)
                        m.Result = (IntPtr)Win32.HTBOTTOMLEFT;
                    else
                        m.Result = (IntPtr)Win32.HTLEFT;
                }
                else if (point.X >= Width - 8)
                {
                    if (point.Y <= 8)
                        m.Result = (IntPtr)Win32.HTTOPRIGHT;
                    else if (point.Y >= Height - 8)
                        m.Result = (IntPtr)Win32.HTBOTTOMRIGHT;
                    else
                        m.Result = (IntPtr)Win32.HTRIGHT;
                }
                else if (point.Y <= 8)
                {
                    m.Result = (IntPtr)Win32.HTTOP;
                }
                else if (point.Y >= Height - 8)
                    m.Result = (IntPtr)Win32.HTBOTTOM;
                else
                    m.Result = (IntPtr)Win32.HTCAPTION;
            }
            else
            { m.Result = (IntPtr)Win32.HTCAPTION; }
        }
       
        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            
            SetReion();
            base.OnInvalidated(e);
        }
        public new bool ControlBox
        {
            get { return btnClose.Visible; }
            set { this.btnClose.Visible = value; }
        }
        public new bool MinimizeBox
        {
            get { return btnMin.Visible; }
            set { this.btnMin.Visible = value; }
        }
        public new bool MaximizeBox
        {
            get { return btnMax.Visible; }
            set { this.btnMax.Visible = value; }
        }
        protected void SetReion()
        {
            var Rgn = Win32.CreateRoundRectRgn(5, 5, ClientRectangle.Width - 4, ClientRectangle.Height - 4, 0, 0);
            Win32.SetWindowRgn(this.Handle, Rgn, true);
        }
   //     protected override void OnPaint(PaintEventArgs e)
   //     {
   //         try
   //         {
   //             e.Graphics.SmoothingMode = SmoothingMode.HighQuality; //高质量
   //             e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality; //高像素偏移质量
   //             e.Graphics.DrawImage(this.BackgroundImage, this.ClientRectangle);
                
   //         }
   //         catch
   //         { }
   //}
        
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnMax = new System.Windows.Forms.ButtonEx();
            this.btnMin = new System.Windows.Forms.ButtonEx();
            this.btnClose = new System.Windows.Forms.ButtonEx();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.BackgroundImage = global::ESkin.Properties.Resources.还原按钮;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Location = new System.Drawing.Point(555, 9);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(15, 15);
            this.btnMax.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnMax, "还原");
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.BackgroundImage = global::ESkin.Properties.Resources._16x1;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(533, 18);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(16, 1);
            this.btnMin.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnMin, "最小化");
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::ESkin.Properties.Resources.关闭按钮;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(576, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(12, 12);
            this.btnClose.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnClose, "关闭");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormEx
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEx";
            this.ResumeLayout(false);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {

        }


    }

}
