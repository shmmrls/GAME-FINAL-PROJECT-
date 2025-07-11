Public Class MEDAGAINN
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        My.Computer.Audio.Play("C:\\Users\\ALLEIA\\OneDrive\\Documents\\VISUAL BASIC\\GAME (FINAL PROJECT)\\Resources\\GAMESTART.wav", AudioPlayMode.Background)
        MEDIUM.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        My.Computer.Audio.Play("C:\\Users\\ALLEIA\\OneDrive\\Documents\\VISUAL BASIC\\GAME (FINAL PROJECT)\\Resources\\GAMESTART.wav", AudioPlayMode.Background)
        Home.Show()
        Me.Hide()
    End Sub
End Class