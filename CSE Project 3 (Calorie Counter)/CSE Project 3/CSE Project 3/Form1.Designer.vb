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
        Me.CarbsCalTextBox = New System.Windows.Forms.TextBox()
        Me.ProteinCalTextBox = New System.Windows.Forms.TextBox()
        Me.FatCalTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.NextItemButton = New System.Windows.Forms.Button()
        Me.NewMealButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ItemCalLabel = New System.Windows.Forms.Label()
        Me.NumberOfItemsLabel = New System.Windows.Forms.Label()
        Me.TotalCalLabel = New System.Windows.Forms.Label()
        Me.TotalItemCaloriesLabel = New System.Windows.Forms.Label()
        Me.TotalNumberOfItemsLabel = New System.Windows.Forms.Label()
        Me.TotalNumberOfCaloriesLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CarbsCalTextBox)
        Me.GroupBox1.Controls.Add(Me.ProteinCalTextBox)
        Me.GroupBox1.Controls.Add(Me.FatCalTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(194, 176)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grams"
        '
        'CarbsCalTextBox
        '
        Me.CarbsCalTextBox.Location = New System.Drawing.Point(82, 128)
        Me.CarbsCalTextBox.Name = "CarbsCalTextBox"
        Me.CarbsCalTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CarbsCalTextBox.TabIndex = 5
        Me.CarbsCalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.CarbsCalTextBox, "Enter total grams of carbohydrates")
        '
        'ProteinCalTextBox
        '
        Me.ProteinCalTextBox.Location = New System.Drawing.Point(82, 82)
        Me.ProteinCalTextBox.Name = "ProteinCalTextBox"
        Me.ProteinCalTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ProteinCalTextBox.TabIndex = 4
        Me.ProteinCalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.ProteinCalTextBox, "Enter total grams of protein")
        '
        'FatCalTextBox
        '
        Me.FatCalTextBox.Location = New System.Drawing.Point(82, 35)
        Me.FatCalTextBox.Name = "FatCalTextBox"
        Me.FatCalTextBox.Size = New System.Drawing.Size(100, 26)
        Me.FatCalTextBox.TabIndex = 3
        Me.FatCalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.FatCalTextBox, "Enter total grams of fat")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Carbs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Protein"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fat"
        '
        'CalculateButton
        '
        Me.CalculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateButton.Location = New System.Drawing.Point(58, 236)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(102, 36)
        Me.CalculateButton.TabIndex = 1
        Me.CalculateButton.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Calculates total grams into calories")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(232, 277)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(102, 36)
        Me.PrintButton.TabIndex = 4
        Me.PrintButton.Text = "&Print"
        Me.ToolTip1.SetToolTip(Me.PrintButton, "Prints Program")
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'NextItemButton
        '
        Me.NextItemButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextItemButton.Location = New System.Drawing.Point(180, 236)
        Me.NextItemButton.Name = "NextItemButton"
        Me.NextItemButton.Size = New System.Drawing.Size(102, 36)
        Me.NextItemButton.TabIndex = 2
        Me.NextItemButton.Text = "&Next Item"
        Me.ToolTip1.SetToolTip(Me.NextItemButton, "Starts next item entry")
        Me.NextItemButton.UseVisualStyleBackColor = True
        '
        'NewMealButton
        '
        Me.NewMealButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewMealButton.Location = New System.Drawing.Point(302, 237)
        Me.NewMealButton.Name = "NewMealButton"
        Me.NewMealButton.Size = New System.Drawing.Size(102, 35)
        Me.NewMealButton.TabIndex = 3
        Me.NewMealButton.Text = "New &Meal"
        Me.ToolTip1.SetToolTip(Me.NewMealButton, "Starts whole new meal")
        Me.NewMealButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(114, 278)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(102, 35)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exits program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Programmed by Andrew Hedy"
        '
        'ItemCalLabel
        '
        Me.ItemCalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemCalLabel.Location = New System.Drawing.Point(219, 66)
        Me.ItemCalLabel.Name = "ItemCalLabel"
        Me.ItemCalLabel.Size = New System.Drawing.Size(115, 23)
        Me.ItemCalLabel.TabIndex = 7
        Me.ItemCalLabel.Text = "Item Calories"
        '
        'NumberOfItemsLabel
        '
        Me.NumberOfItemsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfItemsLabel.Location = New System.Drawing.Point(219, 113)
        Me.NumberOfItemsLabel.Name = "NumberOfItemsLabel"
        Me.NumberOfItemsLabel.Size = New System.Drawing.Size(135, 23)
        Me.NumberOfItemsLabel.TabIndex = 8
        Me.NumberOfItemsLabel.Text = "Number of Items"
        '
        'TotalCalLabel
        '
        Me.TotalCalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCalLabel.Location = New System.Drawing.Point(219, 162)
        Me.TotalCalLabel.Name = "TotalCalLabel"
        Me.TotalCalLabel.Size = New System.Drawing.Size(112, 23)
        Me.TotalCalLabel.TabIndex = 9
        Me.TotalCalLabel.Text = "Total Calories"
        '
        'TotalItemCaloriesLabel
        '
        Me.TotalItemCaloriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalItemCaloriesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalItemCaloriesLabel.Location = New System.Drawing.Point(340, 65)
        Me.TotalItemCaloriesLabel.Name = "TotalItemCaloriesLabel"
        Me.TotalItemCaloriesLabel.Size = New System.Drawing.Size(100, 23)
        Me.TotalItemCaloriesLabel.TabIndex = 10
        Me.TotalItemCaloriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalNumberOfItemsLabel
        '
        Me.TotalNumberOfItemsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalNumberOfItemsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalNumberOfItemsLabel.Location = New System.Drawing.Point(361, 113)
        Me.TotalNumberOfItemsLabel.Name = "TotalNumberOfItemsLabel"
        Me.TotalNumberOfItemsLabel.Size = New System.Drawing.Size(79, 23)
        Me.TotalNumberOfItemsLabel.TabIndex = 11
        Me.TotalNumberOfItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalNumberOfCaloriesLabel
        '
        Me.TotalNumberOfCaloriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalNumberOfCaloriesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalNumberOfCaloriesLabel.Location = New System.Drawing.Point(340, 162)
        Me.TotalNumberOfCaloriesLabel.Name = "TotalNumberOfCaloriesLabel"
        Me.TotalNumberOfCaloriesLabel.Size = New System.Drawing.Size(100, 23)
        Me.TotalNumberOfCaloriesLabel.TabIndex = 12
        Me.TotalNumberOfCaloriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(159, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 26)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Calorie Counter"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(451, 389)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TotalNumberOfCaloriesLabel)
        Me.Controls.Add(Me.TotalNumberOfItemsLabel)
        Me.Controls.Add(Me.TotalItemCaloriesLabel)
        Me.Controls.Add(Me.TotalCalLabel)
        Me.Controls.Add(Me.NumberOfItemsLabel)
        Me.Controls.Add(Me.ItemCalLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.NewMealButton)
        Me.Controls.Add(Me.NextItemButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CarbsCalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProteinCalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FatCalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents NextItemButton As System.Windows.Forms.Button
    Friend WithEvents NewMealButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ItemCalLabel As System.Windows.Forms.Label
    Friend WithEvents NumberOfItemsLabel As System.Windows.Forms.Label
    Friend WithEvents TotalCalLabel As System.Windows.Forms.Label
    Friend WithEvents TotalItemCaloriesLabel As System.Windows.Forms.Label
    Friend WithEvents TotalNumberOfItemsLabel As System.Windows.Forms.Label
    Friend WithEvents TotalNumberOfCaloriesLabel As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
