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
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.BorderStyle = Forms.BorderStyle.None;
            this.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.RowHeadersDefaultCellStyle.BackColor = Color.Transparent;
            this.DefaultCellStyle.SelectionBackColor = this.BackgroundColor ;
        }
        protected override void OnRowPrePaint(DataGridViewRowPrePaintEventArgs e)
        {
            base.OnRowPrePaint(e);
            if ((e.State & DataGridViewElementStates.Selected) ==
                      DataGridViewElementStates.Selected)
            {
                // 计算选中区域Size
                int width = this.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + RowHeadersWidth;

                Rectangle rowBounds = new Rectangle(
                  0, e.RowBounds.Top, width,
                    e.RowBounds.Height -1);


                e.Graphics.DrawRectangle(Pens.Red, rowBounds);
                // e.Graphics.FillRectangle(backbrush, rowBounds);
                 e.PaintCellsContent(rowBounds);
                e.Handled = true;
            }
        }
       
    }

    public class DataGridViewCheckBoxTextControl : CheckBoxEx, IDataGridViewEditingControl
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
    public class DataGridViewCheckBoxTextCell : DataGridViewCell
    {
        public DataGridViewCheckBoxTextCell() : base() { }

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

        protected override void OnLeave(int rowIndex, bool throughMouseClick)
        {
            OnMouseLeave(rowIndex);
            base.OnLeave(rowIndex, throughMouseClick);
        }
        protected override void OnMouseLeave(int rowIndex)
        {
            base.OnMouseLeave(rowIndex);
               ControlState = ControlState.Normal;
        }
        

        
        protected override void OnMouseMove(DataGridViewCellMouseEventArgs e)
        {
            ControlState = ControlState.Hover;
            base.OnMouseMove(e);
        }
        protected override void OnMouseDown(DataGridViewCellMouseEventArgs e)
        {
            var check = (bool)Value;
            CheckState = check ? CheckBoxState.CheckedPressed : CheckBoxState.UncheckedPressed;
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                ControlState = ControlState.Pressed;
            }
            base.OnMouseDown(e);
        }
        //protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
        //{
             
        //    this.OnMouseDown(e);
        //    base.OnMouseClick(e);
        //}
        
        protected override void OnEnter(int rowIndex, bool throughMouseClick)
        {
            OnMouseEnter(rowIndex);
            base.OnEnter(rowIndex, throughMouseClick);
        }
        protected override void OnMouseEnter(int rowIndex)
        {
            ControlState = ControlState.Hover;
            base.OnMouseEnter(rowIndex);
        }
        public Image image = ESkin.Properties.Resources._16x16_没勾选;
        
        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            
            cellBounds.Height -= 1 ;
            var check = (Boolean)value;
            if (paintParts == DataGridViewPaintParts.Background || paintParts == DataGridViewPaintParts.All)
            {
                graphics.FillRectangle(new SolidBrush(cellStyle.BackColor), cellBounds);
            }
            if (paintParts == DataGridViewPaintParts.Border || paintParts == DataGridViewPaintParts.All)
            {
                // var color = cellState == DataGridViewElementStates.Selected ? Color.Red : Color.Transparent;
                // graphics.DrawLine(new Pen(CellBorderColor), cellBounds.X, cellBounds.Y, cellBounds.X + cellBounds.Width,  cellBounds.Y);
                 //graphics.DrawRectangle(new Pen(CellBorderColor), cellBounds);
            }
            if (paintParts == DataGridViewPaintParts.SelectionBackground || Selected)
            {
                graphics.FillRectangle(new SolidBrush(cellStyle.SelectionBackColor), cellBounds);
            }
            //var col = OwningColumn as DataGridViewCheckBoxTextColumn;
            //if (col != null && !string.IsNullOrEmpty(col.Text))
            //{
                graphics.DrawString( check ?"TRUE":"FALSE", cellStyle.Font, new SolidBrush(Selected ?
                    cellStyle.SelectionForeColor : cellStyle.ForeColor),
                    new Point(cellBounds.X + 25, cellBounds.Y + cellBounds.Height / 4));
            //}
                 
                    switch (ControlState)
                    {
                        case ControlState.Hover:
                            image = check ? ESkin.Properties.Resources._16x16勾选点击状态 : ESkin.Properties.Resources._16x16_没勾选点击状态;
                            break;
                        case ControlState.Pressed:
                            image = check ? ESkin.Properties.Resources._16x16勾选点击状态 : ESkin.Properties.Resources._16x16_没勾选点击状态;
                            break;
                        default:
                            image = check ? ESkin.Properties.Resources._16x16勾选 : ESkin.Properties.Resources._16x16_没勾选;
                            break;
                    }

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

    public class DataGridViewCheckBoxTextColumn : DataGridViewColumn
    {
        
        
        public DataGridViewCheckBoxTextColumn()
            : base()
        {
            CellTemplate = new DataGridViewCheckBoxTextCell();
        }

        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                if (value != null && !value.GetType().IsAssignableFrom(typeof(DataGridViewCheckBoxTextCell)))
                {
                    throw new Exception("这个列里面必须绑定MyDataGridViewCheckBoxCell");
                }
                base.CellTemplate = value;
            }
        }

        public override object Clone()
        {
            DataGridViewCheckBoxTextColumn col = (DataGridViewCheckBoxTextColumn)base.Clone();
            col.Text = Text;
            return col;
        }

        public string Text { set; get; }


    }
}
