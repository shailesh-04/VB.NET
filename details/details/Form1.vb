Public Class Form1

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.StudentDetails' table. You can move, or remove it, as needed.
        Me.StudentDetailsTableAdapter.Fill(Me.Database1DataSet.StudentDetails)

    End Sub
End Class
