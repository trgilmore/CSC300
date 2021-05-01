
Public Class frmStarter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSaveStarter.Click
        Dim starter1 As New Starter
        starter1.Name = txtStarterName.Text
        For Each flour In lstFeedingRecipe.Items
            starter1.FeedingRecipe.Add(flour)
        Next
        starter1.StarterWeight = CInt(nudStarterWeight.Text)
        starter1.FlourWeight = CInt(nudStarterFlourWeight.Text)
        starter1.WaterWeight = CInt(nudStarterWaterWeight.Text)
        starter1.Schedule = CInt(txtFeedingSchedule.Text)
        starter1.CreationDate = dtpCreationDate.Value.Date
        If chkHibernation.Checked = True Then
            starter1.Hibernation = True
            If rbDry.Checked = True Then
                starter1.HibernationType = rbDry.Text
            ElseIf rbFridge.Checked = True Then
                starter1.HibernationType = rbFridge.Text
            ElseIf rbFreezer.Checked = True Then
                starter1.HibernationType = rbFreezer.Text
            Else
                starter1.HibernationType = ""
            End If
        Else
            starter1.Hibernation = False
            starter1.HibernationType = ""
        End If
        starter1.AmbientTemp = CInt(txtAmbTemp.Text)
        starter1.AmbientHumidity = CInt(txtAmbHumidity.Text)


        Dim str(11) As String
        Dim itm As ListViewItem

        str(0) = txtStarterName.Text
        str(1) = dtpCreationDate.Value.Date
        str(2) = "Business Manager"


        itm = New ListViewItem(str)

        frmDiaryeMain.lstvStarters.Items.Insert(0, itm)
        My.Computer.FileSystem.WriteAllText("C:\Users\tgilm\source\repos\Diarye\data\Starters.txt",
        starter1.ToString(), True)

        'starter1.Save()
        clearForm()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkHibernation.CheckedChanged
        If chkHibernation.Checked = True Then
            rbDry.Enabled = True
            rbFridge.Enabled = True
            rbFreezer.Enabled = True
        Else
            rbDry.Enabled = False
            rbFridge.Enabled = False
            rbFreezer.Enabled = False
            rbDry.Checked = False
            rbFridge.Checked = False
            rbFreezer.Checked = False
        End If
    End Sub

    Private Sub btnCancelStarter_Click(sender As Object, e As EventArgs) Handles btnCancelStarter.Click
        Me.Hide()
    End Sub

    Private Sub btnAddToFeedingRecipe_Click(sender As Object, e As EventArgs) Handles btnAddToFeedingRecipe.Click
        lstFeedingRecipe.Items.Add(lstStarterRecipeFlour.SelectedItem & " -- " & txtStarterRecipeFlourPercent.Text & "%")
    End Sub

    Private Sub calcRatio()
        Dim s As Double = nudStarterWeight.Value
        Dim w As Double = nudStarterWaterWeight.Value
        Dim f As Double = nudStarterFlourWeight.Value
        Dim low As Double = 1
        If s <= w And s <= f Then
            txtStarterRatio.Text = low
            txtStarterWaterRatio.Text = w / s
            txtStarterFlourRatio.Text = f / s
        ElseIf w <= f Then
            txtStarterWaterRatio.Text = low
            txtStarterRatio.Text = s / w
            txtStarterFlourRatio.Text = f / w
        Else
            txtStarterFlourRatio.Text = low
            txtStarterRatio.Text = s / f
            txtStarterWaterRatio.Text = w / f
        End If

    End Sub

    Private Sub frmStarter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                        lstStarterRecipeFlour.Items.Add(currentField)
                    Next
                Catch ex As Microsoft.VisualBasic.
                            FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                End Try
            End While
        End Using

    End Sub

    Private Sub nudStarterWeight_ValueChanged(sender As Object, e As EventArgs) Handles nudStarterWeight.ValueChanged, nudStarterWaterWeight.ValueChanged, nudStarterFlourWeight.ValueChanged
        calcRatio()
    End Sub

    Private Sub chkAmbTemp_CheckedChanged(sender As Object, e As EventArgs) Handles chkAmbTemp.CheckedChanged
        If chkAmbTemp.Checked = True Then
            txtAmbTemp.Enabled = True
        Else
            txtAmbTemp.Enabled = False
            txtAmbTemp.Text = 0
        End If
    End Sub

    Private Sub chkAmbHumidity_CheckedChanged(sender As Object, e As EventArgs) Handles chkAmbHumidity.CheckedChanged
        If chkAmbHumidity.Checked = True Then
            txtAmbHumidity.Enabled = True
        Else
            txtAmbHumidity.Enabled = False
            txtAmbHumidity.Text = 0
        End If
    End Sub
    Private Sub clearForm()
        txtStarterName.Text = ""
        txtStarterRecipeFlourPercent.Text = 100
        lstFeedingRecipe.Items.Clear()
        nudStarterFlourWeight.Value = 0
        nudStarterWaterWeight.Value = 0
        nudStarterWeight.Value = 0
        txtStarterRatio.Text = "1"
        txtStarterWaterRatio.Text = "1"
        txtStarterFlourRatio.Text = "1"
        txtFeedingSchedule.Text = ""
        dtpCreationDate.Value = Today
        chkHibernation.Checked = False
        chkAmbTemp.Checked = False
        chkAmbHumidity.Checked = False

    End Sub

    Private Sub btnClearStarter_Click(sender As Object, e As EventArgs) Handles btnClearStarter.Click
        clearForm()
    End Sub
End Class