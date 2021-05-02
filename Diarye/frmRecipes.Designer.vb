<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecipes
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
        Me.lblRecipeTitle = New System.Windows.Forms.Label()
        Me.txtRecipeTitle = New System.Windows.Forms.TextBox()
        Me.lblRecipeFlour = New System.Windows.Forms.Label()
        Me.lstRecipeFlours = New System.Windows.Forms.ListBox()
        Me.btnAddFlourToRecipe = New System.Windows.Forms.Button()
        Me.lblRecipeFlourWeight = New System.Windows.Forms.Label()
        Me.nudRecipeFlourWeight = New System.Windows.Forms.NumericUpDown()
        Me.nudRecipeSaltWeight = New System.Windows.Forms.NumericUpDown()
        Me.lblRecipeSaltWeight = New System.Windows.Forms.Label()
        Me.nudRecipeWaterWeight = New System.Windows.Forms.NumericUpDown()
        Me.lblRecipeWaterWeight = New System.Windows.Forms.Label()
        Me.lstRecipeLevain = New System.Windows.Forms.ListBox()
        Me.lblRecipeLevain = New System.Windows.Forms.Label()
        Me.nudRecipeLevainWeight = New System.Windows.Forms.NumericUpDown()
        Me.lblRecipeLevainWeight = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtRecipeLevainPercent = New System.Windows.Forms.TextBox()
        Me.txtRecipeHydration = New System.Windows.Forms.TextBox()
        Me.txtRecipeTotalFlourWeight = New System.Windows.Forms.TextBox()
        Me.txtRecipeTotalDoughWeight = New System.Windows.Forms.TextBox()
        Me.lblRecipeLevainPercent = New System.Windows.Forms.Label()
        Me.lblRecipeHydration = New System.Windows.Forms.Label()
        Me.lblRecipeTotalFlourWeight = New System.Windows.Forms.Label()
        Me.lblRecipeTotalDoughWeight = New System.Windows.Forms.Label()
        Me.lblRecipeAdditions = New System.Windows.Forms.Label()
        Me.txtRecipeAddition1 = New System.Windows.Forms.TextBox()
        Me.txtRecipeAddition2 = New System.Windows.Forms.TextBox()
        Me.txtRecipeAddition3 = New System.Windows.Forms.TextBox()
        Me.txtRecipeAddition4 = New System.Windows.Forms.TextBox()
        Me.nudRecipeAdditionWeight1 = New System.Windows.Forms.NumericUpDown()
        Me.lblRecipeAddition1Weight = New System.Windows.Forms.Label()
        Me.lblRecipeAddition2Weight = New System.Windows.Forms.Label()
        Me.nudRecipeAdditionWeight2 = New System.Windows.Forms.NumericUpDown()
        Me.lblRecipeAddition3Weight = New System.Windows.Forms.Label()
        Me.nudRecipeAdditionWeight3 = New System.Windows.Forms.NumericUpDown()
        Me.lblRecipeAddition4Weight = New System.Windows.Forms.Label()
        Me.nudRecipeAdditionWeight4 = New System.Windows.Forms.NumericUpDown()
        Me.chkRecipeAddition1 = New System.Windows.Forms.CheckBox()
        Me.chkRecipeAddition2 = New System.Windows.Forms.CheckBox()
        Me.chkRecipeAddition3 = New System.Windows.Forms.CheckBox()
        Me.chkRecipeAddition4 = New System.Windows.Forms.CheckBox()
        Me.btnRecipeSave = New System.Windows.Forms.Button()
        Me.btnRecipeClear = New System.Windows.Forms.Button()
        Me.btnRecipeCancel = New System.Windows.Forms.Button()
        Me.lstFlourRecipe = New System.Windows.Forms.ListBox()
        Me.lblFlourRecipe = New System.Windows.Forms.Label()
        CType(Me.nudRecipeFlourWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRecipeSaltWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRecipeWaterWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRecipeLevainWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.nudRecipeAdditionWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRecipeAdditionWeight2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRecipeAdditionWeight3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRecipeAdditionWeight4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRecipeTitle
        '
        Me.lblRecipeTitle.AutoSize = True
        Me.lblRecipeTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecipeTitle.Location = New System.Drawing.Point(8, 20)
        Me.lblRecipeTitle.Name = "lblRecipeTitle"
        Me.lblRecipeTitle.Size = New System.Drawing.Size(100, 20)
        Me.lblRecipeTitle.TabIndex = 5
        Me.lblRecipeTitle.Text = "Recipe Title: "
        '
        'txtRecipeTitle
        '
        Me.txtRecipeTitle.Location = New System.Drawing.Point(11, 43)
        Me.txtRecipeTitle.Name = "txtRecipeTitle"
        Me.txtRecipeTitle.Size = New System.Drawing.Size(123, 20)
        Me.txtRecipeTitle.TabIndex = 6
        '
        'lblRecipeFlour
        '
        Me.lblRecipeFlour.AutoSize = True
        Me.lblRecipeFlour.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecipeFlour.Location = New System.Drawing.Point(12, 92)
        Me.lblRecipeFlour.Name = "lblRecipeFlour"
        Me.lblRecipeFlour.Size = New System.Drawing.Size(38, 16)
        Me.lblRecipeFlour.TabIndex = 7
        Me.lblRecipeFlour.Text = "Flour"
        '
        'lstRecipeFlours
        '
        Me.lstRecipeFlours.FormattingEnabled = True
        Me.lstRecipeFlours.Location = New System.Drawing.Point(11, 108)
        Me.lstRecipeFlours.Name = "lstRecipeFlours"
        Me.lstRecipeFlours.Size = New System.Drawing.Size(122, 108)
        Me.lstRecipeFlours.TabIndex = 8
        '
        'btnAddFlourToRecipe
        '
        Me.btnAddFlourToRecipe.Location = New System.Drawing.Point(139, 153)
        Me.btnAddFlourToRecipe.Name = "btnAddFlourToRecipe"
        Me.btnAddFlourToRecipe.Size = New System.Drawing.Size(58, 64)
        Me.btnAddFlourToRecipe.TabIndex = 10
        Me.btnAddFlourToRecipe.Text = "Add Flour To Recipe"
        Me.btnAddFlourToRecipe.UseVisualStyleBackColor = True
        '
        'lblRecipeFlourWeight
        '
        Me.lblRecipeFlourWeight.AutoSize = True
        Me.lblRecipeFlourWeight.Location = New System.Drawing.Point(144, 108)
        Me.lblRecipeFlourWeight.Name = "lblRecipeFlourWeight"
        Me.lblRecipeFlourWeight.Size = New System.Drawing.Size(53, 13)
        Me.lblRecipeFlourWeight.TabIndex = 12
        Me.lblRecipeFlourWeight.Text = "Weight(g)"
        '
        'nudRecipeFlourWeight
        '
        Me.nudRecipeFlourWeight.Location = New System.Drawing.Point(139, 127)
        Me.nudRecipeFlourWeight.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudRecipeFlourWeight.Name = "nudRecipeFlourWeight"
        Me.nudRecipeFlourWeight.Size = New System.Drawing.Size(58, 20)
        Me.nudRecipeFlourWeight.TabIndex = 13
        '
        'nudRecipeSaltWeight
        '
        Me.nudRecipeSaltWeight.Location = New System.Drawing.Point(235, 112)
        Me.nudRecipeSaltWeight.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudRecipeSaltWeight.Name = "nudRecipeSaltWeight"
        Me.nudRecipeSaltWeight.Size = New System.Drawing.Size(58, 20)
        Me.nudRecipeSaltWeight.TabIndex = 15
        '
        'lblRecipeSaltWeight
        '
        Me.lblRecipeSaltWeight.AutoSize = True
        Me.lblRecipeSaltWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecipeSaltWeight.Location = New System.Drawing.Point(232, 92)
        Me.lblRecipeSaltWeight.Name = "lblRecipeSaltWeight"
        Me.lblRecipeSaltWeight.Size = New System.Drawing.Size(50, 17)
        Me.lblRecipeSaltWeight.TabIndex = 14
        Me.lblRecipeSaltWeight.Text = "Salt(g)"
        '
        'nudRecipeWaterWeight
        '
        Me.nudRecipeWaterWeight.Location = New System.Drawing.Point(231, 173)
        Me.nudRecipeWaterWeight.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudRecipeWaterWeight.Name = "nudRecipeWaterWeight"
        Me.nudRecipeWaterWeight.Size = New System.Drawing.Size(58, 20)
        Me.nudRecipeWaterWeight.TabIndex = 17
        '
        'lblRecipeWaterWeight
        '
        Me.lblRecipeWaterWeight.AutoSize = True
        Me.lblRecipeWaterWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecipeWaterWeight.Location = New System.Drawing.Point(229, 153)
        Me.lblRecipeWaterWeight.Name = "lblRecipeWaterWeight"
        Me.lblRecipeWaterWeight.Size = New System.Drawing.Size(64, 17)
        Me.lblRecipeWaterWeight.TabIndex = 16
        Me.lblRecipeWaterWeight.Text = "Water(g)"
        '
        'lstRecipeLevain
        '
        Me.lstRecipeLevain.FormattingEnabled = True
        Me.lstRecipeLevain.Location = New System.Drawing.Point(320, 109)
        Me.lstRecipeLevain.Name = "lstRecipeLevain"
        Me.lstRecipeLevain.Size = New System.Drawing.Size(120, 95)
        Me.lstRecipeLevain.TabIndex = 18
        '
        'lblRecipeLevain
        '
        Me.lblRecipeLevain.AutoSize = True
        Me.lblRecipeLevain.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecipeLevain.Location = New System.Drawing.Point(317, 92)
        Me.lblRecipeLevain.Name = "lblRecipeLevain"
        Me.lblRecipeLevain.Size = New System.Drawing.Size(50, 17)
        Me.lblRecipeLevain.TabIndex = 19
        Me.lblRecipeLevain.Text = "Levain"
        '
        'nudRecipeLevainWeight
        '
        Me.nudRecipeLevainWeight.Location = New System.Drawing.Point(382, 207)
        Me.nudRecipeLevainWeight.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudRecipeLevainWeight.Name = "nudRecipeLevainWeight"
        Me.nudRecipeLevainWeight.Size = New System.Drawing.Size(58, 20)
        Me.nudRecipeLevainWeight.TabIndex = 21
        '
        'lblRecipeLevainWeight
        '
        Me.lblRecipeLevainWeight.AutoSize = True
        Me.lblRecipeLevainWeight.Location = New System.Drawing.Point(317, 209)
        Me.lblRecipeLevainWeight.Name = "lblRecipeLevainWeight"
        Me.lblRecipeLevainWeight.Size = New System.Drawing.Size(53, 13)
        Me.lblRecipeLevainWeight.TabIndex = 20
        Me.lblRecipeLevainWeight.Text = "Weight(g)"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtRecipeLevainPercent)
        Me.Panel1.Controls.Add(Me.txtRecipeHydration)
        Me.Panel1.Controls.Add(Me.txtRecipeTotalFlourWeight)
        Me.Panel1.Controls.Add(Me.txtRecipeTotalDoughWeight)
        Me.Panel1.Controls.Add(Me.lblRecipeLevainPercent)
        Me.Panel1.Controls.Add(Me.lblRecipeHydration)
        Me.Panel1.Controls.Add(Me.lblRecipeTotalFlourWeight)
        Me.Panel1.Controls.Add(Me.lblRecipeTotalDoughWeight)
        Me.Panel1.Location = New System.Drawing.Point(0, 292)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(799, 121)
        Me.Panel1.TabIndex = 22
        '
        'txtRecipeLevainPercent
        '
        Me.txtRecipeLevainPercent.Enabled = False
        Me.txtRecipeLevainPercent.Location = New System.Drawing.Point(628, 48)
        Me.txtRecipeLevainPercent.Name = "txtRecipeLevainPercent"
        Me.txtRecipeLevainPercent.Size = New System.Drawing.Size(76, 20)
        Me.txtRecipeLevainPercent.TabIndex = 7
        '
        'txtRecipeHydration
        '
        Me.txtRecipeHydration.Enabled = False
        Me.txtRecipeHydration.Location = New System.Drawing.Point(474, 47)
        Me.txtRecipeHydration.Name = "txtRecipeHydration"
        Me.txtRecipeHydration.Size = New System.Drawing.Size(49, 20)
        Me.txtRecipeHydration.TabIndex = 6
        '
        'txtRecipeTotalFlourWeight
        '
        Me.txtRecipeTotalFlourWeight.Enabled = False
        Me.txtRecipeTotalFlourWeight.Location = New System.Drawing.Point(278, 47)
        Me.txtRecipeTotalFlourWeight.Name = "txtRecipeTotalFlourWeight"
        Me.txtRecipeTotalFlourWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtRecipeTotalFlourWeight.TabIndex = 5
        '
        'txtRecipeTotalDoughWeight
        '
        Me.txtRecipeTotalDoughWeight.Enabled = False
        Me.txtRecipeTotalDoughWeight.Location = New System.Drawing.Point(74, 48)
        Me.txtRecipeTotalDoughWeight.Name = "txtRecipeTotalDoughWeight"
        Me.txtRecipeTotalDoughWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtRecipeTotalDoughWeight.TabIndex = 4
        '
        'lblRecipeLevainPercent
        '
        Me.lblRecipeLevainPercent.AutoSize = True
        Me.lblRecipeLevainPercent.Location = New System.Drawing.Point(625, 31)
        Me.lblRecipeLevainPercent.Name = "lblRecipeLevainPercent"
        Me.lblRecipeLevainPercent.Size = New System.Drawing.Size(79, 13)
        Me.lblRecipeLevainPercent.TabIndex = 3
        Me.lblRecipeLevainPercent.Text = "Levain Percent"
        '
        'lblRecipeHydration
        '
        Me.lblRecipeHydration.AutoSize = True
        Me.lblRecipeHydration.Location = New System.Drawing.Point(471, 31)
        Me.lblRecipeHydration.Name = "lblRecipeHydration"
        Me.lblRecipeHydration.Size = New System.Drawing.Size(52, 13)
        Me.lblRecipeHydration.TabIndex = 2
        Me.lblRecipeHydration.Text = "Hydration"
        '
        'lblRecipeTotalFlourWeight
        '
        Me.lblRecipeTotalFlourWeight.AutoSize = True
        Me.lblRecipeTotalFlourWeight.Location = New System.Drawing.Point(275, 31)
        Me.lblRecipeTotalFlourWeight.Name = "lblRecipeTotalFlourWeight"
        Me.lblRecipeTotalFlourWeight.Size = New System.Drawing.Size(94, 13)
        Me.lblRecipeTotalFlourWeight.TabIndex = 1
        Me.lblRecipeTotalFlourWeight.Text = "Total Flour Weight"
        '
        'lblRecipeTotalDoughWeight
        '
        Me.lblRecipeTotalDoughWeight.AutoSize = True
        Me.lblRecipeTotalDoughWeight.Location = New System.Drawing.Point(71, 32)
        Me.lblRecipeTotalDoughWeight.Name = "lblRecipeTotalDoughWeight"
        Me.lblRecipeTotalDoughWeight.Size = New System.Drawing.Size(103, 13)
        Me.lblRecipeTotalDoughWeight.TabIndex = 0
        Me.lblRecipeTotalDoughWeight.Text = "Total Dough Weight"
        '
        'lblRecipeAdditions
        '
        Me.lblRecipeAdditions.AutoSize = True
        Me.lblRecipeAdditions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecipeAdditions.Location = New System.Drawing.Point(473, 91)
        Me.lblRecipeAdditions.Name = "lblRecipeAdditions"
        Me.lblRecipeAdditions.Size = New System.Drawing.Size(66, 17)
        Me.lblRecipeAdditions.TabIndex = 23
        Me.lblRecipeAdditions.Text = "Additions"
        '
        'txtRecipeAddition1
        '
        Me.txtRecipeAddition1.Enabled = False
        Me.txtRecipeAddition1.Location = New System.Drawing.Point(474, 146)
        Me.txtRecipeAddition1.Name = "txtRecipeAddition1"
        Me.txtRecipeAddition1.Size = New System.Drawing.Size(114, 20)
        Me.txtRecipeAddition1.TabIndex = 28
        '
        'txtRecipeAddition2
        '
        Me.txtRecipeAddition2.Enabled = False
        Me.txtRecipeAddition2.Location = New System.Drawing.Point(474, 223)
        Me.txtRecipeAddition2.Name = "txtRecipeAddition2"
        Me.txtRecipeAddition2.Size = New System.Drawing.Size(114, 20)
        Me.txtRecipeAddition2.TabIndex = 29
        '
        'txtRecipeAddition3
        '
        Me.txtRecipeAddition3.Enabled = False
        Me.txtRecipeAddition3.Location = New System.Drawing.Point(608, 146)
        Me.txtRecipeAddition3.Name = "txtRecipeAddition3"
        Me.txtRecipeAddition3.Size = New System.Drawing.Size(116, 20)
        Me.txtRecipeAddition3.TabIndex = 30
        '
        'txtRecipeAddition4
        '
        Me.txtRecipeAddition4.Enabled = False
        Me.txtRecipeAddition4.Location = New System.Drawing.Point(608, 223)
        Me.txtRecipeAddition4.Name = "txtRecipeAddition4"
        Me.txtRecipeAddition4.Size = New System.Drawing.Size(116, 20)
        Me.txtRecipeAddition4.TabIndex = 31
        '
        'nudRecipeAdditionWeight1
        '
        Me.nudRecipeAdditionWeight1.Enabled = False
        Me.nudRecipeAdditionWeight1.Location = New System.Drawing.Point(530, 172)
        Me.nudRecipeAdditionWeight1.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudRecipeAdditionWeight1.Name = "nudRecipeAdditionWeight1"
        Me.nudRecipeAdditionWeight1.Size = New System.Drawing.Size(58, 20)
        Me.nudRecipeAdditionWeight1.TabIndex = 32
        '
        'lblRecipeAddition1Weight
        '
        Me.lblRecipeAddition1Weight.AutoSize = True
        Me.lblRecipeAddition1Weight.Enabled = False
        Me.lblRecipeAddition1Weight.Location = New System.Drawing.Point(471, 174)
        Me.lblRecipeAddition1Weight.Name = "lblRecipeAddition1Weight"
        Me.lblRecipeAddition1Weight.Size = New System.Drawing.Size(53, 13)
        Me.lblRecipeAddition1Weight.TabIndex = 33
        Me.lblRecipeAddition1Weight.Text = "Weight(g)"
        '
        'lblRecipeAddition2Weight
        '
        Me.lblRecipeAddition2Weight.AutoSize = True
        Me.lblRecipeAddition2Weight.Enabled = False
        Me.lblRecipeAddition2Weight.Location = New System.Drawing.Point(471, 250)
        Me.lblRecipeAddition2Weight.Name = "lblRecipeAddition2Weight"
        Me.lblRecipeAddition2Weight.Size = New System.Drawing.Size(53, 13)
        Me.lblRecipeAddition2Weight.TabIndex = 35
        Me.lblRecipeAddition2Weight.Text = "Weight(g)"
        '
        'nudRecipeAdditionWeight2
        '
        Me.nudRecipeAdditionWeight2.Enabled = False
        Me.nudRecipeAdditionWeight2.Location = New System.Drawing.Point(530, 248)
        Me.nudRecipeAdditionWeight2.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudRecipeAdditionWeight2.Name = "nudRecipeAdditionWeight2"
        Me.nudRecipeAdditionWeight2.Size = New System.Drawing.Size(58, 20)
        Me.nudRecipeAdditionWeight2.TabIndex = 34
        '
        'lblRecipeAddition3Weight
        '
        Me.lblRecipeAddition3Weight.AutoSize = True
        Me.lblRecipeAddition3Weight.Enabled = False
        Me.lblRecipeAddition3Weight.Location = New System.Drawing.Point(605, 174)
        Me.lblRecipeAddition3Weight.Name = "lblRecipeAddition3Weight"
        Me.lblRecipeAddition3Weight.Size = New System.Drawing.Size(53, 13)
        Me.lblRecipeAddition3Weight.TabIndex = 37
        Me.lblRecipeAddition3Weight.Text = "Weight(g)"
        '
        'nudRecipeAdditionWeight3
        '
        Me.nudRecipeAdditionWeight3.Enabled = False
        Me.nudRecipeAdditionWeight3.Location = New System.Drawing.Point(666, 172)
        Me.nudRecipeAdditionWeight3.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudRecipeAdditionWeight3.Name = "nudRecipeAdditionWeight3"
        Me.nudRecipeAdditionWeight3.Size = New System.Drawing.Size(58, 20)
        Me.nudRecipeAdditionWeight3.TabIndex = 36
        '
        'lblRecipeAddition4Weight
        '
        Me.lblRecipeAddition4Weight.AutoSize = True
        Me.lblRecipeAddition4Weight.Enabled = False
        Me.lblRecipeAddition4Weight.Location = New System.Drawing.Point(605, 252)
        Me.lblRecipeAddition4Weight.Name = "lblRecipeAddition4Weight"
        Me.lblRecipeAddition4Weight.Size = New System.Drawing.Size(53, 13)
        Me.lblRecipeAddition4Weight.TabIndex = 39
        Me.lblRecipeAddition4Weight.Text = "Weight(g)"
        '
        'nudRecipeAdditionWeight4
        '
        Me.nudRecipeAdditionWeight4.Enabled = False
        Me.nudRecipeAdditionWeight4.Location = New System.Drawing.Point(666, 250)
        Me.nudRecipeAdditionWeight4.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudRecipeAdditionWeight4.Name = "nudRecipeAdditionWeight4"
        Me.nudRecipeAdditionWeight4.Size = New System.Drawing.Size(58, 20)
        Me.nudRecipeAdditionWeight4.TabIndex = 38
        '
        'chkRecipeAddition1
        '
        Me.chkRecipeAddition1.AutoSize = True
        Me.chkRecipeAddition1.Location = New System.Drawing.Point(476, 123)
        Me.chkRecipeAddition1.Name = "chkRecipeAddition1"
        Me.chkRecipeAddition1.Size = New System.Drawing.Size(73, 17)
        Me.chkRecipeAddition1.TabIndex = 40
        Me.chkRecipeAddition1.Text = "Addition 1"
        Me.chkRecipeAddition1.UseVisualStyleBackColor = True
        '
        'chkRecipeAddition2
        '
        Me.chkRecipeAddition2.AutoSize = True
        Me.chkRecipeAddition2.Location = New System.Drawing.Point(474, 200)
        Me.chkRecipeAddition2.Name = "chkRecipeAddition2"
        Me.chkRecipeAddition2.Size = New System.Drawing.Size(73, 17)
        Me.chkRecipeAddition2.TabIndex = 41
        Me.chkRecipeAddition2.Text = "Addition 2"
        Me.chkRecipeAddition2.UseVisualStyleBackColor = True
        '
        'chkRecipeAddition3
        '
        Me.chkRecipeAddition3.AutoSize = True
        Me.chkRecipeAddition3.Location = New System.Drawing.Point(608, 123)
        Me.chkRecipeAddition3.Name = "chkRecipeAddition3"
        Me.chkRecipeAddition3.Size = New System.Drawing.Size(73, 17)
        Me.chkRecipeAddition3.TabIndex = 42
        Me.chkRecipeAddition3.Text = "Addition 3"
        Me.chkRecipeAddition3.UseVisualStyleBackColor = True
        '
        'chkRecipeAddition4
        '
        Me.chkRecipeAddition4.AutoSize = True
        Me.chkRecipeAddition4.Location = New System.Drawing.Point(608, 200)
        Me.chkRecipeAddition4.Name = "chkRecipeAddition4"
        Me.chkRecipeAddition4.Size = New System.Drawing.Size(73, 17)
        Me.chkRecipeAddition4.TabIndex = 43
        Me.chkRecipeAddition4.Text = "Addition 4"
        Me.chkRecipeAddition4.UseVisualStyleBackColor = True
        '
        'btnRecipeSave
        '
        Me.btnRecipeSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecipeSave.Location = New System.Drawing.Point(193, 419)
        Me.btnRecipeSave.Name = "btnRecipeSave"
        Me.btnRecipeSave.Size = New System.Drawing.Size(134, 30)
        Me.btnRecipeSave.TabIndex = 44
        Me.btnRecipeSave.Text = "Save"
        Me.btnRecipeSave.UseVisualStyleBackColor = True
        '
        'btnRecipeClear
        '
        Me.btnRecipeClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecipeClear.Location = New System.Drawing.Point(333, 419)
        Me.btnRecipeClear.Name = "btnRecipeClear"
        Me.btnRecipeClear.Size = New System.Drawing.Size(134, 30)
        Me.btnRecipeClear.TabIndex = 45
        Me.btnRecipeClear.Text = "Clear"
        Me.btnRecipeClear.UseVisualStyleBackColor = True
        '
        'btnRecipeCancel
        '
        Me.btnRecipeCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecipeCancel.Location = New System.Drawing.Point(473, 419)
        Me.btnRecipeCancel.Name = "btnRecipeCancel"
        Me.btnRecipeCancel.Size = New System.Drawing.Size(134, 30)
        Me.btnRecipeCancel.TabIndex = 46
        Me.btnRecipeCancel.Text = "Cancel"
        Me.btnRecipeCancel.UseVisualStyleBackColor = True
        '
        'lstFlourRecipe
        '
        Me.lstFlourRecipe.FormattingEnabled = True
        Me.lstFlourRecipe.Location = New System.Drawing.Point(10, 238)
        Me.lstFlourRecipe.Name = "lstFlourRecipe"
        Me.lstFlourRecipe.Size = New System.Drawing.Size(186, 43)
        Me.lstFlourRecipe.TabIndex = 47
        '
        'lblFlourRecipe
        '
        Me.lblFlourRecipe.AutoSize = True
        Me.lblFlourRecipe.Location = New System.Drawing.Point(12, 222)
        Me.lblFlourRecipe.Name = "lblFlourRecipe"
        Me.lblFlourRecipe.Size = New System.Drawing.Size(67, 13)
        Me.lblFlourRecipe.TabIndex = 48
        Me.lblFlourRecipe.Text = "Flour Recipe"
        '
        'frmRecipes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblFlourRecipe)
        Me.Controls.Add(Me.lstFlourRecipe)
        Me.Controls.Add(Me.btnRecipeCancel)
        Me.Controls.Add(Me.btnRecipeClear)
        Me.Controls.Add(Me.btnRecipeSave)
        Me.Controls.Add(Me.chkRecipeAddition4)
        Me.Controls.Add(Me.chkRecipeAddition3)
        Me.Controls.Add(Me.chkRecipeAddition2)
        Me.Controls.Add(Me.chkRecipeAddition1)
        Me.Controls.Add(Me.lblRecipeAddition4Weight)
        Me.Controls.Add(Me.nudRecipeAdditionWeight4)
        Me.Controls.Add(Me.lblRecipeAddition3Weight)
        Me.Controls.Add(Me.nudRecipeAdditionWeight3)
        Me.Controls.Add(Me.lblRecipeAddition2Weight)
        Me.Controls.Add(Me.nudRecipeAdditionWeight2)
        Me.Controls.Add(Me.lblRecipeAddition1Weight)
        Me.Controls.Add(Me.nudRecipeAdditionWeight1)
        Me.Controls.Add(Me.txtRecipeAddition4)
        Me.Controls.Add(Me.txtRecipeAddition3)
        Me.Controls.Add(Me.txtRecipeAddition2)
        Me.Controls.Add(Me.txtRecipeAddition1)
        Me.Controls.Add(Me.lblRecipeAdditions)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.nudRecipeLevainWeight)
        Me.Controls.Add(Me.lblRecipeLevainWeight)
        Me.Controls.Add(Me.lblRecipeLevain)
        Me.Controls.Add(Me.lstRecipeLevain)
        Me.Controls.Add(Me.nudRecipeWaterWeight)
        Me.Controls.Add(Me.lblRecipeWaterWeight)
        Me.Controls.Add(Me.nudRecipeSaltWeight)
        Me.Controls.Add(Me.lblRecipeSaltWeight)
        Me.Controls.Add(Me.nudRecipeFlourWeight)
        Me.Controls.Add(Me.lblRecipeFlourWeight)
        Me.Controls.Add(Me.btnAddFlourToRecipe)
        Me.Controls.Add(Me.lstRecipeFlours)
        Me.Controls.Add(Me.lblRecipeFlour)
        Me.Controls.Add(Me.txtRecipeTitle)
        Me.Controls.Add(Me.lblRecipeTitle)
        Me.Name = "frmRecipes"
        Me.Text = "frmRecipes"
        CType(Me.nudRecipeFlourWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRecipeSaltWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRecipeWaterWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRecipeLevainWeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudRecipeAdditionWeight1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRecipeAdditionWeight2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRecipeAdditionWeight3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRecipeAdditionWeight4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRecipeTitle As Label
    Friend WithEvents txtRecipeTitle As TextBox
    Friend WithEvents lblRecipeFlour As Label
    Friend WithEvents lstRecipeFlours As ListBox
    Friend WithEvents btnAddFlourToRecipe As Button
    Friend WithEvents lblRecipeFlourWeight As Label
    Friend WithEvents nudRecipeFlourWeight As NumericUpDown
    Friend WithEvents nudRecipeSaltWeight As NumericUpDown
    Friend WithEvents lblRecipeSaltWeight As Label
    Friend WithEvents nudRecipeWaterWeight As NumericUpDown
    Friend WithEvents lblRecipeWaterWeight As Label
    Friend WithEvents lstRecipeLevain As ListBox
    Friend WithEvents lblRecipeLevain As Label
    Friend WithEvents nudRecipeLevainWeight As NumericUpDown
    Friend WithEvents lblRecipeLevainWeight As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblRecipeAdditions As Label
    Friend WithEvents txtRecipeAddition1 As TextBox
    Friend WithEvents txtRecipeAddition2 As TextBox
    Friend WithEvents txtRecipeAddition3 As TextBox
    Friend WithEvents txtRecipeAddition4 As TextBox
    Friend WithEvents nudRecipeAdditionWeight1 As NumericUpDown
    Friend WithEvents lblRecipeAddition1Weight As Label
    Friend WithEvents lblRecipeAddition2Weight As Label
    Friend WithEvents nudRecipeAdditionWeight2 As NumericUpDown
    Friend WithEvents lblRecipeAddition3Weight As Label
    Friend WithEvents nudRecipeAdditionWeight3 As NumericUpDown
    Friend WithEvents lblRecipeAddition4Weight As Label
    Friend WithEvents nudRecipeAdditionWeight4 As NumericUpDown
    Friend WithEvents chkRecipeAddition1 As CheckBox
    Friend WithEvents chkRecipeAddition2 As CheckBox
    Friend WithEvents chkRecipeAddition3 As CheckBox
    Friend WithEvents chkRecipeAddition4 As CheckBox
    Friend WithEvents lblRecipeTotalFlourWeight As Label
    Friend WithEvents lblRecipeTotalDoughWeight As Label
    Friend WithEvents txtRecipeLevainPercent As TextBox
    Friend WithEvents txtRecipeHydration As TextBox
    Friend WithEvents txtRecipeTotalFlourWeight As TextBox
    Friend WithEvents txtRecipeTotalDoughWeight As TextBox
    Friend WithEvents lblRecipeLevainPercent As Label
    Friend WithEvents lblRecipeHydration As Label
    Friend WithEvents btnRecipeSave As Button
    Friend WithEvents btnRecipeClear As Button
    Friend WithEvents btnRecipeCancel As Button
    Friend WithEvents lstFlourRecipe As ListBox
    Friend WithEvents lblFlourRecipe As Label
End Class
