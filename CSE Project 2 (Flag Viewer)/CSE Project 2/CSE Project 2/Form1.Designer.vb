<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.CountryGroupBox = New System.Windows.Forms.GroupBox()
        Me.MexicoRadioButton = New System.Windows.Forms.RadioButton()
        Me.CanadaRadioButton = New System.Windows.Forms.RadioButton()
        Me.JapanRadioButton = New System.Windows.Forms.RadioButton()
        Me.USRadioButton = New System.Windows.Forms.RadioButton()
        Me.DisplayGroupBox = New System.Windows.Forms.GroupBox()
        Me.ProgrammerCheckBox = New System.Windows.Forms.CheckBox()
        Me.CountryCheckBox = New System.Windows.Forms.CheckBox()
        Me.TitleCheckBox = New System.Windows.Forms.CheckBox()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ProgrammerLabel = New System.Windows.Forms.Label()
        Me.CountryLabel = New System.Windows.Forms.Label()
        Me.CountryPictureBox = New System.Windows.Forms.PictureBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CountryGroupBox.SuspendLayout()
        Me.DisplayGroupBox.SuspendLayout()
        CType(Me.CountryPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(189, 21)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(139, 34)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Flag Viewer"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CountryGroupBox
        '
        Me.CountryGroupBox.Controls.Add(Me.MexicoRadioButton)
        Me.CountryGroupBox.Controls.Add(Me.CanadaRadioButton)
        Me.CountryGroupBox.Controls.Add(Me.JapanRadioButton)
        Me.CountryGroupBox.Controls.Add(Me.USRadioButton)
        Me.CountryGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryGroupBox.Location = New System.Drawing.Point(24, 112)
        Me.CountryGroupBox.Name = "CountryGroupBox"
        Me.CountryGroupBox.Size = New System.Drawing.Size(154, 199)
        Me.CountryGroupBox.TabIndex = 2
        Me.CountryGroupBox.TabStop = False
        Me.CountryGroupBox.Text = "Country"
        '
        'MexicoRadioButton
        '
        Me.MexicoRadioButton.AutoSize = True
        Me.MexicoRadioButton.Location = New System.Drawing.Point(7, 160)
        Me.MexicoRadioButton.Name = "MexicoRadioButton"
        Me.MexicoRadioButton.Size = New System.Drawing.Size(76, 24)
        Me.MexicoRadioButton.TabIndex = 3
        Me.MexicoRadioButton.Text = "&Mexico"
        Me.ToolTip1.SetToolTip(Me.MexicoRadioButton, "Click here to view the Mexican flag")
        Me.MexicoRadioButton.UseVisualStyleBackColor = True
        '
        'CanadaRadioButton
        '
        Me.CanadaRadioButton.AutoSize = True
        Me.CanadaRadioButton.Location = New System.Drawing.Point(7, 120)
        Me.CanadaRadioButton.Name = "CanadaRadioButton"
        Me.CanadaRadioButton.Size = New System.Drawing.Size(83, 24)
        Me.CanadaRadioButton.TabIndex = 2
        Me.CanadaRadioButton.Text = "&Canada"
        Me.ToolTip1.SetToolTip(Me.CanadaRadioButton, "Click here to view the Canadian flag")
        Me.CanadaRadioButton.UseVisualStyleBackColor = True
        '
        'JapanRadioButton
        '
        Me.JapanRadioButton.AutoSize = True
        Me.JapanRadioButton.Location = New System.Drawing.Point(7, 78)
        Me.JapanRadioButton.Name = "JapanRadioButton"
        Me.JapanRadioButton.Size = New System.Drawing.Size(71, 24)
        Me.JapanRadioButton.TabIndex = 1
        Me.JapanRadioButton.Text = "&Japan"
        Me.ToolTip1.SetToolTip(Me.JapanRadioButton, "Click here to view the Japanese flag")
        Me.JapanRadioButton.UseVisualStyleBackColor = True
        '
        'USRadioButton
        '
        Me.USRadioButton.AutoSize = True
        Me.USRadioButton.Location = New System.Drawing.Point(7, 38)
        Me.USRadioButton.Name = "USRadioButton"
        Me.USRadioButton.Size = New System.Drawing.Size(125, 24)
        Me.USRadioButton.TabIndex = 0
        Me.USRadioButton.Text = "&United States"
        Me.ToolTip1.SetToolTip(Me.USRadioButton, "Click here to view the United States flag")
        Me.USRadioButton.UseVisualStyleBackColor = True
        '
        'DisplayGroupBox
        '
        Me.DisplayGroupBox.Controls.Add(Me.ProgrammerCheckBox)
        Me.DisplayGroupBox.Controls.Add(Me.CountryCheckBox)
        Me.DisplayGroupBox.Controls.Add(Me.TitleCheckBox)
        Me.DisplayGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayGroupBox.Location = New System.Drawing.Point(330, 112)
        Me.DisplayGroupBox.Name = "DisplayGroupBox"
        Me.DisplayGroupBox.Size = New System.Drawing.Size(147, 199)
        Me.DisplayGroupBox.TabIndex = 3
        Me.DisplayGroupBox.TabStop = False
        Me.DisplayGroupBox.Text = "Display"
        '
        'ProgrammerCheckBox
        '
        Me.ProgrammerCheckBox.AutoSize = True
        Me.ProgrammerCheckBox.Checked = True
        Me.ProgrammerCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ProgrammerCheckBox.Location = New System.Drawing.Point(7, 160)
        Me.ProgrammerCheckBox.Name = "ProgrammerCheckBox"
        Me.ProgrammerCheckBox.Size = New System.Drawing.Size(115, 24)
        Me.ProgrammerCheckBox.TabIndex = 6
        Me.ProgrammerCheckBox.Text = "P&rogrammer"
        Me.ToolTip1.SetToolTip(Me.ProgrammerCheckBox, "Click here to view or remove the programmer details")
        Me.ProgrammerCheckBox.UseVisualStyleBackColor = True
        '
        'CountryCheckBox
        '
        Me.CountryCheckBox.AutoSize = True
        Me.CountryCheckBox.Checked = True
        Me.CountryCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CountryCheckBox.Location = New System.Drawing.Point(7, 96)
        Me.CountryCheckBox.Name = "CountryCheckBox"
        Me.CountryCheckBox.Size = New System.Drawing.Size(129, 24)
        Me.CountryCheckBox.TabIndex = 5
        Me.CountryCheckBox.Text = "C&ountry Name"
        Me.ToolTip1.SetToolTip(Me.CountryCheckBox, "Click here to view or remove the country name")
        Me.CountryCheckBox.UseVisualStyleBackColor = True
        '
        'TitleCheckBox
        '
        Me.TitleCheckBox.AutoSize = True
        Me.TitleCheckBox.Checked = True
        Me.TitleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TitleCheckBox.Location = New System.Drawing.Point(7, 39)
        Me.TitleCheckBox.Name = "TitleCheckBox"
        Me.TitleCheckBox.Size = New System.Drawing.Size(57, 24)
        Me.TitleCheckBox.TabIndex = 4
        Me.TitleCheckBox.Text = "&Title"
        Me.ToolTip1.SetToolTip(Me.TitleCheckBox, "Click here to view or remove the title")
        Me.TitleCheckBox.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(341, 352)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(111, 34)
        Me.PrintButton.TabIndex = 7
        Me.PrintButton.Text = "&Print"
        Me.ToolTip1.SetToolTip(Me.PrintButton, "Click here to print")
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(341, 419)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(111, 34)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Click here to exit")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ProgrammerLabel
        '
        Me.ProgrammerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProgrammerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgrammerLabel.Location = New System.Drawing.Point(12, 546)
        Me.ProgrammerLabel.Name = "ProgrammerLabel"
        Me.ProgrammerLabel.Size = New System.Drawing.Size(227, 27)
        Me.ProgrammerLabel.TabIndex = 7
        Me.ProgrammerLabel.Text = "Programmed by Andrew Hedy"
        '
        'CountryLabel
        '
        Me.CountryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CountryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryLabel.Location = New System.Drawing.Point(50, 486)
        Me.CountryLabel.Name = "CountryLabel"
        Me.CountryLabel.Size = New System.Drawing.Size(206, 29)
        Me.CountryLabel.TabIndex = 8
        Me.CountryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CountryPictureBox
        '
        Me.CountryPictureBox.InitialImage = Nothing
        Me.CountryPictureBox.Location = New System.Drawing.Point(24, 317)
        Me.CountryPictureBox.Name = "CountryPictureBox"
        Me.CountryPictureBox.Size = New System.Drawing.Size(266, 166)
        Me.CountryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CountryPictureBox.TabIndex = 6
        Me.CountryPictureBox.TabStop = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(514, 582)
        Me.Controls.Add(Me.CountryLabel)
        Me.Controls.Add(Me.ProgrammerLabel)
        Me.Controls.Add(Me.CountryPictureBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.DisplayGroupBox)
        Me.Controls.Add(Me.CountryGroupBox)
        Me.Controls.Add(Me.TitleLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.CountryGroupBox.ResumeLayout(False)
        Me.CountryGroupBox.PerformLayout()
        Me.DisplayGroupBox.ResumeLayout(False)
        Me.DisplayGroupBox.PerformLayout()
        CType(Me.CountryPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents CountryGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents MexicoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CanadaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents JapanRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents USRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DisplayGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ProgrammerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CountryCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TitleCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents CountryPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ProgrammerLabel As System.Windows.Forms.Label
    Friend WithEvents CountryLabel As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
