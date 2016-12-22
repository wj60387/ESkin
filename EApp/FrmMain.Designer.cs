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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelLT = new System.Windows.Forms.Panel();
            this.toolStripEx1 = new System.Windows.Forms.ToolStripEx();
            this.btnLG = new System.Windows.Forms.ToolStripButton();
            this.btnPZ = new System.Windows.Forms.ToolStripButton();
            this.btnJX = new System.Windows.Forms.ToolStripButton();
            this.btnLY = new System.Windows.Forms.ToolStripButton();
            this.btnYD = new System.Windows.Forms.ToolStripButton();
            this.btnYC = new System.Windows.Forms.ToolStripButton();
            this.panelLB = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelLT.SuspendLayout();
            this.toolStripEx1.SuspendLayout();
            this.panelLB.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelLeft.BackgroundImage = global::EApp.Properties.Resources.导航栏200x1080;
            this.panelLeft.Controls.Add(this.panelLT);
            this.panelLeft.Controls.Add(this.panelLB);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(180, 728);
            this.panelLeft.TabIndex = 1;
            // 
            // panelLT
            // 
            this.panelLT.Controls.Add(this.toolStripEx1);
            this.panelLT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLT.Location = new System.Drawing.Point(0, 0);
            this.panelLT.Name = "panelLT";
            this.panelLT.Size = new System.Drawing.Size(180, 647);
            this.panelLT.TabIndex = 1;
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.AutoSize = false;
            this.toolStripEx1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.toolStripEx1.BackgroundImage = global::EApp.Properties.Resources.导航栏200x1080;
            this.toolStripEx1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLG,
            this.btnPZ,
            this.btnJX,
            this.btnLY,
            this.btnYD,
            this.btnYC});
            this.toolStripEx1.Location = new System.Drawing.Point(0, 0);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripEx1.Size = new System.Drawing.Size(180, 647);
            this.toolStripEx1.TabIndex = 0;
            this.toolStripEx1.Text = "toolStripEx1";
            // 
            // btnLG
            // 
            this.btnLG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLG.Image = global::EApp.Properties.Resources.logo;
            this.btnLG.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLG.Name = "btnLG";
            this.btnLG.Size = new System.Drawing.Size(179, 52);
            // 
            // btnPZ
            // 
            this.btnPZ.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPZ.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPZ.Image = global::EApp.Properties.Resources.听诊器配置;
            this.btnPZ.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPZ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPZ.Name = "btnPZ";
            this.btnPZ.Size = new System.Drawing.Size(179, 120);
            this.btnPZ.Text = "听诊器配置";
            this.btnPZ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnJX
            // 
            this.btnJX.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnJX.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnJX.Image = global::EApp.Properties.Resources.听诊教学;
            this.btnJX.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnJX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnJX.Name = "btnJX";
            this.btnJX.Size = new System.Drawing.Size(179, 111);
            this.btnJX.Text = "听诊教学";
            this.btnJX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnLY
            // 
            this.btnLY.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLY.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLY.Image = global::EApp.Properties.Resources.听诊录音;
            this.btnLY.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLY.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLY.Name = "btnLY";
            this.btnLY.Size = new System.Drawing.Size(179, 113);
            this.btnLY.Text = "听诊录音";
            this.btnLY.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnYD
            // 
            this.btnYD.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnYD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnYD.Image = global::EApp.Properties.Resources.云端听诊;
            this.btnYD.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnYD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYD.Name = "btnYD";
            this.btnYD.Size = new System.Drawing.Size(179, 102);
            this.btnYD.Text = "远端听诊";
            this.btnYD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnYC
            // 
            this.btnYC.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnYC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnYC.Image = global::EApp.Properties.Resources.远程教学;
            this.btnYC.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnYC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYC.Name = "btnYC";
            this.btnYC.Size = new System.Drawing.Size(179, 105);
            this.btnYC.Text = "远程教学";
            this.btnYC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panelLB
            // 
            this.panelLB.Controls.Add(this.toolStrip1);
            this.panelLB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLB.Location = new System.Drawing.Point(0, 647);
            this.panelLB.Margin = new System.Windows.Forms.Padding(0);
            this.panelLB.Name = "panelLB";
            this.panelLB.Size = new System.Drawing.Size(180, 81);
            this.panelLB.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::EApp.Properties.Resources.导航栏200x1080;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(180, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = global::EApp.Properties.Resources.系统;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton7.Text = "系统";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::EApp.Properties.Resources.关于;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "关于";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 707);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "XXXXXXXXXXXXXXXX";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(881, 728);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLeft);
            this.MaximumSize = new System.Drawing.Size(1366, 728);
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.Text = "";
            this.panelLeft.ResumeLayout(false);
            this.panelLT.ResumeLayout(false);
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.panelLB.ResumeLayout(false);
            this.panelLB.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripButton btnPZ;
        private System.Windows.Forms.ToolStripButton btnJX;
        private System.Windows.Forms.ToolStripButton btnLY;
        private System.Windows.Forms.ToolStripButton btnYD;
        private System.Windows.Forms.ToolStripButton btnYC;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.Panel panelLT;
        private System.Windows.Forms.Panel panelLB;
        private System.Windows.Forms.ToolStripButton btnLG;
        private System.Windows.Forms.Label label1;



    }
}

