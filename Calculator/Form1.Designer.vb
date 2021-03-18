<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
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
        Me.txtBox = New System.Windows.Forms.TextBox()
        Me.pnlNumbers = New System.Windows.Forms.Panel()
        Me.btn00 = New System.Windows.Forms.Button()
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
        Me.pnlMath = New System.Windows.Forms.Panel()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnDec = New System.Windows.Forms.Button()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.btnOff = New System.Windows.Forms.Button()
        Me.pnlNumbers.SuspendLayout()
        Me.pnlMath.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBox
        '
        Me.txtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox.Location = New System.Drawing.Point(17, 20)
        Me.txtBox.Name = "txtBox"
        Me.txtBox.Size = New System.Drawing.Size(550, 29)
        Me.txtBox.TabIndex = 0
        Me.txtBox.Text = "0"
        Me.txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlNumbers
        '
        Me.pnlNumbers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNumbers.Controls.Add(Me.btn00)
        Me.pnlNumbers.Controls.Add(Me.btn0)
        Me.pnlNumbers.Controls.Add(Me.btn9)
        Me.pnlNumbers.Controls.Add(Me.btn8)
        Me.pnlNumbers.Controls.Add(Me.btn7)
        Me.pnlNumbers.Controls.Add(Me.btn6)
        Me.pnlNumbers.Controls.Add(Me.btn5)
        Me.pnlNumbers.Controls.Add(Me.btn4)
        Me.pnlNumbers.Controls.Add(Me.btn3)
        Me.pnlNumbers.Controls.Add(Me.btn2)
        Me.pnlNumbers.Controls.Add(Me.btn1)
        Me.pnlNumbers.Location = New System.Drawing.Point(17, 84)
        Me.pnlNumbers.Name = "pnlNumbers"
        Me.pnlNumbers.Size = New System.Drawing.Size(221, 274)
        Me.pnlNumbers.TabIndex = 1
        '
        'btn00
        '
        Me.btn00.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn00.Location = New System.Drawing.Point(84, 209)
        Me.btn00.Name = "btn00"
        Me.btn00.Size = New System.Drawing.Size(101, 43)
        Me.btn00.TabIndex = 10
        Me.btn00.Text = "00"
        Me.btn00.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(30, 209)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(48, 43)
        Me.btn0.TabIndex = 9
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(138, 150)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(48, 43)
        Me.btn9.TabIndex = 8
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(84, 150)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(48, 43)
        Me.btn8.TabIndex = 7
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(30, 150)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(48, 43)
        Me.btn7.TabIndex = 6
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(138, 87)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(48, 43)
        Me.btn6.TabIndex = 5
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(84, 87)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(48, 43)
        Me.btn5.TabIndex = 4
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(30, 87)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(48, 43)
        Me.btn4.TabIndex = 3
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(138, 22)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(48, 43)
        Me.btn3.TabIndex = 2
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(84, 22)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(48, 43)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(30, 22)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(48, 43)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'pnlMath
        '
        Me.pnlMath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlMath.Controls.Add(Me.btnEquals)
        Me.pnlMath.Controls.Add(Me.btnDec)
        Me.pnlMath.Controls.Add(Me.btnDivide)
        Me.pnlMath.Controls.Add(Me.btnPlus)
        Me.pnlMath.Controls.Add(Me.btnMultiply)
        Me.pnlMath.Controls.Add(Me.btnMinus)
        Me.pnlMath.Location = New System.Drawing.Point(277, 84)
        Me.pnlMath.Name = "pnlMath"
        Me.pnlMath.Size = New System.Drawing.Size(148, 274)
        Me.pnlMath.TabIndex = 2
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(15, 22)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(48, 171)
        Me.btnPlus.TabIndex = 0
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnDec
        '
        Me.btnDec.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDec.Location = New System.Drawing.Point(15, 209)
        Me.btnDec.Name = "btnDec"
        Me.btnDec.Size = New System.Drawing.Size(47, 42)
        Me.btnDec.TabIndex = 1
        Me.btnDec.Text = "."
        Me.btnDec.UseVisualStyleBackColor = True
        '
        'btnEquals
        '
        Me.btnEquals.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEquals.Location = New System.Drawing.Point(82, 209)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(48, 43)
        Me.btnEquals.TabIndex = 14
        Me.btnEquals.Text = "="
        Me.btnEquals.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.Location = New System.Drawing.Point(82, 150)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(48, 43)
        Me.btnDivide.TabIndex = 13
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiply.Location = New System.Drawing.Point(82, 87)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(48, 43)
        Me.btnMultiply.TabIndex = 12
        Me.btnMultiply.Text = "X"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus.Location = New System.Drawing.Point(82, 22)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(48, 43)
        Me.btnMinus.TabIndex = 11
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnClearAll)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Location = New System.Drawing.Point(463, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(104, 169)
        Me.Panel1.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(14, 21)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 46)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAll.Location = New System.Drawing.Point(14, 98)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(75, 46)
        Me.btnClearAll.TabIndex = 1
        Me.btnClearAll.Text = "C/A"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'btnOff
        '
        Me.btnOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOff.Location = New System.Drawing.Point(463, 295)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(103, 42)
        Me.btnOff.TabIndex = 4
        Me.btnOff.Text = "OFF"
        Me.btnOff.UseVisualStyleBackColor = True
        '
        'frmCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 376)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlMath)
        Me.Controls.Add(Me.pnlNumbers)
        Me.Controls.Add(Me.txtBox)
        Me.Name = "frmCalculator"
        Me.Text = "Calculator"
        Me.pnlNumbers.ResumeLayout(False)
        Me.pnlMath.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBox As TextBox
    Friend WithEvents pnlNumbers As Panel
    Friend WithEvents pnlMath As Panel
    Friend WithEvents btn00 As Button
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
    Friend WithEvents btnEquals As Button
    Friend WithEvents btnDec As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClearAll As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnOff As Button
End Class
