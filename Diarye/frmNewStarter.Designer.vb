<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStarter
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
        Me.txtStarterName = New System.Windows.Forms.TextBox()
        Me.btnSaveStarter = New System.Windows.Forms.Button()
        Me.dtpCreationDate = New System.Windows.Forms.DateTimePicker()
        Me.lblStarterName = New System.Windows.Forms.Label()
        Me.lblCreationDate = New System.Windows.Forms.Label()
        Me.btnClearStarter = New System.Windows.Forms.Button()
        Me.btnCancelStarter = New System.Windows.Forms.Button()
        Me.lblFeedingDetails = New System.Windows.Forms.Label()
        Me.lstStarterRecipeFlour = New System.Windows.Forms.ListBox()
        Me.lblStarterRecipeFlour = New System.Windows.Forms.Label()
        Me.lblStartRecipeFlourPercent = New System.Windows.Forms.Label()
        Me.txtStarterRecipeFlourPercent = New System.Windows.Forms.TextBox()
        Me.lstFeedingRecipe = New System.Windows.Forms.ListBox()
        Me.btnAddToFeedingRecipe = New System.Windows.Forms.Button()
        Me.lblFeedingRecipe = New System.Windows.Forms.Label()
        Me.lblRecipeWeights = New System.Windows.Forms.Label()
        Me.lblRatioSep1 = New System.Windows.Forms.Label()
        Me.lblRatioSep2 = New System.Windows.Forms.Label()
        Me.lblFeedingSchedule = New System.Windows.Forms.Label()
        Me.txtFeedingSchedule = New System.Windows.Forms.TextBox()
        Me.lblRatioSep4 = New System.Windows.Forms.Label()
        Me.lblRatioSep3 = New System.Windows.Forms.Label()
        Me.txtStarterFlourRatio = New System.Windows.Forms.TextBox()
        Me.txtStarterWaterRatio = New System.Windows.Forms.TextBox()
        Me.txtStarterRatio = New System.Windows.Forms.TextBox()
        Me.chkHibernation = New System.Windows.Forms.CheckBox()
        Me.chkAmbTemp = New System.Windows.Forms.CheckBox()
        Me.chkAmbHumidity = New System.Windows.Forms.CheckBox()
        Me.txtAmbTemp = New System.Windows.Forms.TextBox()
        Me.txtAmbHumidity = New System.Windows.Forms.TextBox()
        Me.rbDry = New System.Windows.Forms.RadioButton()
        Me.rbFridge = New System.Windows.Forms.RadioButton()
        Me.rbFreezer = New System.Windows.Forms.RadioButton()
        Me.nudStarterWeight = New System.Windows.Forms.NumericUpDown()
        Me.nudStarterWaterWeight = New System.Windows.Forms.NumericUpDown()
        Me.nudStarterFlourWeight = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudStarterWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStarterWaterWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStarterFlourWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtStarterName
        '
        Me.txtStarterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStarterName.Location = New System.Drawing.Point(157, 36)
        Me.txtStarterName.Name = "txtStarterName"
        Me.txtStarterName.Size = New System.Drawing.Size(133, 26)
        Me.txtStarterName.TabIndex = 0
        '
        'btnSaveStarter
        '
        Me.btnSaveStarter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveStarter.Location = New System.Drawing.Point(123, 337)
        Me.btnSaveStarter.Name = "btnSaveStarter"
        Me.btnSaveStarter.Size = New System.Drawing.Size(134, 30)
        Me.btnSaveStarter.TabIndex = 2
        Me.btnSaveStarter.Text = "Save"
        Me.btnSaveStarter.UseVisualStyleBackColor = True
        '
        'dtpCreationDate
        '
        Me.dtpCreationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCreationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCreationDate.Location = New System.Drawing.Point(525, 37)
        Me.dtpCreationDate.Name = "dtpCreationDate"
        Me.dtpCreationDate.Size = New System.Drawing.Size(103, 26)
        Me.dtpCreationDate.TabIndex = 3
        Me.dtpCreationDate.Value = New Date(2021, 4, 30, 11, 36, 43, 0)
        '
        'lblStarterName
        '
        Me.lblStarterName.AutoSize = True
        Me.lblStarterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStarterName.Location = New System.Drawing.Point(39, 42)
        Me.lblStarterName.Name = "lblStarterName"
        Me.lblStarterName.Size = New System.Drawing.Size(112, 20)
        Me.lblStarterName.TabIndex = 4
        Me.lblStarterName.Text = "Starter Name: "
        '
        'lblCreationDate
        '
        Me.lblCreationDate.AutoSize = True
        Me.lblCreationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreationDate.Location = New System.Drawing.Point(407, 42)
        Me.lblCreationDate.Name = "lblCreationDate"
        Me.lblCreationDate.Size = New System.Drawing.Size(112, 20)
        Me.lblCreationDate.TabIndex = 5
        Me.lblCreationDate.Text = "Creation Date:"
        '
        'btnClearStarter
        '
        Me.btnClearStarter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearStarter.Location = New System.Drawing.Point(263, 337)
        Me.btnClearStarter.Name = "btnClearStarter"
        Me.btnClearStarter.Size = New System.Drawing.Size(134, 30)
        Me.btnClearStarter.TabIndex = 6
        Me.btnClearStarter.Text = "Clear"
        Me.btnClearStarter.UseVisualStyleBackColor = True
        '
        'btnCancelStarter
        '
        Me.btnCancelStarter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelStarter.Location = New System.Drawing.Point(403, 337)
        Me.btnCancelStarter.Name = "btnCancelStarter"
        Me.btnCancelStarter.Size = New System.Drawing.Size(134, 30)
        Me.btnCancelStarter.TabIndex = 7
        Me.btnCancelStarter.Text = "Cancel"
        Me.btnCancelStarter.UseVisualStyleBackColor = True
        '
        'lblFeedingDetails
        '
        Me.lblFeedingDetails.AutoSize = True
        Me.lblFeedingDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedingDetails.Location = New System.Drawing.Point(39, 104)
        Me.lblFeedingDetails.Name = "lblFeedingDetails"
        Me.lblFeedingDetails.Size = New System.Drawing.Size(120, 20)
        Me.lblFeedingDetails.TabIndex = 8
        Me.lblFeedingDetails.Text = "Feeding Details"
        '
        'lstStarterRecipeFlour
        '
        Me.lstStarterRecipeFlour.FormattingEnabled = True
        Me.lstStarterRecipeFlour.Location = New System.Drawing.Point(43, 158)
        Me.lstStarterRecipeFlour.Name = "lstStarterRecipeFlour"
        Me.lstStarterRecipeFlour.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstStarterRecipeFlour.Size = New System.Drawing.Size(97, 56)
        Me.lstStarterRecipeFlour.TabIndex = 9
        '
        'lblStarterRecipeFlour
        '
        Me.lblStarterRecipeFlour.AutoSize = True
        Me.lblStarterRecipeFlour.Location = New System.Drawing.Point(50, 142)
        Me.lblStarterRecipeFlour.Name = "lblStarterRecipeFlour"
        Me.lblStarterRecipeFlour.Size = New System.Drawing.Size(30, 13)
        Me.lblStarterRecipeFlour.TabIndex = 10
        Me.lblStarterRecipeFlour.Text = "Flour"
        '
        'lblStartRecipeFlourPercent
        '
        Me.lblStartRecipeFlourPercent.AutoSize = True
        Me.lblStartRecipeFlourPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartRecipeFlourPercent.Location = New System.Drawing.Point(153, 137)
        Me.lblStartRecipeFlourPercent.Name = "lblStartRecipeFlourPercent"
        Me.lblStartRecipeFlourPercent.Size = New System.Drawing.Size(23, 20)
        Me.lblStartRecipeFlourPercent.TabIndex = 11
        Me.lblStartRecipeFlourPercent.Text = "%"
        '
        'txtStarterRecipeFlourPercent
        '
        Me.txtStarterRecipeFlourPercent.Location = New System.Drawing.Point(146, 158)
        Me.txtStarterRecipeFlourPercent.Name = "txtStarterRecipeFlourPercent"
        Me.txtStarterRecipeFlourPercent.Size = New System.Drawing.Size(41, 20)
        Me.txtStarterRecipeFlourPercent.TabIndex = 12
        Me.txtStarterRecipeFlourPercent.Text = "100"
        '
        'lstFeedingRecipe
        '
        Me.lstFeedingRecipe.FormattingEnabled = True
        Me.lstFeedingRecipe.Location = New System.Drawing.Point(43, 242)
        Me.lstFeedingRecipe.Name = "lstFeedingRecipe"
        Me.lstFeedingRecipe.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstFeedingRecipe.Size = New System.Drawing.Size(144, 69)
        Me.lstFeedingRecipe.TabIndex = 13
        '
        'btnAddToFeedingRecipe
        '
        Me.btnAddToFeedingRecipe.Location = New System.Drawing.Point(146, 184)
        Me.btnAddToFeedingRecipe.Name = "btnAddToFeedingRecipe"
        Me.btnAddToFeedingRecipe.Size = New System.Drawing.Size(41, 30)
        Me.btnAddToFeedingRecipe.TabIndex = 14
        Me.btnAddToFeedingRecipe.Text = "Add"
        Me.btnAddToFeedingRecipe.UseVisualStyleBackColor = True
        '
        'lblFeedingRecipe
        '
        Me.lblFeedingRecipe.AutoSize = True
        Me.lblFeedingRecipe.Location = New System.Drawing.Point(77, 226)
        Me.lblFeedingRecipe.Name = "lblFeedingRecipe"
        Me.lblFeedingRecipe.Size = New System.Drawing.Size(82, 13)
        Me.lblFeedingRecipe.TabIndex = 15
        Me.lblFeedingRecipe.Text = "Feeding Recipe"
        '
        'lblRecipeWeights
        '
        Me.lblRecipeWeights.AutoSize = True
        Me.lblRecipeWeights.Location = New System.Drawing.Point(242, 128)
        Me.lblRecipeWeights.Name = "lblRecipeWeights"
        Me.lblRecipeWeights.Size = New System.Drawing.Size(114, 26)
        Me.lblRecipeWeights.TabIndex = 16
        Me.lblRecipeWeights.Text = "Weight in grams" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Starter : Water : Flour)"
        Me.lblRecipeWeights.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRatioSep1
        '
        Me.lblRatioSep1.AutoSize = True
        Me.lblRatioSep1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRatioSep1.Location = New System.Drawing.Point(260, 175)
        Me.lblRatioSep1.Name = "lblRatioSep1"
        Me.lblRatioSep1.Size = New System.Drawing.Size(14, 20)
        Me.lblRatioSep1.TabIndex = 20
        Me.lblRatioSep1.Text = ":"
        '
        'lblRatioSep2
        '
        Me.lblRatioSep2.AutoSize = True
        Me.lblRatioSep2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRatioSep2.Location = New System.Drawing.Point(319, 175)
        Me.lblRatioSep2.Name = "lblRatioSep2"
        Me.lblRatioSep2.Size = New System.Drawing.Size(14, 20)
        Me.lblRatioSep2.TabIndex = 21
        Me.lblRatioSep2.Text = ":"
        '
        'lblFeedingSchedule
        '
        Me.lblFeedingSchedule.AutoSize = True
        Me.lblFeedingSchedule.Location = New System.Drawing.Point(223, 242)
        Me.lblFeedingSchedule.Name = "lblFeedingSchedule"
        Me.lblFeedingSchedule.Size = New System.Drawing.Size(121, 13)
        Me.lblFeedingSchedule.TabIndex = 24
        Me.lblFeedingSchedule.Text = "Hours Between Feeding"
        '
        'txtFeedingSchedule
        '
        Me.txtFeedingSchedule.Location = New System.Drawing.Point(226, 265)
        Me.txtFeedingSchedule.Name = "txtFeedingSchedule"
        Me.txtFeedingSchedule.Size = New System.Drawing.Size(35, 20)
        Me.txtFeedingSchedule.TabIndex = 25
        Me.txtFeedingSchedule.Text = "0"
        '
        'lblRatioSep4
        '
        Me.lblRatioSep4.AutoSize = True
        Me.lblRatioSep4.Enabled = False
        Me.lblRatioSep4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRatioSep4.Location = New System.Drawing.Point(319, 201)
        Me.lblRatioSep4.Name = "lblRatioSep4"
        Me.lblRatioSep4.Size = New System.Drawing.Size(14, 20)
        Me.lblRatioSep4.TabIndex = 32
        Me.lblRatioSep4.Text = ":"
        '
        'lblRatioSep3
        '
        Me.lblRatioSep3.AutoSize = True
        Me.lblRatioSep3.Enabled = False
        Me.lblRatioSep3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRatioSep3.Location = New System.Drawing.Point(260, 201)
        Me.lblRatioSep3.Name = "lblRatioSep3"
        Me.lblRatioSep3.Size = New System.Drawing.Size(14, 20)
        Me.lblRatioSep3.TabIndex = 31
        Me.lblRatioSep3.Text = ":"
        '
        'txtStarterFlourRatio
        '
        Me.txtStarterFlourRatio.Enabled = False
        Me.txtStarterFlourRatio.Location = New System.Drawing.Point(333, 201)
        Me.txtStarterFlourRatio.Name = "txtStarterFlourRatio"
        Me.txtStarterFlourRatio.Size = New System.Drawing.Size(44, 20)
        Me.txtStarterFlourRatio.TabIndex = 30
        Me.txtStarterFlourRatio.Text = "1"
        Me.txtStarterFlourRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStarterWaterRatio
        '
        Me.txtStarterWaterRatio.Enabled = False
        Me.txtStarterWaterRatio.Location = New System.Drawing.Point(274, 201)
        Me.txtStarterWaterRatio.Name = "txtStarterWaterRatio"
        Me.txtStarterWaterRatio.Size = New System.Drawing.Size(44, 20)
        Me.txtStarterWaterRatio.TabIndex = 29
        Me.txtStarterWaterRatio.Text = "1"
        Me.txtStarterWaterRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStarterRatio
        '
        Me.txtStarterRatio.Enabled = False
        Me.txtStarterRatio.Location = New System.Drawing.Point(215, 201)
        Me.txtStarterRatio.Name = "txtStarterRatio"
        Me.txtStarterRatio.Size = New System.Drawing.Size(44, 20)
        Me.txtStarterRatio.TabIndex = 28
        Me.txtStarterRatio.Text = "1"
        Me.txtStarterRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkHibernation
        '
        Me.chkHibernation.AutoSize = True
        Me.chkHibernation.Location = New System.Drawing.Point(417, 137)
        Me.chkHibernation.Name = "chkHibernation"
        Me.chkHibernation.Size = New System.Drawing.Size(92, 17)
        Me.chkHibernation.TabIndex = 33
        Me.chkHibernation.Text = "In Hibernation"
        Me.chkHibernation.UseVisualStyleBackColor = True
        '
        'chkAmbTemp
        '
        Me.chkAmbTemp.AutoSize = True
        Me.chkAmbTemp.Location = New System.Drawing.Point(417, 197)
        Me.chkAmbTemp.Name = "chkAmbTemp"
        Me.chkAmbTemp.Size = New System.Drawing.Size(146, 17)
        Me.chkAmbTemp.TabIndex = 34
        Me.chkAmbTemp.Text = "Ambient Temperature (F°)"
        Me.chkAmbTemp.UseVisualStyleBackColor = True
        '
        'chkAmbHumidity
        '
        Me.chkAmbHumidity.AutoSize = True
        Me.chkAmbHumidity.Location = New System.Drawing.Point(417, 242)
        Me.chkAmbHumidity.Name = "chkAmbHumidity"
        Me.chkAmbHumidity.Size = New System.Drawing.Size(107, 17)
        Me.chkAmbHumidity.TabIndex = 35
        Me.chkAmbHumidity.Text = "Ambient Humidity"
        Me.chkAmbHumidity.UseVisualStyleBackColor = True
        '
        'txtAmbTemp
        '
        Me.txtAmbTemp.Enabled = False
        Me.txtAmbTemp.Location = New System.Drawing.Point(415, 219)
        Me.txtAmbTemp.Name = "txtAmbTemp"
        Me.txtAmbTemp.Size = New System.Drawing.Size(44, 20)
        Me.txtAmbTemp.TabIndex = 39
        Me.txtAmbTemp.Text = "0"
        '
        'txtAmbHumidity
        '
        Me.txtAmbHumidity.Enabled = False
        Me.txtAmbHumidity.Location = New System.Drawing.Point(415, 265)
        Me.txtAmbHumidity.Name = "txtAmbHumidity"
        Me.txtAmbHumidity.Size = New System.Drawing.Size(44, 20)
        Me.txtAmbHumidity.TabIndex = 40
        Me.txtAmbHumidity.Text = "0"
        '
        'rbDry
        '
        Me.rbDry.AutoSize = True
        Me.rbDry.Enabled = False
        Me.rbDry.Location = New System.Drawing.Point(417, 160)
        Me.rbDry.Name = "rbDry"
        Me.rbDry.Size = New System.Drawing.Size(41, 17)
        Me.rbDry.TabIndex = 36
        Me.rbDry.TabStop = True
        Me.rbDry.Text = "Dry"
        Me.rbDry.UseVisualStyleBackColor = True
        '
        'rbFridge
        '
        Me.rbFridge.AutoSize = True
        Me.rbFridge.Enabled = False
        Me.rbFridge.Location = New System.Drawing.Point(464, 160)
        Me.rbFridge.Name = "rbFridge"
        Me.rbFridge.Size = New System.Drawing.Size(54, 17)
        Me.rbFridge.TabIndex = 37
        Me.rbFridge.TabStop = True
        Me.rbFridge.Text = "Fridge"
        Me.rbFridge.UseVisualStyleBackColor = True
        '
        'rbFreezer
        '
        Me.rbFreezer.AutoSize = True
        Me.rbFreezer.Enabled = False
        Me.rbFreezer.Location = New System.Drawing.Point(524, 158)
        Me.rbFreezer.Name = "rbFreezer"
        Me.rbFreezer.Size = New System.Drawing.Size(60, 17)
        Me.rbFreezer.TabIndex = 38
        Me.rbFreezer.TabStop = True
        Me.rbFreezer.Text = "Freezer"
        Me.rbFreezer.UseVisualStyleBackColor = True
        '
        'nudStarterWeight
        '
        Me.nudStarterWeight.Location = New System.Drawing.Point(215, 175)
        Me.nudStarterWeight.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudStarterWeight.Name = "nudStarterWeight"
        Me.nudStarterWeight.Size = New System.Drawing.Size(44, 20)
        Me.nudStarterWeight.TabIndex = 41
        '
        'nudStarterWaterWeight
        '
        Me.nudStarterWaterWeight.Location = New System.Drawing.Point(274, 175)
        Me.nudStarterWaterWeight.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudStarterWaterWeight.Name = "nudStarterWaterWeight"
        Me.nudStarterWaterWeight.Size = New System.Drawing.Size(44, 20)
        Me.nudStarterWaterWeight.TabIndex = 42
        '
        'nudStarterFlourWeight
        '
        Me.nudStarterFlourWeight.Location = New System.Drawing.Point(333, 175)
        Me.nudStarterFlourWeight.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudStarterFlourWeight.Name = "nudStarterFlourWeight"
        Me.nudStarterFlourWeight.Size = New System.Drawing.Size(44, 20)
        Me.nudStarterFlourWeight.TabIndex = 43
        '
        'frmStarter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 381)
        Me.Controls.Add(Me.nudStarterFlourWeight)
        Me.Controls.Add(Me.nudStarterWaterWeight)
        Me.Controls.Add(Me.nudStarterWeight)
        Me.Controls.Add(Me.rbDry)
        Me.Controls.Add(Me.rbFridge)
        Me.Controls.Add(Me.rbFreezer)
        Me.Controls.Add(Me.txtAmbHumidity)
        Me.Controls.Add(Me.txtAmbTemp)
        Me.Controls.Add(Me.chkAmbHumidity)
        Me.Controls.Add(Me.chkAmbTemp)
        Me.Controls.Add(Me.chkHibernation)
        Me.Controls.Add(Me.lblRatioSep4)
        Me.Controls.Add(Me.lblRatioSep3)
        Me.Controls.Add(Me.txtStarterFlourRatio)
        Me.Controls.Add(Me.txtStarterWaterRatio)
        Me.Controls.Add(Me.txtStarterRatio)
        Me.Controls.Add(Me.txtFeedingSchedule)
        Me.Controls.Add(Me.lblFeedingSchedule)
        Me.Controls.Add(Me.lblRatioSep2)
        Me.Controls.Add(Me.lblRatioSep1)
        Me.Controls.Add(Me.lblRecipeWeights)
        Me.Controls.Add(Me.lblFeedingRecipe)
        Me.Controls.Add(Me.btnAddToFeedingRecipe)
        Me.Controls.Add(Me.lstFeedingRecipe)
        Me.Controls.Add(Me.txtStarterRecipeFlourPercent)
        Me.Controls.Add(Me.lblStartRecipeFlourPercent)
        Me.Controls.Add(Me.lblStarterRecipeFlour)
        Me.Controls.Add(Me.lstStarterRecipeFlour)
        Me.Controls.Add(Me.lblFeedingDetails)
        Me.Controls.Add(Me.btnCancelStarter)
        Me.Controls.Add(Me.btnClearStarter)
        Me.Controls.Add(Me.lblCreationDate)
        Me.Controls.Add(Me.lblStarterName)
        Me.Controls.Add(Me.dtpCreationDate)
        Me.Controls.Add(Me.btnSaveStarter)
        Me.Controls.Add(Me.txtStarterName)
        Me.Name = "frmStarter"
        Me.Text = "Starter"
        CType(Me.nudStarterWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStarterWaterWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStarterFlourWeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStarterName As TextBox
    Friend WithEvents btnSaveStarter As Button
    Friend WithEvents dtpCreationDate As DateTimePicker
    Friend WithEvents lblStarterName As Label
    Friend WithEvents lblCreationDate As Label
    Friend WithEvents btnClearStarter As Button
    Friend WithEvents btnCancelStarter As Button
    Friend WithEvents lblFeedingDetails As Label
    Friend WithEvents lstStarterRecipeFlour As ListBox
    Friend WithEvents lblStarterRecipeFlour As Label
    Friend WithEvents lblStartRecipeFlourPercent As Label
    Friend WithEvents txtStarterRecipeFlourPercent As TextBox
    Friend WithEvents lstFeedingRecipe As ListBox
    Friend WithEvents btnAddToFeedingRecipe As Button
    Friend WithEvents lblFeedingRecipe As Label
    Friend WithEvents lblRecipeWeights As Label
    Friend WithEvents lblRatioSep1 As Label
    Friend WithEvents lblRatioSep2 As Label
    Friend WithEvents lblFeedingSchedule As Label
    Friend WithEvents txtFeedingSchedule As TextBox
    Friend WithEvents lblRatioSep4 As Label
    Friend WithEvents lblRatioSep3 As Label
    Friend WithEvents txtStarterFlourRatio As TextBox
    Friend WithEvents txtStarterWaterRatio As TextBox
    Friend WithEvents txtStarterRatio As TextBox
    Friend WithEvents chkHibernation As CheckBox
    Friend WithEvents chkAmbTemp As CheckBox
    Friend WithEvents chkAmbHumidity As CheckBox
    Friend WithEvents txtAmbTemp As TextBox
    Friend WithEvents txtAmbHumidity As TextBox
    Friend WithEvents rbDry As RadioButton
    Friend WithEvents rbFridge As RadioButton
    Friend WithEvents rbFreezer As RadioButton
    Friend WithEvents nudStarterWeight As NumericUpDown
    Friend WithEvents nudStarterWaterWeight As NumericUpDown
    Friend WithEvents nudStarterFlourWeight As NumericUpDown
End Class
