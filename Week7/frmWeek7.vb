Public Class frmWeek7
    Dim die1 As Die = New Die(20)

    Dim allCustomers As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)
    Private Sub btnShowCustomer_Click(sender As Object, e As EventArgs) Handles btnShowCustomer.Click

        Dim cust1 As Customer = New Customer
        cust1.ID = 1
        cust1.Name = "Clint Eastwood"
        'cust1.City = "Carmel"


    End Sub

    Private Sub btnCreateIn_Click(sender As Object, e As EventArgs) Handles btnCreateIn.Click
        Dim cust As Customer = New Customer
        cust.ID = CInt(txtId.Text)
        cust.Name = txtName.Text
        'cust.City = txtCity.Text
        allCustomers.Add(cust.ID, cust.toString)
        lstCustomers.Items.Add("Added to dictionary: " & cust.toString)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lstCustomers.Items.Clear()
        For Each value In allCustomers.Values
            lstCustomers.Items.Add(value)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Dim v As Integer
        'v = die1.Roll()
        lstCustomers.Items.Add(die1.Roll) 'or 

    End Sub
End Class
