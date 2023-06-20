#Region ""

Imports System
Imports System.Diagnostics
Imports System.Linq
Imports System.Threading
Imports System.Threading.Tasks

#End Region

Namespace vanick
	Friend Class Glow
		Friend Shared Async Sub Run()
			Dim offsets = Utils.RenewOffsets()
			Dim proc() As Process = Process.GetProcessesByName("csgo")
			Memory.ProcessHandle = Memory.OpenProcess(&H8 Or &H10 Or &H20, False, proc(0).Id)

			'Get the base addy for client.dll & engine.dll inside our csgo.exe
			Dim clientdll As Integer = GetModuleBaseAddress(proc(0), "client.dll")
			Dim enginedll As Integer = GetModuleBaseAddress(proc(0), "engine.dll")

			'Our general settings
			Dim glowSettingsStruct As Models.GlowSettingsStruct = New Models.GlowSettingsStruct With {.renderOccluded = True, .renderUnoccluded = False}

			'Get our local player
			Await Task.Run(Sub() 'Change this if ur cpu can't handle it :pepeclown:
					'Keep reading our local player coz incase teams change and stuff
					'Basically sleep the hack if ur in menu and such
					'Get our glow object
					'Get our team number
						'The current entity
									'*255 idea from: https://stackoverflow.com/a/46575472/12897035
								' if defusing
								'Our teammates are shown on map so we only have to write the radar to our enemies. (Basically this: https://youtu.be/5VOkRJk1GVg)
				Do
					Dim LocalPlayer As Integer = Memory.ReadMemory(Of Integer)(clientdll + offsets.signatures.dwLocalPlayer)
					Dim clientstate As Integer = Memory.ReadMemory(Of Integer)(enginedll + offsets.signatures.dwClientState)
					Dim MaxPlayerCount As Integer = Memory.ReadMemory(Of Integer)(clientstate + offsets.signatures.dwClientState_MaxPlayer)
					If MaxPlayerCount < 1 Then
						Thread.Sleep(500)
						Continue Do
					End If
					Dim glowObject As Integer = Memory.ReadMemory(Of Integer)(clientdll + offsets.signatures.dwGlowObjectManager)
					Dim myTeam As Integer = Memory.ReadMemory(Of Integer)(LocalPlayer + offsets.netvars.m_iTeamNum)
					For i As Integer = 0 To MaxPlayerCount - 1
						Dim entity As Integer = Memory.ReadMemory(Of Integer)(clientdll + offsets.signatures.dwEntityList + i * &H10)
						Dim bDormant As Boolean = Memory.ReadMemory(Of Boolean)(entity + offsets.signatures.m_bDormant)
						If Not bDormant Then
							Dim glowIndex As Integer = Memory.ReadMemory(Of Integer)(entity + offsets.netvars.m_iGlowIndex)
							Dim entityTeam As Integer = Memory.ReadMemory(Of Integer)(entity + offsets.netvars.m_iTeamNum)
							If myTeam = entityTeam Then
								Dim TeamGlow As Models.GlowColorStruct = Consts.GlowTeam
								Memory.WriteMemory(Of Models.GlowColorStruct)(glowObject + glowIndex * &H38 + &H8, TeamGlow)
								Dim clrRender_t As Models.rgba = New Models.rgba With {.r = CByte(Math.Round(TeamGlow.red * 255.0)), .g = CByte(Math.Round(TeamGlow.green * 255.0)), .b = CByte(Math.Round(TeamGlow.blue * 255.0)), .a = CByte(Math.Round(TeamGlow.alpha * 255.0))}
								Memory.WriteMemory(Of Models.GlowColorStruct)(entity + offsets.netvars.m_clrRender, clrRender_t)
							Else
								Dim EnemyGlow As Models.GlowColorStruct = Consts.GlowEnemy
								If Memory.ReadMemory(Of Boolean)(entity + offsets.netvars.m_bIsDefusing) Then
									EnemyGlow = New Models.GlowColorStruct With {.red = 255, .green = 255, .blue = 255, .alpha = 1.7F}
								Else
									Memory.WriteMemory(Of Models.GlowColorStruct)(glowObject + glowIndex * &H38 + &H8, EnemyGlow)
								End If
								Dim clrRender_t As Models.rgba = New Models.rgba With {.r = CByte(Math.Round(EnemyGlow.red * 255.0)), .g = CByte(Math.Round(EnemyGlow.green * 255.0)), .b = CByte(Math.Round(EnemyGlow.blue * 255.0)), .a = CByte(Math.Round(EnemyGlow.alpha * 255.0))}
								Memory.WriteMemory(Of Models.GlowColorStruct)(entity + offsets.netvars.m_clrRender, clrRender_t)
								Memory.WriteMemory(Of Boolean)(entity + offsets.netvars.m_bSpotted, True)
							End If
							Memory.WriteMemory(Of Models.GlowSettingsStruct)(glowObject + glowIndex * &H38 + &H28, glowSettingsStruct)
						End If
					Next i
					Thread.Sleep(1)
				Loop
			End Sub)
		End Sub

		Public Shared Function GetModuleBaseAddress(ByVal process As Process, ByVal moduleName As String) As Integer
			Return CInt(Math.Truncate(CDec(process.Modules.Cast(Of ProcessModule)().SingleOrDefault(Function(m) String.Equals(m.ModuleName, moduleName, StringComparison.OrdinalIgnoreCase)).BaseAddress)))
		End Function
	End Class
End Namespace