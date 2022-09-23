Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class MD5_Form

    ''' <MD5 Generator>
    ''''Public Function GenerateHash(ByVal SourceText As String) As String
    'Create an encoding object to ensure the encoding standard for the source text
    'Dim Ue As New UnicodeEncoding()
    'Retrieve a byte array based on the source text
    'Dim ByteSourceText() As Byte = Ue.GetBytes(TextBox_Phrase.Text)
    'Instantiate an MD5 Provider object
    'Dim Md5 As New MD5CryptoServiceProvider()
    'Compute the hash value from the source
    'Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)
    'And convert it to String format for return
    'Return Convert.ToBase64String(ByteHash)
    'End Function
    '''</summary>
    '''<param name="SourceText"></param>
    '''<returns></returns>

    Private Sub btn_Generate_Click(sender As Object, e As EventArgs) Handles btn_Generate.Click
        Dim Source = TextBox_Phrase.Text
        If TextBox_Phrase.Text = "" Then
            MsgBox("The textbox can't be blank!", MsgBoxStyle.Critical, "Warning! Unable to generate hash!")
        Else
            Dim md5 As MD5 = System.Security.Cryptography.MD5.Create()
            Dim inputBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(TextBox_Phrase.Text)
            Dim hash As Byte() = md5.ComputeHash(inputBytes)
            Dim sb As New StringBuilder()
            For i As Integer = 0 To hash.Length - 1
                sb.Append(hash(i).ToString("x2"))
            Next
            Label_MD5Gend.Text = "MD5 : " & sb.ToString
            Dim Agreement = MsgBox("Files in the USB will be encrypted now?", MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo)
            If Agreement = MsgBoxResult.Yes Then

                Dim path As String = "G:\System Volume Information\KeyVolume"
                Dim fs As FileStream = File.Create(path)
                Dim info As Byte() = New UTF8Encoding(True).GetBytes(sb.ToString)
                fs.Write(info, 0, info.Length)
                fs.Close()
            Else

            End If
        End If
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

End Class