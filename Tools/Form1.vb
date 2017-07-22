Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub Form1_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        MsgBox("Thank You For Using Brett Tech Mini Tool Panel", MsgBoxStyle.Information, Title:="Thank You")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Form3.Show()
    End Sub

    Private Sub BrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrowserToolStripMenuItem.Click
        Browser.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class
