<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWeek8
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
        Me.lstDetails = New System.Windows.Forms.ListBox()
        Me.btnDemoArray = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstDetails
        '
        Me.lstDetails.FormattingEnabled = True
        Me.lstDetails.Location = New System.Drawing.Point(726, 26)
        Me.lstDetails.Name = "lstDetails"
        Me.lstDetails.Size = New System.Drawing.Size(248, 394)
        Me.lstDetails.TabIndex = 0
        '
        'btnDemoArray
        '
        Me.btnDemoArray.Location = New System.Drawing.Point(22, 9)
        Me.btnDemoArray.Name = "btnDemoArray"
        Me.btnDemoArray.Size = New System.Drawing.Size(118, 48)
        Me.btnDemoArray.TabIndex = 1
        Me.btnDemoArray.Text = "Button1"
        Me.btnDemoArray.UseVisualStyleBackColor = True
        '
        'frmWeek8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 450)
        Me.Controls.Add(Me.btnDemoArray)
        Me.Controls.Add(Me.lstDetails)
        Me.Name = "frmWeek8"
        Me.Text = "Week8"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstDetails As ListBox
    Friend WithEvents btnDemoArray As Button
End Class
