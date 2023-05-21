Imports System.Diagnostics
Imports System.Media

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInterval.Text = String.Format("Interval: {0} minute(s)", interval)
        beep = New SoundPlayer(sound_file$)
        beep.Load()
    End Sub

    Const sound_file$ = "Shylily - BEEPBEEPBEEPBEEEPBEEP.wav"
    Dim beep As SoundPlayer
    Const interval% = 7 ' in minutes
    Dim end_time As Date
    Dim is_playing As Boolean

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        RestartTimer()
    End Sub

    Sub RestartTimer()
        btnStart.Enabled = False
        Dim today = Date.Now
        end_time = today.AddMinutes(interval)
        tmrTrigger.Start()
    End Sub

    Sub CallScript()
        Process.Start("script.au3")
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
            is_playing = False
            beep.Stop()

            lblTimeLeft.Text = "00:00"
            CallScript()
            RestartTimer()
        End If
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        btnStart.Enabled = True
        tmrTrigger.Stop()
    End Sub
End Class
