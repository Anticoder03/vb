Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox2.Items.Add(ListBox1.SelectedItem)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox2.Items.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a As Byte
        For a = 1 To ListBox1.Items.Count - 1
            ListBox2.Items.Add(ListBox1.Items(a).ToString)
        Next
    End Sub
End Class
