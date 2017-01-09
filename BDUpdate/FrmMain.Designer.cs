namespace BDUpdate
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
            this.btnDown = new System.Windows.Forms.ButtonEx();
            this.processBarEx1 = new System.Windows.Forms.ProcessBarEx();
            this.btnMin = new System.Windows.Forms.ButtonEx();
            this.btnClose = new System.Windows.Forms.ButtonEx();
            this.SuspendLayout();
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.Transparent;
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDown.ForeColor = System.Drawing.Color.White;
            this.btnDown.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(85)))), ((int)(((byte)(230)))));
            this.btnDown.Location = new System.Drawing.Point(163, 115);
            this.btnDown.Name = "btnDown";
            this.btnDown.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(135)))), ((int)(((byte)(251)))));
            this.btnDown.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(105)))), ((int)(((byte)(251)))));
            this.btnDown.Radius = 16;
            this.btnDown.Size = new System.Drawing.Size(60, 23);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "下载";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // processBarEx1
            // 
            this.processBarEx1.BackColor = System.Drawing.Color.White;
            this.processBarEx1.Font = new System.Drawing.Font("微软雅黑", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.processBarEx1.ForeColor = System.Drawing.Color.Blue;
            this.processBarEx1.Location = new System.Drawing.Point(0, 217);
            this.processBarEx1.MaxValue = 100;
            this.processBarEx1.Name = "processBarEx1";
            this.processBarEx1.Size = new System.Drawing.Size(392, 3);
            this.processBarEx1.TabIndex = 2;
            this.processBarEx1.Text = "processBarEx1";
            this.processBarEx1.Value = 30;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.HoverColor = System.Drawing.Color.Transparent;
            this.btnMin.Image = global::BDUpdate.Properties.Resources.zuixiaohua;
            this.btnMin.Location = new System.Drawing.Point(353, 7);
            this.btnMin.Name = "btnMin";
            this.btnMin.NormalColor = System.Drawing.Color.Transparent;
            this.btnMin.PressColor = System.Drawing.Color.Transparent;
            this.btnMin.Radius = 16;
            this.btnMin.Size = new System.Drawing.Size(12, 12);
            this.btnMin.TabIndex = 1;
            this.btnMin.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::BDUpdate.Properties.Resources.关闭按钮;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(85)))), ((int)(((byte)(230)))));
            this.btnClose.Location = new System.Drawing.Point(371, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(135)))), ((int)(((byte)(251)))));
            this.btnClose.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(105)))), ((int)(((byte)(251)))));
            this.btnClose.Radius = 16;
            this.btnClose.Size = new System.Drawing.Size(12, 12);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BDUpdate.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(392, 254);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.processBarEx1);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ButtonEx btnClose;
        private System.Windows.Forms.ButtonEx btnMin;
        private System.Windows.Forms.ProcessBarEx processBarEx1;
        private System.Windows.Forms.ButtonEx btnDown;

    }
}

