﻿namespace BDRemote
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.ButtonEx();
            this.label2 = new System.Windows.Forms.Label();
            this.stetList = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConn = new System.Windows.Forms.ButtonEx();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPresss = new System.Windows.Forms.ButtonEx();
            this.gifBox1 = new System.Windows.Forms.GifBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(85)))), ((int)(((byte)(230)))));
            this.btnClose.LeftBottom = 0;
            this.btnClose.LeftTop = 0;
            this.btnClose.Location = new System.Drawing.Point(434, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(135)))), ((int)(((byte)(251)))));
            this.btnClose.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(105)))), ((int)(((byte)(251)))));
            this.btnClose.Radius = 16;
            this.btnClose.RightBottom = 0;
            this.btnClose.RightTop = 0;
            this.btnClose.Size = new System.Drawing.Size(12, 12);
            this.btnClose.TabIndex = 48;
            this.toolTip1.SetToolTip(this.btnClose, "关闭");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(27, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "听诊器：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // stetList
            // 
            this.stetList.BackColor = System.Drawing.SystemColors.Control;
            this.stetList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stetList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stetList.FormattingEnabled = true;
            this.stetList.Location = new System.Drawing.Point(89, 22);
            this.stetList.Name = "stetList";
            this.stetList.Size = new System.Drawing.Size(256, 25);
            this.stetList.TabIndex = 58;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(82, 209);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(370, 86);
            this.richTextBox1.TabIndex = 61;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(181, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "被听方";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnConn
            // 
            this.btnConn.BackColor = System.Drawing.Color.Transparent;
            this.btnConn.BackgroundImage = global::BDRemote.Properties.Resources.未连接状态;
            this.btnConn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConn.FlatAppearance.BorderSize = 0;
            this.btnConn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(85)))), ((int)(((byte)(230)))));
            this.btnConn.LeftBottom = 0;
            this.btnConn.LeftTop = 0;
            this.btnConn.Location = new System.Drawing.Point(354, 11);
            this.btnConn.Name = "btnConn";
            this.btnConn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(135)))), ((int)(((byte)(251)))));
            this.btnConn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(105)))), ((int)(((byte)(251)))));
            this.btnConn.Radius = 16;
            this.btnConn.RightBottom = 0;
            this.btnConn.RightTop = 0;
            this.btnConn.Size = new System.Drawing.Size(83, 47);
            this.btnConn.TabIndex = 67;
            this.btnConn.UseVisualStyleBackColor = false;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.stetList);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnConn);
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 69);
            this.panel3.TabIndex = 71;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnPresss);
            this.panel1.Controls.Add(this.gifBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 116);
            this.panel1.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 73;
            this.label4.Text = "奔达微客户端";
            // 
            // btnPresss
            // 
            this.btnPresss.BackColor = System.Drawing.Color.Transparent;
            this.btnPresss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPresss.FlatAppearance.BorderSize = 0;
            this.btnPresss.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPresss.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPresss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresss.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPresss.ForeColor = System.Drawing.Color.White;
            this.btnPresss.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(85)))), ((int)(((byte)(230)))));
            this.btnPresss.LeftBottom = 0;
            this.btnPresss.LeftTop = 0;
            this.btnPresss.Location = new System.Drawing.Point(401, 46);
            this.btnPresss.Name = "btnPresss";
            this.btnPresss.NormalColor = System.Drawing.Color.Transparent;
            this.btnPresss.PressColor = System.Drawing.Color.Transparent;
            this.btnPresss.Radius = 16;
            this.btnPresss.RightBottom = 0;
            this.btnPresss.RightTop = 0;
            this.btnPresss.Size = new System.Drawing.Size(42, 25);
            this.btnPresss.TabIndex = 71;
            this.btnPresss.Text = "开始";
            this.btnPresss.UseVisualStyleBackColor = false;
            this.btnPresss.Click += new System.EventHandler(this.btnPresss_Click);
            // 
            // gifBox1
            // 
            this.gifBox1.BackColor = System.Drawing.Color.Transparent;
            this.gifBox1.BorderColor = System.Drawing.Color.Transparent;
            this.gifBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gifBox1.Image = global::BDRemote.Properties.Resources.timg;
            this.gifBox1.Location = new System.Drawing.Point(82, 7);
            this.gifBox1.Name = "gifBox1";
            this.gifBox1.Size = new System.Drawing.Size(290, 67);
            this.gifBox1.TabIndex = 70;
            this.gifBox1.Text = "gifBox1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(455, 295);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ButtonEx btnClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox stetList;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ButtonEx btnConn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GifBox gifBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ButtonEx btnPresss;

    }
}

