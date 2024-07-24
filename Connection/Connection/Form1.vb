Imports System.Data.OleDb
Public Class Form1
    Dim conn As OleDb.OleDbConnection
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDb.OleDbCommand
    Dim I As Integer = 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New OleDb.OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=F:\D\vb.net\student_info.mdb")
        da = New OleDb.OleDbDataAdapter("SELECT * FROM detail", conn)
        ds = New DataSet
        da.Fill(ds, "detail")
        DataGridView1.DataSource = ds.Tables("detail")
        ShowData(0)
    End Sub
    Private Sub ShowData(ByVal pos)
        txtId.Text = ds.Tables("detail").Rows(pos)("studentId")
        txtName.Text = ds.Tables("detail").Rows(pos)("Name")
        txtCity.Text = ds.Tables("detail").Rows(pos)("City")
        txtMobile.Text = ds.Tables("detail").Rows(pos)("Mobile")
    End Sub
    Private Sub ClearForm()
        txtId.Clear()
        txtName.Clear()
        txtCity.Clear()
        txtMobile.Clear()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If I < ds.Tables("detail").Rows.Count - 1 Then
            I += 1
        Else
            I = 0
        End If
        ShowData(I)
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        If I > 0 Then
            I -= 1
        Else
            I = ds.Tables("detail").Rows.Count - 1
        End If
        ShowData(I)
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        ShowData(0)
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        ShowData(ds.Tables("detail").Rows.Count - 1)
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

    End Sub
End Class
