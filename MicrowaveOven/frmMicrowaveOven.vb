Public Class frmMicrowaveOven
    Public Property Green As Color

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click
        Dim sTime As String = lblTime.Text.Replace(":", "")
        sTime &= Me.ActiveControl.Text
        sTime = sTime.Substring(sTime.Length - 4)
        lblTime.Text = sTime.Substring(0, 2) & ":" & sTime.Substring(2, 2)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblTime.Text = "00:00"
        tmrCook.Enabled = False
        pnlOven.BackColor = Color.LightGray
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        lblTime.Text = ConvertToFormattedTime(lblTime.Text)
        tmrCook.Enabled = True
        pnlOven.BackColor = Color.LightGreen
    End Sub

    'HW file called for 2 separate functions to convert to and from "seconds" and "mm:ss"
    'You told us verbally in class to program the way our home microwave works. My microwave
    'will subtract 60 seconds from the SS field and add 1 minute to the MM field any time the
    'SS field is greater than 60. The following single function semed like the best way to handle that.

    Private Function ConvertToFormattedTime([String] As Object)
        Dim sTimer As String = lblTime.Text
        sTimer = sTimer.Remove(2, 1)
        Dim sMM = sTimer.Substring(0, 2)
        Dim sSS = sTimer.Substring(2, 2)
        Dim iSeconds As Integer = CInt(sSS)
        Dim iMinutes As Integer = CInt(sMM)
        If iSeconds > 59 Then
            iMinutes += 1
        End If
        Dim iSpanSeconds As TimeSpan = TimeSpan.FromSeconds(iSeconds)
        Dim iSpanMinutes As TimeSpan = TimeSpan.FromMinutes(iMinutes)
        Dim sFormattedTime
        sFormattedTime = iSpanMinutes.Minutes.ToString.PadLeft(2, "0"c) & ":" &
                        iSpanSeconds.Seconds.ToString.PadLeft(2, "0"c)

        Return sFormattedTime
    End Function

    Private Sub tmrCook_Tick(sender As Object, e As EventArgs) Handles tmrCook.Tick
        Dim sTimer As String = lblTime.Text
        sTimer = sTimer.Remove(2, 1)
        Dim sMM = sTimer.Substring(0, 2)
        Dim sSS = sTimer.Substring(2, 2)
        Dim iSeconds As Integer = CInt(sSS)
        Dim iMinutes As Integer = CInt(sMM)
        If iSeconds = 0 AndAlso iMinutes > 0 Then
            iMinutes -= 1
            iSeconds += 59
        ElseIf iSeconds > 0 Then
            iSeconds -= 1
        Else
            pnlOven.BackColor = Color.LightGray
            tmrCook.Enabled = False
        End If
        Dim iSpanSeconds As TimeSpan = TimeSpan.FromSeconds(iSeconds)
        Dim iSpanMinutes As TimeSpan = TimeSpan.FromMinutes(iMinutes)
        Dim sFormattedTime
        sFormattedTime = iSpanMinutes.Minutes.ToString.PadLeft(2, "0"c) & ":" &
                        iSpanSeconds.Seconds.ToString.PadLeft(2, "0"c)
        lblTime.Text = sFormattedTime
    End Sub
End Class
