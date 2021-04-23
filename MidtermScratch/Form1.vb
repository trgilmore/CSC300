Public Class Form1



    Function calcSumProduct(A As Double, B As Double, C As Double) As Double
        Return ((A * B) + (B * C) + (C * A))
    End Function

    Private Function random()
        Dim random1 As Double = Rnd()
        Return random1
    End Function
    Function calcCV(i As Integer) As Double
        If (i Mod 2 = 0) Then
            Return (i / 2)
        Else
            Return (i * 3 + 1)
        End If
    End Function

    Const H As Double = 6.62607015E-34
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = calcSumProduct(1, 2, 3)
        Label2.Text = CStr(random())
        Label3.Text = calcCV(5)
        Dim strMsg As String = ""

        For i = 1 To 10

            If i Mod 3 = 0 Then

                strMsg &= i & ","

            End If

        Next

        MsgBox(strMsg)
    End Sub
    Private Sub resetFields()
        txtName.Text = ""
        txtAge.Text = ""
        txtCity.Text = ""
        lstDetails.Items.Clear()
    End Sub
End Class
