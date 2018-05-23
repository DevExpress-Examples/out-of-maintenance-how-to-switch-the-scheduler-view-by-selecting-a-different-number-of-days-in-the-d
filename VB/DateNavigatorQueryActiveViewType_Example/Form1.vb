Imports Microsoft.VisualBasic
#Region "#usings"
Imports DevExpress.XtraScheduler
Imports System.Windows.Forms
#End Region ' #usings

Namespace DateNavigatorQueryActiveViewType_Example
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			schedulerControl1.OptionsView.FirstDayOfWeek = DevExpress.XtraScheduler.FirstDayOfWeek.Monday
			AddHandler schedulerControl1.DateNavigatorQueryActiveViewType, AddressOf schedulerControl1_DateNavigatorQueryActiveViewType
		End Sub
		#Region "#DateNavigatorQueryActiveViewType"
		Private Sub schedulerControl1_DateNavigatorQueryActiveViewType(ByVal sender As Object, ByVal e As DateNavigatorQueryActiveViewTypeEventArgs)
			If (e.SelectedDays.Count = 7) AndAlso (e.SelectedDays.Start.DayOfWeek = schedulerControl1.FirstDayOfWeek) Then
				e.NewViewType = SchedulerViewType.Week
			End If
		End Sub
		#End Region ' #DateNavigatorQueryActiveViewType
	End Class
End Namespace
