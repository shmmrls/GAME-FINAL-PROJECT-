Public Class Home
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PlaySound("GAMESTART.wav")
        CHOOSE.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PlaySound("GAMESTART.wav")
        ABOUT.Show()
        Me.Hide()
    End Sub
End Class
