Public Class frmWeek4
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        txtAnswer.Text = calcProduct(CDbl(txtInput1.Text), CDbl(txtInput2.Text))
        populateListBox(CDbl(txtInput1.Text), CDbl(txtInput2.Text))
        lstTape.Items.Add(solveForY(CDbl(txtInput1.Text)))
    End Sub

    Sub populateListBox(d1 As Double, d2 As Double)
        Dim sMsg As String = ""
        Dim dAnswer As Double

        dAnswer = d1 * d2
        sMsg = d1 & " * " & d2 & " = " & dAnswer
        lstTape.Items.Add(sMsg)


        dAnswer = d1 / d2
        sMsg = d1 & " / " & d2 & " = " & dAnswer
        lstTape.Items.Add(sMsg)


        dAnswer = d1 + d2
        sMsg = d1 & " + " & d2 & " = " & dAnswer
        lstTape.Items.Add(sMsg)


        dAnswer = d1 - d2
        sMsg = d1 & " - " & d2 & " = " & dAnswer
        lstTape.Items.Add(sMsg)

        txtAnswer.Text = "Finished"



    End Sub
    Function calcProduct(dNum1 As Double, dNum2 As Double) As Double
        Return (dNum1 * dNum2)
    End Function

    Function solveForY(X As Double) As Double
        Return ((3 * (X * X) - 2 * X + 1) / Math.Sqrt(X - 1))
    End Function

End Class
