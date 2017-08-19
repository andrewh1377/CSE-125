Public Class MainForm

    Private Sub InputSaleFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputSaleFormToolStripMenuItem.Click

        'Displays input sale form
        InputSales.Show()
        Me.Hide()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        'Exits the program
        Dim ReturnDialogResult As DialogResult
        Dim MessageString As String

        'Opens yes/no dialog box and if yes is selected program is ended
        MessageString = "Are you sure you wish to exit the program?"
        ReturnDialogResult = MessageBox.Show(MessageString, "Exit order", MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ReturnDialogResult = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click

        'Changes the color of the font of certain items in the program
        With ColorDialog1
            .ShowDialog()
            Label1.ForeColor = .Color
        End With

    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click

        'Changes font style of certain items in the program
        With FontDialog1
            .ShowDialog()
            Label2.Font = .Font
        End With

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        'Shows about box and hides main form
        AboutBox1.Show()
        Me.Hide()

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click

        'Displays print preview dialog and allows user to print program
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub
End Class