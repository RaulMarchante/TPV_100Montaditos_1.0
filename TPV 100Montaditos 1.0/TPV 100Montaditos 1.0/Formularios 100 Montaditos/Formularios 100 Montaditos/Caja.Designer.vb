<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Caja))
        Me.BMontadito = New System.Windows.Forms.Button()
        Me.BBebidas = New System.Windows.Forms.Button()
        Me.BAperitivos = New System.Windows.Forms.Button()
        Me.BHelados = New System.Windows.Forms.Button()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.BQuitar = New System.Windows.Forms.Button()
        Me.BQuitarTodo = New System.Windows.Forms.Button()
        Me.TBUnidades = New System.Windows.Forms.TextBox()
        Me.LUnidades = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ComprobarCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LTextPrecio = New System.Windows.Forms.Label()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.LCliente = New System.Windows.Forms.Label()
        Me.TBEfectivo = New System.Windows.Forms.TextBox()
        Me.LTextCambio = New System.Windows.Forms.Label()
        Me.LCambio = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBReferencia = New System.Windows.Forms.ListBox()
        Me.LBPrecio = New System.Windows.Forms.ListBox()
        Me.LBCantidad = New System.Windows.Forms.ListBox()
        Me.LBProductos = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LBProductoPrecio = New System.Windows.Forms.ListBox()
        Me.BCobrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LEuro = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BMontadito
        '
        Me.BMontadito.BackColor = System.Drawing.Color.Red
        Me.BMontadito.Image = CType(resources.GetObject("BMontadito.Image"), System.Drawing.Image)
        Me.BMontadito.Location = New System.Drawing.Point(12, 81)
        Me.BMontadito.Name = "BMontadito"
        Me.BMontadito.Size = New System.Drawing.Size(315, 111)
        Me.BMontadito.TabIndex = 0
        Me.BMontadito.UseCompatibleTextRendering = True
        Me.BMontadito.UseVisualStyleBackColor = False
        '
        'BBebidas
        '
        Me.BBebidas.BackColor = System.Drawing.Color.Yellow
        Me.BBebidas.Image = CType(resources.GetObject("BBebidas.Image"), System.Drawing.Image)
        Me.BBebidas.Location = New System.Drawing.Point(12, 213)
        Me.BBebidas.Name = "BBebidas"
        Me.BBebidas.Size = New System.Drawing.Size(320, 97)
        Me.BBebidas.TabIndex = 1
        Me.BBebidas.UseVisualStyleBackColor = False
        '
        'BAperitivos
        '
        Me.BAperitivos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BAperitivos.Image = CType(resources.GetObject("BAperitivos.Image"), System.Drawing.Image)
        Me.BAperitivos.Location = New System.Drawing.Point(12, 340)
        Me.BAperitivos.Name = "BAperitivos"
        Me.BAperitivos.Size = New System.Drawing.Size(320, 96)
        Me.BAperitivos.TabIndex = 2
        Me.BAperitivos.UseVisualStyleBackColor = False
        '
        'BHelados
        '
        Me.BHelados.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BHelados.Image = CType(resources.GetObject("BHelados.Image"), System.Drawing.Image)
        Me.BHelados.Location = New System.Drawing.Point(12, 480)
        Me.BHelados.Name = "BHelados"
        Me.BHelados.Size = New System.Drawing.Size(320, 125)
        Me.BHelados.TabIndex = 3
        Me.BHelados.UseVisualStyleBackColor = False
        '
        'BAgregar
        '
        Me.BAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAgregar.Location = New System.Drawing.Point(663, 632)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(160, 76)
        Me.BAgregar.TabIndex = 5
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'BQuitar
        '
        Me.BQuitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BQuitar.Location = New System.Drawing.Point(1117, 543)
        Me.BQuitar.Name = "BQuitar"
        Me.BQuitar.Size = New System.Drawing.Size(121, 64)
        Me.BQuitar.TabIndex = 6
        Me.BQuitar.Text = "Quitar"
        Me.BQuitar.UseVisualStyleBackColor = True
        '
        'BQuitarTodo
        '
        Me.BQuitarTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BQuitarTodo.Location = New System.Drawing.Point(1117, 612)
        Me.BQuitarTodo.Name = "BQuitarTodo"
        Me.BQuitarTodo.Size = New System.Drawing.Size(119, 76)
        Me.BQuitarTodo.TabIndex = 7
        Me.BQuitarTodo.Text = "Quitar todo"
        Me.BQuitarTodo.UseVisualStyleBackColor = True
        '
        'TBUnidades
        '
        Me.TBUnidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBUnidades.Location = New System.Drawing.Point(589, 629)
        Me.TBUnidades.MaxLength = 2
        Me.TBUnidades.Name = "TBUnidades"
        Me.TBUnidades.Size = New System.Drawing.Size(39, 38)
        Me.TBUnidades.TabIndex = 4
        Me.TBUnidades.Text = "1"
        '
        'LUnidades
        '
        Me.LUnidades.AutoSize = True
        Me.LUnidades.BackColor = System.Drawing.Color.White
        Me.LUnidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUnidades.ForeColor = System.Drawing.Color.Black
        Me.LUnidades.Location = New System.Drawing.Point(402, 629)
        Me.LUnidades.Name = "LUnidades"
        Me.LUnidades.Size = New System.Drawing.Size(129, 31)
        Me.LUnidades.TabIndex = 10
        Me.LUnidades.Text = "Unidades"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AdministarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1593, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoPedidoToolStripMenuItem, Me.ToolStripSeparator2, Me.ComprobarCajaToolStripMenuItem, Me.ToolStripSeparator3, Me.CerrarSesionToolStripMenuItem, Me.ToolStripSeparator4, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevoPedidoToolStripMenuItem
        '
        Me.NuevoPedidoToolStripMenuItem.Name = "NuevoPedidoToolStripMenuItem"
        Me.NuevoPedidoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuevoPedidoToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.NuevoPedidoToolStripMenuItem.Text = "Nuevo pedido"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(200, 6)
        '
        'ComprobarCajaToolStripMenuItem
        '
        Me.ComprobarCajaToolStripMenuItem.Name = "ComprobarCajaToolStripMenuItem"
        Me.ComprobarCajaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ComprobarCajaToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ComprobarCajaToolStripMenuItem.Text = "Comprobar Caja"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(200, 6)
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar sesion"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(200, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AdministarToolStripMenuItem
        '
        Me.AdministarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.ToolStripSeparator1, Me.ProductosToolStripMenuItem})
        Me.AdministarToolStripMenuItem.Name = "AdministarToolStripMenuItem"
        Me.AdministarToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AdministarToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.AdministarToolStripMenuItem.Text = "Administar"
        Me.AdministarToolStripMenuItem.Visible = False
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(166, 6)
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'LTextPrecio
        '
        Me.LTextPrecio.AutoSize = True
        Me.LTextPrecio.BackColor = System.Drawing.Color.Transparent
        Me.LTextPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTextPrecio.ForeColor = System.Drawing.Color.Black
        Me.LTextPrecio.Location = New System.Drawing.Point(15, 21)
        Me.LTextPrecio.Name = "LTextPrecio"
        Me.LTextPrecio.Size = New System.Drawing.Size(60, 25)
        Me.LTextPrecio.TabIndex = 12
        Me.LTextPrecio.Text = "Total"
        '
        'LPrecio
        '
        Me.LPrecio.AutoSize = True
        Me.LPrecio.BackColor = System.Drawing.Color.Transparent
        Me.LPrecio.Cursor = System.Windows.Forms.Cursors.Default
        Me.LPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPrecio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LPrecio.Location = New System.Drawing.Point(102, 21)
        Me.LPrecio.Name = "LPrecio"
        Me.LPrecio.Size = New System.Drawing.Size(24, 25)
        Me.LPrecio.TabIndex = 13
        Me.LPrecio.Text = "0"
        '
        'LCliente
        '
        Me.LCliente.AutoSize = True
        Me.LCliente.BackColor = System.Drawing.Color.Transparent
        Me.LCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCliente.ForeColor = System.Drawing.Color.Black
        Me.LCliente.Location = New System.Drawing.Point(3, 62)
        Me.LCliente.Name = "LCliente"
        Me.LCliente.Size = New System.Drawing.Size(89, 25)
        Me.LCliente.TabIndex = 14
        Me.LCliente.Text = "Efectivo"
        '
        'TBEfectivo
        '
        Me.TBEfectivo.BackColor = System.Drawing.Color.White
        Me.TBEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBEfectivo.Location = New System.Drawing.Point(107, 69)
        Me.TBEfectivo.MaxLength = 5
        Me.TBEfectivo.Name = "TBEfectivo"
        Me.TBEfectivo.Size = New System.Drawing.Size(49, 24)
        Me.TBEfectivo.TabIndex = 8
        Me.TBEfectivo.Text = "0"
        Me.TBEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LTextCambio
        '
        Me.LTextCambio.AutoSize = True
        Me.LTextCambio.BackColor = System.Drawing.Color.Transparent
        Me.LTextCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTextCambio.ForeColor = System.Drawing.Color.Black
        Me.LTextCambio.Location = New System.Drawing.Point(7, 107)
        Me.LTextCambio.Name = "LTextCambio"
        Me.LTextCambio.Size = New System.Drawing.Size(85, 25)
        Me.LTextCambio.TabIndex = 16
        Me.LTextCambio.Text = "Cambio"
        '
        'LCambio
        '
        Me.LCambio.AutoSize = True
        Me.LCambio.BackColor = System.Drawing.Color.Transparent
        Me.LCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCambio.ForeColor = System.Drawing.Color.Black
        Me.LCambio.Location = New System.Drawing.Point(102, 107)
        Me.LCambio.Name = "LCambio"
        Me.LCambio.Size = New System.Drawing.Size(24, 25)
        Me.LCambio.TabIndex = 17
        Me.LCambio.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.LBReferencia)
        Me.Panel1.Controls.Add(Me.LBPrecio)
        Me.Panel1.Controls.Add(Me.LBCantidad)
        Me.Panel1.Location = New System.Drawing.Point(1117, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(476, 490)
        Me.Panel1.TabIndex = 18
        '
        'LBReferencia
        '
        Me.LBReferencia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBReferencia.BackColor = System.Drawing.Color.White
        Me.LBReferencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LBReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBReferencia.FormattingEnabled = True
        Me.LBReferencia.ItemHeight = 31
        Me.LBReferencia.Location = New System.Drawing.Point(45, -2)
        Me.LBReferencia.Name = "LBReferencia"
        Me.LBReferencia.Size = New System.Drawing.Size(374, 496)
        Me.LBReferencia.TabIndex = 2
        '
        'LBPrecio
        '
        Me.LBPrecio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBPrecio.BackColor = System.Drawing.Color.White
        Me.LBPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LBPrecio.Enabled = False
        Me.LBPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBPrecio.FormattingEnabled = True
        Me.LBPrecio.ItemHeight = 31
        Me.LBPrecio.Location = New System.Drawing.Point(412, 0)
        Me.LBPrecio.Name = "LBPrecio"
        Me.LBPrecio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LBPrecio.Size = New System.Drawing.Size(61, 496)
        Me.LBPrecio.TabIndex = 1
        '
        'LBCantidad
        '
        Me.LBCantidad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBCantidad.BackColor = System.Drawing.Color.White
        Me.LBCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LBCantidad.Enabled = False
        Me.LBCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCantidad.FormattingEnabled = True
        Me.LBCantidad.ItemHeight = 31
        Me.LBCantidad.Location = New System.Drawing.Point(0, 0)
        Me.LBCantidad.Name = "LBCantidad"
        Me.LBCantidad.Size = New System.Drawing.Size(49, 496)
        Me.LBCantidad.TabIndex = 0
        '
        'LBProductos
        '
        Me.LBProductos.BackColor = System.Drawing.Color.White
        Me.LBProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LBProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBProductos.FormattingEnabled = True
        Me.LBProductos.ItemHeight = 31
        Me.LBProductos.Location = New System.Drawing.Point(3, -8)
        Me.LBProductos.Name = "LBProductos"
        Me.LBProductos.Size = New System.Drawing.Size(502, 930)
        Me.LBProductos.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.LBProductoPrecio)
        Me.Panel2.Controls.Add(Me.LBProductos)
        Me.Panel2.Location = New System.Drawing.Point(338, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(589, 568)
        Me.Panel2.TabIndex = 20
        '
        'LBProductoPrecio
        '
        Me.LBProductoPrecio.BackColor = System.Drawing.Color.White
        Me.LBProductoPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LBProductoPrecio.Enabled = False
        Me.LBProductoPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBProductoPrecio.ForeColor = System.Drawing.Color.Black
        Me.LBProductoPrecio.FormattingEnabled = True
        Me.LBProductoPrecio.ItemHeight = 31
        Me.LBProductoPrecio.Location = New System.Drawing.Point(501, -8)
        Me.LBProductoPrecio.Name = "LBProductoPrecio"
        Me.LBProductoPrecio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LBProductoPrecio.Size = New System.Drawing.Size(68, 1023)
        Me.LBProductoPrecio.TabIndex = 20
        '
        'BCobrar
        '
        Me.BCobrar.Enabled = False
        Me.BCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCobrar.Location = New System.Drawing.Point(1365, 761)
        Me.BCobrar.Name = "BCobrar"
        Me.BCobrar.Size = New System.Drawing.Size(201, 70)
        Me.BCobrar.TabIndex = 21
        Me.BCobrar.Text = "Cobrar"
        Me.BCobrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(341, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Productos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1112, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 25)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Recibo"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "Ayuda usuario\Documento 2 (1).html"
        '
        'TBNombre
        '
        Me.TBNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNombre.Location = New System.Drawing.Point(1339, 691)
        Me.TBNombre.MaxLength = 14
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(227, 38)
        Me.TBNombre.TabIndex = 24
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.BackColor = System.Drawing.Color.White
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.Color.Black
        Me.LNombre.Location = New System.Drawing.Point(1072, 691)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(239, 31)
        Me.LNombre.TabIndex = 25
        Me.LNombre.Text = "Nombre del cliente"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.LEuro)
        Me.Panel3.Controls.Add(Me.LTextPrecio)
        Me.Panel3.Controls.Add(Me.LPrecio)
        Me.Panel3.Controls.Add(Me.LCliente)
        Me.Panel3.Controls.Add(Me.TBEfectivo)
        Me.Panel3.Controls.Add(Me.LTextCambio)
        Me.Panel3.Controls.Add(Me.LCambio)
        Me.Panel3.Location = New System.Drawing.Point(1366, 543)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 146)
        Me.Panel3.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(176, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 25)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "€"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(176, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 25)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "€"
        '
        'LEuro
        '
        Me.LEuro.AutoSize = True
        Me.LEuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEuro.Location = New System.Drawing.Point(176, 21)
        Me.LEuro.Name = "LEuro"
        Me.LEuro.Size = New System.Drawing.Size(24, 25)
        Me.LEuro.TabIndex = 18
        Me.LEuro.Text = "€"
        '
        'Caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1593, 882)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.TBNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BCobrar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LUnidades)
        Me.Controls.Add(Me.TBUnidades)
        Me.Controls.Add(Me.BQuitarTodo)
        Me.Controls.Add(Me.BQuitar)
        Me.Controls.Add(Me.BAgregar)
        Me.Controls.Add(Me.BHelados)
        Me.Controls.Add(Me.BAperitivos)
        Me.Controls.Add(Me.BBebidas)
        Me.Controls.Add(Me.BMontadito)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Caja"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Caja"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BMontadito As System.Windows.Forms.Button
    Friend WithEvents BBebidas As System.Windows.Forms.Button
    Friend WithEvents BAperitivos As System.Windows.Forms.Button
    Friend WithEvents BHelados As System.Windows.Forms.Button
    Friend WithEvents BAgregar As System.Windows.Forms.Button
    Friend WithEvents BQuitar As System.Windows.Forms.Button
    Friend WithEvents BQuitarTodo As System.Windows.Forms.Button
    Friend WithEvents TBUnidades As System.Windows.Forms.TextBox
    Friend WithEvents LUnidades As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoPedidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ComprobarCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LTextPrecio As Label
    Friend WithEvents LPrecio As Label
    Friend WithEvents LCliente As Label
    Friend WithEvents TBEfectivo As TextBox
    Friend WithEvents LTextCambio As Label
    Friend WithEvents LCambio As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBReferencia As ListBox
    Friend WithEvents LBPrecio As ListBox
    Friend WithEvents LBCantidad As ListBox
    Friend WithEvents LBProductos As ListBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LBProductoPrecio As ListBox
    Friend WithEvents BCobrar As Button
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents LNombre As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LEuro As Label
End Class
