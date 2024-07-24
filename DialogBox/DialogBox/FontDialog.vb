Public Class FontDialog

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FontDialog1.ShowDialog()
        Label1.Font = FontDialog1.Font
    End Sub
