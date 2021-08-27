<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128632819/14.2.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2187)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/Q157926/Form1.cs) (VB: [Form1.vb](./VB/Q157926/Form1.vb))**
<!-- default file list end -->
# How to allow moving focus within the LayoutGroup only


<p>The logic of moving focus within the LayoutControl is implemented in the FocusHelperBase class. An instance of a FocusHelperBase descendant can be assigned to the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraLayoutLayoutControl_FocusHelpertopic">LayoutControl.FocusHelper</a> property to provide a custom mechanism.</p><p>In this example, the CheckItem method is overridden to exclude items that don't belong to a group, containing an active control from a list of items that can be focused.</p>


<h3>Description</h3>

The DevExpress.XtraLayout.Helpers.FocusHelperBase.FilterElements and DevExpress.XtraLayout.Helpers.FocusHelperBase.CheckItem methods signature has been changed. The includeReadOnly parameter has been added.

<br/>


