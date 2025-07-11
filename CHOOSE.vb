Public Class CHOOSE
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        My.Computer.Audio.Play("C:\\Users\\ALLEIA\\OneDrive\\Documents\\VISUAL BASIC\\GAME (FINAL PROJECT)\\Resources\\GAMESTART.wav", AudioPlayMode.Background)
        EASY.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        My.Computer.Audio.Play("C:\\Users\\ALLEIA\\OneDrive\\Documents\\VISUAL BASIC\\GAME (FINAL PROJECT)\\Resources\\GAMESTART.wav", AudioPlayMode.Background)
        MEDIUM.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        My.Computer.Audio.Play("C:\\Users\\ALLEIA\\OneDrive\\Documents\\VISUAL BASIC\\GAME (FINAL PROJECT)\\Resources\\GAMESTART.wav", AudioPlayMode.Background)
        HARD.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        My.Computer.Audio.Play("C:\\Users\\ALLEIA\\OneDrive\\Documents\\VISUAL BASIC\\GAME (FINAL PROJECT)\\Resources\\GAMESTART.wav", AudioPlayMode.Background)
        Home.Show()
        Me.Hide()
    End Sub
End Class