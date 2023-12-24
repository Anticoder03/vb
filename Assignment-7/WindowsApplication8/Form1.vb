Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim name, pass As String
        name = TextBox1.Text
        pass = TextBox2.Text

        'If name = "" Or pass = "" Then
        'MsgBox("Plese fill all filds")
        If name = "" Then
            MsgBox("Plese Enter The Name: ")
        ElseIf pass = "" Then
            MsgBox("Plese Enter Password: ")
        ElseIf IsNumeric(name) Then
            MsgBox("You can not enter number in name field")
        ElseIf pass.Length < 8 Then
            MsgBox("Password Shuld be 8 char Long")
        Else
            MsgBox("Hello, World!")
            TextBox1.Clear()
            TextBox2.Clear()

        End If
    End Sub
End Class
