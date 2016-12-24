using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms
{
    public class UCTextBox:UserControl
    {
        private WaterTextBox waterTextBox1;

       
        public UCTextBox()
        {
            
            InitializeComponent();
            waterTextBox1.Font = this.Font;
             TextImage = global::ESkin.Properties.Resources.账号图标;
            this.waterTextBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DoubleBuffered = true;
            //base.SetStyle(
            //       ControlStyles.UserPaint |                      // 控件将自行绘制，而不是通过操作系统来绘制
            //       ControlStyles.OptimizedDoubleBuffer |          // 该控件首先在缓冲区中绘制，而不是直接绘制到屏幕上，这样可以减少闪烁
            //       ControlStyles.AllPaintingInWmPaint |           // 控件将忽略 WM_ERASEBKGND 窗口消息以减少闪烁
            //       ControlStyles.ResizeRedraw |                   // 在调整控件大小时重绘控件
            //       ControlStyles.SupportsTransparentBackColor,    // 控件接受 alpha 组件小于 255 的 BackColor 以模拟透明
            //       true);                                         // 设置以上值为 true
            //base.UpdateStyles();


            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.StandardDoubleClick, false);
            this.SetStyle(ControlStyles.Selectable, true);
            this.BackColor = Color.Transparent;
        }
 
        public string WaterText
        {
            get { return waterTextBox1.WaterText; }
            set
            {
                waterTextBox1.WaterText = value;
            }
        }
        private Image textImage=null;
        public Image TextImage
        {
            get
            {
                return textImage;
            }
            set
            {
                textImage = value;
                this.Invalidate();
            }
        }
        Rectangle imageDrawRect = Rectangle.Empty;
        public Rectangle ImageDrawRect
        {
            get { return  imageDrawRect; }
            set { imageDrawRect = value; this.Invalidate() ; }
        }
        public char PasswordChar
        {
            get
            {
                return waterTextBox1.PasswordChar;
            }
            set
            {
                waterTextBox1.PasswordChar = value;
                this.Invalidate();
            }

        }
        
        private void InitializeComponent()
        {
            this.waterTextBox1 = new System.Windows.Forms.WaterTextBox();
            this.SuspendLayout();
            // 
            // waterTextBox1
            // 
            this.waterTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.waterTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.waterTextBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.waterTextBox1.Location = new System.Drawing.Point(25, 11);
            this.waterTextBox1.Name = "waterTextBox1";
            this.waterTextBox1.Size = new System.Drawing.Size(224, 19);
            this.waterTextBox1.TabIndex = 0;
            this.waterTextBox1.WaterText = "水印文字";
            // 
            // UCTextBox
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::ESkin.Properties.Resources.输入框账号;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.waterTextBox1);
            this.DoubleBuffered = true;
            this.Name = "UCTextBox";
            this.Size = new System.Drawing.Size(273, 40);
            this.FontChanged += new System.EventHandler(this.UCTextBox_FontChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void UCTextBox_FontChanged(object sender, EventArgs e)
        {
            waterTextBox1.Font = this.Font;
        }
        Point textBoxLocation = Point.Empty;
        public Point TextBoxLocation {
            get{return textBoxLocation;}
            set
            {
                textBoxLocation = value;
                this.Invalidate();}
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if(textImage!=null)
            {
                e.Graphics.DrawImage(TextImage, ImageDrawRect);
            }
            this.waterTextBox1.Location = TextBoxLocation;
            this.waterTextBox1.Size=new Size(this.Width - ImageDrawRect.Width-40,this.Height);
            waterTextBox1.Invalidate();
            base.OnPaint(e);

        }
    }
}
