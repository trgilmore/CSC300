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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiaryeMain))
        Me.btnNewStarter = New System.Windows.Forms.Button()
        Me.btnViewStarters = New System.Windows.Forms.Button()
        Me.lblStarter = New System.Windows.Forms.Label()
        Me.lblRecipes = New System.Windows.Forms.Label()
        Me.btnViewRecipes = New System.Windows.Forms.Button()
        Me.btnNewRecipe = New System.Windows.Forms.Button()
        Me.btnBake = New System.Windows.Forms.Button()
        Me.btnViewLog = New System.Windows.Forms.Button()
        Me.lstStarterNames = New System.Windows.Forms.ListBox()
        Me.lstRecipeTitles = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnNewStarter
        '
        Me.btnNewStarter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewStarter.Location = New System.Drawing.Point(173, 65)
        Me.btnNewStarter.Name = "btnNewStarter"
        Me.btnNewStarter.Size = New System.Drawing.Size(130, 132)
        Me.btnNewStarter.TabIndex = 0
        Me.btnNewStarter.Text = "+" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "New Starter"
        Me.btnNewStarter.UseVisualStyleBackColor = True
        '
        'btnViewStarters
        '
        Me.btnViewStarters.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewStarters.Location = New System.Drawing.Point(551, 65)
        Me.btnViewStarters.Name = "btnViewStarters"
        Me.btnViewStarters.Size = New System.Drawing.Size(130, 132)
        Me.btnViewStarters.TabIndex = 3
        Me.btnViewStarters.Text = "View" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Starters"
        Me.btnViewStarters.UseVisualStyleBackColor = True
        '
        'lblStarter
        '
        Me.lblStarter.AutoSize = True
        Me.lblStarter.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStarter.Location = New System.Drawing.Point(373, 9)
        Me.lblStarter.Name = "lblStarter"
        Me.lblStarter.Size = New System.Drawing.Size(104, 29)
        Me.lblStarter.TabIndex = 5
        Me.lblStarter.Text = "Starters"
        '
        'lblRecipes
        '
        Me.lblRecipes.AutoSize = True
        Me.lblRecipes.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecipes.Location = New System.Drawing.Point(373, 220)
        Me.lblRecipes.Name = "lblRecipes"
        Me.lblRecipes.Size = New System.Drawing.Size(109, 29)
        Me.lblRecipes.TabIndex = 6
        Me.lblRecipes.Text = "Recipes"
        '
        'btnViewRecipes
        '
        Me.btnViewRecipes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewRecipes.Location = New System.Drawing.Point(552, 263)
        Me.btnViewRecipes.Name = "btnViewRecipes"
        Me.btnViewRecipes.Size = New System.Drawing.Size(130, 132)
        Me.btnViewRecipes.TabIndex = 10
        Me.btnViewRecipes.Text = "View" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Recipes"
        Me.btnViewRecipes.UseVisualStyleBackColor = True
        '
        'btnNewRecipe
        '
        Me.btnNewRecipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRecipe.Location = New System.Drawing.Point(175, 263)
        Me.btnNewRecipe.Name = "btnNewRecipe"
        Me.btnNewRecipe.Size = New System.Drawing.Size(130, 132)
        Me.btnNewRecipe.TabIndex = 7
        Me.btnNewRecipe.Text = "+" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "New Recipe"
        Me.btnNewRecipe.UseVisualStyleBackColor = True
        '
        'btnBake
        '
        Me.btnBake.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBake.Location = New System.Drawing.Point(83, 459)
        Me.btnBake.Name = "btnBake"
        Me.btnBake.Size = New System.Drawing.Size(342, 116)
        Me.btnBake.TabIndex = 12
        Me.btnBake.Text = "Bake"
        Me.btnBake.UseVisualStyleBackColor = True
        '
        'btnViewLog
        '
        Me.btnViewLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewLog.Location = New System.Drawing.Point(431, 459)
        Me.btnViewLog.Name = "btnViewLog"
        Me.btnViewLog.Size = New System.Drawing.Size(342, 116)
        Me.btnViewLog.TabIndex = 13
        Me.btnViewLog.Text = "View Bake Log"
        Me.btnViewLog.UseVisualStyleBackColor = True
        '
        'lstStarterNames
        '
        Me.lstStarterNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStarterNames.FormattingEnabled = True
        Me.lstStarterNames.ItemHeight = 16
        Me.lstStarterNames.Location = New System.Drawing.Point(368, 65)
        Me.lstStarterNames.Name = "lstStarterNames"
        Me.lstStarterNames.Size = New System.Drawing.Size(118, 132)
        Me.lstStarterNames.TabIndex = 14
        '
        'lstRecipeTitles
        '
        Me.lstRecipeTitles.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRecipeTitles.FormattingEnabled = True
        Me.lstRecipeTitles.ItemHeight = 16
        Me.lstRecipeTitles.Location = New System.Drawing.Point(370, 263)
        Me.lstRecipeTitles.Name = "lstRecipeTitles"
        Me.lstRecipeTitles.Size = New System.Drawing.Size(118, 132)
        Me.lstRecipeTitles.TabIndex = 15
        '
        'frmDiaryeMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 611)
        Me.Controls.Add(Me.lstRecipeTitles)
        Me.Controls.Add(Me.lstStarterNames)
        Me.Controls.Add(Me.btnViewLog)
        Me.Controls.Add(Me.btnBake)
        Me.Controls.Add(Me.btnViewRecipes)
        Me.Controls.Add(Me.btnNewRecipe)
        Me.Controls.Add(Me.lblRecipes)
        Me.Controls.Add(Me.lblStarter)
        Me.Controls.Add(Me.btnViewStarters)
        Me.Controls.Add(Me.btnNewStarter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDiaryeMain"
        Me.Text = "Dia-Rye"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNewStarter As Button
    Friend WithEvents btnViewStarters As Button
    Friend WithEvents lblStarter As Label
    Friend WithEvents lblRecipes As Label
    Friend WithEvents btnViewRecipes As Button
    Friend WithEvents btnNewRecipe As Button
    Friend WithEvents btnBake As Button
    Friend WithEvents btnViewLog As Button
    Friend WithEvents lstStarterNames As ListBox
    Friend WithEvents lstRecipeTitles As ListBox
End Class
