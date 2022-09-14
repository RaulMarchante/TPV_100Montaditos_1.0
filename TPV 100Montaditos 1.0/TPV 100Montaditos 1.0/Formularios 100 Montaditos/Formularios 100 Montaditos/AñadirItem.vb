Public Class AñadirItem
    Public valor As Double
    'Botón de cierre del formulario
    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub
    'Botón que añade un montadito a la lista y permite elegir otro
    Private Sub BAñadir_Click(sender As Object, e As EventArgs) Handles BAñadir.Click
        'Si no se introduce ningún dato en los Textbox no deja añadir el montadito
        If TBNºMontado.Text = "" Or TBCantidad.Text = "" Then

            MsgBox("Por favor rellene los campos antes de añadir un montadito", MsgBoxStyle.Information, "Campos vacios")
            Exit Sub
            'Si el Nº del montadito introducido es menor que cincuenta se le indica que debe buscar en el primer fichero de montaditos
        ElseIf TBNºMontado.Text < 51 And TBNºMontado.Text > 0 Then
            Try
                'abre el fichero
                FileOpen(2, "Montaditos1", OpenMode.Random, OpenAccess.Read, , Len(mt))
                'Se busca el montadito por número
                FileGet(2, mt, TBNºMontado.Text)
                'Se añade el montadito
                valor = mt.precio * TBCantidad.Text
                Caja.LBCantidad.Items.Add(TBCantidad.Text)
                Caja.LBReferencia.Items.Add("Montadito-" & TBNºMontado.Text)
                Caja.LBPrecio.Items.Add(Math.Round(valor, 2))
                Caja.LPrecio.Text = Caja.LPrecio.Text + Math.Round(valor, 2)

            Catch ex As Exception
                'En caso de algún error salta el mensaje de error
                FileOpen(7, "Errores", OpenMode.Output)
                Write(7, Err.Description & Now)
                MsgBox("El montadito que quiere introducir no existe", MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                'Al final exista o no error se cierra el fichero
                FileClose(2)

            End Try
            'Si el Nº del montadito introducido es mayor que cincuenta se le indica que debe buscar en el segundo fichero de montaditos
        ElseIf TBNºMontado.Text >= 51 Then
            Try
                'abre el fichero
                FileOpen(3, "Montaditos2", OpenMode.Random, OpenAccess.Read, , Len(mt))
                'Se busca el montadito por número 
                FileGet(3, mt, TBNºMontado.Text - 50)
                'Se añade el montadito
                valor = mt.precio * TBCantidad.Text
                Caja.LBCantidad.Items.Add(TBCantidad.Text)
                Caja.LBReferencia.Items.Add("Montadito-" & TBNºMontado.Text)
                Caja.LBPrecio.Items.Add(Math.Round(valor, 2))
                Caja.LPrecio.Text = Caja.LPrecio.Text + Math.Round(valor, 2)

            Catch ex As Exception
                'En caso de algún error salta el mensaje de error
                FileOpen(7, "Errores", OpenMode.Output)
                Write(7, Err.Description & Now)
                MsgBox("El montadito que quiere introducir no existe", MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                'Al final exista o no error se cierra el fichero
                FileClose(3)
            End Try
        End If
        'Una vez añadido el montadito limpia los campos para poder introducir otro
        TBCantidad.Clear()
        TBNºMontado.Clear()




    End Sub
    'Botón que añade un montadito a la lista y cierra el formulario
    Private Sub BTerminar_Click(sender As Object, e As EventArgs) Handles BTerminar.Click
        'Si no se introduce ningún dato en los Textbox no deja añadir el montadito
        If TBNºMontado.Text = "" Or TBCantidad.Text = "" Then

            MsgBox("Por favor rellene los campos antes de añadir un montadito", MsgBoxStyle.Information, "Campos vacios")
            Exit Sub
            'Si el Nº del montadito introducido es menor que cincuenta se le indica que debe buscar en el primer fichero de montaditos
        ElseIf TBNºMontado.Text < 51 And TBNºMontado.Text > 0 Then
            Try
                'abre el fichero
                FileOpen(2, "Montaditos1", OpenMode.Random, OpenAccess.Read, , Len(mt))
                'Se busca el montadito por número
                FileGet(2, mt, TBNºMontado.Text)
                'Se añade el montadito
                valor = mt.precio * TBCantidad.Text
                Caja.LBCantidad.Items.Add(TBCantidad.Text)
                Caja.LBReferencia.Items.Add("Montadito-" & TBNºMontado.Text)
                Caja.LBPrecio.Items.Add(Math.Round(valor, 2))
                Caja.LPrecio.Text = Caja.LPrecio.Text + Math.Round(valor, 2)

            Catch ex As Exception
                'En caso de algún error salta el mensaje de error
                FileOpen(7, "Errores", OpenMode.Output)
                Write(7, Err.Description & Now)
                MsgBox("El montadito que quiere introducir no existe", MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                'Al final exista o no error se cierra el fichero
                FileClose(2)
            End Try
            'Si el Nº del montadito introducido es mayor que cincuenta se le indica que debe buscar en el segundo fichero de montaditos
        ElseIf TBNºMontado.Text >= 51 Then
            Try
                'abre el fichero
                FileOpen(3, "Montaditos2", OpenMode.Random, OpenAccess.Read, , Len(mt))
                'Se busca el montadito por número
                FileGet(3, mt, TBNºMontado.Text - 50)
                'Se añade el montadito
                valor = mt.precio * TBCantidad.Text
                Caja.LBCantidad.Items.Add(TBCantidad.Text)
                Caja.LBReferencia.Items.Add("Montadito-" & TBNºMontado.Text)
                Caja.LBPrecio.Items.Add(Math.Round(valor, 2))
                Caja.LPrecio.Text = Caja.LPrecio.Text + Math.Round(valor, 2)

            Catch ex As Exception
                'En caso de algún error salta el mensaje de error
                FileOpen(7, "Errores", OpenMode.Output)
                Write(7, Err.Description & Now)
                MsgBox("El montadito que quiere introducir no existe", MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                'Al final exista o no error se cierra el fichero
                FileClose(3)
            End Try
        End If
        Me.Close()
        Me.Dispose()
    End Sub
    'Validacion del textbox TBNºMontadito
    Private Sub TBNºMontado_TextChanged(sender As Object, e As EventArgs) Handles TBNºMontado.TextChanged
        Dim noV() As Char = TBNºMontado.Text.ToCharArray
        For i As Integer = 0 To noV.Length - 1

            If noV(i) = "-" Or noV(i) = "+" Then
                TBNºMontado.Clear()
                Exit Sub
            End If

        Next
        If Not IsNumeric(TBNºMontado.Text) Then
            TBNºMontado.Clear()
        End If
    End Sub
    'Validacion del textbox TBCantidad
    Private Sub TBCantidad_TextChanged(sender As Object, e As EventArgs) Handles TBCantidad.TextChanged
        Dim noV() As Char = TBCantidad.Text.ToCharArray
        For i As Integer = 0 To noV.Length - 1

            If noV(i) = "-" Or noV(i) = "+" Then
                TBCantidad.Clear()
                Exit Sub
            End If

        Next
        If Not IsNumeric(TBCantidad.Text) Then
            TBCantidad.Clear()
        End If
    End Sub


End Class