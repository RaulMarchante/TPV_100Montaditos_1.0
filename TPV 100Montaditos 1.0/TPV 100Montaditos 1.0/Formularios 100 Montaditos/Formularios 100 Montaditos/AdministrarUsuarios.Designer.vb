<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministrarUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdministrarUsuarios))
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.LRol2 = New System.Windows.Forms.Label()
        Me.LNombre2 = New System.Windows.Forms.Label()
        Me.LUsuario2 = New System.Windows.Forms.Label()
        Me.LID2 = New System.Windows.Forms.Label()
        Me.LEjemploCorreo = New System.Windows.Forms.Label()
        Me.LEjemploContraseña = New System.Windows.Forms.Label()
        Me.TBUsuario = New System.Windows.Forms.TextBox()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.TBId = New System.Windows.Forms.TextBox()
        Me.LID = New System.Windows.Forms.Label()
        Me.CBRol = New System.Windows.Forms.ComboBox()
        Me.LRol = New System.Windows.Forms.Label()
        Me.LBUsuarios = New System.Windows.Forms.ListBox()
        Me.TBCorreo = New System.Windows.Forms.TextBox()
        Me.TBTelefono = New System.Windows.Forms.TextBox()
        Me.TBDNI = New System.Windows.Forms.TextBox()
        Me.TBContraseña = New System.Windows.Forms.TextBox()
        Me.TBApellido = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.LCorreo = New System.Windows.Forms.Label()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.LDNI = New System.Windows.Forms.Label()
        Me.LContraseña = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoUsuarioTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GuardarTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BorrarTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBRol = New System.Windows.Forms.ListBox()
        Me.LBNombre = New System.Windows.Forms.ListBox()
        Me.LBID = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBBuscar
        '
        Me.TBBuscar.Location = New System.Drawing.Point(589, 279)
        Me.TBBuscar.MaxLength = 2
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(52, 20)
        Me.TBBuscar.TabIndex = 42
        '
        'BBuscar
        '
        Me.BBuscar.Location = New System.Drawing.Point(495, 279)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BBuscar.TabIndex = 43
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'LRol2
        '
        Me.LRol2.AutoSize = True
        Me.LRol2.Location = New System.Drawing.Point(692, 74)
        Me.LRol2.Name = "LRol2"
        Me.LRol2.Size = New System.Drawing.Size(23, 13)
        Me.LRol2.TabIndex = 54
        Me.LRol2.Text = "Rol"
        '
        'LNombre2
        '
        Me.LNombre2.AutoSize = True
        Me.LNombre2.Location = New System.Drawing.Point(610, 73)
        Me.LNombre2.Name = "LNombre2"
        Me.LNombre2.Size = New System.Drawing.Size(44, 13)
        Me.LNombre2.TabIndex = 53
        Me.LNombre2.Text = "Nombre"
        '
        'LUsuario2
        '
        Me.LUsuario2.AutoSize = True
        Me.LUsuario2.Location = New System.Drawing.Point(536, 73)
        Me.LUsuario2.Name = "LUsuario2"
        Me.LUsuario2.Size = New System.Drawing.Size(43, 13)
        Me.LUsuario2.TabIndex = 52
        Me.LUsuario2.Text = "Usuario"
        '
        'LID2
        '
        Me.LID2.AutoSize = True
        Me.LID2.Location = New System.Drawing.Point(492, 73)
        Me.LID2.Name = "LID2"
        Me.LID2.Size = New System.Drawing.Size(18, 13)
        Me.LID2.TabIndex = 51
        Me.LID2.Text = "ID"
        '
        'LEjemploCorreo
        '
        Me.LEjemploCorreo.AutoSize = True
        Me.LEjemploCorreo.Location = New System.Drawing.Point(82, 273)
        Me.LEjemploCorreo.Name = "LEjemploCorreo"
        Me.LEjemploCorreo.Size = New System.Drawing.Size(171, 13)
        Me.LEjemploCorreo.TabIndex = 50
        Me.LEjemploCorreo.Text = "Ejemplo: ejemple@montaditos.com"
        '
        'LEjemploContraseña
        '
        Me.LEjemploContraseña.AutoSize = True
        Me.LEjemploContraseña.Location = New System.Drawing.Point(251, 162)
        Me.LEjemploContraseña.Name = "LEjemploContraseña"
        Me.LEjemploContraseña.Size = New System.Drawing.Size(105, 13)
        Me.LEjemploContraseña.TabIndex = 49
        Me.LEjemploContraseña.Text = "Ejemplo: Ejemplo123"
        '
        'TBUsuario
        '
        Me.TBUsuario.Location = New System.Drawing.Point(333, 80)
        Me.TBUsuario.MaxLength = 12
        Me.TBUsuario.Name = "TBUsuario"
        Me.TBUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TBUsuario.TabIndex = 28
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Location = New System.Drawing.Point(284, 80)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(47, 13)
        Me.LUsuario.TabIndex = 48
        Me.LUsuario.Text = "Usuario*"
        '
        'TBId
        '
        Me.TBId.Enabled = False
        Me.TBId.Location = New System.Drawing.Point(100, 83)
        Me.TBId.MaxLength = 2
        Me.TBId.Name = "TBId"
        Me.TBId.ReadOnly = True
        Me.TBId.Size = New System.Drawing.Size(100, 20)
        Me.TBId.TabIndex = 47
        '
        'LID
        '
        Me.LID.AutoSize = True
        Me.LID.Location = New System.Drawing.Point(64, 83)
        Me.LID.Name = "LID"
        Me.LID.Size = New System.Drawing.Size(22, 13)
        Me.LID.TabIndex = 46
        Me.LID.Text = "ID*"
        '
        'CBRol
        '
        Me.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBRol.FormattingEnabled = True
        Me.CBRol.Items.AddRange(New Object() {"Admin", "Vendedor"})
        Me.CBRol.Location = New System.Drawing.Point(333, 254)
        Me.CBRol.Name = "CBRol"
        Me.CBRol.Size = New System.Drawing.Size(121, 21)
        Me.CBRol.TabIndex = 41
        '
        'LRol
        '
        Me.LRol.AutoSize = True
        Me.LRol.BackColor = System.Drawing.Color.Transparent
        Me.LRol.Location = New System.Drawing.Point(300, 254)
        Me.LRol.Name = "LRol"
        Me.LRol.Size = New System.Drawing.Size(27, 13)
        Me.LRol.TabIndex = 45
        Me.LRol.Text = "Rol*"
        '
        'LBUsuarios
        '
        Me.LBUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LBUsuarios.FormattingEnabled = True
        Me.LBUsuarios.Location = New System.Drawing.Point(32, 0)
        Me.LBUsuarios.Name = "LBUsuarios"
        Me.LBUsuarios.Size = New System.Drawing.Size(91, 182)
        Me.LBUsuarios.TabIndex = 44
        '
        'TBCorreo
        '
        Me.TBCorreo.Location = New System.Drawing.Point(100, 242)
        Me.TBCorreo.MaxLength = 25
        Me.TBCorreo.Name = "TBCorreo"
        Me.TBCorreo.Size = New System.Drawing.Size(153, 20)
        Me.TBCorreo.TabIndex = 40
        '
        'TBTelefono
        '
        Me.TBTelefono.Location = New System.Drawing.Point(333, 195)
        Me.TBTelefono.MaxLength = 9
        Me.TBTelefono.Name = "TBTelefono"
        Me.TBTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TBTelefono.TabIndex = 39
        '
        'TBDNI
        '
        Me.TBDNI.Location = New System.Drawing.Point(100, 195)
        Me.TBDNI.MaxLength = 9
        Me.TBDNI.Name = "TBDNI"
        Me.TBDNI.Size = New System.Drawing.Size(100, 20)
        Me.TBDNI.TabIndex = 37
        '
        'TBContraseña
        '
        Me.TBContraseña.Location = New System.Drawing.Point(100, 162)
        Me.TBContraseña.MaxLength = 15
        Me.TBContraseña.Name = "TBContraseña"
        Me.TBContraseña.Size = New System.Drawing.Size(100, 20)
        Me.TBContraseña.TabIndex = 35
        Me.TBContraseña.UseSystemPasswordChar = True
        '
        'TBApellido
        '
        Me.TBApellido.Location = New System.Drawing.Point(333, 114)
        Me.TBApellido.MaxLength = 12
        Me.TBApellido.Name = "TBApellido"
        Me.TBApellido.Size = New System.Drawing.Size(100, 20)
        Me.TBApellido.TabIndex = 33
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(100, 121)
        Me.TBNombre.MaxLength = 10
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(100, 20)
        Me.TBNombre.TabIndex = 31
        '
        'LCorreo
        '
        Me.LCorreo.AutoSize = True
        Me.LCorreo.Location = New System.Drawing.Point(-3, 242)
        Me.LCorreo.Name = "LCorreo"
        Me.LCorreo.Size = New System.Drawing.Size(94, 13)
        Me.LCorreo.TabIndex = 38
        Me.LCorreo.Text = "Correo Electronico"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(278, 198)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LTelefono.TabIndex = 36
        Me.LTelefono.Text = "Teléfono"
        '
        'LDNI
        '
        Me.LDNI.AutoSize = True
        Me.LDNI.Location = New System.Drawing.Point(56, 195)
        Me.LDNI.Name = "LDNI"
        Me.LDNI.Size = New System.Drawing.Size(30, 13)
        Me.LDNI.TabIndex = 34
        Me.LDNI.Text = "DNI*"
        '
        'LContraseña
        '
        Me.LContraseña.AutoSize = True
        Me.LContraseña.Location = New System.Drawing.Point(21, 162)
        Me.LContraseña.Name = "LContraseña"
        Me.LContraseña.Size = New System.Drawing.Size(65, 13)
        Me.LContraseña.TabIndex = 32
        Me.LContraseña.Text = "Contraseña*"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(251, 114)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(80, 13)
        Me.LApellido.TabIndex = 30
        Me.LApellido.Text = "Primer Apellido*"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(38, 121)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(48, 13)
        Me.LNombre.TabIndex = 29
        Me.LNombre.Text = "Nombre*"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.VolverToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(762, 24)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoUsuarioTSMI, Me.ActualizarTSMI, Me.ToolStripSeparator1, Me.GuardarTSMI, Me.ModificarTSMI, Me.ToolStripSeparator2, Me.BorrarTSMI})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'NuevoUsuarioTSMI
        '
        Me.NuevoUsuarioTSMI.Name = "NuevoUsuarioTSMI"
        Me.NuevoUsuarioTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.NuevoUsuarioTSMI.Size = New System.Drawing.Size(195, 22)
        Me.NuevoUsuarioTSMI.Text = "Nuevo usuario"
        '
        'ActualizarTSMI
        '
        Me.ActualizarTSMI.Name = "ActualizarTSMI"
        Me.ActualizarTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ActualizarTSMI.Size = New System.Drawing.Size(195, 22)
        Me.ActualizarTSMI.Text = "Actualizar Lista"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(192, 6)
        '
        'GuardarTSMI
        '
        Me.GuardarTSMI.Name = "GuardarTSMI"
        Me.GuardarTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GuardarTSMI.Size = New System.Drawing.Size(195, 22)
        Me.GuardarTSMI.Text = "Guardar"
        '
        'ModificarTSMI
        '
        Me.ModificarTSMI.Name = "ModificarTSMI"
        Me.ModificarTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ModificarTSMI.Size = New System.Drawing.Size(195, 22)
        Me.ModificarTSMI.Text = "Modificar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(192, 6)
        '
        'BorrarTSMI
        '
        Me.BorrarTSMI.Name = "BorrarTSMI"
        Me.BorrarTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BorrarTSMI.Size = New System.Drawing.Size(195, 22)
        Me.BorrarTSMI.Text = "Borrar"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(215, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 31)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Administracion de Usuarios"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "Ayuda usuario\Documento 2 (1).html"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LBRol)
        Me.Panel1.Controls.Add(Me.LBNombre)
        Me.Panel1.Controls.Add(Me.LBUsuarios)
        Me.Panel1.Controls.Add(Me.LBID)
        Me.Panel1.Location = New System.Drawing.Point(495, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(255, 181)
        Me.Panel1.TabIndex = 56
        '
        'LBRol
        '
        Me.LBRol.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LBRol.FormattingEnabled = True
        Me.LBRol.Location = New System.Drawing.Point(200, 1)
        Me.LBRol.Name = "LBRol"
        Me.LBRol.Size = New System.Drawing.Size(55, 182)
        Me.LBRol.TabIndex = 47
        '
        'LBNombre
        '
        Me.LBNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LBNombre.FormattingEnabled = True
        Me.LBNombre.Location = New System.Drawing.Point(118, 0)
        Me.LBNombre.Name = "LBNombre"
        Me.LBNombre.Size = New System.Drawing.Size(88, 182)
        Me.LBNombre.TabIndex = 46
        '
        'LBID
        '
        Me.LBID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LBID.FormattingEnabled = True
        Me.LBID.Location = New System.Drawing.Point(0, 0)
        Me.LBID.Name = "LBID"
        Me.LBID.Size = New System.Drawing.Size(35, 182)
        Me.LBID.TabIndex = 45
        '
        'AdministrarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(762, 334)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LNombre2)
        Me.Controls.Add(Me.TBBuscar)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.LRol2)
        Me.Controls.Add(Me.LUsuario2)
        Me.Controls.Add(Me.LID2)
        Me.Controls.Add(Me.LEjemploCorreo)
        Me.Controls.Add(Me.LEjemploContraseña)
        Me.Controls.Add(Me.TBUsuario)
        Me.Controls.Add(Me.LUsuario)
        Me.Controls.Add(Me.TBId)
        Me.Controls.Add(Me.LID)
        Me.Controls.Add(Me.CBRol)
        Me.Controls.Add(Me.LRol)
        Me.Controls.Add(Me.TBCorreo)
        Me.Controls.Add(Me.TBTelefono)
        Me.Controls.Add(Me.TBDNI)
        Me.Controls.Add(Me.TBContraseña)
        Me.Controls.Add(Me.TBApellido)
        Me.Controls.Add(Me.TBNombre)
        Me.Controls.Add(Me.LCorreo)
        Me.Controls.Add(Me.LTelefono)
        Me.Controls.Add(Me.LDNI)
        Me.Controls.Add(Me.LContraseña)
        Me.Controls.Add(Me.LApellido)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AdministrarUsuarios"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Administracion de usuarios"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents LRol2 As Label
    Friend WithEvents LNombre2 As Label
    Friend WithEvents LUsuario2 As Label
    Friend WithEvents LID2 As Label
    Friend WithEvents LEjemploCorreo As Label
    Friend WithEvents LEjemploContraseña As Label
    Friend WithEvents TBUsuario As TextBox
    Friend WithEvents LUsuario As Label
    Friend WithEvents TBId As TextBox
    Friend WithEvents LID As Label
    Friend WithEvents CBRol As ComboBox
    Friend WithEvents LRol As Label
    Friend WithEvents LBUsuarios As ListBox
    Friend WithEvents TBCorreo As TextBox
    Friend WithEvents TBTelefono As TextBox
    Friend WithEvents TBDNI As TextBox
    Friend WithEvents TBContraseña As TextBox
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents LCorreo As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents LDNI As Label
    Friend WithEvents LContraseña As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoUsuarioTSMI As ToolStripMenuItem
    Friend WithEvents ActualizarTSMI As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents GuardarTSMI As ToolStripMenuItem
    Friend WithEvents ModificarTSMI As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents BorrarTSMI As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LBID As System.Windows.Forms.ListBox
    Friend WithEvents LBNombre As System.Windows.Forms.ListBox
    Friend WithEvents LBRol As System.Windows.Forms.ListBox
End Class
