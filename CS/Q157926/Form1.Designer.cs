namespace Q157926 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.layout = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new Q157926.nwindDataSet();
            this.lookUpEdit3 = new DevExpress.XtraEditors.LookUpEdit();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lookUpEdit4 = new DevExpress.XtraEditors.LookUpEdit();
            this.ProductIDSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.ProductNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CategoryIDSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.SupplierIDSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.QuantityPerUnitTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UnitPriceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.ItemForProductID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCategoryID = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Product = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForUnitPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForQuantityPerUnit = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSupplierID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForProductName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.productsTableAdapter = new Q157926.nwindDataSetTableAdapters.ProductsTableAdapter();
            this.categoriesTableAdapter = new Q157926.nwindDataSetTableAdapters.CategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
            this.layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityPerUnitTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPriceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategoryID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQuantityPerUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSupplierID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.Controls.Add(this.dataNavigator1);
            this.layout.Controls.Add(this.lookUpEdit3);
            this.layout.Controls.Add(this.lookUpEdit4);
            this.layout.Controls.Add(this.ProductIDSpinEdit);
            this.layout.Controls.Add(this.ProductNameTextEdit);
            this.layout.Controls.Add(this.CategoryIDSpinEdit);
            this.layout.Controls.Add(this.SupplierIDSpinEdit);
            this.layout.Controls.Add(this.QuantityPerUnitTextEdit);
            this.layout.Controls.Add(this.UnitPriceSpinEdit);
            this.layout.DataSource = this.productsBindingSource;
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForProductID,
            this.ItemForCategoryID});
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.Root = this.layoutControlGroup1;
            this.layout.Size = new System.Drawing.Size(488, 186);
            this.layout.TabIndex = 0;
            this.layout.Text = "dataLayoutControl1";
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.DataSource = this.productsBindingSource;
            this.dataNavigator1.Location = new System.Drawing.Point(7, 7);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(475, 19);
            this.dataNavigator1.StyleController = this.layout;
            this.dataNavigator1.TabIndex = 1;
            this.dataNavigator1.Text = "dataNavigator1";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lookUpEdit3
            // 
            this.lookUpEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productsBindingSource, "CategoryID", true));
            this.lookUpEdit3.Location = new System.Drawing.Point(359, 89);
            this.lookUpEdit3.Name = "lookUpEdit3";
            this.lookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit3.Properties.DataSource = this.categoriesBindingSource;
            this.lookUpEdit3.Properties.DisplayMember = "Description";
            this.lookUpEdit3.Properties.ValueMember = "CategoryID";
            this.lookUpEdit3.Size = new System.Drawing.Size(120, 20);
            this.lookUpEdit3.StyleController = this.layout;
            this.lookUpEdit3.TabIndex = 3;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.nwindDataSet;
            // 
            // lookUpEdit4
            // 
            this.lookUpEdit4.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productsBindingSource, "CategoryID", true));
            this.lookUpEdit4.Location = new System.Drawing.Point(359, 58);
            this.lookUpEdit4.Name = "lookUpEdit4";
            this.lookUpEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit4.Properties.DataSource = this.categoriesBindingSource;
            this.lookUpEdit4.Properties.DisplayMember = "CategoryName";
            this.lookUpEdit4.Properties.ValueMember = "CategoryID";
            this.lookUpEdit4.Size = new System.Drawing.Size(120, 20);
            this.lookUpEdit4.StyleController = this.layout;
            this.lookUpEdit4.TabIndex = 4;
            // 
            // ProductIDSpinEdit
            // 
            this.ProductIDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productsBindingSource, "ProductID", true));
            this.ProductIDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ProductIDSpinEdit.Location = new System.Drawing.Point(0, 0);
            this.ProductIDSpinEdit.Name = "ProductIDSpinEdit";
            this.ProductIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ProductIDSpinEdit.Size = new System.Drawing.Size(0, 20);
            this.ProductIDSpinEdit.StyleController = this.layout;
            this.ProductIDSpinEdit.TabIndex = 4;
            // 
            // ProductNameTextEdit
            // 
            this.ProductNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productsBindingSource, "ProductName", true));
            this.ProductNameTextEdit.Location = new System.Drawing.Point(116, 58);
            this.ProductNameTextEdit.Name = "ProductNameTextEdit";
            this.ProductNameTextEdit.Size = new System.Drawing.Size(120, 20);
            this.ProductNameTextEdit.StyleController = this.layout;
            this.ProductNameTextEdit.TabIndex = 5;
            // 
            // CategoryIDSpinEdit
            // 
            this.CategoryIDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productsBindingSource, "CategoryID", true));
            this.CategoryIDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.CategoryIDSpinEdit.Location = new System.Drawing.Point(0, 0);
            this.CategoryIDSpinEdit.Name = "CategoryIDSpinEdit";
            this.CategoryIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.CategoryIDSpinEdit.Size = new System.Drawing.Size(0, 20);
            this.CategoryIDSpinEdit.StyleController = this.layout;
            this.CategoryIDSpinEdit.TabIndex = 6;
            // 
            // SupplierIDSpinEdit
            // 
            this.SupplierIDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productsBindingSource, "SupplierID", true));
            this.SupplierIDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SupplierIDSpinEdit.Location = new System.Drawing.Point(116, 89);
            this.SupplierIDSpinEdit.Name = "SupplierIDSpinEdit";
            this.SupplierIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.SupplierIDSpinEdit.Size = new System.Drawing.Size(120, 20);
            this.SupplierIDSpinEdit.StyleController = this.layout;
            this.SupplierIDSpinEdit.TabIndex = 7;
            // 
            // QuantityPerUnitTextEdit
            // 
            this.QuantityPerUnitTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productsBindingSource, "QuantityPerUnit", true));
            this.QuantityPerUnitTextEdit.Location = new System.Drawing.Point(116, 120);
            this.QuantityPerUnitTextEdit.Name = "QuantityPerUnitTextEdit";
            this.QuantityPerUnitTextEdit.Size = new System.Drawing.Size(120, 20);
            this.QuantityPerUnitTextEdit.StyleController = this.layout;
            this.QuantityPerUnitTextEdit.TabIndex = 8;
            // 
            // UnitPriceSpinEdit
            // 
            this.UnitPriceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productsBindingSource, "UnitPrice", true));
            this.UnitPriceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.UnitPriceSpinEdit.Location = new System.Drawing.Point(116, 151);
            this.UnitPriceSpinEdit.Name = "UnitPriceSpinEdit";
            this.UnitPriceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.UnitPriceSpinEdit.Size = new System.Drawing.Size(120, 20);
            this.UnitPriceSpinEdit.StyleController = this.layout;
            this.UnitPriceSpinEdit.TabIndex = 9;
            // 
            // ItemForProductID
            // 
            this.ItemForProductID.Control = this.ProductIDSpinEdit;
            this.ItemForProductID.CustomizationFormText = "ProductID";
            this.ItemForProductID.Location = new System.Drawing.Point(0, 0);
            this.ItemForProductID.Name = "ItemForProductID";
            this.ItemForProductID.Size = new System.Drawing.Size(0, 0);
            this.ItemForProductID.Text = "ProductID";
            this.ItemForProductID.TextLocation = DevExpress.Utils.Locations.Left;
            this.ItemForProductID.TextSize = new System.Drawing.Size(50, 20);
            // 
            // ItemForCategoryID
            // 
            this.ItemForCategoryID.Control = this.CategoryIDSpinEdit;
            this.ItemForCategoryID.CustomizationFormText = "CategoryID";
            this.ItemForCategoryID.Location = new System.Drawing.Point(0, 0);
            this.ItemForCategoryID.Name = "ItemForCategoryID";
            this.ItemForCategoryID.Size = new System.Drawing.Size(0, 0);
            this.ItemForCategoryID.Text = "CategoryID";
            this.ItemForCategoryID.TextLocation = DevExpress.Utils.Locations.Left;
            this.ItemForCategoryID.TextSize = new System.Drawing.Size(50, 20);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Product,
            this.layoutControlGroup2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(488, 186);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // Product
            // 
            this.Product.CustomizationFormText = "Product";
            this.Product.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForUnitPrice,
            this.ItemForQuantityPerUnit,
            this.ItemForSupplierID,
            this.ItemForProductName});
            this.Product.Location = new System.Drawing.Point(0, 30);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(243, 154);
            this.Product.Text = "Product";
            // 
            // ItemForUnitPrice
            // 
            this.ItemForUnitPrice.Control = this.UnitPriceSpinEdit;
            this.ItemForUnitPrice.CustomizationFormText = "UnitPrice";
            this.ItemForUnitPrice.Location = new System.Drawing.Point(0, 93);
            this.ItemForUnitPrice.Name = "ItemForUnitPrice";
            this.ItemForUnitPrice.Size = new System.Drawing.Size(237, 37);
            this.ItemForUnitPrice.Text = "UnitPrice";
            this.ItemForUnitPrice.TextLocation = DevExpress.Utils.Locations.Left;
            this.ItemForUnitPrice.TextSize = new System.Drawing.Size(101, 20);
            // 
            // ItemForQuantityPerUnit
            // 
            this.ItemForQuantityPerUnit.Control = this.QuantityPerUnitTextEdit;
            this.ItemForQuantityPerUnit.CustomizationFormText = "QuantityPerUnit";
            this.ItemForQuantityPerUnit.Location = new System.Drawing.Point(0, 62);
            this.ItemForQuantityPerUnit.Name = "ItemForQuantityPerUnit";
            this.ItemForQuantityPerUnit.Size = new System.Drawing.Size(237, 31);
            this.ItemForQuantityPerUnit.Text = "QuantityPerUnit";
            this.ItemForQuantityPerUnit.TextLocation = DevExpress.Utils.Locations.Left;
            this.ItemForQuantityPerUnit.TextSize = new System.Drawing.Size(101, 20);
            // 
            // ItemForSupplierID
            // 
            this.ItemForSupplierID.Control = this.SupplierIDSpinEdit;
            this.ItemForSupplierID.CustomizationFormText = "SupplierID";
            this.ItemForSupplierID.Location = new System.Drawing.Point(0, 31);
            this.ItemForSupplierID.Name = "ItemForSupplierID";
            this.ItemForSupplierID.Size = new System.Drawing.Size(237, 31);
            this.ItemForSupplierID.Text = "SupplierID";
            this.ItemForSupplierID.TextLocation = DevExpress.Utils.Locations.Left;
            this.ItemForSupplierID.TextSize = new System.Drawing.Size(101, 20);
            // 
            // ItemForProductName
            // 
            this.ItemForProductName.Control = this.ProductNameTextEdit;
            this.ItemForProductName.CustomizationFormText = "ProductName";
            this.ItemForProductName.Location = new System.Drawing.Point(0, 0);
            this.ItemForProductName.Name = "ItemForProductName";
            this.ItemForProductName.Size = new System.Drawing.Size(237, 31);
            this.ItemForProductName.Text = "ProductName";
            this.ItemForProductName.TextLocation = DevExpress.Utils.Locations.Left;
            this.ItemForProductName.TextSize = new System.Drawing.Size(101, 20);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Category";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(243, 30);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(243, 154);
            this.layoutControlGroup2.Text = "Category";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lookUpEdit3;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 31);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(237, 99);
            this.layoutControlItem2.Text = "Category Description";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(101, 20);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lookUpEdit4;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(237, 31);
            this.layoutControlItem1.Text = "Category Name";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(101, 20);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dataNavigator1;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(486, 30);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 186);
            this.Controls.Add(this.layout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
            this.layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityPerUnitTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPriceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategoryID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQuantityPerUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSupplierID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private Q157926.nwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private DevExpress.XtraDataLayout.DataLayoutControl layout;
        private DevExpress.XtraEditors.SpinEdit ProductIDSpinEdit;
        private DevExpress.XtraEditors.TextEdit ProductNameTextEdit;
        private DevExpress.XtraEditors.SpinEdit CategoryIDSpinEdit;
        private DevExpress.XtraEditors.SpinEdit SupplierIDSpinEdit;
        private DevExpress.XtraEditors.TextEdit QuantityPerUnitTextEdit;
        private DevExpress.XtraEditors.SpinEdit UnitPriceSpinEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProductID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCategoryID;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup Product;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUnitPrice;
        private DevExpress.XtraLayout.LayoutControlItem ItemForQuantityPerUnit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSupplierID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProductName;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit3;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private Q157926.nwindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}

