#Region ""

Imports System.Linq

#End Region

Namespace vanick
	Friend Class Models
		Friend Structure GlowColorStruct
			Public Property red() As Single
			Public Property green() As Single
			Public Property blue() As Single
			Public Property alpha() As Single
		End Structure

		Friend Structure rgba 'Overlay player color or "chams"
			Public r As Byte
			Public g As Byte
			Public b As Byte
			Public a As Byte
		End Structure

		Friend Structure GlowSettingsStruct
			Public Property renderOccluded() As Boolean
			Public Property renderUnoccluded() As Boolean
		End Structure
	End Class
End Namespace