using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using System.Drawing;
using System.ComponentModel;

namespace System.Windows.Forms
{
    //TypeConverter未解决
    //[DefaultProperty("Text"),TypeConverter(typeof(ChatListItemConverter))]
    public class ChatListItem
    {


       
        private string text = "Item";
        /// <summary>
        /// 获取或者设置列表项的显示文本
        /// </summary>
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Text {
            get { return text; }
            set {
                text = value;
                if (this.ownerChatListBox != null)
                    this.ownerChatListBox.Invalidate(this.bounds);
            }
        }
        /// <summary>
        /// 分组ID
        /// </summary>
        public int ID { get; set; }
        private bool isOpen;
        /// <summary>
        /// 获取或者设置列表项是否展开
        /// </summary>
        [DefaultValue(false)]
        public bool IsOpen {
            get { return isOpen; }
            set {
                isOpen = value;
              //  this.ownerChatListBox.Invalidate();
                if (this.ownerChatListBox != null)
                    this.ownerChatListBox.Invalidate();
            }
        }

         

        private bool isTwinkleHide;
        internal bool IsTwinkleHide {
            get { return isTwinkleHide; }
            set { isTwinkleHide = value; }
        }

        private Rectangle bounds;
        /// <summary>
        /// 获取列表项的显示区域
        /// </summary>
        [Browsable(false)]
        public Rectangle Bounds {
            get { return bounds; }
            internal set { bounds = value; }
        }

        private ChatListBox ownerChatListBox;
        /// <summary>
        /// 获取列表项所在的控件
        /// </summary>
        [Browsable(false)]
        public ChatListBox OwnerChatListBox {
            get { return ownerChatListBox; }
            internal set { ownerChatListBox = value; }
        }
        public ChatListItem() { if (this.text == null) this.text = string.Empty; }
        public ChatListItem(string text) { this.text = text; }
        public ChatListItem(int ID,string text) {
            this.ID = ID;
            this.text = text; }
        public ChatListItem(string text, bool bOpen) {
            this.text = text;
            this.isOpen = bOpen;
        }
    }
}
