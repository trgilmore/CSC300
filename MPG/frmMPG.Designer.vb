<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMPG
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
        Me.txtOdo1 = New System.Windows.Forms.TextBox()
        Me.txtOdo2 = New System.Windows.Forms.TextBox()
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.txtMPG = New System.Windows.Forms.TextBox()
        Me.lblOdo1 = New System.Windows.Forms.Label()
        Me.lblOdo2 = New System.Windows.Forms.Label()
        Me.lblGallons = New System.Windows.Forms.Label()
        Me.lblMPG = New System.Windows.Forms.Label()
        Me.btnMPG = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOdo1
        '
        Me.txtOdo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOdo1.Location = New System.Drawing.Point(247, 40)
        Me.txtOdo1.Name = "txtOdo1"
        Me.txtOdo1.Size = New System.Drawing.Size(124, 35)
        Me.txtOdo1.TabIndex = 0
        '
        'txtOdo2
        '
        Me.txtOdo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOdo2.Location = New System.Drawing.Point(247, 102)
        Me.txtOdo2.Name = "txtOdo2"
        Me.txtOdo2.Size = New System.Drawing.Size(124, 35)
        Me.txtOdo2.TabIndex = 1
        '
        'txtGallons
        '
        Me.txtGallons.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGallons.Location = New System.Drawing.Point(247, 164)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(124, 35)
        Me.txtGallons.TabIndex = 2
        '
        'txtMPG
        '
        Me.txtMPG.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMPG.Location = New System.Drawing.Point(247, 226)
        Me.txtMPG.Name = "txtMPG"
        Me.txtMPG.Size = New System.Drawing.Size(124, 35)
        Me.txtMPG.TabIndex = 3
        '
        'lblOdo1
        '
        Me.lblOdo1.AutoSize = True
        Me.lblOdo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOdo1.Location = New System.Drawing.Point(83, 43)
        Me.lblOdo1.Name = "lblOdo1"
        Me.lblOdo1.Size = New System.Drawing.Size(147, 29)
        Me.lblOdo1.TabIndex = 4
        Me.lblOdo1.Text = "Odometer 1:"
        '
        'lblOdo2
        '
        Me.lblOdo2.AutoSize = True
        Me.lblOdo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOdo2.Location = New System.Drawing.Point(83, 102)
        Me.lblOdo2.Name = "lblOdo2"
        Me.lblOdo2.Size = New System.Drawing.Size(147, 29)
        Me.lblOdo2.TabIndex = 5
        Me.lblOdo2.Text = "Odometer 2:"
        '
        'lblGallons
        '
        Me.lblGallons.AutoSize = True
        Me.lblGallons.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGallons.Location = New System.Drawing.Point(83, 164)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.Size = New System.Drawing.Size(101, 29)
        Me.lblGallons.TabIndex = 6
        Me.lblGallons.Text = "Gallons:"
        '
        'lblMPG
        '
        Me.lblMPG.AutoSize = True
        Me.lblMPG.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMPG.Location = New System.Drawing.Point(83, 226)
        Me.lblMPG.Name = "lblMPG"
        Me.lblMPG.Size = New System.Drawing.Size(73, 29)
        Me.lblMPG.TabIndex = 7
        Me.lblMPG.Text = "MPG:"
        '
        'btnMPG
        '
        Me.btnMPG.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMPG.Location = New System.Drawing.Point(168, 333)
        Me.btnMPG.Name = "btnMPG"
        Me.btnMPG.Size = New System.Drawing.Size(149, 69)
        Me.btnMPG.TabIndex = 8
        Me.btnMPG.Text = "Calculate MPG"
        Me.btnMPG.UseVisualStyleBackColor = True
        '
        'frmMPG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.btnMPG)
        Me.Controls.Add(Me.lblMPG)
        Me.Controls.Add(Me.lblGallons)
        Me.Controls.Add(Me.lblOdo2)
        Me.Controls.Add(Me.lblOdo1)
        Me.Controls.Add(Me.txtMPG)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.txtOdo2)
        Me.Controls.Add(Me.txtOdo1)
        Me.Name = "frmMPG"
        Me.Text = "MPG Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOdo1 As TextBox
    Friend WithEvents txtOdo2 As TextBox
    Friend WithEvents txtGallons As TextBox
    Friend WithEvents txtMPG As TextBox
    Friend WithEvents lblOdo1 As Label
    Friend WithEvents lblOdo2 As Label
    Friend WithEvents lblGallons As Label
    Friend WithEvents lblMPG As Label
    Friend WithEvents btnMPG As Button
End Class
