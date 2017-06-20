<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class crearmiembros
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
        Me.TBnmiembro = New System.Windows.Forms.TextBox()
        Me.Ltitulomiembro = New System.Windows.Forms.Label()
        Me.Lnmiembro = New System.Windows.Forms.Label()
        Me.Pdatosmiembro = New System.Windows.Forms.Panel()
        Me.Bcomprobardni = New System.Windows.Forms.Button()
        Me.TBtelefono2 = New System.Windows.Forms.TextBox()
        Me.TBtelefono1 = New System.Windows.Forms.TextBox()
        Me.Ltelefonos = New System.Windows.Forms.Label()
        Me.TBprovincia = New System.Windows.Forms.TextBox()
        Me.Lprovincia = New System.Windows.Forms.Label()
        Me.TBlocalidad = New System.Windows.Forms.TextBox()
        Me.Llocalidad = New System.Windows.Forms.Label()
        Me.TBcodigopostal = New System.Windows.Forms.TextBox()
        Me.Lcodigopostal = New System.Windows.Forms.Label()
        Me.Ldireccion = New System.Windows.Forms.Label()
        Me.TBdireccion = New System.Windows.Forms.TextBox()
        Me.Lapellidos = New System.Windows.Forms.Label()
        Me.TBapellidos = New System.Windows.Forms.TextBox()
        Me.Lnombre = New System.Windows.Forms.Label()
        Me.TBnombre = New System.Windows.Forms.TextBox()
        Me.Ldni = New System.Windows.Forms.Label()
        Me.TBdni = New System.Windows.Forms.TextBox()
        Me.Lpagoinicial = New System.Windows.Forms.Label()
        Me.TBpagoinicial = New System.Windows.Forms.TextBox()
        Me.Lpagoinicialefectuado = New System.Windows.Forms.Label()
        Me.TBpagoinicialefectuado = New System.Windows.Forms.TextBox()
        Me.Lcuota = New System.Windows.Forms.Label()
        Me.TBcuota = New System.Windows.Forms.TextBox()
        Me.Lobservaciones = New System.Windows.Forms.Label()
        Me.TBobservaciones = New System.Windows.Forms.TextBox()
        Me.Bcrearmiembro = New System.Windows.Forms.Button()
        Me.Pdatosmiembro.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBnmiembro
        '
        Me.TBnmiembro.Location = New System.Drawing.Point(71, 6)
        Me.TBnmiembro.Name = "TBnmiembro"
        Me.TBnmiembro.Size = New System.Drawing.Size(100, 20)
        Me.TBnmiembro.TabIndex = 0
        '
        'Ltitulomiembro
        '
        Me.Ltitulomiembro.AutoSize = True
        Me.Ltitulomiembro.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ltitulomiembro.Location = New System.Drawing.Point(12, 9)
        Me.Ltitulomiembro.Name = "Ltitulomiembro"
        Me.Ltitulomiembro.Size = New System.Drawing.Size(162, 18)
        Me.Ltitulomiembro.TabIndex = 1
        Me.Ltitulomiembro.Text = "CREAR MIEMBRO"
        '
        'Lnmiembro
        '
        Me.Lnmiembro.AutoSize = True
        Me.Lnmiembro.Location = New System.Drawing.Point(3, 9)
        Me.Lnmiembro.Name = "Lnmiembro"
        Me.Lnmiembro.Size = New System.Drawing.Size(62, 13)
        Me.Lnmiembro.TabIndex = 2
        Me.Lnmiembro.Text = "Nº Miembro"
        '
        'Pdatosmiembro
        '
        Me.Pdatosmiembro.Controls.Add(Me.Bcomprobardni)
        Me.Pdatosmiembro.Controls.Add(Me.TBtelefono2)
        Me.Pdatosmiembro.Controls.Add(Me.TBtelefono1)
        Me.Pdatosmiembro.Controls.Add(Me.Ltelefonos)
        Me.Pdatosmiembro.Controls.Add(Me.TBprovincia)
        Me.Pdatosmiembro.Controls.Add(Me.Lprovincia)
        Me.Pdatosmiembro.Controls.Add(Me.TBlocalidad)
        Me.Pdatosmiembro.Controls.Add(Me.Llocalidad)
        Me.Pdatosmiembro.Controls.Add(Me.TBcodigopostal)
        Me.Pdatosmiembro.Controls.Add(Me.Lcodigopostal)
        Me.Pdatosmiembro.Controls.Add(Me.Ldireccion)
        Me.Pdatosmiembro.Controls.Add(Me.TBdireccion)
        Me.Pdatosmiembro.Controls.Add(Me.Lapellidos)
        Me.Pdatosmiembro.Controls.Add(Me.TBapellidos)
        Me.Pdatosmiembro.Controls.Add(Me.Lnombre)
        Me.Pdatosmiembro.Controls.Add(Me.TBnombre)
        Me.Pdatosmiembro.Controls.Add(Me.Ldni)
        Me.Pdatosmiembro.Controls.Add(Me.TBdni)
        Me.Pdatosmiembro.Controls.Add(Me.Lnmiembro)
        Me.Pdatosmiembro.Controls.Add(Me.TBnmiembro)
        Me.Pdatosmiembro.Location = New System.Drawing.Point(12, 35)
        Me.Pdatosmiembro.Name = "Pdatosmiembro"
        Me.Pdatosmiembro.Size = New System.Drawing.Size(721, 157)
        Me.Pdatosmiembro.TabIndex = 3
        '
        'Bcomprobardni
        '
        Me.Bcomprobardni.Location = New System.Drawing.Point(428, 6)
        Me.Bcomprobardni.Name = "Bcomprobardni"
        Me.Bcomprobardni.Size = New System.Drawing.Size(75, 23)
        Me.Bcomprobardni.TabIndex = 20
        Me.Bcomprobardni.Text = "Comprobar"
        Me.Bcomprobardni.UseVisualStyleBackColor = True
        '
        'TBtelefono2
        '
        Me.TBtelefono2.Location = New System.Drawing.Point(189, 126)
        Me.TBtelefono2.Name = "TBtelefono2"
        Me.TBtelefono2.Size = New System.Drawing.Size(120, 20)
        Me.TBtelefono2.TabIndex = 19
        '
        'TBtelefono1
        '
        Me.TBtelefono1.Location = New System.Drawing.Point(63, 126)
        Me.TBtelefono1.Name = "TBtelefono1"
        Me.TBtelefono1.Size = New System.Drawing.Size(120, 20)
        Me.TBtelefono1.TabIndex = 18
        '
        'Ltelefonos
        '
        Me.Ltelefonos.AutoSize = True
        Me.Ltelefonos.Location = New System.Drawing.Point(3, 129)
        Me.Ltelefonos.Name = "Ltelefonos"
        Me.Ltelefonos.Size = New System.Drawing.Size(54, 13)
        Me.Ltelefonos.TabIndex = 17
        Me.Ltelefonos.Text = "Telefonos"
        '
        'TBprovincia
        '
        Me.TBprovincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TBprovincia.Location = New System.Drawing.Point(514, 97)
        Me.TBprovincia.Name = "TBprovincia"
        Me.TBprovincia.Size = New System.Drawing.Size(200, 20)
        Me.TBprovincia.TabIndex = 16
        '
        'Lprovincia
        '
        Me.Lprovincia.AutoSize = True
        Me.Lprovincia.Location = New System.Drawing.Point(455, 100)
        Me.Lprovincia.Name = "Lprovincia"
        Me.Lprovincia.Size = New System.Drawing.Size(51, 13)
        Me.Lprovincia.TabIndex = 15
        Me.Lprovincia.Text = "Provincia"
        '
        'TBlocalidad
        '
        Me.TBlocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TBlocalidad.Location = New System.Drawing.Point(244, 97)
        Me.TBlocalidad.Name = "TBlocalidad"
        Me.TBlocalidad.Size = New System.Drawing.Size(200, 20)
        Me.TBlocalidad.TabIndex = 14
        '
        'Llocalidad
        '
        Me.Llocalidad.AutoSize = True
        Me.Llocalidad.Location = New System.Drawing.Point(185, 100)
        Me.Llocalidad.Name = "Llocalidad"
        Me.Llocalidad.Size = New System.Drawing.Size(53, 13)
        Me.Llocalidad.TabIndex = 13
        Me.Llocalidad.Text = "Localidad"
        '
        'TBcodigopostal
        '
        Me.TBcodigopostal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TBcodigopostal.Location = New System.Drawing.Point(81, 97)
        Me.TBcodigopostal.Name = "TBcodigopostal"
        Me.TBcodigopostal.Size = New System.Drawing.Size(90, 20)
        Me.TBcodigopostal.TabIndex = 12
        '
        'Lcodigopostal
        '
        Me.Lcodigopostal.AutoSize = True
        Me.Lcodigopostal.Location = New System.Drawing.Point(3, 100)
        Me.Lcodigopostal.Name = "Lcodigopostal"
        Me.Lcodigopostal.Size = New System.Drawing.Size(72, 13)
        Me.Lcodigopostal.TabIndex = 11
        Me.Lcodigopostal.Text = "Codigo Postal"
        '
        'Ldireccion
        '
        Me.Ldireccion.AutoSize = True
        Me.Ldireccion.Location = New System.Drawing.Point(3, 72)
        Me.Ldireccion.Name = "Ldireccion"
        Me.Ldireccion.Size = New System.Drawing.Size(52, 13)
        Me.Ldireccion.TabIndex = 10
        Me.Ldireccion.Text = "Dirección"
        '
        'TBdireccion
        '
        Me.TBdireccion.Location = New System.Drawing.Point(61, 69)
        Me.TBdireccion.Name = "TBdireccion"
        Me.TBdireccion.Size = New System.Drawing.Size(653, 20)
        Me.TBdireccion.TabIndex = 9
        '
        'Lapellidos
        '
        Me.Lapellidos.AutoSize = True
        Me.Lapellidos.Location = New System.Drawing.Point(359, 39)
        Me.Lapellidos.Name = "Lapellidos"
        Me.Lapellidos.Size = New System.Drawing.Size(49, 13)
        Me.Lapellidos.TabIndex = 8
        Me.Lapellidos.Text = "Apellidos"
        '
        'TBapellidos
        '
        Me.TBapellidos.Location = New System.Drawing.Point(414, 36)
        Me.TBapellidos.Name = "TBapellidos"
        Me.TBapellidos.Size = New System.Drawing.Size(300, 20)
        Me.TBapellidos.TabIndex = 7
        '
        'Lnombre
        '
        Me.Lnombre.AutoSize = True
        Me.Lnombre.Location = New System.Drawing.Point(3, 39)
        Me.Lnombre.Name = "Lnombre"
        Me.Lnombre.Size = New System.Drawing.Size(44, 13)
        Me.Lnombre.TabIndex = 6
        Me.Lnombre.Text = "Nombre"
        '
        'TBnombre
        '
        Me.TBnombre.Location = New System.Drawing.Point(53, 36)
        Me.TBnombre.Name = "TBnombre"
        Me.TBnombre.Size = New System.Drawing.Size(300, 20)
        Me.TBnombre.TabIndex = 5
        '
        'Ldni
        '
        Me.Ldni.AutoSize = True
        Me.Ldni.Location = New System.Drawing.Point(190, 9)
        Me.Ldni.Name = "Ldni"
        Me.Ldni.Size = New System.Drawing.Size(26, 13)
        Me.Ldni.TabIndex = 4
        Me.Ldni.Text = "DNI"
        '
        'TBdni
        '
        Me.TBdni.Location = New System.Drawing.Point(222, 6)
        Me.TBdni.Name = "TBdni"
        Me.TBdni.Size = New System.Drawing.Size(200, 20)
        Me.TBdni.TabIndex = 3
        '
        'Lpagoinicial
        '
        Me.Lpagoinicial.AutoSize = True
        Me.Lpagoinicial.Location = New System.Drawing.Point(15, 211)
        Me.Lpagoinicial.Name = "Lpagoinicial"
        Me.Lpagoinicial.Size = New System.Drawing.Size(61, 13)
        Me.Lpagoinicial.TabIndex = 21
        Me.Lpagoinicial.Text = "Pago inicial"
        '
        'TBpagoinicial
        '
        Me.TBpagoinicial.Location = New System.Drawing.Point(133, 208)
        Me.TBpagoinicial.Name = "TBpagoinicial"
        Me.TBpagoinicial.Size = New System.Drawing.Size(145, 20)
        Me.TBpagoinicial.TabIndex = 20
        '
        'Lpagoinicialefectuado
        '
        Me.Lpagoinicialefectuado.AutoSize = True
        Me.Lpagoinicialefectuado.Location = New System.Drawing.Point(15, 240)
        Me.Lpagoinicialefectuado.Name = "Lpagoinicialefectuado"
        Me.Lpagoinicialefectuado.Size = New System.Drawing.Size(112, 13)
        Me.Lpagoinicialefectuado.TabIndex = 23
        Me.Lpagoinicialefectuado.Text = "Pago inicial efectuado"
        '
        'TBpagoinicialefectuado
        '
        Me.TBpagoinicialefectuado.Location = New System.Drawing.Point(133, 237)
        Me.TBpagoinicialefectuado.Name = "TBpagoinicialefectuado"
        Me.TBpagoinicialefectuado.Size = New System.Drawing.Size(145, 20)
        Me.TBpagoinicialefectuado.TabIndex = 22
        '
        'Lcuota
        '
        Me.Lcuota.AutoSize = True
        Me.Lcuota.Location = New System.Drawing.Point(555, 211)
        Me.Lcuota.Name = "Lcuota"
        Me.Lcuota.Size = New System.Drawing.Size(35, 13)
        Me.Lcuota.TabIndex = 25
        Me.Lcuota.Text = "Cuota"
        '
        'TBcuota
        '
        Me.TBcuota.Location = New System.Drawing.Point(596, 208)
        Me.TBcuota.Name = "TBcuota"
        Me.TBcuota.Size = New System.Drawing.Size(130, 20)
        Me.TBcuota.TabIndex = 24
        '
        'Lobservaciones
        '
        Me.Lobservaciones.AutoSize = True
        Me.Lobservaciones.Location = New System.Drawing.Point(15, 270)
        Me.Lobservaciones.Name = "Lobservaciones"
        Me.Lobservaciones.Size = New System.Drawing.Size(78, 13)
        Me.Lobservaciones.TabIndex = 27
        Me.Lobservaciones.Text = "Observaciones"
        '
        'TBobservaciones
        '
        Me.TBobservaciones.Location = New System.Drawing.Point(12, 286)
        Me.TBobservaciones.Multiline = True
        Me.TBobservaciones.Name = "TBobservaciones"
        Me.TBobservaciones.Size = New System.Drawing.Size(714, 80)
        Me.TBobservaciones.TabIndex = 26
        '
        'Bcrearmiembro
        '
        Me.Bcrearmiembro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bcrearmiembro.Location = New System.Drawing.Point(626, 372)
        Me.Bcrearmiembro.Name = "Bcrearmiembro"
        Me.Bcrearmiembro.Size = New System.Drawing.Size(100, 36)
        Me.Bcrearmiembro.TabIndex = 28
        Me.Bcrearmiembro.Text = "Crear"
        Me.Bcrearmiembro.UseVisualStyleBackColor = True
        '
        'crearmiembros
        '
        Me.ClientSize = New System.Drawing.Size(743, 420)
        Me.Controls.Add(Me.Bcrearmiembro)
        Me.Controls.Add(Me.Lobservaciones)
        Me.Controls.Add(Me.TBobservaciones)
        Me.Controls.Add(Me.Lcuota)
        Me.Controls.Add(Me.TBcuota)
        Me.Controls.Add(Me.Lpagoinicialefectuado)
        Me.Controls.Add(Me.TBpagoinicialefectuado)
        Me.Controls.Add(Me.Lpagoinicial)
        Me.Controls.Add(Me.Ltitulomiembro)
        Me.Controls.Add(Me.TBpagoinicial)
        Me.Controls.Add(Me.Pdatosmiembro)
        Me.Name = "crearmiembros"
        Me.Text = "Crear miembro"
        Me.Pdatosmiembro.ResumeLayout(False)
        Me.Pdatosmiembro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBnmiembro As TextBox
    Friend WithEvents Ltitulomiembro As Label
    Friend WithEvents Lnmiembro As Label
    Friend WithEvents Pdatosmiembro As Panel
    Friend WithEvents TBprovincia As TextBox
    Friend WithEvents Lprovincia As Label
    Friend WithEvents TBlocalidad As TextBox
    Friend WithEvents Llocalidad As Label
    Friend WithEvents TBcodigopostal As TextBox
    Friend WithEvents Lcodigopostal As Label
    Friend WithEvents Ldireccion As Label
    Friend WithEvents TBdireccion As TextBox
    Friend WithEvents Lapellidos As Label
    Friend WithEvents TBapellidos As TextBox
    Friend WithEvents Lnombre As Label
    Friend WithEvents TBnombre As TextBox
    Friend WithEvents Ldni As Label
    Friend WithEvents TBdni As TextBox
    Friend WithEvents TBtelefono2 As TextBox
    Friend WithEvents TBtelefono1 As TextBox
    Friend WithEvents Ltelefonos As Label
    Friend WithEvents Lpagoinicial As Label
    Friend WithEvents TBpagoinicial As TextBox
    Friend WithEvents Lpagoinicialefectuado As Label
    Friend WithEvents TBpagoinicialefectuado As TextBox
    Friend WithEvents Lcuota As Label
    Friend WithEvents TBcuota As TextBox
    Friend WithEvents Lobservaciones As Label
    Friend WithEvents TBobservaciones As TextBox
    Friend WithEvents Bcrearmiembro As Button
    Friend WithEvents Bcomprobardni As Button
End Class
