Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions

Namespace AuditDemo.Module.Win
	Partial Public Class ViewController1
		Inherits ViewController
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
		End Sub
		Private Sub simpleAction1_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles simpleAction1.Execute
			Dim lookupListView As ListView = CType(View, ListView)
			CType(lookupListView.ProcessSelectedItemAction, SimpleAction).DoExecute()
		End Sub
	End Class
End Namespace
