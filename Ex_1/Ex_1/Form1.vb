Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (Val(txtnumber.Text) Mod 2) = 0 Then
            MsgBox("even")
        Else
            MsgBox("odd")
        End If

    End Sub
End Class
