Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim s As Integer = 0
        Dim d As Integer = 0
        n = Val(txtno.Text)
        While (n > 0)

            d = n Mod 10
            s = s + d
            n = n / 10

        End While
        lblno.Text = s


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
