'Andrew Hedy
'Final Project
'March 2015
'Tuesday Lab

'Calculates and displays the total due for a new car after trade in value of old vehicle and added accessories to new vehicle

Public Class InputSales

    'Declaring Modular Constants
    Dim AccessoriesTotalDecimal As Decimal
    Dim AccountTotalDecimal As Decimal
    Const StereoSystemDecimal As Decimal = 456.76
    Const LeatherInteriorDecimal As Decimal = 987.41
    Const NavigationDecimal As Decimal = 1741.23
    Const PearlizedDecimal As Decimal = 345.72
    Const CustomDecimal As Decimal = 599.99
    Const TaxRateDecimal As Decimal = 0.08

    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click

        'Dementioning Local Variables
        Dim TradeinDecimal As Decimal
        Dim BaseValueDecimal As Decimal
        Dim TaxDueDecimal As Decimal
        Dim AmountDueDecimal As Decimal
        Dim TotalDueDecimal As Decimal
        Dim SubTotalDueDecimal As Decimal
        Dim FinishTotalDecimal As Decimal
        Dim MessageString As String

        'Selects the correct output when user selects a radio button
        If PearlRadioButton.Checked = True Then
            FinishTotalDecimal = FinishTotalDecimal + PearlizedDecimal
        ElseIf CustomRadioButton.Checked = True Then
            FinishTotalDecimal = FinishTotalDecimal + CustomDecimal
        End If

        'Sums the correct output when user selects multiple checkboxes 
        If StereoCheckBox.Checked = True Then
            AccessoriesTotalDecimal = AccessoriesTotalDecimal + StereoSystemDecimal
        End If
        If InteriorCheckBox.Checked = True Then
            AccessoriesTotalDecimal = AccessoriesTotalDecimal + LeatherInteriorDecimal
        End If
        If NavigationCheckBox.Checked = True Then
            AccessoriesTotalDecimal = AccessoriesTotalDecimal + NavigationDecimal
        End If

        'Sets trade in value to zero if nothing was entered
        If TradeInTextBox.Text = "" Then
            TradeInTextBox.Text = 0
        End If
        'Convert input value into numeric value
        Try
            TradeinDecimal = Integer.Parse(TradeInTextBox.Text)
            BaseValueDecimal = Integer.Parse(BasePriceTextBox.Text)

            'Calculates total extras
            AccountTotalDecimal = AccessoriesTotalDecimal + FinishTotalDecimal

            'Calculates Subtotal Due
            SubTotalDueDecimal = BaseValueDecimal + AccountTotalDecimal

            'Calculates Tax
            TaxDueDecimal = SubTotalDueDecimal * TaxRateDecimal

            'Calculates total due before trade-in value
            TotalDueDecimal = TaxDueDecimal + SubTotalDueDecimal

            'Calculates the total amount due
            AmountDueDecimal = TotalDueDecimal - TradeinDecimal

            'Displays Values
            SubtotalLabel.Text = SubTotalDueDecimal.ToString("C")
            AmountDueLabel.Text = AmountDueDecimal.ToString("C")
            BasePriceTextBox.Text = BaseValueDecimal.ToString("C")
            TradeInTextBox.Text = TradeinDecimal.ToString("C")
            ExtrasLabel.Text = AccountTotalDecimal.ToString("C")
            SalesTaxLabel.Text = TaxDueDecimal.ToString("C")
            TotalLabel.Text = TotalDueDecimal.ToString("C")

            'Displays error message if there was no numeric value inputed in text box
        Catch BasePriceException As FormatException
            MessageString = Environment.NewLine & "Please enter a numeric value"
            MessageBox.Show(MessageString, "Error", MessageBoxButtons.OK, _
             MessageBoxIcon.Information)
            With BasePriceTextBox
                .Focus()
                .SelectAll()
            End With
        End Try
    End Sub
    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click

        'Dementioning local variables
        Dim ReturnDialogResult As DialogResult
        Dim MessageString As String

        'Opens yes/no dialog box and if yes is selected than data is cleared
        MessageString = "Are you sure you want to clear the current data?"
        ReturnDialogResult = MessageBox.Show(MessageString, "Clear Order", MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ReturnDialogResult = Windows.Forms.DialogResult.Yes Then
            SubtotalLabel.Text = ""
            AmountDueLabel.Text = ""
            TradeInTextBox.Text = ""
            BasePriceTextBox.Text = ""
            ExtrasLabel.Text = ""
            SalesTaxLabel.Text = ""
            TotalLabel.Text = ""
            AccessoriesTotalDecimal = 0
            AccountTotalDecimal = 0
            StandardRadioButton.Focus()
            BasePriceTextBox.Focus()
            StereoCheckBox.Checked = False
            InteriorCheckBox.Checked = False
            NavigationCheckBox.Checked = False
            StereoCheckBox.Font = Nothing
            InteriorCheckBox.Font = Nothing
            NavigationCheckBox.Font = Nothing
            StandardRadioButton.ForeColor = Nothing
            PearlRadioButton.ForeColor = Nothing
            CustomRadioButton.ForeColor = Nothing
        End If

    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FotToolStripMenuItem.Click

        'Changes the font of certain items in the program
        With FontDialog1
            .ShowDialog()
            StereoCheckBox.Font = .Font
            InteriorCheckBox.Font = .Font
            NavigationCheckBox.Font = .Font
        End With

    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click

        'Changes the color of the font of certain items in the program
        With ColorDialog1
            .ShowDialog()
            StandardRadioButton.ForeColor = .Color
            PearlRadioButton.ForeColor = .Color
            CustomRadioButton.ForeColor = .Color
        End With

    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        'Displays print preview dialog and allows user to print program
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub
    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click

        'Uses same code for clear button/clears the program
        Call ClearButton_Click(sender, e)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        'Dementioning local variable
        Dim messageString As String

        'Displays a message box describing the program
        messageString = "VB Auto Center" & Environment.NewLine & Environment.NewLine & "This program calculates the value of a new car with added upgrades and detailing. It will also include trade in value and taxes in total price" & Environment.NewLine & Environment.NewLine & "Programmed by Andrew Hedy"
        MessageBox.Show(messageString, "About VB Auto Center", MessageBoxButtons.OK, _
         MessageBoxIcon.Information)

    End Sub

    Private Sub AboutVBAutoCenter2015ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutVBAutoCenter2015ToolStripMenuItem.Click

        'Shows the about box for VB Auto Center
        AboutBox1.ShowDialog()

    End Sub

    Private Sub MainFormToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click

        'Shows Main Form
        MainForm.Show()
        Me.Hide()

    End Sub

    Private Sub CalculateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateToolStripMenuItem.Click

        'Uses the same code for the calculate button/calculates auto sales
        Call CalculateButton_Click(sender, e)

    End Sub

    Private Sub PrintInvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintInvoiceToolStripMenuItem.Click

        'Prints invoice of sale
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        'Dementioning local Variables
        Dim PrintFont As New Font("Times New Roman", 12)
        Dim HeadingFont As New Font("Times New Roman", 16, FontStyle.Bold)
        Dim FontSizeF As New SizeF
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizantalPrintLocationSingle As Single = 175
        Dim HorizantalPrintLocationSingle2 As Single = 270
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim VerticalPrintLocationSingle2 As Single = e.MarginBounds.Bottom
        Dim PrintLineString As String
        Dim FormattedPriceString As String
        Dim ColumnStart As Single

        'Displays Title on invoice
        PrintLineString = "Cost of Accessories and Finish"
        e.Graphics.DrawString(PrintLineString, HeadingFont,
                              Brushes.Black, HorizantalPrintLocationSingle2, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle = VerticalPrintLocationSingle + LineHeightSingle * 4

        'Displays "Cost of accessories selected" title
        PrintLineString = "Cost of Accessories Selected"
        e.Graphics.DrawString(PrintLineString, PrintFont,
                              Brushes.Black, HorizantalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle = VerticalPrintLocationSingle + LineHeightSingle * 2

        'Displays "stereo system" title
        PrintLineString = "Stereo System"
        e.Graphics.DrawString(PrintLineString, PrintFont,
                              Brushes.Black, HorizantalPrintLocationSingle, VerticalPrintLocationSingle)

        'Displays price for stereo system if checked
        If StereoCheckBox.Checked = True Then
            FormattedPriceString = StereoSystemDecimal.ToString("N")
        ElseIf StereoCheckBox.Checked = False Then
            FormattedPriceString = 0.ToString("N")
        End If

        'Measure string in this font
        FontSizeF = e.Graphics.MeasureString(FormattedPriceString, PrintFont)

        'subtract width of string from column position
        ColumnStart = 625 - FontSizeF.Width
        e.Graphics.DrawString(FormattedPriceString, PrintFont, Brushes.Black, ColumnStart, VerticalPrintLocationSingle)

        'Places a space between line strings
        VerticalPrintLocationSingle = VerticalPrintLocationSingle + LineHeightSingle

        'Displays "leather interior" title
        PrintLineString = "Leather Interior"
        e.Graphics.DrawString(PrintLineString, PrintFont,
                             Brushes.Black, HorizantalPrintLocationSingle, VerticalPrintLocationSingle)

        'Displays price for leather interior if checked
        If InteriorCheckBox.Checked = True Then
            FormattedPriceString = LeatherInteriorDecimal.ToString("N")
        ElseIf InteriorCheckBox.Checked = False Then
            FormattedPriceString = 0.ToString("N")
        End If

        'Measure string in this font
        FontSizeF = e.Graphics.MeasureString(FormattedPriceString, PrintFont)

        'subtract width of string from column position
        ColumnStart = 625 - FontSizeF.Width
        e.Graphics.DrawString(FormattedPriceString, PrintFont, Brushes.Black, ColumnStart, VerticalPrintLocationSingle)

        'Places a space between line strings
        VerticalPrintLocationSingle = VerticalPrintLocationSingle + LineHeightSingle

        'Displays "Computer Navigation" title
        PrintLineString = "Computer Navigation"
        e.Graphics.DrawString(PrintLineString, PrintFont,
                             Brushes.Black, HorizantalPrintLocationSingle, VerticalPrintLocationSingle)

        'Displays price for computer navigation if checked
        If NavigationCheckBox.Checked = True Then
            FormattedPriceString = NavigationDecimal.ToString("N")
        ElseIf NavigationCheckBox.Checked = False Then
            FormattedPriceString = 0.ToString("N")
        End If

        'Measure string in this font
        FontSizeF = e.Graphics.MeasureString(FormattedPriceString, PrintFont)

        'subtract width of string from column position
        ColumnStart = 625 - FontSizeF.Width
        e.Graphics.DrawString(FormattedPriceString, PrintFont, Brushes.Black, ColumnStart, VerticalPrintLocationSingle)

        'Places a space between line strings
        VerticalPrintLocationSingle = VerticalPrintLocationSingle + LineHeightSingle

        'Displays the "total" label on print document
        PrintLineString = "Total"
        e.Graphics.DrawString(PrintLineString, PrintFont,
                            Brushes.Black, HorizantalPrintLocationSingle, VerticalPrintLocationSingle)

        'Right-align the price
        FormattedPriceString = AccessoriesTotalDecimal.ToString("C")

        'Measure string in this font
        FontSizeF = e.Graphics.MeasureString(FormattedPriceString, PrintFont)

        'subtract width of string from column position
        ColumnStart = 625 - FontSizeF.Width
        e.Graphics.DrawString(FormattedPriceString, PrintFont, Brushes.Black, ColumnStart, VerticalPrintLocationSingle)

        'Places a space between line strings
        VerticalPrintLocationSingle = VerticalPrintLocationSingle + LineHeightSingle * 2

        'Displays title for cost of selected finish
        PrintLineString = "Cost of Selected Finish"
        e.Graphics.DrawString(PrintLineString, PrintFont,
                            Brushes.Black, HorizantalPrintLocationSingle, VerticalPrintLocationSingle)

        'Places a space between line strings
        VerticalPrintLocationSingle = VerticalPrintLocationSingle + LineHeightSingle * 2

        'Displays the correct finish 
        If StandardRadioButton.Checked = True Then
            PrintLineString = "Standard"
            FormattedPriceString = 0.ToString("C")
        ElseIf PearlRadioButton.Checked = True Then
            PrintLineString = "Pearlized"
            FormattedPriceString = PearlizedDecimal.ToString("C")
        ElseIf CustomRadioButton.Checked = True Then
            PrintLineString = "Custom Detailing"
            FormattedPriceString = CustomDecimal.ToString("C")
        End If

        'Displays the correct title for exterior finish
        e.Graphics.DrawString(PrintLineString, PrintFont,
                           Brushes.Black, HorizantalPrintLocationSingle, VerticalPrintLocationSingle)

        'Measure string in this font
        FontSizeF = e.Graphics.MeasureString(FormattedPriceString, PrintFont)

        'subtract width of string from column position
        ColumnStart = 625 - FontSizeF.Width
        e.Graphics.DrawString(FormattedPriceString, PrintFont, Brushes.Black, ColumnStart, VerticalPrintLocationSingle)

        'Places a space between line strings
        VerticalPrintLocationSingle = VerticalPrintLocationSingle + LineHeightSingle * 2

        'Displays title for total cost
        PrintLineString = "Total Cost of Selected Accessories and Finish"
        e.Graphics.DrawString(PrintLineString, PrintFont,
                            Brushes.Black, HorizantalPrintLocationSingle, VerticalPrintLocationSingle)

        'Right-align the price
        FormattedPriceString = AccountTotalDecimal.ToString("C")

        'Measure string in this font
        FontSizeF = e.Graphics.MeasureString(FormattedPriceString, PrintFont)

        'subtract width of string from column position
        ColumnStart = 625 - FontSizeF.Width
        e.Graphics.DrawString(FormattedPriceString, PrintFont, Brushes.Black, ColumnStart, VerticalPrintLocationSingle)

    End Sub
End Class

