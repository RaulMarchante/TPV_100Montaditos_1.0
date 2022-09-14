Public Class ValCaracNum
    Function ValCaracNum(letras As String)
        'valida si son letras y numeros
        Dim a, b As Integer
        Dim com, x As Char
        Dim valido As String = "qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM0123456789"
        Dim correcto As Boolean = True
        If (letras = "") Then

        Else
            For a = 1 To letras.Length
                x = GetChar(letras, a)
                correcto = False
                For b = 1 To valido.Length
                    com = GetChar(valido, b)
                    If x = com Then
                        correcto = True
                        b = valido.Length
                    End If
                Next b
            Next a
        End If
        Return correcto
    End Function
End Class
