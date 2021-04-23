<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWeek7
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
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnShowCustomer = New System.Windows.Forms.Button()
        Me.lstCustomers = New System.Windows.Forms.ListBox()
        Me.btnCreateIn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(703, 56)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(170, 23)
        Me.txtId.TabIndex = 0
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(703, 114)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(170, 23)
        Me.txtCity.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(703, 85)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(170, 23)
        Me.txtName.TabIndex = 3
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(649, 62)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(21, 17)
        Me.lblId.TabIndex = 4
        Me.lblId.Text = "ID"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(649, 120)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(31, 17)
        Me.lblCity.TabIndex = 6
        Me.lblCity.Text = "City"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(649, 91)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 17)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Name"
        '
        'btnShowCustomer
        '
        Me.btnShowCustomer.Location = New System.Drawing.Point(652, 143)
        Me.btnShowCustomer.Name = "btnShowCustomer"
        Me.btnShowCustomer.Size = New System.Drawing.Size(221, 50)
        Me.btnShowCustomer.TabIndex = 8
        Me.btnShowCustomer.Text = "Show Customer"
        Me.btnShowCustomer.UseVisualStyleBackColor = True
        '
        'lstCustomers
        '
        Me.lstCustomers.FormattingEnabled = True
        Me.lstCustomers.ItemHeight = 16
        Me.lstCustomers.Location = New System.Drawing.Point(130, 39)
        Me.lstCustomers.Name = "lstCustomers"
        Me.lstCustomers.Size = New System.Drawing.Size(244, 308)
        Me.lstCustomers.TabIndex = 9
        '
        'btnCreateIn
        '
        Me.btnCreateIn.Location = New System.Drawing.Point(652, 199)
        Me.btnCreateIn.Name = "btnCreateIn"
        Me.btnCreateIn.Size = New System.Drawing.Size(220, 38)
        Me.btnCreateIn.TabIndex = 10
        Me.btnCreateIn.Text = "Create Instance"
        Me.btnCreateIn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(649, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(223, 29)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(657, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(214, 64)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Roll Die"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmWeek7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCreateIn)
        Me.Controls.Add(Me.lstCustomers)
        Me.Controls.Add(Me.btnShowCustomer)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtId)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmWeek7"
        Me.Text = "Week 7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtId As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnShowCustomer As Button
    Friend WithEvents lstCustomers As ListBox
    Friend WithEvents btnCreateIn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
