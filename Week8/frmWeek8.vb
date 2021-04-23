Public Class frmWeek8
    Private Sub btnDemoArray_Click(sender As Object, e As EventArgs) Handles btnDemoArray.Click
        Dim aListComputers As ArrayList = New ArrayList
        aListComputers.Add("Test 1")
        aListComputers.Add("another test")

        '''
        Dim sBrands As String = "dell, hp, lenovo, apple, asus, acer"
        Dim aBrandArray() As String = sBrands.Split(",")
        For Each brand In aBrandArray
            aListComputers.Add(brand)
        Next
        For Each computer In aListComputers
            lstDetails.Items.Add(computer)
        Next



        'MsgBox(aListComputers.Count)
    End Sub
End Class
