Public Class Form1
    Private Const Length As Integer = 2

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox(TextBox1.Text, MsgBoxStyle.Information, "Your text")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak(TextBox1.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        MsgBox(TrackBar1.Value, MsgBoxStyle.Information, "Dat bar value")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim playnew As New Form1
        playnew.Show()
        MsgBox("bonjour", MsgBoxStyle.Information, "New window")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Adios!", MsgBoxStyle.Information, "Y DO U YEET ME")
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MsgBox("Progress bar is at 100% !", MsgBoxStyle.Information, "Progress bar")
            ProgressBar1.Value = 0
        Else
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rnd As New Random
        Cursor.Position = New Point(rnd.Next(0, My.Computer.Screen.Bounds.Width), rnd.Next(0, My.Computer.Screen.Bounds.Height))
        MsgBox("Cursor teleported!", MsgBoxStyle.Information, "Naruto intensifies")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("https://www.youtube.com/channel/UClKapNqEC8M13ZMcDTorQ_g")
        MsgBox("Subscribe to my channel!", MsgBoxStyle.Information, "Creator of this playground")
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Label2.Text = (TrackBar1.Value)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label4.Text = Format(DateAndTime.Now.ToString("hh:mm:ss"))
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim Ran As New Random
        MsgBox(Ran.Next(0, 1000000), MsgBoxStyle.Information, "Can you count them all?")
    End Sub
End Class
