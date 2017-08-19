'Andrew Hedy
'Company Contact Information
'January 2015
'Tuesday Lab


'Displays company contact information, clears company contact information, prints form, and exits program


Public Class Form1


    Private Sub ClearButton_Click(sender As System.Object, e As System.EventArgs) Handles ClearButton.Click
        'Clears the name and phone number labels
        NameLabel.Text = ""
        PhoneNumberLabel.Text = ""
    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        'Ends the program
        End
    End Sub

    Private Sub CRButton_Click(sender As System.Object, e As System.EventArgs) Handles CRButton.Click
        'Displays contact information for Customer Relations
        NameLabel.Text = "Tricia Mills"
        PhoneNumberLabel.Text = "500-1111"
    End Sub

    Private Sub MarketingButton_Click(sender As System.Object, e As System.EventArgs) Handles MarketingButton.Click
        'Displays contact information for marketing
        NameLabel.Text = "Michelle Rigner"
        PhoneNumberLabel.Text = "500-2222"
    End Sub

    Private Sub OPButton_Click(sender As System.Object, e As System.EventArgs) Handles OPButton.Click
        'Displays contact information for Order Processing
        NameLabel.Text = "Kenna DeVoss"
        PhoneNumberLabel.Text = "500-3333"
    End Sub

    Private Sub ShippingButton_Click(sender As System.Object, e As System.EventArgs) Handles ShippingButton.Click
        'Displays contact information for Shipping
        NameLabel.Text = "Eric Andrews"
        PhoneNumberLabel.Text = "500-4444"
    End Sub

    Private Sub PrintButton_Click(sender As System.Object, e As System.EventArgs) Handles PrintButton.Click
        'Displays print preview of program and prints
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub

End Class
