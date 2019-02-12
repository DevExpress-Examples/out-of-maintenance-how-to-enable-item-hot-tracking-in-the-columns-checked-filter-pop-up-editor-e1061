Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports System
Imports DevExpress.XtraEditors

Namespace WindowsApplication1
	Public Class MyCheckedColumnFilterPopup
		Inherits CheckedColumnFilterPopup
		Public Sub New(ByVal view As ColumnView, ByVal column As GridColumn, ByVal owner As Control, ByVal creator As Object)
			MyBase.New(view, column, owner, creator)
		End Sub

		Protected Overrides Function CreateRepositoryItem() As RepositoryItemPopupBase
			Dim ret As RepositoryItemFilterComboBox = TryCast(MyBase.CreateRepositoryItem(), RepositoryItemFilterComboBox)
			ret.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
			AddHandler ret.Popup, AddressOf ret_Popup
			AddHandler ret.CloseUp, AddressOf ret_CloseUp
			Return ret
		End Function

		Private Sub ret_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs)
			Dim ret As RepositoryItemFilterComboBox = TryCast(MyBase.CreateRepositoryItem(), RepositoryItemFilterComboBox)
			RemoveHandler ret.Popup, AddressOf ret_Popup
			RemoveHandler ret.CloseUp, AddressOf ret_CloseUp
		End Sub

		Private Sub ret_Popup(ByVal sender As Object, ByVal e As EventArgs)
			Dim c As CheckedListBoxControl = TryCast((TryCast(sender, PopupContainerEdit)).Properties.PopupControl.Controls(0), CheckedListBoxControl)
            c.HotTrackItems = True
            c.SelectionMode = SelectionMode.One
        End Sub
	End Class
End Namespace
