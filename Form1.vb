Imports System.Diagnostics
Imports System.IO
Imports System.Media

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInterval.Text = String.Format("Interval: {0} minute(s)", interval)
        beep = New SoundPlayer(sound_file$)
        beep.Load()
    End Sub

    Const sound_file$ = "Shylily - BEEPBEEPBEEPBEEEPBEEP.wav"
    Const script_name$ = "script.au3"
    Const interval% = 7 ' in minutes

    Dim beep As SoundPlayer
    Dim end_time As Date
    Dim is_playing As Boolean

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        RestartTimer()
    End Sub

    Sub RestartTimer()
        ResetBeep()
        btnStart.Enabled = False
        Dim today = Date.Now
        end_time = today.AddMinutes(interval)
        tmrTrigger.Start()
    End Sub

    Sub CallScript()
        If Not File.Exists(script_name) Then
            btnStop.PerformClick()
            MessageBox.Show("Can't find {0}. Timer is stopped automatically.")
            Exit Sub
        End If

        Process.Start(script_name)
    End Sub

    Sub ResetBeep()
        is_playing = False
        beep.Stop()
    End Sub

    Private Sub tmrTrigger_Tick(sender As Object, e As EventArgs) Handles tmrTrigger.Tick
        Dim diff = end_time.Subtract(Date.Now)

        If diff.TotalSeconds <= 10 And Not is_playing Then
            is_playing = True
            beep.PlayLooping()
        End If

        If diff.TotalSeconds > 0 Then
            Debug.Print(diff.TotalSeconds)
            lblTimeLeft.Text = diff.ToString("mm':'ss")
        Else
            ResetBeep()

            lblTimeLeft.Text = "00:00"
            CallScript()
            RestartTimer()
        End If
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        btnStart.Enabled = True
        ResetBeep()
        tmrTrigger.Stop()
    End Sub
End Class
