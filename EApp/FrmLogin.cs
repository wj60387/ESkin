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
    public partial class FrmLogin : FormEx
    {
        public FrmLogin()
        {
            InitializeComponent();
             
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmMain main = new FrmMain();
            main.Show();
        }
    }
}
