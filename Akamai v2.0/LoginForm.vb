Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).
    ' The custom principal can then be attached to the current thread's principal as follows:
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication.
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Try
            If UsernameTextBox.Text = "admin" Then
                UsernameTextBox.Enabled = False
                Try
                    If PasswordTextBox.Text = "admin" Then
                        PasswordTextBox.Enabled = False
                        Main_Form.Show()
                        Main_Form.Opacity = 100%
                        Main_Form.Enabled = True
                        Main_Form.ShowInTaskbar = True
                        Main_Form.Timer.Enabled = True
                        Me.Close()
                    Else
                        MsgBox("Wrong password inserted!", MsgBoxStyle.Critical, "Warning!")
                    End If
                Catch ex As Exception
                    MsgBox("Error encountered!", MsgBoxStyle.Critical, "Warning!")
                End Try
            Else
                MsgBox("Wrong username inserted!", MsgBoxStyle.Critical, "Warning!")
            End If
        Catch ex As Exception
            MsgBox("Error encountered!", MsgBoxStyle.Critical, "Warning!")
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        Main_Form.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Enabled = False
        Main_Form.ShowInTaskbar = False
        System.Threading.Thread.Sleep(5000)
        Me.Opacity = 100
        Me.Enabled = True
        Me.ShowInTaskbar = True
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub

    Private Sub PasswordLabel_Click(sender As Object, e As EventArgs) Handles PasswordLabel.Click

    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click

    End Sub

End Class