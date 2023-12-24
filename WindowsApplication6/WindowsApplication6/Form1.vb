Public Class Form1
   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim width, height, area As Integer
        width = InputBox("Enter Width")
        height = InputBox("Enter Height")
        area = width * height
        MsgBox("Area is: " & area)
    End Sub
End Class
