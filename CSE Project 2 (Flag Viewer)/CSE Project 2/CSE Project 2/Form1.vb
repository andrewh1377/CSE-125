'Andrew Hedy
'Flag Viewer
'January 2015
'Tuesday Lab

'Displays flags and names of different countries once a radio button is checked. Also makes title, programmer, and country label visible when each check box is checked. 

Public Class Form1


    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        'Ends the program
        End
    End Sub

    Private Sub ProgrammerCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ProgrammerCheckBox.CheckedChanged
        'Displays programmer when checked
        ProgrammerLabel.Visible = ProgrammerCheckBox.Checked
    End Sub

    Private Sub TitleCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles TitleCheckBox.CheckedChanged
        'Displays title label when checked
        TitleLabel.Visible = TitleCheckBox.Checked
    End Sub

    Private Sub CountryCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CountryCheckBox.CheckedChanged
        'Displays country label when checked
        CountryLabel.Visible = CountryCheckBox.Checked
    End Sub

    Private Sub USRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles USRadioButton.CheckedChanged
        'Displays United States when checked
        CountryLabel.Text = "United States"
        CountryPictureBox.Image = My.Resources.United_States_Flag
    End Sub

    Private Sub JapanRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles JapanRadioButton.CheckedChanged
        'Displays Japan when checked
        CountryLabel.Text = "Japan"
        CountryPictureBox.Image = My.Resources.Japan_Flag
    End Sub

    Private Sub CanadaRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CanadaRadioButton.CheckedChanged
        'Displays Canada when checked
        CountryLabel.Text = "Canada"
        CountryPictureBox.Image = My.Resources.Canada_Flag
    End Sub

    Private Sub MexicoRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles MexicoRadioButton.CheckedChanged
        'Displays Mexico when checked
        CountryLabel.Text = "Mexico"
        CountryPictureBox.Image = My.Resources.Mexico_Flag
    End Sub

    Private Sub PrintButton_Click(sender As System.Object, e As System.EventArgs) Handles PrintButton.Click
        'Displays print preview of program and prints program
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub
End Class
