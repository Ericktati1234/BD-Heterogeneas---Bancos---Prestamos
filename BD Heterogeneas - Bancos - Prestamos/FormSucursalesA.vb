Public Class FormSucursalesA

    Sub reiniciar()
        LlenaGrid(sqlConexion, dgvSucursales, "use BDHeterogenea exec sp_SeleccionarSucursalPorRegion 1")
        txtActivos.Text = ""
        txtCiudad.Text = ""
        txtNombre.Text = ""
        txtRegion.Text = ""
        lblIdSucursal.Text = "default"
        txtNombre.Enabled = False
        txtCiudad.Enabled = False
        txtRegion.Enabled = False
        txtActivos.Enabled = False
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        btnNuevo.Enabled = True
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombre.Enabled = True
        txtNombre.Text = ""
        txtCiudad.Enabled = True
        txtCiudad.Text = ""
        txtRegion.Enabled = True
        txtRegion.Text = ""
        txtActivos.Enabled = True
        txtActivos.Text = ""
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
        btnNuevo.Enabled = False
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombre.Text = "" Or txtCiudad.Text = "" Or txtActivos.Text = "" Or txtRegion.Text = "" Then
            MessageBox.Show("Favor de rellenar todos los campos", "Atencion")
        Else
            If MessageBox.Show("Quieres guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim maxID As Integer = 0
                For Each row As DataGridViewRow In dgvSucursales.Rows
                    If Not row.IsNewRow Then
                        Dim currentID As Integer = Convert.ToInt32(row.Cells(0).Value)
                        If currentID > maxID Then
                            maxID = currentID
                        End If
                    End If
                Next
                Dim nuevoID = maxID + 1
                lblIdSucursal.Text = nuevoID.ToString()

                Dim sqlcmdComando As New SqlClient.SqlCommand
                sqlcmdComando.CommandText = "USE BDHeterogenea EXEC sp_InsertarSucursal " & nuevoID & ",'" & txtNombre.Text & "','" & txtCiudad.Text & "'," & txtActivos.Text & ",'A';"
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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        FormOpcionesA.Enabled = True
    End Sub


End Class