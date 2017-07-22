Public Class Form2
    Private Sub FaderButton1_Click(sender As Object, e As EventArgs) Handles FaderButton1.Click
        Process.Start("Control", "mouse")
    End Sub

    Private Sub FaderTheme1_Leave(sender As Object, e As EventArgs) Handles FaderTheme1.Leave

    End Sub

    Private Sub FaderTheme1_Click(sender As Object, e As EventArgs) Handles FaderTheme1.Click

    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.WindowState = System.Windows.Forms.FormWindowState.Normal
    End Sub

    Private Sub FaderButton2_Click(sender As Object, e As EventArgs) Handles FaderButton2.Click
        Process.Start("Control", "Keyboard")
    End Sub

    Private Sub FaderButton3_Click(sender As Object, e As EventArgs) Handles FaderButton3.Click
        Process.Start("control", "wuaucpl.cpl")
    End Sub

    Private Sub FaderButton4_Click(sender As Object, e As EventArgs) Handles FaderButton4.Click
        Process.Start("control", "timedate.cpl")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Timer1.Start()
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()

        If Label1.ForeColor = Color.Red Then
            Label1.ForeColor = Color.Lime
            If Label1.ForeColor = Color.Lime Then
                Label1.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub FaderButton5_Click(sender As Object, e As EventArgs) Handles FaderButton5.Click
        Process.Start("Chrome.exe")
    End Sub
End Class