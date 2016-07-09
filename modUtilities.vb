'Imports System.Security.AccessControl
'Imports System.Security.Principal
'Imports System.Text
'Imports System.Runtime.InteropServices
Imports System.IO

Module modUtilities

    'Public sFolder As String = "N:\CPAI\CD5X-2232"
    Public sFolder As String = "E:\Aarons Stuff\.NET Development\_Projects\FolderIT\_Test Folder Structure"

    Public WithEvents BackgroundWorker1 As New System.ComponentModel.BackgroundWorker
    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim subDirTextList As List(Of String) = New List(Of String)(Directory.GetDirectories(CType(e.Argument, String), "*", SearchOption.AllDirectories))
        subDirTextList.Sort()
        e.Result = subDirTextList
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ' Access the result through the Result property. 
        PopulateTreeView(frmFolders.tvFolders, e.Result)
        frmFolders.btnMain.Enabled = True
    End Sub

    Public Sub PopulateTreeView(ByVal treeView As TreeView, ByVal subDirTextList As List(Of String))
        Dim lastNode As TreeNode = Nothing
        Dim subPathAgg As String
        'Dim applyTo As permApplyTo
        Dim dirInfoFolder As DirectoryInfo
        Dim dirSecFolderAcl As New DirectorySecurity
        Dim fSecurity As AuthorizationRuleCollection

        treeView.Nodes.Clear()

        Dim dirCount As Integer = subDirTextList.Count

        frmFolders.LabelProgress.Text = "Populating Tree View: "
        frmFolders.ProgressBar1.Style = ProgressBarStyle.Continuous
        frmFolders.ProgressBar1.Maximum = dirCount
        frmFolders.ProgressBar1.Value = 0
        Application.DoEvents()

        For Each path As String In subDirTextList

            path = path.Substring(sFolder.Length + 1)
            subPathAgg = String.Empty

            If Not lastNode Is Nothing And path.Split("\").Length < 2 Then
                lastNode = treeView.Nodes(0)
            End If

            For Each subPath As String In path.Split("\")
                subPathAgg += subPath & "\"

                Dim nodes As TreeNode() = treeView.Nodes.Find(subPathAgg, True)
                If nodes.Length = 0 Then

                    If lastNode Is Nothing Then
                        dirInfoFolder = New DirectoryInfo(sFolder)
                        lastNode = treeView.Nodes.Add(sFolder, "<ROOT>")
                    Else
                        dirInfoFolder = New DirectoryInfo(sFolder & "\" & subPathAgg)
                        lastNode = lastNode.Nodes.Add(subPathAgg, subPath)
                    End If
                    dirSecFolderAcl = dirInfoFolder.GetAccessControl()
                    fSecurity = dirSecFolderAcl.GetAccessRules(True, True, GetType(System.Security.Principal.NTAccount))
                    setFolderIcon(fSecurity, lastNode)
                    lastNode.Tag = dirInfoFolder.GetAccessControl()
                Else
                    lastNode = nodes(0)
                End If
            Next
            frmFolders.ProgressBar1.Value += 1
        Next

        frmFolders.LabelProgress.Visible = False
        frmFolders.ProgressBar1.Visible = False
        frmFolders.tvFolders.ExpandAll()

        treeView.SelectedNode = treeView.Nodes(0)

    End Sub

    Sub setFolderIcon(ByVal fSecurity As AuthorizationRuleCollection, ByVal node As TreeNode)
        Dim inherit As Boolean = False
        Dim explicit As Boolean = False
        For Each acc As FileSystemAccessRule In fSecurity
            If acc.IsInherited = True Then
                inherit = True
            Else
                explicit = True
            End If
        Next

        Select Case True
            Case inherit And explicit
                node.ImageIndex = 2
                node.SelectedImageIndex = 2
            Case inherit
                node.ImageIndex = 1
                node.SelectedImageIndex = 1
            Case explicit
                node.ImageIndex = 3
                node.SelectedImageIndex = 3
            Case Else
                node.ImageIndex = 0
                node.SelectedImageIndex = 0
        End Select
    End Sub

    Public Function getApplyTo(ByVal acc As AuthorizationRule) As permApplyTo
        Dim bPropFlag As Boolean
        '╔═════════════╦══════════╦══════════════════════╦════════════════╦════════════╦═════════════════╦═══════════╦═══════════╗
        '║             ║ThisFolder║folder/subFolder/files║folder/subFolder║folder/files║ subFolder/files ║ subFolder ║   files   ║
        '╠═════════════╬══════════╬══════════════════════╬════════════════╬════════════╬═════════════════╬═══════════╬═══════════╣
        '║ Propagation ║ none     ║ none                 ║ none           ║ none       ║InheritOnly      ║InheritOnly║InheritOnly║
        '║ Inheritance ║ none     ║ Container|Object     ║ Container      ║ Object     ║Container|Object ║Container  ║Object     ║
        '╚═════════════╩══════════╩══════════════════════╩════════════════╩════════════╩═════════════════╩═══════════╩═══════════╝
        bPropFlag = IIf((acc.PropagationFlags And PropagationFlags.None) = PropagationFlags.None, Nothing, True)
        Select Case True
            Case ((acc.InheritanceFlags And InheritanceFlags.ContainerInherit) = InheritanceFlags.ContainerInherit And _
                  (acc.InheritanceFlags And InheritanceFlags.ObjectInherit) = InheritanceFlags.ObjectInherit)
                getApplyTo = IIf(bPropFlag, permApplyTo.SubFoldersFiles, permApplyTo.ThisFolderSubFoldersFiles)
            Case (acc.InheritanceFlags And InheritanceFlags.ObjectInherit) = InheritanceFlags.ObjectInherit
                getApplyTo = IIf(bPropFlag, permApplyTo.Files, permApplyTo.ThisFolderFiles)
            Case (acc.InheritanceFlags And InheritanceFlags.ContainerInherit) = InheritanceFlags.ContainerInherit
                getApplyTo = IIf(bPropFlag, permApplyTo.SubFolders, permApplyTo.ThisFolderSubFolders)
            Case Else
                getApplyTo = permApplyTo.ThisFolder
        End Select
    End Function

    Public Function accRuleToAdvFlags(ByVal acc As FileSystemAccessRule) As String
        'getAdvancedPermissions = acc.FileSystemRights.ToString
        accRuleToAdvFlags = IIf((acc.FileSystemRights And FileSystemRights.FullControl) = FileSystemRights.FullControl, "1", "0") & _
                                 IIf(((acc.FileSystemRights And FileSystemRights.Traverse) = FileSystemRights.Traverse And _
                                      (acc.FileSystemRights And FileSystemRights.ExecuteFile) = FileSystemRights.ExecuteFile), "|1", "|0") & _
                                 IIf(((acc.FileSystemRights And FileSystemRights.ListDirectory) = FileSystemRights.ListDirectory And _
                                      (acc.FileSystemRights And FileSystemRights.ReadData) = FileSystemRights.ReadData), "|1", "|0") & _
                                 IIf((acc.FileSystemRights And FileSystemRights.ReadAttributes) = FileSystemRights.ReadAttributes, "|1", "|0") & _
                                 IIf((acc.FileSystemRights And FileSystemRights.ReadExtendedAttributes) = FileSystemRights.ReadExtendedAttributes, "|1", "|0") & _
                                 IIf(((acc.FileSystemRights And FileSystemRights.CreateFiles) = FileSystemRights.CreateFiles And _
                                      (acc.FileSystemRights And FileSystemRights.WriteData) = FileSystemRights.WriteData), "|1", "|0") & _
                                 IIf(((acc.FileSystemRights And FileSystemRights.CreateDirectories) = FileSystemRights.CreateDirectories And _
                                      (acc.FileSystemRights And FileSystemRights.AppendData) = FileSystemRights.AppendData), "|1", "|0") & _
                                 IIf((acc.FileSystemRights And FileSystemRights.WriteAttributes) = FileSystemRights.WriteAttributes, "|1", "|0") & _
                                 IIf((acc.FileSystemRights And FileSystemRights.WriteExtendedAttributes) = FileSystemRights.WriteExtendedAttributes, "|1", "|0") & _
                                 IIf((acc.FileSystemRights And FileSystemRights.DeleteSubdirectoriesAndFiles) = FileSystemRights.DeleteSubdirectoriesAndFiles, "|1", "|0") & _
                                 IIf((acc.FileSystemRights And FileSystemRights.Delete) = FileSystemRights.Delete, "|1", "|0") & _
                                 IIf((acc.FileSystemRights And FileSystemRights.ReadPermissions) = FileSystemRights.ReadPermissions, "|1", "|0") & _
                                 IIf((acc.FileSystemRights And FileSystemRights.ChangePermissions) = FileSystemRights.ChangePermissions, "|1", "|0") & _
                                 IIf((acc.FileSystemRights And FileSystemRights.TakeOwnership) = FileSystemRights.TakeOwnership, "|1", "|0") & _
                                 IIf((acc.FileSystemRights And FileSystemRights.Synchronize) = FileSystemRights.Synchronize, "|1", "|0")
    End Function

    Public Function advFlagsToSumFlags(ByVal advFlags As String) As String ', ByVal appTo As permApplyTo
        Select Case advFlags
            Case "1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|ThisFolderSubFoldersFiles"
                Return "1|1|1|1|1|1|0"  'Full Control
            Case "0|1|1|1|1|1|1|1|1|0|1|1|0|0|1|ThisFolderSubFoldersFiles"
                Return "0|1|1|1|1|1|0"  'Modify
            Case "0|1|1|1|1|0|0|0|0|0|0|1|0|0|1|ThisFolderSubFoldersFiles"
                Return "0|0|1|1|1|0|0"  'Read and Execute
            Case "0|1|1|1|1|0|0|0|0|0|0|1|0|0|1|ThisFolderSubFolders"
                Return "0|0|0|1|1|0|0"  'List Folder Contents
            Case "0|0|1|1|1|0|0|0|0|0|0|1|0|0|1|ThisFolderSubFoldersFiles"
                Return "0|0|0|0|1|0|0"  'Read
            Case "0|0|0|0|0|1|1|1|1|0|0|0|0|0|1|ThisFolderSubFoldersFiles"
                Return "0|0|0|0|0|1|0"  'Write
            Case Else
                Dim special As String = "0|0|0|0|0|0|1"  'Special
                Select Case advFlags
                    Case testFlags(advFlags, "0|1|1|1|1|1|1|1|1|0|1|1|0|0|1|ThisFolderSubFoldersFiles")
                        special = switchFlag("X|1|1|1|1|1|X", special)  'Modify
                    Case testFlags(advFlags, "0|1|1|1|1|0|0|0|0|0|0|1|0|0|1|ThisFolderSubFoldersFiles")
                        special = switchFlag("X|X|1|1|1|X|X", special)  'Read and Execute
                    Case testFlags(advFlags, "0|1|1|1|1|0|0|0|0|0|0|1|0|0|1|ThisFolderSubFolders")
                        special = switchFlag("X|X|X|1|1|X|X", special)  'List Folder Contents
                    Case testFlags(advFlags, "0|0|1|1|1|0|0|0|0|0|0|1|0|0|1|ThisFolderSubFoldersFiles")
                        special = switchFlag("X|X|X|X|1|X|X", special)  'Read
                    Case testFlags(advFlags, "0|0|0|0|0|1|1|1|1|0|0|0|0|0|1|ThisFolderSubFoldersFiles")
                        special = switchFlag("X|X|X|X|X|1|X", special)  'Write
                End Select
                Return special
        End Select
    End Function

    Public Function testFlags(ByVal compare As String, ByVal compareTo As String) As Boolean
        Dim compareList() As String = compare.Split("|")
        Dim compareToList() As String = compareTo.Split("|")
        Dim test As Boolean = True
        Dim i As Integer = compareList.Length

        While test And i > 0
            If compareToList(i) = "1" And compareList(i) <> compareToList(i) Then
                test = False
            End If
            i = i - 1
        End While
    End Function

    Public Function switchFlag(ByVal compare As String, ByVal compareTo As String) As Boolean
        Dim compareList() As String = compare.Split("|")
        Dim compareToList() As String = compareTo.Split("|")
        Dim test As Boolean = True
        Dim i As Integer = compareList.Length

        While test And i > 0
            If compareToList(i) = "1" And compareList(i) <> compareToList(i) Then
                test = False
            End If
            i = i - 1
        End While
    End Function

    Public Function sumFlagsToAdvFlags(ByVal sumFlags As String) As List(Of String)
        Dim ret As List(Of String) = New List(Of String)
        Select Case sumFlags
            Case "1|1|1|1|1|1|0"
                ret.Add("1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|ThisFolderSubFoldersFiles")  'Full Control
            Case "0|1|1|1|1|1|0"
                ret.Add("0|1|1|1|1|1|1|1|1|0|1|1|0|0|1|ThisFolderSubFoldersFiles")    'Modify
            Case "0|0|1|1|1|1|0"
                ret.Add("0|1|1|1|1|1|1|1|1|0|0|1|0|0|1|ThisFolderSubFoldersFiles")    'Read, Write & Execute
            Case "0|0|1|1|1|0|0"
                ret.Add("0|1|1|1|1|0|0|0|0|0|0|1|0|0|1|ThisFolderSubFoldersFiles")    'Read and Execute
            Case "0|0|0|1|1|0|0"
                ret.Add("0|1|1|1|1|0|0|0|0|0|0|1|0|0|1|ThisFolderSubFolders")         'List Folder Contents
                ret.Add("0|0|1|1|1|0|0|0|0|0|0|1|0|0|1|ThisFolderSubFoldersFiles")    'Read
            Case "0|0|0|1|0|0|0"
                ret.Add("0|1|1|1|1|0|0|0|0|0|0|1|0|0|1|ThisFolderSubFolders")         'List Folder Contents
            Case "0|0|0|1|1|1|0"
                ret.Add("0|1|1|1|1|0|0|0|0|0|0|1|0|0|1|ThisFolderSubFolders")         'List Folder Contents
                ret.Add("0|0|1|1|1|1|1|1|1|0|0|1|0|0|1|ThisFolderSubFoldersFiles")    'Special (Read & Write)
            Case "0|0|0|1|0|1|0"
                ret.Add("0|1|1|1|1|0|0|0|0|0|0|1|0|0|1|ThisFolderSubFolders")         'List Folder Contents
                ret.Add("0|0|0|0|0|1|1|1|1|0|0|0|0|0|1|ThisFolderSubFoldersFiles")    'Write
            Case "0|0|0|0|1|1|0"
                ret.Add("0|0|1|1|1|1|1|1|1|0|0|1|0|0|1|ThisFolderSubFoldersFiles")    'Special (Read & Write)
            Case "0|0|0|0|1|0|0"
                ret.Add("0|0|1|1|1|0|0|0|0|0|0|1|0|0|1|ThisFolderSubFoldersFiles")    'Read
            Case "0|0|0|0|0|1|0"
                ret.Add("0|0|0|0|0|1|1|1|1|0|0|0|0|0|1|ThisFolderSubFoldersFiles")    'Write
            Case Else
                ret.Add("Special")
        End Select
        Return ret
    End Function

    Public Function sumFlagsToSring(ByVal sumFlags As String) As String
        Select Case sumFlags
            Case "1|1|1|1|1|1|0"
                Return "Full Control"
            Case "0|1|1|1|1|1|0"
                Return "Modify"
            Case "0|0|1|1|1|0|0"
                Return "Read and Execute"
            Case "0|0|0|1|0|0|0"
                Return "List Folder Contents"
            Case "0|0|0|0|1|0|0"
                Return "Read"
            Case "0|0|0|0|0|1|0"
                Return "Write"
            Case Else
                Return "Special"
        End Select
    End Function

    Public Function isInherited(ByVal FolderAcl As DirectorySecurity) As Boolean
        If FolderAcl.GetAccessRules(False, True, GetType(System.Security.Principal.SecurityIdentifier)).Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Enum permApplyTo
        ThisFolder = 1
        ThisFolderSubFoldersFiles
        ThisFolderSubFolders
        ThisFolderFiles
        SubFoldersFiles
        SubFolders
        Files
    End Enum

End Module
