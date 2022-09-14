Imports BC_Montaditos
Public Class Inicio
    <VBFixedString(12)> Dim usuario As String
    <VBFixedString(15)> Dim contraseña As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        'Muestra el Panel de iniciar sesion cuando el usuario haga click en cualquier parte del formulario
        PinicioSesion.Show()
    End Sub

    Private Sub BiniciarSesion_Click(sender As Object, e As EventArgs) Handles BiniciarSesion.Click
        'se abre el fichero
        FileOpen(1, "usuarios", OpenMode.Random, OpenAccess.Read,, Len(user))
        Dim valido As Boolean = False
        'si los textbox estan vacios da los datos de inicio de sesión como incorrectos
        If TBusuario.Text = "" Or TBcontraseña.Text = "" Then
            MsgBox("Usuario o contraseña incorrecta", MsgBoxStyle.Information, "Sesión no iniciada")
            FileClose(1)
            Exit Sub
        End If
        'Se Obtienen los datos de usuario y contraseña del fichero de usuarios con los escritos en los textbox y si coinciden permite el inicio de sesión
        While Not EOF(1)
            FileGet(1, user, )
            usuario = user.usuario
            contraseña = user.contrasena
            usuario = usuario.Replace(" ", String.Empty)
            contraseña = contraseña.Replace(" ", String.Empty)
            If (TBusuario.Text = usuario And TBcontraseña.Text = contraseña) Then
                valido = True
                FileOpen(8, "accesos", OpenMode.Append)
                WriteLine(8, "El usuario " & usuario & " con contraseña " & contraseña & " Ha iniciado sesión en la fecha " & Now)
                FileClose(8)
                'comprueba si el usuario que se ha logeado es el administrador o no
                If (user.rol.Replace(" ", String.Empty) = "Admin" Or user.rol.Replace(" ", String.Empty) = "AdminP") Then
                    Usuarios.adminaccess = True
                    Caja.AdministarToolStripMenuItem.Visible = True
                Else
                    Caja.AdministarToolStripMenuItem.Visible = False
                    adminaccess = False
                End If
                Exit While

            End If

        End While

        If (valido = True) Then
            TBcontraseña.Clear()
            TBusuario.Clear()
            Me.Hide()
            Caja.Show()

        Else
            MsgBox("Usuario o contraseña incorrecta", MsgBoxStyle.Information, "Sesión no iniciada")
            TBusuario.Clear()
            TBcontraseña.Clear()
            TBusuario.Focus()
        End If
        'Se cierra el fichero
        FileClose(1)
    End Sub
    'Validacion del textbox TBNusuario
    Private Sub TBusuario_TextChanged(sender As Object, e As EventArgs) Handles TBusuario.TextChanged
        Dim CV As New ValCarac
        Dim letras As String = TBusuario.Text
        Dim comp As Boolean
        comp = CV.ValCarac(letras)
        If (comp = False) Then
            MsgBox("Caracter no válido", MsgBoxStyle.Information, "Caracter no válido")
            TBusuario.Clear()
            TBusuario.Focus()
        End If
    End Sub
    'Validacion del textbox TBcontraseña
    Private Sub TBcontraseña_TextChanged(sender As Object, e As EventArgs) Handles TBcontraseña.TextChanged
        Dim CV As New ValCaracNum
        Dim letras As String = TBcontraseña.Text
        Dim comp As Boolean
        comp = CV.ValCaracNum(letras)
        If (comp = False) Then
            MsgBox("Caracter no válido", MsgBoxStyle.Information, "Caracter no válido")
            TBcontraseña.Clear()
            TBcontraseña.Focus()
        End If
    End Sub

   
End Class