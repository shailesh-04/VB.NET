Public Class Ex2

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubject.SelectedIndexChanged
        lstBox.Items.Add("The Selected Subject" + cmbSubject.Text)
    End Sub

    Private Sub cmbSemaster_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSemaster.SelectedIndexChanged
        Select Case cmbSemaster.Text
            Case "Sem1"
                cmbSubject.Items.Clear()
                With cmbSubject.Items
                    .Add("RDBMS")
                    .Add("C Lang")
                    .Add("FCO")
                    .Add("MATH")
                End With
                With lstBox.Items
                    .Clear()
                    .Add("The Selected Semaster" + cmbSemaster.Text)
                    .Add("RDBMS")
                    .Add("C Lang")
                    .Add("FCO")
                    .Add("MATH")
                End With
            Case "Sem2"
                cmbSubject.Items.Clear()
                lstBox.Items.Clear()
                lstBox.Items.Add(cmbSemaster.Text)
                With cmbSubject.Items
                    .Add("WEB Desine")
                    .Add("Adv C Lang")
                    .Add(" Adv FCO")
                    .Add("Stat")
                End With
                With lstBox.Items
                    .Clear()
                    .Add("The Selected Semaster" + cmbSemaster.Text)
                    .Add("WEB Desine")
                    .Add("Adv C Lang")
                    .Add(" Adv FCO")
                    .Add("Stat")
                End With
            Case "Sem3"
                cmbSubject.Items.Clear()
                lstBox.Items.Clear()
                lstBox.Items.Add(cmbSemaster.Text)
                With cmbSubject.Items
                    .Add("CPP")
                    .Add("DFS")
                    .Add("OS")
                    .Add("SAD")
                End With
                With lstBox.Items
                    .Clear()
                    .Add("The Selected Semaster" + cmbSemaster.Text)
                    .Add("CPP")
                    .Add("DFS")
                    .Add("OS")
                    .Add("SAD")
                End With
            Case "Sem4"
                cmbSubject.Items.Clear()
                lstBox.Items.Clear()
                lstBox.Items.Add(cmbSemaster.Text)
                With cmbSubject.Items
                    .Add("PHP")
                    .Add("VB")
                    .Add("Adv OS")
                    .Add("OOAD")
                End With
                With lstBox.Items
                    .Clear()
                    .Add("The Selected Semaster" + cmbSemaster.Text)
                    .Add("PHP")
                    .Add("VB")
                    .Add("Adv OS")
                    .Add("OOAD")
                End With
        End Select
        cmbSubject.Text = cmbSemaster.Text
    End Sub

    Private Sub Ex2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class