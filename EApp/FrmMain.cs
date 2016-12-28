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

            this.dataGridViewEx1.Columns.Add(new DataGridViewCheckBoxTextColumn() { HeaderText = "选择" });
            this.dataGridViewEx1.Columns.Add("C1", "C1");
            this.dataGridViewEx1.Columns.Add("C2", "C2");
            this.dataGridViewEx1.RowCount = 5;

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

        
    }
}
