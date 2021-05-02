Public Class frmBakeLog
    Private Sub btnCancelBake_Click(sender As Object, e As EventArgs) Handles btnCancelBake.Click
        Me.Hide()
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
End Class