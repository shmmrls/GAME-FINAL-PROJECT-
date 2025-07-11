Public Class Home
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        My.Computer.Audio.Play("C:\\Users\\ALLEIA\\OneDrive\\Documents\\VISUAL BASIC\\GAME (FINAL PROJECT)\\Resources\\GAMESTART.wav", AudioPlayMode.Background)
        CHOOSE.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        My.Computer.Audio.Play("C:\\Users\\ALLEIA\\OneDrive\\Documents\\VISUAL BASIC\\GAME (FINAL PROJECT)\\Resources\\GAMESTART.wav", AudioPlayMode.Background)
        ABOUT.Show()
        Me.Hide()
    End Sub
End Class
