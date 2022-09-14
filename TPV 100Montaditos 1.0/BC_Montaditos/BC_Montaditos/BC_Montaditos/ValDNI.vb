Public Class ValDNI
    Function ValDNI(dni As String)
        'comprueba si es un DNi real
        Dim correcto As Boolean = True
        Dim num As Integer
        Dim letras() As Char = {"T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X",
            "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E"}
        Dim c As Char
        Dim letr() As Char = dni.ToCharArray
        If (dni = "") Then
        Else
            num = Integer.Parse(dni.Substring(0, dni.Length - 1))
            If Not (dni(dni.Length - 1) = letras(num Mod 23)) Then
                correcto = False
            End If
        End If
        Return correcto

    End Function
End Class
