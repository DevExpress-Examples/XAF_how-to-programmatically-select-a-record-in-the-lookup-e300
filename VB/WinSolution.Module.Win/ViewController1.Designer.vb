Imports Microsoft.VisualBasic
Imports System
Namespace AuditDemo.Module.Win
	Partial Public Class ViewController1
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

		#Region "Component Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.simpleAction1 = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
			' 
			' simpleAction1
			' 
			Me.simpleAction1.ActionMeaning = DevExpress.ExpressApp.Actions.ActionMeaning.Accept
			Me.simpleAction1.Caption = "OK"
			Me.simpleAction1.Category = "PopupActions"
			Me.simpleAction1.Id = "8bc28951-9a0a-401a-a707-49001bd2bc65"
'			Me.simpleAction1.Execute += New DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(Me.simpleAction1_Execute);

		End Sub

		#End Region

		Private WithEvents simpleAction1 As DevExpress.ExpressApp.Actions.SimpleAction
	End Class
End Namespace
