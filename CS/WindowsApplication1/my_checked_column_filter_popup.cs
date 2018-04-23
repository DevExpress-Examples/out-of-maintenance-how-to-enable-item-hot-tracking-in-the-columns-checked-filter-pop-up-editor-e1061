using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using System;
using DevExpress.XtraEditors;

namespace WindowsApplication1 {
    public class MyCheckedColumnFilterPopup :CheckedColumnFilterPopup {
        public MyCheckedColumnFilterPopup(ColumnView view, GridColumn column, Control owner, object creator) : base(view, column, owner, creator) { }

        protected override RepositoryItemPopupBase CreateRepositoryItem() {
            RepositoryItemFilterComboBox ret = base.CreateRepositoryItem() as RepositoryItemFilterComboBox;
            ret.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            ret.Popup += new EventHandler(ret_Popup);
            ret.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(ret_CloseUp);
            return ret;
        }

        void ret_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e) {
            RepositoryItemFilterComboBox ret = base.CreateRepositoryItem() as RepositoryItemFilterComboBox;
            ret.Popup -= new EventHandler(ret_Popup);
            ret.CloseUp -= new DevExpress.XtraEditors.Controls.CloseUpEventHandler(ret_CloseUp);
        }

        void ret_Popup(object sender, EventArgs e) {
            CheckedListBoxControl c = (sender as PopupContainerEdit).Properties.PopupControl.Controls[0] as CheckedListBoxControl;
            c.HotTrackItems = true;
        }
    }
}
