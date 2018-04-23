Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraLayout.Helpers
Imports DevExpress.XtraLayout
Imports System.Collections
Imports DevExpress.XtraEditors

Namespace Q157926
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
			Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)
			layout.FocusHelper = New MyFocusHelper(layout)
		End Sub
	End Class

	Public Class MyFocusHelper
		Inherits FocusHelperBase
		Public Sub New(ByVal control As ILayoutControl)
			MyBase.New(control)
		End Sub

		Private focusedGroup As LayoutGroup
		Protected Overrides Function FilterElements(ByVal list As ArrayList, ByVal tabStopOnly As Boolean) As ArrayList
			Dim container As ContainerControl = TryCast(layoutControl.Control, ContainerControl)
			If container IsNot Nothing AndAlso container.ActiveControl IsNot Nothing Then
				Dim activeControl As Control = container.ActiveControl
				If TypeOf activeControl Is TextBoxMaskBox Then
					activeControl = activeControl.Parent
				End If
				focusedGroup = layoutControl.GetItemByControl(activeControl).Parent
			End If
			'focusedGroup = null;
			Return MyBase.FilterElements(list, tabStopOnly)
		End Function

		Protected Overrides Function CheckItem(ByVal item As BaseLayoutItem, ByVal tabStopOnly As Boolean) As Boolean
			If focusedGroup IsNot Nothing AndAlso item.Parent IsNot focusedGroup Then
				Return False
			End If
			Return MyBase.CheckItem(item, tabStopOnly)
		End Function
	End Class
End Namespace