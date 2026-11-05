Public Class HARDAGAIN
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PlaySound("GAMESTART.wav")
        HARD.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PlaySound("GAMESTART.wav")
        Home.Show()
        Me.Hide()
    End Sub
End Class