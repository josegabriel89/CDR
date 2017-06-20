Public Class crearparcela

    Private Sub crearparcela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarcampos()
    End Sub

    Private Sub crearparcela_closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Dim form As New main
        form.Show()
        Me.Hide()
    End Sub

    Private Sub Bactualizartitular_Click(sender As Object, e As EventArgs) Handles Bactualizartitular.Click
        actualizartitular()
    End Sub

    Private Sub Bactualizararrendatario_Click(sender As Object, e As EventArgs) Handles Bactualizararrendatario.Click
        actualizararrendatario()
    End Sub

    Private Sub actualizartitular()
        Ltitularnombre.Text = ""
        If TBtitularnumero.Text = "" And TBtitulardni.Text <> "" Then
            TBtitularnumero.Text = nsocioxdni(TBtitulardni.Text)
        End If
        If TBtitularnumero.Text <> "" Then
            Dim nombretitular As String
            nombretitular = nombresocio(TBtitularnumero.Text)
            If nombretitular <> "" Then
                Dim respuestavarias() As String
                respuestavarias = nombretitular.Split(";")
                TBtitulardni.Text = respuestavarias(0)
                Ltitularnombre.Text = respuestavarias(1) + " " + respuestavarias(2)
            Else
                MsgBox("No existe ningun socio con ese numero", MsgBoxStyle.Exclamation, "aviso")
                Ltitularnombre.Text = ""
            End If
        End If
    End Sub

    Private Sub actualizararrendatario()
        Larrendatarionombre.Text = ""
        If TBarrendatarionumero.Text = "" And TBarrendatariodni.Text <> "" Then
            TBarrendatarionumero.Text = nsocioxdni(TBarrendatariodni.Text)
        End If
        If TBarrendatarionumero.Text <> "" Then
            Dim nombrearrendatario As String
            nombrearrendatario = nombresocio(TBarrendatarionumero.Text)
            If nombrearrendatario <> "" Then
                Dim respuestavarias() As String
                respuestavarias = nombrearrendatario.Split(";")
                TBarrendatariodni.Text = respuestavarias(0)
                Larrendatarionombre.Text = respuestavarias(1) + " " + respuestavarias(2)
            Else
                MsgBox("No existe ningun socio con ese numero", MsgBoxStyle.Exclamation, "aviso")
                Larrendatarionombre.Text = ""
            End If
        End If
    End Sub

    'Funcion de obtencion de los datos del socio
    Private Function nombresocio(ByVal codigo As String) As String
        Dim db As New Consulta
        Dim resultado As DataTable
        Dim consulta As String = "SELECT dni, nombre, apellidos FROM miembros WHERE nsocio='" + codigo + "';"
        Dim socio As String = ""
        resultado = db.consulta_reader(consulta)
        If resultado.Rows.Count > 0 Then
            socio = resultado.Rows.Item(0).Item(0).ToString + ";" + resultado.Rows.Item(0).Item(1).ToString + ";" + resultado.Rows.Item(0).Item(2).ToString
        End If
        Return socio
    End Function

    'Funcion para obtener el nsocio si se pone el dni
    Private Function nsocioxdni(ByVal dnidelsocio As String) As String
        Dim db As New Consulta
        Dim resultado As DataTable
        Dim socio As String = ""
        If dnidelsocio <> "" Then
            Dim consulta As String = "SELECT nsocio FROM miembros WHERE dni='" + dnidelsocio + "';"
            resultado = db.consulta_reader(consulta)
            If resultado.Rows.Count = 1 Then
                socio = resultado.Rows.Item(0).Item(0).ToString
            End If
        End If
        Return socio
    End Function

    Private Sub Bcrearparcela_Click(sender As Object, e As EventArgs) Handles Bcrearparcela.Click
        If TBrefernciacatastral.Text <> "" And TBpoligono.Text <> "" And TBparcela.Text <> "" And TBsuperficie.Text <> "" Then
            If comprobarreferencia() Then
                MsgBox("ERROR. La referencia catastral ya existe", MsgBoxStyle.Critical, "ERROR")
            Else
                If TBtitularnumero.Text = "" Then
                    MsgBox("ERROR. Falta un titular para la parcela", MsgBoxStyle.Critical, "ERROR")
                Else
                    Dim m1 As parcela
                    m1 = New parcela(TBrefernciacatastral.Text, TBnumeroparcelaprovincia.Text, TBnumeroparcelamunicipio.Text, TBpoligono.Text, TBparcela.Text, TBtitularnumero.Text,
                                 TBarrendatarionumero.Text, TBsuperficie.Text, TBpago.Text, TBobservacionesparcela.Text)
                    If m1.crearparcela() Then
                        MsgBox("Parcela creada", MsgBoxStyle.Information, "aviso")
                        actualizarcampos()
                    Else
                        MsgBox("ERROR. Parcela no creada", MsgBoxStyle.Critical, "ERROR")
                    End If
                End If
            End If
        End If
    End Sub
    Public Function comprobarreferencia() As Boolean
        Dim bd As New Consulta
        Dim respuesta As Boolean
        Dim consulta As String
        If TBrefernciacatastral.Text = "" Then
            respuesta = False
        Else
            consulta = "SELECT referenciacatastral FROM parcelas WHERE referenciacatastral='" + TBrefernciacatastral.Text + "';"
            respuesta = bd.verificar_existencia(consulta)
        End If
        Return respuesta
    End Function

    Private Sub actualizarcampos()
        TBrefernciacatastral.Text = ""
        TBnumeroparcelaprovincia.Text = "18"
        TBnombreparcelaprovincia.Text = "GRANADA"
        TBnumeroparcelamunicipio.Text = "186"
        TBnombreparcelamunicipio.Text = "UGIJAR"
        TBpoligono.Text = ""
        TBparcela.Text = ""
        TBtitularnumero.Text = ""
        TBtitulardni.Text = ""
        Ltitularnombre.Text = ""
        TBarrendatarionumero.Text = ""
        TBarrendatariodni.Text = ""
        Larrendatarionombre.Text = ""
        TBsuperficie.Text = "0"
        TBpago.Text = "0"
        TBobservacionesparcela.Text = ""
    End Sub
    Private Sub textbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBnumeroparcelaprovincia.KeyPress, TBnumeroparcelamunicipio.KeyPress, TBpoligono.KeyPress, TBparcela.KeyPress, TBtitularnumero.KeyPress, TBarrendatarionumero.KeyPress, TBpago.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBsuperficie_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TBsuperficie.KeyPress
        eventArgs.Handled = KeyPress_Numerosypunto(eventArgs.KeyChar, TBsuperficie.Text)
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

End Class