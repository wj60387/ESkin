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
      Color backColor = Color.Transparent;
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
        }
        protected override void OnEnter(EventArgs e)
        {
          //  backColor = Color.Red;
            base.OnEnter(e);
            //this.Invalidate();
        }
        protected override void OnLeave(EventArgs e)
        {
           // backColor = Color.Transparent;
            base.OnLeave(e);
           // this.Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.BackColor = backColor;
            this.Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            this.BackColor = backColor;
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {

            base.OnPaint(pevent);
        }
    }
}
