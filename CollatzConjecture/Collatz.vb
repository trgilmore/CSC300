Public Class frmCollatz

    Dim iterationsHeader1 As String = "Iterations  |       N"
    Dim iterationsHeader2 As String = "---------------|-----------"
    Dim topTwentyHeader1 As String = "Initial N  |    Iterations Needed"
    Dim topTwentyHeader2 As String = "------------|-----------"
    Function computeCollatz(initial As Integer) As Integer
        If (initial Mod 2 = 0) Then
            Return (initial / 2)
        Else
            Return (3 * initial + 1)
        End If
    End Function
    Function calcIterations(start As Integer) As Integer
        Dim passes As Integer = 0
        While (start > 1)
            start = computeCollatz(start)
            passes += 1
            lstIterations.Items.Add(passes & "---------------" & start)
        End While
        Return (passes)
    End Function
    Function calcTopTwenty(start As Integer) As Integer
        Dim passes As Integer = 0
        While (start > 1)
            start = computeCollatz(start)
            passes += 1
        End While
        Return (passes)
    End Function
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        lstIterations.Items.Clear()
        lblNext.Visible = True
        txtNext.Visible = True
        lblIterations.Visible = False
        txtIterations.Visible = False
        txtNext.Text = computeCollatz(txtInitial.Text)
    End Sub

    Private Sub btnCalculateIterations_Click(sender As Object, e As EventArgs) Handles btnCalculateIterations.Click
        lblNext.Visible = False
        txtNext.Visible = False
        lblIterations.Visible = True
        txtIterations.Visible = True
        lstIterations.Items.Clear()
        lstIterations.Items.Add(iterationsHeader1)
        lstIterations.Items.Add(iterationsHeader2)
        lstIterations.Items.Add("0" & "---------------" & txtInitial.Text)
        txtIterations.Text = calcIterations(txtInitial.Text)
    End Sub

    Private Sub btnTopTwenty_Click(sender As Object, e As EventArgs) Handles btnTopTwenty.Click
        lstIterations.Items.Clear()
        lstIterations.Items.Add(topTwentyHeader1)
        lstIterations.Items.Add(topTwentyHeader2)
        lblNext.Visible = False
        txtNext.Visible = False
        lblIterations.Visible = False
        txtIterations.Visible = False
        txtInitial.Text = ""
        For i = 1 To 20
            lstIterations.Items.Add(i & "---------------" & calcTopTwenty(i))
        Next
    End Sub
End Class
