<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        carchoiceGroupBox = New GroupBox()
        camaroRadioButton = New RadioButton()
        benzRadioButton = New RadioButton()
        hondaRadioButton = New RadioButton()
        lexusRadioButton = New RadioButton()
        vwRadioButton = New RadioButton()
        toyotaRadioButton = New RadioButton()
        exteriorGroupBox = New GroupBox()
        detailingRadioButton = New RadioButton()
        pearlRadioButton = New RadioButton()
        standardRadioButton = New RadioButton()
        accessoriesGroupBox = New GroupBox()
        gpsCheckBox = New CheckBox()
        leatherCheckBox = New CheckBox()
        stereoCheckBox = New CheckBox()
        nextButton = New Button()
        calculateButton = New Button()
        clearButton = New Button()
        exitButton = New Button()
        GroupBox1 = New GroupBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        totalcarsalesTextBox = New TextBox()
        noofsalesTextBox = New TextBox()
        subtotalTextBox = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        amountdueTextBox = New TextBox()
        allowanceTextBox = New TextBox()
        totalTextBox = New TextBox()
        Label1 = New Label()
        carchoiceGroupBox.SuspendLayout()
        exteriorGroupBox.SuspendLayout()
        accessoriesGroupBox.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' carchoiceGroupBox
        ' 
        carchoiceGroupBox.Controls.Add(camaroRadioButton)
        carchoiceGroupBox.Controls.Add(benzRadioButton)
        carchoiceGroupBox.Controls.Add(hondaRadioButton)
        carchoiceGroupBox.Controls.Add(lexusRadioButton)
        carchoiceGroupBox.Controls.Add(vwRadioButton)
        carchoiceGroupBox.Controls.Add(toyotaRadioButton)
        carchoiceGroupBox.Location = New Point(23, 31)
        carchoiceGroupBox.Name = "carchoiceGroupBox"
        carchoiceGroupBox.Size = New Size(608, 107)
        carchoiceGroupBox.TabIndex = 0
        carchoiceGroupBox.TabStop = False
        carchoiceGroupBox.Text = "Car Choice"
        ' 
        ' camaroRadioButton
        ' 
        camaroRadioButton.AutoSize = True
        camaroRadioButton.Location = New Point(392, 67)
        camaroRadioButton.Name = "camaroRadioButton"
        camaroRadioButton.Size = New Size(190, 20)
        camaroRadioButton.TabIndex = 5
        camaroRadioButton.TabStop = True
        camaroRadioButton.Text = "Chevroley Camaro ($49,890)"
        camaroRadioButton.UseVisualStyleBackColor = True
        ' 
        ' benzRadioButton
        ' 
        benzRadioButton.AutoSize = True
        benzRadioButton.Location = New Point(392, 23)
        benzRadioButton.Name = "benzRadioButton"
        benzRadioButton.Size = New Size(213, 20)
        benzRadioButton.TabIndex = 4
        benzRadioButton.TabStop = True
        benzRadioButton.Text = "Mercedes C300 Sedan ($41,600)"
        benzRadioButton.UseVisualStyleBackColor = True
        ' 
        ' hondaRadioButton
        ' 
        hondaRadioButton.AutoSize = True
        hondaRadioButton.Location = New Point(211, 67)
        hondaRadioButton.Name = "hondaRadioButton"
        hondaRadioButton.Size = New Size(151, 20)
        hondaRadioButton.TabIndex = 3
        hondaRadioButton.TabStop = True
        hondaRadioButton.Text = "Honda Civic ($32,545)"
        hondaRadioButton.UseVisualStyleBackColor = True
        ' 
        ' lexusRadioButton
        ' 
        lexusRadioButton.AutoSize = True
        lexusRadioButton.Location = New Point(211, 23)
        lexusRadioButton.Name = "lexusRadioButton"
        lexusRadioButton.Size = New Size(135, 20)
        lexusRadioButton.TabIndex = 2
        lexusRadioButton.TabStop = True
        lexusRadioButton.Text = "Lexus LX ($93,915)"
        lexusRadioButton.UseVisualStyleBackColor = True
        ' 
        ' vwRadioButton
        ' 
        vwRadioButton.AutoSize = True
        vwRadioButton.Location = New Point(18, 67)
        vwRadioButton.Name = "vwRadioButton"
        vwRadioButton.Size = New Size(185, 20)
        vwRadioButton.TabIndex = 1
        vwRadioButton.TabStop = True
        vwRadioButton.Text = "Volkswagen Atlas ($39,420)"
        vwRadioButton.UseVisualStyleBackColor = True
        ' 
        ' toyotaRadioButton
        ' 
        toyotaRadioButton.AutoSize = True
        toyotaRadioButton.Location = New Point(18, 28)
        toyotaRadioButton.Name = "toyotaRadioButton"
        toyotaRadioButton.Size = New Size(165, 20)
        toyotaRadioButton.TabIndex = 0
        toyotaRadioButton.TabStop = True
        toyotaRadioButton.Text = "Toyota Camry ($30,000)"
        toyotaRadioButton.UseVisualStyleBackColor = True
        ' 
        ' exteriorGroupBox
        ' 
        exteriorGroupBox.Controls.Add(detailingRadioButton)
        exteriorGroupBox.Controls.Add(pearlRadioButton)
        exteriorGroupBox.Controls.Add(standardRadioButton)
        exteriorGroupBox.Location = New Point(23, 156)
        exteriorGroupBox.Name = "exteriorGroupBox"
        exteriorGroupBox.Size = New Size(289, 147)
        exteriorGroupBox.TabIndex = 1
        exteriorGroupBox.TabStop = False
        exteriorGroupBox.Text = "Exterior Finish"
        ' 
        ' detailingRadioButton
        ' 
        detailingRadioButton.AutoSize = True
        detailingRadioButton.Location = New Point(18, 108)
        detailingRadioButton.Name = "detailingRadioButton"
        detailingRadioButton.Size = New Size(204, 20)
        detailingRadioButton.TabIndex = 3
        detailingRadioButton.TabStop = True
        detailingRadioButton.Text = "Customized Detailing ($698.94)"
        detailingRadioButton.UseVisualStyleBackColor = True
        ' 
        ' pearlRadioButton
        ' 
        pearlRadioButton.AutoSize = True
        pearlRadioButton.Location = New Point(18, 71)
        pearlRadioButton.Name = "pearlRadioButton"
        pearlRadioButton.Size = New Size(137, 20)
        pearlRadioButton.TabIndex = 2
        pearlRadioButton.TabStop = True
        pearlRadioButton.Text = "Pearlized ($543.27)"
        pearlRadioButton.UseVisualStyleBackColor = True
        ' 
        ' standardRadioButton
        ' 
        standardRadioButton.AutoSize = True
        standardRadioButton.Location = New Point(18, 35)
        standardRadioButton.Name = "standardRadioButton"
        standardRadioButton.Size = New Size(151, 20)
        standardRadioButton.TabIndex = 1
        standardRadioButton.TabStop = True
        standardRadioButton.Text = "Standard (No Charge)"
        standardRadioButton.UseVisualStyleBackColor = True
        ' 
        ' accessoriesGroupBox
        ' 
        accessoriesGroupBox.Controls.Add(gpsCheckBox)
        accessoriesGroupBox.Controls.Add(leatherCheckBox)
        accessoriesGroupBox.Controls.Add(stereoCheckBox)
        accessoriesGroupBox.Location = New Point(336, 156)
        accessoriesGroupBox.Name = "accessoriesGroupBox"
        accessoriesGroupBox.Size = New Size(295, 147)
        accessoriesGroupBox.TabIndex = 2
        accessoriesGroupBox.TabStop = False
        accessoriesGroupBox.Text = "Accessories"
        ' 
        ' gpsCheckBox
        ' 
        gpsCheckBox.AutoSize = True
        gpsCheckBox.Location = New Point(6, 109)
        gpsCheckBox.Name = "gpsCheckBox"
        gpsCheckBox.Size = New Size(216, 20)
        gpsCheckBox.TabIndex = 2
        gpsCheckBox.Text = "Computer Navigation ($3,471.32)"
        gpsCheckBox.UseVisualStyleBackColor = True
        ' 
        ' leatherCheckBox
        ' 
        leatherCheckBox.AutoSize = True
        leatherCheckBox.Location = New Point(6, 71)
        leatherCheckBox.Name = "leatherCheckBox"
        leatherCheckBox.Size = New Size(175, 20)
        leatherCheckBox.TabIndex = 1
        leatherCheckBox.Text = "Leather Interior ($789.14)"
        leatherCheckBox.UseVisualStyleBackColor = True
        ' 
        ' stereoCheckBox
        ' 
        stereoCheckBox.AutoSize = True
        stereoCheckBox.Location = New Point(6, 35)
        stereoCheckBox.Name = "stereoCheckBox"
        stereoCheckBox.Size = New Size(170, 20)
        stereoCheckBox.TabIndex = 0
        stereoCheckBox.Text = "Stereo System ($524.67)"
        stereoCheckBox.UseVisualStyleBackColor = True
        ' 
        ' nextButton
        ' 
        nextButton.Location = New Point(556, 316)
        nextButton.Name = "nextButton"
        nextButton.Size = New Size(75, 40)
        nextButton.TabIndex = 3
        nextButton.Text = "Next"
        nextButton.UseVisualStyleBackColor = True
        ' 
        ' calculateButton
        ' 
        calculateButton.Location = New Point(556, 363)
        calculateButton.Name = "calculateButton"
        calculateButton.Size = New Size(75, 40)
        calculateButton.TabIndex = 4
        calculateButton.Text = "Calculate"
        calculateButton.UseVisualStyleBackColor = True
        ' 
        ' clearButton
        ' 
        clearButton.Location = New Point(556, 409)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(75, 40)
        clearButton.TabIndex = 5
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = True
        ' 
        ' exitButton
        ' 
        exitButton.Location = New Point(556, 455)
        exitButton.Name = "exitButton"
        exitButton.Size = New Size(75, 40)
        exitButton.TabIndex = 6
        exitButton.Text = "Exit"
        exitButton.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(totalcarsalesTextBox)
        GroupBox1.Controls.Add(noofsalesTextBox)
        GroupBox1.Controls.Add(subtotalTextBox)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(amountdueTextBox)
        GroupBox1.Controls.Add(allowanceTextBox)
        GroupBox1.Controls.Add(totalTextBox)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(21, 309)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(529, 186)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(45, 141)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 16)
        Label7.TabIndex = 12
        Label7.Text = "Total Car Sales:"
        Label7.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(3, 104)
        Label6.Name = "Label6"
        Label6.Size = New Size(142, 16)
        Label6.TabIndex = 11
        Label6.Text = "Number of Sales Made:"
        Label6.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(86, 66)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 16)
        Label5.TabIndex = 10
        Label5.Text = "Subtotal:"
        Label5.TextAlign = ContentAlignment.TopRight
        ' 
        ' totalcarsalesTextBox
        ' 
        totalcarsalesTextBox.Enabled = False
        totalcarsalesTextBox.Location = New Point(151, 138)
        totalcarsalesTextBox.Name = "totalcarsalesTextBox"
        totalcarsalesTextBox.ReadOnly = True
        totalcarsalesTextBox.Size = New Size(100, 23)
        totalcarsalesTextBox.TabIndex = 9
        totalcarsalesTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' noofsalesTextBox
        ' 
        noofsalesTextBox.Enabled = False
        noofsalesTextBox.Location = New Point(151, 101)
        noofsalesTextBox.Name = "noofsalesTextBox"
        noofsalesTextBox.ReadOnly = True
        noofsalesTextBox.Size = New Size(100, 23)
        noofsalesTextBox.TabIndex = 8
        noofsalesTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' subtotalTextBox
        ' 
        subtotalTextBox.Enabled = False
        subtotalTextBox.Location = New Point(151, 63)
        subtotalTextBox.Name = "subtotalTextBox"
        subtotalTextBox.ReadOnly = True
        subtotalTextBox.Size = New Size(100, 23)
        subtotalTextBox.TabIndex = 7
        subtotalTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(322, 141)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 16)
        Label4.TabIndex = 6
        Label4.Text = "Amount Due:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(281, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 16)
        Label3.TabIndex = 5
        Label3.Text = "Trade-in Allowance:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(363, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 16)
        Label2.TabIndex = 4
        Label2.Text = "Total:"
        Label2.TextAlign = ContentAlignment.TopRight
        ' 
        ' amountdueTextBox
        ' 
        amountdueTextBox.Enabled = False
        amountdueTextBox.Location = New Point(410, 138)
        amountdueTextBox.Name = "amountdueTextBox"
        amountdueTextBox.ReadOnly = True
        amountdueTextBox.Size = New Size(100, 23)
        amountdueTextBox.TabIndex = 3
        amountdueTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' allowanceTextBox
        ' 
        allowanceTextBox.Location = New Point(410, 101)
        allowanceTextBox.Name = "allowanceTextBox"
        allowanceTextBox.Size = New Size(100, 23)
        allowanceTextBox.TabIndex = 2
        allowanceTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' totalTextBox
        ' 
        totalTextBox.Enabled = False
        totalTextBox.Location = New Point(410, 63)
        totalTextBox.Name = "totalTextBox"
        totalTextBox.ReadOnly = True
        totalTextBox.Size = New Size(100, 23)
        totalTextBox.TabIndex = 1
        totalTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(400, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 16)
        Label1.TabIndex = 0
        Label1.Text = "Sales Tax (8%)"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(662, 518)
        Controls.Add(GroupBox1)
        Controls.Add(exitButton)
        Controls.Add(clearButton)
        Controls.Add(calculateButton)
        Controls.Add(nextButton)
        Controls.Add(accessoriesGroupBox)
        Controls.Add(exteriorGroupBox)
        Controls.Add(carchoiceGroupBox)
        Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        Text = "Form1"
        carchoiceGroupBox.ResumeLayout(False)
        carchoiceGroupBox.PerformLayout()
        exteriorGroupBox.ResumeLayout(False)
        exteriorGroupBox.PerformLayout()
        accessoriesGroupBox.ResumeLayout(False)
        accessoriesGroupBox.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents carchoiceGroupBox As GroupBox
    Friend WithEvents exteriorGroupBox As GroupBox
    Friend WithEvents accessoriesGroupBox As GroupBox
    Friend WithEvents camaroRadioButton As RadioButton
    Friend WithEvents benzRadioButton As RadioButton
    Friend WithEvents hondaRadioButton As RadioButton
    Friend WithEvents lexusRadioButton As RadioButton
    Friend WithEvents vwRadioButton As RadioButton
    Friend WithEvents toyotaRadioButton As RadioButton
    Friend WithEvents detailingRadioButton As RadioButton
    Friend WithEvents pearlRadioButton As RadioButton
    Friend WithEvents standardRadioButton As RadioButton
    Friend WithEvents gpsCheckBox As CheckBox
    Friend WithEvents leatherCheckBox As CheckBox
    Friend WithEvents stereoCheckBox As CheckBox
    Friend WithEvents nextButton As Button
    Friend WithEvents calculateButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents amountdueTextBox As TextBox
    Friend WithEvents allowanceTextBox As TextBox
    Friend WithEvents totalTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents totalcarsalesTextBox As TextBox
    Friend WithEvents noofsalesTextBox As TextBox
    Friend WithEvents subtotalTextBox As TextBox
    Friend WithEvents Label7 As Label

End Class
