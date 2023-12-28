Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = Image.FromFile("C:\Users\Ashish\Desktop\HTML PROJECT\RUPH SITE PROJECTS\Some\img\download (2).jpg")

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            PictureBox1.Image = Image.FromFile("C:\Users\Ashish\Desktop\HTML PROJECT\RUPH SITE PROJECTS\Some\img\download.jpg")
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            PictureBox1.Image = Image.FromFile("C:\Users\Ashish\Desktop\HTML PROJECT\RUPH SITE PROJECTS\Some\img\download (8).jpg")
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            PictureBox1.Image = Image.FromFile("C:\Users\Ashish\Desktop\HTML PROJECT\RUPH SITE PROJECTS\Some\img\download (3).jpg")
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            PictureBox1.Image = Image.FromFile("C:\Users\Ashish\Desktop\HTML PROJECT\RUPH SITE PROJECTS\Some\img\download (2).jpg")
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        PictureBox1.SizeMode = PictureBoxSizeMode.Normal
    End Sub
End Class
