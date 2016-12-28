using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace  System.Windows.Forms
{


    public class DataGridViewEx:DataGridView
    {
        public DataGridViewEx()
        {
            SetStyle(
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.SupportsTransparentBackColor, true);
            this.BackgroundColor = Color.White;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.BorderStyle = Forms.BorderStyle.None;
            this.CellBorderStyle = DataGridViewCellBorderStyle.None;

            this.DefaultCellStyle.BackColor = DefaultCellStyle.SelectionBackColor = Color.White;
            this.DefaultCellStyle.SelectionForeColor = Color.FromArgb(100, 200, 250);
             
            this.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            //行头样式消除
            this.EnableHeadersVisualStyles = false;


            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ColumnHeadersHeight = 24;
            this.ColumnHeadersDefaultCellStyle.BackColor = ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            this.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(100, 200, 250);
            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.RowHeadersDefaultCellStyle.BackColor = RowHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            this.RowHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(100, 200, 250);
            //去掉小三角
            this.RowHeadersDefaultCellStyle.Padding = new Padding(this.RowHeadersWidth);

            this.ReadOnly = true;
                
        }
        Image xhImage = ESkin.Properties.Resources.序号;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //StringFormat sfn = new StringFormat();
            //sfn.Alignment = StringAlignment.Center;
            //sfn.LineAlignment = StringAlignment.Center;
            //e.Graphics.DrawString("序号", this.Font, new SolidBrush(this.ForeColor), new Rectangle(0, 0, this.RowHeadersWidth, this.ColumnHeadersHeight), sfn);
            System.Drawing.Rectangle xh = this.GetCellDisplayRectangle(-1, -1, true);
            e.Graphics.DrawImage(xhImage, xh.X+ 4  , xh.Y + 4, xhImage.Width, xhImage.Height);
            
            if (ListColumnImage.Count == this.Columns.Count)
                for (int i = 0; i < this.Columns.Count; i++)
                {
                    System.Drawing.Rectangle rect = this.GetCellDisplayRectangle(i, -1, true);
                    e.Graphics.DrawImage(ListColumnImage[i], rect.X + rect.Width / 2 + 4, rect.Y + 4, ListColumnImage[i].Width, ListColumnImage[i].Height);
                    // e.Graphics.DrawRectangle(  Pens.Red, rect);
                }
        }
        public List<Image> ListColumnImage = new List<Image>();
        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {
            base.OnRowPostPaint(e);
            var rowIdx = (e.RowIndex + 1).ToString();
            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,


            };
            var color = this.Rows[e.RowIndex].Selected ? Color.FromArgb(100, 200, 250) : Color.Black;

            var rowBounds = new Rectangle(e.RowBounds.X - 1, e.RowBounds.Y, e.RowBounds.Width + 1, e.RowBounds.Height - 1);
            if (this.Rows[e.RowIndex].Selected)
                e.Graphics.DrawRectangle(new Pen(color), rowBounds);

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, this.RowHeadersWidth, e.RowBounds.Height);
            using (var brush = new SolidBrush(color))
            {
                e.Graphics.DrawString(rowIdx, this.Font, brush, headerBounds, centerFormat);

            }
            
        }
        protected override void OnRowPrePaint(DataGridViewRowPrePaintEventArgs e)
        {
            base.OnRowPrePaint(e);
        }
       
    }

    class DataGridViewCheckBoxTextControl : CheckBoxEx, IDataGridViewEditingControl
    {
        /// <summary>
        /// 当前所在表格
        /// </summary>
        private DataGridView MyDataGridView { set; get; }
        /// <summary>
        /// 值是否发生更改
        /// </summary>
        private bool ValueChanged { set; get; }
        /// <summary>
        /// 当前所在行
        /// </summary>
        private int RowIndex { set; get; }

        protected override void OnCheckedChanged(EventArgs e)
        {
            ValueChanged = true;
            this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnCheckedChanged(e);
        }

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            Font = dataGridViewCellStyle.Font;
            ForeColor = dataGridViewCellStyle.ForeColor;
            BackColor = dataGridViewCellStyle.BackColor;
        }

        public DataGridView EditingControlDataGridView
        {
            get
            {
                return MyDataGridView;
            }
            set
            {
                MyDataGridView = value;
            }
        }

        public object EditingControlFormattedValue
        {
            get
            {
                return GetEditingControlFormattedValue(DataGridViewDataErrorContexts.Formatting);
            }
            set
            {
                Checked = value == null ? false : (bool)value;
            }
        }

        public int EditingControlRowIndex
        {
            get
            {
                return RowIndex;
            }
            set
            {
                RowIndex = value;
            }
        }

        public bool EditingControlValueChanged
        {
            get
            {
                return ValueChanged;
            }
            set
            {
                ValueChanged = value;
            }
        }

        public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
        {
            switch (keyData & Keys.KeyCode)
            {
                case Keys.LButton:
                    return !dataGridViewWantsInputKey;
            }
            return !dataGridViewWantsInputKey;
        }

        public Cursor EditingPanelCursor
        {
            get { return Cursors.Default; }
        }

        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return this.Checked;
        }

        public void PrepareEditingControlForEdit(bool selectAll)
        {

        }

        public bool RepositionEditingControlOnValueChange
        {
            get { return false; }
        }
    }
    public class DataGridViewCheckBoxExCell : DataGridViewCell
    {
        public DataGridViewCheckBoxExCell() : base() { }

        private static Type defaultEditType = typeof(DataGridViewCheckBoxTextControl);
        private static Type defaultValueType = typeof(System.Boolean);

        public override Type EditType
        {
            get { return defaultEditType; }
        }

        /// <summary>
        /// 单元格边框颜色
        /// </summary>
       // private Color CellBorderColor { get { return Color.Transparent; } }
        private Color CellBorderColor { get { return Color.FromArgb(100,200,250); } }
       // private Color CellBorderColor { get { return Color.Transparent; } }
        ControlState _controlState = ControlState.Normal;
        ControlState ControlState
        {
            get { return _controlState; }
            set
            {
                if (_controlState != value)
                {
                    _controlState = value;
                }
            }
        }

        
        public Image image = ESkin.Properties.Resources._16x16_没勾选;
        
        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {

            var boundRect = new Rectangle(cellBounds.X, cellBounds.Y , cellBounds.Width, cellBounds.Height - 1);
            
            var check = (Boolean)value;
            if (paintParts == DataGridViewPaintParts.Background || paintParts == DataGridViewPaintParts.All)
            {
                graphics.FillRectangle(new SolidBrush(Color.White), boundRect);
               // graphics.FillRectangle(new SolidBrush(cellStyle.BackColor), boundRect);
            }
            if (paintParts == DataGridViewPaintParts.Border || paintParts == DataGridViewPaintParts.All)
            {
                // var color = cellState == DataGridViewElementStates.Selected ? Color.Red : Color.Transparent;
                // graphics.DrawLine(new Pen(CellBorderColor), cellBounds.X, cellBounds.Y, cellBounds.X + cellBounds.Width,  cellBounds.Y);
                graphics.DrawRectangle(new Pen(Color.White), boundRect);
            }
            if (paintParts == DataGridViewPaintParts.SelectionBackground || Selected)
            {
                //graphics.FillRectangle(new SolidBrush(cellStyle.SelectionBackColor), cellBounds);
            }
            //var col = OwningColumn as DataGridViewCheckBoxTextColumn;
            //if (col != null && !string.IsNullOrEmpty(col.Text))
            //{
            graphics.DrawString(check ? "TRUE" : "FALSE", cellStyle.Font, new SolidBrush(Selected ?
                cellStyle.SelectionForeColor : cellStyle.ForeColor),
                new Point(cellBounds.X + 25, cellBounds.Y + cellBounds.Height / 4));
            //}

            if ((cellState & DataGridViewElementStates.Selected)!=0)
            {
                image = check ? ESkin.Properties.Resources._16x16勾选点击状态 : ESkin.Properties.Resources._16x16_没勾选点击状态;
            }
            else
            {
                image = check ? ESkin.Properties.Resources._16x16勾选 : ESkin.Properties.Resources._16x16_没勾选;
            }
                    //switch (ControlState)
                    //{
                    //    case ControlState.Hover:
                    //        image = check ? ESkin.Properties.Resources._16x16勾选点击状态 : ESkin.Properties.Resources._16x16_没勾选点击状态;
                    //        break;
                    //    case ControlState.Pressed:
                    //        image = check ? ESkin.Properties.Resources._16x16勾选点击状态 : ESkin.Properties.Resources._16x16_没勾选点击状态;
                    //        break;
                    //    default:
                    //        image = check ? ESkin.Properties.Resources._16x16勾选 : ESkin.Properties.Resources._16x16_没勾选;
                    //        break;
                    //}

                    var rect = new Rectangle(cellBounds.X+4,cellBounds.Y+ cellBounds.Height / 2 - image.Height / 2, image.Width, image.Height);
            //  image = check ? ESkin.Properties.Resources._16x16勾选点击状态 : ESkin.Properties.Resources._16x16_没勾选点击状态;
                   graphics.DrawImage(image, rect);
            //CheckBoxRenderer.DrawCheckBox(graphics, new Point(cellBounds.X + 4, cellBounds.Y + cellBounds.Height / 4), CheckState);
           // base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
        }

        /// <summary>
        /// <summary>
        /// 当前复选框的状态
        /// </summary>
        private CheckBoxState CheckState { set; get; }

       

        protected override void OnMouseUp(DataGridViewCellMouseEventArgs e)
        {
            var check = (bool)Value;
            Value = !check;
            SetValue(RowIndex, Value);
            CheckState = check ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal;
            base.OnMouseUp(e);
        }

        public override Type ValueType
        {
            get
            {
                Type valueType = base.ValueType;
                if (valueType != null)
                {
                    return valueType;
                }
                return defaultValueType;
            }
        }

        public override object DefaultNewRowValue
        {
            get
            {
                return true;
            }
        }
    }

    public class DataGridViewCheckBoxExColumn : DataGridViewColumn
    {
        
        
        public DataGridViewCheckBoxExColumn()
            : base()
        {
            CellTemplate = new DataGridViewCheckBoxExCell();
        }

        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                if (value != null && !value.GetType().IsAssignableFrom(typeof(DataGridViewCheckBoxExCell)))
                {
                    throw new Exception("这个列里面必须绑定MyDataGridViewCheckBoxCell");
                }
                base.CellTemplate = value;
            }
        }

        public override object Clone()
        {
            DataGridViewCheckBoxExColumn col = (DataGridViewCheckBoxExColumn)base.Clone();
            col.Text = Text;
            return col;
        }

        public string Text { set; get; }


    }
}
