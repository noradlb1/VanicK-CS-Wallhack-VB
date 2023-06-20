Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace vanick
    Partial Public Class Menu
        Inherits Form

        Public Sub New()
            Return
            InitializeComponent()
        End Sub

        Private Sub Menu_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim proc = Process.GetProcessesByName("csgo")

            If proc.Length <= 0 Then
                MessageBox.Show("Please run CSGO first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Environment.[Exit](0)
            End If

            Glow.Run()
        End Sub

        Private Sub modeswitch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not modeswitch.Checked Then
                enemy_lbl.ForeColor = Color.White
                team_lbl.ForeColor = Color.Green
                picker.Color = Utils.FromStruct(Consts.GlowTeam)
            Else
                team_lbl.ForeColor = Color.White
                enemy_lbl.ForeColor = Color.Green
                picker.Color = Utils.FromStruct(Consts.GlowEnemy)
            End If
        End Sub

        Private Sub colorWheel1_ColorChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not modeswitch.Checked Then
                Consts.GlowTeam = Utils.CreateStruct(picker.Color)
            Else
                Consts.GlowEnemy = Utils.CreateStruct(picker.Color)
            End If
        End Sub
    End Class
End Namespace
