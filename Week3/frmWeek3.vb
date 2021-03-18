Public Class frmWeek3
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub btnShowClock_Click(sender As Object, e As EventArgs) Handles btnShowClock.Click
        If tmr1.Enabled Then
            tmr1.Enabled = False
            btnShowClock.Text = "Start Clock"
        Else
            txtClock.Text = Now.ToLongTimeString
            tmr1.Interval = 100
            tmr1.Enabled = True
            btnShowClock.Text = "Stop Clock"
        End If
    End Sub

    Private Sub tmr1_Tick(sender As Object, e As EventArgs) Handles tmr1.Tick
        txtClock.Text = Now.ToLongTimeString
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click
        Dim sNum As String = Me.ActiveControl.Name.Substring(3)
        MsgBox("A button " & sNum & " was clicked")



    End Sub
End Class
