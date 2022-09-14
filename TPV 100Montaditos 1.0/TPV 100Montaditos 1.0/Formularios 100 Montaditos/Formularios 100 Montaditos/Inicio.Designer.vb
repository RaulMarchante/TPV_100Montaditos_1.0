<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.PinicioSesion = New System.Windows.Forms.Panel()
        Me.BiniciarSesion = New System.Windows.Forms.Button()
        Me.TBcontraseña = New System.Windows.Forms.TextBox()
        Me.TBusuario = New System.Windows.Forms.TextBox()
        Me.Lcontraseña = New System.Windows.Forms.Label()
        Me.Lusuario = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PinicioSesion.SuspendLayout()
        Me.SuspendLayout()
        '
        'PinicioSesion
        '
        Me.PinicioSesion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PinicioSesion.AutoSize = True
        Me.PinicioSesion.Controls.Add(Me.BiniciarSesion)
        Me.PinicioSesion.Controls.Add(Me.TBcontraseña)
        Me.PinicioSesion.Controls.Add(Me.TBusuario)
        Me.PinicioSesion.Controls.Add(Me.Lcontraseña)
        Me.PinicioSesion.Controls.Add(Me.Lusuario)
        Me.PinicioSesion.Location = New System.Drawing.Point(266, 143)
        Me.PinicioSesion.Name = "PinicioSesion"
        Me.PinicioSesion.Size = New System.Drawing.Size(269, 164)
        Me.PinicioSesion.TabIndex = 4
        Me.PinicioSesion.Visible = False
        '
        'BiniciarSesion
        '
        Me.BiniciarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BiniciarSesion.Location = New System.Drawing.Point(80, 96)
        Me.BiniciarSesion.Name = "BiniciarSesion"
        Me.BiniciarSesion.Size = New System.Drawing.Size(135, 63)
        Me.BiniciarSesion.TabIndex = 4
        Me.BiniciarSesion.Text = "Iniciar Sesion"
        Me.BiniciarSesion.UseVisualStyleBackColor = True
        '
        'TBcontraseña
        '
        Me.TBcontraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBcontraseña.Location = New System.Drawing.Point(150, 59)
        Me.TBcontraseña.MaxLength = 15
        Me.TBcontraseña.Name = "TBcontraseña"
        Me.TBcontraseña.Size = New System.Drawing.Size(100, 31)
        Me.TBcontraseña.TabIndex = 1
        Me.TBcontraseña.UseSystemPasswordChar = True
        '
        'TBusuario
        '
        Me.TBusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBusuario.Location = New System.Drawing.Point(150, 16)
        Me.TBusuario.MaxLength = 12
        Me.TBusuario.Name = "TBusuario"
        Me.TBusuario.Size = New System.Drawing.Size(100, 31)
        Me.TBusuario.TabIndex = 0
        '
        'Lcontraseña
        '
        Me.Lcontraseña.AutoSize = True
        Me.Lcontraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcontraseña.Location = New System.Drawing.Point(19, 59)
        Me.Lcontraseña.Name = "Lcontraseña"
        Me.Lcontraseña.Size = New System.Drawing.Size(123, 25)
        Me.Lcontraseña.TabIndex = 3
        Me.Lcontraseña.Text = "Contraseña"
        '
        'Lusuario
        '
        Me.Lusuario.AutoSize = True
        Me.Lusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lusuario.Location = New System.Drawing.Point(19, 22)
        Me.Lusuario.Name = "Lusuario"
        Me.Lusuario.Size = New System.Drawing.Size(86, 25)
        Me.Lusuario.TabIndex = 2
        Me.Lusuario.Text = "Usuario"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "Ayuda usuario\Documento 2 (1).html"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PinicioSesion)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Inicio"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.PinicioSesion.ResumeLayout(False)
        Me.PinicioSesion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PinicioSesion As Panel
    Friend WithEvents BiniciarSesion As Button
    Friend WithEvents TBcontraseña As TextBox
    Friend WithEvents TBusuario As TextBox
    Friend WithEvents Lcontraseña As Label
    Friend WithEvents Lusuario As Label
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
