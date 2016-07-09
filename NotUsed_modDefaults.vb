Option Strict Off
Option Explicit On
Module NotUsed_modDefaults
    Private Declare Function WNetGetConnection Lib "mpr.dll" Alias "WNetGetConnectionA" (ByVal lpszLocalName As String, ByVal lpszRemoteName As String, ByRef cbRemoteName As Integer) As Integer

    Public sCurrentDomain As String
    Public sPRFCFGini As String


    Public Function GetLDAPName(ByRef sDomain As String) As Object
        'Gives LDAP Name for given Domain
        Dim sName As String = ""

        'sName = ReadINI("Domains", sDomain, sPRFCFGini)
        'If sName = "" Then
        '	sName = "WinNT://127.0.0.1"
        'Else
        '	sName = "LDAP://" & sName
        'End If

        'UPGRADE_WARNING: Couldn't resolve default property of object GetLDAPName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        GetLDAPName = sName
    End Function

    Public Function GetShortName(ByRef sDomain As String) As Object
        Dim bNewSection As Object
        'Gives LDAP Name for given Domain
        Dim sName As String

        'need to fix
        'loop throu text file to file most correct answer
        'do a if in str and that must be it....but use the most correct one..biggest len

        'Removes given section from file
        Dim oFS As New Scripting.FileSystemObject
        Dim oRead As Scripting.TextStream
        Dim sRead As String
        Dim aRead() As String
        Dim sShortDomain As String
        Dim sProcess As String
        Dim bDone As Boolean
        Dim iName As Short


        iName = 0
        sName = sCurrentDomain
        'UPGRADE_WARNING: Couldn't resolve default property of object bNewSection. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        bNewSection = False

        oRead = oFS.OpenTextFile(sPRFCFGini, Scripting.IOMode.ForReading, False, Scripting.Tristate.TristateFalse)

        Do While Not oRead.AtEndOfStream
            sRead = oRead.ReadLine
            sProcess = Trim(sRead)

            If Trim(sRead) = "[Domains]" Then
                'start reading
                bDone = False
                Do While (Not bDone) And (Not oRead.AtEndOfStream)
                    sRead = oRead.ReadLine
                    sProcess = Trim(sRead)

                    If (Left(sProcess, 1) = "[") And (Right(sProcess, 1) = "]") Then
                        bDone = True
                    Else
                        If sProcess <> "" Then
                            aRead = Split(sProcess, "=", -1, CompareMethod.Text)
                            sShortDomain = aRead(LBound(aRead))
                            aRead(LBound(aRead)) = ""
                            sRead = Join(aRead, "=")
                            sRead = Right(sRead, Len(sRead) - 1)
                            If InStr(1, sDomain, sRead, CompareMethod.Text) > 0 Then
                                If Len(sRead) > iName Then
                                    iName = Len(sRead)
                                    sName = sShortDomain
                                End If
                            End If
                        End If
                    End If

                    System.Windows.Forms.Application.DoEvents()
                Loop
            End If
            System.Windows.Forms.Application.DoEvents()
        Loop

        oRead.Close()

        'UPGRADE_NOTE: Object oRead may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        oRead = Nothing
        'UPGRADE_NOTE: Object oFS may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        oFS = Nothing
        'UPGRADE_WARNING: Couldn't resolve default property of object GetShortName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        GetShortName = sName
    End Function


    Public Sub RefreshDomains()
        'Enumerates All Domains for current PC's Forest
        Dim oRootDSE As ActiveDs.IADs
        Dim oCont As ActiveDs.IADsContainer
        Dim oDomain As ActiveDs.IADs
        Dim sNC As String
        'Dim sName As String
        'Dim sLDAP As String

        oRootDSE = GetObject("LDAP://RootDSE")
        'UPGRADE_WARNING: Couldn't resolve default property of object oRootDSE.Get(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sNC = oRootDSE.Get("configurationNamingContext")
        sNC = "LDAP://CN=Partitions," & sNC
        oCont = GetObject(sNC)
        'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        oCont.Filter = New Object() {"crossRef"}

        'RemoveSection("Domains", sPRFCFGini)

        'For	Each oDomain In oCont
        '	'UPGRADE_WARNING: Couldn't resolve default property of object oDomain.cn. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	sName = oDomain.cn
        '	If (UCase(sName) <> "ENTERPRISE CONFIGURATION") And (UCase(sName) <> "ENTERPRISE SCHEMA") Then
        '		'UPGRADE_WARNING: Couldn't resolve default property of object oDomain.Get(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		sLDAP = oDomain.Get("nCName")
        '		WriteINI("Domains", sName, sLDAP, sPRFCFGini)
        '	End If
        '	System.Windows.Forms.Application.DoEvents()
        'Next oDomain

        'UPGRADE_NOTE: Object oDomain may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        oDomain = Nothing
        'UPGRADE_NOTE: Object oCont may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        oCont = Nothing
        'UPGRADE_NOTE: Object oRootDSE may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        oRootDSE = Nothing
    End Sub


    Public Sub EnumDomains(ByRef cmbDomain As System.Windows.Forms.ComboBox, Optional ByRef bRefresh As Boolean = False)
        'Adds Domains from INI to ComboBox
        Dim oFS As New Scripting.FileSystemObject
        Dim oRead As Scripting.TextStream
        Dim sRead As String
        Dim sProcess As String
        Dim bRead As Boolean
        Dim sDomain As String


        bRead = False
        cmbDomain.Items.Clear()

        oRead = oFS.OpenTextFile(sPRFCFGini, Scripting.IOMode.ForReading, True, Scripting.Tristate.TristateFalse)

        Do While Not oRead.AtEndOfStream
            sRead = oRead.ReadLine
            sProcess = Trim(sRead)

            If (Left(sProcess, 1) = "[") And (Right(sProcess, 1) = "]") Then
                If UCase(sProcess) = "[DOMAINS]" Then
                    'in Section
                    bRead = True
                Else
                    If bRead Then Exit Do 'new section...time to exit routine
                End If
            ElseIf bRead Then
                If sProcess <> "" Then
                    sDomain = Left(sProcess, InStr(1, sProcess, "=", CompareMethod.Text) - 1)
                    cmbDomain.Items.Add(sDomain)
                End If
            End If

            System.Windows.Forms.Application.DoEvents()
        Loop

        oRead.Close()

        'UPGRADE_NOTE: Object oRead may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        oRead = Nothing
        'UPGRADE_NOTE: Object oFS may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        oFS = Nothing

        'if this is the first run...then their may not be anything in the INI file.
        If (cmbDomain.Items.Count <= 0) And (Not bRefresh) Then
            RefreshDomains()
            EnumDomains(cmbDomain, True)
        End If
    End Sub



    Public Function ADSecurityTest() As Boolean
        On Error Resume Next
        Dim bOK As Boolean

        bOK = True
        Err.Clear()
        'Dim sec As New ADSSECURITYLib.ADsSecurity

        'sec = CreateObject("ADsSecurity")

        If Err.Number Then
            Err.Clear()
            bOK = False
        End If

        'UPGRADE_NOTE: Object sec may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'sec = Nothing
        ADSecurityTest = bOK
    End Function

    Public Sub RunAsMe(ByRef sUser As String, ByRef sPass As String, ByRef sDomain As String, ByRef sFolder As String)
        Dim sDrive As Object
        'initiats the RUNAS routine
        Dim iProc As Integer
        Dim sArg As String
        Dim sApp As String

        Dim sVerify As String
        Dim sGroup As String
        Dim sAccess As String
        If sFolder = "cmdTestRun" Then
            sArg = "cmdTestRun"
        Else

            sVerify = "0"
            sGroup = "0"
            sAccess = "0"

            If frmFolders.mnuVerifyGroup.Checked Then sVerify = "1"
            If frmFolders.mnuAutoGroup.Checked Then sGroup = "1"
            If frmFolders.mnuVerifyAccess.Checked Then sAccess = "1"

            'UPGRADE_WARNING: Lower bound of collection frmFolders.tvFolders.Nodes has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            'sArg = sINIFile & "|||" & sFolder & "|||" & frmFolders.tvFolders.Nodes.Item(1).Text & "|||" & sVerify & "|||" & sGroup & "|||" & sAccess
        End If


        If (sUser = "") Or (sDomain = "") Then
            MsgBox("User or Domain not set for RunAs Routine" & vbCrLf & "Please Contact Computer Services", MsgBoxStyle.Critical, "ERROR: PM206 - RunAs")
            Exit Sub
        End If

        sApp = My.Application.Info.DirectoryPath

        If Mid(sApp, 2, 1) = ":" Then
            'UPGRADE_WARNING: Couldn't resolve default property of object sDrive. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sDrive = fGetUNCPath(Mid(sApp, 1, 2))
            'UPGRADE_WARNING: Couldn't resolve default property of object sDrive. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If sDrive <> "" Then sApp = Left(sDrive, Len(sDrive) - 1) & Right(sApp, Len(sApp) - 2)
        End If

        If Right(sApp, 1) <> "\" Then sApp = sApp & "\"

        'UPGRADE_WARNING: App property App.EXEName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        'iProc = CreateProcess(sDomain, sUser, sPass, sApp & My.Application.Info.AssemblyName & ".exe", "/k " & sArg, False, True)
        If iProc = -1 Then
            MsgBox("There was an error with the RunAs Routine" & vbCrLf & "Please Contact Computer Services", MsgBoxStyle.Critical, "ERROR: PM206 - RunAs")
        End If
    End Sub


    Private Function fGetUNCPath(ByRef strDriveLetter As String) As String
        'Dim Msg As String
        Dim lngReturn As Integer
        Dim lpszLocalName As String
        Dim lpszRemoteName As String
        Dim cbRemoteName As Integer
        Dim sUNC As String

        lpszLocalName = strDriveLetter
        lpszRemoteName = New String(Chr(32), 255)
        cbRemoteName = Len(lpszRemoteName)
        lngReturn = WNetGetConnection(lpszLocalName, lpszRemoteName, cbRemoteName)

        If lngReturn <> 0 Then
            sUNC = ""
        Else
            sUNC = Left(lpszRemoteName, cbRemoteName)
        End If

        fGetUNCPath = Trim(sUNC)
    End Function
End Module