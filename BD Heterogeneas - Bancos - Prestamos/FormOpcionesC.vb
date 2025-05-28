Public Class FormOpcionesC

    Private Sub btnSucursales_Click(sender As Object, e As EventArgs) Handles btnSucursales.Click
        Me.Enabled = False
        FormSucursalesC.Show()
    End Sub

    Private Sub btnPrestamos_Click(sender As Object, e As EventArgs) Handles btnPrestamos.Click
        Me.Enabled = False
        FormPrestamosC.Show()
    End Sub


    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        Me.Enabled = False
        FormReportesC.Show()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        Home.Show()
        Home.Enabled = True
    End Sub

    'Sub reiniciar()
    '    txtNombreEmpleado.Text = ""
    '    txtApellidoPa.Text = ""
    '    txtApellidoMa.Text = ""
    '    txtCorreo.Text = ""
    '    numTelefono.Value = 1000000000
    '    lblFecha.Text = "default"
    'End Sub
    'Private Sub NuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    CalendarioNacimiento.MaxDate = Today
    '    numTelefono.Minimum = 1000000000
    '    numTelefono.Maximum = 10000000000
    '    reiniciar()
    'End Sub

    'Private Sub CambiarUsuario_Click(sender As Object, e As EventArgs)
    '    If MessageBox.Show("Estas seguro de cambiar el Usuario, tus cambios en esta ventana no se guardaran", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '        FormUsuariosALTA.Show
    '        Close
    '    End If

    'End Sub

    'Private Sub btnAlta_Click(sender As Object, e As EventArgs)
    '    If String.IsNullOrWhiteSpace(txtNombreEmpleado.Text) Or String.IsNullOrWhiteSpace(txtApellidoPa.Text) Or String.IsNullOrWhiteSpace(txtApellidoMa.Text) Or numTelefono.Value = 0 Or lblFecha.Text = "default" Then
    '        MessageBox.Show("Favor de rellenar todos los campos", "Atencion")
    '    Else
    '        If MessageBox.Show("Quieres dar de alta el nuevo empleado? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '            Dim sqlcmdComando As New SqlClient.SqlCommand
    '            sqlcmdComando.CommandText = "sp_Empleados_Usuarios_ABM 1,NULL,NULL,'" & txtNombreEmpleado.Text & "','" & txtApellidoPa.Text & "  " & txtApellidoMa.Text & "','" & RolALTA & "','" & Convert.ToDateTime(lblFecha.Text).ToString("yyyy-MM-dd") & "'," & numTelefono.Value & ",'" & txtCorreo.Text & "','" & UsuarioALTA & "','" & ContraseñaALTA & "'"
    '            sqlcmdComando.Connection = sqlConexion
    '            Dim sqldrDatos As SqlClient.SqlDataReader
    '            sqldrDatos = sqlcmdComando.ExecuteReader
    '            sqldrDatos.Read
    '            sqldrDatos.Close
    '            MessageBox.Show("Se ha dado de alta el Empleado y su usuario con Exito!", "EXITO")
    '            Close
    '            LlenaGrid(sqlConexion, FormUsuariosVisualizar.dgvUsuariosEmpleados, "sp_Empleados_Usuarios_ABM 6,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL")
    '            FormUsuariosVisualizar.Enabled = True
    '        End If
    '    End If
    'End Sub

    'Private Sub CalendarioNacimiento_DateSelected(sender As Object, e As DateRangeEventArgs)
    '    lblFecha.Text = e.Start.Date
    'End Sub

    'Private Sub btnReiniciar_Click(sender As Object, e As EventArgs)
    '    If MessageBox.Show("Quieres reiniciar los datos de empleado? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '        reiniciar
    '    End If
    'End Sub

    'Private Sub btnEditar_Click(sender As Object, e As EventArgs)
    '    If String.IsNullOrWhiteSpace(txtNombreEmpleado.Text) Or String.IsNullOrWhiteSpace(txtApellidoPa.Text) Or String.IsNullOrWhiteSpace(txtApellidoMa.Text) Or numTelefono.Value = 0 Or lblFecha.Text = "default" Then
    '        MessageBox.Show("Favor de rellenar todos los campos", "Atencion")
    '    Else
    '        If MessageBox.Show("Quieres editar a este empleado? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '            Dim sqlcmdComando As New SqlClient.SqlCommand
    '            sqlcmdComando.CommandText = "sp_Empleados_Usuarios_ABM 2," & idEmpleado & "," & idALTA & ",'" & txtNombreEmpleado.Text & "','" & txtApellidoPa.Text & "  " & txtApellidoMa.Text & "','" & RolALTA & "','" & Convert.ToDateTime(lblFecha.Text).ToString("yyyy-MM-dd") & "'," & numTelefono.Value & ",'" & txtCorreo.Text & "','" & UsuarioALTA & "','" & ContraseñaALTA & "'"
    '            sqlcmdComando.Connection = sqlConexion
    '            Dim sqldrDatos As SqlClient.SqlDataReader
    '            sqldrDatos = sqlcmdComando.ExecuteReader
    '            sqldrDatos.Read
    '            sqldrDatos.Close
    '            MessageBox.Show("Se ha modificado el usuario con exito!", "EXITO")
    '            Close
    '            LlenaGrid(sqlConexion, FormUsuariosVisualizar.dgvUsuariosEmpleados, "sp_Empleados_Usuarios_ABM 6,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL")
    '            FormUsuariosVisualizar.Enabled = True
    '        End If
    '    End If
    'End Sub

    'Private Sub formEmpleadosALTA_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
    '    FormUsuariosVisualizar.Enabled = True
    'End Sub
End Class