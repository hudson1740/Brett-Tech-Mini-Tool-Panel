<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.FaderTheme1 = New Fader_Theme.FaderTheme()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FaderControlBox1 = New Fader_Theme.FaderControlBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FaderTheme1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FaderTheme1
        '
        Me.FaderTheme1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.FaderTheme1.Controls.Add(Me.FaderControlBox1)
        Me.FaderTheme1.Controls.Add(Me.Label1)
        Me.FaderTheme1.Controls.Add(Me.Button2)
        Me.FaderTheme1.Controls.Add(Me.Button1)
        Me.FaderTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FaderTheme1.HeaderAlignment = Fader_Theme.AlignmentStyle.Center
        Me.FaderTheme1.Icon = Nothing
        Me.FaderTheme1.Location = New System.Drawing.Point(0, 0)
        Me.FaderTheme1.Name = "FaderTheme1"
        Me.FaderTheme1.ShowHeader = True
        Me.FaderTheme1.ShowIcon = True
        Me.FaderTheme1.Size = New System.Drawing.Size(522, 304)
        Me.FaderTheme1.TabIndex = 0
        Me.FaderTheme1.Text = "Brett Tech Mini Tool Panel"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("AR DELANEY", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(38, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(204, 121)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "PC TOOLS"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("AR DELANEY", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(280, 133)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(191, 121)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Custom Tools"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("AR DESTINE", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(140, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please Choose An Option"
        '
        'FaderControlBox1
        '
        Me.FaderControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FaderControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.FaderControlBox1.Location = New System.Drawing.Point(419, 11)
        Me.FaderControlBox1.MaximumDisable = False
        Me.FaderControlBox1.MinimumDisable = False
        Me.FaderControlBox1.Name = "FaderControlBox1"
        Me.FaderControlBox1.Size = New System.Drawing.Size(85, 30)
        Me.FaderControlBox1.TabIndex = 3
        Me.FaderControlBox1.Text = "FaderControlBox1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowserToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(117, 48)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BrowserToolStripMenuItem
        '
        Me.BrowserToolStripMenuItem.Name = "BrowserToolStripMenuItem"
        Me.BrowserToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BrowserToolStripMenuItem.Text = "Browser"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 304)
        Me.Controls.Add(Me.FaderTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FaderTheme1.ResumeLayout(False)
        Me.FaderTheme1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FaderTheme1 As Fader_Theme.FaderTheme
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents FaderControlBox1 As Fader_Theme.FaderControlBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents BrowserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
