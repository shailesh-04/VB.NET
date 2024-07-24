Public Class Ex1

    Private Sub Ex1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFile.Click
        OpenFileDialog1.ShowDialog()
        PtrBox.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub PtrBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PtrBox.Click

    End Sub
End Class
