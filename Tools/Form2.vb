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
End Class