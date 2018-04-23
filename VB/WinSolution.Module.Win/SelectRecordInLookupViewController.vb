Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.ExpressApp.SystemModule

Namespace AuditDemo.Module.Win
	Partial Public Class SelectRecordInLookupViewController
		Inherits ViewController(Of ListView)
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
		End Sub
		Private Sub saSelectRecordInLookup_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles saSelectRecordInLookup.Execute
			Dim processCurrentObjectAction As SimpleAction = Frame.GetController(Of ListViewProcessCurrentObjectController)().ProcessCurrentObjectAction
			If processCurrentObjectAction.Active.ResultValue AndAlso processCurrentObjectAction.Enabled.ResultValue Then
				processCurrentObjectAction.DoExecute()
			End If
		End Sub
	End Class
End Namespace
