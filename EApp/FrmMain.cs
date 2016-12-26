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
            //this.dataGridViewEx1.Columns.Add("C1","C2");
             this.dataGridView1.RowCount = 5;

            //System.Windows.Forms.CheckBoxEx ckBox = new System.Windows.Forms.CheckBoxEx();
            //ckBox.Text = "全选";
            //ckBox.Checked = true;
            //System.Drawing.Rectangle rect =
            //    dataGridViewEx1.GetCellDisplayRectangle(0, -1, true);
            //ckBox.Size = new System.Drawing.Size(dataGridViewEx1.Columns[0].Width, 18);
            //ckBox.Location = rect.Location;
            //dataGridViewEx1.Controls.Add(ckBox);



            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                row.Cells[0].Value = row.Index%2==0 ;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
