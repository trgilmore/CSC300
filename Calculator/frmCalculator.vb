Public Class frmCalculator
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBox.Text = 0
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If (txtBox.Text = 0) Then
            txtBox.Text = "1"
        Else
            txtBox.Text = txtBox.Text & "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If (txtBox.Text = 0) Then
            txtBox.Text = "2"
        Else
            txtBox.Text = txtBox.Text & "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If (txtBox.Text = 0) Then
            txtBox.Text = "3"
        Else
            txtBox.Text = txtBox.Text & "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If (txtBox.Text = 0) Then
            txtBox.Text = "4"
        Else
            txtBox.Text = txtBox.Text & "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtBox.Text = If((txtBox.Text = 0), "5", txtBox.Text & "5")
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If (txtBox.Text = 0) Then
            txtBox.Text = "6"
        Else
            txtBox.Text = txtBox.Text & "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If (txtBox.Text = 0) Then
            txtBox.Text = "7"
        Else
            txtBox.Text = txtBox.Text & "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If (txtBox.Text = 0) Then
            txtBox.Text = "8"
        Else
            txtBox.Text = txtBox.Text & "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If (txtBox.Text = 0) Then
            txtBox.Text = "9"
        Else
            txtBox.Text = txtBox.Text & "9"
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If (txtBox.Text = 0) Then
            txtBox.Text = "0"
        Else
            txtBox.Text = txtBox.Text & "0"
        End If
    End Sub

    Private Sub btn00_Click(sender As Object, e As EventArgs) Handles btn00.Click
        txtBox.Text = txtBox.Text & ".00"
    End Sub

    Private Sub btnDec_Click(sender As Object, e As EventArgs) Handles btnDec.Click
        txtBox.Text = txtBox.Text & "."
    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        txtBox.Text = 0
    End Sub

    Private Sub btnOff_Click(sender As Object, e As EventArgs) Handles btnOff.Click
        txtBox.Text = ""
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        If (txtBox.Text = 0) Then
            txtBox.Text = "0"
        Else
            txtBox.Text = txtBox.Text & "+"
        End If
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        If (txtBox.Text = 0) Then
            txtBox.Text = "0"
        Else
            txtBox.Text = txtBox.Text & "-"
        End If
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        If (txtBox.Text = 0) Then
            txtBox.Text = "0"
        Else
            txtBox.Text = txtBox.Text & "x"
        End If
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        If (txtBox.Text = 0) Then
            txtBox.Text = "0"
        Else
            txtBox.Text = txtBox.Text & "/"
        End If
    End Sub
End Class
