Public Class Form1

    Dim cn As New OleDb.OleDbConnection
    Dim ad As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim com As New OleDb.OleDbCommand
    Dim c As New Integer



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\data\student.mdb")
        cn.Open()
        ad = New OleDb.OleDbDataAdapter("select * from student", cn)
        ad.Fill(ds)
        TextBox1.Text = ds.Tables(0).Rows(0).Item(0)
        TextBox2.Text = ds.Tables(0).Rows(0).Item(1)
        TextBox3.Text = ds.Tables(0).Rows(0).Item(2)
        TextBox4.Text = ds.Tables(0).Rows(0).Item(3)













    End Sub
End Class
