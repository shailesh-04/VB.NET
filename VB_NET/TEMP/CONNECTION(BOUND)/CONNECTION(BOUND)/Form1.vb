Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet.detail' table. You can move, or remove it, as needed.
        Me.DetailTableAdapter.Fill(Me.StudentDataSet.detail)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        DetailBindingSource.MoveNext()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DetailBindingSource.MoveFirst()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DetailBindingSource.MoveLast()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        DetailBindingSource.MovePrevious()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        DetailBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        On Error GoTo saveError
        DetailBindingSource.EndEdit()
        DetailTableAdapter.Update(StudentDataSet.detail)
        MsgBox("Record Successfully")
saveError:
        Exit Sub
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        DetailBindingSource.RemoveCurrent()
        DetailTableAdapter.Update(StudentDataSet.detail)
    End Sub
End Class
