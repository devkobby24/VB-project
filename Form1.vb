Imports System.Windows.Forms.ComponentModel.Com2Interop

Public Class Form1
    Dim subtotal As Decimal = 0
    Dim trade_in As Double = 0
    Dim no_of_sales As Integer = 0
    Dim total_car_sales As Integer = 0
    Dim Amount_due As Decimal = 0
    Dim total As Decimal
    Const toyota As Double = 30000
    Const lexus As Double = 93915
    Const benz As Double = 41600
    Const vw As Double = 39420
    Const camaro As Double = 49890
    Const honda As Double = 32545


    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        If MessageBox.Show("Do you want to close?", "Exit", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        If MessageBox.Show("Do you want to clear the form?", "Clear", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            benzRadioButton.Checked = False
            standardRadioButton.Checked = False
            pearlRadioButton.Checked = False
            detailingRadioButton.Checked = False
            stereoCheckBox.Checked = False
            leatherCheckBox.Checked = False
            gpsCheckBox.Checked = False
            lexusRadioButton.Checked = False
            toyotaRadioButton.Checked = False
            vwRadioButton.Checked = False
            camaroRadioButton.Checked = False
            hondaRadioButton.Checked = False
            allowanceTextBox.Clear()
            totalTextBox.Clear()
            subtotalTextBox.Clear()
            amountdueTextBox.Clear()
        End If
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Select Case True
            Case toyotaRadioButton.Checked
                subtotal = toyota
            Case lexusRadioButton.Checked
                subtotal = lexus
            Case vwRadioButton.Checked
                subtotal = vw
            Case benzRadioButton.Checked
                subtotal = benz
            Case camaroRadioButton.Checked
                subtotal = camaro
            Case hondaRadioButton.Checked
                subtotal = honda
            Case Else
                MessageBox.Show("Please select a car", "Error!", MessageBoxButtons.OK)
        End Select

        Select Case True
            Case standardRadioButton.Checked
                subtotal = subtotal
            Case pearlRadioButton.Checked
                subtotal += 543.27
            Case detailingRadioButton.Checked
                subtotal += 698.94
        End Select

        If stereoCheckBox.Checked Then
            subtotal += 524.67
        End If

        If leatherCheckBox.Checked Then
            subtotal += 789.14
        End If

        If gpsCheckBox.Checked Then
            subtotal += 3471.32
        End If

        total = 0.08 * subtotal

        If allowanceTextBox.Text = "" Then
            Amount_due = subtotal - trade_in + total
        Else
            Amount_due = subtotal + total - Decimal.Parse(allowanceTextBox.Text)
        End If


        totalTextBox.Text = total.ToString("C2")
        subtotalTextBox.Text = subtotal.ToString("c2")

        amountdueTextBox.Text = Amount_due.ToString("c2")


    End Sub
    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click


        benzRadioButton.Checked = False
        standardRadioButton.Checked = False
        pearlRadioButton.Checked = False
        detailingRadioButton.Checked = False
        stereoCheckBox.Checked = False
        leatherCheckBox.Checked = False
        gpsCheckBox.Checked = False
        lexusRadioButton.Checked = False
        toyotaRadioButton.Checked = False
        vwRadioButton.Checked = False
        camaroRadioButton.Checked = False
        hondaRadioButton.Checked = False
        allowanceTextBox.Clear()
        totalTextBox.Clear()
        subtotalTextBox.Clear()
        amountdueTextBox.Clear()


        total_car_sales += Amount_due

        totalcarsalesTextBox.Text = total_car_sales.ToString("c2")


        If Amount_due = 0 Then
            no_of_sales += 0
        Else
            no_of_sales += 1
        End If
        Amount_due = 0

        noofsalesTextBox.Text = no_of_sales


    End Sub


End Class
