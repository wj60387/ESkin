namespace BDRemote
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
            this.ucTextBoxEx1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.processBarEx1 = new System.Windows.Forms.ProcessBarEx();
            this.radioButtonEx2 = new System.Windows.Forms.RadioButtonEx();
            this.radioButtonEx1 = new System.Windows.Forms.RadioButtonEx();
            this.ucTextBoxEx3 = new System.Windows.Forms.UCTextBoxEx();
            this.ucTextBoxEx2 = new System.Windows.Forms.UCTextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEx1 = new System.Windows.Forms.ButtonEx();
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
            this.btnClose.Location = new System.Drawing.Point(418, 7);
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
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "当前听诊器：";
            // 
            // ucTextBoxEx1
            // 
            this.ucTextBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ucTextBoxEx1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucTextBoxEx1.FormattingEnabled = true;
            this.ucTextBoxEx1.Location = new System.Drawing.Point(98, 51);
            this.ucTextBoxEx1.Name = "ucTextBoxEx1";
            this.ucTextBoxEx1.Size = new System.Drawing.Size(228, 25);
            this.ucTextBoxEx1.TabIndex = 58;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(25, 190);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(377, 75);
            this.richTextBox1.TabIndex = 61;
            this.richTextBox1.Text = "";
            // 
            // processBarEx1
            // 
            this.processBarEx1.Location = new System.Drawing.Point(25, 163);
            this.processBarEx1.MaxValue = 100;
            this.processBarEx1.Name = "processBarEx1";
            this.processBarEx1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.processBarEx1.Size = new System.Drawing.Size(318, 10);
            this.processBarEx1.TabIndex = 63;
            this.processBarEx1.Text = "processBarEx1";
            this.processBarEx1.Value = 30;
            this.processBarEx1.Visible = false;
            // 
            // radioButtonEx2
            // 
            this.radioButtonEx2.AutoSize = true;
            this.radioButtonEx2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonEx2.Location = new System.Drawing.Point(220, 116);
            this.radioButtonEx2.Name = "radioButtonEx2";
            this.radioButtonEx2.Size = new System.Drawing.Size(69, 24);
            this.radioButtonEx2.TabIndex = 57;
            this.radioButtonEx2.Text = "被叫方";
            this.radioButtonEx2.UseVisualStyleBackColor = true;
            // 
            // radioButtonEx1
            // 
            this.radioButtonEx1.AutoSize = true;
            this.radioButtonEx1.Checked = true;
            this.radioButtonEx1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonEx1.Location = new System.Drawing.Point(25, 117);
            this.radioButtonEx1.Name = "radioButtonEx1";
            this.radioButtonEx1.Size = new System.Drawing.Size(69, 24);
            this.radioButtonEx1.TabIndex = 56;
            this.radioButtonEx1.TabStop = true;
            this.radioButtonEx1.Text = "发起方";
            this.radioButtonEx1.UseVisualStyleBackColor = true;
            // 
            // ucTextBoxEx3
            // 
            this.ucTextBoxEx3.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.ucTextBoxEx3.BackColor = System.Drawing.SystemColors.Control;
            this.ucTextBoxEx3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTextBoxEx3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucTextBoxEx3.Location = new System.Drawing.Point(294, 116);
            this.ucTextBoxEx3.Multiline = false;
            this.ucTextBoxEx3.Name = "ucTextBoxEx3";
            this.ucTextBoxEx3.PasswordChar = '\0';
            this.ucTextBoxEx3.Radius = 22;
            this.ucTextBoxEx3.ReadOnly = true;
            this.ucTextBoxEx3.Size = new System.Drawing.Size(98, 24);
            this.ucTextBoxEx3.TabIndex = 52;
            this.ucTextBoxEx3.WaterText = "医生姓名";
            // 
            // ucTextBoxEx2
            // 
            this.ucTextBoxEx2.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.ucTextBoxEx2.BackColor = System.Drawing.SystemColors.Control;
            this.ucTextBoxEx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTextBoxEx2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucTextBoxEx2.Location = new System.Drawing.Point(98, 118);
            this.ucTextBoxEx2.Multiline = false;
            this.ucTextBoxEx2.Name = "ucTextBoxEx2";
            this.ucTextBoxEx2.PasswordChar = '\0';
            this.ucTextBoxEx2.Radius = 22;
            this.ucTextBoxEx2.ReadOnly = true;
            this.ucTextBoxEx2.Size = new System.Drawing.Size(98, 24);
            this.ucTextBoxEx2.TabIndex = 50;
            this.ucTextBoxEx2.WaterText = "医生姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(364, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 64;
            // 
            // buttonEx1
            // 
            this.buttonEx1.BackColor = System.Drawing.Color.Transparent;
            this.buttonEx1.BackgroundImage = global::BDRemote.Properties.Resources.已连接状态;
            this.buttonEx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEx1.FlatAppearance.BorderSize = 0;
            this.buttonEx1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEx1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEx1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEx1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(85)))), ((int)(((byte)(230)))));
            this.buttonEx1.LeftBottom = 0;
            this.buttonEx1.LeftTop = 0;
            this.buttonEx1.Location = new System.Drawing.Point(332, 53);
            this.buttonEx1.Name = "buttonEx1";
            this.buttonEx1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(135)))), ((int)(((byte)(251)))));
            this.buttonEx1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(105)))), ((int)(((byte)(251)))));
            this.buttonEx1.Radius = 16;
            this.buttonEx1.RightBottom = 0;
            this.buttonEx1.RightTop = 0;
            this.buttonEx1.Size = new System.Drawing.Size(50, 25);
            this.buttonEx1.TabIndex = 67;
            this.buttonEx1.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 295);
            this.ControlBox = false;
            this.Controls.Add(this.buttonEx1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processBarEx1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ucTextBoxEx1);
            this.Controls.Add(this.radioButtonEx2);
            this.Controls.Add(this.radioButtonEx1);
            this.Controls.Add(this.ucTextBoxEx3);
            this.Controls.Add(this.ucTextBoxEx2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ButtonEx btnClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.UCTextBoxEx ucTextBoxEx2;
        private System.Windows.Forms.UCTextBoxEx ucTextBoxEx3;
        private System.Windows.Forms.RadioButtonEx radioButtonEx1;
        private System.Windows.Forms.RadioButtonEx radioButtonEx2;
        private System.Windows.Forms.ComboBox ucTextBoxEx1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ProcessBarEx processBarEx1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ButtonEx buttonEx1;

    }
}

