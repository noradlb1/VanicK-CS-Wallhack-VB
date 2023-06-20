#Region ""

Imports System.Drawing
Imports System.Linq
Imports System.Net
Imports Newtonsoft.Json
'Imports staticvanick.Offsets
Imports vanick.Offsets

#End Region

Namespace vanick
    Public NotInheritable Class Utils

        Private Sub New()
        End Sub

        Friend Shared Function RenewOffsets() As OffsetMain
            Using wc = New WebClient()
                Dim json As String = wc.DownloadString("https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.min.json")
                Return JsonConvert.DeserializeObject(Of OffsetMain)(json)
            End Using

            Return Nothing
        End Function

        Friend Shared Function CreateStruct(ByVal color As Color) As Models.GlowColorStruct
            Return New Models.GlowColorStruct With {.alpha = color.A, .blue = color.B, .green = color.G, .red = color.R}
        End Function

        Friend Shared Function FromStruct(ByVal str As Models.GlowColorStruct) As Color
            Return Color.FromArgb(CInt(Math.Truncate(str.alpha)), CInt(Math.Truncate(str.red)), CInt(Math.Truncate(str.green)), CInt(Math.Truncate(str.blue)))
        End Function
    End Class
End Namespace