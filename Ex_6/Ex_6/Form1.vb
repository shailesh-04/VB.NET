Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim d As Integer
        Dim r As Integer = 0
        Dim l As Integer = 0
        n = Val(txtno.Text)
        While (n > 0)
            d = n Mod 10
            r = r * 10 + d
            n = n / 10


        End While
        If (r = Val(txtno.Text)) Then
            lblno.Text = "Pelindrome"
        Else
            lblno.Text = "Not Pelindrome"

        End If
    End Sub
End Class
