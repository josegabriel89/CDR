Public Class listarparcelas
    Private Sub listarparcelas_Load(sender As Object, e As EventArgs) Handles MyBase.Closing
        Dim form As New main
        form.Show()
        Me.Hide()
    End Sub

    Private Sub listarparcelas_Load_2(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CDRDSparcela.parcelas' Puede moverla o quitarla según sea necesario.
        Me.ParcelasTableAdapter2.Fill(Me.CDRDSparcela.parcelas)

    End Sub
End Class