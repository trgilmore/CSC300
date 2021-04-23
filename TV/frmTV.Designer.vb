<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTV
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
        Me.btnVolUp = New System.Windows.Forms.Button()
        Me.btnVolDown = New System.Windows.Forms.Button()
        Me.btnChanDown = New System.Windows.Forms.Button()
        Me.btnChanUp = New System.Windows.Forms.Button()
        Me.lvlVolume = New System.Windows.Forms.Label()
        Me.btnPower = New System.Windows.Forms.Button()
        Me.lblChannel = New System.Windows.Forms.Label()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.txtChannel = New System.Windows.Forms.TextBox()
        Me.lblPower = New System.Windows.Forms.Label()
        Me.pnlPower = New System.Windows.Forms.Panel()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblMfg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnVolUp
        '
        Me.btnVolUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolUp.Location = New System.Drawing.Point(153, 149)
        Me.btnVolUp.Name = "btnVolUp"
        Me.btnVolUp.Size = New System.Drawing.Size(72, 66)
        Me.btnVolUp.TabIndex = 0
        Me.btnVolUp.Text = "▲" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Volume Up"
        Me.btnVolUp.UseVisualStyleBackColor = True
        '
        'btnVolDown
        '
        Me.btnVolDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolDown.Location = New System.Drawing.Point(153, 235)
        Me.btnVolDown.Name = "btnVolDown"
        Me.btnVolDown.Size = New System.Drawing.Size(72, 66)
        Me.btnVolDown.TabIndex = 1
        Me.btnVolDown.Text = "Volume Down" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "▼"
        Me.btnVolDown.UseVisualStyleBackColor = True
        '
        'btnChanDown
        '
        Me.btnChanDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChanDown.Location = New System.Drawing.Point(231, 235)
        Me.btnChanDown.Name = "btnChanDown"
        Me.btnChanDown.Size = New System.Drawing.Size(72, 66)
        Me.btnChanDown.TabIndex = 3
        Me.btnChanDown.Text = "Channel Down" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "▼"
        Me.btnChanDown.UseVisualStyleBackColor = True
        '
        'btnChanUp
        '
        Me.btnChanUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChanUp.Location = New System.Drawing.Point(231, 149)
        Me.btnChanUp.Name = "btnChanUp"
        Me.btnChanUp.Size = New System.Drawing.Size(72, 66)
        Me.btnChanUp.TabIndex = 2
        Me.btnChanUp.Text = "▲" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Channel Up"
        Me.btnChanUp.UseVisualStyleBackColor = True
        '
        'lvlVolume
        '
        Me.lvlVolume.AutoSize = True
        Me.lvlVolume.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlVolume.Location = New System.Drawing.Point(144, 33)
        Me.lvlVolume.Name = "lvlVolume"
        Me.lvlVolume.Size = New System.Drawing.Size(93, 13)
        Me.lvlVolume.TabIndex = 4
        Me.lvlVolume.Text = "Current Volume"
        '
        'btnPower
        '
        Me.btnPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPower.Location = New System.Drawing.Point(12, 12)
        Me.btnPower.Name = "btnPower"
        Me.btnPower.Size = New System.Drawing.Size(72, 66)
        Me.btnPower.TabIndex = 5
        Me.btnPower.Text = "I/O" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Power"
        Me.btnPower.UseVisualStyleBackColor = True
        '
        'lblChannel
        '
        Me.lblChannel.AutoSize = True
        Me.lblChannel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChannel.Location = New System.Drawing.Point(144, 65)
        Me.lblChannel.Name = "lblChannel"
        Me.lblChannel.Size = New System.Drawing.Size(98, 13)
        Me.lblChannel.TabIndex = 6
        Me.lblChannel.Text = "Current Channel"
        '
        'txtVolume
        '
        Me.txtVolume.Enabled = False
        Me.txtVolume.Location = New System.Drawing.Point(243, 30)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(35, 20)
        Me.txtVolume.TabIndex = 7
        '
        'txtChannel
        '
        Me.txtChannel.Enabled = False
        Me.txtChannel.Location = New System.Drawing.Point(243, 62)
        Me.txtChannel.Name = "txtChannel"
        Me.txtChannel.Size = New System.Drawing.Size(35, 20)
        Me.txtChannel.TabIndex = 8
        '
        'lblPower
        '
        Me.lblPower.AutoSize = True
        Me.lblPower.Location = New System.Drawing.Point(12, 81)
        Me.lblPower.Name = "lblPower"
        Me.lblPower.Size = New System.Drawing.Size(37, 13)
        Me.lblPower.TabIndex = 9
        Me.lblPower.Text = "Power"
        '
        'pnlPower
        '
        Me.pnlPower.Location = New System.Drawing.Point(48, 81)
        Me.pnlPower.Name = "pnlPower"
        Me.pnlPower.Size = New System.Drawing.Size(18, 16)
        Me.pnlPower.TabIndex = 10
        '
        'lblBrand
        '
        Me.lblBrand.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Location = New System.Drawing.Point(211, 409)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(39, 13)
        Me.lblBrand.TabIndex = 11
        Me.lblBrand.Text = "Label1"
        Me.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMfg
        '
        Me.lblMfg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMfg.AutoSize = True
        Me.lblMfg.Location = New System.Drawing.Point(211, 422)
        Me.lblMfg.Name = "lblMfg"
        Me.lblMfg.Size = New System.Drawing.Size(39, 13)
        Me.lblMfg.TabIndex = 12
        Me.lblMfg.Text = "Label1"
        Me.lblMfg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 450)
        Me.Controls.Add(Me.lblMfg)
        Me.Controls.Add(Me.lblBrand)
        Me.Controls.Add(Me.pnlPower)
        Me.Controls.Add(Me.lblPower)
        Me.Controls.Add(Me.txtChannel)
        Me.Controls.Add(Me.txtVolume)
        Me.Controls.Add(Me.lblChannel)
        Me.Controls.Add(Me.btnPower)
        Me.Controls.Add(Me.lvlVolume)
        Me.Controls.Add(Me.btnChanDown)
        Me.Controls.Add(Me.btnChanUp)
        Me.Controls.Add(Me.btnVolDown)
        Me.Controls.Add(Me.btnVolUp)
        Me.Name = "frmTV"
        Me.Text = "TV"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVolUp As Button
    Friend WithEvents btnVolDown As Button
    Friend WithEvents btnChanDown As Button
    Friend WithEvents btnChanUp As Button
    Friend WithEvents lvlVolume As Label
    Friend WithEvents btnPower As Button
    Friend WithEvents lblChannel As Label
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents txtChannel As TextBox
    Friend WithEvents lblPower As Label
    Friend WithEvents pnlPower As Panel
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblMfg As Label
End Class
