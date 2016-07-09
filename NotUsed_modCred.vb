Option Strict Off
Option Explicit On
Module NotUsed_modCred

    Private Const LOGON_WITH_PROFILE As Integer = &H1
    Private Const LOGON_NETCREDENTIALS_ONLY As Integer = &H2
    Private Const CREATE_DEFAULT_ERROR_MODE As Integer = &H4000000
    Private Const CREATE_NEW_CONSOLE As Integer = &H10
    Private Const CREATE_NEW_PROCESS_GROUP As Integer = &H200
    Private Const CREATE_SEPARATE_WOW_VDM As Integer = &H800
    Private Const CREATE_SUSPENDED As Integer = &H4
    Private Const CREATE_UNICODE_ENVIRONMENT As Integer = &H400
    Private Const ABOVE_NORMAL_PRIORITY_CLASS As Integer = &H8000
    Private Const BELOW_NORMAL_PRIORITY_CLASS As Integer = &H4000
    Private Const HIGH_PRIORITY_CLASS As Integer = &H80
    Private Const IDLE_PRIORITY_CLASS As Integer = &H40
    Private Const NORMAL_PRIORITY_CLASS As Integer = &H20
    Private Const REALTIME_PRIORITY_CLASS As Integer = &H100
    Private Const SLEEP_DELAY As Integer = 100
    Private Const STATUS_PENDING As Integer = &H103
    Private Const STILL_ACTIVE As Integer = STATUS_PENDING
    Private Const API_TRUE As Integer = &H1
    Private Const API_FALSE As Integer = &H0
    Private Const API_NULL As Integer = &H0

    Private Const API_FAILURE As Integer = &H0
    Private Const STARTF_USESHOWWINDOW As Integer = &H1
    Private Const SW_HIDE As Integer = 0
    Private Const SW_SHOW As Integer = &H1

    Private Const DOMAIN_ALIAS_RID_ADMINS As Integer = &H220
    Private Structure PROCESS_INFORMATION
        Dim hProcess As Integer
        Dim hThread As Integer
        Dim dwProcessId As Integer
        Dim dwThreadId As Integer
    End Structure

    Private Structure STARTUPINFO
        Dim cb As Integer
        Dim lpReserved As Integer
        Dim lpDesktop As Integer
        Dim lpTitle As Integer
        Dim dwX As Integer
        Dim dwY As Integer
        Dim dwXSize As Integer
        Dim dwYSize As Integer
        Dim dwXCountChars As Integer
        Dim dwYCountChars As Integer
        Dim dwFillAttribute As Integer
        Dim dwFlags As Integer
        Dim wShowWindow As Short
        Dim cbReserved2 As Short
        Dim lpReserved2 As Byte
        Dim hStdInput As Integer
        Dim hStdOutput As Integer
        Dim hStdError As Integer
    End Structure

    'UPGRADE_WARNING: Structure PROCESS_INFORMATION may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
    'UPGRADE_WARNING: Structure STARTUPINFO may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
    Private Declare Function CreateProcessWithLogon Lib "Advapi32" Alias "CreateProcessWithLogonW" (ByVal UserName As Integer, ByVal Domain As Integer, ByVal Password As Integer, ByVal dwLogonFlags As Integer, ByVal ApplicationName As Integer, ByVal strCommandLine As Integer, ByVal dwCreationFlags As Integer, ByVal lpEnvironment As Integer, ByVal strCurrentDirectory As Integer, ByRef lpStartupInfo As STARTUPINFO, ByRef lppiProcessInfo As PROCESS_INFORMATION) As Integer

    Private Declare Function GetExitCodeProcess Lib "kernel32" (ByVal hProcess As Integer, ByRef lpExitCode As Integer) As Integer

    Private Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Integer) As Integer

    Private Declare Function Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer) As Integer

    Public Function CreateProcess(ByVal Domain As String, ByVal UserName As String, ByVal Password As String, ByVal ApplicationName As String, ByVal sCommandLine As String, Optional ByVal ExecuteAsynch As Boolean = False, Optional ByVal Visible As Boolean = False) As Integer


        'Define local variables
        Dim strCurrentDirectory As String
        Dim suiStartUpInfo As STARTUPINFO
        Dim piProcessInfo As PROCESS_INFORMATION
        Dim lngExitCode As Integer
        Dim lngReturnValue As Integer
        'Dim strMessage As String
        'Initialize local variables
        strCurrentDirectory = vbNullString 'Use the standard, default assignment
        With suiStartUpInfo
            'UPGRADE_ISSUE: LenB function is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="367764E5-F3F8-4E43-AC3E-7FE0B5E074E2"'
            .cb = Len(suiStartUpInfo) 'Size of the structure
            .lpReserved = API_NULL 'Reserved
            .cbReserved2 = API_NULL 'Reserved
            .dwFlags = STARTF_USESHOWWINDOW 'Use the wShowWindow parameter
            .wShowWindow = IIf(Visible, SW_SHOW, SW_HIDE) 'Hide or show any window that might be shown
        End With
        'Create the new process with the credentials provided
        'UPGRADE_ISSUE: StrPtr function is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="367764E5-F3F8-4E43-AC3E-7FE0B5E074E2"'
        'If CreateProcessWithLogon(StrPtr(UserName), StrPtr(Domain), StrPtr(Password), LOGON_WITH_PROFILE, StrPtr(ApplicationName), StrPtr(sCommandLine), CREATE_DEFAULT_ERROR_MODE Or CREATE_NEW_CONSOLE Or CREATE_NEW_PROCESS_GROUP, 0, StrPtr(strCurrentDirectory), suiStartUpInfo, piProcessInfo) = API_FAILURE Then
        '	'There is no pointin moving on if this failed
        '	'Unable to launch the new process
        '	CreateProcess = -1
        '	Exit Function
        'End If
        'Should we hang around till the new process ends?
        If Not ExecuteAsynch Then
            Do
                'This function returns STILL_ACTIVE if the process is still running
                lngReturnValue = GetExitCodeProcess(piProcessInfo.hProcess, lngExitCode)
                'Give up the processor
                Call Sleep(SLEEP_DELAY)
                'Loop while the process is running and there is no error
            Loop While (lngExitCode = STILL_ACTIVE) And Not (lngReturnValue = API_FAILURE)
            'The process was executed synchronously
            CreateProcess = lngExitCode
        Else
            'We arent going to stick around,
            'so don't return an exit code
            CreateProcess = 0
        End If
        'Close the handles to the thread & process, since we don't use them
        'NOTE: Closing the handles of the main thread and the process do not terminate the process
        Call CloseHandle(piProcessInfo.hThread)
        Call CloseHandle(piProcessInfo.hProcess)
    End Function
End Module