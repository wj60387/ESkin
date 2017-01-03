using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms
{
    public class UCTextBoxEx:UserControl
    {
        private WaterTextBox waterTextBox1;

       
        public UCTextBoxEx()
        {
            
            InitializeComponent();
            waterTextBox1.Font = this.Font;
            this.waterTextBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DoubleBuffered = true;

           
            this.waterTextBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.StandardDoubleClick, false);
            this.SetStyle(ControlStyles.Selectable, true);
           this.BackColor = Color.Transparent;

           this.waterTextBox1.Enter += waterTextBox1_Enter;
           this.waterTextBox1.Leave += waterTextBox1_Leave;
        }
        Color color = Color.Black;
        void waterTextBox1_Leave(object sender, EventArgs e)
        {
            color = Color.Black;
            this.Invalidate();
        }

        void waterTextBox1_Enter(object sender, EventArgs e)
        {
            color = Color.FromArgb(100,200,250);
            this.Invalidate();
        }
         
        public string WaterText
        {
            get { return waterTextBox1.WaterText; }
            set
            {
                waterTextBox1.WaterText = value;
            }
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
            this.waterTextBox1.Location = new System.Drawing.Point(12, 2);
            this.waterTextBox1.Name = "waterTextBox1";
            this.waterTextBox1.Size = new System.Drawing.Size(187, 19);
            this.waterTextBox1.TabIndex = 0;
            this.waterTextBox1.WaterText = "水印文字";
            // 
            // UCTextBoxEx
            // 
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.waterTextBox1);
            this.DoubleBuffered = true;
            this.Name = "UCTextBoxEx";
            this.Size = new System.Drawing.Size(210, 24);
            this.FontChanged += new System.EventHandler(this.UCTextBox_FontChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        private void UCTextBox_FontChanged(object sender, EventArgs e)
        {
             this.waterTextBox1.Font=this.Font;
        }
        public int _radius = 16;
        public int Radius
        {
            get { return _radius; }
            set { _radius = value; this.Invalidate(); }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, _radius);
            base.OnPaint(e);
        }
       
        private void Draw(Rectangle rectangle, Graphics g, int _radius)
        {
            Pen shadowPen = new Pen(color,1.5f);
            g.DrawPath(shadowPen, DrawRoundRect(rectangle.X, rectangle.Y, rectangle.Width - 2, rectangle.Height - 1, _radius));
        }
        public static GraphicsPath DrawRoundRect(int x, int y, int width, int height, int radius)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(x, y, radius, radius, 180, 90);
            gp.AddArc(width - radius, y, radius, radius, 270, 90);
            gp.AddArc(width - radius, height - radius, radius, radius, 0, 90);
            gp.AddArc(x, height - radius, radius, radius, 90, 90);
            gp.CloseAllFigures();
            return gp;
        }

        public string Text
        {
            get
            {
                return this.waterTextBox1.Text;

            }
            set
            {
                this.waterTextBox1.Text = value;
            }
        }
    }
}
