<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWeek4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.txtInput1 = New System.Windows.Forms.TextBox()
        Me.txtInput2 = New System.Windows.Forms.TextBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lstTape = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(246, 189)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(316, 116)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "Calc"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'txtInput1
        '
        Me.txtInput1.Location = New System.Drawing.Point(402, 42)
        Me.txtInput1.Name = "txtInput1"
        Me.txtInput1.Size = New System.Drawing.Size(259, 20)
        Me.txtInput1.TabIndex = 1
        '
        'txtInput2
        '
        Me.txtInput2.Location = New System.Drawing.Point(143, 42)
        Me.txtInput2.Name = "txtInput2"
        Me.txtInput2.Size = New System.Drawing.Size(259, 20)
        Me.txtInput2.TabIndex = 2
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(218, 370)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(373, 20)
        Me.txtAnswer.TabIndex = 3
        '
        'lstTape
        '
        Me.lstTape.FormattingEnabled = True
        Me.lstTape.Location = New System.Drawing.Point(637, 79)
        Me.lstTape.Name = "lstTape"
        Me.lstTape.Size = New System.Drawing.Size(157, 342)
        Me.lstTape.TabIndex = 4
        '
        'frmWeek4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstTape)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.txtInput2)
        Me.Controls.Add(Me.txtInput1)
        Me.Controls.Add(Me.btnCalc)
        Me.Name = "frmWeek4"
        Me.Text = "Week 4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents txtInput1 As TextBox
    Friend WithEvents txtInput2 As TextBox
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents lstTape As ListBox
End Class
