Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim strBeatles(3) As String

        strBeatles(0) = "John"
        strBeatles(1) = "Paul"
        strBeatles(2) = "George"
        strBeatles(3) = "Ringo"


        Dim strSisters() As String
        Dim count As Integer = 5
        ReDim strSisters(count)

        Dim strBrothers() As String = "Randy,Jimmy".Split(",")
        For beatle = 0 To 1
            ListBox1.Items.Add(strBrothers(beatle))
        Next


    End Sub
End Class
