Module Usuarios
    'Estructura para los datos de los usuarios
    Structure Usuarios
        Dim id As Single
        <VBFixedString(12)> Dim usuario As String
        <VBFixedString(10)> Dim nombre As String
        <VBFixedString(12)> Dim apellido As String
        <VBFixedString(15)> Dim contrasena As String
        <VBFixedString(9)> Dim dni As String
        <VBFixedString(9)> Dim telefono As String
        <VBFixedString(30)> Dim correo As String
        <VBFixedString(8)> Dim rol As String
    End Structure
    Public adminaccess As Boolean
    Public user As New Usuarios
End Module
