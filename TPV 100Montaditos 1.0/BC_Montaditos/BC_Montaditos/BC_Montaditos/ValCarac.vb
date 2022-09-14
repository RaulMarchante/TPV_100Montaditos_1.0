Public Class ValCarac
    Function ValCarac(letras As String)
        'comprueba si son letras
        Dim a, b As Integer
        Dim com, x As Char
        Dim valido As String = "qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNMáéíóúÁÉÍÓÚ"
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
