# How to allow moving focus within the LayoutGroup only


<p>The logic of moving focus within the LayoutControl is implemented in the FocusHelperBase class. An instance of a FocusHelperBase descendant can be assigned to the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraLayoutLayoutControl_FocusHelpertopic">LayoutControl.FocusHelper</a> property to provide a custom mechanism.</p><p>In this example, the CheckItem method is overridden to exclude items that don't belong to a group, containing an active control from a list of items that can be focused.</p>

<br/>


