Imports System.Text.RegularExpressions
Public Class ValCorreo
    'comprueba si es un correo valido
    Function ValCorreo(correo As String) As Boolean
        Return Regex.IsMatch(correo, "^[_a-z0-9-]+@[montaditos]+\.([a-z]{2,4})$")
    End Function
End Class