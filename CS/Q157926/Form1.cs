using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;
using System.Collections;
using DevExpress.XtraEditors;

namespace Q157926 {
    public partial class Form1 :Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);
            layout.FocusHelper = new MyFocusHelper(layout);
        }
    }

    public class MyFocusHelper :FocusHelperBase {
        public MyFocusHelper(ILayoutControl control) : base(control) { }

        private LayoutGroup focusedGroup;
        protected override ArrayList FilterElements(ArrayList list, bool tabStopOnly) {
            ContainerControl container = layoutControl.Control as ContainerControl;
            if (container != null && container.ActiveControl != null) {
                Control activeControl = container.ActiveControl;
                if (activeControl is TextBoxMaskBox) activeControl = activeControl.Parent;
                focusedGroup = layoutControl.GetItemByControl(activeControl).Parent;
            }
            //focusedGroup = null;
            return base.FilterElements(list, tabStopOnly);
        }

        protected override bool CheckItem(BaseLayoutItem item, bool tabStopOnly) {
            if (focusedGroup != null && item.Parent != focusedGroup) return false;
            return base.CheckItem(item, tabStopOnly);
        }
    }
}