<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.FaderTheme1 = New Fader_Theme.FaderTheme()
        Me.FaderVerticalTabControl1 = New Fader_Theme.FaderVerticalTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FaderButton1 = New Fader_Theme.FaderButton()
        Me.FaderButton2 = New Fader_Theme.FaderButton()
        Me.FaderControlBox1 = New Fader_Theme.FaderControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FaderTheme1.SuspendLayout()
        Me.FaderVerticalTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FaderTheme1
        '
        Me.FaderTheme1.Controls.Add(Me.FaderControlBox1)
        Me.FaderTheme1.Controls.Add(Me.FaderVerticalTabControl1)
        Me.FaderTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FaderTheme1.HeaderAlignment = Fader_Theme.AlignmentStyle.Center
        Me.FaderTheme1.Icon = Nothing
        Me.FaderTheme1.Location = New System.Drawing.Point(0, 0)
        Me.FaderTheme1.Name = "FaderTheme1"
        Me.FaderTheme1.ShowHeader = True
        Me.FaderTheme1.ShowIcon = True
        Me.FaderTheme1.Size = New System.Drawing.Size(615, 532)
        Me.FaderTheme1.TabIndex = 0
        Me.FaderTheme1.Text = "Brett Tech Custom Tools"
        '
        'FaderVerticalTabControl1
        '
        Me.FaderVerticalTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.FaderVerticalTabControl1.Controls.Add(Me.TabPage1)
        Me.FaderVerticalTabControl1.ItemSize = New System.Drawing.Size(35, 100)
        Me.FaderVerticalTabControl1.Location = New System.Drawing.Point(16, 61)
        Me.FaderVerticalTabControl1.Multiline = True
        Me.FaderVerticalTabControl1.Name = "FaderVerticalTabControl1"
        Me.FaderVerticalTabControl1.SelectedIndex = 0
        Me.FaderVerticalTabControl1.Size = New System.Drawing.Size(587, 448)
        Me.FaderVerticalTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FaderVerticalTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.FaderButton2)
        Me.TabPage1.Controls.Add(Me.FaderButton1)
        Me.TabPage1.Location = New System.Drawing.Point(104, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(479, 440)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Custom"
        '
        'FaderButton1
        '
        Me.FaderButton1.BackColor = System.Drawing.Color.Transparent
        Me.FaderButton1.Location = New System.Drawing.Point(17, 21)
        Me.FaderButton1.Name = "FaderButton1"
        Me.FaderButton1.Size = New System.Drawing.Size(160, 35)
        Me.FaderButton1.TabIndex = 0
        Me.FaderButton1.Text = "Proccess"
        '
        'FaderButton2
        '
        Me.FaderButton2.BackColor = System.Drawing.Color.Transparent
        Me.FaderButton2.Location = New System.Drawing.Point(294, 21)
        Me.FaderButton2.Name = "FaderButton2"
        Me.FaderButton2.Size = New System.Drawing.Size(160, 35)
        Me.FaderButton2.TabIndex = 1
        Me.FaderButton2.Text = "Browser"
        '
        'FaderControlBox1
        '
        Me.FaderControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FaderControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.FaderControlBox1.Location = New System.Drawing.Point(508, 12)
        Me.FaderControlBox1.MaximumDisable = False
        Me.FaderControlBox1.MinimumDisable = False
        Me.FaderControlBox1.Name = "FaderControlBox1"
        Me.FaderControlBox1.Size = New System.Drawing.Size(85, 30)
        Me.FaderControlBox1.TabIndex = 1
        Me.FaderControlBox1.Text = "FaderControlBox1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(64, 394)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Brett Tech Custom Tools"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 532)
        Me.Controls.Add(Me.FaderTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FaderTheme1.ResumeLayout(False)
        Me.FaderVerticalTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FaderTheme1 As Fader_Theme.FaderTheme
    Friend WithEvents FaderVerticalTabControl1 As Fader_Theme.FaderVerticalTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents FaderButton2 As Fader_Theme.FaderButton
    Friend WithEvents FaderButton1 As Fader_Theme.FaderButton
    Friend WithEvents FaderControlBox1 As Fader_Theme.FaderControlBox
    Friend WithEvents Label1 As Label
End Class
