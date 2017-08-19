'Andrew Hedy
'Project 7
'March 2015
'Tuesday Lab

'Displays the selected book information on a print document 

Public Class Form1
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        'Ends the program
        End

    End Sub
    Private Sub PrintSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSubjectToolStripMenuItem.Click

        'Shows print preview dialog 
        PrintPreviewDialog1.Document = PrintSelectedPrintDocument
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintSelectedPrintDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintSelectedPrintDocument.PrintPage

        'Dementioning Local Variables
        Dim PrintFont As New Font("Times New Roman", 12)
        Dim HeadingFont As New Font("Times New Roman", 16, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizantalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim HorizantalPrintLocationSingle2 As Single = 300
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim VerticalPrintLocationSingle2 As Single = e.MarginBounds.Bottom
        Dim PrintLineString As String
        Dim ListIndexInteger As Integer

        'Displays the title in the correct location
        PrintLineString = "Reading 'n Refreshment"
        e.Graphics.DrawString(PrintLineString, HeadingFont,
                              Brushes.Black, HorizantalPrintLocationSingle2, VerticalPrintLocationSingle)

        'Places a space between two line strings
        VerticalPrintLocationSingle = VerticalPrintLocationSingle + LineHeightSingle * 2

        'Displays title for subjects
        PrintLineString = "Selected Subject"
        e.Graphics.DrawString(PrintLineString, HeadingFont,
                              Brushes.Black, HorizantalPrintLocationSingle, VerticalPrintLocationSingle)

        'Places a space between two line strings
        VerticalPrintLocationSingle = VerticalPrintLocationSingle + LineHeightSingle * 2

        'Selects all items from combo box
        For ListIndexInteger = 0 To SubjectComboBox.Items.Count - 1

            'Displays selected items on print preview page
            PrintLineString = SubjectComboBox.Items(ListIndexInteger)
            e.Graphics.DrawString(PrintLineString, PrintFont,
                             Brushes.Black, HorizantalPrintLocationSingle, VerticalPrintLocationSingle)
            'Spaces all subjects
            VerticalPrintLocationSingle = VerticalPrintLocationSingle + LineHeightSingle
        Next

        'Displays programmer at bottom of page
        PrintLineString = "Programmed by Andrew Hedy"
        e.Graphics.DrawString(PrintLineString, HeadingFont,
                             Brushes.Black, HorizantalPrintLocationSingle, VerticalPrintLocationSingle2)
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click

        'Prints a screenshot of the program
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub
    Private Sub PrintBookInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBookInfoToolStripMenuItem.Click

        'Displays a print preview of selected items 
        PrintPreviewDialog1.Document = BookInfoPrintDocument
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub BookInfoPrintDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles BookInfoPrintDocument.PrintPage

        'Dementioning local variables
        Dim PrintFont As New Font("Times New Roman", 12)
        Dim HeadingFont As New Font("Times New Roman", 16, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizantalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim HorizantalPrintLocationSingle2 As Single = 300
        Dim HorizantalPrintLocationSingle3 As Single = 225
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim VerticalPrintLocationSingle2 As Single = e.MarginBounds.Bottom
        Dim PrintLineString As String

        'Displays and places the title in the correct location on the page
        PrintLineString = "Reading 'n Refreshment"
        e.Graphics.DrawString(PrintLineString, HeadingFont,
                              Brushes.Black, HorizantalPrintLocationSingle2, VerticalPrintLocationSingle)

        'Places a space between two objects
        VerticalPrintLocationSingle = VerticalPrintLocationSingle + LineHeightSingle * 2

        'Displays and places book information in the correct location on the page
        PrintLineString = "Book Information"
        e.Graphics.DrawString(PrintLineString, HeadingFont,
                              Brushes.Black, HorizantalPrintLocationSingle, VerticalPrintLocationSingle)

        'Places a space between two objects
        VerticalPrintLocationSingle = VerticalPrintLocationSingle + LineHeightSingle * 2

        'Displays and places author in correct location on page
        PrintLineString = "Author:"
        e.Graphics.DrawString(PrintLineString, PrintFont,
                              Brushes.Black, HorizantalPrintLocationSingle, VerticalPrintLocationSingle)

        'Displays and places the selected author in the correct location on page
        PrintLineString = String.Copy(AuthorTextBox.Text)
        e.Graphics.DrawString(PrintLineString, PrintFont,
                             Brushes.Black, HorizantalPrintLocationSingle3, VerticalPrintLocationSingle)

        'Places space between two objects on page
        VerticalPrintLocationSingle = VerticalPrintLocationSingle + LineHeightSingle * 2

        'Display and places title in correct location on the page
        PrintLineString = "Title:"
        e.Graphics.DrawString(PrintLineString, PrintFont,
                              Brushes.Black, HorizantalPrintLocationSingle, VerticalPrintLocationSingle)

        'Displays and places the title of the book in the correct place on the page
        PrintLineString = String.Copy(TitleTextBox.Text)
        e.Graphics.DrawString(PrintLineString, PrintFont,
                            Brushes.Black, HorizantalPrintLocationSingle3, VerticalPrintLocationSingle)

        'Places a space between two objects
        VerticalPrintLocationSingle = VerticalPrintLocationSingle + LineHeightSingle * 2

        'Displays and places the type in correct place on page
        PrintLineString = "Type:"
        e.Graphics.DrawString(PrintLineString, PrintFont,
                               Brushes.Black, HorizantalPrintLocationSingle, VerticalPrintLocationSingle)

        'Displays correct radio button and places selection in correct place on page
        If FictionRadioButton.Checked = True Then
            PrintLineString = "Fiction"
        ElseIf NonFictionRadioButton.Checked = True Then
            PrintLineString = "Non-Fiction"
        End If
        e.Graphics.DrawString(PrintLineString, PrintFont,
                              Brushes.Black, HorizantalPrintLocationSingle3, VerticalPrintLocationSingle)

        'Places a space between two objects on page
        VerticalPrintLocationSingle = VerticalPrintLocationSingle + LineHeightSingle * 2

        'Displays and places shelf number in correct place on on page
        PrintLineString = "Shelf Number:"
        e.Graphics.DrawString(PrintLineString, PrintFont,
                              Brushes.Black, HorizantalPrintLocationSingle, VerticalPrintLocationSingle)

        'Displays and placed selected shelf number in the correct place on page
        PrintLineString = ShelfNumberListBox.Text
        e.Graphics.DrawString(PrintLineString, PrintFont,
                              Brushes.Black, HorizantalPrintLocationSingle3, VerticalPrintLocationSingle)

        'Places a space between two objects
        VerticalPrintLocationSingle = VerticalPrintLocationSingle + LineHeightSingle * 2

        'Displays and places the word "subject" in the correct place on page
        PrintLineString = "Subject:"
        e.Graphics.DrawString(PrintLineString, PrintFont,
                             Brushes.Black, HorizantalPrintLocationSingle, VerticalPrintLocationSingle)

        'Displays and places the selected subject in the correct place on page
        PrintLineString = SubjectComboBox.Text
        e.Graphics.DrawString(PrintLineString, PrintFont,
                              Brushes.Black, HorizantalPrintLocationSingle3, VerticalPrintLocationSingle)

        'Displays the progammer at the bottom of the page
        PrintLineString = "Programmed by Andrew Hedy"
        e.Graphics.DrawString(PrintLineString, HeadingFont,
                             Brushes.Black, HorizantalPrintLocationSingle, VerticalPrintLocationSingle2)
    End Sub
    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click

        'Exits the program
        End

    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        Dim MessageString As String
        Dim ReturnDialogResult As DialogResult
        'Opens yes/no dialog box and if yes is selected than data is cleared
        MessageString = "Are you sure you want to clear the current data?"
        ReturnDialogResult = MessageBox.Show(MessageString, "Clear Order", MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ReturnDialogResult = Windows.Forms.DialogResult.Yes Then

            'Clears the program
            AuthorTextBox.Text = ""
            TitleTextBox.Text = ""
            FictionRadioButton.Checked = False
            NonFictionRadioButton.Checked = False
            ShelfNumberListBox.SelectedIndex = -1
            SubjectComboBox.SelectedIndex = -1
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        'Displays about box and hides the main form
        AboutBox1.Show()
        Me.Hide()

    End Sub
End Class

