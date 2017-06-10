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
' Description:    Demo using Textboxes for numeric input and the ErrorProvider.
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
    End Sub

    ' Allow only Carriage Return (13), BackSpace(8) and Period(46) and Numbers.
    Private Sub KeyPressTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles KeyPressTextBox.KeyPress

        Dim ctrl As Control = CType(sender, Control)
        MyErrorProvider.SetError(ctrl, String.Empty)
        If Asc(e.KeyChar) <> 13 AndAlso
            Asc(e.KeyChar) <> 8 AndAlso
            Asc(e.KeyChar) <> 46 AndAlso
            Not IsNumeric(e.KeyChar) Then
            MyErrorProvider.SetError(ctrl, "Please enter numbers only.")
            e.Handled = True
        End If
    End Sub

    Private Sub ValidatingTextBox_Validating(sender As Object, e As CancelEventArgs) _
        Handles ValidatingTextBox.Validating

        Dim ctrl As Control = CType(sender, Control)
        MyErrorProvider.SetError(ctrl, String.Empty)
        Try
            ValidateIsRequired(ctrl.Text)
            ValidateIsNumeric(ctrl.Text)
            ValidateInRange(ctrl.Text, 0, 100)
        Catch ex As Exception
            MyErrorProvider.SetError(ctrl, ex.Message)
            e.Cancel = True
        End Try
    End Sub


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

End Class
