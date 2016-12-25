using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace System.Windows.Forms
{
    public class ComboBoxEx : ComboBox
    {
        public ComboBoxEx()
            : base()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
             this.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemHeight = 22;
        }
        [System.Runtime.InteropServices.DllImport("user32.dll ")]
        static extern IntPtr GetWindowDC(IntPtr hWnd);//返回hWnd参数所指定的窗口的设备环境。    

        [System.Runtime.InteropServices.DllImport("user32.dll ")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC); //函数释放设备上下文环境（DC）    

        protected override void WndProc(ref   Message m)
        {
            base.WndProc(ref   m);

            //WM_PAINT = 0xf; 要求一个窗口重画自己,即Paint事件时    
            //WM_CTLCOLOREDIT = 0x133;当一个编辑型控件将要被绘制时发送此消息给它的父窗口；    
            //通过响应这条消息，所有者窗口可以通过使用给定的相关显示设备的句柄来设置编辑框的文本和背景颜色    
            //windows消息值表,可参考:http://hi.baidu.com/dooy/blog/item/0e770a24f70e3b2cd407421b.html    
            if (m.Msg == 0xf || m.Msg == 0x133)
            {
                IntPtr hDC = GetWindowDC(m.HWnd);
                if (hDC.ToInt32() == 0) //如果取设备上下文失败则返回    
                {
                    return;
                }

                //建立Graphics对像    
                Graphics g = Graphics.FromHdc(hDC);
                //画边框的     
                ControlPaint.DrawBorder(g, new Rectangle(0, 0, Width, Height), Color.Red, ButtonBorderStyle.Solid);
                //画坚线    
                ControlPaint.DrawBorder(g, new Rectangle(Width - Height, 0, Height, Height), Color.Red, ButtonBorderStyle.Solid);
                //g.DrawLine(new Pen(Brushes.Blue, 2), new PointF(this.Width - this.Height, 0), new PointF(this.Width - this.Height, this.Height));    
                //释放DC      
                ReleaseDC(m.HWnd, hDC);
            }
        }     


        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            //鼠标选中在这个项上
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
            e.Graphics.DrawString(this.Items[e.Index] + "", new Font("微软雅黑", 12), Brushes.Black, textRect, sfn);
        }
    }
}
   
 
