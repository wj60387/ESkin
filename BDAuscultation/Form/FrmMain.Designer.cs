namespace BDAuscultation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnMin = new System.Windows.Forms.ButtonEx();
            this.btnBack = new System.Windows.Forms.ButtonEx();
            this.btnClose = new System.Windows.Forms.ButtonEx();
            this.tabControlEx1 = new System.Windows.Forms.TabControlEx();
            this.tabTZPZ = new System.Windows.Forms.TabPage();
            this.dataGridViewEx1 = new System.Windows.Forms.DataGridViewEx();
            this.buttonEx1 = new System.Windows.Forms.ButtonEx();
            this.comboBoxEx1 = new System.Windows.Forms.ComboBoxEx();
            this.buttonEx2 = new System.Windows.Forms.ButtonEx();
            this.tabTZJX = new System.Windows.Forms.TabPage();
            this.tabTZLY = new System.Windows.Forms.TabPage();
            this.tabYDTZ = new System.Windows.Forms.TabPage();
            this.tabYCTZ = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripEx1 = new System.Windows.Forms.ToolStripEx();
            this.navLOGO = new System.Windows.Forms.ToolStripButton();
            this.navTZPZ = new System.Windows.Forms.ToolStripButton();
            this.navTZJX = new System.Windows.Forms.ToolStripButton();
            this.navTZLY = new System.Windows.Forms.ToolStripButton();
            this.navYDTZ = new System.Windows.Forms.ToolStripButton();
            this.navYCTZ = new System.Windows.Forms.ToolStripButton();
            this.tabControlEx1.SuspendLayout();
            this.tabTZPZ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
            this.toolStripEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.BackgroundImage = global::BDAuscultation.Properties.Resources.系统按钮最小化;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(698, 9);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(12, 12);
            this.btnMin.TabIndex = 42;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::BDAuscultation.Properties.Resources.系统按钮还原;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(716, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(12, 12);
            this.btnBack.TabIndex = 41;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::BDAuscultation.Properties.Resources.系统按钮关闭;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(734, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(12, 12);
            this.btnClose.TabIndex = 40;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControlEx1
            // 
            this.tabControlEx1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlEx1.Controls.Add(this.tabTZPZ);
            this.tabControlEx1.Controls.Add(this.tabTZJX);
            this.tabControlEx1.Controls.Add(this.tabTZLY);
            this.tabControlEx1.Controls.Add(this.tabYDTZ);
            this.tabControlEx1.Controls.Add(this.tabYCTZ);
            this.tabControlEx1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlEx1.ItemSize = new System.Drawing.Size(1, 1);
            this.tabControlEx1.Location = new System.Drawing.Point(123, 31);
            this.tabControlEx1.Name = "tabControlEx1";
            this.tabControlEx1.SelectedIndex = 0;
            this.tabControlEx1.Size = new System.Drawing.Size(633, 447);
            this.tabControlEx1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlEx1.TabIndex = 43;
            // 
            // tabTZPZ
            // 
            this.tabTZPZ.Controls.Add(this.dataGridViewEx1);
            this.tabTZPZ.Controls.Add(this.buttonEx1);
            this.tabTZPZ.Controls.Add(this.comboBoxEx1);
            this.tabTZPZ.Controls.Add(this.buttonEx2);
            this.tabTZPZ.Location = new System.Drawing.Point(0, 1);
            this.tabTZPZ.Name = "tabTZPZ";
            this.tabTZPZ.Padding = new System.Windows.Forms.Padding(3);
            this.tabTZPZ.Size = new System.Drawing.Size(631, 444);
            this.tabTZPZ.TabIndex = 0;
            this.tabTZPZ.Text = "tabPage1";
            this.tabTZPZ.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.AllowUserToDeleteRows = false;
            this.dataGridViewEx1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEx1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEx1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEx1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewEx1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEx1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEx1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEx1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewEx1.EnableHeadersVisualStyles = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(6, 84);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.ReadOnly = true;
            this.dataGridViewEx1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(41);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEx1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEx1.Size = new System.Drawing.Size(619, 354);
            this.dataGridViewEx1.TabIndex = 33;
            // 
            // buttonEx1
            // 
            this.buttonEx1.BackColor = System.Drawing.Color.Transparent;
            this.buttonEx1.BackgroundImage = global::BDAuscultation.Properties.Resources.按钮左半椭圆;
            this.buttonEx1.FlatAppearance.BorderSize = 0;
            this.buttonEx1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEx1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEx1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEx1.Location = new System.Drawing.Point(253, 41);
            this.buttonEx1.Name = "buttonEx1";
            this.buttonEx1.Size = new System.Drawing.Size(86, 30);
            this.buttonEx1.TabIndex = 32;
            this.buttonEx1.Text = "选择听诊器";
            this.buttonEx1.UseVisualStyleBackColor = false;
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.DropDownHeight = 150;
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
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.comboBoxEx1.Location = new System.Drawing.Point(339, 41);
            this.comboBoxEx1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(219, 30);
            this.comboBoxEx1.TabIndex = 31;
            // 
            // buttonEx2
            // 
            this.buttonEx2.BackColor = System.Drawing.Color.Transparent;
            this.buttonEx2.BackgroundImage = global::BDAuscultation.Properties.Resources.听诊器配置;
            this.buttonEx2.FlatAppearance.BorderSize = 0;
            this.buttonEx2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEx2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEx2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEx2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonEx2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEx2.Image = global::BDAuscultation.Properties.Resources.听诊器图片;
            this.buttonEx2.Location = new System.Drawing.Point(15, 15);
            this.buttonEx2.Name = "buttonEx2";
            this.buttonEx2.Size = new System.Drawing.Size(224, 63);
            this.buttonEx2.TabIndex = 14;
            this.buttonEx2.Text = "听诊器配置";
            this.buttonEx2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEx2.UseVisualStyleBackColor = false;
            // 
            // tabTZJX
            // 
            this.tabTZJX.Location = new System.Drawing.Point(0, 1);
            this.tabTZJX.Name = "tabTZJX";
            this.tabTZJX.Padding = new System.Windows.Forms.Padding(3);
            this.tabTZJX.Size = new System.Drawing.Size(631, 444);
            this.tabTZJX.TabIndex = 1;
            this.tabTZJX.Text = "tabPage2";
            this.tabTZJX.UseVisualStyleBackColor = true;
            // 
            // tabTZLY
            // 
            this.tabTZLY.Location = new System.Drawing.Point(0, 1);
            this.tabTZLY.Name = "tabTZLY";
            this.tabTZLY.Size = new System.Drawing.Size(631, 444);
            this.tabTZLY.TabIndex = 2;
            this.tabTZLY.Text = "tabPage3";
            this.tabTZLY.UseVisualStyleBackColor = true;
            // 
            // tabYDTZ
            // 
            this.tabYDTZ.Location = new System.Drawing.Point(0, 1);
            this.tabYDTZ.Name = "tabYDTZ";
            this.tabYDTZ.Size = new System.Drawing.Size(631, 444);
            this.tabYDTZ.TabIndex = 3;
            this.tabYDTZ.Text = "tabPage4";
            this.tabYDTZ.UseVisualStyleBackColor = true;
            // 
            // tabYCTZ
            // 
            this.tabYCTZ.Location = new System.Drawing.Point(0, 1);
            this.tabYCTZ.Name = "tabYCTZ";
            this.tabYCTZ.Size = new System.Drawing.Size(631, 444);
            this.tabYCTZ.TabIndex = 4;
            this.tabYCTZ.Text = "tabPage5";
            this.tabYCTZ.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(120, 484);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 31);
            this.panel1.TabIndex = 44;
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.AutoSize = false;
            this.toolStripEx1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.toolStripEx1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripEx1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.ImageScalingSize = new System.Drawing.Size(55, 55);
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navLOGO,
            this.navTZPZ,
            this.navTZJX,
            this.navTZLY,
            this.navYDTZ,
            this.navYCTZ});
            this.toolStripEx1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStripEx1.Location = new System.Drawing.Point(0, 0);
            this.toolStripEx1.MouseMoveItem = null;
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripEx1.PressItem = this.navTZPZ;
            this.toolStripEx1.Size = new System.Drawing.Size(120, 515);
            this.toolStripEx1.TabIndex = 0;
            this.toolStripEx1.Text = "toolStripEx1";
            // 
            // navLOGO
            // 
            this.navLOGO.AutoSize = false;
            this.navLOGO.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.navLOGO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navLOGO.Margin = new System.Windows.Forms.Padding(0);
            this.navLOGO.Name = "navLOGO";
            this.navLOGO.Size = new System.Drawing.Size(119, 88);
            this.navLOGO.Text = "LOGO";
            // 
            // navTZPZ
            // 
            this.navTZPZ.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.navTZPZ.ForeColor = System.Drawing.Color.White;
            this.navTZPZ.Image = global::BDAuscultation.Properties.Resources.听诊配置;
            this.navTZPZ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navTZPZ.Margin = new System.Windows.Forms.Padding(0);
            this.navTZPZ.Name = "navTZPZ";
            this.navTZPZ.Size = new System.Drawing.Size(119, 80);
            this.navTZPZ.Text = "听诊配置";
            this.navTZPZ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // navTZJX
            // 
            this.navTZJX.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.navTZJX.ForeColor = System.Drawing.Color.White;
            this.navTZJX.Image = global::BDAuscultation.Properties.Resources.听诊教学;
            this.navTZJX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navTZJX.Margin = new System.Windows.Forms.Padding(0);
            this.navTZJX.Name = "navTZJX";
            this.navTZJX.Size = new System.Drawing.Size(119, 80);
            this.navTZJX.Text = "听诊教学";
            this.navTZJX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.navTZJX.ToolTipText = "听诊教学";
            // 
            // navTZLY
            // 
            this.navTZLY.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.navTZLY.ForeColor = System.Drawing.Color.White;
            this.navTZLY.Image = global::BDAuscultation.Properties.Resources.听诊录音;
            this.navTZLY.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navTZLY.Margin = new System.Windows.Forms.Padding(0);
            this.navTZLY.Name = "navTZLY";
            this.navTZLY.Size = new System.Drawing.Size(119, 80);
            this.navTZLY.Text = "听诊录音";
            this.navTZLY.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.navTZLY.ToolTipText = "听诊录音";
            // 
            // navYDTZ
            // 
            this.navYDTZ.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.navYDTZ.ForeColor = System.Drawing.Color.White;
            this.navYDTZ.Image = global::BDAuscultation.Properties.Resources.云端听诊;
            this.navYDTZ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navYDTZ.Margin = new System.Windows.Forms.Padding(0);
            this.navYDTZ.Name = "navYDTZ";
            this.navYDTZ.Size = new System.Drawing.Size(119, 80);
            this.navYDTZ.Text = "云端听诊";
            this.navYDTZ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.navYDTZ.ToolTipText = "云端听诊";
            // 
            // navYCTZ
            // 
            this.navYCTZ.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.navYCTZ.ForeColor = System.Drawing.Color.White;
            this.navYCTZ.Image = global::BDAuscultation.Properties.Resources.远程教学;
            this.navYCTZ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navYCTZ.Margin = new System.Windows.Forms.Padding(0);
            this.navYCTZ.Name = "navYCTZ";
            this.navYCTZ.Size = new System.Drawing.Size(119, 80);
            this.navYCTZ.Text = "远程听诊";
            this.navYCTZ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.navYCTZ.ToolTipText = "远程听诊";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripEx1);
            this.Controls.Add(this.tabControlEx1);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClose);
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControlEx1.ResumeLayout(false);
            this.tabTZPZ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ButtonEx btnMin;
        private System.Windows.Forms.ButtonEx btnBack;
        private System.Windows.Forms.ButtonEx btnClose;
        private System.Windows.Forms.TabControlEx tabControlEx1;
        private System.Windows.Forms.TabPage tabTZPZ;
        private System.Windows.Forms.TabPage tabTZJX;
        private System.Windows.Forms.TabPage tabTZLY;
        private System.Windows.Forms.TabPage tabYDTZ;
        private System.Windows.Forms.TabPage tabYCTZ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripButton navTZPZ;
        private System.Windows.Forms.ToolStripButton navTZJX;
        private System.Windows.Forms.ToolStripButton navTZLY;
        private System.Windows.Forms.ToolStripButton navYDTZ;
        private System.Windows.Forms.ToolStripButton navYCTZ;
        private System.Windows.Forms.ButtonEx buttonEx2;
        private System.Windows.Forms.DataGridViewEx dataGridViewEx1;
        private System.Windows.Forms.ButtonEx buttonEx1;
        private System.Windows.Forms.ComboBoxEx comboBoxEx1;
        private System.Windows.Forms.ToolStripButton navLOGO;
    }
}

