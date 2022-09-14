<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        Me.TBid = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.LCodigo = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.LBCodigo = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBPrecio = New System.Windows.Forms.ListBox()
        Me.LBNombre = New System.Windows.Forms.ListBox()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BActualizar = New System.Windows.Forms.Button()
        Me.CBTipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.TBbusqueda = New System.Windows.Forms.TextBox()
        Me.BBusqueda = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBid
        '
        Me.TBid.Location = New System.Drawing.Point(88, 86)
        Me.TBid.MaxLength = 3
        Me.TBid.Name = "TBid"
        Me.TBid.Size = New System.Drawing.Size(100, 20)
        Me.TBid.TabIndex = 1
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(88, 113)
        Me.TBNombre.MaxLength = 100
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(100, 20)
        Me.TBNombre.TabIndex = 2
        '
        'TBPrecio
        '
        Me.TBPrecio.Location = New System.Drawing.Point(88, 139)
        Me.TBPrecio.MaxLength = 4
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.Size = New System.Drawing.Size(100, 20)
        Me.TBPrecio.TabIndex = 3
        '
        'LCodigo
        '
        Me.LCodigo.AutoSize = True
        Me.LCodigo.Location = New System.Drawing.Point(13, 93)
        Me.LCodigo.Name = "LCodigo"
        Me.LCodigo.Size = New System.Drawing.Size(16, 13)
        Me.LCodigo.TabIndex = 3
        Me.LCodigo.Text = "Id"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(13, 120)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(44, 13)
        Me.LNombre.TabIndex = 4
        Me.LNombre.Text = "Nombre"
        '
        'LPrecio
        '
        Me.LPrecio.AutoSize = True
        Me.LPrecio.Location = New System.Drawing.Point(13, 146)
        Me.LPrecio.Name = "LPrecio"
        Me.LPrecio.Size = New System.Drawing.Size(37, 13)
        Me.LPrecio.TabIndex = 5
        Me.LPrecio.Text = "Precio"
        '
        'LBCodigo
        '
        Me.LBCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LBCodigo.FormattingEnabled = True
        Me.LBCodigo.Location = New System.Drawing.Point(0, 0)
        Me.LBCodigo.Name = "LBCodigo"
        Me.LBCodigo.Size = New System.Drawing.Size(35, 663)
        Me.LBCodigo.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.LBPrecio)
        Me.Panel1.Controls.Add(Me.LBNombre)
        Me.Panel1.Controls.Add(Me.LBCodigo)
        Me.Panel1.Location = New System.Drawing.Point(12, 188)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(514, 159)
        Me.Panel1.TabIndex = 7
        '
        'LBPrecio
        '
        Me.LBPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LBPrecio.FormattingEnabled = True
        Me.LBPrecio.Location = New System.Drawing.Point(472, 0)
        Me.LBPrecio.Name = "LBPrecio"
        Me.LBPrecio.Size = New System.Drawing.Size(30, 676)
        Me.LBPrecio.TabIndex = 13
        '
        'LBNombre
        '
        Me.LBNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LBNombre.FormattingEnabled = True
        Me.LBNombre.Location = New System.Drawing.Point(31, 0)
        Me.LBNombre.Name = "LBNombre"
        Me.LBNombre.Size = New System.Drawing.Size(443, 676)
        Me.LBNombre.TabIndex = 12
        '
        'BGuardar
        '
        Me.BGuardar.Enabled = False
        Me.BGuardar.Location = New System.Drawing.Point(269, 110)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(61, 23)
        Me.BGuardar.TabIndex = 6
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'BEliminar
        '
        Me.BEliminar.Enabled = False
        Me.BEliminar.Location = New System.Drawing.Point(407, 111)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(62, 23)
        Me.BEliminar.TabIndex = 8
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'BActualizar
        '
        Me.BActualizar.Enabled = False
        Me.BActualizar.Location = New System.Drawing.Point(336, 110)
        Me.BActualizar.Name = "BActualizar"
        Me.BActualizar.Size = New System.Drawing.Size(65, 23)
        Me.BActualizar.TabIndex = 7
        Me.BActualizar.Text = "Actualizar"
        Me.BActualizar.UseVisualStyleBackColor = True
        '
        'CBTipo
        '
        Me.CBTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTipo.FormattingEnabled = True
        Me.CBTipo.Items.AddRange(New Object() {"Montaditos (1-50)", "Montaditos(51-100)", "Bebidas", "Aperitivos", "Helados"})
        Me.CBTipo.Location = New System.Drawing.Point(88, 59)
        Me.CBTipo.Name = "CBTipo"
        Me.CBTipo.Size = New System.Drawing.Size(121, 21)
        Me.CBTipo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Tipo producto"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(526, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'BNuevo
        '
        Me.BNuevo.Location = New System.Drawing.Point(208, 110)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Size = New System.Drawing.Size(55, 23)
        Me.BNuevo.TabIndex = 5
        Me.BNuevo.Text = "Nuevo"
        Me.BNuevo.UseVisualStyleBackColor = True
        '
        'TBbusqueda
        '
        Me.TBbusqueda.Location = New System.Drawing.Point(208, 138)
        Me.TBbusqueda.MaxLength = 20
        Me.TBbusqueda.Name = "TBbusqueda"
        Me.TBbusqueda.Size = New System.Drawing.Size(193, 20)
        Me.TBbusqueda.TabIndex = 9
        Me.TBbusqueda.Text = "<--Introduzca id para busqueda-->"
        '
        'BBusqueda
        '
        Me.BBusqueda.Location = New System.Drawing.Point(407, 138)
        Me.BBusqueda.Name = "BBusqueda"
        Me.BBusqueda.Size = New System.Drawing.Size(62, 23)
        Me.BBusqueda.TabIndex = 10
        Me.BBusqueda.Text = "Buscar"
        Me.BBusqueda.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(281, 31)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Administrar Productos"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "Ayuda usuario\Documento 2 (1).html"
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(526, 374)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BBusqueda)
        Me.Controls.Add(Me.TBbusqueda)
        Me.Controls.Add(Me.BNuevo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBTipo)
        Me.Controls.Add(Me.BActualizar)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LPrecio)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.LCodigo)
        Me.Controls.Add(Me.TBPrecio)
        Me.Controls.Add(Me.TBNombre)
        Me.Controls.Add(Me.TBid)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Productos"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBid As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents TBPrecio As TextBox
    Friend WithEvents LCodigo As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LPrecio As Label
    Friend WithEvents LBCodigo As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBPrecio As ListBox
    Friend WithEvents LBNombre As ListBox
    Friend WithEvents BGuardar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents BActualizar As Button
    Friend WithEvents CBTipo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BNuevo As Button
    Friend WithEvents TBbusqueda As TextBox
    Friend WithEvents BBusqueda As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
