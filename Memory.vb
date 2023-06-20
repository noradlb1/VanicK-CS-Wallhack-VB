#Region ""

Imports System
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Text

#End Region

Namespace vanick
	Friend Class Memory
		Public Shared ProcessHandle As IntPtr
		Public Shared m_iBytesRead As Integer
		Public Shared m_iBytesWrite As Integer

		<DllImport("kernel32.dll")> _
		Public Shared Function WriteProcessMemory(ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByVal buffer As String, ByVal size As Integer, <System.Runtime.InteropServices.Out()> ByRef lpNumberOfBytesWritten As Integer) As Boolean
		End Function

		<DllImport("kernel32.dll")> _
		Public Shared Function OpenProcess(ByVal dwDesiredAccess As Integer, ByVal bInheritHandle As Boolean, ByVal dwProcessId As Integer) As IntPtr
		End Function

		<DllImport("kernel32.dll")> _
		Private Shared Function ReadProcessMemory(ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByVal buffer() As Byte, ByVal size As Integer, ByRef lpNumberOfBytesRead As Integer) As Boolean
		End Function

		<DllImport("kernel32.dll")> _
		Public Shared Function WriteProcessMemory(ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByVal buffer() As Byte, ByVal size As Integer, <System.Runtime.InteropServices.Out()> ByRef lpNumberOfBytesWritten As Integer) As Boolean
		End Function

		Public Shared Function ReadMemory(Of T As Structure)(ByVal Adress As Integer) As T
			Dim ByteSize As Integer = Marshal.SizeOf(GetType(T))
			Dim buffer(ByteSize - 1) As Byte
			ReadProcessMemory(CInt(Math.Truncate(CDec(ProcessHandle))), Adress, buffer, buffer.Length, m_iBytesRead)

			Return ByteArrayToStructure(Of T)(buffer)
		End Function

		Public Shared Function ReadMemoryBytes(ByVal Adress As Integer, ByVal bytesToRead As Integer) As Byte()
			Dim buffer(bytesToRead - 1) As Byte
			ReadProcessMemory(CInt(Math.Truncate(CDec(ProcessHandle))), Adress, buffer, buffer.Length, m_iBytesRead)

			Return buffer
		End Function

		Public Shared Sub WriteMemory(Of T)(ByVal Adress As Integer, ByVal Value As Object)
			Dim buffer() As Byte = StructureToByteArray(Value)

			WriteProcessMemory(CInt(Math.Truncate(CDec(ProcessHandle))), Adress, buffer, buffer.Length, m_iBytesWrite)
		End Sub

		Public Shared Function ReadString(ByVal baseAddress As Integer, ByVal size As Integer) As String
			'create buffer for string
			Dim buffer(size - 1) As Byte


			ReadProcessMemory(CInt(Math.Truncate(CDec(ProcessHandle))), baseAddress, buffer, size, m_iBytesWrite)

			'encode bytes to ASCII
			Return Encoding.ASCII.GetString(buffer)
		End Function

		Public Shared Function ByteArrayToStructure(Of T As Structure)(ByVal bytes() As Byte) As T
			Dim handle = GCHandle.Alloc(bytes, GCHandleType.Pinned)
			Try
				Return DirectCast(Marshal.PtrToStructure(handle.AddrOfPinnedObject(), GetType(T)), T)
			Finally
				handle.Free()
			End Try
		End Function

		Public Shared Function StructureToByteArray(ByVal obj As Object) As Byte()
			Dim len As Integer = Marshal.SizeOf(obj)

			Dim arr(len - 1) As Byte

			Dim ptr As IntPtr = Marshal.AllocHGlobal(len)

			Marshal.StructureToPtr(obj, ptr, True)
			Marshal.Copy(ptr, arr, 0, len)
			Marshal.FreeHGlobal(ptr)

			Return arr
		End Function
	End Class
End Namespace