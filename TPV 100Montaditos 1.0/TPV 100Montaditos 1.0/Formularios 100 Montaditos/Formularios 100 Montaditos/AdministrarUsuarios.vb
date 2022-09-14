
Imports BC_Montaditos

    Public Class AdministrarUsuarios
        Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Close()
        Me.Dispose()
    End Sub

        Private Sub NuevoUsuarioTSMI_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioTSMI.Click
            'Borra los campos y añade una id
            TBId.Text = LBUsuarios.Items.Count + 1
            TBUsuario.Clear()
            TBNombre.Clear()
            TBApellido.Clear()
            TBContraseña.Clear()
            TBDNI.Clear()
            TBTelefono.Clear()
            TBCorreo.Clear()
            CBRol.Text = ""

        End Sub

        Private Sub GuardarTSMI_Click(sender As Object, e As EventArgs) Handles GuardarTSMI.Click
        'guardar un nuevo registro
        Dim a As Integer = 0
        TBApellido.Text = Trim(TBApellido.Text)
        TBNombre.Text = Trim(TBNombre.Text)
        TBId.Text = Trim(TBId.Text)
        TBUsuario.Text = Trim(TBUsuario.Text)
        TBContraseña.Text = Trim(TBContraseña.Text)
        TBTelefono.Text = Trim(TBTelefono.Text)
        TBDNI.Text = Trim(TBDNI.Text)
        TBCorreo.Text = Trim(TBCorreo.Text)
        CBRol.Text = Trim(CBRol.Text)
        FileOpen(1, "usuarios", OpenMode.Random, OpenAccess.Write,, Len(user))

        'comprueba de que no haya ningun campo vacio
        If (TBId.Text = "" Or TBUsuario.Text = "" Or TBNombre.Text = "" Or TBApellido.Text = "" Or
            TBContraseña.Text = "" Or TBDNI.Text = "" Or CBRol.Text = "") Then
            MsgBox("Faltan campos por rellenar, revise los campos", MsgBoxStyle.Information,
                   "Faltan campos")
        ElseIf (user.id = 1) Then
            MsgBox("No se puede modificar el usuario administrador", MsgBoxStyle.Information,
               "No se puede borrar")

        Else
            'Guarda los valores
            Try
                a = Val(TBId.Text)
                user.id = TBId.Text
                user.usuario = TBUsuario.Text
                user.nombre = TBNombre.Text
                user.apellido = TBApellido.Text
                user.contrasena = TBContraseña.Text
                user.dni = TBDNI.Text
                user.telefono = TBTelefono.Text
                user.correo = TBCorreo.Text
                user.rol = CBRol.Text
                FilePut(1, user, a)
            Catch ex As Exception
                MsgBox("Operación Incorrecta" & Err.Description)
            End Try
        End If
        FileClose(1)
    End Sub

    Private Sub TBUsuario_TextChanged(sender As Object, e As EventArgs) Handles TBUsuario.TextChanged
        'valida el campo en cuando se cambie el foco
        Dim CV As New ValCarac
        Dim letras As String = TBUsuario.Text
        Dim comp As Boolean
        comp = CV.ValCarac(letras)
        If (comp = False) Then
            MsgBox("Caracter no válido", MsgBoxStyle.Information, "Caracter no válido")
            TBUsuario.Clear()
            TBUsuario.Focus()
        End If
    End Sub
    Private Sub TBNombre_TextChanged(sender As Object, e As EventArgs) Handles TBNombre.TextChanged
        'valida el campo en cuando se cambie el foco
        Dim CV As New ValCarac
        Dim letras As String = TBNombre.Text
        Dim comp As Boolean
        comp = CV.ValCarac(letras)
        If (comp = False) Then
            MsgBox("Caracter no válido", MsgBoxStyle.Information, "Caracter no válido")
            TBNombre.Clear()
            TBNombre.Focus()
        End If
    End Sub


    Private Sub TBApellido_TextChanged(sender As Object, e As EventArgs) Handles TBApellido.TextChanged
        'valida el campo en cuando se cambie el foco
        Dim CV As New ValCarac
        Dim letras As String = TBApellido.Text
        Dim comp As Boolean
        comp = CV.ValCarac(letras)
        If (comp = False) Then
            MsgBox("Caracter no válido", MsgBoxStyle.Information, "Caracter no válido")
            TBApellido.Clear()
            TBApellido.Focus()
        End If
    End Sub

    Private Sub TBContraseña_TextChanged_1(sender As Object, e As EventArgs) Handles TBContraseña.TextChanged
        'valida el campo en cuando se cambie el foco
        Dim CV As New ValCaracNum
        Dim letras As String = TBContraseña.Text
        Dim comp As Boolean
        comp = CV.ValCaracNum(letras)
        If (comp = False) Then
            MsgBox("Caracter no válido", MsgBoxStyle.Information, "Caracter no válido")
            TBContraseña.Clear()
            TBContraseña.Focus()
        End If
    End Sub

    Private Sub TBDNI_Validating(sender As Object, e As EventArgs) Handles TBDNI.Leave
            'valida el campo en cuando se cambie el foco
            Dim CV As New ValDNI
            Dim dni As String = TBDNI.Text
            Dim comp As Boolean
        If (dni.Length <> 9) Then
            MsgBox("DNI incorrecto", MsgBoxStyle.Information, "DNI incorrecto")
            TBDNI.Clear()

        Else
            Try
                comp = CV.ValDNI(dni)
            Catch
                MsgBox("DNI incorrecto", MsgBoxStyle.Information, "DNI incorrecto")
                TBDNI.Clear()

            End Try
            If (comp = False) Then
                    MsgBox("DNI incorrecto", MsgBoxStyle.Information, "DNI incorrecto")
                    TBDNI.Clear()

                End If
            End If

        End Sub

        Private Sub TBTelefono_TextChanged(sender As Object, e As EventArgs) Handles TBTelefono.TextChanged
            'valida el campo en cuando se cambie el foco
            Dim CV As New ValNumero
            Dim num As String = TBTelefono.Text
        Dim comp As Boolean
        Dim c As Char() = num.ToCharArray
        comp = CV.numero(num)
        For i As Integer = 0 To c.Length - 1
            If c(i) = "," Or c(i) = "-" Or c(i) = "+" Or c(i) = "." Then
                MsgBox("Caracter no válido", MsgBoxStyle.Information, "Caracter no válido")
                TBTelefono.Clear()
                TBTelefono.Focus()
                Exit Sub
            End If
        Next
        If (comp = False) Then
            MsgBox("Caracter no válido", MsgBoxStyle.Information, "Caracter no válido")
            TBTelefono.Clear()
            TBTelefono.Focus()
        End If
        End Sub

        Private Sub TBCorreo_Leave(sender As Object, e As EventArgs) Handles TBCorreo.Leave
            'valida el campo en cuando se cambie el foco
            Dim CV As New ValCorreo
            Dim letras As String = TBCorreo.Text
            Dim comp As Boolean
            If (letras = "") Then
            Else
                comp = CV.ValCorreo(letras)
                If (comp = False) Then
                MsgBox("Correo electrónico no válido", MsgBoxStyle.Information, "Correo no valido")
                TBCorreo.Clear()
                    TBCorreo.Focus()
                End If
            End If
        End Sub

        Private Sub ActualizarTSMI_Click(sender As Object, e As EventArgs) Handles ActualizarTSMI.Click
        'Actualiza la informacion del listbox de los ususarios
        LBID.Items.Clear()
        LBRol.Items.Clear()
        LBNombre.Items.Clear()

        LBUsuarios.Items.Clear()
            FileOpen(1, "usuarios", OpenMode.Random, OpenAccess.Read, , Len(user))
            While Not EOF(1)
                FileGet(1, user, )
            LBID.Items.Add(user.id)
            LBUsuarios.Items.Add(user.usuario)
            LBNombre.Items.Add(user.nombre)
            LBRol.Items.Add(user.rol)
            End While
            FileClose(1)
        End Sub
        Private Sub ModificarTSMI_Click(sender As Object, e As EventArgs) Handles ModificarTSMI.Click
        'modifica un usuario
        Dim a As Integer
        TBApellido.Text = Trim(TBApellido.Text)
        TBNombre.Text = Trim(TBNombre.Text)
        TBId.Text = Trim(TBId.Text)
        TBUsuario.Text = Trim(TBUsuario.Text)
        TBContraseña.Text = Trim(TBContraseña.Text)
        TBTelefono.Text = Trim(TBTelefono.Text)
        TBDNI.Text = Trim(TBDNI.Text)
        TBCorreo.Text = Trim(TBCorreo.Text)
        CBRol.Text = Trim(CBRol.Text)
        'no permite modificar el usuario con id 1, ya que los programadores han decidido que el usuario
        'con esta id sea el administrador
        If (TBId.Text = "" Or TBUsuario.Text = "" Or TBNombre.Text = "" Or TBApellido.Text = "" Or
           TBContraseña.Text = "" Or TBDNI.Text = "" Or CBRol.Text = "") Then
            MsgBox("Faltan campos por rellenar, revise los campos", MsgBoxStyle.Information,
               "Faltan campos")

        ElseIf (TBId.Text = 1) Then
            MsgBox("No se puede modificar el usuario administrador", MsgBoxStyle.Information,
               "No se puede modificar")
        Else


            Try
                a = Val(TBId.Text)
                FileOpen(1, "usuarios", OpenMode.Random, OpenAccess.Write, , Len(user))
                user.id = TBId.Text
                user.usuario = TBUsuario.Text
                user.nombre = TBNombre.Text
                user.apellido = TBApellido.Text
                user.contrasena = TBContraseña.Text
                user.dni = TBDNI.Text
                user.telefono = TBTelefono.Text
                user.correo = TBCorreo.Text
                user.rol = CBRol.Text
                FilePut(1, user, a)
                MsgBox("Campo modificado correctamente",, "Usuario modificado")
            Catch ex As Exception
                MsgBox(Err.Description)
            End Try
        End If
        FileClose(1)

    End Sub

        Private Sub BorrarTSMI_Click(sender As Object, e As EventArgs) Handles BorrarTSMI.Click
        'Borra un usuario, deja el hueco creado en la tabla, ya que al usar ficheros "borramos" un 
        'usuario cambiando todos los valores a nada
        Dim a, valor As Integer
        Dim contador As Integer = 0
        Try
            If TBId.Text = "" Then
                MsgBox("Introduzca id para eliminar un registro", , "Fallo al eliminar")
                FileClose(1)
                Exit Sub
            End If
            a = Val(TBId.Text)
            FileOpen(1, "usuarios", OpenMode.Random, OpenAccess.ReadWrite, , Len(user))
            While Not EOF(1)
                FileGet(1, user, )
                contador += 1
            End While
            If TBId.Text > contador Then
                MsgBox("No se puede eliminar un registro no existente", , "Fallo al eliminar")
                FileClose(1)
                Exit Sub
            End If
        Catch
        Finally
            FileClose(1)
        End Try

        Try
            a = Val(TBId.Text)
            FileOpen(1, "usuarios", OpenMode.Random, OpenAccess.ReadWrite, , Len(user))
            'no permite borrar el usuario con id 1, ya que los programadores han decidido que el usuario
            'con esta id sea el administrador
            If (TBId.Text = 1) Then
                MsgBox("No se puede borrar el usuario administrador", MsgBoxStyle.Information,
                   "No se puede borrar")
            Else
                valor = MsgBox("¿Estas seguro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Borrar usuario")
                If valor = MsgBoxResult.Yes Then

                    user.id = TBId.Text
                    user.usuario = ""
                    user.nombre = ""
                    user.apellido = ""
                    user.contrasena = ""
                    user.dni = ""
                    user.telefono = ""
                    user.correo = ""
                    user.rol = ""
                    FilePut(1, user, a)
                    NuevoUsuarioTSMI_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            MsgBox("Operacion Incorrecta" & Err.Description)
        Finally
            FileClose(1)
        End Try


    End Sub

        Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        'Busca un usuario que coincida con la id introducida
        Dim a As String = TBBuscar.Text
        FileOpen(1, "usuarios", OpenMode.Random, OpenAccess.Read,, Len(user))
        Seek(1, Val(a))

        Try
            FileGet(1, user, )
            If user.id <> 0 Then
                TBId.Text = Trim(user.id)
                TBUsuario.Text = Trim(user.usuario)
                TBNombre.Text = Trim(user.nombre)
                TBApellido.Text = Trim(user.apellido)
                TBContraseña.Text = Trim(user.contrasena)
                TBDNI.Text = Trim(user.dni)
                TBTelefono.Text = Trim(user.telefono)
                TBCorreo.Text = Trim(user.correo)
                CBRol.SelectedItem = Trim(user.rol)

            End If

        Catch ex As Exception
            MsgBox("No existe el registro", MsgBoxStyle.Information, "Registro inexistente")
            TBBuscar.Clear()
        Finally
            FileClose(1)
        End Try

    End Sub

        Private Sub TBBuscar_TextChanged(sender As Object, e As EventArgs) Handles TBBuscar.TextChanged
            ' valida los caracteres introducios en este campo
            Dim CV As New ValNumero
        Dim num As String = TBBuscar.Text
        Dim c As Char() = TBBuscar.Text
            Dim comp As Boolean
        comp = CV.numero(num)
        For i As Integer = 0 To c.Length - 1
            If c(i) = "," Or c(i) = "-" Or c(i) = "+" Or c(i) = "." Then
                MsgBox("Caracter no válido", MsgBoxStyle.Information, "Caracter no válido")
                TBBuscar.Clear()
                TBBuscar.Focus()
                Exit Sub
            End If
        Next
        If (comp = False) Then
            MsgBox("Caracter no valido", MsgBoxStyle.Information, "Caracter no valido")
            TBBuscar.Clear()

        End If
    End Sub

        Private Sub AdministrarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cuando abre este formulario, carga en el listbox los usuarios dadode alta
        Try
            FileOpen(1, "usuarios", OpenMode.Random, OpenAccess.Read,, Len(user))
            While Not EOF(1)
                FileGet(1, user, )
                LBID.Items.Add(user.id)
                LBUsuarios.Items.Add(user.usuario)
                LBNombre.Items.Add(user.nombre)
                LBRol.Items.Add(user.rol)

            End While
        Catch ex As Exception
        Finally
            FileClose(1)
        End Try


    End Sub


End Class
