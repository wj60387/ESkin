using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace  System.Windows.Forms
{
    public class ButtonEx : Button
    {
        public ButtonEx()
        {
            this.BackColor = Color.Transparent;
            this.FlatStyle = Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            
            base.OnMouseDown(e);
        }
    }
}
