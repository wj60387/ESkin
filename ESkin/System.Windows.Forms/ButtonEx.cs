using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace  System.Windows.Forms
{
    public class ButtonEx : Button
    {

        //bool isRadiusButton = false;
        //public bool IsRadiusButton
        //{
        //    get { return isRadiusButton; }
        //    set { isRadiusButton = value; this.Invalidate(); }
        //}
          int radius=16;
        public int Radius
        {
            get{return radius;}
             set { radius = value; this.Invalidate(); }
        }
       
        //  public Color RadiusColor
        //{
        //    get { return color; }
        //    set { color = value; this.Invalidate(); }
        //}
        Color pressColor = Color.FromArgb(80, 105, 251);
          public Color PressColor
          {
              get { return pressColor; }
              set { pressColor = value; this.Invalidate(); }
          }
          Color hoverColor = Color.FromArgb(60, 85, 230);
          public Color HoverColor
          {
              get { return hoverColor; }
              set { hoverColor = value; this.Invalidate(); }
          }
          Color normalColor = Color.FromArgb(60, 135, 251);
          public Color NormalColor
          {
              get { return normalColor; }
              set { normalColor = value; this.Invalidate(); }
          }

        ControlState ControlState = ControlState.Normal;
        public ButtonEx()
        {
            this.SetStyle(
               ControlStyles.UserPaint |  //控件自行绘制，而不使用操作系统的绘制
               ControlStyles.AllPaintingInWmPaint | //忽略擦出的消息，减少闪烁。
               ControlStyles.OptimizedDoubleBuffer |//在缓冲区上绘制，不直接绘制到屏幕上，减少闪烁。
               ControlStyles.ResizeRedraw | //控件大小发生变化时，重绘。                  
               ControlStyles.SupportsTransparentBackColor, true);//支持透明背景颜色
            this.BackColor = Color.Transparent;
            this.FlatStyle = Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.FlatAppearance.MouseOverBackColor = Color.Transparent;
            
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if(e.Button!= Forms.MouseButtons.Left)
                ControlState = Forms.ControlState.Hover;
            this.Invalidate();
        }
        

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            ControlState = Forms.ControlState.Normal;
            this.Invalidate();
        }
       
        protected override void OnMouseDown(MouseEventArgs e)
        {
           
            base.OnMouseDown(e);
            if (e.Button == Forms.MouseButtons.Left)
            {
                ControlState = Forms.ControlState.Pressed;
                this.Invalidate();
            }

        }
         
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            ControlState = Forms.ControlState.Normal;
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {

            Color color;
            switch (ControlState)
            {
                case  Forms.ControlState.Pressed:
                    color = PressColor;
                    break;
                case Forms.ControlState.Hover:
                    color = HoverColor;
                    break;
                default:
                    color = NormalColor;
                    break;
            }
            base.OnPaintBackground(e);
            base.OnPaint(e);
            if (BackgroundImage == null)
            {
                using (var brush = new SolidBrush(color))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                    e.Graphics.FillPath(brush, DrawRoundRect(e.ClipRectangle.X, e.ClipRectangle.Y,
                        e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 1, radius));
                }
                using (var brush = new SolidBrush(this.ForeColor))
                {
                    e.Graphics.DrawString(this.Text, this.Font, brush, e.ClipRectangle,
                        new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                }
            }

        }
        public ArcRadius ArcRadius { get; set; }
         
        public   GraphicsPath DrawRoundRect(int x, int y, int width, int height, int radius)
        {
             var rect = new Rectangle(x, y, width, height);
            //GraphicsPath gp = new GraphicsPath();
            //gp.AddArc(x, y, radius, radius, 180, 90);
            //gp.AddArc(width - radius, y, radius, radius, 270, 90);
            //gp.AddArc(width - radius, height - radius, radius, radius, 0, 90);
            //gp.AddArc(x, height - radius, radius, radius, 90, 90);
            //gp.CloseAllFigures();
            //return gp;
            return GraphicsPathHelper.CreateRoundPath(rect,ArcRadius );
        }
    }

    public class ArcRadiusConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context,
   Type sourceType)
        {
            if (sourceType == typeof(string)) return true;//字符串，如："Jonny,Sun,33" 
            return base.CanConvertFrom(context, sourceType);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(string)) return true;
            if (destinationType == typeof(InstanceDescriptor)) return true;
            return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            string s = value as string;
            if (s == null) return base.ConvertFrom(context, culture, value);
            //字符串，如："Jonny,Sun,33" 
            string[] ps = s.Split(new char[] { char.Parse(",") });
            if (ps.Length != 4)
                throw new ArgumentException("参数异常");
            //解析字符串并实例化对象 
            return new ArcRadius(int.Parse(ps[0]), int.Parse(ps[1]), int.Parse(ps[2]), int.Parse(ps[3]));
        }

        public override object ConvertTo(ITypeDescriptorContext context,
        CultureInfo culture,
        object value,
        Type destinationType)
        {
            //将对象转换为字符串，如："Jonny,Sun,33" 
            if ((destinationType == typeof(string)) && (value is ArcRadius))
            {
                var obj = (ArcRadius)value;
                return string.Join(",", new string[]{obj.LeftTop.ToString()
              ,obj.RightTop.ToString()
              ,obj.LeftBottom.ToString()
              ,obj.RightBottom.ToString()});
            }
            //生成设计时的构造器代码 
            // this.testComponent1.Person = new CSFramework.MyTypeConverter.Person("Jonny", "Sun", 33); 
            if (destinationType == typeof(InstanceDescriptor) && value is ArcRadius)
            {
                ArcRadius obj = (ArcRadius)value;
                ConstructorInfo ctor = typeof(ArcRadius).GetConstructor(
                new Type[] { typeof(int), typeof(int), typeof(int), typeof(int) });
                return new InstanceDescriptor(ctor, new object[] { obj.LeftTop
              ,obj.RightTop
              ,obj.LeftBottom
              ,obj.RightBottom });
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }

        public override object CreateInstance(ITypeDescriptorContext context,
        IDictionary propertyValues)
        {
            int LeftTop = (int)propertyValues["LeftTop"];
            int LeftBottom = (int)propertyValues["LeftBottom"];
            int RightTop = (int)propertyValues["RightTop"];
            int RightBottom = (int)propertyValues["RightBottom"];
            return new ArcRadius(LeftTop, RightTop, LeftBottom, RightBottom);//创建实例 
        }
        public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override PropertyDescriptorCollection GetProperties(
                            ITypeDescriptorContext context,
                            object value, Attribute[] attributes)
        {
            if (value is ArcRadius)
                return TypeDescriptor.GetProperties(value, attributes);

            return base.GetProperties(context, value, attributes);
        }

        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }
    }
    [Serializable]
    [Browsable(true)]
    [ComVisible(true)]
    [TypeConverter(typeof(ArcRadiusConverter))]
    public struct ArcRadius
    {
        private int _rightBottom;
        private int _rightTop;
        private int _leftBottom;
        private int _leftTop;

        public static readonly ArcRadius Empty = new ArcRadius(0);

        public ArcRadius(int radiusLength)
        {
            if (radiusLength < 0)
            {
                radiusLength = 0;
            }

            this._rightBottom = this._rightTop = this._leftBottom = this._leftTop = radiusLength;
        }

        public ArcRadius(int leftTop, int rightTop, int leftBottom, int rightBottom)
        {
            this._rightBottom = rightBottom < 0 ? 0 : rightBottom;
            this._rightTop = rightTop < 0 ? 0 : rightTop;
            this._leftBottom = leftBottom < 0 ? 0 : leftBottom;
            this._leftTop = leftTop < 0 ? 0 : leftTop;
        }

        private bool IsAllEqual()
        {
            return ((this.RightBottom == this.RightTop)
                 && (this.RightBottom == this.LeftBottom))
                 && (this.RightBottom == this.LeftTop);
        }

        [Browsable(true)]
        public int All
        {
            get
            {
                if (!IsAllEqual())
                {
                    return -1;
                }

                return this.RightBottom;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                this.RightBottom = this.RightTop = this.LeftBottom = this.LeftTop = value;
            }
        }
        [Browsable(true)]
        public int LeftTop
        {
            get
            {
                return this._leftTop;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                this._leftTop = value;
            }
        }

        [Browsable(true)]
        public int RightTop
        {
            get
            {
                return this._rightTop;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                this._rightTop = value;
            }
        }

        [Browsable(true)]
        public int LeftBottom
        {
            get
            {
                return this._leftBottom;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                this._leftBottom = value;
            }
        }

        [Browsable(true)]
        public int RightBottom
        {
            get
            {
                return this._rightBottom;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                this._rightBottom = value;
            }
        }

        //public static bool operator ==(ArcRadius p1, ArcRadius p2)
        //{
        //    return ((((p1.RightTop == p2.RightTop)
        //        && (p1.RightBottom == p2.RightBottom))
        //        && (p1.LeftBottom == p2.LeftBottom))
        //        && (p1.LeftTop == p2.LeftTop));
        //}

        //public static bool operator !=(ArcRadius p1, ArcRadius p2)
        //{
        //    return !(p1 == p2);
        //}

        public override string ToString()
        {
            return LeftTop + ", " + RightTop + ", " + LeftBottom + ", " + RightBottom;
        }
    }
    public static class GraphicsPathHelper
    {
        public static GraphicsPath CreateRoundPath(Rectangle rect, ArcRadius arcRadius)
        {
            var path = new GraphicsPath();

            if (rect.Width == 0 || rect.Height == 0)
            {
                return path;
            }

            if (arcRadius.LeftTop > 0)
            {
                path.AddArc(
                    rect.Left, rect.Top, arcRadius.LeftTop, arcRadius.LeftTop, 180, 90);
            }

            path.AddLine(new Point(rect.Left + arcRadius.LeftTop, rect.Top),
                         new Point(rect.Right - arcRadius.RightTop, rect.Top));

            if (arcRadius.RightTop > 0)
            {
                path.AddArc(rect.Right - arcRadius.RightTop, rect.Top,
                    arcRadius.RightTop, arcRadius.RightTop, -90, 90);
            }

            path.AddLine(new Point(rect.Right, rect.Top + arcRadius.RightTop),
                         new Point(rect.Right, rect.Bottom - arcRadius.RightBottom));

            if (arcRadius.RightBottom > 0)
            {
                path.AddArc(rect.Right - arcRadius.RightBottom, rect.Bottom - arcRadius.RightBottom,
                    arcRadius.RightBottom, arcRadius.RightBottom, 0, 90);
            }

            path.AddLine(new Point(rect.Right - arcRadius.RightBottom, rect.Bottom),
                         new Point(rect.Left + arcRadius.LeftBottom, rect.Bottom));

            if (arcRadius.LeftBottom > 0)
            {
                path.AddArc(rect.Left, rect.Bottom - arcRadius.LeftBottom,
                    arcRadius.LeftBottom, arcRadius.LeftBottom, 90, 90);
            }

            path.AddLine(new Point(rect.Left, rect.Bottom - arcRadius.LeftBottom),
                         new Point(rect.Left, rect.Top + arcRadius.LeftTop));

            path.CloseFigure();

            return path;
        }
    }
}
