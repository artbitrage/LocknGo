Imports System.Security.Cryptography
Imports System.Text

Public Class Class_MD5

    Public Function Md5FromString(ByVal Source As String) As String
        MD5_Form.TextBox_Phrase.Text = Source
        Dim Bytes() As Byte
        Dim sb As New StringBuilder()
        'Check for empty string.
        If String.IsNullOrEmpty(Source) Then
            Throw New ArgumentNullException
        End If
        'Get bytes from string.
        Bytes = Encoding.Default.GetBytes(Source)
        'Get md5 hash
        Bytes = MD5.Create().ComputeHash(Bytes)
        'Loop though the byte array and convert each byte to hex.
        For x As Integer = 0 To Bytes.Length - 1
            sb.Append(Bytes(x).ToString("x2"))
        Next
        'Return md5 hash.
        Return sb.ToString()
    End Function

    Friend Shared Sub Md5FromString()
        Throw New NotImplementedException()
    End Sub

End Class