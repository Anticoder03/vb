Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim r, area As Integer
        r = InputBox("Enter Radious Of Circle: ")
        area = 3.14 * r * r
        MsgBox("Artea of circle is: " & area)
    End Sub
End Class
