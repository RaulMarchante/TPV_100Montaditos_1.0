Imports System.IO
Imports System.Drawing.Printing
Imports BC_Montaditos
Public Class Caja

    'Validación del Textbox TBunidades
    Private Sub TBUnidades_TextChanged(sender As Object, e As EventArgs) Handles TBUnidades.TextChanged
       
        Dim noV() As Char = TBUnidades.Text.ToCharArray
      
        For i As Integer = 0 To noV.Length - 1

            If noV(i) = "-" Or noV(i) = "+" Then
                TBUnidades.Clear()
                Exit Sub
            End If
        Next
       
        If TBUnidades.Text = "" Then
            Exit Sub
        ElseIf Not IsNumeric(TBUnidades.Text) And Not TBUnidades.Text = "" Then
            MsgBox("Introduzca solo números", MsgBoxStyle.Information, "Dato incorrecto")
            TBUnidades.Clear()
            Exit Sub
        ElseIf TBUnidades.Text = 0 Then
            TBUnidades.Clear()
            Exit Sub
        End If
    End Sub
    'Boton que sirve para salir del programa
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim i As Integer
        i = MsgBox("¿Estas seguro de que deseas salir?", 292, "Salir")
        If i = 6 Then
            Try
                Inicio.Close()
                Inicio.Dispose()
                AñadirItem.Close()
                AñadirItem.Dispose()
                Productos.Close()
                Productos.Dispose()
                AdministrarUsuarios.Close()
                AdministrarUsuarios.Dispose()
                Me.Close()
                Me.Dispose()



            Catch ex As Exception

            End Try

        End If
    End Sub
    'Validacion del textbox Efectivo y operaciones para el calculo del cambio
    Private Sub TBEfectivo_TextChanged(sender As Object, e As EventArgs) Handles TBEfectivo.TextChanged
        Dim a As Double
        
        Dim noV() As Char = TBEfectivo.Text.ToCharArray
        For i As Integer = 0 To noV.Length - 1

            If noV(i) = "-" Or noV(i) = "+" Then
                TBEfectivo.Clear()
                Exit Sub
            End If
        Next

        If TBEfectivo.Text = "" Then
            LCambio.Text = 0 - LPrecio.Text
        ElseIf Not IsNumeric(TBEfectivo.Text) Then
            TBEfectivo.Clear()
        ElseIf TBEfectivo.Text > 500 Then
            a = 0 - LPrecio.Text
            LCambio.Text = Math.Round(a, 2)
            TBEfectivo.Clear()
            Exit Sub
        Else
            a = TBEfectivo.Text - LPrecio.Text
            LCambio.Text = Math.Round(a, 2)
        End If

    End Sub


    'Muestra la ventana de administracion de usuarios
    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        AdministrarUsuarios.Show()


    End Sub
    'Muestra la ventana de administracion de productos
    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Productos.Show()


    End Sub
    'Muestra la ventana de seleccion de montadito
    Private Sub BMontadito_Click(sender As Object, e As EventArgs) Handles BMontadito.Click
        AñadirItem.Show()

    End Sub
    'Operaciones para el calculo del cambio
    Private Sub LPrecio_Click(sender As Object, e As EventArgs) Handles LPrecio.TextChanged
        If LPrecio.Text = "" Or TBEfectivo.Text = "" Then
            Exit Sub
        Else
            LCambio.Text = TBEfectivo.Text - LPrecio.Text

        End If
    End Sub
    'Boton que saca en la lista de productos todos los productos del tipo Bebidas
    Private Sub BBebidas_Click(sender As Object, e As EventArgs) Handles BBebidas.Click
        'Limpia la lista de productos
        LBProductos.Items.Clear()
        LBProductoPrecio.Items.Clear()

        Try
            'Abre el archivo y bisca todos los productos de su categoria
            FileOpen(4, "Bebidas", OpenMode.Random, OpenAccess.Read, , Len(mt))
            While Not EOF(4)
                FileGet(4, mt, )
                LBProductos.Items.Add(mt.nombre)
                LBProductoPrecio.Items.Add(mt.precio)
            End While
        Catch ex As Exception
            'Si ocurre un error sale un mensaje con el tipo de error
            FileOpen(7, "Errores", OpenMode.Append)
            Write(7, Err.Description & Now)
            MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
            FileClose(7)
        Finally
            'Se cierra el archivo haya error o no
            FileClose(4)
        End Try

    End Sub
    'Boton que saca en la lista de productos todos los productos del tipo Aperitivos
    Private Sub BAperitivos_Click(sender As Object, e As EventArgs) Handles BAperitivos.Click
        'Limpia la lista de productos
        LBProductos.Items.Clear()
        LBProductoPrecio.Items.Clear()

        Try
            'Abre el archivo y bisca todos los productos de su categoria
            FileOpen(5, "Aperitivos", OpenMode.Random, OpenAccess.Read, , Len(mt))
            While Not EOF(5)
                FileGet(5, mt, )
                LBProductos.Items.Add(mt.nombre)
                LBProductoPrecio.Items.Add(mt.precio)
            End While
        Catch ex As Exception
            'Si ocurre un error sale un mensaje con el tipo de error
            FileOpen(7, "Errores", OpenMode.Append)
            Write(7, Err.Description & Now)
            MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
            FileClose(7)
            'Se cierra el archivo haya error o no
        Finally
            FileClose(5)
        End Try
    End Sub
    'Boton que saca en la lista de productos todos los productos del tipo Helados
    Private Sub BHelados_Click(sender As Object, e As EventArgs) Handles BHelados.Click
        'Limpia la lista de productos
        LBProductos.Items.Clear()
        LBProductoPrecio.Items.Clear()

        Try
            'Abre el archivo y bisca todos los productos de su categoria
            FileOpen(6, "Helados", OpenMode.Random, OpenAccess.Read, , Len(mt))
            While Not EOF(6)
                FileGet(6, mt, )
                LBProductos.Items.Add(mt.nombre)
                LBProductoPrecio.Items.Add(mt.precio)
            End While
        Catch ex As Exception
            'Si ocurre un error sale un mensaje con el tipo de error
            FileOpen(7, "Errores", OpenMode.Append)
            Write(7, Err.Description & Now)
            MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
            FileClose(7)
            'Se cierra el archivo haya error o no
        Finally
            FileClose(6)
        End Try
    End Sub
    'Boton que agrega productos de la lista de productos a la lista de recibo
    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        'Si no se introducen unidades en el textbox de unidades no deja agregar
        If TBUnidades.Text = "" Then
            MsgBox("Introduzca una cantidad por favor", MsgBoxStyle.Information, "Cantidad no especificada")
        Else
            Try

                LBReferencia.Items.Add(LBProductos.SelectedItem)
                LBPrecio.Items.Add(LBProductoPrecio.Items(LBProductos.SelectedIndex).ToString * TBUnidades.Text)
                LBCantidad.Items.Add(TBUnidades.Text)
                LPrecio.Text = LPrecio.Text + (LBProductoPrecio.Items(LBProductos.SelectedIndex).ToString * TBUnidades.Text)
            Catch
                MsgBox("Seleccione un producto de la lista", MsgBoxStyle.Information, "Falta selección de producto")


            End Try
        End If




    End Sub
    'Boton que reinicia la lista del recibo
    Private Sub BQuitarTodo_Click(sender As Object, e As EventArgs) Handles BQuitarTodo.Click
        LBCantidad.Items.Clear()
        LBReferencia.Items.Clear()
        LBPrecio.Items.Clear()
        LPrecio.Text = 0
    End Sub
    'Botón que permite retirar productos de la lista del recibo
    Private Sub BQuitar_Click(sender As Object, e As EventArgs) Handles BQuitar.Click

        Try
            Dim k As Integer = LBReferencia.SelectedIndex
            Dim b As Double = LBPrecio.Items(k).ToString
            LBReferencia.Items.Remove(LBReferencia.SelectedItem)

            LPrecio.Text = LPrecio.Text - b
            LBPrecio.Items.RemoveAt(k)
            LBCantidad.Items.RemoveAt(k)

        Catch ex As Exception
            MsgBox("Seleccione un producto de la lista", MsgBoxStyle.Information, "Falta seleccion de producto")
        End Try


    End Sub
    'Confiduracion del boton cobrar
    Private Sub BCobrar_Click(sender As Object, e As EventArgs) Handles BCobrar.Click
        'Si no hay objetos en la lista de recibo no deja cobrar
        If LBReferencia.Items.Count = 0 Then
            MsgBox("No se encuentran productos en el recibo", MsgBoxStyle.Information, "Recibo vacio")
            Exit Sub
        End If
        'Impresion del ticket
        Try
            AddHandler PrintDocument1.PrintPage, AddressOf Me.ticket
            PrintDocument1.Print()
        Catch ex As Exception

        End Try
        'Operacion para el calculo de caja
        Producto.total_dia = Producto.total_dia + LPrecio.Text
    End Sub
    'Boton que permite comprobar la caja y guarda los datos en un fichero
    Private Sub ComprobarCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprobarCajaToolStripMenuItem.Click
        MsgBox("En la fecha  " & Now & " se ha recaudado un total de " & Producto.total_dia & "€")
        FileOpen(9, "Caja_diaria", OpenMode.Append)
        Write(9, "En la fecha  " & Now & " se ha recaudado un total de " & Producto.total_dia & "€")

        FileClose(9)

    End Sub
    'Boton de cerrar sesion
    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Inicio.Show()

        Me.Close()
        Me.Dispose()
    End Sub
    'Boton que reinicia el formulario para atender un nuevo pedido
    Private Sub NuevoPedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoPedidoToolStripMenuItem.Click
        LBCantidad.Items.Clear()
        LBPrecio.Items.Clear()
        LBProductoPrecio.Items.Clear()
        LBProductos.Items.Clear()
        LBReferencia.Items.Clear()
        LPrecio.Text = 0
        TBNombre.Clear()
        TBUnidades.Text = 1
        TBEfectivo.Text = 0
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
    'Formato del ticket
    Private Sub Ticket(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Try
            Dim i As Integer
            Dim ivaNo As Integer
            Dim ivaextra As Integer
            e.Graphics.DrawImage(Image.FromFile("Monta.png"), 255, 100, 300, 150)
            e.Graphics.DrawString("Princesa 7", New Font("Arial", 11, FontStyle.Italic), Brushes.Black, 270, 280)
            e.Graphics.DrawString("28008 Madrid", New Font("Arial", 11, FontStyle.Italic), Brushes.Black, 270, 300)
            e.Graphics.DrawString("Montaprincesa7 SL", New Font("Arial", 11, FontStyle.Italic), Brushes.Black, 270, 320)
            e.Graphics.DrawString("CIF: B85989903", New Font("Arial", 11, FontStyle.Italic), Brushes.Black, 270, 340)
            e.Graphics.DrawString("FACTURA SIMPLIFICADA", New Font("Arial", 11, FontStyle.Italic), Brushes.Black, 270, 360)
            e.Graphics.DrawString("-------------------------------", New Font("Arial", 11, FontStyle.Italic), Brushes.Black, 270, 380)
            e.Graphics.DrawString(Now, New Font("Arial", 11, FontStyle.Italic), Brushes.Black, 270, 400)
            e.Graphics.DrawString("-------------------------------", New Font("Arial", 11, FontStyle.Italic), Brushes.Black, 270, 420)
            e.Graphics.DrawString("Nombre: " + TBNombre.Text, New Font("Arial", 11, FontStyle.Italic), Brushes.Black, 270, 440)
            e.Graphics.DrawString("-------------------------------", New Font("Arial", 11, FontStyle.Italic), Brushes.Black, 270, 460)
            Dim y As Integer = 480
            For i = 0 To LBReferencia.Items.Count - 1
                e.Graphics.DrawString(LBCantidad.Items.Item(i) & "x     " & Trim(LBReferencia.Items.Item(i)) & "     " & LBPrecio.Items.Item(i) & "€", New Font("Arial", 8, FontStyle.Italic), Brushes.Black, 270, y)
                y += 20
            Next
            e.Graphics.DrawString("-------------------------------", New Font("Arial", 11, FontStyle.Italic), Brushes.Black, 270, y)
            y = y + 20
            e.Graphics.DrawString("TOTAL: " & LPrecio.Text & "€", New Font("Arial", 16, FontStyle.Bold), Brushes.Black, 270, y)
            y = y + 20
            e.Graphics.DrawString("-------------------------------", New Font("Arial", 11, FontStyle.Italic), Brushes.Black, 270, y)
            y = y + 20
            e.Graphics.DrawString("Base Imp      %IVA     IVA ", New Font("Arial", 11, FontStyle.Italic), Brushes.Black, 270, y)
            ivaNo = LPrecio.Text * 100 / 110
            ivaextra = LPrecio.Text - ivaNo
            y = y + 20
            e.Graphics.DrawString(ivaNo & " €             10%            " & ivaextra & "€", New Font("Arial", 11, FontStyle.Italic), Brushes.Black, 270, y)
            y = y + 20
            e.Graphics.DrawString("Efectivo: " + TBEfectivo.Text & "€", New Font("Arial", 11, FontStyle.Italic), Brushes.Black, 270, y)
            y = y + 20
            e.Graphics.DrawString("Devolucion: " + LCambio.Text & "€", New Font("Arial", 11, FontStyle.Italic), Brushes.Black, 270, y)
            y = y + 20
            e.Graphics.DrawString("-------------------------------", New Font("Arial", 11, FontStyle.Italic), Brushes.Black, 270, y)
            y = y + 20
            e.Graphics.DrawString("Gracias por su visita", New Font("Arial", 11, FontStyle.Italic), Brushes.Black, 270, y)
            e.HasMorePages = False
        Catch
        End Try
    End Sub
    'Validación del textbox TBNombre
    Private Sub TBNombre_TextChanged(sender As Object, e As EventArgs) Handles TBNombre.TextChanged
        Dim cV As New ValCarac
        Dim comp As Boolean
        Dim num As String = TBNombre.Text
        comp = cV.ValCarac(num)
        If (comp = False) Then
            MsgBox("Caracter no valido", MsgBoxStyle.Information, "Caracter no valido")
            TBNombre.Clear()

        End If
        If LCambio.Text < 0 Or TBNombre.Text = "" Or LPrecio.Text < 1 Then
            BCobrar.Enabled = False
        Else
            BCobrar.Enabled = True
        End If
    End Sub
    'Gatillo que indica cuando desbloquear el botón cobrar
    Private Sub LCambio_Click(sender As Object, e As EventArgs) Handles LCambio.TextChanged
        If LCambio.Text < 0 Or TBNombre.Text = "" Or LPrecio.Text < 1 Then
            BCobrar.Enabled = False
        Else
            BCobrar.Enabled = True
        End If
    End Sub
    'Gatillo que indica cuando desbloquear el botón cobrar
    Private Sub LPrecio_Click_1(sender As Object, e As EventArgs) Handles LPrecio.Click
        If LCambio.Text < 0 Or TBNombre.Text = "" Or LPrecio.Text < 1 Then
            BCobrar.Enabled = False
        Else
            BCobrar.Enabled = True
        End If
    End Sub


End Class
