Option Strict Off
Option Explicit On
Friend Class NotUsed_frmAbout
    Inherits System.Windows.Forms.Form

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        Me.Close()
    End Sub

    Private Sub frmAbout_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.Text = "About " & My.Application.Info.Title
        'UPGRADE_ISSUE: PictureBox method Pic.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Pic.Cls()
        ''UPGRADE_ISSUE: PictureBox method Pic.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Pic.Print("Colt Engineering (Ontario) Corporation")
        ''UPGRADE_ISSUE: PictureBox method Pic.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Pic.Print("A Division of WorleyParsons Canada")
        ''UPGRADE_ISSUE: PictureBox method Pic.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Pic.Print(My.Application.Info.Title & " v" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Revision)
        ''UPGRADE_ISSUE: PictureBox method Pic.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Pic.Print("")
        ''UPGRADE_ISSUE: PictureBox method Pic.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Pic.Print("")
        ''UPGRADE_ISSUE: PictureBox method Pic.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Pic.Print("Created By: Shawn Landers")
        ''UPGRADE_ISSUE: PictureBox method Pic.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Pic.Print("                   Shawn.Landers@WorleyParsons.com")
    End Sub

    Private Sub Pic_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Pic.Paint
        Dim TextFont As New System.Drawing.Font("Arial", 10, FontStyle.Regular)
        Dim TextBrush As New System.Drawing.SolidBrush(System.Drawing.Color.RoyalBlue)
        e.Graphics.DrawString("NANA WorleyParsons LLC", TextFont, TextBrush, 10, 10)
        e.Graphics.DrawString("A division of NANA Development Corp. and WorleyParsons", TextFont, TextBrush, 10, 20)
        e.Graphics.DrawString(My.Application.Info.Title & " v" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Revision, TextFont, TextBrush, 10, 30)
        e.Graphics.DrawString("", TextFont, TextBrush, 10, 40)
        e.Graphics.DrawString("", TextFont, TextBrush, 10, 50)
        e.Graphics.DrawString("Created in VB6 By: Shawn Landers", TextFont, TextBrush, 10, 60)
        e.Graphics.DrawString("Rewritten in VB .NET By: Aaron Werning", TextFont, TextBrush, 10, 70)
        e.Graphics.DrawString("Aaron.Werning@nanaworleyparsons.com", TextFont, TextBrush, 10, 80)
        TextFont.Dispose()
        TextBrush.Dispose()
    End Sub
End Class