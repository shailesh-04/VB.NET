Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (Val(txtnumber.Text) = 1) Then
            MsgBox("Mondey")
        ElseIf (Val(txtnumber.Text) = 2) Then
            MsgBox("tuesday")

        ElseIf (Val(txtnumber.Text) = 3) Then
            MsgBox("wednesday")

        ElseIf (Val(txtnumber.Text) = 4) Then
            MsgBox("thursday")
        ElseIf (Val(txtnumber.Text) = 5) Then
            MsgBox("friday")
        ElseIf (Val(txtnumber.Text) = 6) Then
            MsgBox("saturday")
        ElseIf (Val(txtnumber.Text) = 3) Then
            MsgBox("sunday")
        Else
            MsgBox("worng")



        End If

    End Sub
End Class
