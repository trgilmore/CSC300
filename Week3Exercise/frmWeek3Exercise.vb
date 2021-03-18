Public Class frmWeek3Exercise
    Private Sub btnPop_Click(sender As Object, e As EventArgs) Handles btnPop.Click
        Dim sMsg As String = cboSalutation.Text & " " & txtFirst.Text & " " & " " & txtLast.Text & " of " & cboCitizen.Text & " with " & lstEdu.Text
        MsgBox(sMsg)

    End Sub
End Class
