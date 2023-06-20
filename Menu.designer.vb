Namespace vanick
	Partial Public Class Menu
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.colorDialog1 = New System.Windows.Forms.ColorDialog()
            Me.picker = New Cyotek.Windows.Forms.ColorWheel()
            Me.titlelbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.modeswitch = New Guna.UI2.WinForms.Guna2ToggleSwitch()
            Me.team_lbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.enemy_lbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
            Me.guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
            Me.SuspendLayout()
            '
            'picker
            '
            Me.picker.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.picker.Location = New System.Drawing.Point(23, 82)
            Me.picker.Name = "picker"
            Me.picker.Size = New System.Drawing.Size(112, 89)
            Me.picker.TabIndex = 5
            '
            'titlelbl
            '
            Me.titlelbl.BackColor = System.Drawing.Color.Transparent
            Me.titlelbl.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
            Me.titlelbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.titlelbl.IsContextMenuEnabled = False
            Me.titlelbl.IsSelectionEnabled = False
            Me.titlelbl.Location = New System.Drawing.Point(43, 46)
            Me.titlelbl.Name = "titlelbl"
            Me.titlelbl.Size = New System.Drawing.Size(68, 30)
            Me.titlelbl.TabIndex = 7
            Me.titlelbl.Text = "VanicK"
            '
            'modeswitch
            '
            Me.modeswitch.Animated = True
            Me.modeswitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.modeswitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.modeswitch.CheckedState.InnerBorderColor = System.Drawing.Color.White
            Me.modeswitch.CheckedState.InnerColor = System.Drawing.Color.White
            Me.modeswitch.Location = New System.Drawing.Point(45, 179)
            Me.modeswitch.Name = "modeswitch"
            Me.modeswitch.Size = New System.Drawing.Size(68, 21)
            Me.modeswitch.TabIndex = 8
            Me.modeswitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
            Me.modeswitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.modeswitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White
            Me.modeswitch.UncheckedState.InnerColor = System.Drawing.Color.White
            '
            'team_lbl
            '
            Me.team_lbl.BackColor = System.Drawing.Color.Transparent
            Me.team_lbl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.team_lbl.ForeColor = System.Drawing.Color.White
            Me.team_lbl.Location = New System.Drawing.Point(28, 209)
            Me.team_lbl.Name = "team_lbl"
            Me.team_lbl.Size = New System.Drawing.Size(37, 19)
            Me.team_lbl.TabIndex = 9
            Me.team_lbl.Text = "Team"
            '
            'guna2HtmlLabel1
            '
            Me.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
            Me.guna2HtmlLabel1.Location = New System.Drawing.Point(71, 209)
            Me.guna2HtmlLabel1.Name = "guna2HtmlLabel1"
            Me.guna2HtmlLabel1.Size = New System.Drawing.Size(9, 19)
            Me.guna2HtmlLabel1.TabIndex = 10
            Me.guna2HtmlLabel1.Text = "/"
            '
            'enemy_lbl
            '
            Me.enemy_lbl.BackColor = System.Drawing.Color.Transparent
            Me.enemy_lbl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.enemy_lbl.ForeColor = System.Drawing.Color.White
            Me.enemy_lbl.Location = New System.Drawing.Point(86, 209)
            Me.enemy_lbl.Name = "enemy_lbl"
            Me.enemy_lbl.Size = New System.Drawing.Size(44, 19)
            Me.enemy_lbl.TabIndex = 11
            Me.enemy_lbl.Text = "Enemy"
            '
            'guna2ControlBox1
            '
            Me.guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.guna2ControlBox1.Animated = True
            Me.guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer))
            Me.guna2ControlBox1.BorderColor = System.Drawing.Color.RoyalBlue
            Me.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
            Me.guna2ControlBox1.HoverState.BorderColor = System.Drawing.Color.Indigo
            Me.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.guna2ControlBox1.IconColor = System.Drawing.Color.White
            Me.guna2ControlBox1.Location = New System.Drawing.Point(113, 12)
            Me.guna2ControlBox1.Name = "guna2ControlBox1"
            Me.guna2ControlBox1.PressedColor = System.Drawing.Color.DarkCyan
            Me.guna2ControlBox1.Size = New System.Drawing.Size(40, 29)
            Me.guna2ControlBox1.TabIndex = 12
            '
            'guna2BorderlessForm1
            '
            Me.guna2BorderlessForm1.AnimateWindow = True
            Me.guna2BorderlessForm1.ContainerControl = Me
            Me.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
            Me.guna2BorderlessForm1.TransparentWhileDrag = True
            '
            'Menu
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(165, 240)
            Me.Controls.Add(Me.guna2ControlBox1)
            Me.Controls.Add(Me.enemy_lbl)
            Me.Controls.Add(Me.guna2HtmlLabel1)
            Me.Controls.Add(Me.team_lbl)
            Me.Controls.Add(Me.modeswitch)
            Me.Controls.Add(Me.titlelbl)
            Me.Controls.Add(Me.picker)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "Menu"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Menu"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private colorDialog1 As System.Windows.Forms.ColorDialog
		Private WithEvents picker As Cyotek.Windows.Forms.ColorWheel
		Private titlelbl As Guna.UI2.WinForms.Guna2HtmlLabel
		Private WithEvents modeswitch As Guna.UI2.WinForms.Guna2ToggleSwitch
		Private team_lbl As Guna.UI2.WinForms.Guna2HtmlLabel
		Private guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
		Private enemy_lbl As Guna.UI2.WinForms.Guna2HtmlLabel
		Private guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
		Private guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
	End Class
End Namespace