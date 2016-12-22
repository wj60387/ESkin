using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms
{
    public class UCTextBoxEx:UserControl
    {
        private Panel panel1;
        private Panel panel2;
        private WaterTextBox waterTextBox1;

       
        public UCTextBoxEx()
        {
            
            InitializeComponent();
            waterTextBox1.Font = this.Font;
             TextImage = global::ESkin.Properties.Resources.账号图标;
            this.waterTextBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DoubleBuffered = true;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return parms;
            }
        }
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(17, 7);
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
            this.waterTextBox1.Location = new System.Drawing.Point(42, 10);
            this.waterTextBox1.Name = "waterTextBox1";
            this.waterTextBox1.Size = new System.Drawing.Size(183, 19);
            this.waterTextBox1.TabIndex = 0;
            this.waterTextBox1.WaterText = "水印文字";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ESkin.Properties.Resources.输入框账号;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.waterTextBox1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 40);
            this.panel2.TabIndex = 2;
            // 
            // UCTextBoxEx
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "UCTextBoxEx";
            this.Size = new System.Drawing.Size(245, 40);
            this.FontChanged += new System.EventHandler(this.UCTextBox_FontChanged);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void UCTextBox_FontChanged(object sender, EventArgs e)
        {
            waterTextBox1.Font = this.Font;
        }
    }
}
