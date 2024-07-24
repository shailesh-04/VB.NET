<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.header = New System.Windows.Forms.Label
        Me.btnEx1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnEx2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.AutoSize = True
        Me.header.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.Location = New System.Drawing.Point(113, 9)
        Me.header.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(114, 20)
        Me.header.TabIndex = 0
        Me.header.Text = "List Of Exesize"
        '
        'btnEx1
        '
        Me.btnEx1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEx1.Location = New System.Drawing.Point(12, 59)
        Me.btnEx1.Name = "btnEx1"
        Me.btnEx1.Size = New System.Drawing.Size(112, 39)
        Me.btnEx1.TabIndex = 2
        Me.btnEx1.Text = "Ex1 Open"
        Me.btnEx1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(12, 180)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 39)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Ex1 Open"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnEx2
        '
        Me.btnEx2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEx2.Location = New System.Drawing.Point(12, 114)
        Me.btnEx2.Name = "btnEx2"
        Me.btnEx2.Size = New System.Drawing.Size(112, 39)
        Me.btnEx2.TabIndex = 4
        Me.btnEx2.Text = "Ex2 Open"
        Me.btnEx2.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 321)
        Me.Controls.Add(Me.btnEx2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnEx1)
        Me.Controls.Add(Me.header)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents header As System.Windows.Forms.Label
    Friend WithEvents btnEx1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnEx2 As System.Windows.Forms.Button
End Class
