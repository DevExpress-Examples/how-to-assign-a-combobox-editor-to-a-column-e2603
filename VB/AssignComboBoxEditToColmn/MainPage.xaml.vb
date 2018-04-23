Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports DevExpress.Xpf.Editors.Settings

Namespace AssignComboBoxEditToColmn
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			grid.DataSource = New ProductList()
			CType(grid.Columns("ProductName").EditSettings, ComboBoxEditSettings).ItemsSource = New ProductList()
		End Sub
	End Class
End Namespace
