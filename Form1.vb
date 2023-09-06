Public Class Form1
    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        'Declare necessary  variables
        Dim Price As Decimal
        Dim Quantity As Decimal
        Dim Total As Decimal
        Dim NameOfCustomer As String

        'Get the amounts from the textboxes
        Price = txtPrice.Text
        Quantity = txtQuantity.Text
        NameOfCustomer = txtNameOfCustomer.Text
        'Calculate the total
        Total = Price * Quantity

        'Print the message on the screen
        MsgBox("Hi " & NameOfCustomer & " Your total is R" & Total)

    End Sub
End Class
