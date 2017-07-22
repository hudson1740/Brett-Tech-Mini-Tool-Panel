<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Browser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FaderTheme1 = New Fader_Theme.FaderTheme()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.FaderControlBox1 = New Fader_Theme.FaderControlBox()
        Me.FaderTextBox1 = New Fader_Theme.FaderTextBox()
        Me.FaderButton1 = New Fader_Theme.FaderButton()
        Me.MenuStrip1.SuspendLayout()
        Me.FaderTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(16, 38)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(128, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EXITToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'FaderTheme1
        '
        Me.FaderTheme1.Controls.Add(Me.FaderButton1)
        Me.FaderTheme1.Controls.Add(Me.FaderTextBox1)
        Me.FaderTheme1.Controls.Add(Me.FaderControlBox1)
        Me.FaderTheme1.Controls.Add(Me.WebBrowser1)
        Me.FaderTheme1.Controls.Add(Me.MenuStrip1)
        Me.FaderTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FaderTheme1.HeaderAlignment = Fader_Theme.AlignmentStyle.Center
        Me.FaderTheme1.Icon = Nothing
        Me.FaderTheme1.Location = New System.Drawing.Point(0, 0)
        Me.FaderTheme1.MaximumSize = New System.Drawing.Size(1168, 748)
        Me.FaderTheme1.Name = "FaderTheme1"
        Me.FaderTheme1.ShowHeader = True
        Me.FaderTheme1.ShowIcon = True
        Me.FaderTheme1.Size = New System.Drawing.Size(1168, 748)
        Me.FaderTheme1.TabIndex = 1
        Me.FaderTheme1.Text = "Brett Tech Browser"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.EXITToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(21, 110)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(1125, 613)
        Me.WebBrowser1.TabIndex = 1
        Me.WebBrowser1.Url = New System.Uri("http://www.Brett-TechRepair.Com", System.UriKind.Absolute)
        '
        'FaderControlBox1
        '
        Me.FaderControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FaderControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.FaderControlBox1.Location = New System.Drawing.Point(1056, 12)
        Me.FaderControlBox1.MaximumDisable = False
        Me.FaderControlBox1.MinimumDisable = False
        Me.FaderControlBox1.Name = "FaderControlBox1"
        Me.FaderControlBox1.Size = New System.Drawing.Size(85, 30)
        Me.FaderControlBox1.TabIndex = 2
        Me.FaderControlBox1.Text = "FaderControlBox1"
        '
        'FaderTextBox1
        '
        Me.FaderTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.FaderTextBox1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.FaderTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.FaderTextBox1.Location = New System.Drawing.Point(21, 71)
        Me.FaderTextBox1.MaxLength = 32767
        Me.FaderTextBox1.MultiLine = False
        Me.FaderTextBox1.Name = "FaderTextBox1"
        Me.FaderTextBox1.ReadOnly = False
        Me.FaderTextBox1.Size = New System.Drawing.Size(931, 30)
        Me.FaderTextBox1.TabIndex = 3
        Me.FaderTextBox1.Text = "Type In A Website . . ."
        Me.FaderTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FaderTextBox1.UseSystemPasswordChar = False
        '
        'FaderButton1
        '
        Me.FaderButton1.BackColor = System.Drawing.Color.Transparent
        Me.FaderButton1.Location = New System.Drawing.Point(957, 68)
        Me.FaderButton1.Name = "FaderButton1"
        Me.FaderButton1.Size = New System.Drawing.Size(59, 35)
        Me.FaderButton1.TabIndex = 4
        Me.FaderButton1.Text = ">"
        '
        'Browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 748)
        Me.Controls.Add(Me.FaderTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(1168, 748)
        Me.Name = "Browser"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Browser"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.FaderTheme1.ResumeLayout(False)
        Me.FaderTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FaderTheme1 As Fader_Theme.FaderTheme
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents FaderControlBox1 As Fader_Theme.FaderControlBox
    Friend WithEvents FaderButton1 As Fader_Theme.FaderButton
    Friend WithEvents FaderTextBox1 As Fader_Theme.FaderTextBox
End Class
