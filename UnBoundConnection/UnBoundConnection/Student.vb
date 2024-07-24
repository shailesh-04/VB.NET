Imports System.Data.OleDb
Public Class Student
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim i As Integer
    Private Sub Student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\Studen.mdb")
        conn.Open()
        da = New OleDbDataAdapter("SELECT * FROM StudentInfo", conn)
        ds = New DataSet
        da.Fill(ds, "StudentInfo")
        i = 0
        Display()
    End Sub
    Private Sub Clr()
        TextBox1.Clear()
        txtRoll.Clear()
        txtName.Clear()
        txtAddress.Clear()
        txtMobile.Clear()
    End Sub
    Private Sub Display()
        TextBox1.Text = ds.Tables("StudentInfo").Rows(i)(0)
        txtRoll.Text = ds.Tables("StudentInfo").Rows(i)(1)
        txtName.Text = ds.Tables("StudentInfo").Rows(i)(2)
        txtAddress.Text = ds.Tables("StudentInfo").Rows(i)(3)
        txtMobile.Text = ds.Tables("StudentInfo").Rows(i)(4)
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        i = 0
        Display()
    End Sub

    Private Sub bnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnNext.Click
        If i < ds.Tables(0).Rows.Count - 1 Then
            i = i + 1
            Display()
        End If
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        If i > 0 Then
            i = i - 1
            Display()
        End If
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        i = ds.Tables(0).Rows.Count - 1
        Display()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Clr()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cmd = New OleDbCommand("INSERT INTO StudentInfo (Roll, Name, Address, Mobile) VALUES ( " & txtRoll.Text & ",'" & txtName.Text & "', '" & txtAddress.Text & "', '" & txtMobile.Text & "')", conn)
        cmd.ExecuteNonQuery()
        da.Update(ds, "StudentInfo")
        ds.Clear()
        da.Fill(ds, "StudentInfo")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cmd = New OleDbCommand("DELETE FROM StudentInfo WHERE ID = " & TextBox1.Text, conn)
        cmd.ExecuteNonQuery()
        da.Update(ds, "StudentInfo")
        ds.Clear()
        da.Fill(ds, "StudentInfo")
        MsgBox("Delete Is SUccess")
        i = ds.Tables(0).Rows.Count - 1
        Display()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cmd = New OleDbCommand("UPDATE StudentInfo SET Roll='" & txtRoll.Text & "', Name='" & txtName.Text & "', Address='" & txtAddress.Text & "', Mobile='" & txtMobile.Text & "'", conn)
        cmd.ExecuteNonQuery()
        da.Update(ds, "StudentInfo")
        ds.Clear()
        da.Fill(ds, "StudentInfo")
        Display()
    End Sub
End Class
