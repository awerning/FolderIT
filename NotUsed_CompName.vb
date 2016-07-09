Option Strict Off
Option Explicit On
Friend Class ComputerInfo
	Private Declare Function GetComputerName Lib "kernel32"  Alias "GetComputerNameA"(ByVal lpBuffer As String, ByRef nSize As Integer) As Integer
	Private Declare Function GetUserName Lib "advapi32.dll"  Alias "GetUserNameA"(ByVal lpBuffer As String, ByRef nSize As Integer) As Integer
	Public ReadOnly Property ComputerName() As String
		Get
			Dim sName As String
			Dim lRetVal As Integer
			Dim iPos As Short
			
			'API's generally require fixed-length strings, which means
			'pre-filling them with spaces, nulls, or Dim sName As String * 255
			sName = Space(255)
			
			'Actually call the API
			lRetVal = GetComputerName(sName, 255)
			
			'If the API returns 0 then it didn't work, so exit
            If lRetVal = 0 Then
                ComputerName = Nothing
                Exit Property
            End If
			
			'GetComputerName puts a null character, Chr$(0), on the end of the
			'string, so we need to remove it before returning the computer name.
			iPos = InStr(sName, Chr(0))
			ComputerName = Left(sName, iPos - 1)
			
		End Get
	End Property
	
	
	Public ReadOnly Property UserName() As String
		Get
			Dim s1Name As String
			Dim l1RetVal As Integer
			Dim i1Pos As Short
			
			'API's generally require fixed-length strings, which means
			'pre-filling them with spaces, nulls, or Dim sName As String * 255
			s1Name = Space(255)
			
			'Actually call the API
			l1RetVal = GetUserName(s1Name, 255)
			
			'If the API returns 0 then it didn't work, so exit
            If l1RetVal = 0 Then
                UserName = Nothing
                Exit Property
            End If
			
			'GetUserName puts a null character, Chr$(0), on the end of the
			'string, so we need to remove it before returning the computer name.
			i1Pos = InStr(s1Name, Chr(0))
			UserName = Left(s1Name, i1Pos - 1)
			
		End Get
	End Property
End Class