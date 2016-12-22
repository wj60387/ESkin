using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms
{
    public class FormEx : Form,IDisposable
    {
        private bool isMouseDown = false;
        private Point FormLocation;     //form的location
        private Point mouseOffset;      //鼠标的按下位置
        private System.ComponentModel.IContainer components = null;
        public FormEx()
        {
            this.FormBorderStyle =  FormBorderStyle.None;
            this.SuspendLayout();
            this.components = new System.ComponentModel.Container();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(427, 247);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ESkinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打开指标文档所在目录";
            this.ResumeLayout(false);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }
        const int HTLEFT = 10;
        const int HTRIGHT = 11;
        const int HTTOP = 12;
        const int HTTOPLEFT = 13;
        const int HTTOPRIGHT = 14;
        const int HTBOTTOM = 15;
        const int HTBOTTOMLEFT = 0x10;
        const int HTBOTTOMRIGHT = 17;
        protected override void WndProc(ref Message m)
        {

            switch (m.Msg)
            {
                case 0x0084:
                    base.WndProc(ref m);
                    Point vPoint = new Point((int)m.LParam & 0xFFFF,
                        (int)m.LParam >> 16 & 0xFFFF);
                    vPoint = PointToClient(vPoint);
                    if (vPoint.X <= 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOPLEFT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOMLEFT;
                        else m.Result = (IntPtr)HTLEFT;
                    else if (vPoint.X >= ClientSize.Width - 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOPRIGHT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOMRIGHT;
                        else m.Result = (IntPtr)HTRIGHT;
                    else if (vPoint.Y <= 5)
                        m.Result = (IntPtr)HTTOP;
                    else if (vPoint.Y >= ClientSize.Height - 5)
                        m.Result = (IntPtr)HTBOTTOM;
                    break;
                case 0x0201://鼠标左键按下的消息 
                    base.WndProc(ref m);
                    m.Msg = 0x00A1;//更改消息为非客户区按下鼠标 
                    m.LParam = IntPtr.Zero;//默认值 
                    m.WParam = new IntPtr(2);//鼠标放在标题栏内 
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }
        Size IconSize = new Size(12,12);
        Rectangle rectColse
        {
            get
            {
                return new Rectangle(this.ClientSize.Width - IconSize.Width-6, 6, IconSize.Width, IconSize.Height);
            }
        }
        Rectangle rectMax
        {
            get
            {
                return new Rectangle(this.ClientSize.Width - 2*IconSize.Width - 6-5, 6, IconSize.Width, IconSize.Height);
            }
        }
        Rectangle rectMin
        {
            get
            {
                return new Rectangle(this.ClientSize.Width - 3*IconSize.Width - 6-10, 6, IconSize.Width, IconSize.Height);
            }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            var point = PointToScreen(MousePosition);
            this.MaximumSize = Screen.FromPoint(point).WorkingArea.Size;
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left && !rectColse.Contains(e.Location))
            {
                isMouseDown = true;
                FormLocation = this.Location;
                mouseOffset = Control.MousePosition;
            }

        }
        void ShowTip(string Msg)
        {
            ToolTipEx.ShowTip(Msg);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
        }
        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);

            var clientPoint = this.PointToClient(MousePosition);
            if (rectColse.Contains(clientPoint))
            {
                ShowTip("关闭");
            }
            if (rectMax.Contains(clientPoint) && MaximizeBox)
            {
                ShowTip("最大化");
                 
            }
            if (rectMin.Contains(clientPoint) && MinimizeBox)
            {
                ShowTip("最小化");
                
            }
        }
        #if !DEBUG
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        } 
        #endif
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
            if (rectColse.Contains(e.Location) || rectMax.Contains(e.Location) || rectMin.Contains(e.Location))
            {
                this.Invalidate(rectColse);
                this.Invalidate(rectMax);
                this.Invalidate(rectMin);
            }
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            var clientPoint = this.PointToClient(MousePosition);
            if (rectColse.Contains(clientPoint))
            {
                this.Close();
            }
            if (rectMax.Contains(clientPoint))
            {
                if (MaximizeBox)
                    if (this.WindowState != FormWindowState.Maximized)
                        this.WindowState = FormWindowState.Maximized;
                    else
                        this.WindowState = FormWindowState.Normal;
            }
            if (rectMin.Contains(clientPoint))
            {
                if (MinimizeBox)
                    if (this.WindowState != FormWindowState.Minimized)
                        this.WindowState = FormWindowState.Minimized;
                    else
                        this.WindowState = FormWindowState.Normal;
            }
        }
        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnClick(e);
            if (MaximizeBox)
                if (this.WindowState != FormWindowState.Maximized)
                    this.WindowState = FormWindowState.Maximized;
                else
                    this.WindowState = FormWindowState.Normal;
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
           

        }
        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            var image = this.Icon.ToBitmap().GetThumbnailImage(18, 18, () => { return false; }, IntPtr.Zero);
            if (ShowIcon)
                e.Graphics.DrawImage(image, 1, 1);
            var clientPoint = this.PointToClient(MousePosition);
            if (rectColse.Contains(clientPoint) && ControlBox)
            {
               // e.Graphics.DrawRectangle(new Pen(Color.DarkOrange), new Rectangle(rectColse.X, rectColse.Y, rectColse.Width - 1, rectColse.Height - 1));
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(203, 209, 216)), new Rectangle(rectColse.X, rectColse.Y , rectColse.Width, rectColse.Height));
            }
            if (rectMax.Contains(clientPoint) && MaximizeBox)
            {
                // e.Graphics.DrawRectangle(new Pen(Color.DarkOrange), new Rectangle(rectColse.X, rectColse.Y, rectColse.Width - 1, rectColse.Height - 1));
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255)), new Rectangle(rectMax.X, rectMax.Y, rectMax.Width, rectMax.Height));
            }
            if (rectMin.Contains(clientPoint) && MinimizeBox)
            {
                // e.Graphics.DrawRectangle(new Pen(Color.DarkOrange), new Rectangle(rectColse.X, rectColse.Y, rectColse.Width - 1, rectColse.Height - 1));
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255)), new Rectangle(rectMin.X, rectMin.Y, rectMin.Width, rectMin.Height));
            }
            e.Graphics.DrawString(this.Text, Font, new SolidBrush(Color.Black), 2.5f + (ShowIcon ? image.Width : 0), 1.5f);
            if(ControlBox)
            e.Graphics.DrawImage(ESkin.Properties.Resources.关闭按钮, rectColse);
            if (MaximizeBox)
                e.Graphics.DrawImage(ESkin.Properties.Resources.还原按钮, rectMax);
            if (MinimizeBox)
                e.Graphics.DrawImage(ESkin.Properties.Resources._16x1, rectMin);

            //e.Graphics.DrawString(getString(clientPoint), Font, new SolidBrush(ForeColor), this.ClientRectangle, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            //e.Graphics.DrawString(getString(rectMax), Font, new SolidBrush(ForeColor), new Rectangle(20,20,400,100), new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            //e.Graphics.DrawString(getString(rectMin), Font, new SolidBrush(ForeColor), new Rectangle(20,60,400,100), new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
        }
        string getString(Rectangle rect)
        {
            return string.Format("X:{0},Y:{1},Width:{2},Height:{3}", rect.X, rect.Y, rect.Width, rect.Height);
        }
        string getString(Point point)
        {
            return string.Format("X:{0},Y:{1}",point.X,point.Y);
        }
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
    }
    
}
