Public Class ABOUT
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PlaySound("GAMESTART.wav")
        Home.Show()
        Me.Hide()
    End Sub
End Class