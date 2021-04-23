<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWeek3Exercise
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
        Me.lblSalutation = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblCitizen = New System.Windows.Forms.Label()
        Me.lblEdu = New System.Windows.Forms.Label()
        Me.cboSalutation = New System.Windows.Forms.ComboBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.cboCitizen = New System.Windows.Forms.ComboBox()
        Me.lstEdu = New System.Windows.Forms.ListBox()
        Me.btnPop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSalutation
        '
        Me.lblSalutation.AutoSize = True
        Me.lblSalutation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalutation.Location = New System.Drawing.Point(13, 13)
        Me.lblSalutation.Name = "lblSalutation"
        Me.lblSalutation.Size = New System.Drawing.Size(126, 26)
        Me.lblSalutation.TabIndex = 0
        Me.lblSalutation.Text = "Salutation:"
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst.Location = New System.Drawing.Point(12, 59)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(136, 26)
        Me.lblFirst.TabIndex = 1
        Me.lblFirst.Text = "First Name:"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast.Location = New System.Drawing.Point(12, 108)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(134, 26)
        Me.lblLast.TabIndex = 2
        Me.lblLast.Text = "Last Name:"
        '
        'lblCitizen
        '
        Me.lblCitizen.AutoSize = True
        Me.lblCitizen.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCitizen.Location = New System.Drawing.Point(13, 154)
        Me.lblCitizen.Name = "lblCitizen"
        Me.lblCitizen.Size = New System.Drawing.Size(137, 26)
        Me.lblCitizen.TabIndex = 3
        Me.lblCitizen.Text = "Citizenship:"
        '
        'lblEdu
        '
        Me.lblEdu.AutoSize = True
        Me.lblEdu.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdu.Location = New System.Drawing.Point(13, 206)
        Me.lblEdu.Name = "lblEdu"
        Me.lblEdu.Size = New System.Drawing.Size(213, 26)
        Me.lblEdu.TabIndex = 4
        Me.lblEdu.Text = "Highest Education:"
        '
        'cboSalutation
        '
        Me.cboSalutation.FormattingEnabled = True
        Me.cboSalutation.Items.AddRange(New Object() {"Mr.", "Mrs.", "Ms.", "Dr.", "Esq."})
        Me.cboSalutation.Location = New System.Drawing.Point(230, 18)
        Me.cboSalutation.Name = "cboSalutation"
        Me.cboSalutation.Size = New System.Drawing.Size(163, 21)
        Me.cboSalutation.TabIndex = 5
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(230, 65)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(163, 20)
        Me.txtFirst.TabIndex = 6
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(232, 114)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(161, 20)
        Me.txtLast.TabIndex = 7
        '
        'cboCitizen
        '
        Me.cboCitizen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCitizen.FormattingEnabled = True
        Me.cboCitizen.Items.AddRange(New Object() {"USA", "Angola", "France", "Germany"})
        Me.cboCitizen.Location = New System.Drawing.Point(232, 160)
        Me.cboCitizen.Name = "cboCitizen"
        Me.cboCitizen.Size = New System.Drawing.Size(161, 21)
        Me.cboCitizen.TabIndex = 8
        '
        'lstEdu
        '
        Me.lstEdu.FormattingEnabled = True
        Me.lstEdu.Items.AddRange(New Object() {"Middle School", "High School/GED", "Certificate", "Some College", "4 Year Degree", "Masters", "PhD"})
        Me.lstEdu.Location = New System.Drawing.Point(232, 206)
        Me.lstEdu.Name = "lstEdu"
        Me.lstEdu.Size = New System.Drawing.Size(161, 95)
        Me.lstEdu.TabIndex = 9
        '
        'btnPop
        '
        Me.btnPop.Location = New System.Drawing.Point(13, 345)
        Me.btnPop.Name = "btnPop"
        Me.btnPop.Size = New System.Drawing.Size(75, 23)
        Me.btnPop.TabIndex = 10
        Me.btnPop.Text = "Show Greeting"
        Me.btnPop.UseVisualStyleBackColor = True
        '
        'frmWeek3Exercise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 460)
        Me.Controls.Add(Me.btnPop)
        Me.Controls.Add(Me.lstEdu)
        Me.Controls.Add(Me.cboCitizen)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.cboSalutation)
        Me.Controls.Add(Me.lblEdu)
        Me.Controls.Add(Me.lblCitizen)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.lblSalutation)
        Me.Name = "frmWeek3Exercise"
        Me.Text = "Week 3 Exercise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSalutation As Label
    Friend WithEvents lblFirst As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents lblCitizen As Label
    Friend WithEvents lblEdu As Label
    Friend WithEvents cboSalutation As ComboBox
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents cboCitizen As ComboBox
    Friend WithEvents lstEdu As ListBox
    Friend WithEvents btnPop As Button
End Class
