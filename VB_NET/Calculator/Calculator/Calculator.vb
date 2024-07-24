Public Class Calculator

    Dim operation As String = ""

    Dim num As Integer = 0
    Dim num1 As Integer = 0
    Sub ClickOP(ByVal op)
        If num <> 0 Then
            num1 = Val(txtNum.Text)
        Else
            num = txtNum.Text
            operation = op
            txtNum.Clear()
        End If

    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btnDot.Click, btn0.Click

        txtNum.Text = txtNum.Text & sender.text

    End Sub

    Private Sub Calculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click

        txtNum.Clear()

    End Sub

    Private Sub btnSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSum.Click, btnSub.Click, btnDiv.Click, btnMult.Click
        ClickOP(sender.text)
    End Sub

    Private Sub btnEqul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEqul.Click
        Select Case operation
            Case "+"
                MsgBox(num1)

            Case "-"

            Case "*"

            Case "/"

            Case Else

        End Select
    End Sub
End Class