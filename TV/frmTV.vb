Public Class frmTV
    Dim television As TV = New TV
    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        television.TogglePower()
        If television.hasPower = True Then
            pnlPower.BackColor = Color.Green
            txtChannel.Text = television.currentChannel
            txtVolume.Text = television.currentVolume
        Else
            pnlPower.BackColor = Color.White
            txtChannel.Text = ""
            txtVolume.Text = ""
        End If

    End Sub

    Private Sub btnVolUp_Click(sender As Object, e As EventArgs) Handles btnVolUp.Click
        If television.hasPower = False Then
            'Pass
        Else
            txtVolume.Text = television.setVolumeUp()
        End If
    End Sub

    Private Sub btnVolDown_Click(sender As Object, e As EventArgs) Handles btnVolDown.Click
        If television.hasPower = False Then
            'Pass
        Else
            txtVolume.Text = television.setVolumeDown()
        End If
    End Sub

    Private Sub btnChanUp_Click(sender As Object, e As EventArgs) Handles btnChanUp.Click
        If television.hasPower = False Then
            'Pass
        Else
            txtChannel.Text = television.setChannelUp()
        End If
    End Sub

    Private Sub btnChanDown_Click(sender As Object, e As EventArgs) Handles btnChanDown.Click
        If television.hasPower = False Then
            'Pass
        Else
            txtChannel.Text = television.setChannelDown()
        End If
    End Sub

    Private Sub frmTV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBrand.Text = television.Brand
        lblMfg.Text = television.Mfg
    End Sub
End Class
