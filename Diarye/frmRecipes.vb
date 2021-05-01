Public Class frmRecipes
    Private Sub btnRecipeCancel_Click(sender As Object, e As EventArgs) Handles btnRecipeCancel.Click
        Me.Hide()
    End Sub

    Private Sub frmRecipes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using MyReader As New Microsoft.VisualBasic.
              FileIO.TextFieldParser(
                "C:\Users\tgilm\source\repos\Diarye\data\Flours.txt")
            MyReader.SetFieldWidths(-1)
            MyReader.TextFieldType = FileIO.FieldType.FixedWidth
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow
                        lstRecipeFlours.Items.Add(currentField)
                    Next
                Catch ex As Microsoft.VisualBasic.
                            FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                End Try
            End While
        End Using
    End Sub
End Class