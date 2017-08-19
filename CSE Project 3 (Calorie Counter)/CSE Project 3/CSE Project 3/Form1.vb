'Andrew Hedy
'Calorie Counter
'February 2015
'Tuesday Lab

'Calculates the total grams of fat, protein, and carbs and converts them into decimal calories. 

Public Class Form1
    'Dementioning values
    Dim TotalMealDecimal As Decimal
    Dim TotalItemsInteger As Integer

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'Ends program
        End
    End Sub

    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        'Dementioning values
        Dim FatDecimal As Decimal
        Dim CarbDecimal As Decimal
        Dim ProteinDecimal As Decimal
        Dim TotalItemCaloriesDecimal As Decimal
        Try
            'convert input values into numeric values
            FatDecimal = Decimal.Parse(FatCalTextBox.Text)
            ProteinDecimal = Decimal.Parse(ProteinCalTextBox.Text)
            CarbDecimal = Decimal.Parse(CarbsCalTextBox.Text)
            Try
                
            Catch ex As Exception

            End Try

            'Calculate Values
            TotalItemCaloriesDecimal = (FatDecimal * 9) + (CarbDecimal * 4) + (ProteinDecimal * 4)
            TotalItemsInteger = TotalItemsInteger + 1
            TotalMealDecimal = TotalMealDecimal + TotalItemCaloriesDecimal

            'Display Answers
            TotalItemCaloriesLabel.Text = TotalItemCaloriesDecimal
            TotalNumberOfCaloriesLabel.Text = TotalMealDecimal
            TotalNumberOfItemsLabel.Text = TotalItemsInteger

        Catch
        End Try

    End Sub


    Private Sub NewMealButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewMealButton.Click
        'Clears all entries to start a new meal
        FatCalTextBox.Focus()
        FatCalTextBox.Text = ""
        ProteinCalTextBox.Text = ""
        CarbsCalTextBox.Text = ""
        TotalItemCaloriesLabel.Text = ""
        TotalNumberOfItemsLabel.Text = ""
        TotalNumberOfCaloriesLabel.Text = ""
        TotalItemsInteger = 0
        TotalMealDecimal = 0

    End Sub

    Private Sub NextItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextItemButton.Click
        'Clears fat, protein, carbs, and item calories
        FatCalTextBox.Text = ""
        ProteinCalTextBox.Text = ""
        CarbsCalTextBox.Text = ""
        TotalItemCaloriesLabel.Text = ""

    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        'Displays print preview and prints program
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub FatCalTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles FatCalTextBox.TextChanged
        'Sets focus to grams of fat text box after clicking next item or new meal
        FatCalTextBox.Focus()
    End Sub
End Class
