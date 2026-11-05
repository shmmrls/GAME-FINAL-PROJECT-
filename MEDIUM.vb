Public Class MEDIUM
    Dim score As Integer = 0
    Dim timeLeft As Integer = 75
    Dim rnd As New Random()
    Dim comboCount As Integer = 0
    Dim penalty As Integer = 1



    Private Sub pb1Start_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PlaySound("GAMESTART.wav")
        score = 0
        timeLeft = 75
        Label1.Text = "Score: " & score
        Label2.Text = "Time: " & timeLeft
        Timer1.Start()
        MoveTarget()
    End Sub
    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If timeLeft > 0 Then
            timeLeft -= 1
            Label2.Text = "Time: " & timeLeft

            If timeLeft <= 10 Then
                Label2.ForeColor = Color.Red
            Else
                Label2.ForeColor = Color.Black
            End If
        Else
            Timer1.Stop()
            If score > My.Settings.HighScore Then
                My.Settings.HighScore = score
                My.Settings.Save()
                MessageBox.Show("New High Score! " & score, "Game Over")
            Else
                MessageBox.Show("Time's up! Final Score: " & score, "Game Over")
            End If

            MEDAGAINN.Show()
            Me.Hide()
            PlaySound("GAMEOVER.wav")
        End If

        If comboCount > 0 Then
            comboCount = 0
        End If
    End Sub

    Private Async Sub pbTarget_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PlaySound("CLICK.wav")
        comboCount += 1
        If comboCount >= 3 Then
            score += 3 ' 
        Else
            score += 1
        End If
        Label1.Text = "Score: " & score

        Dim originalSize = PictureBox4.Size
        PictureBox4.Size = New Size(originalSize.Width - 20, originalSize.Height - 20)
        Await Task.Delay(150)
        PictureBox4.Size = originalSize

        Await MoveTarget()
    End Sub
    Private Sub MEDIUM_Click(sender As Object, e As MouseEventArgs) Handles Me.Click
        If Not PictureBox4.Bounds.Contains(e.Location) Then
            PlaySound("WRONG.wav")
            comboCount = 0
            score -= penalty
            If score < 0 Then score = 0
            Label1.Text = "Score: " & score
        End If
    End Sub

    Private Async Function MoveTarget() As Task
        PictureBox4.Left = rnd.Next(Me.ClientSize.Width - PictureBox4.Width)
        PictureBox4.Top = rnd.Next(Me.ClientSize.Height - PictureBox4.Height)
    End Function



End Class

