Public Class Desine
    Private Sub Desine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BoundConnectionDataSet1.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.BoundConnectionDataSet1.Student)
        DataGridView1.DataSource = StudentBindingSource
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        StudentBindingSource.MoveFirst()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        StudentBindingSource.MoveNext()
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        StudentBindingSource.MovePrevious()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        StudentBindingSource.MoveLast()

    End Sub
    Dim flag As Boolean = True
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If flag Then
            StudentBindingSource.AddNew()
            btnNew.Text = "Cancel"
            btnSave.Visible = True
            flag = False
            ChangeProps(flag)
        Else
            btnNew.Text = "New"
            Me.StudentTableAdapter.Fill(Me.BoundConnectionDataSet1.Student)
            btnSave.Visible = False
            flag = True
            ChangeProps(flag)
        End If

    End Sub
    Private Sub ChangeProps(ByVal props)
        btnUpdate.Enabled = props
        btnDelete.Enabled = props
        btnNext.Enabled = props
        btnPrev.Enabled = props
        btnLast.Enabled = props
        btnFirst.Enabled = props
    End Sub
    Private Sub ChangeProps2(ByVal props)
        btnNew.Enabled = props
        btnDelete.Enabled = props
        btnNext.Enabled = props
        btnPrev.Enabled = props
        btnLast.Enabled = props
        btnFirst.Enabled = props
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        StudentBindingSource.EndEdit()
        Me.StudentTableAdapter.Update(Me.BoundConnectionDataSet1.Student)
        Defaultfn()
    End Sub
    Private Sub Defaultfn()
        ChangeProps(True)
        ChangeProps2(True)
        btnSave.Visible = False
        btnUpdate.Text = "Update"
    End Sub
    Dim flag2 As Boolean = True
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If flag2 Then
            btnUpdate.Text = "Cancel"
            btnSave.Visible = True
            flag2 = False
            ChangeProps2(flag2)
        Else
            btnUpdate.Text = "Update"
            Me.StudentTableAdapter.Update(Me.BoundConnectionDataSet1.Student)
            btnSave.Visible = False
            flag2 = True
            ChangeProps2(flag2)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        StudentBindingSource.RemoveCurrent()
        StudentTableAdapter.Update(Me.StudentBindingSource)
    End Sub

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.TextChanged

    End Sub
End Class