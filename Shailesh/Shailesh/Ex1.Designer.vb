<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ex1
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.PtrBox = New System.Windows.Forms.PictureBox
        Me.btnOpenFile = New System.Windows.Forms.Button
        CType(Me.PtrBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PtrBox
        '
        Me.PtrBox.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PtrBox.Location = New System.Drawing.Point(12, 12)
        Me.PtrBox.Name = "PtrBox"
        Me.PtrBox.Size = New System.Drawing.Size(204, 206)
        Me.PtrBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtrBox.TabIndex = 0
        Me.PtrBox.TabStop = False
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(244, 195)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenFile.TabIndex = 1
        Me.btnOpenFile.Text = "OpenFile"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'Ex1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 356)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.PtrBox)
        Me.Name = "Ex1"
        Me.Text = "Ex1"
        CType(Me.PtrBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PtrBox As System.Windows.Forms.PictureBox
    Friend WithEvents btnOpenFile As System.Windows.Forms.Button

End Class
