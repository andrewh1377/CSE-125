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
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CountryLabel = New System.Windows.Forms.Label()
        Me.ProgrammerLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CanadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MexicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JapanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnitedStatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TitleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountryNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgrammerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutFlagViewer20ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlagPictureBox = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.FlagPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(171, 55)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(138, 23)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Flag Viewer 2.0"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'CountryLabel
        '
        Me.CountryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CountryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryLabel.Location = New System.Drawing.Point(134, 307)
        Me.CountryLabel.Name = "CountryLabel"
        Me.CountryLabel.Size = New System.Drawing.Size(207, 23)
        Me.CountryLabel.TabIndex = 2
        Me.CountryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgrammerLabel
        '
        Me.ProgrammerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProgrammerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgrammerLabel.Location = New System.Drawing.Point(21, 432)
        Me.ProgrammerLabel.Name = "ProgrammerLabel"
        Me.ProgrammerLabel.Size = New System.Drawing.Size(226, 23)
        Me.ProgrammerLabel.TabIndex = 3
        Me.ProgrammerLabel.Text = "Programmed by Andrew Hedy"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CountryToolStripMenuItem, Me.DisplayToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(495, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        Me.FileToolStripMenuItem.ToolTipText = "Click here to open up the file menu"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        Me.PrintToolStripMenuItem.ToolTipText = "Click here to print"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        Me.ExitToolStripMenuItem.ToolTipText = "Click here to exit the program"
        '
        'CountryToolStripMenuItem
        '
        Me.CountryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CanadaToolStripMenuItem, Me.MexicoToolStripMenuItem, Me.JapanToolStripMenuItem, Me.UnitedStatesToolStripMenuItem})
        Me.CountryToolStripMenuItem.Name = "CountryToolStripMenuItem"
        Me.CountryToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CountryToolStripMenuItem.Text = "&Country"
        Me.CountryToolStripMenuItem.ToolTipText = "Click here to select a country"
        '
        'CanadaToolStripMenuItem
        '
        Me.CanadaToolStripMenuItem.Name = "CanadaToolStripMenuItem"
        Me.CanadaToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CanadaToolStripMenuItem.Text = "C&anada"
        Me.CanadaToolStripMenuItem.ToolTipText = "Click here to view Canada"
        '
        'MexicoToolStripMenuItem
        '
        Me.MexicoToolStripMenuItem.Name = "MexicoToolStripMenuItem"
        Me.MexicoToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.MexicoToolStripMenuItem.Text = "&Mexico"
        Me.MexicoToolStripMenuItem.ToolTipText = "Click here to view Mexico"
        '
        'JapanToolStripMenuItem
        '
        Me.JapanToolStripMenuItem.Name = "JapanToolStripMenuItem"
        Me.JapanToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.JapanToolStripMenuItem.Text = "&Japan"
        Me.JapanToolStripMenuItem.ToolTipText = "Click here to view Japan"
        '
        'UnitedStatesToolStripMenuItem
        '
        Me.UnitedStatesToolStripMenuItem.Name = "UnitedStatesToolStripMenuItem"
        Me.UnitedStatesToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.UnitedStatesToolStripMenuItem.Text = "&United States"
        Me.UnitedStatesToolStripMenuItem.ToolTipText = "Click here to view U.S."
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TitleToolStripMenuItem, Me.CountryNameToolStripMenuItem, Me.ProgrammerToolStripMenuItem})
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.DisplayToolStripMenuItem.Text = "&Display"
        Me.DisplayToolStripMenuItem.ToolTipText = "Click here to select what to display"
        '
        'TitleToolStripMenuItem
        '
        Me.TitleToolStripMenuItem.Checked = True
        Me.TitleToolStripMenuItem.CheckOnClick = True
        Me.TitleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TitleToolStripMenuItem.Name = "TitleToolStripMenuItem"
        Me.TitleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TitleToolStripMenuItem.Text = "&Title"
        Me.TitleToolStripMenuItem.ToolTipText = "Click here to display the title"
        '
        'CountryNameToolStripMenuItem
        '
        Me.CountryNameToolStripMenuItem.Checked = True
        Me.CountryNameToolStripMenuItem.CheckOnClick = True
        Me.CountryNameToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CountryNameToolStripMenuItem.Name = "CountryNameToolStripMenuItem"
        Me.CountryNameToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CountryNameToolStripMenuItem.Text = "Country &Name"
        Me.CountryNameToolStripMenuItem.ToolTipText = "Click here to display the country name"
        '
        'ProgrammerToolStripMenuItem
        '
        Me.ProgrammerToolStripMenuItem.Checked = True
        Me.ProgrammerToolStripMenuItem.CheckOnClick = True
        Me.ProgrammerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ProgrammerToolStripMenuItem.Name = "ProgrammerToolStripMenuItem"
        Me.ProgrammerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProgrammerToolStripMenuItem.Text = "&Programmer"
        Me.ProgrammerToolStripMenuItem.ToolTipText = "Click here to display the programmer"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.AboutFlagViewer20ToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        Me.HelpToolStripMenuItem.ToolTipText = "Click here for help menu"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.AboutToolStripMenuItem.Text = "A&bout"
        Me.AboutToolStripMenuItem.ToolTipText = "Click here for the about menu"
        '
        'AboutFlagViewer20ToolStripMenuItem
        '
        Me.AboutFlagViewer20ToolStripMenuItem.Name = "AboutFlagViewer20ToolStripMenuItem"
        Me.AboutFlagViewer20ToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.AboutFlagViewer20ToolStripMenuItem.Text = "About Flag Viewer 2.0"
        Me.AboutFlagViewer20ToolStripMenuItem.ToolTipText = "Click here for about menu"
        '
        'FlagPictureBox
        '
        Me.FlagPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlagPictureBox.Location = New System.Drawing.Point(67, 94)
        Me.FlagPictureBox.Name = "FlagPictureBox"
        Me.FlagPictureBox.Size = New System.Drawing.Size(341, 197)
        Me.FlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FlagPictureBox.TabIndex = 5
        Me.FlagPictureBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 490)
        Me.Controls.Add(Me.FlagPictureBox)
        Me.Controls.Add(Me.ProgrammerLabel)
        Me.Controls.Add(Me.CountryLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.FlagPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ProgrammerLabel As System.Windows.Forms.Label
    Friend WithEvents CountryLabel As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CountryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CanadaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MexicoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JapanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnitedStatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TitleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CountryNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgrammerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FlagPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents AboutFlagViewer20ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
