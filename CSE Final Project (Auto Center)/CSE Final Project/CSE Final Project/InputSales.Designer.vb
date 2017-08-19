<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputSales))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NavigationCheckBox = New System.Windows.Forms.CheckBox()
        Me.InteriorCheckBox = New System.Windows.Forms.CheckBox()
        Me.StereoCheckBox = New System.Windows.Forms.CheckBox()
        Me.TradeInTextBox = New System.Windows.Forms.TextBox()
        Me.BasePriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CustomRadioButton = New System.Windows.Forms.RadioButton()
        Me.PearlRadioButton = New System.Windows.Forms.RadioButton()
        Me.StandardRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SubtotalLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AmountDueLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintInvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutVBAutoCenter2015ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ExtrasLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SalesTaxLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valley Boulevard Auto Center"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NavigationCheckBox)
        Me.GroupBox1.Controls.Add(Me.InteriorCheckBox)
        Me.GroupBox1.Controls.Add(Me.StereoCheckBox)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 166)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Accessories"
        '
        'NavigationCheckBox
        '
        Me.NavigationCheckBox.AutoSize = True
        Me.NavigationCheckBox.Location = New System.Drawing.Point(7, 129)
        Me.NavigationCheckBox.Name = "NavigationCheckBox"
        Me.NavigationCheckBox.Size = New System.Drawing.Size(176, 24)
        Me.NavigationCheckBox.TabIndex = 3
        Me.NavigationCheckBox.Text = "Computer &Navigation"
        Me.ToolTip1.SetToolTip(Me.NavigationCheckBox, "Click here to add navigation to purchase")
        Me.NavigationCheckBox.UseVisualStyleBackColor = True
        '
        'InteriorCheckBox
        '
        Me.InteriorCheckBox.AutoSize = True
        Me.InteriorCheckBox.Location = New System.Drawing.Point(7, 82)
        Me.InteriorCheckBox.Name = "InteriorCheckBox"
        Me.InteriorCheckBox.Size = New System.Drawing.Size(137, 24)
        Me.InteriorCheckBox.TabIndex = 2
        Me.InteriorCheckBox.Text = "&Leather Interior"
        Me.ToolTip1.SetToolTip(Me.InteriorCheckBox, "Click here to add leather interior to purchase")
        Me.InteriorCheckBox.UseVisualStyleBackColor = True
        '
        'StereoCheckBox
        '
        Me.StereoCheckBox.AutoSize = True
        Me.StereoCheckBox.Location = New System.Drawing.Point(7, 37)
        Me.StereoCheckBox.Name = "StereoCheckBox"
        Me.StereoCheckBox.Size = New System.Drawing.Size(133, 24)
        Me.StereoCheckBox.TabIndex = 1
        Me.StereoCheckBox.Text = "&Stereo System"
        Me.ToolTip1.SetToolTip(Me.StereoCheckBox, "Click here to add stereo system to purchase")
        Me.StereoCheckBox.UseVisualStyleBackColor = True
        '
        'TradeInTextBox
        '
        Me.TradeInTextBox.Location = New System.Drawing.Point(419, 345)
        Me.TradeInTextBox.Name = "TradeInTextBox"
        Me.TradeInTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TradeInTextBox.TabIndex = 7
        Me.TradeInTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.TradeInTextBox, "Enter the trade-in value here")
        '
        'BasePriceTextBox
        '
        Me.BasePriceTextBox.Location = New System.Drawing.Point(419, 89)
        Me.BasePriceTextBox.Name = "BasePriceTextBox"
        Me.BasePriceTextBox.Size = New System.Drawing.Size(100, 26)
        Me.BasePriceTextBox.TabIndex = 8
        Me.BasePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.BasePriceTextBox, "Enter the price for the new car here")
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(269, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Base Price Value"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(286, 345)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Trade-in Value"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CustomRadioButton)
        Me.GroupBox2.Controls.Add(Me.PearlRadioButton)
        Me.GroupBox2.Controls.Add(Me.StandardRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 264)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(188, 166)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Exterior Finish"
        '
        'CustomRadioButton
        '
        Me.CustomRadioButton.AutoSize = True
        Me.CustomRadioButton.Location = New System.Drawing.Point(7, 129)
        Me.CustomRadioButton.Name = "CustomRadioButton"
        Me.CustomRadioButton.Size = New System.Drawing.Size(177, 24)
        Me.CustomRadioButton.TabIndex = 6
        Me.CustomRadioButton.TabStop = True
        Me.CustomRadioButton.Text = "Customized &Detailing"
        Me.ToolTip1.SetToolTip(Me.CustomRadioButton, "Click here to add customized detailing to purchase")
        Me.CustomRadioButton.UseVisualStyleBackColor = True
        '
        'PearlRadioButton
        '
        Me.PearlRadioButton.AutoSize = True
        Me.PearlRadioButton.Location = New System.Drawing.Point(7, 82)
        Me.PearlRadioButton.Name = "PearlRadioButton"
        Me.PearlRadioButton.Size = New System.Drawing.Size(92, 24)
        Me.PearlRadioButton.TabIndex = 5
        Me.PearlRadioButton.TabStop = True
        Me.PearlRadioButton.Text = "&Pearlized"
        Me.ToolTip1.SetToolTip(Me.PearlRadioButton, "Click here to add pearlized finish to purchase")
        Me.PearlRadioButton.UseVisualStyleBackColor = True
        '
        'StandardRadioButton
        '
        Me.StandardRadioButton.AutoSize = True
        Me.StandardRadioButton.Location = New System.Drawing.Point(7, 37)
        Me.StandardRadioButton.Name = "StandardRadioButton"
        Me.StandardRadioButton.Size = New System.Drawing.Size(93, 24)
        Me.StandardRadioButton.TabIndex = 4
        Me.StandardRadioButton.TabStop = True
        Me.StandardRadioButton.Text = "S&tandard"
        Me.ToolTip1.SetToolTip(Me.StandardRadioButton, "Click here for standard exterior finish")
        Me.StandardRadioButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(328, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Subtotal"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SubtotalLabel
        '
        Me.SubtotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubtotalLabel.Location = New System.Drawing.Point(419, 194)
        Me.SubtotalLabel.Name = "SubtotalLabel"
        Me.SubtotalLabel.Size = New System.Drawing.Size(100, 25)
        Me.SubtotalLabel.TabIndex = 8
        Me.SubtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(292, 401)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Amount Due"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AmountDueLabel
        '
        Me.AmountDueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AmountDueLabel.Location = New System.Drawing.Point(419, 400)
        Me.AmountDueLabel.Name = "AmountDueLabel"
        Me.AmountDueLabel.Size = New System.Drawing.Size(100, 24)
        Me.AmountDueLabel.TabIndex = 10
        Me.AmountDueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(5, 514)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(224, 30)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Programmed by Andrew Hedy"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(236, 461)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(105, 32)
        Me.CalculateButton.TabIndex = 9
        Me.CalculateButton.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Click here to calculate price")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(379, 461)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(105, 32)
        Me.ClearButton.TabIndex = 10
        Me.ClearButton.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Click here to clear form")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(540, 29)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.PrintInvoiceToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 25)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.ExitToolStripMenuItem.Text = "&Print"
        '
        'PrintInvoiceToolStripMenuItem
        '
        Me.PrintInvoiceToolStripMenuItem.Name = "PrintInvoiceToolStripMenuItem"
        Me.PrintInvoiceToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.PrintInvoiceToolStripMenuItem.Text = "Print &Invoice"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(166, 26)
        Me.ExitToolStripMenuItem1.Text = "&Main Form"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.ClearToolStripMenuItem, Me.FotToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(48, 25)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.CalculateToolStripMenuItem.Text = "&Calculate"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.ClearToolStripMenuItem.Text = "C&lear"
        '
        'FotToolStripMenuItem
        '
        Me.FotToolStripMenuItem.Name = "FotToolStripMenuItem"
        Me.FotToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.FotToolStripMenuItem.Text = "&Font"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.ColorToolStripMenuItem.Text = "C&olor"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.AboutVBAutoCenter2015ToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(54, 25)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(272, 26)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'AboutVBAutoCenter2015ToolStripMenuItem
        '
        Me.AboutVBAutoCenter2015ToolStripMenuItem.Name = "AboutVBAutoCenter2015ToolStripMenuItem"
        Me.AboutVBAutoCenter2015ToolStripMenuItem.Size = New System.Drawing.Size(272, 26)
        Me.AboutVBAutoCenter2015ToolStripMenuItem.Text = "About &VB Auto Center 2015"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'ExtrasLabel
        '
        Me.ExtrasLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ExtrasLabel.Location = New System.Drawing.Point(419, 142)
        Me.ExtrasLabel.Name = "ExtrasLabel"
        Me.ExtrasLabel.Size = New System.Drawing.Size(100, 24)
        Me.ExtrasLabel.TabIndex = 16
        Me.ExtrasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(232, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Accessories and Finish"
        '
        'SalesTaxLabel
        '
        Me.SalesTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SalesTaxLabel.Location = New System.Drawing.Point(419, 245)
        Me.SalesTaxLabel.Name = "SalesTaxLabel"
        Me.SalesTaxLabel.Size = New System.Drawing.Size(100, 24)
        Me.SalesTaxLabel.TabIndex = 18
        Me.SalesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(315, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 24)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Sales Tax "
        '
        'TotalLabel
        '
        Me.TotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalLabel.Location = New System.Drawing.Point(419, 295)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(100, 24)
        Me.TotalLabel.TabIndex = 20
        Me.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(351, 295)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 23)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Total"
        '
        'PrintDocument1
        '
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
        'InputSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 552)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TotalLabel)
        Me.ContrŸ›Kcq–C—n4a¬œÏ%ùšöœ¸G¤ßŸgNÃÕ-[µh}GP
O‡Ìwr¹üµZ$`Ğ1:LšÙ‰0fËy]8„÷†¼Dá¸[ò^Î\íKpw®N¤Â_?nİca¬åqêÔ¬LŠ}3ßrÚ“N¬CÎã+Ñ³p6dıò~”P¾¢ÛÖ˜$NhşÉ` £“[Æ‹pß ,t´ìh­vì™2"ŠüHCBjM'VçµY¿*Ìq6‹ 	ÿ‹ïV²†øíØ¹_ˆı?©Â.[™KË–ÍfH†vÓèöÃòY!¬pï¶Ë`{Z¹ì¬ŠüÈˆ0ÕR%7Ò¯H†Q—è'èq9™pğûÿ2İİ =Ú¿x‰8!˜f'ö¹út:8ÜcŒÚ2ò?”¡ÿp†ˆ'ÀÏPÖL%˜¤ØßÇ\J>5ğòm\f³8<›˜`I_*;U2 ¡®0õ¦2SO4›“–¦#c›ïä¦Ü#rësû5Ü`ÂcÆı~<‹t\ÀpÿZ’Ü›Á”Şìíì59ÑST%áônĞD¦?­!‰Ë½‘RdÔ'å3Ğp†•ÑÚ½¸€æ6m”œ£`+ó¨j†áAo*5©û¶àÍÄ" ›-s÷É—İÌ{cj4H<û'€ĞAA„ÆAy.Ë@ÿŠRŞ¶XÈD,$„ŒR§‘d0ı{ zæa¶’‹ê±i@+¥S TÆ£iı]úmF—¹ÿ!ê;M³·cAâ«:?¼!İrËÎ>ˆ-z'Rğ(BôN¯˜ğU¦ÿUgOIrœÚ¢~åöôö³3»139ÑàğÔûD„ÕOÅ$×WMÓ–]ÉÜÄÎ#˜—½Ókw~Úsœî¼“˜<·ü”'RXÏš‚êìp}]$Ø‹îbé•´ÄFYH·I¶ÙŸ ÅÅãğ#–¤c_#şaèXaŠTÏ¥"@™;ãøµËõ–+*9fJ	qhüO‚¿[}Çñ«·lä1É >¤e&•§,çNìÎÖèrÉS	˜š#Òª>ä÷Ãn0õš–µá¨].:L5Zx€¡¼Ş*A<Ñ]%âŠº^­¾nbé	§æ[j³„ÿ$1Æ‘
6ÍÔ‰K  ûjÂL®[¾Â¬¶0!²Mcúæêşs‰e)£Âk:êÉòïPşf¯5/÷ñŸs ª	Ø¿o<zÌ‹^âD›ßX3Ä Nb:'‚{Ö¬î~®H¸=ywúá‹d_œnWa† ÃÖ’k¾( ”>S±ô9Ú]ƒE6u…súyk6YŠ*ÓV· Ğd‹.
¦±èXJD­8ô[_m·nÅnËµèJ3Î©şÌnputSales"
        Me.Text = "Final Project"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NavigationCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents InteriorCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents StereoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TradeInTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BasePriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents StandardRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CustomRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PearlRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SubtotalLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AmountDueLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FotToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutVBAutoCenter2015ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    FriJ@Ëíˆ½¨mWØ ½gÎ¨cSIïıGµ2¬Û0µxô`»¿˜4£é”ÆÕ²Ã/2ö]ä¡Â•ã˜¿³Ó£Fç0‘¨cÖéµ'$IÒƒA]5ì}òN™ÊcÏÒ#Ğ°#åìr¤£ÄÄ¼hôp
Ló	Ş":: |UÈm	Æ´Zõş>„MM~³?c¶xÜÄÉ|°Fÿ×Uwı·şmaÍØ}ÂuŠá¹+ïÔ´1`]ì÷;™ğÔnåu|Y®Á‚W–j?¤t³š˜€BS™»÷³ìºñ½Ôï•ùúªn“Mgf”ˆi¡!U–ÏÎç±¬Fÿ|Ç­!š*øG~kİ2}½0mUÏĞ	ÃÊÇ%¤…dzîTêš±‚ª8ı`rã`Àõ’>”(Jrù¨2è6ÎR°ãª–xÎÀú¹×Ç4¤z€Mæ[,ñæ‹ VÀ£Lf-ô3w Ë™¹Û—`j ıŠ¼w$XúÓ  ¬jdÈƒñóºÕ)÷ŸI8¯Æq\Fõ¬Ø¶)ÄTqÒ‰Xj	×(2&A@¢OgDsß²¿•3_°O»šó~p¯Ó‡I÷q¾ë:ìk¼lëúÕŸ"}=‘«•ÎBEçKv…:Ù#œğø‡Bèwg{¦õ>†±ÀâQõZ¯ãœ“
åA·¢¥)¯dd*DÚ€¸a+OìÎ#=C­.5À²¾A¾¤Ò…!`…¬„¢ê ‰OA'	”Â:+ZY_wàÊ&U½Š—+wáîòó
*àÃy…Ÿæ9Ëõ1“d_|ÖdLOÕ˜ï@K¤èdıˆÿ{ÃuıFf3›Adİ1Ûˆ0İŠ"E\+E§:igx