Imports Microsoft.VisualBasic
Imports System
Namespace AuditDemo.Module.Win
	Partial Public Class SelectRecordInLookupViewController
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
			Me.saSelectRecordInLookup = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
			' 
			' saSelectRecordInLookup
			' 
			Me.saSelectRecordInLookup.ActionMeaning = DevExpress.ExpressApp.Actions.ActionMeaning.Accept
			Me.saSelectRecordInLookup.Caption = "Select Record"
			Me.saSelectRecordInLookup.Category = "PopupActions"
			Me.saSelectRecordInLookup.Id = "SelectRecordInLookup"
'			Me.saSelectRecordInLookup.Execute += New DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(Me.saSelectRecordInLookup_Execute);

		End Sub

		#End Region

		Private WithEvents saSelectRecordInLookup As DevExpress.ExpressApp.Actions.SimpleAction
	End Class
End Namespace
