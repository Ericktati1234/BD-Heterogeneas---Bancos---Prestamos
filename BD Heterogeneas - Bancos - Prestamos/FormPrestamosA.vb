Public Class FormPrestamosA

    Sub reiniciar()
        LlenaGrid(sqlConexion, dgvPrestamos, "use BDHeterogenea exec sp_SeleccionarPrestamoPorRegion 1")
        txtCantidad.Enabled = False
        txtCantidad.Text = ""
        txtidSucursal.Enabled = False
        txtidSucursal.Text = ""
        lblidprestamo.Text = "default"
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        btnNuevo.Enabled = True
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        FormOpcionesA.Enabled = True
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCantidad.Enabled = True
        txtCantidad.Text = ""
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
        btnNuevo.Enabled = False
        txtidSucursal.Enabled = True
        txtidSucursal.Text = ""
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
            Dim idPrestamo As Integer = dgvPrestamos.CurrentRow.Cells(0).Value
            Dim idSucursal As Integer = dgvPrestamos.CurrentRow.Cells(1).Value
            Dim Cantidad = dgvPrestamos.CurrentRow.Cells(2).Value

            lblidprestamo.Text = idPrestamo
            txtidSucursal.Text = idSucursal
            txtCantidad.Text = Cantidad
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtCantidad.Text = "" Or txtidSucursal.Text = "" Then
            MessageBox.Show("Favor de rellenar todos los campos", "Atencion")
        Else
            If MessageBox.Show("Quieres guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim maxID As Integer = 0
                For Each row As DataGridViewRow In dgvPrestamos.Rows
                    If Not row.IsNewRow Then
                        Dim currentID As Integer = Convert.ToInt32(row.Cells(0).Value)
                        If currentID > maxID Then
                            maxID = currentID
                        End If
                    End If
                Next
                Dim nuevoID = maxID + 1
                lblidprestamo.Text = nuevoID.ToString()

                Dim sqlcmdComando As New SqlClient.SqlCommand
                sqlcmdComando.CommandText = "USE BDHeterogenea EXEC sp_InsertarPrestamo " & nuevoID & "," & txtidSucursal.Text & "," & txtCantidad.Text & ";"
                sqlcmdComando.Connection = sqlConexion
                Dim sqldrDatos As SqlClient.SqlDataReader
                sqldrDatos = sqlcmdComando.ExecuteReader
                sqldrDatos.Read()
                sqldrDatos.Close()
                MessageBox.Show("Se han guardado los cambios con Exito!", "EXITO")
                reiniciar()
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("Seguro que quieres cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            reiniciar()
        End If
    End Sub

End Class