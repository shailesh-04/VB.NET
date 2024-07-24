<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grid
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StudentTableAdapter1 = New BoundConnection.BoundConnectionDataSet1TableAdapters.StudentTableAdapter
        Me.StudentTableAdapter2 = New BoundConnection.BoundConnectionDataSetTableAdapters.StudentTableAdapter
        Me.SuspendLayout()
        '
        'StudentTableAdapter1
        '
        Me.StudentTableAdapter1.ClearBeforeFill = True
        '
        'StudentTableAdapter2
        '
        Me.StudentTableAdapter2.ClearBeforeFill = True
        '
        'Grid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 340)
        Me.Name = "Grid"
        Me.Text = "Grid"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StudentTableAdapter1 As BoundConnection.BoundConnectionDataSet1TableAdapters.StudentTableAdapter
    Friend WithEvents StudentTableAdapter2 As BoundConnection.BoundConnectionDataSetTableAdapters.StudentTableAdapter

End Class
