<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtno = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.rbtmale = New System.Windows.Forms.RadioButton
        Me.rbtfemale = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 106)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 177)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Gender :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 27.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(145, 39)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(277, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gender Select"
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(283, 106)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(129, 33)
        Me.txtno.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(235, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 35)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rbtmale
        '
        Me.rbtmale.AutoSize = True
        Me.rbtmale.Location = New System.Drawing.Point(240, 177)
        Me.rbtmale.Name = "rbtmale"
        Me.rbtmale.Size = New System.Drawing.Size(76, 25)
        Me.rbtmale.TabIndex = 7
        Me.rbtmale.TabStop = True
        Me.rbtmale.Text = "Male"
        Me.rbtmale.UseVisualStyleBackColor = True
        '
        'rbtfemale
        '
        Me.rbtfemale.AutoSize = True
        Me.rbtfemale.Location = New System.Drawing.Point(322, 175)
        Me.rbtfemale.Name = "rbtfemale"
        Me.rbtfemale.Size = New System.Drawing.Size(100, 25)
        Me.rbtfemale.TabIndex = 8
        Me.rbtfemale.TabStop = True
        Me.rbtfemale.Text = "Female"
        Me.rbtfemale.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 415)
        Me.Controls.Add(Me.rbtfemale)
        Me.Controls.Add(Me.rbtmale)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents rbtmale As System.Windows.Forms.RadioButton
    Friend WithEvents rbtfemale As System.Windows.Forms.RadioButton

End Class
