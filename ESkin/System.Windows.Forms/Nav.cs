using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms
{

    
    public class Nav : Control
    {
        public event Action<NavItem> OnItemClick;
        public event Action OnXTClick;
        public event Action OnGYClick;
        public Nav()
        {
            this.Size = new Size(120, 400);
            this.BackColor = Color.White;
            this.ForeColor = Color.DarkOrange;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackgroundImage = ESkin.Properties.Resources.导航栏;
            this.itemHeight = 100;
        }

        int logoHeight = 110;
        public int LogoHeight
        {
            get { return logoHeight; }
            set {   logoHeight=value; }
        }

        public List<NavItem> NavItemList = new List<NavItem>();

        private int itemHeight = 0;
        public int ItemHeight
        {
            get
            {
                return itemHeight;

            }
            set
            {
                itemHeight = value;
            }
        }
        private int padding = 0;
        public int Pading
        {
            get
            {
                return padding;

            }
            set
            {
                padding = value;
            }
        }
        NavItem ActiveItem = null;
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            ActiveItem = GetItemByPoint(e.Location);
            if (ActiveItem != null)
            {
                OnItemClick(ActiveItem);
            }
            Rectangle sysBtnRect = new Rectangle(0, this.itemHeight * NavItemList.Count + 16 + LogoHeight, this.Width, 21);
            Rectangle xtRect = new Rectangle(sysBtnRect.X  , sysBtnRect.Y, sysBtnRect.Width / 2, sysBtnRect.Height);
            Rectangle gyRect = new Rectangle(sysBtnRect.X + sysBtnRect.Width / 2  , sysBtnRect.Y, sysBtnRect.Width / 2, sysBtnRect.Height);

            if (xtRect.Contains(e.Location))
            {
                if (OnXTClick != null)
                {
                    OnXTClick();
                }
            }
            if (gyRect.Contains(e.Location))
            {
                if (OnGYClick != null)
                {
                    OnGYClick();
                }
            }

        }
        NavItem GetItemByPoint(Point clientPoint)
        {
            for (int i = 0; i < NavItemList.Count; i++)
            {
                var boundItem = new Rectangle(0, i * itemHeight+LogoHeight, this.Width, this.itemHeight);

                if (boundItem.Contains(clientPoint))
                {
                    return NavItemList[i];
                }
            }
            return null;
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            this.Invalidate();
        }

        Size ImageSize = new Size(64, 64);
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //
            var logoRect = new Rectangle(0, 0, this.Width, LogoHeight);
            e.Graphics.DrawString("LOGO", new Font("微软雅黑", 16f), Brushes.Black, logoRect, new StringFormat() { 
            Alignment= StringAlignment.Center,
            LineAlignment= StringAlignment.Center
            });
            for (int i = 0; i < NavItemList.Count; i++)
            {
                //  if (!NavItemList[i].ISNomal) continue;
                var boundItem = new Rectangle(0, i * itemHeight + LogoHeight, this.Width, this.itemHeight);
                if (ActiveItem == NavItemList[i]  )
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(9, 61, 133)), boundItem);
                    var _rect = new Rectangle(boundItem.X + boundItem.Width - 5, boundItem.Y, 6, boundItem.Height);
                    e.Graphics.FillRectangle(new SolidBrush(Color.DarkGoldenrod), _rect);
                }

                var curpoint = this.PointToClient(MousePosition);
                if (ActiveItem != NavItemList[i] && boundItem.Contains(curpoint) )
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(9, 161, 133)), boundItem);
                    var _rect = new Rectangle(boundItem.X + boundItem.Width - 5, boundItem.Y, 6, boundItem.Height);
                    e.Graphics.FillRectangle(new SolidBrush(Color.DarkGoldenrod), _rect);
                }


                // e.Graphics.DrawRectangle(Pens.Red, boundItem);

                var image = NavItemList[i].Image;

                var rectImage = new Rectangle(boundItem.X + Pading, boundItem.Y + 10, ImageSize.Width, ImageSize.Height);
                if (image!=null)
                e.Graphics.DrawImage(image, rectImage, new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);

                var text = NavItemList[i].Text ?? string.Empty;
                var rect = new Rectangle(0, boundItem.Y + +10 + 64, this.Width, boundItem.Height-10-64);
                using (var brush = new SolidBrush(this.ForeColor))
                {
                    e.Graphics.DrawString(text, this.Font, brush, rect, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                }
                // e.Graphics.DrawImage(image, boundItem.X  - Pading + itemHeight / 2 - image.Width/2, boundItem.Y + Pading);

            }

            {
                var rect = new Rectangle(0, this.itemHeight * NavItemList.Count + 60 + LogoHeight, this.Width, 40);
                var point = this.PointToClient(MousePosition);
                var text = string.Format("{0}:{1}", point.X, point.Y);
                using (var brush = new SolidBrush(this.ForeColor))
                {
                    e.Graphics.DrawString(text, this.Font, brush, rect, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });


                    Rectangle sysBtnRect = new Rectangle(0, this.itemHeight * NavItemList.Count + 16 + LogoHeight, this.Width, 21);
                    Rectangle xtRect = new Rectangle(sysBtnRect.X + 21, sysBtnRect.Y, sysBtnRect.Width / 2, sysBtnRect.Height);
                    Rectangle gyRect = new Rectangle(sysBtnRect.X + sysBtnRect.Width / 2 + 21, sysBtnRect.Y, sysBtnRect.Width / 2, sysBtnRect.Height);

                    e.Graphics.DrawImage(ESkin.Properties.Resources.系统设置, 0, sysBtnRect.Y);
                    e.Graphics.DrawString("系统", this.Font, brush, xtRect, new StringFormat() { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                    e.Graphics.DrawImage(ESkin.Properties.Resources.系统关于, sysBtnRect.Width / 2, sysBtnRect.Y);
                    e.Graphics.DrawString("关于", this.Font, brush, gyRect, new StringFormat() { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });

                    // e.Graphics.DrawRectangle(Pens.Red, sysBtnRect);
                }
            }
        }
    
    }


    [Serializable]
    public class NavItem
    {
        public NavItem(Image Image,string Text)
        {
            this.image = Image;
            this.text = Text;
        }
          Image image{get;set;}
          public Image Image
          {
              get
              {
                  return image;
              }
              set
              {
                  image = value;
              }
          }
        string text = string.Empty;
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }
          bool isNomal = true;
          public bool ISNomal
          {
              get { return isNomal; }
              set { isNomal = value; }
          }
    }
}
