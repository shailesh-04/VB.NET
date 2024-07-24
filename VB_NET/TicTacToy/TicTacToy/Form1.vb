Public Class TikTacToy
    Dim t As Boolean = True
    Dim win(,) As Integer = {{1, 2, 3}, {4, 5, 6}}
    Private Sub CheckWinPlear(ByVal data As String)
        If (ox1.Text = data And ox2.Text = data And ox3.Text = data) Or (ox4.Text = data And ox5.Text = data And ox6.Text = data) Or (ox7.Text = data And ox8.Text = data And ox9.Text = data) Or (ox1.Text = data And ox4.Text = data And ox7.Text = data) Or (ox2.Text = data And ox5.Text = data And ox8.Text = data) Or (ox3.Text = data And ox6.Text = data And ox9.Text = data) Or (ox3.Text = data And ox5.Text = data And ox7.Text = data) Or (ox1.Text = data And ox5.Text = data And ox9.Text = data) Then
            MsgBox("Plear " & data & " Is Winner")
            Reset()
        End If
        Dim flag As Integer = 0
        For Each i As Button In ox.Controls
            If Not i.Text = "" Then
                flag = flag + 1
            End If
        Next
        If flag = 9 Then
            MsgBox("Any Plear  Can't Win")
            Reset()
        End If
    End Sub
    Private Sub Reset()
        For Each i As Button In ox.Controls
            i.Text = ""
            i.Enabled = True
        Next
    End Sub
    Private Sub Checked(ByVal btn As Button)
        btn.Enabled = False
        If t = True Then
            btn.Text = "X"
            t = False
        Else
            btn.Text = "0"
            t = True
        End If
        CheckWinPlear(btn.Text)
    End Sub


    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub check_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ox9.Click, ox8.Click, ox7.Click, ox6.Click, ox5.Click, ox4.Click, ox3.Click, ox2.Click, ox1.Click
        Checked(sender)
    End Sub

    Private Sub TikTacToy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub ox_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ox.Paint

    End Sub
End Class
