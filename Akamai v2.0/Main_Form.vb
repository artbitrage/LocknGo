Public Class Main_Form

    Private Sub ToolStripStatusLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Me.Enabled = False
        LoginForm.Show()
        Label_Status.Text = "Started on: " & Now & "."
        Label_Version.Text = "v2.1 1511 build 2586 (Beta Release)"
        ProgressBar.Value = 100
        Label_Progress.Text = ProgressBar.Value & "% complete."
        BasicToolStripMenuItem.Checked = True
        ExpertToolStripMenuItem.Enabled = False
        AkamaiTerminalToolStripMenuItem.Enabled = False
        'SHA1ToolStripMenuItem.Checked = False
        'SHA5ToolStripMenuItem.Checked = False
        MD5ToolStripMenuItem.Checked = True
        'SHA1ToolStripMenuItem.Enabled = False
        'SHA5ToolStripMenuItem.Enabled = False
        'SHA1ToolStripMenuItem.Text = ""
        'SHA5ToolStripMenuItem.Text = ""
    End Sub

    Private Sub ListOfHashesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        AboutBox.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MD5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MD5ToolStripMenuItem.Click
        MD5ToolStripMenuItem.Checked = True
        'SHA1ToolStripMenuItem.Checked = False
        'SHA5ToolStripMenuItem.Checked = False
    End Sub

    Private Sub SHA1ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MD5ToolStripMenuItem.Checked = False
        'SHA1ToolStripMenuItem.Checked = True
        'SHA5ToolStripMenuItem.Checked = False
    End Sub

    Private Sub SHA5ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MD5ToolStripMenuItem.Checked = False
        'SHA1ToolStripMenuItem.Checked = False
        'SHA5ToolStripMenuItem.Checked = True
    End Sub

    Private Sub btn_Start_Click(sender As Object, e As EventArgs) Handles btn_Start.Click
        'If SHA5ToolStripMenuItem.Checked = True Then
        'Dim responseSHA5 = MsgBox("Files will be encrypted in the form of SHA-5. Are you sure?", MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo)
        'If responseSHA5 = MsgBoxResult.Yes Then
        'MessageBox.Show("Life continued.")
        'Else
        'End If
        'ElseIf SHA1ToolStripMenuItem.Checked = True Then
        'Dim responseSHA1 = MsgBox("Files will be encrypted in the form of SHA-1. Are you sure?", MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo)
        'If responseSHA1 = MsgBoxResult.Yes Then
        'MessageBox.Show("Life continued.")
        'End If
        'ElseIf'
        If MD5ToolStripMenuItem.Checked = True Then
            Dim responseMD5 = MsgBox("Files will be encrypted in the form of MD5. Are you sure?", MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo)
            If responseMD5 = MsgBoxResult.Yes Then
                MD5_Form.Show()
            End If
        End If

    End Sub

    Private Sub AkamaiTerminalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AkamaiTerminalToolStripMenuItem.Click

    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click

    End Sub

    Private Sub ExpertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpertToolStripMenuItem.Click

    End Sub

    Private Sub CLIModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLIModeToolStripMenuItem.Click

    End Sub

    Private Sub btn_Check_Click(sender As Object, e As EventArgs) Handles btn_Check.Click
        If My.Computer.FileSystem.FileExists("G:\System Volume Information\KeyVolume") Then
            Process.Start("C:\Users\MuhammadFaris\Desktop\FYP\Akamai v2.0\LiteLock\LiteLock\LiteLock.exe")
            'Process.Start("C:\Users\Lock&Go\Documents\Akamai v2.0\LiteLock\LiteLock\LiteLock.exe")
            'btn_Check.Enabled = False
        Else
            MsgBox("USB is not found / rooted!")
        End If
    End Sub

    Private Sub btn_Scan_Click(sender As Object, e As EventArgs) Handles btn_Scan.Click
        System.Diagnostics.Process.Start("C:\Users\MuhammadFaris\Desktop\FYP\Akamai v2.0\Shortcut.bat")
        'System.Diagnostics.Process.Start("C:\Users\Lock&Go\Documents\Akamai v2.0\Shortcut.bat")
    End Sub

    Private Sub OptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionToolStripMenuItem.Click

    End Sub

End Class