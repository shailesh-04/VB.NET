Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Select Case Val(txtnumber.Text)
            Case 1
                MsgBox("january")
            Case 2
                MsgBox("february")
            Case 3
                MsgBox("march")
            Case 4
                MsgBox("april")
            Case 5
                MsgBox("may")
            Case 6
                MsgBox("june")
            Case 7
                MsgBox("july")
            Case 8
                MsgBox("august")
            Case 9
                MsgBox("saptember")
            Case 10
                MsgBox("octomber")
            Case 11
                MsgBox("november")
            Case 12
                MsgBox("december")
        End Select
    End Sub
End Class

