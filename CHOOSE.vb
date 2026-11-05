Public Class CHOOSE
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PlaySound("GAMESTART.wav")
        EASY.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PlaySound("GAMESTART.wav")
        MEDIUM.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PlaySound("GAMESTART.wav")
        HARD.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PlaySound("GAMESTART.wav")
        Home.Show()
        Me.Hide()
    End Sub
End Class