using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms
{
    public class ToolStripEx:ToolStrip
    {
        public ToolStripEx()
        {
            this.AutoSize = false;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.Dock = System.Windows.Forms.DockStyle.Left;
            this.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "toolStripEx1";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Size = new System.Drawing.Size(100, 561);
            this.TabIndex = 0;
            this.Text = "toolStripEx1";

           // 232, 241, 249
        }
    }
}
