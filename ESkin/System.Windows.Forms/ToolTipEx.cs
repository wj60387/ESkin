using System;

using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace  System.Windows.Forms
{
    public class ToolTipEx:Control
    {
        string tipMsg = string.Empty;
        public string TipMsg { get { return tipMsg; } set {
            using(Graphics graphics = CreateGraphics())
            {
                var sizeF = graphics.MeasureString(value, this.Font);
                this.Size = new Size((int)sizeF.Width * 2, (int)sizeF.Height * 2);
            }
            this.Invalidate();
        } }
        public static ToolTipEx Current { get; set; }
        static ToolTipEx()
        {
            Current = new ToolTipEx();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawString(TipMsg, this.Font, new SolidBrush(ForeColor), this.ClientRectangle, new StringFormat() {
            Alignment= StringAlignment.Center,
            LineAlignment= StringAlignment.Center
            });
            base.OnPaint(e);
        }
        public static void ShowTip(string Msg)
        {
            Current.TipMsg = Msg;
        }
    }
}
