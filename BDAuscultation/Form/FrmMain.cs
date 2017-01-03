using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BDAuscultation
{
    public partial class FrmMain : FormEx
    {
        public FrmMain()
        {
            InitializeComponent();
            Init();
            this.SizeChanged += FrmMain_SizeChanged;
            this.Load += FrmMain_Load;
            
            //this.toolStripEx1.RenderMode = ToolStripRenderMode
            //    .Custom;
            
        }
        void Init()
        {
            
             

           


            dgvTZJX.ListColumnImage.Add(BDAuscultation.Properties.Resources.听诊器编号);
            dgvTZJX.ListColumnImage.Add(BDAuscultation.Properties.Resources.听诊器名字);
            dgvTZJX.ListColumnImage.Add(BDAuscultation.Properties.Resources.听诊器所属人);
            dgvTZJX.ListColumnImage.Add(BDAuscultation.Properties.Resources.连接状态);
            dgvTZJX.ListColumnImage.Add(null);
            var tzjxBtnCheckColumn = new DataGridViewCheckBoxExColumn() { HeaderText = "选择", Text = "选择", AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = 60 };
            dgvTZJX.Columns.Add(tzjxBtnCheckColumn);

            InitdgvTZPZ();

            
        }
        void FrmMain_Load(object sender, EventArgs e)
        {
            this.nav1.NavItemList.Add(new NavItem(null, "LOGO") { ISNomal = false });
            this.nav1.NavItemList.Add(new NavItem(BDAuscultation.Properties.Resources.听诊配置, "听诊配置"));
            this.nav1.NavItemList.Add(new NavItem(BDAuscultation.Properties.Resources.听诊教学, "听诊教学"));
            this.nav1.NavItemList.Add(new NavItem(BDAuscultation.Properties.Resources.听诊录音, "听诊录音"));
            this.nav1.NavItemList.Add(new NavItem(BDAuscultation.Properties.Resources.云端听诊, "云端听诊"));
            this.nav1.NavItemList.Add(new NavItem(BDAuscultation.Properties.Resources.远程教学, "远程教学"));
            nav1.OnItemClick += nav1_OnItemClick;
            nav1.OnXTClick += nav1_OnXTClick;
            nav1.OnGYClick += nav1_OnGYClick;
            //for (int i = 0; i < 6; i++)
            //{
            //    this.dgvTZQPZ.Rows.Add(i + "CellData1", i + "CellData2", i + "CellData3");
            //    this.dgvTZJX.Rows.Add(i + "CellData1", i + "CellData2", i + "CellData3");
            //    this.dgvTZJX.Rows[i].Cells[dgvTZJX.Columns.Count - 1].Value = i % 2 == 0;

            //}
             
        }
        void nav1_OnXTClick()
        {
           // MessageBox.Show("系统");
        }
        void nav1_OnGYClick()
        {
            //MessageBox.Show("关于");
        }
        void nav1_OnItemClick(NavItem obj)
        {
            switch (obj.Text)
            {
                case "听诊配置":
            this.tabControlEx1.SelectedTab = tabTZPZ;

                    break;
                case "听诊教学":
            this.tabControlEx1.SelectedTab = tabTZJX;
                    break;
                case "听诊录音":
            this.tabControlEx1.SelectedTab = tabTZLY;
                    break;
                case "云端听诊":
            this.tabControlEx1.SelectedTab = tabYDTZ;
                    break;
                case "远程教学":
            this.tabControlEx1.SelectedTab = tabYCTZ;
                    break;

            }
        }
        void Nav_MouseLeave(object sender, EventArgs e)
        {
            var btn = sender as ButtonEx;
            btn.BackColor = Color.Transparent;
        }

        void Nav_MouseEnter(object sender, EventArgs e)
        {
            var btn = sender as ButtonEx;
            btn.BackColor = Color.Red;
        }

        void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            if(tabControlEx1.SelectedTab!=null)
            {
                tabControlEx1.SelectedTab.Invalidate();
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
