Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        c = a + b
        TextBox3.Text = c

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a, b, c As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        c = a - b
        TextBox4.Text = c
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a, b, c As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        c = a * b
        TextBox5.Text = c
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim a, b, c As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        c = a / b
        TextBox6.Text = c
    End Sub
End Class
