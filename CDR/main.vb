Public Class main
    Private Sub Bformcrearmiembro_Click(sender As Object, e As EventArgs) Handles Bformcrearmiembro.Click
        Dim form As New crearmiembros
        form.Show()
        Me.Hide()
    End Sub

    Private Sub Bformlistarmiembros_Click(sender As Object, e As EventArgs) Handles Bformlistarmiembros.Click
        Dim form As New listarmiembros
        form.Show()
        Me.Hide()
    End Sub

    Private Sub Bformcrearparcela_Click(sender As Object, e As EventArgs) Handles Bformcrearparcela.Click
        Dim form As New crearparcela
        form.Show()
        Me.Hide()
    End Sub

    Private Sub Bformlistarparcelas_Click(sender As Object, e As EventArgs) Handles Bformlistarparcelas.Click
        Dim form As New listarparcelas
        form.Show()
        Me.Hide()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

End Class
