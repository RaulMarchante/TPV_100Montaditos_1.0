Imports BC_Montaditos

Public Class Productos

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTipo.SelectedIndexChanged
        'Tenemos que hacer todos los pasos por cada opción del combobox
        If CBTipo.SelectedItem = "Montaditos (1-50)" Then
            'Primero se limpia los listbox
            LBCodigo.Items.Clear()
            LBNombre.Items.Clear()
            LBPrecio.Items.Clear()
            'luego se abre el archivo correspondiente en este caso el de los montaditos de 1 a 50
            FileOpen(2, "Montaditos1", OpenMode.Random, OpenAccess.Read, , Len(mt))
            'luego rodeado por un try catch se lee el archivo y se introduce en el listbox
            Try
                While Not EOF(2)
                    FileGet(2, mt, )
                    LBCodigo.Items.Add(mt.id)
                    LBNombre.Items.Add(mt.nombre)
                    LBPrecio.Items.Add(mt.precio)
                End While

            Catch ex As Exception
                'En caso de que de error de algun tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                'Y por último si salta error o no se cerrara el fichero
                FileClose(2)
            End Try


        ElseIf CBTipo.SelectedItem = "Montaditos(51-100)" Then
            'Primero se limpia los listbox
            LBCodigo.Items.Clear()
            LBNombre.Items.Clear()
            LBPrecio.Items.Clear()
            'luego se abre el archivo correspondiente en este caso el de los montaditos de 50 a 100
            FileOpen(3, "Montaditos2", OpenMode.Random, OpenAccess.Read, , Len(mt))
            'luego rodeado por un try catch se lee el archivo y se introduce en el listbox
            Try
                While Not EOF(3)
                    FileGet(3, mt, )
                    LBCodigo.Items.Add(mt.id)
                    LBNombre.Items.Add(mt.nombre)
                    LBPrecio.Items.Add(mt.precio)
                End While
                'En caso de que de error de algun tipo saltara un MSGBox y se guardara el error en un fichero de errores
            Catch ex As Exception
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                'Y por último si salta error o no se cerrara el fichero
                FileClose(3)
            End Try

        ElseIf CBTipo.SelectedItem = "Bebidas" Then
            'Primero se limpia los listbox
            LBCodigo.Items.Clear()
            LBNombre.Items.Clear()
            LBPrecio.Items.Clear()
            'luego se abre el archivo correspondiente en este caso el de Bebidas
            FileOpen(4, "Bebidas", OpenMode.Random, OpenAccess.Read, , Len(mt))
            Try
                While Not EOF(4)
                    FileGet(4, mt, )
                    LBCodigo.Items.Add(mt.id)
                    LBNombre.Items.Add(mt.nombre)
                    LBPrecio.Items.Add(mt.precio)
                End While
                'En caso de que de error de algun tipo saltara un MSGBox y se guardara el error en un fichero de errores
            Catch ex As Exception
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                'Y por último si salta error o no se cerrara el fichero
                FileClose(4)
            End Try

        ElseIf CBTipo.SelectedItem = "Aperitivos" Then
            'Primero se limpia los listbox
            LBCodigo.Items.Clear()
            LBNombre.Items.Clear()
            LBPrecio.Items.Clear()
            'luego se abre el archivo correspondiente en este caso el de Aperitivos
            FileOpen(5, "Aperitivos", OpenMode.Random, OpenAccess.Read, , Len(mt))
            Try
                While Not EOF(5)
                    FileGet(5, mt, )
                    LBCodigo.Items.Add(mt.id)
                    LBNombre.Items.Add(mt.nombre)
                    LBPrecio.Items.Add(mt.precio)
                End While
                'En caso de que de error de algun tipo saltara un MSGBox y se guardara el error en un fichero de errores
            Catch ex As Exception
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                'Y por último si salta error o no se cerrara el fichero
                FileClose(5)
            End Try

        ElseIf CBTipo.SelectedItem = "Helados" Then
            'Primero se limpia los listbox
            LBCodigo.Items.Clear()
            LBNombre.Items.Clear()
            LBPrecio.Items.Clear()
            'luego se abre el archivo correspondiente en este caso el de los helados
            FileOpen(6, "Helados", OpenMode.Random, OpenAccess.Read, , Len(mt))
            Try
                While Not EOF(6)
                    FileGet(6, mt, )
                    LBCodigo.Items.Add(mt.id)
                    LBNombre.Items.Add(mt.nombre)
                    LBPrecio.Items.Add(mt.precio)
                End While
                'En caso de que de error de algun tipo saltara un MSGBox y se guardara el error en un fichero de errores
            Catch ex As Exception
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                'Y por último si salta error o no se cerrara el fichero
                FileClose(6)
            End Try

        End If
        'Y al final del método se limpian los campos de id
        TBid.Clear()
        TBNombre.Clear()
        TBPrecio.Clear()
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim a As Integer = 0
        'Primero se comprueba que los textbox tengan datos y si estan vacios no se permite el guardar
        If TBNombre.Text = "" Or TBPrecio.Text = "" Then
            MsgBox("Introduzca datos antes de guardar", MsgBoxStyle.Information, "Campos vacios")
            Exit Sub
        End If
        'Tenemos que hacer todos los pasos por cada opcion del combobox
        If CBTipo.SelectedItem = "Montaditos (1-50)" Then
            'Solo en este caso restringimos el numero de productos a solo 50
            If TBid.Text > 50 Then
                MsgBox("este registro no admite más de 50 productos si desea añadir mas montaditos use la opción 'Montaditos(50-100)'", MsgBoxStyle.Information, "Límite de registro alcanzado")
                Exit Sub
            End If
            'Rodeamos toda la manipulación del archivo con un try catch
            Try
                'igualamos la variable  al texto contenido en el  textbox del id
                a = Val(TBid.Text)
                'abrimos el fichero
                FileOpen(2, "Montaditos1", OpenMode.Random, OpenAccess.Write, , Len(mt))

                'igualamos las variables de la estructura del registro al contenido de los textbox
                mt.id = TBid.Text
                mt.nombre = TBNombre.Text
                mt.precio = Math.Round(CSng(TBPrecio.Text), 2)
                'Escribimos en el fichero
                FilePut(2, mt, a)

            Catch ex As Exception
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(2)
                ComboBox1_SelectedIndexChanged(sender, e)
            End Try
        ElseIf CBTipo.SelectedItem = "Montaditos(51-100)" Then
            'Rodeamos toda la manipulación del archivo con un try catch
            Try
                'igualamos la variable  al texto contenido en el  textbox del id
                a = Val(TBid.Text)
                'abrimos el fichero
                FileOpen(3, "Montaditos2", OpenMode.Random, OpenAccess.Write, , Len(mt))
                'igualamos las variables de la estructura del registro al contenido de los textbox
                mt.id = TBid.Text
                mt.nombre = TBNombre.Text
                mt.precio = Math.Round(CSng(TBPrecio.Text), 2)
                'Escribimos en el fichero
                FilePut(3, mt, a)

            Catch ex As Exception
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(3)
                ComboBox1_SelectedIndexChanged(sender, e)
            End Try
        ElseIf CBTipo.SelectedItem = "Bebidas" Then
            'Rodeamos toda la manipulación del archivo con un try catch
            Try
                'igualamos la variable  al texto contenido en el  textbox del id
                a = Val(TBid.Text)
                'abrimos el fichero
                FileOpen(4, "Bebidas", OpenMode.Random, OpenAccess.Write, , Len(mt))
                'igualamos las variables de la estructura del registro al contenido de los textbox
                mt.id = TBid.Text
                mt.nombre = TBNombre.Text
                mt.precio = Math.Round(CSng(TBPrecio.Text), 2)
                'Escribimos en el fichero
                FilePut(4, mt, a)

            Catch ex As Exception
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(4)
                ComboBox1_SelectedIndexChanged(sender, e)
            End Try
        ElseIf CBTipo.SelectedItem = "Aperitivos" Then
            'Rodeamos toda la manipulación del archivo con un try catch
            Try
                'igualamos la variable  al texto contenido en el  textbox del id
                a = Val(TBid.Text)
                'abrimos el fichero
                FileOpen(5, "Aperitivos", OpenMode.Random, OpenAccess.Write, , Len(mt))
                'igualamos las variables de la estructura del registro al contenido de los textbox
                mt.id = TBid.Text
                mt.nombre = TBNombre.Text
                mt.precio = Math.Round(CSng(TBPrecio.Text), 2)
                'Escribimos en el fichero
                FilePut(5, mt, a)

            Catch ex As Exception
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(5)
                ComboBox1_SelectedIndexChanged(sender, e)
            End Try
        ElseIf CBTipo.SelectedItem = "Helados" Then
            'Rodeamos toda la manipulación del archivo con un try catch
            Try
                'igualamos la variable  al texto contenido en el  textbox del id
                a = Val(TBid.Text)
                'abrimos el fichero
                FileOpen(6, "Helados", OpenMode.Random, OpenAccess.Write, , Len(mt))
                'igualamos las variables de la estructura del registro al contenido de los textbox
                mt.id = TBid.Text
                mt.nombre = TBNombre.Text
                mt.precio = Math.Round(CSng(TBPrecio.Text), 2)
                'Escribimos en el fichero
                FilePut(6, mt, a)

            Catch ex As Exception
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(6)
                ComboBox1_SelectedIndexChanged(sender, e)
            End Try
        End If



    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim a, valor As Integer
        Dim contador As Integer = 0
        'Tenemos que hacer todos los pasos por cada opcion del combobox
        If CBTipo.SelectedItem = "Montaditos (1-50)" Then
            Try
                'igualamos la variable a al texto contenido en el  textbox del id
                a = Val(TBid.Text)
                'abrimos el fichero
                FileOpen(2, "Montaditos1", OpenMode.Random, OpenAccess.ReadWrite, , Len(mt))
                'Comprobamos la cantidad de objetos que tenemos en el registro
                While Not EOF(2)
                    FileGet(2, mt, )
                    contador += 1
                End While
                'Si el id marcado supera al numero de objetos del registro la id por lo tanto no esta dada de alta en el registro por lo que no se puede borrar
                If TBid.Text > contador Then
                    MsgBox("No se puede eliminar un registro no existente", , "Fallo al eliminar")
                    FileClose(2)
                    Exit Sub
                End If
                'Se le pregunta al usuario si de verdad quiere borrar el objeto del registro y si dice que si se sustituye por valores por defecto ya que no se puede borrar la posicion del registro
                valor = MsgBox("¿Estas seguro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Eliminar")
                If valor = MsgBoxResult.Yes Then
                    mt.id = TBid.Text
                    mt.nombre = ""
                    mt.precio = 0
                    FilePut(2, mt, a)

                    MsgBox("Registro eliminado", MsgBoxStyle.Information, "Éxito al eliminar")

                End If
            Catch ex As Exception
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(2)
                ComboBox1_SelectedIndexChanged(sender, e)
            End Try


        ElseIf CBTipo.SelectedItem = "Montaditos(51-100)" Then
            Try
                'igualamos la variable a al texto contenido en el  textbox del id
                a = Val(TBid.Text)
                'abrimos el fichero
                FileOpen(3, "Montaditos2", OpenMode.Random, OpenAccess.ReadWrite, , Len(mt))
                'Comprobamos la cantidad de objetos que tenemos en el registro
                While Not EOF(3)
                    FileGet(3, mt, )
                    contador += 1
                End While
                'Si el id marcado supera al numero de objetos del registro la id por lo tanto no esta dada de alta en el registro por lo que no se puede borrar
                If TBid.Text > contador Then
                    MsgBox("No se puede eliminar un registro no existente", , "Fallo al eliminar")
                    FileClose(3)
                    Exit Sub
                End If
                'Se le pregunta al usuario si de verdad quiere borrar el objeto del registro y si dice que si se sustituye por valores por defecto ya que no se puede borrar la posicion del registro
                valor = MsgBox("¿Estas seguro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar")
                If valor = MsgBoxResult.Yes Then
                    mt.id = TBid.Text
                    mt.nombre = ""
                    mt.precio = 0
                    FilePut(3, mt, a)

                    MsgBox("Registro eliminado", MsgBoxStyle.Information, "Éxito al eliminar")

                End If
            Catch ex As Exception
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(3)
                ComboBox1_SelectedIndexChanged(sender, e)
            End Try

        ElseIf CBTipo.SelectedItem = "Bebidas" Then
            Try
                'igualamos la variable a al texto contenido en el  textbox del id
                a = Val(TBid.Text)
                'abrimos el fichero
                FileOpen(4, "Bebidas", OpenMode.Random, OpenAccess.ReadWrite, , Len(mt))
                'Comprobamos la cantidad de objetos que tenemos en el registro
                While Not EOF(4)
                    FileGet(4, mt, )
                    contador += 1
                End While
                'Si el id marcado supera al numero de objetos del registro la id por lo tanto no esta dada de alta en el registro por lo que no se puede borrar
                If TBid.Text > contador Then
                    MsgBox("No se puede eliminar un registro no existente: ", , "Fallo al eliminar")
                    FileClose(4)
                    Exit Sub
                End If
                'Se le pregunta al usuario si de verdad quiere borrar el objeto del registro y si dice que si se sustituye por valores por defecto ya que no se puede borrar la posicion del registro
                valor = MsgBox("¿Estas seguro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar")
                If valor = MsgBoxResult.Yes Then
                    mt.id = TBid.Text
                    mt.nombre = ""
                    mt.precio = 0
                    FilePut(4, mt, a)

                    MsgBox("Registro eliminado", MsgBoxStyle.Information, "Éxito al eliminar")

                End If
            Catch ex As Exception
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error" & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(4)
                ComboBox1_SelectedIndexChanged(sender, e)
            End Try

        ElseIf CBTipo.SelectedItem = "Aperitivos" Then
            Try
                'igualamos la variable a al texto contenido en el  textbox del id
                a = Val(TBid.Text)
                'abrimos el fichero
                FileOpen(5, "Aperitivos", OpenMode.Random, OpenAccess.ReadWrite, , Len(mt))
                'Comprobamos la cantidad de objetos que tenemos en el registro
                While Not EOF(5)
                    FileGet(5, mt, )
                    contador += 1
                End While
                'Si el id marcado supera al numero de objetos del registro la id por lo tanto no esta dada de alta en el registro por lo que no se puede borrar
                If TBid.Text > contador Then
                    MsgBox("No se puede eliminar un registro no existente", , "Fallo al eliminar")
                    FileClose(5)
                    Exit Sub
                End If
                'Se le pregunta al usuario si de verdad quiere borrar el objeto del registro y si dice que si se sustituye por valores por defecto ya que no se puede borrar la posicion del registro
                valor = MsgBox("¿Estas seguro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar")
                If valor = MsgBoxResult.Yes Then
                    mt.id = TBid.Text
                    mt.nombre = ""
                    mt.precio = 0
                    FilePut(5, mt, a)

                    MsgBox("Registro eliminado", MsgBoxStyle.Information, "Éxito al eliminar")

                End If
            Catch ex As Exception
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(5)
                ComboBox1_SelectedIndexChanged(sender, e)
            End Try

        ElseIf CBTipo.SelectedItem = "Helados" Then
            Try
                'igualamos la variable a al texto contenido en el  textbox del id
                a = Val(TBid.Text)
                'abrimos el fichero
                FileOpen(6, "Helados", OpenMode.Random, OpenAccess.ReadWrite, , Len(mt))
                'Comprobamos la cantidad de objetos que tenemos en el registro
                While Not EOF(6)
                    FileGet(6, mt, )
                    contador += 1
                End While
                'Si el id marcado supera al numero de objetos del registro la id por lo tanto no esta dada de alta en el registro por lo que no se puede borrar
                If TBid.Text > contador Then
                    MsgBox("No se puede eliminar un registro no existente", , "Fallo al eliminar")
                    FileClose(6)
                    Exit Sub
                End If
                'Se le pregunta al usuario si de verdad quiere borrar el objeto del registro y si dice que si se sustituye por valores por defecto ya que no se puede borrar la posicion del registro
                valor = MsgBox("¿Estas seguro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar")
                If valor = MsgBoxResult.Yes Then
                    mt.id = TBid.Text
                    mt.nombre = ""
                    mt.precio = 0
                    FilePut(6, mt, a)

                    MsgBox("Registro eliminado", MsgBoxStyle.Information, "Éxito al eliminar")

                End If
            Catch ex As Exception
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)

            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(6)
                ComboBox1_SelectedIndexChanged(sender, e)
            End Try

        End If


    End Sub

    Private Sub BActualizar_Click(sender As Object, e As EventArgs) Handles BActualizar.Click
        Dim a As Integer
        Dim contador As Integer = 0
        'Primero se comprueba que los textbox tengan datos y si estan vacios no se permite el guardar
        If TBNombre.Text = "" Or TBPrecio.Text = "" Then
            MsgBox("Introduzca datos antes de guardar", MsgBoxStyle.Information, "Campos vacios")
            Exit Sub
        End If
        'Tenemos que hacer todos los pasos por cada opcion del combobox
        If CBTipo.SelectedItem = "Montaditos (1-50)" Then
            'Rodeamos toda la manipulación del archivo con un try catch
            Try
                'igualamos la variable  al texto contenido en el  textbox del id
                a = Val(TBid.Text)
                'abrimos el fichero
                FileOpen(2, "Montaditos1", OpenMode.Random, OpenAccess.ReadWrite, , Len(mt))
                'Comprobamos la cantidad de objetos que tenemos en el registro
                While Not EOF(2)
                    FileGet(2, mt, )
                    contador += 1
                End While
                'Si el id marcado supera al numero de objetos del registro la id por lo tanto no esta dada de alta en el registro por lo que no se puede modificar
                If TBid.Text > contador Then
                    MsgBox("No se puede modificar un producto no existente", , "Fallo al actualizar")
                    FileClose(2)
                    Exit Sub
                End If
                'igualamos las variables de la estructura del registro al contenido de los textbox
                mt.id = TBid.Text
                mt.nombre = TBNombre.Text
                mt.precio = Math.Round(CSng(TBPrecio.Text), 2)
                'Escribimos en el fichero
                FilePut(2, mt, a)

                MsgBox("Campo modificado correctamente",, "Campo modificado")

            Catch ex As Exception
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(2)
                ComboBox1_SelectedIndexChanged(sender, e)
            End Try
        ElseIf CBTipo.SelectedItem = "Montaditos(51-100)" Then
            'Rodeamos toda la manipulación del archivo con un try catch
            Try
                'igualamos la variable  al texto contenido en el  textbox del id
                a = Val(TBid.Text)
                'abrimos el fichero
                FileOpen(3, "Montaditos2", OpenMode.Random, OpenAccess.ReadWrite, , Len(mt))
                'Comprobamos la cantidad de objetos que tenemos en el registro
                While Not EOF(3)
                    FileGet(3, mt, )
                    contador += 1
                End While
                'Si el id marcado supera al numero de objetos del registro la id por lo tanto no esta dada de alta en el registro por lo que no se puede modificar
                If TBid.Text > contador Then
                    MsgBox("No se puede modificar un producto no existente", , "Fallo al actualizar")
                    FileClose(3)
                    Exit Sub
                End If
                'igualamos las variables de la estructura del registro al contenido de los textbox
                mt.id = TBid.Text
                mt.nombre = TBNombre.Text
                mt.precio = Math.Round(CSng(TBPrecio.Text), 2)
                'Escribimos en el fichero
                FilePut(3, mt, a)

                MsgBox("Campo modificado correctamente",, "Campo modificado")
            Catch ex As Exception
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(3)
                ComboBox1_SelectedIndexChanged(sender, e)
            End Try
        ElseIf CBTipo.SelectedItem = "Bebidas" Then
            'Rodeamos toda la manipulación del archivo con un try catch
            Try
                'igualamos la variable  al texto contenido en el  textbox del id
                a = Val(TBid.Text)
                'abrimos el fichero
                FileOpen(4, "Bebidas", OpenMode.Random, OpenAccess.ReadWrite, , Len(mt))
                'Comprobamos la cantidad de objetos que tenemos en el registro
                While Not EOF(4)
                    FileGet(4, mt, )
                    contador += 1
                End While
                'Si el id marcado supera al numero de objetos del registro la id por lo tanto no esta dada de alta en el registro por lo que no se puede modificar
                If TBid.Text > contador Then
                    MsgBox("No se puede modificar un producto no existente", , "Fallo al actualizar")
                    FileClose(4)
                    Exit Sub
                End If
                'igualamos las variables de la estructura del registro al contenido de los textbox
                mt.id = TBid.Text
                mt.nombre = TBNombre.Text
                mt.precio = Math.Round(CSng(TBPrecio.Text), 2)
                'Escribimos en el fichero
                FilePut(4, mt, a)

                MsgBox("Campo modificado correctamente",, "Campo modificado")
            Catch ex As Exception
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(4)
                ComboBox1_SelectedIndexChanged(sender, e)
            End Try
        ElseIf CBTipo.SelectedItem = "Aperitivos" Then
            'Rodeamos toda la manipulación del archivo con un try catch
            Try
                'igualamos la variable  al texto contenido en el  textbox del id
                a = Val(TBid.Text)
                'abrimos el fichero
                FileOpen(5, "Aperitivos", OpenMode.Random, OpenAccess.ReadWrite, , Len(mt))
                'Comprobamos la cantidad de objetos que tenemos en el registro
                While Not EOF(5)
                    FileGet(5, mt, )
                    contador += 1
                End While
                'Si el id marcado supera al numero de objetos del registro la id por lo tanto no esta dada de alta en el registro por lo que no se puede modificar
                If TBid.Text > contador Then
                    MsgBox("No se puede modificar un producto no existente", , "Fallo al actualizar")
                    FileClose(5)
                    Exit Sub
                End If
                'igualamos las variables de la estructura del registro al contenido de los textbox
                mt.id = TBid.Text
                mt.nombre = TBNombre.Text
                mt.precio = Math.Round(CSng(TBPrecio.Text), 2)
                'Escribimos en el fichero
                FilePut(5, mt, a)

                MsgBox("Campo modificado correctamente",, "Campo modificado")
            Catch ex As Exception
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(5)
                ComboBox1_SelectedIndexChanged(sender, e)
            End Try
        ElseIf CBTipo.SelectedItem = "Helados" Then
            'Rodeamos toda la manipulación del archivo con un try catch
            Try
                'igualamos la variable  al texto contenido en el  textbox del id
                a = Val(TBid.Text)
                'abrimos el fichero
                FileOpen(6, "Helados", OpenMode.Random, OpenAccess.ReadWrite, , Len(mt))
                'Comprobamos la cantidad de objetos que tenemos en el registro
                While Not EOF(6)
                    FileGet(6, mt, )
                    contador += 1
                End While
                'Si el id marcado supera al numero de objetos del registro la id por lo tanto no esta dada de alta en el registro por lo que no se puede modificar
                If TBid.Text > contador Then
                    MsgBox("No se puede modificar un producto no existente", , "Fallo al actualizar")
                    FileClose(6)
                    Exit Sub
                End If
                'igualamos las variables de la estructura del registro al contenido de los textbox
                mt.id = TBid.Text
                mt.nombre = TBNombre.Text
                mt.precio = Math.Round(CSng(TBPrecio.Text), 2)
                'Escribimos en el fichero
                FilePut(6, mt, a)

                MsgBox("Campo modificado correctamente",, "Campo modificado")
            Catch ex As Exception
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Critical, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(6)
                ComboBox1_SelectedIndexChanged(sender, e)
            End Try
        End If
    End Sub

    Private Sub TBbusqueda_GotFocus(sender As Object, e As EventArgs) Handles TBbusqueda.GotFocus
        TBbusqueda.Clear()
    End Sub

    Private Sub BNuevo_Click(sender As Object, e As EventArgs) Handles BNuevo.Click
        Dim contador As Integer = 0
        TBNombre.Clear()
        TBPrecio.Clear()
        'Tenemos que hacer todos los pasos por cada opcion del combobox
        If CBTipo.SelectedItem = "Montaditos (1-50)" Then
            'Rodeamos toda la manipulación del archivo con un try catch
            Try
                'abrimos el fichero
                FileOpen(2, "Montaditos1", OpenMode.Random, OpenAccess.Read, , Len(mt))
                'Comprobamos la cantidad de objetos que tenemos en el registro
                While Not EOF(2)
                    FileGet(2, mt, )
                    contador += 1
                End While
                'suma 1 a la cantidad de objetos y con eso se obtiene la id para un nuevo producto
                TBid.Text = contador + 1
            Catch
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(2)
            End Try
        ElseIf CBTipo.SelectedItem = "Montaditos(51-100)" Then
            'Rodeamos toda la manipulación del archivo con un try catch
            Try
                'abrimos el fichero
                FileOpen(3, "Montaditos2", OpenMode.Random, OpenAccess.Read, , Len(mt))
                'Comprobamos la cantidad de objetos que tenemos en el registro
                While Not EOF(3)
                    FileGet(3, mt, )
                    contador += 1
                End While
                'suma 1 a la cantidad de objetos y con eso se obtiene la id para un nuevo producto
                TBid.Text = contador + 1
            Catch
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(3)
            End Try
        ElseIf CBTipo.SelectedItem = "Bebidas" Then
            'Rodeamos toda la manipulación del archivo con un try catch
            Try
                'abrimos el fichero
                FileOpen(4, "Bebidas", OpenMode.Random, OpenAccess.Read, , Len(mt))
                'Comprobamos la cantidad de objetos que tenemos en el registro
                While Not EOF(4)
                    FileGet(4, mt, )
                    contador += 1
                End While
                'suma 1 a la cantidad de objetos y con eso se obtiene la id para un nuevo producto
                TBid.Text = contador + 1
            Catch
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(4)
            End Try
        ElseIf CBTipo.SelectedItem = "Aperitivos" Then
            'Rodeamos toda la manipulación del archivo con un try catch
            Try
                'abrimos el fichero
                FileOpen(5, "Aperitivos", OpenMode.Random, OpenAccess.Read, , Len(mt))
                'Comprobamos la cantidad de objetos que tenemos en el registro
                While Not EOF(5)
                    FileGet(5, mt, )
                    contador += 1
                End While
                'suma 1 a la cantidad de objetos y con eso se obtiene la id para un nuevo producto
                TBid.Text = contador + 1
            Catch
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                Write(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(5)
            End Try
        ElseIf CBTipo.SelectedItem = "Helados" Then
            'Rodeamos toda la manipulación del archivo con un try catch
            Try
                'abrimos el fichero
                FileOpen(6, "Helados", OpenMode.Random, OpenAccess.Read, , Len(mt))
                'Comprobamos la cantidad de objetos que tenemos en el registro
                While Not EOF(6)
                    FileGet(6, mt, )
                    contador += 1
                End While
                'suma 1 a la cantidad de objetos y con eso se obtiene la id para un nuevo producto
                TBid.Text = contador + 1
            Catch
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(6)
            End Try
        End If
    End Sub

    Private Sub BBusqueda_Click(sender As Object, e As EventArgs) Handles BBusqueda.Click
        'Tenemos que hacer todos los pasos por cada opcion del combobox
        If CBTipo.SelectedItem = "Montaditos (1-50)" Then
            'abrimos el fichero
            FileOpen(2, "Montaditos1", OpenMode.Random, OpenAccess.Read, , Len(mt))
            'Rodeamos toda la manipulación del archivo con un try catch
            Try
                'Se coloca en la posicion del fichero que indica el texto del textbox
                Seek(2, TBbusqueda.Text)
                'Obtiene los datos del objeto que se encuentra en la posición donde se coloco el puntero y si existe lo escribe en los textbox correspondientes
                FileGet(2, mt, )
                If mt.id <> 0 Then
                    TBid.Text = mt.id
                    TBNombre.Text = Trim(mt.nombre)
                    TBPrecio.Text = mt.precio
                End If
            Catch ex As Exception
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(2)
            End Try
        ElseIf CBTipo.SelectedItem = "Montaditos(51-100)" Then
            'abrimos el fichero
            FileOpen(3, "Montaditos2", OpenMode.Random, OpenAccess.Read, , Len(mt))
            'Rodeamos toda la manipulación del archivo con un try catch
            Try
                'Se coloca en la posicion del fichero que indica el texto del textbox
                Seek(3, TBbusqueda.Text)
                'Obtiene los datos del objeto que se encuentra en la posición donde se coloco el puntero y si existe lo escribe en los textbox correspondientes
                FileGet(3, mt, )
                If mt.id <> 0 Then
                    TBid.Text = mt.id
                    TBNombre.Text = Trim(mt.nombre)
                    TBPrecio.Text = mt.precio
                End If
            Catch ex As Exception
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(3)
            End Try
        ElseIf CBTipo.SelectedItem = "Bebidas" Then
            'abrimos el fichero
            FileOpen(4, "Bebidas", OpenMode.Random, OpenAccess.Read, , Len(mt))
            'Rodeamos toda la manipulación del archivo con un try catch
            Try
                'Se coloca en la posicion del fichero que indica el texto del textbox
                Seek(4, TBbusqueda.Text)
                'Obtiene los datos del objeto que se encuentra en la posición donde se coloco el puntero y si existe lo escribe en los textbox correspondientes
                FileGet(4, mt, )
                If mt.id <> 0 Then
                    TBid.Text = mt.id
                    TBNombre.Text = Trim(mt.nombre)
                    TBPrecio.Text = mt.precio
                End If
            Catch ex As Exception
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(4)
            End Try
        ElseIf CBTipo.SelectedItem = "Aperitivos" Then
            'abrimos el fichero
            FileOpen(5, "Aperitivos", OpenMode.Random, OpenAccess.Read, , Len(mt))
            'Rodeamos toda la manipulación del archivo con un try catch
            Try
                'Se coloca en la posicion del fichero que indica el texto del textbox
                Seek(5, TBbusqueda.Text)
                'Obtiene los datos del objeto que se encuentra en la posición donde se coloco el puntero y si existe lo escribe en los textbox correspondientes
                FileGet(5, mt, )
                If mt.id <> 0 Then
                    TBid.Text = mt.id
                    TBNombre.Text = Trim(mt.nombre)
                    TBPrecio.Text = mt.precio
                End If
            Catch ex As Exception
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(5)
            End Try
        ElseIf CBTipo.SelectedItem = "Helados" Then
            'abrimos el fichero
            FileOpen(6, "Helados", OpenMode.Random, OpenAccess.Read, , Len(mt))
            'Rodeamos toda la manipulación del archivo con un try catch
            Try
                'Se coloca en la posicion del fichero que indica el texto del textbox
                Seek(6, TBbusqueda.Text)
                'Obtiene los datos del objeto que se encuentra en la posición donde se coloco el puntero y si existe lo escribe en los textbox correspondientes
                FileGet(6, mt, )
                If mt.id <> 0 Then
                    TBid.Text = mt.id
                    TBNombre.Text = Trim(mt.nombre)
                    TBPrecio.Text = mt.precio
                End If
            Catch ex As Exception
                'En caso de que de error de algún tipo saltara un MSGBox y se guardara el error en un fichero de errores
                FileOpen(7, "Errores", OpenMode.Append)
                WriteLine(7, Err.Description & Now)
                MsgBox("Se ha encontrdo el siguiente error: " & Err.Description, MsgBoxStyle.Information, "Error")
                FileClose(7)
            Finally
                ' y por ultimo ocurra fallo o no cerramos el fichero
                FileClose(6)
            End Try
        End If
    End Sub
    'Cierra la ventana
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click


        Me.Close()
        Me.Dispose()
    End Sub
    'Validacion del textbox nombre
    Private Sub TBNombre_TextChanged(sender As Object, e As EventArgs) Handles TBNombre.TextChanged
        Dim cadena() As Char = TBNombre.Text.ToCharArray
        For i As Integer = 0 To TBNombre.Text.Length - 1
            If IsNumeric(cadena(i)) Then
                TBNombre.Clear()
            End If
        Next

    End Sub
    'Validacion del textbox precio
    Private Sub TBPrecio_TextChanged(sender As Object, e As EventArgs) Handles TBPrecio.TextChanged
        Dim noV() As Char = TBPrecio.Text.ToCharArray
        For i As Integer = 0 To noV.Length - 1

            If noV(i) = "-" Or noV(i) = "+" Then
                TBPrecio.Clear()
                Exit Sub
            End If

        Next
        If Not IsNumeric(TBPrecio.Text) Then
            TBPrecio.Clear()
        End If
        If TBPrecio.Text = "" Then
            Exit Sub

        ElseIf TBPrecio.Text > 50 Then
            TBPrecio.Clear()
        End If
    End Sub
    'Validacion del textbox busqueda
    Private Sub TBbusqueda_TextChanged(sender As Object, e As EventArgs) Handles TBbusqueda.TextChanged
        Dim noV() As Char = TBbusqueda.Text.ToCharArray
        For i As Integer = 0 To noV.Length - 1

            If noV(i) = "-" Or noV(i) = "+" Or noV(i) = "," Or noV(i) = "." Then
                TBbusqueda.Clear()
                Exit Sub
            End If

        Next
        If TBbusqueda.Text = "<--Introduzca id para búsqueda-->" Then
            Exit Sub
        ElseIf Not IsNumeric(TBbusqueda.Text) Then
            TBbusqueda.Clear()
        End If
    End Sub
    'Se pone que por defecto al cargar el formulario salga el primer objeto
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBTipo.SelectedItem = CBTipo.Items.Item(0)
    End Sub
    'Se indica cuando queremos que los botones Guradar, actualizar y eliminar se puedan usar y cuando no 
    Private Sub TBid_TextChanged(sender As Object, e As EventArgs) Handles TBid.TextChanged
        If TBid.Text = "" Then
            BGuardar.Enabled = False
            BActualizar.Enabled = False
            BEliminar.Enabled = False
        Else
            BGuardar.Enabled = True
            BActualizar.Enabled = True
            BEliminar.Enabled = True
        End If
    End Sub
End Class