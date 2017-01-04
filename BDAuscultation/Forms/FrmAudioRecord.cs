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
    public partial class FrmAudioRecord : Form
    {
        public string PatientGUID { get; set; }
        public string StetName { get; set; }
        public int PatientType { get; set; }
        public FrmAudioRecord()
        {
            InitializeComponent();
        }
    }
}
