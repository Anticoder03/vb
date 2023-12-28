Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            Me.BackColor = Color.Red
        ElseIf CheckBox2.Checked Then
            Me.BackColor = Color.Teal
        ElseIf CheckBox3.Checked Then
            Me.BackColor = Color.Blue
        ElseIf CheckBox4.Checked Then
            Me.BackColor = Color.HotPink
        End If
    End Sub
End Class
