'Andrew Hedy
'Project 5 and 6
'March 2015
'Tuesday Lab

'Displays the flag and country name when a country is selected in the tool strip menu. 

Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        'Ends the program
        End

    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click

        'Displays print preview and allows user to print form
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub


    Private Sub UnitedStatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitedStatesToolStripMenuItem.Click

        'Displays the United States flag and the name below it
        If UnitedStatesToolStripMenuItem.Checked Then
            UnitedStatesToolStripMenuItem.Checked = False
            CountryLabel.Text = ""
            FlagPictureBox.Image = Nothing
        Else
            UnitedStatesToolStripMenuItem.Checked = True
            CountryLabel.Text = "United States"
            FlagPictureBox.Image = My.Resources.U_S__Flag
            MexicoToolStripMenuItem.Checked = False
            CanadaToolStripMenuItem.Checked = False
            JapanToolStripMenuItem.Checked = False
        End If

    End Sub

    Private Sub CanadaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CanadaToolStripMenuItem.Click

        'Displays the Canada flag and the name below it
        If CanadaToolStripMenuItem.Checked Then
            CanadaToolStripMenuItem.Checked = False
            CountryLabel.Text = ""
            FlagPictureBox.Image = Nothing
        Else
            CanadaToolStripMenuItem.Checked = True
            CountryLabel.Text = "Canada"
            FlagPictureBox.Image = My.Resources.Canada_Flag
            MexicoToolStripMenuItem.Checked = False
            JapanToolStripMenuItem.Checked = False
            UnitedStatesToolStripMenuItem.Checked = False
        End If

    End Sub

    Private Sub JapanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JapanToolStripMenuItem.Click

        'Displays the Japan flag and the name below it
        If JapanToolStripMenuItem.Checked Then
            JapanToolStripMenuItem.Checked = False
            CountryLabel.Text = ""
            FlagPictureBox.Image = Nothing
        Else
            JapanToolStripMenuItem.Checked = True
            CountryLabel.Text = "Japan"
            FlagPictureBox.Image = My.Resources.Japan_Flag
            MexicoToolStripMenuItem.Checked = False
            UnitedStatesToolStripMenuItem.Checked = False
            CanadaToolStripMenuItem.Checked = False
        End If

    End Sub

    Private Sub MexicoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MexicoToolStripMenuItem.Click

        'Displays the Mexico flag and name below flag
        If MexicoToolStripMenuItem.Checked Then
            MexicoToolStripMenuItem.Checked = False
            CountryLabel.Text = ""
            FlagPictureBox.Image = Nothing
        Else
            MexicoToolStripMenuItem.Checked = True
            CountryLabel.Text = "Mexico"
            FlagPictureBox.Image = My.Resources.Mexico_Flag
            UnitedStatesToolStripMenuItem.Checked = False
            JapanToolStripMenuItem.Checked = False
            CanadaToolStripMenuItem.Checked = False
        End If

    End Sub

    Private Sub TitleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitleToolStripMenuItem.Click

        'Displays title
        If TitleToolStripMenuItem.Checked = False Then
            TitleLabel.Visible = False
        ElseIf TitleToolStripMenuItem.Checked = True Then
            TitleLabel.Visible = True
        End If

    End Sub

    Private Sub CountryNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountryNameToolStripMenuItem.Click

        'Displays country label
        If CountryNameToolStripMenuItem.Checked = False Then
            CountryLabel.Visible = False
        ElseIf CountryNameToolStripMenuItem.Checked = True Then
            CountryLabel.Visible = True
        End If

    End Sub

    Private Sub ProgrammerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgrammerToolStripMenuItem.Click

        'Displays programmed by label
        If ProgrammerToolStripMenuItem.Checked = False Then
            ProgrammerLabel.Visible = False
        ElseIf ProgrammerToolStripMenuItem.Checked = True Then
            ProgrammerLabel.Visible = True
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        'Displays a message box describing the program
        Dim messageString As String

        messageString = "Flag Viewer 2.0" & Environment.NewLine & Environment.NewLine & "This program displays the country name and the appropriate flag for the country. All you have to do is click the country name in the menu that says country." & Environment.NewLine & Environment.NewLine & "Programmed by Andrew Hedy"

        MessageBox.Show(messageString, "About Flag Viewer 2.0", MessageBoxButtons.OK, _
         MessageBoxIcon.Information)

    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click

        'Clears picture box and country label
        Dim ReturnDialogResult As DialogResult
        Dim MessageString As String
        'Opens dialog box
        MessageString = "Are you sure you want to clear the current data?"
        ReturnDialogResult = MessageBox.Show(MessageString, "Clear Order", MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ReturnDialogResult = Windows.Forms.DialogResult.Yes Then
            JapanToolStripMenuItem.Checked = False
            CanadaToolStripMenuItem.Checked = False
            MexicoToolStripMenuItem.Checked = False
            UnitedStatesToolStripMenuItem.Checked = False
            FlagPictureBox.Image = Nothing
            CountryLabel.Text = ""
        End If

    End Sub

    Private Sub AboutFlagViewer20ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutFlagViewer20ToolStripMenuItem.Click

        'Displays the about box
        Me.Hide()
        AboutBox1.ShowDialog()

    End Sub
End Class
