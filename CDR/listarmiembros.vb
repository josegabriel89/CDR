Public Class listarmiembros
    Private Sub listarmiembros_Load(sender As Object, e As EventArgs) Handles MyBase.Closing
        Dim form As New main
        form.Show()
        Me.Hide()
    End Sub

    Private Sub listarmiembros_Load_2(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CDRDSMiembros.miembros' Puede moverla o quitarla según sea necesario.
        Me.MiembrosTableAdapter1.Fill(Me.CDRDSMiembros.miembros)

    End Sub
End Class