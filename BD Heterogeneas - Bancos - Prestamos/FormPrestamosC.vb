Public Class FormPrestamosC

    Sub reiniciar()
        LlenaGrid(sqlConexion, dgvPrestamos, "use BDHeterogenea exec sp_SeleccionarPrestamoPorRegion 3")
        txtCantidad.Enabled = False
        txtCantidad.Text = ""
        lblidprestamo.Text = "default"
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        FormOpcionesC.Enabled = True
    End Sub

    Private Sub FormPrestamosA_Load(sender As Object, e As EventArgs) Handles Me.Load
        reiniciar()

        dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvPrestamos.DefaultCellStyle.Font = New Font("Arial", 12)
        dgvPrestamos.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 13, FontStyle.Bold)

        dgvPrestamos.RowsDefaultCellStyle.BackColor = Color.White
        dgvPrestamos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        dgvPrestamos.EnableHeadersVisualStyles = False
        dgvPrestamos.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
        dgvPrestamos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvPrestamos.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 14, FontStyle.Bold)

        dgvPrestamos.AllowUserToAddRows = False
        dgvPrestamos.ReadOnly = True

    End Sub


    Private Sub dgvPrestamos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPrestamos.SelectionChanged
        If dgvPrestamos.CurrentRow IsNot Nothing Then
            Dim idPaquete As Integer = dgvPrestamos.CurrentRow.Cells(0).Value
            Dim Cantidad = dgvPrestamos.CurrentRow.Cells(1).Value

            lblidprestamo.Text = idPaquete
            txtCantidad.Text = Cantidad
        End If
    End Sub

End Class