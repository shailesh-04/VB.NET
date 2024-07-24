Public Class Color

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ColorDialog1.ShowDialog()
        Button1.BackColor = ColorDialog1.Color
    End Sub

    Private Sub Color_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        ColorDialog1.ShowDialog()
        Label1.BackColor = ColorDialog1.Color
    End Sub
End Class
