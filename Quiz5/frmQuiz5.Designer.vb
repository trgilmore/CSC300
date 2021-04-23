<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuiz5
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
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.txtLabel = New System.Windows.Forms.TextBox()
        Me.btnAddStick = New System.Windows.Forms.Button()
        Me.lstMemory = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(21, 27)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(31, 13)
        Me.lblColor.TabIndex = 0
        Me.lblColor.Text = "Color"
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(21, 56)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(48, 13)
        Me.lblCapacity.TabIndex = 1
        Me.lblCapacity.Text = "Capacity"
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.Location = New System.Drawing.Point(21, 82)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(33, 13)
        Me.lblLabel.TabIndex = 2
        Me.lblLabel.Text = "Label"
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(85, 24)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(105, 20)
        Me.txtColor.TabIndex = 3
        '
        'txtCapacity
        '
        Me.txtCapacity.Location = New System.Drawing.Point(85, 53)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(105, 20)
        Me.txtCapacity.TabIndex = 4
        '
        'txtLabel
        '
        Me.txtLabel.Location = New System.Drawing.Point(85, 79)
        Me.txtLabel.Name = "txtLabel"
        Me.txtLabel.Size = New System.Drawing.Size(105, 20)
        Me.txtLabel.TabIndex = 5
        '
        'btnAddStick
        '
        Me.btnAddStick.Location = New System.Drawing.Point(239, 29)
        Me.btnAddStick.Name = "btnAddStick"
        Me.btnAddStick.Size = New System.Drawing.Size(88, 69)
        Me.btnAddStick.TabIndex = 6
        Me.btnAddStick.Text = "Add Memory stick"
        Me.btnAddStick.UseVisualStyleBackColor = True
        '
        'lstMemory
        '
        Me.lstMemory.FormattingEnabled = True
        Me.lstMemory.Location = New System.Drawing.Point(18, 167)
        Me.lstMemory.Name = "lstMemory"
        Me.lstMemory.Size = New System.Drawing.Size(741, 212)
        Me.lstMemory.TabIndex = 7
        '
        'frmQuiz5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstMemory)
        Me.Controls.Add(Me.btnAddStick)
        Me.Controls.Add(Me.txtLabel)
        Me.Controls.Add(Me.txtCapacity)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.lblLabel)
        Me.Controls.Add(Me.lblCapacity)
        Me.Controls.Add(Me.lblColor)
        Me.Name = "frmQuiz5"
        Me.Text = "Quiz 5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblColor As Label
    Friend WithEvents lblCapacity As Label
    Friend WithEvents lblLabel As Label
    Friend WithEvents txtColor As TextBox
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents txtLabel As TextBox
    Friend WithEvents btnAddStick As Button
    Friend WithEvents lstMemory As ListBox
End Class
