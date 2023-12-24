Public Class Form1
    Public total, per As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim name As String
        Dim sub1, sub2, sub3, sub4, sub5 As Integer

        sub1 = TextBox2.Text
        sub2 = TextBox3.Text
        sub3 = TextBox4.Text
        sub4 = TextBox5.Text
        sub5 = TextBox6.Text
        total = sub1 + sub2 + sub3 + sub4 + sub5
        name = TextBox1.Text
        per = (total / 500) * 100
        MsgBox("Student name is: " & name & Chr(10) & "Vb.NET Marks is: " & TextBox2.Text & vbCrLf & "Web- 2 Marks is: " & TextBox3.Text & vbCrLf & "Java Marks is: " & TextBox4.Text & vbCrLf & "I o T Marks is: " & TextBox5.Text & vbCrLf & "I.S. Marks is: " & TextBox6.Text & vbCrLf & "Total is: " & total & vbCrLf & "Percentage is: " & per)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sub1, sub2, sub3, sub4, sub5 As Integer

        sub1 = TextBox2.Text
        sub2 = TextBox3.Text
        sub3 = TextBox4.Text
        sub4 = TextBox5.Text
        sub5 = TextBox6.Text
        total = sub1 + sub2 + sub3 + sub4 + sub5
        per = (total / 500) * 100
        MsgBox("Percentage is : " & per)
    End Sub
End Class
