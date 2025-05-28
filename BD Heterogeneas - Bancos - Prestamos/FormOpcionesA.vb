Public Class FormOpcionesA
    Private Sub btnSucursales_Click(sender As Object, e As EventArgs) Handles btnSucursales.Click
        Me.Enabled = False
        FormSucursalesA.Show()
    End Sub

    Private Sub btnPrestamos_Click(sender As Object, e As EventArgs) Handles btnPrestamos.Click
        Me.Enabled = False
        FormPrestamosA.Show()
    End Sub


    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        Me.Enabled = False
        FormReportesA.Show()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        Home.Show()
        Home.Enabled = True
    End Sub

End Class