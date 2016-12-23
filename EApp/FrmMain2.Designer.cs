namespace EApp
{
    partial class FrmMain2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain2));
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabControlEx1 = new System.Windows.Forms.TabControlEx();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucTextBox2 = new System.Windows.Forms.UCTextBox();
            this.ucTextBox3 = new System.Windows.Forms.UCTextBox();
            this.ucTextBox1 = new System.Windows.Forms.UCTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStripEx1 = new System.Windows.Forms.ToolStripEx();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.panelMain.SuspendLayout();
            this.tabControlEx1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStripEx1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.tabControlEx1);
            this.panelMain.Location = new System.Drawing.Point(0, 22);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(876, 644);
            this.panelMain.TabIndex = 1;
            // 
            // tabControlEx1
            // 
            this.tabControlEx1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlEx1.Controls.Add(this.tabPage1);
            this.tabControlEx1.Controls.Add(this.tabPage2);
            this.tabControlEx1.Controls.Add(this.tabPage3);
            this.tabControlEx1.Controls.Add(this.tabPage5);
            this.tabControlEx1.Controls.Add(this.tabPage4);
            this.tabControlEx1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlEx1.ItemSize = new System.Drawing.Size(98, 88);
            this.tabControlEx1.Location = new System.Drawing.Point(3, 3);
            this.tabControlEx1.Multiline = true;
            this.tabControlEx1.Name = "tabControlEx1";
            this.tabControlEx1.SelectedIndex = 0;
            this.tabControlEx1.Size = new System.Drawing.Size(873, 641);
            this.tabControlEx1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlEx1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucTextBox2);
            this.tabPage1.Controls.Add(this.ucTextBox3);
            this.tabPage1.Controls.Add(this.ucTextBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Location = new System.Drawing.Point(88, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 640);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "听诊器配置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ucTextBox2
            // 
            this.ucTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.ucTextBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTextBox2.BackgroundImage")));
            this.ucTextBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTextBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucTextBox2.Location = new System.Drawing.Point(110, 328);
            this.ucTextBox2.Name = "ucTextBox2";
            this.ucTextBox2.PasswordChar = '*';
            this.ucTextBox2.Size = new System.Drawing.Size(220, 40);
            this.ucTextBox2.TabIndex = 5;
            this.ucTextBox2.TextImage = global::EApp.Properties.Resources.密码图标;
            this.ucTextBox2.WaterText = "密码";
            // 
            // ucTextBox3
            // 
            this.ucTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.ucTextBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTextBox3.BackgroundImage")));
            this.ucTextBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTextBox3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucTextBox3.Location = new System.Drawing.Point(110, 268);
            this.ucTextBox3.Name = "ucTextBox3";
            this.ucTextBox3.PasswordChar = '\0';
            this.ucTextBox3.Size = new System.Drawing.Size(220, 40);
            this.ucTextBox3.TabIndex = 4;
            this.ucTextBox3.TextImage = ((System.Drawing.Image)(resources.GetObject("ucTextBox3.TextImage")));
            this.ucTextBox3.WaterText = "用户名";
            // 
            // ucTextBox1
            // 
            this.ucTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.ucTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTextBox1.BackgroundImage")));
            this.ucTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTextBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucTextBox1.Location = new System.Drawing.Point(100, 201);
            this.ucTextBox1.Name = "ucTextBox1";
            this.ucTextBox1.PasswordChar = '\0';
            this.ucTextBox1.Size = new System.Drawing.Size(273, 40);
            this.ucTextBox1.TabIndex = 1;
            this.ucTextBox1.TextImage = ((System.Drawing.Image)(resources.GetObject("ucTextBox1.TextImage")));
            this.ucTextBox1.WaterText = "水印文字";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.toolStripEx1);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Location = new System.Drawing.Point(88, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 640);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "听诊教学";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.AutoSize = false;
            this.toolStripEx1.BackColor = System.Drawing.Color.Yellow;
            this.toolStripEx1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton1});
            this.toolStripEx1.Location = new System.Drawing.Point(3, 3);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripEx1.Size = new System.Drawing.Size(119, 634);
            this.toolStripEx1.TabIndex = 0;
            this.toolStripEx1.Text = "toolStripEx1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(118, 69);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(404, 191);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage3.Location = new System.Drawing.Point(88, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(785, 640);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "听诊录音";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button4);
            this.tabPage5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage5.Location = new System.Drawing.Point(88, 0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(785, 640);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "云端听诊";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(180, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 0;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage4.Location = new System.Drawing.Point(88, 0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(785, 640);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "远程教学";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(265, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(118, 69);
            this.toolStripButton3.Text = "toolStripButton1";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // FrmMain2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(876, 666);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain2";
            this.ShowIcon = false;
            this.Text = "窗体2";
            this.panelMain.ResumeLayout(false);
            this.tabControlEx1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControlEx tabControlEx1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.UCTextBox ucTextBox1;
        private System.Windows.Forms.UCTextBox ucTextBox2;
        private System.Windows.Forms.UCTextBox ucTextBox3;
        private System.Windows.Forms.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;

    }
}