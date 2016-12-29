using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EApp
{
    public partial class FrmMain : FormEx
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Load += FrmMain_Load;
        }

        void FrmMain_Load(object sender, EventArgs e)
        {
           //System.Windows.Forms.CheckBoxExColumn col = new System.Windows.Forms.CheckBoxExColumn();
            var checkColumn = new DataGridViewCheckBoxExColumn() { HeaderText = "" };
            this.dataGridViewEx1.Columns.Add(checkColumn);
            this.dataGridViewEx1.Columns.Add("C1C", "C1C");
            this.dataGridViewEx1.Columns.Add("C2C", "C2C");

            var btnDelColumn = new DataGridViewButtonExColumn("删除", EApp.Properties.Resources.删除点击状态, EApp.Properties.Resources.删除未点击) { HeaderText = "删除" };
            this.dataGridViewEx1.Columns.Add(btnDelColumn);


            var btnEditColumn = new DataGridViewButtonExColumn("", EApp.Properties.Resources.下载点击状态, EApp.Properties.Resources.下载未点击) { HeaderText = "下载" };
            this.dataGridViewEx1.Columns.Add(btnEditColumn);
            //var check = new DataGridViewCheckBoxTextColumn() { Text="测试"};
            //this.dataGridViewEx1.Columns.Add(check);
            
            this.dataGridViewEx1.RowCount = 5;
            this.dataGridViewEx1.ListColumnImage.Add(EApp.Properties.Resources.选择);
            this.dataGridViewEx1.ListColumnImage.Add(EApp.Properties.Resources.听诊器所属人);
            this.dataGridViewEx1.ListColumnImage.Add(EApp.Properties.Resources.听诊器名称);
            this.dataGridViewEx1.ListColumnImage.Add(EApp.Properties.Resources.删除);
             this.dataGridViewEx1.ListColumnImage.Add(EApp.Properties.Resources.下载);
             ////System.Windows.Forms.CheckBoxEx ckBox = new System.Windows.Forms.CheckBoxEx();
             ////ckBox.Text = "全选";
             ////ckBox.Checked = true;
             ////System.Drawing.Rectangle rect =
             ////    dataGridView1.GetCellDisplayRectangle(0, -1, true);
             ////ckBox.Size = new System.Drawing.Size(dataGridView1.Columns[0].Width, 18);
             ////ckBox.Location = rect.Location;
             ////dataGridView1.Controls.Add(ckBox);
            foreach (DataGridViewRow row in this.dataGridViewEx1.Rows)
            {
                row.Cells[0].Value = row.Index % 2 == 0;
                row.Cells[1].Value = row.Index + "RowData";
                row.Cells[2].Value = row.Index + "RowData";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

         

        

        
    }
}
