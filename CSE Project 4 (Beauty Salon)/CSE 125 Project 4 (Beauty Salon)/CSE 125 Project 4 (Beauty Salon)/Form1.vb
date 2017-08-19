'Andrew Hedy
'Beauty Salon
'February 2015
'Tuesday Lab

'Calculates and displays services and discounts provided by a beauty salon

Public Class Form1
    'Declaring Constants
    Const TenDecimal As Decimal = 0.1
    Const TwentyDecimal As Decimal = 0.2
    Const MakeOverDecimal As Decimal = 125D
    Const HairStylingDecimal As Decimal = 60D
    Const ManicureDecimal As Decimal = 35D
    Const PermanentMakeupDecimal As Decimal = 200D

    'Dementioning modular variables
    Dim TotalDiscountDecimal As Decimal
    Dim SubtotalDueDecimal As Decimal


    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        'Dementioning local variables
        Dim ServiceCostDecimal As Decimal
        Dim TotalDueDecimal As Decimal
        Dim ServiceDiscountDecimal As Decimal

        'Selects correct output when user selects a radio button
        If MakeOverRadioButton.Checked = True Then
            ServiceCostDecimal = MakeOverDecimal

        ElseIf HairStylingRadioButton.Checked = True Then
            ServiceCostDecimal = HairStylingDecimal

        ElseIf ManicureRadioButton.Checked = True Then
            ServiceCostDecimal = ManicureDecimal

        ElseIf PermanentMakeupRadioButton.Checked = True Then
            ServiceCostDecimal = PermanentMakeupDecimal
        End If


        If TenRadioButton.Checked = True Then
            ServiceDiscountDecimal = TenDecimal * ServiceCostDecimal
        ElseIf TwentyRadioButton.Checked = True Then
            ServiceDiscountDecimal = TwentyDecimal * ServiceCostDecimal
        End If

        'Calculate values
        ServiceCostDecimal = ServiceCostDecimal
        SubtotalDueDecimal = SubtotalDueDecimal + ServiceCostDecimal
        TotalDiscountDecimal = TotalDiscountDecimal + ServiceDiscountDecimal
        TotalDueDecimal = SubtotalDueDecimal - TotalDiscountDecimal

        'Displays values
        ServiceCostSumLabel.Text = ServiceCostDecimal.ToString("C")
        SubTotalSumLabel.Text = SubtotalDueDecimal.ToString("C")
        TotalDiscountSumLabel.Text = TotalDiscountDecimal.ToString("N")
        TotalDueSumLabel.Text = TotalDueDecimal.ToString("C")



        'Sets services radio buttons to false
        MakeOverRadioButton.Checked = False
        ManicureRadioButton.Checked = False
        HairStylingRadioButton.Checked = False
        PermanentMakeupRadioButton.Checked = False


    End Sub

    Private Sub NewItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewItemButton.Click
        'Clears service cost text and sets service cost decimal to 0
        ServiceCostSumLabel.Text = ""
        NoDiscountRadioButton.Focus()
    End Sub

    Private Sub MakeOverRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MakeOverRadioButton.CheckedChanged
        'Focuses no discount radio button
        NoDiscountRadioButton.Focus()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        'Unchecks all services radio buttons until user interacts
        MakeOverRadioButton.AutoCheck = True
        ManicureRadioButton.AutoCheck = True
        PermanentMakeupRadioButton.AutoCheck = True
        HairStylingRadioButton.AutoCheck = True

    End Sub

    Private Sub HairStylingRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HairStylingRadioButton.CheckedChanged
        'Focuses no discount radio button
        NoDiscountRadioButton.Focus()

    End Sub

    Private Sub ManicureRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManicureRadioButton.CheckedChanged
        'Focuses no discount radio button
        NoDiscountRadioButton.Focus()

    End Sub

    Private Sub PermanentMakeupRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermanentMakeupRadioButton.CheckedChanged
        'Focuses no discount radio button
        NoDiscountRadioButton.Focus()

    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'Ends Program
        End

    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        'Displays print preview and allows user to print program
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub NewCustomerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewCustomerButton.Click
        Dim ReturnDialogResult As DialogResult
        Dim MessageString As String
        'Opens dialog box
        MessageString = "Clear current data"
        ReturnDialogResult = MessageBox.Show(MessageString, "Clear Order", MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ReturnDialogResult = Windows.Forms.DialogResult.Yes Then
            PermanentMakeupRadioButton.Checked = False
            ManicureRadioButton.Checked = False
            HairStylingRadioButton.Checked = False
            MakeOverRadioButton.Checked = False
            NoDiscountRadioButton.Checked = True
            TenRadioButton.Checked = False
            TwentyRadioButton.Checked = False
            SubTotalSumLabel.Text = ""
            ServiceCostSumLabel.Text = ""
            TotalDiscountSumLabel.Text = ""
            TotalDueSumLabel.Text = ""
            SubtotalDueDecimal = 0
            TotalDiscountDecimal = 0
        End If
        
    End Sub
End Class
