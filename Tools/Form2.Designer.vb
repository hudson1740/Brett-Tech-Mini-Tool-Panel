<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.FaderControlBox1 = New Fader_Theme.FaderControlBox()
        Me.FaderVerticalTabControl1 = New Fader_Theme.FaderVerticalTabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.FaderButton1 = New Fader_Theme.FaderButton()
        Me.FaderButton2 = New Fader_Theme.FaderButton()
        Me.FaderButton3 = New Fader_Theme.FaderButton()
        Me.FaderButton4 = New Fader_Theme.FaderButton()
        Me.FaderButton5 = New Fader_Theme.FaderButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FaderTheme1.SuspendLayout()
        Me.FaderVerticalTabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'FaderTheme1
        '
        Me.FaderTheme1.Controls.Add(Me.FaderVerticalTabControl1)
        Me.FaderTheme1.Controls.Add(Me.FaderControlBox1)
        Me.FaderTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FaderTheme1.HeaderAlignment = Fader_Theme.AlignmentStyle.Center
        Me.FaderTheme1.Icon = Nothing
        Me.FaderTheme1.Location = New System.Drawing.Point(0, 0)
        Me.FaderTheme1.Name = "FaderTheme1"
        Me.FaderTheme1.ShowHeader = True
        Me.FaderTheme1.ShowIcon = True
        Me.FaderTheme1.Size = New System.Drawing.Size(668, 599)
        Me.FaderTheme1.TabIndex = 0
        Me.FaderTheme1.Text = "PC TOOLS"
        '
        'FaderControlBox1
        '
        Me.FaderControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FaderControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.FaderControlBox1.Location = New System.Drawing.Point(557, 12)
        Me.FaderControlBox1.MaximumDisable = False
        Me.FaderControlBox1.MinimumDisable = False
        Me.FaderControlBox1.Name = "FaderControlBox1"
        Me.FaderControlBox1.Size = New System.Drawing.Size(85, 30)
        Me.FaderControlBox1.TabIndex = 0
        Me.FaderControlBox1.Text = "FaderControlBox1"
        '
        'FaderVerticalTabControl1
        '
        Me.FaderVerticalTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.FaderVerticalTabControl1.Controls.Add(Me.TabPage3)
        Me.FaderVerticalTabControl1.Controls.Add(Me.TabPage4)
        Me.FaderVerticalTabControl1.ItemSize = New System.Drawing.Size(35, 100)
        Me.FaderVerticalTabControl1.Location = New System.Drawing.Point(17, 61)
        Me.FaderVerticalTabControl1.Multiline = True
        Me.FaderVerticalTabControl1.Name = "FaderVerticalTabControl1"
        Me.FaderVerticalTabControl1.SelectedIndex = 0
        Me.FaderVerticalTabControl1.Size = New System.Drawing.Size(639, 513)
        Me.FaderVerticalTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FaderVerticalTabControl1.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.FaderButton5)
        Me.TabPage3.Controls.Add(Me.FaderButton4)
        Me.TabPage3.Controls.Add(Me.FaderButton3)
        Me.TabPage3.Controls.Add(Me.FaderButton2)
        Me.TabPage3.Controls.Add(Me.FaderButton1)
        Me.TabPage3.Location = New System.Drawing.Point(104, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(531, 505)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Basic Tools"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.TabPage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(104, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(531, 505)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Advanced Tools"
        '
        'FaderButton1
        '
        Me.FaderButton1.BackColor = System.Drawing.Color.Transparent
        Me.FaderButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FaderButton1.Location = New System.Drawing.Point(14, 17)
        Me.FaderButton1.Name = "FaderButton1"
        Me.FaderButton1.Size = New System.Drawing.Size(172, 35)
        Me.FaderButton1.TabIndex = 0
        Me.FaderButton1.Text = "Mouse Settings"
        '
        'FaderButton2
        '
        Me.FaderButton2.BackColor = System.Drawing.Color.Transparent
        Me.FaderButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FaderButton2.Location = New System.Drawing.Point(14, 58)
        Me.FaderButton2.Name = "FaderButton2"
        Me.FaderButton2.Size = New System.Drawing.Size(172, 35)
        Me.FaderButton2.TabIndex = 1
        Me.FaderButton2.Text = "Keyboard Settings"
        '
        'FaderButton3
        '
        Me.FaderButton3.BackColor = System.Drawing.Color.Transparent
        Me.FaderButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FaderButton3.Location = New System.Drawing.Point(14, 99)
        Me.FaderButton3.Name = "FaderButton3"
        Me.FaderButton3.Size = New System.Drawing.Size(172, 35)
        Me.FaderButton3.TabIndex = 2
        Me.FaderButton3.Text = "Check System Updates"
        '
        'FaderButton4
        '
        Me.FaderButton4.BackColor = System.Drawing.Color.Transparent
        Me.FaderButton4.Location = New System.Drawing.Point(14, 140)
        Me.FaderButton4.Name = "FaderButton4"
        Me.FaderButton4.Size = New System.Drawing.Size(172, 35)
        Me.FaderButton4.TabIndex = 3
        Me.FaderButton4.Text = "Time & Date"
        '
        'FaderButton5
        '
        Me.FaderButton5.BackColor = System.Drawing.Color.Transparent
        Me.FaderButton5.Location = New System.Drawing.Point(367, 17)
        Me.FaderButton5.Name = "FaderButton5"
        Me.FaderButton5.Size = New System.Drawing.Size(154, 35)
        Me.FaderButton5.TabIndex = 4
        Me.FaderButton5.Text = "Google Chrome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(14, 451)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(507, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Welcome To Brett Tech Mini Tool Panel"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 599)
        Me.Controls.Add(Me.FaderTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FaderTheme1.ResumeLayout(False)
        Me.FaderVerticalTabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FaderTheme1 As Fader_Theme.FaderTheme
    Friend WithEvents FaderVerticalTabControl1 As Fader_Theme.FaderVerticalTabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents FaderControlBox1 As Fader_Theme.FaderControlBox
    Friend WithEvents FaderButton1 As Fader_Theme.FaderButton
    Friend WithEvents FaderButton2 As Fader_Theme.FaderButton
    Friend WithEvents FaderButton3 As Fader_Theme.FaderButton
    Friend WithEvents FaderButton4 As Fader_Theme.FaderButton
    Friend WithEvents Label1 As Label
    Friend WithEvents FaderButton5 As Fader_Theme.FaderButton
    Friend WithEvents Timer1 As Timer
End Class
