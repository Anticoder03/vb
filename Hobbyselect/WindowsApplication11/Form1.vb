Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            Label1.Text = "Chess,  " & TextBox1.Text
        ElseIf CheckBox2.Checked Then
            Label1.Text = "Watch Anime,  " & TextBox1.Text
        ElseIf CheckBox3.Checked Then
            Label1.Text = "Reading,  " & TextBox1.Text
        ElseIf CheckBox4.Checked Then
            Label1.Text = "Coding,  " & TextBox1.Text
        End If
    End Sub
End Class
