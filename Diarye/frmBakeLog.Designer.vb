<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBakeLog
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
        Me.components = New System.ComponentModel.Container()
        Me.chkAutolyse = New System.Windows.Forms.CheckBox()
        Me.tmrAutolyse = New System.Windows.Forms.Timer(Me.components)
        Me.lblGlutenDevelopment = New System.Windows.Forms.Label()
        Me.rbCoil = New System.Windows.Forms.RadioButton()
        Me.rbStretchAndFold = New System.Windows.Forms.RadioButton()
        Me.rbLamination = New System.Windows.Forms.RadioButton()
        Me.lblGlutenDevInterval = New System.Windows.Forms.Label()
        Me.nudInterval = New System.Windows.Forms.NumericUpDown()
        Me.tmrBulkFerment = New System.Windows.Forms.Timer(Me.components)
        Me.nudDevCount = New System.Windows.Forms.NumericUpDown()
        Me.lblDevCount = New System.Windows.Forms.Label()
        Me.chkColdProof = New System.Windows.Forms.CheckBox()
        Me.nudColdProofHours = New System.Windows.Forms.NumericUpDown()
        Me.lblColdProofHours = New System.Windows.Forms.Label()
        Me.nudAutolyseTime = New System.Windows.Forms.NumericUpDown()
        Me.lblAutolyseTime = New System.Windows.Forms.Label()
        Me.lblBulkFermentTime = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.lblPhase1Bake = New System.Windows.Forms.Label()
        Me.chkPhase2Bake = New System.Windows.Forms.CheckBox()
        Me.lblPhase1Temp = New System.Windows.Forms.Label()
        Me.nudPhase1Temp = New System.Windows.Forms.NumericUpDown()
        Me.nudPhase1Time = New System.Windows.Forms.NumericUpDown()
        Me.lblPhase1Time = New System.Windows.Forms.Label()
        Me.nudPhase2Time = New System.Windows.Forms.NumericUpDown()
        Me.lblPhase2Time = New System.Windows.Forms.Label()
        Me.nudPhase2Temp = New System.Windows.Forms.NumericUpDown()
        Me.lblPhase2Temp = New System.Windows.Forms.Label()
        Me.chkBFAmbientTemp = New System.Windows.Forms.CheckBox()
        Me.chkBFAmbientHumidity = New System.Windows.Forms.CheckBox()
        Me.nudBFAmbTemp = New System.Windows.Forms.NumericUpDown()
        Me.nudBFAmbHumidity = New System.Windows.Forms.NumericUpDown()
        Me.btnCancelBake = New System.Windows.Forms.Button()
        Me.btnClearBakeLog = New System.Windows.Forms.Button()
        Me.btnLogBake = New System.Windows.Forms.Button()
        Me.lblTotalBakeTime = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblBakeStarter = New System.Windows.Forms.Label()
        Me.txtBakeStarter = New System.Windows.Forms.TextBox()
        Me.txtBakeRecipe = New System.Windows.Forms.TextBox()
        Me.lblBakeRecipe = New System.Windows.Forms.Label()
        Me.pnlResults = New System.Windows.Forms.Panel()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.rbSuccess = New System.Windows.Forms.RadioButton()
        Me.rbFailure = New System.Windows.Forms.RadioButton()
        Me.lblRise = New System.Windows.Forms.Label()
        Me.lblCrust = New System.Windows.Forms.Label()
        Me.lblCrumb = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblTaste = New System.Windows.Forms.Label()
        Me.chkHasEar = New System.Windows.Forms.CheckBox()
        Me.chkHasBlistering = New System.Windows.Forms.CheckBox()
        Me.nudRise = New System.Windows.Forms.NumericUpDown()
        Me.nudCrust = New System.Windows.Forms.NumericUpDown()
        Me.nudCrumb = New System.Windows.Forms.NumericUpDown()
        Me.nudColor = New System.Windows.Forms.NumericUpDown()
        Me.nudTaste = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDevCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudColdProofHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAutolyseTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPhase1Temp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPhase1Time, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPhase2Time, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPhase2Temp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBFAmbTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBFAmbHumidity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlResults.SuspendLayout()
        CType(Me.nudRise, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCrust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCrumb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTaste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkAutolyse
        '
        Me.chkAutolyse.AutoSize = True
        Me.chkAutolyse.Location = New System.Drawing.Point(211, 12)
        Me.chkAutolyse.Name = "chkAutolyse"
        Me.chkAutolyse.Size = New System.Drawing.Size(66, 17)
        Me.chkAutolyse.TabIndex = 0
        Me.chkAutolyse.Text = "Autolyse"
        Me.chkAutolyse.UseVisualStyleBackColor = True
        '
        'lblGlutenDevelopment
        '
        Me.lblGlutenDevelopment.AutoSize = True
        Me.lblGlutenDevelopment.Location = New System.Drawing.Point(207, 119)
        Me.lblGlutenDevelopment.Name = "lblGlutenDevelopment"
        Me.lblGlutenDevelopment.Size = New System.Drawing.Size(104, 13)
        Me.lblGlutenDevelopment.TabIndex = 2
        Me.lblGlutenDevelopment.Text = "Gluten Development"
        '
        'rbCoil
        '
        Me.rbCoil.AutoSize = True
        Me.rbCoil.Location = New System.Drawing.Point(210, 135)
        Me.rbCoil.Name = "rbCoil"
        Me.rbCoil.Size = New System.Drawing.Size(42, 17)
        Me.rbCoil.TabIndex = 3
        Me.rbCoil.TabStop = True
        Me.rbCoil.Text = "Coil"
        Me.rbCoil.UseVisualStyleBackColor = True
        '
        'rbStretchAndFold
        '
        Me.rbStretchAndFold.AutoSize = True
        Me.rbStretchAndFold.Location = New System.Drawing.Point(258, 135)
        Me.rbStretchAndFold.Name = "rbStretchAndFold"
        Me.rbStretchAndFold.Size = New System.Drawing.Size(103, 17)
        Me.rbStretchAndFold.TabIndex = 4
        Me.rbStretchAndFold.TabStop = True
        Me.rbStretchAndFold.Text = "Stretch and Fold"
        Me.rbStretchAndFold.UseVisualStyleBackColor = True
        '
        'rbLamination
        '
        Me.rbLamination.AutoSize = True
        Me.rbLamination.Location = New System.Drawing.Point(210, 158)
        Me.rbLamination.Name = "rbLamination"
        Me.rbLamination.Size = New System.Drawing.Size(76, 17)
        Me.rbLamination.TabIndex = 5
        Me.rbLamination.TabStop = True
        Me.rbLamination.Text = "Lamination"
        Me.rbLamination.UseVisualStyleBackColor = True
        '
        'lblGlutenDevInterval
        '
        Me.lblGlutenDevInterval.AutoSize = True
        Me.lblGlutenDevInterval.Location = New System.Drawing.Point(207, 201)
        Me.lblGlutenDevInterval.Name = "lblGlutenDevInterval"
        Me.lblGlutenDevInterval.Size = New System.Drawing.Size(98, 13)
        Me.lblGlutenDevInterval.TabIndex = 6
        Me.lblGlutenDevInterval.Text = "Interval (in minutes)"
        '
        'nudInterval
        '
        Me.nudInterval.Location = New System.Drawing.Point(311, 199)
        Me.nudInterval.Name = "nudInterval"
        Me.nudInterval.Size = New System.Drawing.Size(49, 20)
        Me.nudInterval.TabIndex = 7
        '
        'nudDevCount
        '
        Me.nudDevCount.Location = New System.Drawing.Point(311, 176)
        Me.nudDevCount.Name = "nudDevCount"
        Me.nudDevCount.Size = New System.Drawing.Size(49, 20)
        Me.nudDevCount.TabIndex = 15
        '
        'lblDevCount
        '
        Me.lblDevCount.AutoSize = True
        Me.lblDevCount.Location = New System.Drawing.Point(207, 178)
        Me.lblDevCount.Name = "lblDevCount"
        Me.lblDevCount.Size = New System.Drawing.Size(35, 13)
        Me.lblDevCount.TabIndex = 14
        Me.lblDevCount.Text = "Count"
        '
        'chkColdProof
        '
        Me.chkColdProof.AutoSize = True
        Me.chkColdProof.Location = New System.Drawing.Point(393, 172)
        Me.chkColdProof.Name = "chkColdProof"
        Me.chkColdProof.Size = New System.Drawing.Size(75, 17)
        Me.chkColdProof.TabIndex = 16
        Me.chkColdProof.Text = "Cold Proof"
        Me.chkColdProof.UseVisualStyleBackColor = True
        '
        'nudColdProofHours
        '
        Me.nudColdProofHours.Enabled = False
        Me.nudColdProofHours.Location = New System.Drawing.Point(431, 195)
        Me.nudColdProofHours.Name = "nudColdProofHours"
        Me.nudColdProofHours.Size = New System.Drawing.Size(37, 20)
        Me.nudColdProofHours.TabIndex = 17
        '
        'lblColdProofHours
        '
        Me.lblColdProofHours.AutoSize = True
        Me.lblColdProofHours.Enabled = False
        Me.lblColdProofHours.Location = New System.Drawing.Point(390, 197)
        Me.lblColdProofHours.Name = "lblColdProofHours"
        Me.lblColdProofHours.Size = New System.Drawing.Size(35, 13)
        Me.lblColdProofHours.TabIndex = 18
        Me.lblColdProofHours.Text = "Hours"
        '
        'nudAutolyseTime
        '
        Me.nudAutolyseTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudAutolyseTime.Location = New System.Drawing.Point(210, 50)
        Me.nudAutolyseTime.Maximum = New Decimal(New Integer() {720, 0, 0, 0})
        Me.nudAutolyseTime.Name = "nudAutolyseTime"
        Me.nudAutolyseTime.Size = New System.Drawing.Size(66, 29)
        Me.nudAutolyseTime.TabIndex = 19
        '
        'lblAutolyseTime
        '
        Me.lblAutolyseTime.AutoSize = True
        Me.lblAutolyseTime.Location = New System.Drawing.Point(207, 34)
        Me.lblAutolyseTime.Name = "lblAutolyseTime"
        Me.lblAutolyseTime.Size = New System.Drawing.Size(129, 13)
        Me.lblAutolyseTime.TabIndex = 20
        Me.lblAutolyseTime.Text = "Autolyse Time (in minutes)"
        '
        'lblBulkFermentTime
        '
        Me.lblBulkFermentTime.AutoSize = True
        Me.lblBulkFermentTime.Location = New System.Drawing.Point(390, 12)
        Me.lblBulkFermentTime.Name = "lblBulkFermentTime"
        Me.lblBulkFermentTime.Size = New System.Drawing.Size(151, 13)
        Me.lblBulkFermentTime.TabIndex = 22
        Me.lblBulkFermentTime.Text = "Bulk Ferment Time (in minutes)"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(393, 28)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {720, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(66, 29)
        Me.NumericUpDown2.TabIndex = 21
        '
        'lblPhase1Bake
        '
        Me.lblPhase1Bake.AutoSize = True
        Me.lblPhase1Bake.Location = New System.Drawing.Point(567, 12)
        Me.lblPhase1Bake.Name = "lblPhase1Bake"
        Me.lblPhase1Bake.Size = New System.Drawing.Size(74, 13)
        Me.lblPhase1Bake.TabIndex = 23
        Me.lblPhase1Bake.Text = "Phase 1 Bake"
        '
        'chkPhase2Bake
        '
        Me.chkPhase2Bake.AutoSize = True
        Me.chkPhase2Bake.Location = New System.Drawing.Point(693, 11)
        Me.chkPhase2Bake.Name = "chkPhase2Bake"
        Me.chkPhase2Bake.Size = New System.Drawing.Size(93, 17)
        Me.chkPhase2Bake.TabIndex = 24
        Me.chkPhase2Bake.Text = "Phase 2 Bake"
        Me.chkPhase2Bake.UseVisualStyleBackColor = True
        '
        'lblPhase1Temp
        '
        Me.lblPhase1Temp.AutoSize = True
        Me.lblPhase1Temp.Location = New System.Drawing.Point(567, 34)
        Me.lblPhase1Temp.Name = "lblPhase1Temp"
        Me.lblPhase1Temp.Size = New System.Drawing.Size(86, 13)
        Me.lblPhase1Temp.TabIndex = 25
        Me.lblPhase1Temp.Text = "Temperature (F°)"
        '
        'nudPhase1Temp
        '
        Me.nudPhase1Temp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPhase1Temp.Location = New System.Drawing.Point(570, 50)
        Me.nudPhase1Temp.Maximum = New Decimal(New Integer() {720, 0, 0, 0})
        Me.nudPhase1Temp.Name = "nudPhase1Temp"
        Me.nudPhase1Temp.Size = New System.Drawing.Size(66, 29)
        Me.nudPhase1Temp.TabIndex = 26
        Me.nudPhase1Temp.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'nudPhase1Time
        '
        Me.nudPhase1Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPhase1Time.Location = New System.Drawing.Point(570, 127)
        Me.nudPhase1Time.Maximum = New Decimal(New Integer() {720, 0, 0, 0})
        Me.nudPhase1Time.Name = "nudPhase1Time"
        Me.nudPhase1Time.Size = New System.Drawing.Size(66, 29)
        Me.nudPhase1Time.TabIndex = 28
        '
        'lblPhase1Time
        '
        Me.lblPhase1Time.AutoSize = True
        Me.lblPhase1Time.Location = New System.Drawing.Point(567, 111)
        Me.lblPhase1Time.Name = "lblPhase1Time"
        Me.lblPhase1Time.Size = New System.Drawing.Size(86, 13)
        Me.lblPhase1Time.TabIndex = 27
        Me.lblPhase1Time.Text = "Time (in minutes)"
        '
        'nudPhase2Time
        '
        Me.nudPhase2Time.Enabled = False
        Me.nudPhase2Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPhase2Time.Location = New System.Drawing.Point(693, 127)
        Me.nudPhase2Time.Maximum = New Decimal(New Integer() {720, 0, 0, 0})
        Me.nudPhase2Time.Name = "nudPhase2Time"
        Me.nudPhase2Time.Size = New System.Drawing.Size(66, 29)
        Me.nudPhase2Time.TabIndex = 32
        '
        'lblPhase2Time
        '
        Me.lblPhase2Time.AutoSize = True
        Me.lblPhase2Time.Enabled = False
        Me.lblPhase2Time.Location = New System.Drawing.Point(690, 111)
        Me.lblPhase2Time.Name = "lblPhase2Time"
        Me.lblPhase2Time.Size = New System.Drawing.Size(86, 13)
        Me.lblPhase2Time.TabIndex = 31
        Me.lblPhase2Time.Text = "Time (in minutes)"
        '
        'nudPhase2Temp
        '
        Me.nudPhase2Temp.Enabled = False
        Me.nudPhase2Temp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPhase2Temp.Location = New System.Drawing.Point(693, 49)
        Me.nudPhase2Temp.Maximum = New Decimal(New Integer() {720, 0, 0, 0})
        Me.nudPhase2Temp.Name = "nudPhase2Temp"
        Me.nudPhase2Temp.Size = New System.Drawing.Size(66, 29)
        Me.nudPhase2Temp.TabIndex = 30
        Me.nudPhase2Temp.Value = New Decimal(New Integer() {450, 0, 0, 0})
        '
        'lblPhase2Temp
        '
        Me.lblPhase2Temp.AutoSize = True
        Me.lblPhase2Temp.Enabled = False
        Me.lblPhase2Temp.Location = New System.Drawing.Point(690, 33)
        Me.lblPhase2Temp.Name = "lblPhase2Temp"
        Me.lblPhase2Temp.Size = New System.Drawing.Size(86, 13)
        Me.lblPhase2Temp.TabIndex = 29
        Me.lblPhase2Temp.Text = "Temperature (F°)"
        '
        'chkBFAmbientTemp
        '
        Me.chkBFAmbientTemp.AutoSize = True
        Me.chkBFAmbientTemp.Checked = True
        Me.chkBFAmbientTemp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBFAmbientTemp.Location = New System.Drawing.Point(393, 63)
        Me.chkBFAmbientTemp.Name = "chkBFAmbientTemp"
        Me.chkBFAmbientTemp.Size = New System.Drawing.Size(127, 17)
        Me.chkBFAmbientTemp.TabIndex = 33
        Me.chkBFAmbientTemp.Text = "Ambient Temperature"
        Me.chkBFAmbientTemp.UseVisualStyleBackColor = True
        '
        'chkBFAmbientHumidity
        '
        Me.chkBFAmbientHumidity.AutoSize = True
        Me.chkBFAmbientHumidity.Location = New System.Drawing.Point(393, 115)
        Me.chkBFAmbientHumidity.Name = "chkBFAmbientHumidity"
        Me.chkBFAmbientHumidity.Size = New System.Drawing.Size(107, 17)
        Me.chkBFAmbientHumidity.TabIndex = 34
        Me.chkBFAmbientHumidity.Text = "Ambient Humidity"
        Me.chkBFAmbientHumidity.UseVisualStyleBackColor = True
        '
        'nudBFAmbTemp
        '
        Me.nudBFAmbTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudBFAmbTemp.Location = New System.Drawing.Point(393, 86)
        Me.nudBFAmbTemp.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
        Me.nudBFAmbTemp.Name = "nudBFAmbTemp"
        Me.nudBFAmbTemp.Size = New System.Drawing.Size(66, 24)
        Me.nudBFAmbTemp.TabIndex = 35
        Me.nudBFAmbTemp.Value = New Decimal(New Integer() {75, 0, 0, 0})
        '
        'nudBFAmbHumidity
        '
        Me.nudBFAmbHumidity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudBFAmbHumidity.Location = New System.Drawing.Point(393, 135)
        Me.nudBFAmbHumidity.Name = "nudBFAmbHumidity"
        Me.nudBFAmbHumidity.Size = New System.Drawing.Size(66, 24)
        Me.nudBFAmbHumidity.TabIndex = 36
        '
        'btnCancelBake
        '
        Me.btnCancelBake.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelBake.Location = New System.Drawing.Point(473, 408)
        Me.btnCancelBake.Name = "btnCancelBake"
        Me.btnCancelBake.Size = New System.Drawing.Size(134, 30)
        Me.btnCancelBake.TabIndex = 39
        Me.btnCancelBake.Text = "Cancel"
        Me.btnCancelBake.UseVisualStyleBackColor = True
        '
        'btnClearBakeLog
        '
        Me.btnClearBakeLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearBakeLog.Location = New System.Drawing.Point(333, 408)
        Me.btnClearBakeLog.Name = "btnClearBakeLog"
        Me.btnClearBakeLog.Size = New System.Drawing.Size(134, 30)
        Me.btnClearBakeLog.TabIndex = 38
        Me.btnClearBakeLog.Text = "Clear"
        Me.btnClearBakeLog.UseVisualStyleBackColor = True
        '
        'btnLogBake
        '
        Me.btnLogBake.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogBake.Location = New System.Drawing.Point(193, 408)
        Me.btnLogBake.Name = "btnLogBake"
        Me.btnLogBake.Size = New System.Drawing.Size(134, 30)
        Me.btnLogBake.TabIndex = 37
        Me.btnLogBake.Text = "Save to Log"
        Me.btnLogBake.UseVisualStyleBackColor = True
        '
        'lblTotalBakeTime
        '
        Me.lblTotalBakeTime.AutoSize = True
        Me.lblTotalBakeTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBakeTime.Location = New System.Drawing.Point(567, 174)
        Me.lblTotalBakeTime.Name = "lblTotalBakeTime"
        Me.lblTotalBakeTime.Size = New System.Drawing.Size(120, 18)
        Me.lblTotalBakeTime.TabIndex = 40
        Me.lblTotalBakeTime.Text = "Total Bake Time:"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(693, 171)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(66, 24)
        Me.TextBox1.TabIndex = 41
        '
        'lblBakeStarter
        '
        Me.lblBakeStarter.AutoSize = True
        Me.lblBakeStarter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBakeStarter.Location = New System.Drawing.Point(55, 34)
        Me.lblBakeStarter.Name = "lblBakeStarter"
        Me.lblBakeStarter.Size = New System.Drawing.Size(58, 20)
        Me.lblBakeStarter.TabIndex = 42
        Me.lblBakeStarter.Text = "Starter"
        '
        'txtBakeStarter
        '
        Me.txtBakeStarter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBakeStarter.Location = New System.Drawing.Point(35, 57)
        Me.txtBakeStarter.Name = "txtBakeStarter"
        Me.txtBakeStarter.Size = New System.Drawing.Size(100, 26)
        Me.txtBakeStarter.TabIndex = 43
        '
        'txtBakeRecipe
        '
        Me.txtBakeRecipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBakeRecipe.Location = New System.Drawing.Point(35, 137)
        Me.txtBakeRecipe.Name = "txtBakeRecipe"
        Me.txtBakeRecipe.Size = New System.Drawing.Size(100, 26)
        Me.txtBakeRecipe.TabIndex = 45
        '
        'lblBakeRecipe
        '
        Me.lblBakeRecipe.AutoSize = True
        Me.lblBakeRecipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBakeRecipe.Location = New System.Drawing.Point(55, 114)
        Me.lblBakeRecipe.Name = "lblBakeRecipe"
        Me.lblBakeRecipe.Size = New System.Drawing.Size(59, 20)
        Me.lblBakeRecipe.TabIndex = 44
        Me.lblBakeRecipe.Text = "Recipe"
        '
        'pnlResults
        '
        Me.pnlResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlResults.Controls.Add(Me.nudTaste)
        Me.pnlResults.Controls.Add(Me.nudColor)
        Me.pnlResults.Controls.Add(Me.nudCrumb)
        Me.pnlResults.Controls.Add(Me.nudCrust)
        Me.pnlResults.Controls.Add(Me.nudRise)
        Me.pnlResults.Controls.Add(Me.chkHasBlistering)
        Me.pnlResults.Controls.Add(Me.chkHasEar)
        Me.pnlResults.Controls.Add(Me.lblTaste)
        Me.pnlResults.Controls.Add(Me.lblColor)
        Me.pnlResults.Controls.Add(Me.lblCrumb)
        Me.pnlResults.Controls.Add(Me.lblCrust)
        Me.pnlResults.Controls.Add(Me.lblRise)
        Me.pnlResults.Controls.Add(Me.rbFailure)
        Me.pnlResults.Controls.Add(Me.rbSuccess)
        Me.pnlResults.Controls.Add(Me.lblRate)
        Me.pnlResults.Location = New System.Drawing.Point(1, 250)
        Me.pnlResults.Name = "pnlResults"
        Me.pnlResults.Size = New System.Drawing.Size(799, 148)
        Me.pnlResults.TabIndex = 46
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(369, 228)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(63, 20)
        Me.lblResults.TabIndex = 47
        Me.lblResults.Text = "Results"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(269, 0)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(258, 13)
        Me.lblRate.TabIndex = 0
        Me.lblRate.Text = "Please rate the following (0 = Poor, 10 = Outstanding)"
        '
        'rbSuccess
        '
        Me.rbSuccess.AutoSize = True
        Me.rbSuccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSuccess.Location = New System.Drawing.Point(691, 34)
        Me.rbSuccess.Name = "rbSuccess"
        Me.rbSuccess.Size = New System.Drawing.Size(79, 21)
        Me.rbSuccess.TabIndex = 1
        Me.rbSuccess.TabStop = True
        Me.rbSuccess.Text = "Success"
        Me.rbSuccess.UseVisualStyleBackColor = True
        '
        'rbFailure
        '
        Me.rbFailure.AutoSize = True
        Me.rbFailure.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFailure.Location = New System.Drawing.Point(691, 57)
        Me.rbFailure.Name = "rbFailure"
        Me.rbFailure.Size = New System.Drawing.Size(69, 21)
        Me.rbFailure.TabIndex = 2
        Me.rbFailure.TabStop = True
        Me.rbFailure.Text = "Failure"
        Me.rbFailure.UseVisualStyleBackColor = True
        '
        'lblRise
        '
        Me.lblRise.AutoSize = True
        Me.lblRise.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRise.Location = New System.Drawing.Point(33, 34)
        Me.lblRise.Name = "lblRise"
        Me.lblRise.Size = New System.Drawing.Size(36, 17)
        Me.lblRise.TabIndex = 3
        Me.lblRise.Text = "Rise"
        '
        'lblCrust
        '
        Me.lblCrust.AutoSize = True
        Me.lblCrust.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrust.Location = New System.Drawing.Point(138, 34)
        Me.lblCrust.Name = "lblCrust"
        Me.lblCrust.Size = New System.Drawing.Size(41, 17)
        Me.lblCrust.TabIndex = 4
        Me.lblCrust.Text = "Crust"
        '
        'lblCrumb
        '
        Me.lblCrumb.AutoSize = True
        Me.lblCrumb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrumb.Location = New System.Drawing.Point(243, 34)
        Me.lblCrumb.Name = "lblCrumb"
        Me.lblCrumb.Size = New System.Drawing.Size(49, 17)
        Me.lblCrumb.TabIndex = 5
        Me.lblCrumb.Text = "Crumb"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.Location = New System.Drawing.Point(348, 34)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(41, 17)
        Me.lblColor.TabIndex = 6
        Me.lblColor.Text = "Color"
        '
        'lblTaste
        '
        Me.lblTaste.AutoSize = True
        Me.lblTaste.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaste.Location = New System.Drawing.Point(453, 34)
        Me.lblTaste.Name = "lblTaste"
        Me.lblTaste.Size = New System.Drawing.Size(44, 17)
        Me.lblTaste.TabIndex = 7
        Me.lblTaste.Text = "Taste"
        '
        'chkHasEar
        '
        Me.chkHasEar.AutoSize = True
        Me.chkHasEar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHasEar.Location = New System.Drawing.Point(554, 35)
        Me.chkHasEar.Name = "chkHasEar"
        Me.chkHasEar.Size = New System.Drawing.Size(78, 21)
        Me.chkHasEar.TabIndex = 8
        Me.chkHasEar.Text = "Has Ear"
        Me.chkHasEar.UseVisualStyleBackColor = True
        '
        'chkHasBlistering
        '
        Me.chkHasBlistering.AutoSize = True
        Me.chkHasBlistering.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHasBlistering.Location = New System.Drawing.Point(554, 58)
        Me.chkHasBlistering.Name = "chkHasBlistering"
        Me.chkHasBlistering.Size = New System.Drawing.Size(114, 21)
        Me.chkHasBlistering.TabIndex = 9
        Me.chkHasBlistering.Text = "Has Blistering"
        Me.chkHasBlistering.UseVisualStyleBackColor = True
        '
        'nudRise
        '
        Me.nudRise.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudRise.Location = New System.Drawing.Point(36, 58)
        Me.nudRise.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudRise.Name = "nudRise"
        Me.nudRise.Size = New System.Drawing.Size(38, 23)
        Me.nudRise.TabIndex = 10
        Me.nudRise.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'nudCrust
        '
        Me.nudCrust.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCrust.Location = New System.Drawing.Point(141, 58)
        Me.nudCrust.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudCrust.Name = "nudCrust"
        Me.nudCrust.Size = New System.Drawing.Size(38, 23)
        Me.nudCrust.TabIndex = 11
        Me.nudCrust.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'nudCrumb
        '
        Me.nudCrumb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCrumb.Location = New System.Drawing.Point(246, 58)
        Me.nudCrumb.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudCrumb.Name = "nudCrumb"
        Me.nudCrumb.Size = New System.Drawing.Size(38, 23)
        Me.nudCrumb.TabIndex = 12
        Me.nudCrumb.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'nudColor
        '
        Me.nudColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudColor.Location = New System.Drawing.Point(351, 58)
        Me.nudColor.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudColor.Name = "nudColor"
        Me.nudColor.Size = New System.Drawing.Size(38, 23)
        Me.nudColor.TabIndex = 13
        Me.nudColor.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'nudTaste
        '
        Me.nudTaste.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTaste.Location = New System.Drawing.Point(456, 58)
        Me.nudTaste.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudTaste.Name = "nudTaste"
        Me.nudTaste.Size = New System.Drawing.Size(38, 23)
        Me.nudTaste.TabIndex = 14
        Me.nudTaste.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'frmBakeLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.pnlResults)
        Me.Controls.Add(Me.txtBakeRecipe)
        Me.Controls.Add(Me.lblBakeRecipe)
        Me.Controls.Add(Me.txtBakeStarter)
        Me.Controls.Add(Me.lblBakeStarter)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblTotalBakeTime)
        Me.Controls.Add(Me.btnCancelBake)
        Me.Controls.Add(Me.btnClearBakeLog)
        Me.Controls.Add(Me.btnLogBake)
        Me.Controls.Add(Me.nudBFAmbHumidity)
        Me.Controls.Add(Me.nudBFAmbTemp)
        Me.Controls.Add(Me.chkBFAmbientHumidity)
        Me.Controls.Add(Me.chkBFAmbientTemp)
        Me.Controls.Add(Me.nudPhase2Time)
        Me.Controls.Add(Me.lblPhase2Time)
        Me.Controls.Add(Me.nudPhase2Temp)
        Me.Controls.Add(Me.lblPhase2Temp)
        Me.Controls.Add(Me.nudPhase1Time)
        Me.Controls.Add(Me.lblPhase1Time)
        Me.Controls.Add(Me.nudPhase1Temp)
        Me.Controls.Add(Me.lblPhase1Temp)
        Me.Controls.Add(Me.chkPhase2Bake)
        Me.Controls.Add(Me.lblPhase1Bake)
        Me.Controls.Add(Me.lblBulkFermentTime)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.lblAutolyseTime)
        Me.Controls.Add(Me.nudAutolyseTime)
        Me.Controls.Add(Me.lblColdProofHours)
        Me.Controls.Add(Me.nudColdProofHours)
        Me.Controls.Add(Me.chkColdProof)
        Me.Controls.Add(Me.nudDevCount)
        Me.Controls.Add(Me.lblDevCount)
        Me.Controls.Add(Me.nudInterval)
        Me.Controls.Add(Me.lblGlutenDevInterval)
        Me.Controls.Add(Me.rbLamination)
        Me.Controls.Add(Me.rbStretchAndFold)
        Me.Controls.Add(Me.rbCoil)
        Me.Controls.Add(Me.lblGlutenDevelopment)
        Me.Controls.Add(Me.chkAutolyse)
        Me.Name = "frmBakeLog"
        Me.Text = "frmBakeLog"
        CType(Me.nudInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDevCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudColdProofHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAutolyseTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPhase1Temp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPhase1Time, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPhase2Time, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPhase2Temp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBFAmbTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBFAmbHumidity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlResults.ResumeLayout(False)
        Me.pnlResults.PerformLayout()
        CType(Me.nudRise, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCrust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCrumb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTaste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkAutolyse As CheckBox
    Friend WithEvents tmrAutolyse As Timer
    Friend WithEvents lblGlutenDevelopment As Label
    Friend WithEvents rbCoil As RadioButton
    Friend WithEvents rbStretchAndFold As RadioButton
    Friend WithEvents rbLamination As RadioButton
    Friend WithEvents lblGlutenDevInterval As Label
    Friend WithEvents nudInterval As NumericUpDown
    Friend WithEvents tmrBulkFerment As Timer
    Friend WithEvents nudDevCount As NumericUpDown
    Friend WithEvents lblDevCount As Label
    Friend WithEvents chkColdProof As CheckBox
    Friend WithEvents nudColdProofHours As NumericUpDown
    Friend WithEvents lblColdProofHours As Label
    Friend WithEvents nudAutolyseTime As NumericUpDown
    Friend WithEvents lblAutolyseTime As Label
    Friend WithEvents lblBulkFermentTime As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents lblPhase1Bake As Label
    Friend WithEvents chkPhase2Bake As CheckBox
    Friend WithEvents lblPhase1Temp As Label
    Friend WithEvents nudPhase1Temp As NumericUpDown
    Friend WithEvents nudPhase1Time As NumericUpDown
    Friend WithEvents lblPhase1Time As Label
    Friend WithEvents nudPhase2Time As NumericUpDown
    Friend WithEvents lblPhase2Time As Label
    Friend WithEvents nudPhase2Temp As NumericUpDown
    Friend WithEvents lblPhase2Temp As Label
    Friend WithEvents chkBFAmbientTemp As CheckBox
    Friend WithEvents chkBFAmbientHumidity As CheckBox
    Friend WithEvents nudBFAmbTemp As NumericUpDown
    Friend WithEvents nudBFAmbHumidity As NumericUpDown
    Friend WithEvents btnCancelBake As Button
    Friend WithEvents btnClearBakeLog As Button
    Friend WithEvents btnLogBake As Button
    Friend WithEvents lblTotalBakeTime As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblBakeStarter As Label
    Friend WithEvents txtBakeStarter As TextBox
    Friend WithEvents txtBakeRecipe As TextBox
    Friend WithEvents lblBakeRecipe As Label
    Friend WithEvents pnlResults As Panel
    Friend WithEvents lblRate As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents rbFailure As RadioButton
    Friend WithEvents rbSuccess As RadioButton
    Friend WithEvents nudTaste As NumericUpDown
    Friend WithEvents nudColor As NumericUpDown
    Friend WithEvents nudCrumb As NumericUpDown
    Friend WithEvents nudCrust As NumericUpDown
    Friend WithEvents nudRise As NumericUpDown
    Friend WithEvents chkHasBlistering As CheckBox
    Friend WithEvents chkHasEar As CheckBox
    Friend WithEvents lblTaste As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents lblCrumb As Label
    Friend WithEvents lblCrust As Label
    Friend WithEvents lblRise As Label
End Class
