using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;

namespace WindowsApplication1 {
    public class MyGridControl : GridControl {
        public MyGridControl() : base() { }
        protected override void RegisterAvailableViewsCore(InfoCollection collection) {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridInfoRegistrator());
        }
    }

    public class MyGridView : GridView {
        public MyGridView() : base() { }
        public MyGridView(GridControl control) : base(control) { }
        protected override string ViewName { get { return "MyGridView"; } }
        protected override CheckedColumnFilterPopup CreateCheckedFilterPopup(GridColumn column, Control ownerControl, object creator) { 
            return new MyCheckedColumnFilterPopup(this, column, ownerControl, creator); 
        }
    }

    public class MyGridInfoRegistrator : GridInfoRegistrator {
        public MyGridInfoRegistrator() : base() { }
        public override string ViewName { get { return "MyGridView"; } }
        public override BaseView CreateView(GridControl grid) { return new MyGridView(grid); }
    }
}