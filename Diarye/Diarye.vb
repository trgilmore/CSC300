
Imports System.IO
Imports System.Xml.Serialization

Public Class frmDiaryeMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNewStarter.Click
        frmStarter.ShowDialog()
    End Sub

    Private Sub btnNewRecipe_Click(sender As Object, e As EventArgs) Handles btnNewRecipe.Click
        frmRecipes.ShowDialog()
    End Sub

    Private Sub frmDiaryeMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(Starter))
        'Dim file As New System.IO.StreamReader(
        '    "C:\Users\tgilm\source\repos\Diarye\data\Starters.xml")
        'Dim overview As Starter
        'overview = CType(reader.Deserialize(file), Starter)
        'file.Close()
    End Sub

    Private Sub btnDeleteStarter_Click(sender As Object, e As EventArgs) Handles btnDeleteStarter.Click
        lstvStarters.Items.RemoveAt(lstvStarters.SelectedIndices(0))
    End Sub
End Class
