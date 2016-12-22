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
            //foreach (ToolStripItem item in toolStrip1.Items)
            //{
            //    item.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tsButton_MouseMove);
            //}
           
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           // e.ClickedItem.BackColor = Color.FromArgb(9,61,133);
        }

        private void tsButton_MouseMove(object sender, MouseEventArgs e)
        {
            //foreach (ToolStripItem item in toolStrip1.Items)
            //{
            //    item.BackColor = Color.FromArgb(232, 239, 241);
            //}
            var toolStripItem = sender
                as ToolStripItem;
            toolStripItem.BackColor = Color.FromArgb(9, 61, 133);
        }
    }
}
