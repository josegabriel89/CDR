Public Class crearmiembros
    Private Sub Bcrearmiembro_Click(sender As Object, e As EventArgs) Handles Bcrearmiembro.Click

        If TBnmiembro.Text <> "" And TBnombre.Text <> "" Then
            If TBdni.Text = "" Then
                If insertarsindni() Then
                    If MsgBox("Hay una persona con ese mismo nombre" + vbCrLf + "¿Desea guardar de todas formas el socio?", MsgBoxStyle.YesNo, "ATENCION") = vbNo Then
                        Exit Sub
                    End If
                End If
            End If
            If comprobardni() Then
                    MsgBox("ERROR. El DNI ya existe", MsgBoxStyle.Critical, "ERROR")
                ElseIf (TBdni.Text.Count > 10) Then
                    MsgBox("Tamaño del DNI demasiado largo", MsgBoxStyle.Critical, "ERROR")
                Else
                    Dim m1 As miembro
                    'm1 = New miembro()
                    m1 = New miembro(TBnmiembro.Text, TBdni.Text, TBnombre.Text, TBapellidos.Text, TBdireccion.Text, TBcodigopostal.Text, TBlocalidad.Text, TBprovincia.Text, TBtelefono1.Text,
                                TBtelefono2.Text, TBpagoinicial.Text, TBpagoinicialefectuado.Text, TBcuota.Text, TBobservaciones.Text)
                    'm1 = New miembro(Convert.ToInt64(TBnmiembro.Text),
                    '                 TBdni.Text, TBnombre.Text,
                    '                 TBapellidos.Text, TBdireccion.Text,
                    '                 Convert.ToInt64(TBcodigopostal.Text),
                    '                 TBlocalidad.Text, TBprovincia.Text,
                    '                 Convert.ToInt64(TBtelefono1.Text),
                    '                 Convert.ToInt64(TBtelefono2.Text),
                    '                 Convert.ToDouble(TBpagoinicial.Text),
                    '                 Convert.ToDouble(TBpagoinicialefectuado.Text),
                    '                 Convert.ToDouble(TBcuota.Text),
                    '                 TBobservaciones.Text)
                    If m1.crearmiembro() Then
                        MsgBox("Miembro creado", MsgBoxStyle.Information, "aviso")
                        actualizar()
                    Else
                        MsgBox("ERROR. Miembro no creado", MsgBoxStyle.Critical, "ERROR")
                    End If
                End If
            End If

    End Sub

    Private Sub crearmiembros_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Dim form As New main
        form.Show()
        Me.Hide()
    End Sub

    Private Sub crearmiembros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizar()
    End Sub

    Private Sub actualizar()
        Dim bd As New Consulta
        TBnmiembro.Text = bd.nuevonumero()
        TBdni.Text = ""
        TBnombre.Text = ""
        TBapellidos.Text = ""
        TBdireccion.Text = ""
        TBcodigopostal.Text = ""
        TBlocalidad.Text = ""
        TBprovincia.Text = ""
        TBtelefono1.Text = ""
        TBtelefono2.Text = ""
        TBpagoinicial.Text = "0"
        TBpagoinicialefectuado.Text = "0"
        TBcuota.Text = "0"
        'TBobservaciones.Text = ""
    End Sub

    Private Sub textbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBtelefono1.KeyPress, TBtelefono2.KeyPress, TBcodigopostal.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBpagoinicial_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TBpagoinicial.KeyPress
        eventArgs.Handled = KeyPress_Numerosypunto(eventArgs.KeyChar, TBpagoinicial.Text)
    End Sub
    Private Sub TBpagoinicialefectuado_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TBpagoinicialefectuado.KeyPress
        eventArgs.Handled = KeyPress_Numerosypunto(eventArgs.KeyChar, TBpagoinicialefectuado.Text)
    End Sub
    Private Sub TBcuota_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TBcuota.KeyPress
        eventArgs.Handled = KeyPress_Numerosypunto(eventArgs.KeyChar, TBcuota.Text)
    End Sub

    Function KeyPress_Numerosypunto(ByVal Digito As String, ByVal texto As String) As Boolean
        Dim respuesta As Boolean
        If Not IsNumeric(Digito) Then
            respuesta = True
        End If
        If Digito = vbBack Then
            respuesta = False
        End If
        If Digito = "."c Then
            If texto.IndexOf(".") = -1 Then
                respuesta = False
            End If
        End If
        Return respuesta

    End Function

    Private Sub Bcomprobardni_Click(sender As Object, e As EventArgs) Handles Bcomprobardni.Click
        If comprobardni() Then
            MsgBox("ERROR. El DNI ya existe", MsgBoxStyle.Critical, "ERROR")
        End If

    End Sub

    Public Function comprobardni() As Boolean
        Dim bd As New Consulta
        Dim respuesta As Boolean
        Dim consulta As String
        If TBdni.Text = "" Then
            respuesta = False
        Else
            consulta = "SELECT dni FROM miembros WHERE dni='" + TBdni.Text + "';"
            respuesta = bd.verificar_existencia(consulta)
        End If
        Return respuesta
    End Function
    Public Function insertarsindni() As Boolean
        Dim bd As New Consulta
        Dim respuesta As Boolean
        Dim consulta As String
        consulta = "SELECT nombre,apellidos FROM miembros WHERE nombre like '" + TBnombre.Text + "' and apellidos like '" + TBapellidos.Text + "';"
        respuesta = bd.verificar_existencia(consulta)
        Return respuesta
    End Function
End Class


