<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWeek2
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
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.lstlog = New System.Windows.Forms.ListBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Location = New System.Drawing.Point(131, 82)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(0, 26)
        Me.lblDisplay.TabIndex = 1
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(56, 148)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 44)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'lstlog
        '
        Me.lstlog.FormattingEnabled = True
        Me.lstlog.ItemHeight = 25
        Me.lstlog.Location = New System.Drawing.Point(329, 141)
        Me.lstlog.Name = "lstlog"
        Me.lstlog.Size = New System.Drawing.Size(317, 129)
        Me.lstlog.TabIndex = 4
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(334, 36)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(283, 32)
        Me.txtNumber.TabIndex = 2
        '
        'dtp
        '
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp.Location = New System.Drawing.Point(487, 96)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(140, 32)
        Me.dtp.TabIndex = 0
        '
        'frmWeek2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 311)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lstlog)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lblDisplay)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmWeek2"
        Me.Text = "Week 2 Stuff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDisplay As Label
    Friend WithEvents btn1 As Button
    Friend WithEvents lstlog As ListBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents dtp As DateTimePicker
End Class
