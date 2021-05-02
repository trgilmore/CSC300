Public Class frmRecipes

    Dim tfw As Integer = 0
    Dim tdw As Integer = 0
    Dim tsw As Integer = 0
    Dim tww As Integer = 0
    Dim tlw As Integer = 0
    Dim taw As Integer = 0
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

    Private Sub btnAddFlourToRecipe_Click(sender As Object, e As EventArgs) Handles btnAddFlourToRecipe.Click
        If lstRecipeFlours.SelectedIndex >= 0 Then
            lstFlourRecipe.Items.Add(lstRecipeFlours.SelectedItem & " -- " & nudRecipeFlourWeight.Text & "g")
            tfw += nudRecipeFlourWeight.Value
            tdw = tfw + tsw + tww + tlw + taw
            txtRecipeTotalDoughWeight.Text = CStr(tdw) & "g"
            txtRecipeTotalFlourWeight.Text = CStr(tfw) & "g"
        Else
            MsgBox("Please select a flour")
        End If
    End Sub

    Private Sub nudRecipeSaltWeight_ValueChanged(sender As Object, e As EventArgs) Handles nudRecipeSaltWeight.ValueChanged
        tsw = nudRecipeSaltWeight.Value
        tdw = tfw + tsw + tww + tlw + taw
        txtRecipeTotalDoughWeight.Text = CStr(tdw) & "g"
    End Sub

    Private Sub nudRecipeWaterWeight_ValueChanged(sender As Object, e As EventArgs) Handles nudRecipeWaterWeight.ValueChanged
        tww = nudRecipeWaterWeight.Value
        tdw = tfw + tsw + tww + tlw + taw
        txtRecipeTotalDoughWeight.Text = CStr(tdw) & "g"
        txtRecipeHydration.Text = CStr(Math.Round(((tww / tfw) * 100), 2)) & "%"
    End Sub

    Private Sub nudRecipeLevainWeight_ValueChanged(sender As Object, e As EventArgs) Handles nudRecipeLevainWeight.ValueChanged
        tlw = nudRecipeLevainWeight.Value
        tdw = tfw + tsw + tww + tlw + taw
        txtRecipeTotalDoughWeight.Text = CStr(tdw) & "g"
        txtRecipeLevainPercent.Text = CStr(Math.Round(((tlw / tfw) * 100), 2)) & "%"
    End Sub

    Private Sub chkRecipeAddition1_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecipeAddition1.CheckedChanged
        If chkRecipeAddition1.Checked = True Then
            txtRecipeAddition1.Enabled = True
            lblRecipeAddition1Weight.Enabled = True
            nudRecipeAdditionWeight1.Enabled = True
        Else
            txtRecipeAddition1.Enabled = False
            lblRecipeAddition1Weight.Enabled = False
            nudRecipeAdditionWeight1.Enabled = False
        End If
    End Sub

    Private Sub chkRecipeAddition2_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecipeAddition2.CheckedChanged
        If chkRecipeAddition2.Checked = True Then
            txtRecipeAddition2.Enabled = True
            lblRecipeAddition2Weight.Enabled = True
            nudRecipeAdditionWeight2.Enabled = True
        Else
            txtRecipeAddition2.Enabled = False
            lblRecipeAddition2Weight.Enabled = False
            nudRecipeAdditionWeight2.Enabled = False
        End If
    End Sub
    Private Sub chkRecipeAddition3_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecipeAddition3.CheckedChanged
        If chkRecipeAddition3.Checked = True Then
            txtRecipeAddition3.Enabled = True
            lblRecipeAddition3Weight.Enabled = True
            nudRecipeAdditionWeight3.Enabled = True
        Else
            txtRecipeAddition3.Enabled = False
            lblRecipeAddition3Weight.Enabled = False
            nudRecipeAdditionWeight3.Enabled = False
        End If
    End Sub
    Private Sub chkRecipeAddition4_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecipeAddition4.CheckedChanged
        If chkRecipeAddition4.Checked = True Then
            txtRecipeAddition4.Enabled = True
            lblRecipeAddition4Weight.Enabled = True
            nudRecipeAdditionWeight4.Enabled = True
        Else
            txtRecipeAddition4.Enabled = False
            lblRecipeAddition4Weight.Enabled = False
            nudRecipeAdditionWeight4.Enabled = False
        End If
    End Sub

    Private Sub nudRecipeAdditionWeight1_ValueChanged(sender As Object, e As EventArgs) Handles nudRecipeAdditionWeight1.ValueChanged
        taw = nudRecipeAdditionWeight1.Value + nudRecipeAdditionWeight2.Value + nudRecipeAdditionWeight3.Value + nudRecipeAdditionWeight4.Value
        tdw = tfw + tsw + tww + tlw + taw
        txtRecipeTotalDoughWeight.Text = CStr(tdw) & "g"
    End Sub
    Private Sub nudRecipeAdditionWeight2_ValueChanged(sender As Object, e As EventArgs) Handles nudRecipeAdditionWeight2.ValueChanged
        taw = nudRecipeAdditionWeight1.Value + nudRecipeAdditionWeight2.Value + nudRecipeAdditionWeight3.Value + nudRecipeAdditionWeight4.Value
        tdw = tfw + tsw + tww + tlw + taw
        txtRecipeTotalDoughWeight.Text = CStr(tdw) & "g"
    End Sub
    Private Sub nudRecipeAdditionWeight3_ValueChanged(sender As Object, e As EventArgs) Handles nudRecipeAdditionWeight3.ValueChanged
        taw = nudRecipeAdditionWeight1.Value + nudRecipeAdditionWeight2.Value + nudRecipeAdditionWeight3.Value + nudRecipeAdditionWeight4.Value
        tdw = tfw + tsw + tww + tlw + taw
        txtRecipeTotalDoughWeight.Text = CStr(tdw) & "g"
    End Sub
    Private Sub nudRecipeAdditionWeight4_ValueChanged(sender As Object, e As EventArgs) Handles nudRecipeAdditionWeight4.ValueChanged
        taw = nudRecipeAdditionWeight1.Value + nudRecipeAdditionWeight2.Value + nudRecipeAdditionWeight3.Value + nudRecipeAdditionWeight4.Value
        tdw = tfw + tsw + tww + tlw + taw
        txtRecipeTotalDoughWeight.Text = CStr(tdw) & "g"
    End Sub

    Private Sub ClearForm()
        tdw = 0
        tfw = 0
        tsw = 0
        tww = 0
        tlw = 0
        taw = 0
        txtRecipeTitle.Text = ""
        nudRecipeFlourWeight.Value = 0
        lstFlourRecipe.Items.Clear()
        nudRecipeSaltWeight.Value = 0
        nudRecipeWaterWeight.Value = 0
        nudRecipeLevainWeight.Value = 0
        chkRecipeAddition1.Checked = False
        txtRecipeAddition1.Text = ""
        nudRecipeAdditionWeight1.Value = 0
        chkRecipeAddition2.Checked = False
        txtRecipeAddition2.Text = ""
        nudRecipeAdditionWeight2.Value = 0
        chkRecipeAddition3.Checked = False
        txtRecipeAddition3.Text = ""
        nudRecipeAdditionWeight3.Value = 0
        chkRecipeAddition4.Checked = False
        txtRecipeAddition4.Text = ""
        nudRecipeAdditionWeight4.Value = 0
        txtRecipeTotalDoughWeight.Text = ""
        txtRecipeTotalFlourWeight.Text = ""
        txtRecipeHydration.Text = ""
        txtRecipeLevainPercent.Text = ""
    End Sub

    Private Sub btnRecipeClear_Click(sender As Object, e As EventArgs) Handles btnRecipeClear.Click
        ClearForm()
    End Sub
End Class