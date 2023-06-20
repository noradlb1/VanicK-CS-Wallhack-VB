#Region ""

Imports System.Drawing
Imports System.Linq

#End Region

Namespace vanick
	Friend Class Consts
		Friend Shared GlowTeam As Models.GlowColorStruct = Utils.CreateStruct(Color.White)
		Friend Shared GlowEnemy As Models.GlowColorStruct = Utils.CreateStruct(Color.Yellow)
	End Class
End Namespace