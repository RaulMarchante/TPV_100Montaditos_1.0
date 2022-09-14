Public Class ValNumero
    Function numero(num As String)
        'comprueba si es un numero
        Dim correcto As Boolean = True
        Dim noV() As Char = num.ToCharArray
        If (num = "") Then

        Else
            For i As Integer = 0 To noV.Length - 1

                If noV(i) = "-" Or noV(i) = "+" Then
                    correcto = False
                End If

            Next
            If Not IsNumeric(num) Then
                correcto = False
            End If

        End If
        Return correcto
    End Function
End Class
