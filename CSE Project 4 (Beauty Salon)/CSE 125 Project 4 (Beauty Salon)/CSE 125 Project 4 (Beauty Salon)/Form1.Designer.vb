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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PermanentMakeupRadioButton = New System.Windows.Forms.RadioButton()
        Me.ManicureRadioButton = New System.Windows.Forms.RadioButton()
        Me.HairStylingRadioButton = New System.Windows.Forms.RadioButton()
        Me.MakeOverRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TenRadioButton = New System.Windows.Forms.RadioButton()
        Me.TwentyRadioButton = New System.Windows.Forms.RadioButton()
        Me.NoDiscountRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ServiceCostSumLabel = New System.Windows.Forms.Label()
        Me.SubTotalSumLabel = New System.Windows.Forms.Label()
        Me.TotalDiscountSumLabel = New System.Windows.Forms.Label()
        Me.TotalDueSumLabel = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.NewItemButton = New System.Windows.Forms.Button()
        Me.NewCustomerButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PermanentMakeupRadioButton)
        Me.GroupBox1.Controls.Add(Me.ManicureRadioButton)
        Me.GroupBox1.Controls.Add(Me.HairStylingRadioButton)
        Me.GroupBox1.Controls.Add(Me.MakeOverRadioButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(47, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 179)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Services"
        '
        'PermanentMakeupRadioButton
        '
        Me.PermanentMakeupRadioButton.AutoCheck = False
        Me.PermanentMakeupRadioButton.AutoSize = True
        Me.PermanentMakeupRadioButton.Location = New System.Drawing.Point(7, 140)
        Me.PermanentMakeupRadioButton.Name = "PermanentMakeupRadioButton"
        Me.PermanentMakeupRadioButton.Size = New System.Drawing.Size(166, 24)
        Me.PermanentMakeupRadioButton.TabIndex = 3
        Me.PermanentMakeupRadioButton.Text = "&Permanent Makeup"
        Me.ToolTip1.SetToolTip(Me.PermanentMakeupRadioButton, "check here to see permanent makeup cost")
        Me.PermanentMakeupRadioButton.UseVisualStyleBackColor = True
        '
        'ManicureRadioButton
        '
        Me.ManicureRadioButton.AutoCheck = False
        Me.ManicureRadioButton.AutoSize = True
        Me.ManicureRadioButton.Location = New System.Drawing.Point(6, 102)
        Me.ManicureRadioButton.Name = "ManicureRadioButton"
        Me.ManicureRadioButton.Size = New System.Drawing.Size(92, 24)
        Me.ManicureRadioButton.TabIndex = 2
        Me.ManicureRadioButton.Text = "M&anicure"
        Me.ToolTip1.SetToolTip(Me.ManicureRadioButton, "Check here to see manicure cost")
        Me.ManicureRadioButton.UseVisualStyleBackColor = True
        '
        'HairStylingRadioButton
        '
        Me.HairStylingRadioButton.AutoCheck = False
        Me.HairStylingRadioButton.AutoSize = True
        Me.HairStylingRadioButton.Location = New System.Drawing.Point(7, 66)
        Me.HairStylingRadioButton.Name = "HairStylingRadioButton"
        Me.HairStylingRadioButton.Size = New System.Drawing.Size(107, 24)
        Me.HairStylingRadioButton.TabIndex = 1
        Me.HairStylingRadioButton.Text = "&Hair Styling"
        Me.ToolTip1.SetToolTip(Me.HairStylingRadioButton, "Check here to see hair styling cost")
        Me.HairStylingRadioButton.UseVisualStyleBackColor = True
        '
        'MakeOverRadioButton
        '
        Me.MakeOverRadioButton.AutoCheck = False
        Me.MakeOverRadioButton.AutoSize = True
        Me.MakeOverRadioButton.Location = New System.Drawing.Point(7, 31)
        Me.MakeOverRadioButton.Name = "MakeOverRadioButton"
        Me.MakeOverRadioButton.Size = New System.Drawing.Size(103, 24)
        Me.MakeOverRadioButton.TabIndex = 0
        Me.MakeOverRadioButton.Text = "&Make Over"
        Me.ToolTip1.SetToolTip(Me.MakeOverRadioButton, "Check here to see Make Over cost")
        Me.MakeOverRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TenRadioButton)
        Me.GroupBox2.Controls.Add(Me.TwentyRadioButton)
        Me.GroupBox2.Controls.Add(Me.NoDiscountRadioButton)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(273, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(175, 179)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Discounts"
        '
        'TenRadioButton
        '
        Me.TenRadioButton.AutoSize = True
        Me.TenRadioButton.Location = New System.Drawing.Point(7, 86)
        Me.TenRadioButton.Name = "TenRadioButton"
        Me.TenRadioButton.Size = New System.Drawing.Size(59, 24)
        Me.TenRadioButton.TabIndex = 2
        Me.TenRadioButton.Text = "&10%"
        Me.ToolTip1.SetToolTip(Me.TenRadioButton, "check here for 10% discount")
        Me.TenRadioButton.UseVisualStyleBackColor = True
        '
        'TwentyRadioButton
        '
        Me.TwentyRadioButton.AutoSize = True
        Me.TwentyRadioButton.Location = New System.Drawing.Point(7, 138)
        Me.TwentyRadioButton.Name = "TwentyRadioButton"
        Me.TwentyRadioButton.Size = New System.Drawing.Size(59, 24)
        Me.TwentyRadioButton.TabIndex = 1
        Me.TwentyRadioButton.Text = "&20%"
        Me.ToolTip1.SetToolTip(Me.TwentyRadioButton, "check here for 20% discount")
        Me.TwentyRadioButton.UseVisualStyleBackColor = True
        '
        'NoDiscountRadioButton
        '
        Me.NoDiscountRadioButton.AutoSize = True
        Me.NoDiscountRadioButton.Checked = True
        Me.NoDiscountRadioButton.Location = New System.Drawing.Point(7, 35)
        Me.NoDiscountRadioButton.Name = "NoDiscountRadioButton"
        Me.NoDiscountRadioButton.Size = New System.Drawing.Size(65, 24)
        Me.NoDiscountRadioButton.TabIndex = 0
        Me.NoDiscountRadioButton.TabStop = True
        Me.NoDiscountRadioButton.Text = "&None"
        Me.ToolTip1.SetToolTip(Me.NoDiscountRadioButton, "check here for no discount")
        Me.NoDiscountRadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(189, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Beauty Salon"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(269, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Subtotal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(234, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total Discount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(260, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Total Due"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Service Cost"
        '
        'ServiceCostSumLabel
        '
        Me.ServiceCostSumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ServiceCostSumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServiceCostSumLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ServiceCostSumLabel.Location = New System.Drawing.Point(121, 238)
        Me.ServiceCostSumLabel.Name = "ServiceCostSumLabel"
        Me.ServiceCostSumLabel.Size = New System.Drawing.Size(100, 23)
        Me.ServiceCostSumLabel.TabIndex = 7
        Me.ServiceCostSumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SubTotalSumLabel
        '
        Me.SubTotalSumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubTotalSumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTotalSumLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SubTotalSumLabel.Location = New System.Drawing.Point(348, 235)
        Me.SubTotalSumLabel.Name = "SubTotalSumLabel"
        Me.SubTotalSumLabel.Size = New System.Drawing.Size(100, 23)
        Me.SubTotalSumLabel.TabIndex = 8
        Me.SubTotalSumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalDiscountSumLabel
        '
        Me.TotalDiscountSumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalDiscountSumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalDiscountSumLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TotalDiscountSumLabel.Location = New System.Drawing.Point(348, 275)
        Me.TotalDiscountSumLabel.Name = "TotalDiscountSumLabel"
        Me.TotalDiscountSumLabel.Size = New System.Drawing.Size(100, 23)
        Me.TotalDiscountSumLabel.TabIndex = 9
        Me.TotalDiscountSumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalDueSumLabel
        '
        Me.TotalDueSumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalDueSumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalDueSumLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TotalDueSumLabel.Location = New System.Drawing.Point(348, 315)
        Me.TotalDueSumLabel.Name = "TotalDueSumLabel"
        Me.TotalDueSumLabel.Size = New System.Drawing.Size(100, 23)
        Me.TotalDueSumLabel.TabIndex = 10
        Me.TotalDueSumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CalculateButton
        '
        Me.CalculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateButton.Location = New System.Drawing.Point(89, 278)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(121, 31)
        Me.CalculateButton.TabIndex = 11
        Me.CalculateButton.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Click here to calculate costs")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'NewItemButton
        '
        Me.NewItemButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewItemButton.Location = New System.Drawing.Point(89, 338)
        Me.NewItemButton.Name = "NewItemButton"
        Me.NewItemButton.Size = New System.Drawing.Size(121, 31)
        Me.NewItemButton.TabIndex = 12
        Me.NewItemButton.Text = "New &Item"
        Me.ToolTip1.SetToolTip(Me.NewItemButton, "Click here to input new item")
        Me.NewItemButton.UseVisualStyleBackColor = True
        '
        'NewCustomerButton
        '
        Me.NewCustomerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewCustomerButton.Location = New System.Drawing.Point(21, 395)
        Me.NewCustomerButton.Name = "NewCustomerButton"
        Me.NewCustomerButton.Size = New System.Drawing.Size(121, 31)
        Me.NewCustomerButton.TabIndex = 13
        Me.NewCustomerButton.Text = "Ne&w Customer"
        Me.ToolTip1.SetToolTip(Me.NewCustomerButton, "Click here to start over")
        Me.NewCustomerButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(171, 395)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(121, 31)
        Me.PrintButton.TabIndex = 14
        Me.PrintButton.Text = "P&rint"
        Me.ToolTip1.SetToolTip(Me.PrintButton, "Click here to print")
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(327, 395)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(121, 31)
        Me.ExitButton.TabIndex = 15
        Me.ExitButton.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Click here to exit program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 445)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(230, 23)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Programmed by Andrew Hedy"
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
        Me.ClientSize = New System.Drawing.Size(501, 487)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.NewCustomerButton)
        Me.Controls.Add(Me.NewItemButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.TotalDueSumLabel)
        Me.Controls.Add(Me.TotalDiscountSumLabel)
        Me.Controls.Add(Me.SubTotalSumLabel)
        Me.Controls.Add(Me.ServiceCostSumLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PermanentMakeupRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ManicureRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents HairStylingRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MakeOverRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TenRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TwentyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents NoDiscountRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ServiceCostSumLabel As System.Windows.Forms.Label
    Friend WithEvents SubTotalSumLabel As System.Windows.Forms.Label
    Friend WithEvents TotalDiscountSumLabel As System.Windows.Forms.Label
    Friend WithEvents TotalDueSumLabel As System.Windows.Forms.Label
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents NewItemButton As System.Windows.Forms.Button
    Friend WithEvents NewCustomerButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
