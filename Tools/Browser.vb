Public Class Browser
    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub FaderButton1_Click(sender As Object, e As EventArgs) Handles FaderButton1.Click
        WebBrowser1.Navigate(FaderTextBox1.Text)
    End Sub
End Class