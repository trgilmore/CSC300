<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiaryeMain
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Country Loaf", "KA Bread Flour 800g", "680g", "18g"}, -1)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiaryeMain))
        Me.btnNewStarter = New System.Windows.Forms.Button()
        Me.lstvStarters = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDeleteStarter = New System.Windows.Forms.Button()
        Me.lblStarter = New System.Windows.Forms.Label()
        Me.lblRecipes = New System.Windows.Forms.Label()
        Me.btnDeleteRecipe = New System.Windows.Forms.Button()
        Me.lstvRecipes = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnNewRecipe = New System.Windows.Forms.Button()
        Me.btnBake = New System.Windows.Forms.Button()
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnNewStarter
        '
        Me.btnNewStarter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewStarter.Location = New System.Drawing.Point(21, 65)
        Me.btnNewStarter.Name = "btnNewStarter"
        Me.btnNewStarter.Size = New System.Drawing.Size(130, 140)
        Me.btnNewStarter.TabIndex = 0
        Me.btnNewStarter.Text = "+" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "New Starter"
        Me.btnNewStarter.UseVisualStyleBackColor = True
        '
        'lstvStarters
        '
        Me.lstvStarters.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15})
        Me.lstvStarters.HideSelection = False
        Me.lstvStarters.Location = New System.Drawing.Point(157, 65)
        Me.lstvStarters.Name = "lstvStarters"
        Me.lstvStarters.Size = New System.Drawing.Size(738, 140)
        Me.lstvStarters.TabIndex = 1
        Me.lstvStarters.UseCompatibleStateImageBehavior = False
        Me.lstvStarters.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Starter Name"
        Me.ColumnHeader1.Width = 74
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Creation Date"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Recipe"
        Me.ColumnHeader3.Width = 152
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Hydration"
        Me.ColumnHeader10.Width = 57
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Schedule"
        Me.ColumnHeader11.Width = 57
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Status"
        Me.ColumnHeader12.Width = 42
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Hibernation"
        Me.ColumnHeader13.Width = 66
        '
        'btnDeleteStarter
        '
        Me.btnDeleteStarter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteStarter.Location = New System.Drawing.Point(901, 65)
        Me.btnDeleteStarter.Name = "btnDeleteStarter"
        Me.btnDeleteStarter.Size = New System.Drawing.Size(150, 40)
        Me.btnDeleteStarter.TabIndex = 3
        Me.btnDeleteStarter.Text = "Delete"
        Me.btnDeleteStarter.UseVisualStyleBackColor = True
        '
        'lblStarter
        '
        Me.lblStarter.AutoSize = True
        Me.lblStarter.Font = New System.Drawing.Font("Segoe Script", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStarter.Location = New System.Drawing.Point(12, 9)
        Me.lblStarter.Name = "lblStarter"
        Me.lblStarter.Size = New System.Drawing.Size(106, 40)
        Me.lblStarter.TabIndex = 5
        Me.lblStarter.Text = "Starter"
        '
        'lblRecipes
        '
        Me.lblRecipes.AutoSize = True
        Me.lblRecipes.Font = New System.Drawing.Font("Segoe Script", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecipes.Location = New System.Drawing.Point(12, 219)
        Me.lblRecipes.Name = "lblRecipes"
        Me.lblRecipes.Size = New System.Drawing.Size(113, 40)
        Me.lblRecipes.TabIndex = 6
        Me.lblRecipes.Text = "Recipes"
        '
        'btnDeleteRecipe
        '
        Me.btnDeleteRecipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteRecipe.Location = New System.Drawing.Point(901, 271)
        Me.btnDeleteRecipe.Name = "btnDeleteRecipe"
        Me.btnDeleteRecipe.Size = New System.Drawing.Size(150, 40)
        Me.btnDeleteRecipe.TabIndex = 10
        Me.btnDeleteRecipe.Text = "Delete"
        Me.btnDeleteRecipe.UseVisualStyleBackColor = True
        '
        'lstvRecipes
        '
        Me.lstvRecipes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lstvRecipes.HideSelection = False
        ListViewItem1.StateImageIndex = 0
        Me.lstvRecipes.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lstvRecipes.Location = New System.Drawing.Point(157, 271)
        Me.lstvRecipes.Name = "lstvRecipes"
        Me.lstvRecipes.Size = New System.Drawing.Size(738, 140)
        Me.lstvRecipes.TabIndex = 8
        Me.lstvRecipes.UseCompatibleStateImageBehavior = False
        Me.lstvRecipes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Recipe Title"
        Me.ColumnHeader4.Width = 74
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Flour"
        Me.ColumnHeader5.Width = 140
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Water"
        Me.ColumnHeader6.Width = 47
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Salt"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Starter"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Additions"
        '
        'btnNewRecipe
        '
        Me.btnNewRecipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRecipe.Location = New System.Drawing.Point(21, 271)
        Me.btnNewRecipe.Name = "btnNewRecipe"
        Me.btnNewRecipe.Size = New System.Drawing.Size(130, 140)
        Me.btnNewRecipe.TabIndex = 7
        Me.btnNewRecipe.Text = "+" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "New Recipe"
        Me.btnNewRecipe.UseVisualStyleBackColor = True
        '
        'btnBake
        '
        Me.btnBake.Font = New System.Drawing.Font("Segoe Script", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBake.Location = New System.Drawing.Point(133, 459)
        Me.btnBake.Name = "btnBake"
        Me.btnBake.Size = New System.Drawing.Size(342, 116)
        Me.btnBake.TabIndex = 12
        Me.btnBake.Text = "Bake"
        Me.btnBake.UseVisualStyleBackColor = True
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Ambient Temperature"
        Me.ColumnHeader14.Width = 113
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Ambient Humidity"
        Me.ColumnHeader15.Width = 93
        '
        'frmDiaryeMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 611)
        Me.Controls.Add(Me.btnBake)
        Me.Controls.Add(Me.btnDeleteRecipe)
        Me.Controls.Add(Me.lstvRecipes)
        Me.Controls.Add(Me.btnNewRecipe)
        Me.Controls.Add(Me.lblRecipes)
        Me.Controls.Add(Me.lblStarter)
        Me.Controls.Add(Me.btnDeleteStarter)
        Me.Controls.Add(Me.lstvStarters)
        Me.Controls.Add(Me.btnNewStarter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDiaryeMain"
        Me.Text = "Dia-Rye"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNewStarter As Button
    Friend WithEvents lstvStarters As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents btnDeleteStarter As Button
    Friend WithEvents lblStarter As Label
    Friend WithEvents lblRecipes As Label
    Friend WithEvents btnDeleteRecipe As Button
    Friend WithEvents lstvRecipes As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents btnNewRecipe As Button
    Friend WithEvents btnBake As Button
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
End Class
