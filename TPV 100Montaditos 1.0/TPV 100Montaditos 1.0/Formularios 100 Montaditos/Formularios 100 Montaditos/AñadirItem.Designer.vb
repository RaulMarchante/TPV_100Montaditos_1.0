<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AñadirItem))
        Me.BTerminar = New System.Windows.Forms.Button()
        Me.BAñadir = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.LCantidad = New System.Windows.Forms.Label()
        Me.LMontado = New System.Windows.Forms.Label()
        Me.TBCantidad = New System.Windows.Forms.TextBox()
        Me.TBNºMontado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.SuspendLayout()
        '
        'BTerminar
        '
        Me.BTerminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTerminar.Location = New System.Drawing.Point(351, 225)
        Me.BTerminar.Name = "BTerminar"
        Me.BTerminar.Size = New System.Drawing.Size(113, 32)
        Me.BTerminar.TabIndex = 13
        Me.BTerminar.Text = "Terminar"
        Me.BTerminar.UseVisualStyleBackColor = True
        '
        'BAñadir
        '
        Me.BAñadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAñadir.Location = New System.Drawing.Point(195, 225)
        Me.BAñadir.Name = "BAñadir"
        Me.BAñadir.Size = New System.Drawing.Size(134, 32)
        Me.BAñadir.TabIndex = 12
        Me.BAñadir.Text = "Añadir otro"
        Me.BAñadir.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.Location = New System.Drawing.Point(59, 225)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(106, 32)
        Me.BCancelar.TabIndex = 11
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'LCantidad
        '
        Me.LCantidad.AutoSize = True
        Me.LCantidad.BackColor = System.Drawing.Color.Transparent
        Me.LCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCantidad.Location = New System.Drawing.Point(124, 155)
        Me.LCantidad.Name = "LCantidad"
        Me.LCantidad.Size = New System.Drawing.Size(98, 25)
        Me.LCantidad.TabIndex = 10
        Me.LCantidad.Text = "Cantidad"
        '
        'LMontado
        '
        Me.LMontado.AutoSize = True
        Me.LMontado.BackColor = System.Drawing.Color.Transparent
        Me.LMontado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMontado.Location = New System.Drawing.Point(97, 104)
        Me.LMontado.Name = "LMontado"
        Me.LMontado.Size = New System.Drawing.Size(125, 25)
        Me.LMontado.TabIndex = 9
        Me.LMontado.Text = "Nº Montado"
        '
        'TBCantidad
        '
        Me.TBCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCantidad.Location = New System.Drawing.Point(251, 155)
        Me.TBCantidad.MaxLength = 2
        Me.TBCantidad.Name = "TBCantidad"
        Me.TBCantidad.Size = New System.Drawing.Size(100, 31)
        Me.TBCantidad.TabIndex = 8
        '
        'TBNºMontado
        '
        Me.TBNºMontado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNºMontado.Location = New System.Drawing.Point(251, 104)
        Me.TBNºMontado.MaxLength = 3
        Me.TBNºMontado.Name = "TBNºMontado"
        Me.TBNºMontado.Size = New System.Drawing.Size(100, 31)
        Me.TBNºMontado.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 31)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "SELECCION MONTADITOS "
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "Ayuda usuario\Documento 2 (1).html"
        '
        'AñadirItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(519, 302)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTerminar)
        Me.Controls.Add(Me.BAñadir)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.LCantidad)
        Me.Controls.Add(Me.LMontado)
        Me.Controls.Add(Me.TBCantidad)
        Me.Controls.Add(Me.TBNºMontado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AñadirItem"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccion de montadito"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTerminar As Button
    Friend WithEvents BAñadir As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents LCantidad As Label
    Friend WithEvents LMontado As Label
    Friend WithEvents TBCantidad As TextBox
    Friend WithEvents TBNºMontado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
