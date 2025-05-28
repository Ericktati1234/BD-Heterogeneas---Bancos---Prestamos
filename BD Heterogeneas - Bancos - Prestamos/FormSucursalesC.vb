Public Class FormSucursalesC
    Sub reiniciar()
        LlenaGrid(sqlConexion, dgvSucursales, "use BDHeterogenea exec sp_SeleccionarSucursalPorRegion 3")
        txtActivos.Text = ""
        txtCiudad.Text = ""
        txtNombre.Text = ""
        txtRegion.Text = ""
        lblIdSucursal.Text = "default"
        txtNombre.Enabled = False
        txtCiudad.Enabled = False
        txtRegion.Enabled = False
        txtActivos.Enabled = False
    End Sub

    Private Sub FormPrestamosA_Load(sender As Object, e As EventArgs) Handles Me.Load
        reiniciar()

        dgvSucursales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvSucursales.DefaultCellStyle.Font = New Font("Arial", 12)
        dgvSucursales.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 13, FontStyle.Bold)

        dgvSucursales.RowsDefaultCellStyle.BackColor = Color.White
        dgvSucursales.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        dgvSucursales.EnableHeadersVisualStyles = False
        dgvSucursales.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
        dgvSucursales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvSucursales.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 14, FontStyle.Bold)

        dgvSucursales.AllowUserToAddRows = False
        dgvSucursales.ReadOnly = True

    End Sub


    Private Sub dgvSucursales_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSucursales.SelectionChanged
        If dgvSucursales.CurrentRow IsNot Nothing Then
            Dim idSucursal As Integer = dgvSucursales.CurrentRow.Cells(0).Value
            Dim Nombre As String = dgvSucursales.CurrentRow.Cells(1).Value.ToString
            Dim Ciudad As String = dgvSucursales.CurrentRow.Cells(2).Value.ToString
            Dim Activos As Integer = dgvSucursales.CurrentRow.Cells(3).Value
            Dim Region As String = dgvSucursales.CurrentRow.Cells(4).Value.ToString

            lblIdSucursal.Text = idSucursal
            txtNombre.Text = Nombre
            txtCiudad.Text = Ciudad
            txtActivos.Text = Activos
            txtRegion.Text = Region

        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        FormOpcionesC.Enabled = True
    End Sub

End Class