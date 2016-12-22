namespace EApp
{
    partial class FrmLogin2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin2));
            this.ucTextBox1 = new System.Windows.Forms.UCTextBox();
            this.ucTextBox2 = new System.Windows.Forms.UCTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucTextBox1
            // 
            this.ucTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.ucTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTextBox1.BackgroundImage")));
            this.ucTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTextBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucTextBox1.Location = new System.Drawing.Point(72, 154);
            this.ucTextBox1.Name = "ucTextBox1";
            this.ucTextBox1.PasswordChar = '\0';
            this.ucTextBox1.Size = new System.Drawing.Size(220, 40);
            this.ucTextBox1.TabIndex = 2;
            this.ucTextBox1.TextImage = ((System.Drawing.Image)(resources.GetObject("ucTextBox1.TextImage")));
            this.ucTextBox1.WaterText = "用户名";
            // 
            // ucTextBox2
            // 
            this.ucTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.ucTextBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTextBox2.BackgroundImage")));
            this.ucTextBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTextBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucTextBox2.Location = new System.Drawing.Point(72, 219);
            this.ucTextBox2.Name = "ucTextBox2";
            this.ucTextBox2.PasswordChar = '*';
            this.ucTextBox2.Size = new System.Drawing.Size(220, 40);
            this.ucTextBox2.TabIndex = 3;
            this.ucTextBox2.TextImage = global::EApp.Properties.Resources.密码图标;
            this.ucTextBox2.WaterText = "密码";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::EApp.Properties.Resources.奔达听诊平台;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(34, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 45);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::EApp.Properties.Resources.登入框登录200x40;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(72, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmLogin2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::EApp.Properties.Resources.背景;
            this.ClientSize = new System.Drawing.Size(600, 404);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ucTextBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin2";
            this.ShowIcon = false;
            this.Text = "";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.UCTextBox ucTextBox1;
        private System.Windows.Forms.UCTextBox ucTextBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}