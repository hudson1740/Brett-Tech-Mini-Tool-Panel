Public Class Form3
    Private Sub FaderButton2_Click(sender As Object, e As EventArgs) Handles FaderButton2.Click
        Browser.Show()
    End Sub

    Private Sub Form3_DragLeave(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form3_Leave(sender As Object, e As EventArgs)
        Form1.WindowState = System.Windows.Forms.FormWindowState.Normal
    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.WindowState = System.Windows.Forms.FormWindowState.Normal
    End Sub
End Class