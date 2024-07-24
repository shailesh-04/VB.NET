<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ex2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbSemaster = New System.Windows.Forms.ComboBox
        Me.cmbSubject = New System.Windows.Forms.ComboBox
        Me.lblHeader = New System.Windows.Forms.Label
        Me.lstBox = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'cmbSemaster
        '
        Me.cmbSemaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSemaster.FormattingEnabled = True
        Me.cmbSemaster.Items.AddRange(New Object() {"Sem1", "Sem2", "Sem3", "Sem4", "Sem5", "Sem6"})
        Me.cmbSemaster.Location = New System.Drawing.Point(65, 64)
        Me.cmbSemaster.Name = "cmbSemaster"
        Me.cmbSemaster.Size = New System.Drawing.Size(215, 24)
        Me.cmbSemaster.TabIndex = 0
        Me.cmbSemaster.Text = "SelectSemaster"
        '
        'cmbSubject
        '
        Me.cmbSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubject.FormattingEnabled = True
        Me.cmbSubject.Location = New System.Drawing.Point(65, 109)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(215, 24)
        Me.cmbSubject.TabIndex = 1
        Me.cmbSubject.Text = "SelectSubject"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(61, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(254, 24)
        Me.lblHeader.TabIndex = 2
        Me.lblHeader.Text = "Select Semaster And Subject"
        '
        'lstBox
        '
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.Location = New System.Drawing.Point(66, 156)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(214, 95)
        Me.lstBox.TabIndex = 3
        Me.lstBox.Tag = ""
        '
        'Ex2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 350)
        Me.Controls.Add(Me.lstBox)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.cmbSubject)
        Me.Controls.Add(Me.cmbSemaster)
        Me.Name = "Ex2"
        Me.Text = "Ex2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbSemaster As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSubject As System.Windows.Forms.ComboBox
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lstBox As System.Windows.Forms.ListBox
End Class
