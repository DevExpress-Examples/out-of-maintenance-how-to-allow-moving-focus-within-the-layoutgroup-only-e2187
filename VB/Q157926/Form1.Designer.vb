Namespace Q157926
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.DataLayoutControl = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
            Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New Q157926.nwindDataSet()
            Me.lookUpEdit3 = New DevExpress.XtraEditors.LookUpEdit()
            Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.lookUpEdit4 = New DevExpress.XtraEditors.LookUpEdit()
            Me.ProductIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.ProductNameTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.CategoryIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.SupplierIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.QuantityPerUnitTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.UnitPriceSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.ItemForProductID = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForCategoryID = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.Product = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForUnitPrice = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForQuantityPerUnit = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForSupplierID = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForProductName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.productsTableAdapter = New Q157926.nwindDataSetTableAdapters.ProductsTableAdapter()
            Me.categoriesTableAdapter = New Q157926.nwindDataSetTableAdapters.CategoriesTableAdapter()
            DirectCast(Me.DataLayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DataLayoutControl.SuspendLayout()
            DirectCast(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lookUpEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ProductIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ProductNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.CategoryIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.SupplierIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.QuantityPerUnitTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.UnitPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForProductID, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForCategoryID, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.Product, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForQuantityPerUnit, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForSupplierID, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForProductName, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layout
            ' 
            Me.DataLayoutControl.Controls.Add(Me.dataNavigator1)
            Me.DataLayoutControl.Controls.Add(Me.lookUpEdit3)
            Me.DataLayoutControl.Controls.Add(Me.lookUpEdit4)
            Me.DataLayoutControl.Controls.Add(Me.ProductIDSpinEdit)
            Me.DataLayoutControl.Controls.Add(Me.ProductNameTextEdit)
            Me.DataLayoutControl.Controls.Add(Me.CategoryIDSpinEdit)
            Me.DataLayoutControl.Controls.Add(Me.SupplierIDSpinEdit)
            Me.DataLayoutControl.Controls.Add(Me.QuantityPerUnitTextEdit)
            Me.DataLayoutControl.Controls.Add(Me.UnitPriceSpinEdit)
            Me.DataLayoutControl.DataSource = Me.productsBindingSource
            Me.DataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DataLayoutControl.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForProductID, Me.ItemForCategoryID})
            Me.DataLayoutControl.Location = New System.Drawing.Point(0, 0)
            Me.DataLayoutControl.Name = "layout"
            Me.DataLayoutControl.Root = Me.layoutControlGroup1
            Me.DataLayoutControl.Size = New System.Drawing.Size(488, 186)
            Me.DataLayoutControl.TabIndex = 0
            Me.DataLayoutControl.Text = "dataLayoutControl1"
            ' 
            ' dataNavigator1
            ' 
            Me.dataNavigator1.DataSource = Me.productsBindingSource
            Me.dataNavigator1.Location = New System.Drawing.Point(7, 7)
            Me.dataNavigator1.Name = "dataNavigator1"
            Me.dataNavigator1.Size = New System.Drawing.Size(475, 19)
            Me.dataNavigator1.StyleController = Me.DataLayoutControl
            Me.dataNavigator1.TabIndex = 1
            Me.dataNavigator1.Text = "dataNavigator1"
            ' 
            ' productsBindingSource
            ' 
            Me.productsBindingSource.DataMember = "Products"
            Me.productsBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' lookUpEdit3
            ' 
            Me.lookUpEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.productsBindingSource, "CategoryID", True))
            Me.lookUpEdit3.Location = New System.Drawing.Point(359, 89)
            Me.lookUpEdit3.Name = "lookUpEdit3"
            Me.lookUpEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.lookUpEdit3.Properties.DataSource = Me.categoriesBindingSource
            Me.lookUpEdit3.Properties.DisplayMember = "Description"
            Me.lookUpEdit3.Properties.ValueMember = "CategoryID"
            Me.lookUpEdit3.Size = New System.Drawing.Size(120, 20)
            Me.lookUpEdit3.StyleController = Me.DataLayoutControl
            Me.lookUpEdit3.TabIndex = 3
            ' 
            ' categoriesBindingSource
            ' 
            Me.categoriesBindingSource.DataMember = "Categories"
            Me.categoriesBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' lookUpEdit4
            ' 
            Me.lookUpEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.productsBindingSource, "CategoryID", True))
            Me.lookUpEdit4.Location = New System.Drawing.Point(359, 58)
            Me.lookUpEdit4.Name = "lookUpEdit4"
            Me.lookUpEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.lookUpEdit4.Properties.DataSource = Me.categoriesBindingSource
            Me.lookUpEdit4.Properties.DisplayMember = "CategoryName"
            Me.lookUpEdit4.Properties.ValueMember = "CategoryID"
            Me.lookUpEdit4.Size = New System.Drawing.Size(120, 20)
            Me.lookUpEdit4.StyleController = Me.DataLayoutControl
            Me.lookUpEdit4.TabIndex = 4
            ' 
            ' ProductIDSpinEdit
            ' 
            Me.ProductIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.productsBindingSource, "ProductID", True))
            Me.ProductIDSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
            Me.ProductIDSpinEdit.Location = New System.Drawing.Point(0, 0)
            Me.ProductIDSpinEdit.Name = "ProductIDSpinEdit"
            Me.ProductIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.ProductIDSpinEdit.Size = New System.Drawing.Size(0, 20)
            Me.ProductIDSpinEdit.StyleController = Me.DataLayoutControl
            Me.ProductIDSpinEdit.TabIndex = 4
            ' 
            ' ProductNameTextEdit
            ' 
            Me.ProductNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.productsBindingSource, "ProductName", True))
            Me.ProductNameTextEdit.Location = New System.Drawing.Point(116, 58)
            Me.ProductNameTextEdit.Name = "ProductNameTextEdit"
            Me.ProductNameTextEdit.Size = New System.Drawing.Size(120, 20)
            Me.ProductNameTextEdit.StyleController = Me.DataLayoutControl
            Me.ProductNameTextEdit.TabIndex = 5
            ' 
            ' CategoryIDSpinEdit
            ' 
            Me.CategoryIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.productsBindingSource, "CategoryID", True))
            Me.CategoryIDSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
            Me.CategoryIDSpinEdit.Location = New System.Drawing.Point(0, 0)
            Me.CategoryIDSpinEdit.Name = "CategoryIDSpinEdit"
            Me.CategoryIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.CategoryIDSpinEdit.Size = New System.Drawing.Size(0, 20)
            Me.CategoryIDSpinEdit.StyleController = Me.DataLayoutControl
            Me.CategoryIDSpinEdit.TabIndex = 6
            ' 
            ' SupplierIDSpinEdit
            ' 
            Me.SupplierIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.productsBindingSource, "SupplierID", True))
            Me.SupplierIDSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
            Me.SupplierIDSpinEdit.Location = New System.Drawing.Point(116, 89)
            Me.SupplierIDSpinEdit.Name = "SupplierIDSpinEdit"
            Me.SupplierIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.SupplierIDSpinEdit.Size = New System.Drawing.Size(120, 20)
            Me.SupplierIDSpinEdit.StyleController = Me.DataLayoutControl
            Me.SupplierIDSpinEdit.TabIndex = 7
            ' 
            ' QuantityPerUnitTextEdit
            ' 
            Me.QuantityPerUnitTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.productsBindingSource, "QuantityPerUnit", True))
            Me.QuantityPerUnitTextEdit.Location = New System.Drawing.Point(116, 120)
            Me.QuantityPerUnitTextEdit.Name = "QuantityPerUnitTextEdit"
            Me.QuantityPerUnitTextEdit.Size = New System.Drawing.Size(120, 20)
            Me.QuantityPerUnitTextEdit.StyleController = Me.DataLayoutControl
            Me.QuantityPerUnitTextEdit.TabIndex = 8
            ' 
            ' UnitPriceSpinEdit
            ' 
            Me.UnitPriceSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.productsBindingSource, "UnitPrice", True))
            Me.UnitPriceSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
            Me.UnitPriceSpinEdit.Location = New System.Drawing.Point(116, 151)
            Me.UnitPriceSpinEdit.Name = "UnitPriceSpinEdit"
            Me.UnitPriceSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.UnitPriceSpinEdit.Size = New System.Drawing.Size(120, 20)
            Me.UnitPriceSpinEdit.StyleController = Me.DataLayoutControl
            Me.UnitPriceSpinEdit.TabIndex = 9
            ' 
            ' ItemForProductID
            ' 
            Me.ItemForProductID.Control = Me.ProductIDSpinEdit
            Me.ItemForProductID.CustomizationFormText = "ProductID"
            Me.ItemForProductID.Location = New System.Drawing.Point(0, 0)
            Me.ItemForProductID.Name = "ItemForProductID"
            Me.ItemForProductID.Size = New System.Drawing.Size(0, 0)
            Me.ItemForProductID.Text = "ProductID"
            Me.ItemForProductID.TextLocation = DevExpress.Utils.Locations.Left
            Me.ItemForProductID.TextSize = New System.Drawing.Size(50, 20)
            ' 
            ' ItemForCategoryID
            ' 
            Me.ItemForCategoryID.Control = Me.CategoryIDSpinEdit
            Me.ItemForCategoryID.CustomizationFormText = "CategoryID"
            Me.ItemForCategoryID.Location = New System.Drawing.Point(0, 0)
            Me.ItemForCategoryID.Name = "ItemForCategoryID"
            Me.ItemForCategoryID.Size = New System.Drawing.Size(0, 0)
            Me.ItemForCategoryID.Text = "CategoryID"
            Me.ItemForCategoryID.TextLocation = DevExpress.Utils.Locations.Left
            Me.ItemForCategoryID.TextSize = New System.Drawing.Size(50, 20)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.Product, Me.layoutControlGroup2, Me.layoutControlItem3})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(488, 186)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "layoutControlGroup1"
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' Product
            ' 
            Me.Product.CustomizationFormText = "Product"
            Me.Product.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForUnitPrice, Me.ItemForQuantityPerUnit, Me.ItemForSupplierID, Me.ItemForProductName})
            Me.Product.Location = New System.Drawing.Point(0, 30)
            Me.Product.Name = "Product"
            Me.Product.Size = New System.Drawing.Size(243, 154)
            Me.Product.Text = "Product"
            ' 
            ' ItemForUnitPrice
            ' 
            Me.ItemForUnitPrice.Control = Me.UnitPriceSpinEdit
            Me.ItemForUnitPrice.CustomizationFormText = "UnitPrice"
            Me.ItemForUnitPrice.Location = New System.Drawing.Point(0, 93)
            Me.ItemForUnitPrice.Name = "ItemForUnitPrice"
            Me.ItemForUnitPrice.Size = New System.Drawing.Size(237, 37)
            Me.ItemForUnitPrice.Text = "UnitPrice"
            Me.ItemForUnitPrice.TextLocation = DevExpress.Utils.Locations.Left
            Me.ItemForUnitPrice.TextSize = New System.Drawing.Size(101, 20)
            ' 
            ' ItemForQuantityPerUnit
            ' 
            Me.ItemForQuantityPerUnit.Control = Me.QuantityPerUnitTextEdit
            Me.ItemForQuantityPerUnit.CustomizationFormText = "QuantityPerUnit"
            Me.ItemForQuantityPerUnit.Location = New System.Drawing.Point(0, 62)
            Me.ItemForQuantityPerUnit.Name = "ItemForQuantityPerUnit"
            Me.ItemForQuantityPerUnit.Size = New System.Drawing.Size(237, 31)
            Me.ItemForQuantityPerUnit.Text = "QuantityPerUnit"
            Me.ItemForQuantityPerUnit.TextLocation = DevExpress.Utils.Locations.Left
            Me.ItemForQuantityPerUnit.TextSize = New System.Drawing.Size(101, 20)
            ' 
            ' ItemForSupplierID
            ' 
            Me.ItemForSupplierID.Control = Me.SupplierIDSpinEdit
            Me.ItemForSupplierID.CustomizationFormText = "SupplierID"
            Me.ItemForSupplierID.Location = New System.Drawing.Point(0, 31)
            Me.ItemForSupplierID.Name = "ItemForSupplierID"
            Me.ItemForSupplierID.Size = New System.Drawing.Size(237, 31)
            Me.ItemForSupplierID.Text = "SupplierID"
            Me.ItemForSupplierID.TextLocation = DevExpress.Utils.Locations.Left
            Me.ItemForSupplierID.TextSize = New System.Drawing.Size(101, 20)
            ' 
            ' ItemForProductName
            ' 
            Me.ItemForProductName.Control = Me.ProductNameTextEdit
            Me.ItemForProductName.CustomizationFormText = "ProductName"
            Me.ItemForProductName.Location = New System.Drawing.Point(0, 0)
            Me.ItemForProductName.Name = "ItemForProductName"
            Me.ItemForProductName.Size = New System.Drawing.Size(237, 31)
            Me.ItemForProductName.Text = "ProductName"
            Me.ItemForProductName.TextLocation = DevExpress.Utils.Locations.Left
            Me.ItemForProductName.TextSize = New System.Drawing.Size(101, 20)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.CustomizationFormText = "Category"
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(243, 30)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(243, 154)
            Me.layoutControlGroup2.Text = "Category"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.lookUpEdit3
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 31)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(237, 99)
            Me.layoutControlItem2.Text = "Category Description"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(101, 20)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.lookUpEdit4
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(237, 31)
            Me.layoutControlItem1.Text = "Category Name"
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(101, 20)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.dataNavigator1
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(486, 30)
            Me.layoutControlItem3.Text = "layoutControlItem3"
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextToControlDistance = 0
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' productsTableAdapter
            ' 
            Me.productsTableAdapter.ClearBeforeFill = True
            ' 
            ' categoriesTableAdapter
            ' 
            Me.categoriesTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(488, 186)
            Me.Controls.Add(Me.DataLayoutControl)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.DataLayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DataLayoutControl.ResumeLayout(False)
            DirectCast(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lookUpEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ProductIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ProductNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.CategoryIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.SupplierIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.QuantityPerUnitTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.UnitPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForProductID, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForCategoryID, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.Product, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForQuantityPerUnit, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForSupplierID, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForProductName, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private nwindDataSet As nwindDataSet
        Private productsBindingSource As System.Windows.Forms.BindingSource
        Private productsTableAdapter As Q157926.nwindDataSetTableAdapters.ProductsTableAdapter
        Private DataLayoutControl As DevExpress.XtraDataLayout.DataLayoutControl
        Private ProductIDSpinEdit As DevExpress.XtraEditors.SpinEdit
        Private ProductNameTextEdit As DevExpress.XtraEditors.TextEdit
        Private CategoryIDSpinEdit As DevExpress.XtraEditors.SpinEdit
        Private SupplierIDSpinEdit As DevExpress.XtraEditors.SpinEdit
        Private QuantityPerUnitTextEdit As DevExpress.XtraEditors.TextEdit
        Private UnitPriceSpinEdit As DevExpress.XtraEditors.SpinEdit
        Private ItemForProductID As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForCategoryID As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private Product As DevExpress.XtraLayout.LayoutControlGroup
        Private ItemForUnitPrice As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForQuantityPerUnit As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForSupplierID As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForProductName As DevExpress.XtraLayout.LayoutControlItem
        Private lookUpEdit3 As DevExpress.XtraEditors.LookUpEdit
        Private lookUpEdit4 As DevExpress.XtraEditors.LookUpEdit
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private categoriesBindingSource As System.Windows.Forms.BindingSource
        Private categoriesTableAdapter As Q157926.nwindDataSetTableAdapters.CategoriesTableAdapter
        Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator
        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

