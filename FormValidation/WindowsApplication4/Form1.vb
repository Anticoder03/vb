Imports System.Text.RegularExpressions
Public Class Form1
    'Function for name validation
    'Idea from stackoverflow
    'https://stackoverflow.com/questions/46520546/is-there-an-isalpha-function-in-vb-net
    Public Function checkname(ByVal name As String) As Boolean
        Dim a As Byte
        If name = "" Then
            Return False
        End If

        For a = 0 To Len(name) - 1
            If IsNumeric(name(a)) Then
                Return False
            End If
        Next
        Return True
    End Function
    'Function for Phone Number Validation
    Public Function check_number(ByVal number As String) As Boolean
        If number = "" Then
            Return False
        ElseIf Len(number) < 10 Then
            Return False
        Else
            Return True
        End If
    End Function
    'Function For Email Validation
    'Help From Stackoverflow
    'https://stackoverflow.com/questions/10129374/textbox-email-validation
    Public Function checkEmail(ByVal email As String) As Boolean
        Dim patten As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim match_email As Match = Regex.Match(email, patten)
        If match_email.Success Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function check_form(ByVal name As String, ByVal age As String, ByVal email As String, ByVal number As String) As Boolean
        ' Checking Phone Number Validation
        If Not check_number(number) Then
            MsgBox("Invalid Number")
            Return False

            'Checking Email Validation
        ElseIf Not checkEmail(email) Then
            MsgBox("Invalid Email")
            Return False
            'Checking Name Validation
        ElseIf Not checkname(name) Then
            MsgBox("Invalid Name")
            Return False
            'Checking Age Validation
        ElseIf age = "" Or age < 1 Then
            MsgBox("Invalid Age")
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Checking All The Validation
        ' If check_form(TextBox1.Text, TextBox2.Text, TextBox4.Text, TextBox5.Text) Then
        'MsgBox("Your Form Is Submited.")
        'End If
        Dim hob(5) As String
        Dim i As Byte = 0
        Dim a As Byte
        For Each b As RadioButton In GroupBox1.Controls.OfType(Of RadioButton)()
            If b.Checked = True Then
                MsgBox(b.Text)
            End If
        Next
        For Each c As CheckBox In GroupBox2.Controls.OfType(Of CheckBox)()
            If c.Checked Then
                hob(i) = c.Text
            End If
            i += 1
        Next
        For a = 0 To i - 1
            If hob(a) = "" Then
                Continue For
            Else
                MsgBox(hob(a))
            End If
        Next
    End Sub
End Class
