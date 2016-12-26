namespace EApp
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.buttonEx1 = new System.Windows.Forms.ButtonEx();
            this.comboBoxEx1 = new System.Windows.Forms.ComboBoxEx();
            this.btnClose = new System.Windows.Forms.ButtonEx();
            this.buttonEx2 = new System.Windows.Forms.ButtonEx();
            this.toolStripEx3 = new System.Windows.Forms.ToolStripEx();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStripEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEx1
            // 
            this.buttonEx1.BackColor = System.Drawing.Color.Transparent;
            this.buttonEx1.BackgroundImage = global::EApp.Properties.Resources.按钮左半椭圆;
            this.buttonEx1.FlatAppearance.BorderSize = 0;
            this.buttonEx1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEx1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEx1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEx1.Location = new System.Drawing.Point(389, 39);
            this.buttonEx1.Name = "buttonEx1";
            this.buttonEx1.Size = new System.Drawing.Size(86, 30);
            this.buttonEx1.TabIndex = 30;
            this.buttonEx1.Text = "选择听诊器";
            this.buttonEx1.UseVisualStyleBackColor = false;
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.DropDownHeight = 100;
            this.comboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEx1.DwonImage = ((System.Drawing.Image)(resources.GetObject("comboBoxEx1.DwonImage")));
            this.comboBoxEx1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEx1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxEx1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.IntegralHeight = false;
            this.comboBoxEx1.ItemHeight = 24;
            this.comboBoxEx1.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboBoxEx1.Location = new System.Drawing.Point(475, 39);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(219, 30);
            this.comboBoxEx1.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::EApp.Properties.Resources.系统按钮关闭;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(744, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(12, 12);
            this.btnClose.TabIndex = 14;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // buttonEx2
            // 
            this.buttonEx2.BackColor = System.Drawing.Color.Transparent;
            this.buttonEx2.BackgroundImage = global::EApp.Properties.Resources.听诊器配置;
            this.buttonEx2.FlatAppearance.BorderSize = 0;
            this.buttonEx2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEx2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEx2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEx2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonEx2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEx2.Image = global::EApp.Properties.Resources.听诊器图片;
            this.buttonEx2.Location = new System.Drawing.Point(148, 29);
            this.buttonEx2.Name = "buttonEx2";
            this.buttonEx2.Size = new System.Drawing.Size(224, 63);
            this.buttonEx2.TabIndex = 13;
            this.buttonEx2.Text = "听诊器配置";
            this.buttonEx2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEx2.UseVisualStyleBackColor = false;
            // 
            // toolStripEx3
            // 
            this.toolStripEx3.AutoSize = false;
            this.toolStripEx3.BackColor = System.Drawing.Color.Yellow;
            this.toolStripEx3.BackgroundImage = global::EApp.Properties.Resources.导航栏200x1080;
            this.toolStripEx3.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripEx3.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripEx3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx3.ImageScalingSize = new System.Drawing.Size(51, 51);
            this.toolStripEx3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton5});
            this.toolStripEx3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStripEx3.Location = new System.Drawing.Point(0, 0);
            this.toolStripEx3.MaximumSize = new System.Drawing.Size(120, 0);
            this.toolStripEx3.MinimumSize = new System.Drawing.Size(64, 0);
            this.toolStripEx3.MouseMoveItem = null;
            this.toolStripEx3.Name = "toolStripEx3";
            this.toolStripEx3.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripEx3.PressItem = null;
            this.toolStripEx3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripEx3.Size = new System.Drawing.Size(112, 515);
            this.toolStripEx3.TabIndex = 6;
            this.toolStripEx3.Text = "toolStripEx3";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::EApp.Properties.Resources.听诊配置;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(111, 72);
            this.toolStripButton3.Text = "AAA";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::EApp.Properties.Resources.听诊教学;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(111, 72);
            this.toolStripButton4.Text = "BBB";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = global::EApp.Properties.Resources.听诊录音;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(111, 72);
            this.toolStripButton8.Text = "CCC";
            this.toolStripButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.Image = global::EApp.Properties.Resources.云端听诊;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(111, 72);
            this.toolStripButton9.Text = "DDD";
            this.toolStripButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::EApp.Properties.Resources.远程教学;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(111, 72);
            this.toolStripButton5.Text = "EEE";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(265, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 31;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(767, 515);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEx1);
            this.Controls.Add(this.comboBoxEx1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.buttonEx2);
            this.Controls.Add(this.toolStripEx3);
            this.MaximumSize = new System.Drawing.Size(1366, 728);
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.Text = "";
            this.toolStripEx3.ResumeLayout(false);
            this.toolStripEx3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripEx toolStripEx3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ButtonEx buttonEx2;
        private System.Windows.Forms.ButtonEx btnClose;
        private System.Windows.Forms.ComboBoxEx comboBoxEx1;
        private System.Windows.Forms.ButtonEx buttonEx1;
        private System.Windows.Forms.DataGridView dataGridView1;





    }
}

