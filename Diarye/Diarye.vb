Imports System.IO

Public Class frmDiaryeMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNewStarter.Click
        frmStarter.ShowDialog()
    End Sub

    Private Sub btnNewRecipe_Click(sender As Object, e As EventArgs) Handles btnNewRecipe.Click
        frmRecipes.ShowDialog()
    End Sub

    Private Sub frmDiaryeMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInfo()
    End Sub

    Private Sub btnDeleteStarter_Click(sender As Object, e As EventArgs) Handles btnViewStarters.Click
        Process.Start("Notepad", "C:\Users\tgilm\source\repos\Diarye\data\Starters.txt")
    End Sub

    Private Sub btnBake_Click(sender As Object, e As EventArgs) Handles btnBake.Click
        frmBakeLog.txtBakeStarter.Text = lstStarterNames.SelectedItem
        frmBakeLog.txtBakeRecipe.Text = lstRecipeTitles.SelectedItem
        frmBakeLog.ShowDialog()
    End Sub

    Private Sub btnViewLog_Click(sender As Object, e As EventArgs) Handles btnViewLog.Click
        Process.Start("Notepad", "C:\Users\tgilm\source\repos\Diarye\data\BakeLog.txt")
    End Sub

    Private Sub btnViewRecipes_Click(sender As Object, e As EventArgs) Handles btnViewRecipes.Click
        Process.Start("Notepad", "C:\Users\tgilm\source\repos\Diarye\data\Recipes.txt")
    End Sub

    Public Sub LoadInfo()
        Dim fileReader As System.IO.StreamReader
        fileReader =
        My.Computer.FileSystem.OpenTextFileReader("C:\Users\tgilm\source\repos\Diarye\data\Starters.txt")
        Dim stringReader As String()

        Using fileReader
            Do While fileReader.Peek <> -1
                stringReader = fileReader.ReadLine.Split(":")
                If (stringReader.Contains("Name")) Then
                    lstStarterNames.Items.Add(stringReader.ElementAt(1))
                End If
            Loop
        End Using

        Dim RecipeReader As System.IO.StreamReader
        RecipeReader =
        My.Computer.FileSystem.OpenTextFileReader("C:\Users\tgilm\source\repos\Diarye\data\Recipes.txt")

        Using RecipeReader
            Do While RecipeReader.Peek <> -1
                stringReader = RecipeReader.ReadLine.Split(":")
                If (stringReader.Contains("Title")) Then
                    lstRecipeTitles.Items.Add(stringReader.ElementAt(1))
                End If
            Loop
        End Using
    End Sub
End Class