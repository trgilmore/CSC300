Public Class frmStarter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim str(3) As String

        Dim itm As ListViewItem

        str(0) = "Rob Machy"

        str(1) = dtp1.Value.Date

        str(2) = "Business Manager"


        itm = New ListViewItem(str)

        frmDiaryeMain.ListView1.Items.Insert(0, itm)

        Me.Hide()
    End Sub
End Class