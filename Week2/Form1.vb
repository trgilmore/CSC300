Public Class frmWeek2
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        Dim strUndef As String = ""
        lstlog.Items.Add(strUndef.Length.ToString)

        Dim strResult As String = ""
        Dim i As Integer = 1500
        strResult = "My dog has " & i & " fleas"
        lstlog.Items.Add(strResult)

        Dim strExer As String = "Klaatu"
        strExer &= " Barada Nikto"



    End Sub

End Class
