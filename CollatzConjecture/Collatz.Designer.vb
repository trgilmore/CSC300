<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollatz
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
        Me.txtInitial = New System.Windows.Forms.TextBox()
        Me.lblN = New System.Windows.Forms.Label()
        Me.lstIterations = New System.Windows.Forms.ListBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnCalculateIterations = New System.Windows.Forms.Button()
        Me.btnTopTwenty = New System.Windows.Forms.Button()
        Me.txtNext = New System.Windows.Forms.TextBox()
        Me.txtIterations = New System.Windows.Forms.TextBox()
        Me.lblNext = New System.Windows.Forms.Label()
        Me.lblIterations = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtInitial
        '
        Me.txtInitial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInitial.Location = New System.Drawing.Point(117, 24)
        Me.txtInitial.Name = "txtInitial"
        Me.txtInitial.Size = New System.Drawing.Size(81, 26)
        Me.txtInitial.TabIndex = 0
        Me.txtInitial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblN.Location = New System.Drawing.Point(71, 22)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(36, 20)
        Me.lblN.TabIndex = 1
        Me.lblN.Text = "N ="
        '
        'lstIterations
        '
        Me.lstIterations.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstIterations.FormattingEnabled = True
        Me.lstIterations.ItemHeight = 20
        Me.lstIterations.Location = New System.Drawing.Point(238, 24)
        Me.lstIterations.Name = "lstIterations"
        Me.lstIterations.Size = New System.Drawing.Size(287, 404)
        Me.lstIterations.TabIndex = 2
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(34, 173)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(164, 68)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Get next N"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnCalculateIterations
        '
        Me.btnCalculateIterations.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateIterations.Location = New System.Drawing.Point(34, 256)
        Me.btnCalculateIterations.Name = "btnCalculateIterations"
        Me.btnCalculateIterations.Size = New System.Drawing.Size(164, 68)
        Me.btnCalculateIterations.TabIndex = 4
        Me.btnCalculateIterations.Text = "Calculate Iterations"
        Me.btnCalculateIterations.UseVisualStyleBackColor = True
        '
        'btnTopTwenty
        '
        Me.btnTopTwenty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTopTwenty.Location = New System.Drawing.Point(34, 340)
        Me.btnTopTwenty.Name = "btnTopTwenty"
        Me.btnTopTwenty.Size = New System.Drawing.Size(164, 68)
        Me.btnTopTwenty.TabIndex = 5
        Me.btnTopTwenty.Text = "First 20 Iterations"
        Me.btnTopTwenty.UseVisualStyleBackColor = True
        '
        'txtNext
        '
        Me.txtNext.Enabled = False
        Me.txtNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNext.Location = New System.Drawing.Point(117, 65)
        Me.txtNext.Name = "txtNext"
        Me.txtNext.Size = New System.Drawing.Size(81, 26)
        Me.txtNext.TabIndex = 6
        Me.txtNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNext.Visible = False
        '
        'txtIterations
        '
        Me.txtIterations.Enabled = False
        Me.txtIterations.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIterations.Location = New System.Drawing.Point(117, 106)
        Me.txtIterations.Name = "txtIterations"
        Me.txtIterations.Size = New System.Drawing.Size(81, 26)
        Me.txtIterations.TabIndex = 7
        Me.txtIterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtIterations.Visible = False
        '
        'lblNext
        '
        Me.lblNext.AutoSize = True
        Me.lblNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNext.Location = New System.Drawing.Point(30, 63)
        Me.lblNext.Name = "lblNext"
        Me.lblNext.Size = New System.Drawing.Size(77, 20)
        Me.lblNext.TabIndex = 8
        Me.lblNext.Text = "Next N ="
        Me.lblNext.Visible = False
        '
        'lblIterations
        '
        Me.lblIterations.AutoSize = True
        Me.lblIterations.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIterations.Location = New System.Drawing.Point(6, 106)
        Me.lblIterations.Name = "lblIterations"
        Me.lblIterations.Size = New System.Drawing.Size(101, 20)
        Me.lblIterations.TabIndex = 9
        Me.lblIterations.Text = "Iterations ="
        Me.lblIterations.Visible = False
        '
        'frmCollatz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 461)
        Me.Controls.Add(Me.lblIterations)
        Me.Controls.Add(Me.lblNext)
        Me.Controls.Add(Me.txtIterations)
        Me.Controls.Add(Me.txtNext)
        Me.Controls.Add(Me.btnTopTwenty)
        Me.Controls.Add(Me.btnCalculateIterations)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lstIterations)
        Me.Controls.Add(Me.lblN)
        Me.Controls.Add(Me.txtInitial)
        Me.Name = "frmCollatz"
        Me.Text = "Collatz Conjecture"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInitial As TextBox
    Friend WithEvents lblN As Label
    Friend WithEvents lstIterations As ListBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnCalculateIterations As Button
    Friend WithEvents btnTopTwenty As Button
    Friend WithEvents txtNext As TextBox
    Friend WithEvents txtIterations As TextBox
    Friend WithEvents lblNext As Label
    Friend WithEvents lblIterations As Label
End Class
