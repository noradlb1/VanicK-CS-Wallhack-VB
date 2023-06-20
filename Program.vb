#Region ""

Imports System
Imports System.Linq
Imports System.Windows.Forms

#End Region

Namespace vanick
	Friend NotInheritable Class Program

		Private Sub New()
		End Sub

		''' <summary>
		'''     The main entry point for the application.
		''' </summary>
		<STAThread> _
		Public Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Menu())
		End Sub
	End Class
End Namespace