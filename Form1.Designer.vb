<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblLegajo = New System.Windows.Forms.Label()
        Me.txtLegajo = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblOrientacion = New System.Windows.Forms.Label()
        Me.lblDesaprobadas = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDesaprobadas = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarAplicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContarRegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaInscripcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.AlumnosInscriptosDetalladoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarLegajoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarLegajoDesaprobadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbOrientacion = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLegajo
        '
        Me.lblLegajo.AutoSize = True
        Me.lblLegajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLegajo.Location = New System.Drawing.Point(48, 124)
        Me.lblLegajo.Name = "lblLegajo"
        Me.lblLegajo.Size = New System.Drawing.Size(61, 20)
        Me.lblLegajo.TabIndex = 0
        Me.lblLegajo.Text = "Legajo:"
        '
        'txtLegajo
        '
        Me.txtLegajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLegajo.Location = New System.Drawing.Point(193, 121)
        Me.txtLegajo.Name = "txtLegajo"
        Me.txtLegajo.Size = New System.Drawing.Size(287, 26)
        Me.txtLegajo.TabIndex = 1
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(48, 167)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(69, 20)
        Me.lblApellido.TabIndex = 2
        Me.lblApellido.Text = "Apellido:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(48, 212)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(69, 20)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre:"
        '
        'lblOrientacion
        '
        Me.lblOrientacion.AutoSize = True
        Me.lblOrientacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrientacion.Location = New System.Drawing.Point(48, 255)
        Me.lblOrientacion.Name = "lblOrientacion"
        Me.lblOrientacion.Size = New System.Drawing.Size(94, 20)
        Me.lblOrientacion.TabIndex = 4
        Me.lblOrientacion.Text = "Orientación:"
        '
        'lblDesaprobadas
        '
        Me.lblDesaprobadas.AutoSize = True
        Me.lblDesaprobadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesaprobadas.Location = New System.Drawing.Point(48, 294)
        Me.lblDesaprobadas.Name = "lblDesaprobadas"
        Me.lblDesaprobadas.Size = New System.Drawing.Size(118, 20)
        Me.lblDesaprobadas.TabIndex = 5
        Me.lblDesaprobadas.Text = "Desaprobadas:"
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(193, 167)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(287, 26)
        Me.txtApellido.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(193, 209)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(287, 26)
        Me.txtNombre.TabIndex = 7
        '
        'txtDesaprobadas
        '
        Me.txtDesaprobadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesaprobadas.Location = New System.Drawing.Point(193, 294)
        Me.txtDesaprobadas.Name = "txtDesaprobadas"
        Me.txtDesaprobadas.Size = New System.Drawing.Size(287, 26)
        Me.txtDesaprobadas.TabIndex = 9
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1055, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarAplicaciónToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarRegistroToolStripMenuItem, Me.ContarRegistrosToolStripMenuItem, Me.AlumnosInscriptosDetalladoToolStripMenuItem, Me.MostrarLegajoToolStripMenuItem, Me.MostrarLegajoDesaprobadosToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.EditarToolStripMenuItem.Text = "Consultas"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaInscripcionesToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'CerrarAplicaciónToolStripMenuItem
        '
        Me.CerrarAplicaciónToolStripMenuItem.Name = "CerrarAplicaciónToolStripMenuItem"
        Me.CerrarAplicaciónToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarAplicaciónToolStripMenuItem.Text = "Cerrar Aplicación"
        '
        'BuscarRegistroToolStripMenuItem
        '
        Me.BuscarRegistroToolStripMenuItem.Name = "BuscarRegistroToolStripMenuItem"
        Me.BuscarRegistroToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.BuscarRegistroToolStripMenuItem.Text = "Allumnos Inscriptos"
        '
        'ContarRegistrosToolStripMenuItem
        '
        Me.ContarRegistrosToolStripMenuItem.Name = "ContarRegistrosToolStripMenuItem"
        Me.ContarRegistrosToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ContarRegistrosToolStripMenuItem.Text = "Inscriptos por Orientación"
        '
        'AcercaInscripcionesToolStripMenuItem
        '
        Me.AcercaInscripcionesToolStripMenuItem.Name = "AcercaInscripcionesToolStripMenuItem"
        Me.AcercaInscripcionesToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.AcercaInscripcionesToolStripMenuItem.Text = "Acerca Inscripciones"
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(290, 381)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 31)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(390, 381)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 31)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1055, 25)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripButton1.Text = "Agregar"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(78, 22)
        Me.ToolStripButton2.Text = "Modificar"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripButton3.Text = "Eliminar"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(876, 459)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 31)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'AlumnosInscriptosDetalladoToolStripMenuItem
        '
        Me.AlumnosInscriptosDetalladoToolStripMenuItem.Name = "AlumnosInscriptosDetalladoToolStripMenuItem"
        Me.AlumnosInscriptosDetalladoToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.AlumnosInscriptosDetalladoToolStripMenuItem.Text = "Alumnos Inscriptos Detallado"
        '
        'MostrarLegajoToolStripMenuItem
        '
        Me.MostrarLegajoToolStripMenuItem.Name = "MostrarLegajoToolStripMenuItem"
        Me.MostrarLegajoToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.MostrarLegajoToolStripMenuItem.Text = "Mostrar Legajo"
        '
        'MostrarLegajoDesaprobadosToolStripMenuItem
        '
        Me.MostrarLegajoDesaprobadosToolStripMenuItem.Name = "MostrarLegajoDesaprobadosToolStripMenuItem"
        Me.MostrarLegajoDesaprobadosToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.MostrarLegajoDesaprobadosToolStripMenuItem.Text = "Mostrar Legajo Desaprobados"
        '
        'cmbOrientacion
        '
        Me.cmbOrientacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOrientacion.FormattingEnabled = True
        Me.cmbOrientacion.Items.AddRange(New Object() {"Economia y Administración", "Comunicaciones", "Sociales"})
        Me.cmbOrientacion.Location = New System.Drawing.Point(193, 252)
        Me.cmbOrientacion.Name = "cmbOrientacion"
        Me.cmbOrientacion.Size = New System.Drawing.Size(287, 28)
        Me.cmbOrientacion.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 523)
        Me.Controls.Add(Me.cmbOrientacion)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtDesaprobadas)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.lblDesaprobadas)
        Me.Controls.Add(Me.lblOrientacion)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.txtLegajo)
        Me.Controls.Add(Me.lblLegajo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Inscripciones"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLegajo As Label
    Friend WithEvents txtLegajo As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblOrientacion As Label
    Friend WithEvents lblDesaprobadas As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDesaprobadas As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarAplicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarRegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContarRegistrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaInscripcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents btnSalir As Button
    Friend WithEvents AlumnosInscriptosDetalladoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarLegajoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarLegajoDesaprobadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmbOrientacion As ComboBox
End Class
