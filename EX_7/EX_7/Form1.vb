Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If rbtmale.Checked = True Then

            MsgBox("WELOME MR " & txtno.Text)

        Else
            MsgBox("WELCOME MISS " & txtno.Text)


        End If
    End Sub
End Class
