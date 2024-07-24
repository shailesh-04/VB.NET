Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet.Details' table. You can move, or remove it, as needed.
        Me.DetailsTableAdapter.Fill(Me.StudentDataSet.Details)

    End Sub

    Private Sub DetailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DetailsBindingSource.EndEdit()
        Me.DetailsTableAdapter.Update(Me.StudentDataSet.Details)

    End Sub

    Private Sub DetailsBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsBindingNavigator.RefreshItems

    End Sub

    Private Sub DetailsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DetailsDataGridView.CellContentClick

    End Sub
End Class
