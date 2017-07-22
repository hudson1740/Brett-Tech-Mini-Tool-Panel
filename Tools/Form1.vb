Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub
End Class
