Public Class Form1
    Dim b_col(4) As Color
    Dim f_col(4) As Color
    Dim pg As Boolean
    Public i As Byte
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        b_col(0) = Color.Black
        b_col(1) = Color.Blue
        b_col(2) = Color.BlueViolet
        b_col(3) = Color.Teal
        b_col(4) = Color.HotPink
        f_col(0) = Color.Wheat
        f_col(1) = Color.Black
        f_col(2) = Color.Red
        f_col(3) = Color.White
        f_col(4) = Color.Cyan
        Label1.Text = TimeOfDay
        Label2.Text = TimeOfDay
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.BackColor = b_col(i)
        Label2.ForeColor = f_col(i)
        i += 1
        If i >= 4 Then
            i = 0
        End If

        If pg = False Then
            Label2.Left = Label2.Left + 10

            If Label2.Left >= 500 Then
                pg = True
            End If
        Else
            Label2.Left = Label2.Left - 10
            If Label2.Left < 10 Then
                pg = False
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

End Class
