﻿Imports System.Windows.Forms.ComponentModel.Com2Interop

Public Class Form1
    Dim subtotal As Decimal = 0
    Dim trade_in As Double = 0
    Dim no_of_sales As Integer = 0
    Dim total_car_sales As Integer = 0
    Dim Amount_due As Decimal = 0
    Dim total As Decimal

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Select Case True
            Case toyotaRadioButton.Checked
                subtotal = 30000
            Case lexusRadioButton.Checked
                subtotal = 93915
            Case vwRadioButton.Checked
                subtotal = 39420
            Case benzRadioButton.Checked
                subtotal = 41600
            Case camaroRadioButton.Checked
                subtotal = 49890
            Case hondaRadioButton.Checked
                subtotal = 32545
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
        totalTextBox.Text = total.ToString("C2")
        subtotalTextBox.Text = subtotal.ToString("c2")

        If allowanceTextBox.Text = "" Then
            Amount_due = subtotal - trade_in + total
        Else
            Amount_due = subtotal + total - Decimal.Parse(allowanceTextBox.Text)
        End If
        amountdueTextBox.Text = Amount_due.ToString("c2")

    End Sub

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

        no_of_sales += 1
        total_car_sales += Amount_due
        noofsalesTextBox.Text = no_of_sales
        totalcarsalesTextBox.Text = total_car_sales.ToString("c2")


    End Sub
End Class
