'------------------------------------------------------------------------------------------
'           Notice of My Copyright and Intellectual Property Rights
'
'            Copyright © 2017 Joseph L. Bolen. All rights reserved.
'        All trademarks remain the property of their respective owners.
'
'    This program Is free software: you can redistribute it And/Or modify
'    it under the terms Of the GNU General Public License As published by
'    the Free Software Foundation, either version 3 Of the License, Or
'    any later version.
'
'    This program Is distributed In the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty Of
'    MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License For more details.
'
'    You should have received a copy Of the GNU General Public License
'    along with this program.  If Not, see < http: //www.gnu.org/licenses/>.
'
'-------------------------------------------------------------------------------------------
' Program Name:   Numeric Input Demo
' Class:          MainLine
'
' Author:         Joseph L. Bolen
' Date Created:   10 JUN 2017
'
' Description:    Demo for numeric input and the ErrorProvider.
'
'                 Note: The KeyPress event and the MaskedTextBox can shape the data,
'                       however both still require a Validating event to ensure
'                       that data is required or within a correct range.
'
'                 Documentation is at:
'                   App's documentation is at:  https://jaybeeoh.github.io/NumericInputDemo/
'                   Video tutorials at YouTube: http://www.youtube.com/user/bolenpresents
'-------------------------------------------------------------------------------------------

Imports System.ComponentModel

Public Class MainLine

    Private WithEvents MyErrorProvider As New ErrorProvider With {.BlinkStyle = ErrorBlinkStyle.NeverBlink}


    Private Sub MainLine_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load

        ' Allow tabbing when using ErrorProvider
        AutoValidate = Windows.Forms.AutoValidate.EnableAllowFocusChange

        NumericMaskedTextBox.BeepOnError = True
        NumericMaskedTextBox.Mask = "990"

        MyNumericUpDwn.Minimum = 0
        MyNumericUpDwn.Maximum = 100

    End Sub

#Region "     KeyPress example code."

    ' Allow only Carriage Return (13), BackSpace(8), Negative sign(45), Period(46) and Numbers.
    Private Sub KeyPressTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles KeyPressTextBox.KeyPress

        Dim ctrl As Control = CType(sender, Control)
        MyErrorProvider.SetError(ctrl, String.Empty)
        If Asc(e.KeyChar) <> 13 AndAlso
            Asc(e.KeyChar) <> 8 AndAlso
            Asc(e.KeyChar) <> 45 AndAlso
            Asc(e.KeyChar) <> 46 AndAlso
            Not IsNumeric(e.KeyChar) Then
            Beep()
            MyErrorProvider.SetError(ctrl, "Please enter numbers only.")
            e.Handled = True
            Exit Sub
        End If

        ' Negative sign must be first character.
        If Asc(e.KeyChar) = 45 AndAlso
                ctrl.Text.Length > 1 Then
            e.Handled = True
        End If

        ' Only one decimal point allowed using LINQ.
        If Asc(e.KeyChar) = 46 AndAlso
            ctrl.Text.Where(Function(ch) (ch = "."c)).Count() > 0 Then
            e.Handled = True
        End If

    End Sub

#End Region

#Region "     Validating event example code."

    Private Sub ValidatingTextBox_Validating(sender As Object, e As CancelEventArgs) _
        Handles ValidatingTextBox.Validating

        Dim ctrl As Control = CType(sender, Control)
        MyErrorProvider.SetError(ctrl, String.Empty)
        Try
            ValidateIsRequired(ctrl.Text)
            ValidateIsNumeric(ctrl.Text)
            ValidateInRange(ctrl.Text, 0, 100)
        Catch ex As Exception
            Beep()
            MyErrorProvider.SetError(ctrl, ex.Message)
            e.Cancel = True
        End Try
    End Sub

#End Region

#Region "     MaskedTextBox example code."

    Private Sub NumericMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) _
        Handles NumericMaskedTextBox.MaskInputRejected

        Dim maskedTB As MaskedTextBox = CType(sender, MaskedTextBox)
        MyErrorProvider.SetError(maskedTB, String.Empty)

        If maskedTB.MaskFull Then
            MyErrorProvider.SetError(maskedTB,
                                     "You cannot enter any more data into the field. Delete some digits in order to insert more data.")
        Else
            MyErrorProvider.SetError(maskedTB,
                                    $"Error: {e.RejectionHint} at position {e.Position + 1}.")
            ' Or ...
            ' $"Error: Digit required at positon {e.Position + 1}.")

        End If
    End Sub

    Private Sub NumericMaskedTextBox_Validating(sender As Object, e As CancelEventArgs) _
        Handles NumericMaskedTextBox.Validating

        Dim ctrl As Control = CType(sender, Control)
        MyErrorProvider.SetError(ctrl, String.Empty)
        Try
            ValidateInRange(ctrl.Text, 0, 100)
        Catch ex As Exception
            Beep()
            MyErrorProvider.SetError(ctrl, ex.Message)
            e.Cancel = True
        End Try

    End Sub

#End Region

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) _
        Handles SubmitButton.Click

        StatusLabel.Text = String.Empty

        If Not ValidateChildren() Then
            StatusLabel.ForeColor = Color.Red
            StatusLabel.Text = "Please correct entered data."
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
            Exit Sub
        End If

        StatusLabel.ForeColor = Color.Green
        StatusLabel.Text = "Data is has been validated."
    End Sub

    Private Sub MainLine_FormClosing(sender As Object, e As FormClosingEventArgs) _
        Handles Me.FormClosing

        e.Cancel = False    ' Allow close with errors pending using ErrorProvider.
    End Sub

#Region "    Validation Functions."

    ' Normally, these and other Validation functions as placed in their own module.
    Public Function ValidateIsRequired(ByVal value As String) As Boolean

        If String.IsNullOrWhiteSpace(value) Then
            Throw New InvalidExpressionException("A value is required.")
            Return False
        Else
            Return True
        End If
    End Function

    Public Function ValidateIsNumeric(ByVal value As String) As Boolean

        If Not IsNumeric(value) Then
            Throw New InvalidExpressionException("Value must be numeric.")
            Return False
        Else
            Return True
        End If
    End Function

    Public Function ValidateInRange(ByVal value As String,
                                  ByVal minValue As Double,
                                  ByVal maxValue As Double) As Boolean

        Dim valueDouble As Double = 0
        Double.TryParse(value, valueDouble)
        If valueDouble < minValue OrElse valueDouble > maxValue Then
            Throw New InvalidExpressionException(String.Format("Value is out of range, please enter a number between {0} and {1}.", minValue, maxValue))
            Return False
        Else
            Return True
        End If
    End Function

#End Region

End Class
