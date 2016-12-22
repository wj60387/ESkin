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
        private Panel panel1;
        private WaterTextBox waterTextBox1;

       
        public UCTextBox()
        {
            
            InitializeComponent();
            waterTextBox1.Font = this.Font;
             TextImage = global::ESkin.Properties.Resources.账号图标;
            this.waterTextBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DoubleBuffered = true;
        }
#if !DEBUG
        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return parms;
            }
        }
#endif
        public string WaterText
        {
            get { return waterTextBox1.WaterText; }
            set
            {
                waterTextBox1.WaterText = value;
            }
        }
        public Image TextImage
        {
            get
            {
                return panel1.BackgroundImage;
            }
            set
            {
                panel1.BackgroundImage = value;
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.waterTextBox1 = new System.Windows.Forms.WaterTextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(22, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(24, 24);
            this.panel1.TabIndex = 1;
            // 
            // waterTextBox1
            // 
            this.waterTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.waterTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.waterTextBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.waterTextBox1.Location = new System.Drawing.Point(49, 8);
            this.waterTextBox1.Name = "waterTextBox1";
            this.waterTextBox1.Size = new System.Drawing.Size(200, 19);
            this.waterTextBox1.TabIndex = 0;
            this.waterTextBox1.WaterText = "水印文字";
            // 
            // UCTextBox
            // 
             this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::ESkin.Properties.Resources.输入框账号;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
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
    }
}
