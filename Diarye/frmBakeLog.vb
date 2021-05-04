Public Class frmBakeLog
    Private Sub btnCancelBake_Click(sender As Object, e As EventArgs) Handles btnCancelBake.Click
        Me.ClearForm()
        Me.Hide()
    End Sub

    Private Sub ClearForm()
        txtBakeStarter.Text = ""
        txtBakeRecipe.Text = ""
        chkAutolyse.Checked = False
        rbCoil.Checked = False
        rbLamination.Checked = False
        rbStretchAndFold.Checked = False
        nudDevCount.Value = 0
        nudInterval.Value = 0
        nudBulkFerment.Value = 0
        chkBFAmbientTemp.Checked = False
        chkBFAmbientHumidity.Checked = False
        chkColdProof.Checked = False
        nudPhase1Temp.Value = 500
        nudPhase1Time.Value = 0
        chkPhase2Bake.Checked = False
        nudPhase2Temp.Value = 450
        nudPhase2Time.Value = 0
        txtTotalBakeTime.Text = ""
        nudRise.Value = 5
        nudCrust.Value = 5
        nudCrumb.Value = 5
        nudColor.Value = 5
        nudTaste.Value = 5
        chkHasBlistering.Checked = False
        chkHasEar.Checked = False
        rbSuccess.Checked = False
        rbFailure.Checked = False
    End Sub

    Private Sub chkAutolyse_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutolyse.CheckedChanged
        If chkAutolyse.Checked = True Then
            lblAutolyseTime.Enabled = True
            nudAutolyseTime.Enabled = True
        Else
            lblAutolyseTime.Enabled = True
            nudAutolyseTime.Enabled = True
            nudAutolyseTime.Value = 0
        End If
    End Sub

    Private Sub chkBFAmbientTemp_CheckedChanged(sender As Object, e As EventArgs) Handles chkBFAmbientTemp.CheckedChanged
        If chkBFAmbientTemp.Checked = True Then
            nudBFAmbTemp.Enabled = True
        Else
            nudBFAmbTemp.Enabled = False
            nudBFAmbTemp.Value = 0
        End If
    End Sub

    Private Sub chkBFAmbientHumidity_CheckedChanged(sender As Object, e As EventArgs) Handles chkBFAmbientHumidity.CheckedChanged
        If chkBFAmbientHumidity.Checked = True Then
            nudBFAmbHumidity.Enabled = True
        Else
            nudBFAmbHumidity.Enabled = False
            nudBFAmbHumidity.Value = 0
        End If
    End Sub

    Private Sub chkColdProof_CheckedChanged(sender As Object, e As EventArgs) Handles chkColdProof.CheckedChanged
        If chkColdProof.Checked = True Then
            lblColdProofHours.Enabled = True
            nudColdProofHours.Enabled = True
        Else
            lblColdProofHours.Enabled = False
            nudColdProofHours.Enabled = False
            nudColdProofHours.Value = 0
        End If
    End Sub

    Private Sub chkPhase2Bake_CheckedChanged(sender As Object, e As EventArgs) Handles chkPhase2Bake.CheckedChanged
        If chkPhase2Bake.Checked = True Then
            lblPhase2Temp.Enabled = True
            lblPhase2Time.Enabled = True
            nudPhase2Temp.Enabled = True
            nudPhase2Time.Enabled = True
        Else
            lblPhase2Temp.Enabled = False
            lblPhase2Time.Enabled = False
            nudPhase2Temp.Enabled = False
            nudPhase2Temp.Value = 450
            nudPhase2Time.Enabled = False
            nudPhase2Time.Value = 0
        End If
    End Sub

    Private Sub nudPhase1Time_ValueChanged(sender As Object, e As EventArgs) Handles nudPhase2Time.ValueChanged, nudPhase1Time.ValueChanged
        txtTotalBakeTime.Text = CStr(nudPhase1Time.Value + nudPhase2Time.Value)
    End Sub

    Private Sub btnClearBakeLog_Click(sender As Object, e As EventArgs) Handles btnClearBakeLog.Click
        Me.ClearForm()
    End Sub

    Private Sub btnLogBake_Click(sender As Object, e As EventArgs) Handles btnLogBake.Click
        Dim bake1 As New BakeLog
        bake1.BakeDate = dtpBakeLog.Value
        bake1.StarterUsed = txtBakeStarter.Text
        bake1.RecipeUsed = txtBakeRecipe.Text
        bake1.Autolyse = chkAutolyse.Checked
        bake1.AutolyseTime = nudAutolyseTime.Value
        If rbCoil.Checked = True Then
            bake1.GlutenDevMethod = rbCoil.Text
        ElseIf rbLamination.Checked = True Then
            bake1.GlutenDevMethod = rbLamination.Text
        Else
            bake1.GlutenDevMethod = rbStretchAndFold.Text
        End If
        bake1.GlutenDevCount = nudDevCount.Value
        bake1.GlutenDevInterval = nudInterval.Value
        bake1.BulkFermentTime = nudBulkFerment.Value
        bake1.AmbientTemp = nudBFAmbTemp.Value
        bake1.AmbientHumidity = nudBFAmbHumidity.Value
        bake1.ColdProof = chkColdProof.Checked
        bake1.ColdProofTime = nudColdProofHours.Value
        bake1.Phase1Temp = nudPhase1Temp.Value
        bake1.Phase1Time = nudPhase1Time.Value
        bake1.Phase2Temp = nudPhase2Temp.Value
        bake1.Phase2Time = nudPhase2Time.Value
        bake1.RiseRating = nudRise.Value
        bake1.CrumbRating = nudCrumb.Value
        bake1.CrustRating = nudCrust.Value
        bake1.ColorRating = nudColor.Value
        bake1.TasteRating = nudTaste.Value
        bake1.HasBlistering = chkHasBlistering.Checked
        bake1.HasEar = chkHasEar.Checked
        bake1.IsSuccess = rbSuccess.Checked

        My.Computer.FileSystem.WriteAllText("C:\Users\tgilm\source\repos\Diarye\data\BakeLog.txt",
            bake1.ToString(), True)

        ClearForm()
        Me.Hide()
    End Sub
End Class