<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMicrowaveOven
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
        Me.components = New System.ComponentModel.Container()
        Me.pnlOven = New System.Windows.Forms.Panel()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.pnlTime = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.tmrCook = New System.Windows.Forms.Timer(Me.components)
        Me.pnlControls.SuspendLayout()
        Me.pnlTime.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlOven
        '
        Me.pnlOven.BackColor = System.Drawing.Color.LightGray
        Me.pnlOven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOven.Location = New System.Drawing.Point(12, 12)
        Me.pnlOven.Name = "pnlOven"
        Me.pnlOven.Size = New System.Drawing.Size(509, 337)
        Me.pnlOven.TabIndex = 0
        '
        'pnlControls
        '
        Me.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlControls.Controls.Add(Me.btnClear)
        Me.pnlControls.Controls.Add(Me.btnStart)
        Me.pnlControls.Controls.Add(Me.btn0)
        Me.pnlControls.Controls.Add(Me.btn9)
        Me.pnlControls.Controls.Add(Me.btn8)
        Me.pnlControls.Controls.Add(Me.btn7)
        Me.pnlControls.Controls.Add(Me.btn6)
        Me.pnlControls.Controls.Add(Me.btn5)
        Me.pnlControls.Controls.Add(Me.btn4)
        Me.pnlControls.Controls.Add(Me.btn3)
        Me.pnlControls.Controls.Add(Me.btn2)
        Me.pnlControls.Controls.Add(Me.btn1)
        Me.pnlControls.Controls.Add(Me.pnlTime)
        Me.pnlControls.Location = New System.Drawing.Point(527, 12)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(245, 337)
        Me.pnlControls.TabIndex = 1
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(149, 280)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(73, 40)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(22, 280)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(80, 40)
        Me.btnStart.TabIndex = 11
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(108, 227)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(35, 37)
        Me.btn0.TabIndex = 10
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(149, 184)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(35, 37)
        Me.btn9.TabIndex = 9
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(108, 184)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(35, 37)
        Me.btn8.TabIndex = 8
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(67, 184)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(35, 37)
        Me.btn7.TabIndex = 7
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(149, 141)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(35, 37)
        Me.btn6.TabIndex = 6
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(108, 141)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(35, 37)
        Me.btn5.TabIndex = 5
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(67, 141)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(35, 37)
        Me.btn4.TabIndex = 4
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(149, 98)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(35, 37)
        Me.btn3.TabIndex = 3
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(108, 98)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(35, 37)
        Me.btn2.TabIndex = 2
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(67, 98)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(35, 37)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'pnlTime
        '
        Me.pnlTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTime.Controls.Add(Me.lblTime)
        Me.pnlTime.Location = New System.Drawing.Point(22, 16)
        Me.pnlTime.Name = "pnlTime"
        Me.pnlTime.Size = New System.Drawing.Size(200, 64)
        Me.pnlTime.TabIndex = 0
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(54, 17)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(94, 31)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "00:00"
        '
        'tmrCook
        '
        Me.tmrCook.Interval = 1000
        '
        'frmMicrowaveOven
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 361)
        Me.Controls.Add(Me.pnlControls)
        Me.Controls.Add(Me.pnlOven)
        Me.Name = "frmMicrowaveOven"
        Me.Text = "Microwave Oven"
        Me.pnlControls.ResumeLayout(False)
        Me.pnlTime.ResumeLayout(False)
        Me.pnlTime.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlOven As Panel
    Friend WithEvents pnlControls As Panel
    Friend WithEvents btn0 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents pnlTime As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents tmrCook As Timer
End Class
