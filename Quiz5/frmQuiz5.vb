Public Class frmQuiz5

    Private Sub btnAddStick_Click(sender As Object, e As EventArgs) Handles btnAddStick.Click
        Dim stick As MemoryStick = New MemoryStick(txtColor.Text, txtCapacity.Text, txtLabel.Text)
        lstMemory.Items.Add(stick.ToString)
    End Sub
End Class
