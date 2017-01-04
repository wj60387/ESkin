using System.Windows.Forms;
namespace BDAuscultation.Forms
{
    partial class FrmAudioDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAudioDetail));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelImages = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPatientId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewEx1 = new System.Windows.Forms.DataGridViewEx();
            this.btnReport = new System.Windows.Forms.ButtonEx();
            this.txtPatientId = new System.Windows.Forms.WaterTextBox();
            this.txtHis = new System.Windows.Forms.WaterTextBox();
            this.txtPatientName = new System.Windows.Forms.WaterTextBox();
            this.txtDocRemark = new System.Windows.Forms.WaterTextBox();
            this.txtDocDiagnose = new System.Windows.Forms.WaterTextBox();
            this.txtDocName = new System.Windows.Forms.WaterTextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelImages);
            this.panel2.Controls.Add(this.btnReport);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.numAge);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtPatientId);
            this.panel2.Controls.Add(this.lblPatientId);
            this.panel2.Controls.Add(this.txtHis);
            this.panel2.Controls.Add(this.txtPatientName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblPatientName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtDocRemark);
            this.panel2.Controls.Add(this.txtDocDiagnose);
            this.panel2.Controls.Add(this.txtDocName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 352);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 235);
            this.panel2.TabIndex = 3;
            // 
            // panelImages
            // 
            this.panelImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelImages.Location = new System.Drawing.Point(369, 102);
            this.panelImages.Name = "panelImages";
            this.panelImages.Size = new System.Drawing.Size(217, 32);
            this.panelImages.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(297, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 32;
            this.label8.Text = "检查报告：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numAge
            // 
            this.numAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numAge.Enabled = false;
            this.numAge.Location = new System.Drawing.Point(524, 16);
            this.numAge.Name = "numAge";
            this.numAge.ReadOnly = true;
            this.numAge.Size = new System.Drawing.Size(63, 23);
            this.numAge.TabIndex = 30;
            this.numAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(406, 18);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(38, 21);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.Text = "女";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(371, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(38, 21);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "男";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(450, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "患者年龄：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(307, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "患者性别：";
            // 
            // lblPatientId
            // 
            this.lblPatientId.AutoSize = true;
            this.lblPatientId.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPatientId.Location = new System.Drawing.Point(307, 211);
            this.lblPatientId.Name = "lblPatientId";
            this.lblPatientId.Size = new System.Drawing.Size(57, 17);
            this.lblPatientId.TabIndex = 8;
            this.lblPatientId.Text = "患者ID：";
            this.lblPatientId.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(146, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "标识：";
            this.label5.Visible = false;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPatientName.Location = new System.Drawing.Point(10, 20);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(68, 17);
            this.lblPatientName.TabIndex = 5;
            this.lblPatientName.Text = "患者姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(6, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "诊断版本：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(26, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "备注：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "初步诊断：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "医生姓名：";
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.AllowUserToDeleteRows = false;
            this.dataGridViewEx1.AllowUserToResizeColumns = false;
            this.dataGridViewEx1.AllowUserToResizeRows = false;
            this.dataGridViewEx1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEx1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewEx1.BoderPad = 0;
            this.dataGridViewEx1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEx1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewEx1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEx1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEx1.ColumnHeadersHeight = 40;
            this.dataGridViewEx1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEx1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.EnableHeadersVisualStyles = false;
            this.dataGridViewEx1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.dataGridViewEx1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewEx1.IndexSize = 24;
            this.dataGridViewEx1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEx1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dataGridViewEx1.MultiSelect = false;
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.ReadOnly = true;
            this.dataGridViewEx1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEx1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEx1.RowHeadersWidth = 70;
            this.dataGridViewEx1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridViewEx1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEx1.Size = new System.Drawing.Size(595, 352);
            this.dataGridViewEx1.TabIndex = 4;
            this.dataGridViewEx1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEx1_CellContentClick);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.Location = new System.Drawing.Point(79, 206);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(60, 24);
            this.btnReport.TabIndex = 35;
            this.btnReport.Text = "附件";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Visible = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // txtPatientId
            // 
            this.txtPatientId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPatientId.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtPatientId.Location = new System.Drawing.Point(376, 207);
            this.txtPatientId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientId.MaxLength = 512;
            this.txtPatientId.Multiline = true;
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.ReadOnly = true;
            this.txtPatientId.Size = new System.Drawing.Size(113, 21);
            this.txtPatientId.TabIndex = 15;
            this.txtPatientId.Visible = false;
            this.txtPatientId.WaterText = "患者ID";
            // 
            // txtHis
            // 
            this.txtHis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHis.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtHis.Location = new System.Drawing.Point(211, 209);
            this.txtHis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHis.MaxLength = 512;
            this.txtHis.Multiline = true;
            this.txtHis.Name = "txtHis";
            this.txtHis.ReadOnly = true;
            this.txtHis.Size = new System.Drawing.Size(88, 21);
            this.txtHis.TabIndex = 21;
            this.txtHis.Visible = false;
            this.txtHis.WaterText = "标识说明";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPatientName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtPatientName.Location = new System.Drawing.Point(80, 17);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientName.MaxLength = 512;
            this.txtPatientName.Multiline = true;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(210, 21);
            this.txtPatientName.TabIndex = 16;
            this.txtPatientName.WaterText = "患者姓名";
            // 
            // txtDocRemark
            // 
            this.txtDocRemark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocRemark.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtDocRemark.Location = new System.Drawing.Point(79, 148);
            this.txtDocRemark.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtDocRemark.MaxLength = 512;
            this.txtDocRemark.Multiline = true;
            this.txtDocRemark.Name = "txtDocRemark";
            this.txtDocRemark.ReadOnly = true;
            this.txtDocRemark.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDocRemark.Size = new System.Drawing.Size(507, 51);
            this.txtDocRemark.TabIndex = 10;
            this.txtDocRemark.WaterText = "备注";
            // 
            // txtDocDiagnose
            // 
            this.txtDocDiagnose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocDiagnose.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtDocDiagnose.Location = new System.Drawing.Point(79, 98);
            this.txtDocDiagnose.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtDocDiagnose.MaxLength = 512;
            this.txtDocDiagnose.Multiline = true;
            this.txtDocDiagnose.Name = "txtDocDiagnose";
            this.txtDocDiagnose.ReadOnly = true;
            this.txtDocDiagnose.Size = new System.Drawing.Size(211, 36);
            this.txtDocDiagnose.TabIndex = 9;
            this.txtDocDiagnose.WaterText = "初步诊断";
            // 
            // txtDocName
            // 
            this.txtDocName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtDocName.Location = new System.Drawing.Point(80, 56);
            this.txtDocName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtDocName.MaxLength = 512;
            this.txtDocName.Multiline = true;
            this.txtDocName.Name = "txtDocName";
            this.txtDocName.ReadOnly = true;
            this.txtDocName.Size = new System.Drawing.Size(210, 25);
            this.txtDocName.TabIndex = 6;
            this.txtDocName.WaterText = "医生姓名";
            // 
            // FrmAudioDetail
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 587);
            this.Controls.Add(this.dataGridViewEx1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAudioDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "听诊录音详情";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private  DataGridViewEx dataGridViewEx1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        internal  WaterTextBox txtDocRemark;
        internal  WaterTextBox txtDocDiagnose;
        internal  WaterTextBox txtDocName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal  WaterTextBox txtPatientId;
        private System.Windows.Forms.Label lblPatientId;
        internal  WaterTextBox txtPatientName;
        private System.Windows.Forms.Label lblPatientName;
        internal  WaterTextBox txtHis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private  ButtonEx btnReport;
        private System.Windows.Forms.Panel panelImages;

    }
}