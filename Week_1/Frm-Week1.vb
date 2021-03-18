Public Class Form1
    Public Property Red As Color

    Private Sub btnHelloWorld_Click(sender As Object, e As EventArgs) Handles btnHelloWorld.Click
        btnHelloWorld.Text = "Thanks for Clicking!"
        btnHelloWorld.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        TextBox1.ForeColor = Red
    End Sub

End Class
