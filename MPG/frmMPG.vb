Public Class frmMPG
    Function calcMPG(miles1 As Integer, miles2 As Integer, gallons As Double) As Double
        If gallons = 0 Then
            Return (-1)
        Else
            Return (Math.Abs(miles1 - miles2) / gallons)
        End If
    End Function

    Private Sub btnMPG_Click(sender As Object, e As EventArgs) Handles btnMPG.Click
        Dim sMPG As String = calcMPG(CDbl(txtOdo1.Text), CDbl(txtOdo2.Text), CInt(txtGallons.Text))
        If CDbl(sMPG) < 0 Then
            txtMPG.Text = sMPG
        Else
            txtMPG.Text = "ERROR"
        End If
    End Sub
End Class
