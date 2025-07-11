Public Class ABOUT
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        My.Computer.Audio.Play("C:\\Users\\ALLEIA\\OneDrive\\Documents\\VISUAL BASIC\\GAME (FINAL PROJECT)\\Resources\\GAMESTART.wav", AudioPlayMode.Background)
        Home.Show()
        Me.Hide()
    End Sub
End Class