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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintBookInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FictionRadioButton = New System.Windows.Forms.RadioButton()
        Me.NonFictionRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SubjectComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ShelfNumberListBox = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintSelectedPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BookInfoPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(601, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintBookInfoToolStripMenuItem, Me.PrintSubjectToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 19)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintBookInfoToolStripMenuItem
        '
        Me.PrintBookInfoToolStripMenuItem.Name = "PrintBookInfoToolStripMenuItem"
        Me.PrintBookInfoToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.PrintBookInfoToolStripMenuItem.Text = "Print &book info"
        Me.PrintBookInfoToolStripMenuItem.ToolTipText = "Click here to print book info"
        '
        'PrintSubjectToolStripMenuItem
        '
        Me.PrintSubjectToolStripMenuItem.Name = "PrintSubjectToolStripMenuItem"
        Me.PrintSubjectToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.PrintSubjectToolStripMenuItem.Text = "Print &subject"
        Me.PrintSubjectToolStripMenuItem.ToolTipText = "Click here to print subject"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        Me.ExitToolStripMenuItem.ToolTipText = "Click here to exit program"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 19)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        Me.AboutToolStripMenuItem.ToolTipText = "Click here for about menu"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(25, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Author:"
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.Location = New System.Drawing.Point(124, 66)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(165, 26)
        Me.AuthorTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.AuthorTextBox, "Type here to input author name")
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(41, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Title:"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Location = New System.Drawing.Point(124, 131)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(165, 26)
        Me.TitleTextBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.TitleTextBox, "Type here to input title name")
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(35, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 27)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Type:"
        '
        'FictionRadioButton
        '
        Me.FictionRadioButton.AutoSize = True
        Me.FictionRadioButton.Location = New System.Drawing.Point(124, 208)
        Me.FictionRadioButton.Name = "FictionRadioButton"
        Me.FictionRadioButton.Size = New System.Drawing.Size(74, 24)
        Me.FictionRadioButton.TabIndex = 6
        Me.FictionRadioButton.TabStop = True
        Me.FictionRadioButton.Text = "&Fiction"
        Me.ToolTip1.SetToolTip(Me.FictionRadioButton, "Click here to select fiction")
        Me.FictionRadioButton.UseVisualStyleBackColor = True
        '
        'NonFictionRadioButton
        '
        Me.NonFictionRadioButton.AutoSize = True
        Me.NonFictionRadioButton.Location = New System.Drawing.Point(124, 236)
        Me.NonFictionRadioButton.Name = "NonFictionRadioButton"
        Me.NonFictionRadioButton.Size = New System.Drawing.Size(108, 24)
        Me.NonFictionRadioButton.TabIndex = 7
        Me.NonFictionRadioButton.TabStop = True
        Me.NonFictionRadioButton.Text = "&Non-Fiction"
        Me.ToolTip1.SetToolTip(Me.NonFictionRadioButton, "Click here to select non-fiction")
        Me.NonFictionRadioButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(353, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Subject:"
        '
        'SubjectComboBox
        '
        Me.SubjectComboBox.FormattingEnabled = True
        Me.SubjectComboBox.Items.AddRange(New Object() {"Best-Seller", "Fantasy", "Religion", "Romance", "Humor", "Science Fiction", "Business", "Philosphy", "Education", "Self-Help", "Mystery"})
        Me.SubjectComboBox.Location = New System.Drawing.Point(445, 158)
        Me.SubjectComboBox.Name = "SubjectComboBox"
        Me.SubjectComboBox.Size = New System.Drawing.Size(121, 28)
        Me.SubjectComboBox.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.SubjectComboBox, "Click to select the genre")
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(319, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Shelf Number:"
        '
        'ShelfNumberListBox
        '
        Me.ShelfNumberListBox.FormattingEnabled = True
        Me.ShelfNumberListBox.ItemHeight = 20
        Me.ShelfNumberListBox.Items.AddRange(New Object() {"RC-1111", "RC-1112", "RC-1113", "RC-1114"})
        Me.ShelfNumberListBox.Location = New System.Drawing.Point(446, 65)
        Me.ShelfNumberListBox.Name = "ShelfNumberListBox"
        Me.ShelfNumberListBox.Size = New System.Drawing.Size(120, 84)
        Me.ShelfNumberListBox.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.ShelfNumberListBox, "Click the correct shelf number")
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(11, 371)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(221, 29)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Programmed by Andrew Hedy"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(338, 221)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(89, 27)
        Me.PrintButton.TabIndex = 13
        Me.PrintButton.Text = "&Print"
        Me.ToolTip1.SetToolTip(Me.PrintButton, "Click here to print")
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(338, 275)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(89, 27)
        Me.ClearButton.TabIndex = 14
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Click here to clear the program")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(338, 331)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(89, 29)
        Me.ExitButton.TabIndex = 15
        Me.ExitButton.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Click here to exit the program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(202, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Reading 'n Refreshment"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintSelectedPrintDocument
        '
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'BookInfoPrintDocument
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 409)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ShelfNumberListBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SubjectComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NonFictionRadioButton)
        Me.Controls.Add(Me.FictionRadioButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AuthorTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintBookInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSubjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FictionRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents NonFictionRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SubjectComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ShelfNumberListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintSelectedPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BookInfoPrintDocument As System.Drawing.Printing.PrintDocument

End Class
