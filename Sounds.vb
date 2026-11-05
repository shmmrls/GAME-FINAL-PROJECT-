Imports System.IO

''' <summary>
''' Plays the game's sound effects from the "Resources" folder that is copied
''' next to the executable, so the game works on any machine.
''' </summary>
Module Sounds

    Friend Sub PlaySound(fileName As String)
        Try
            Dim fullPath As String = Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources", fileName)
            If File.Exists(fullPath) Then
                My.Computer.Audio.Play(fullPath, AudioPlayMode.Background)
            End If
        Catch ex As Exception
            ' A missing or unplayable sound should never crash the game.
            Debug.WriteLine("Could not play sound '" & fileName & "': " & ex.Message)
        End Try
    End Sub

End Module
