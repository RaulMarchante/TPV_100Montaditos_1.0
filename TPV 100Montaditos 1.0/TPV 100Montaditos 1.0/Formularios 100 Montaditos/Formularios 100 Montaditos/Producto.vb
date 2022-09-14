Module Producto
    Structure Montaditos
        <VBFixedString(3)> Dim id As String
        <VBFixedString(100)> Dim nombre As String
        Dim precio As Double
    End Structure
    Public mt As Montaditos
    Public total_dia As Double
End Module
