Public Class FormUsuariosALTA
    'Sub Reiniciar()
    '    txtUsuario.Enabled = True
    '    txtUsuario.Text = ""
    '    txtContraseña.Enabled = False
    '    txtContraseña.Text = ""
    '    CheckAdmin.Enabled = False
    '    CheckAdmin.Checked = False
    '    CheckContador.Enabled = False
    '    CheckContador.Checked = False
    '    btnVerificar.Enabled = True
    '    btnConfirmar.Enabled = False
    'End Sub

    'Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click

    '    If String.IsNullOrWhiteSpace(txtUsuario.Text) Then
    '        MessageBox.Show("Favor de rellenar todos los campos", "Error")
    '    Else
    '        If MessageBox.Show("Tu Usuario va a ser: '" & txtUsuario.Text & "'. Estas seguro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '            Dim sqlcmdComando As New SqlClient.SqlCommand
    '            sqlcmdComando.CommandText = "sp_Empleados_Usuarios_ABM 5,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'" & txtUsuario.Text & "',NULL"
    '            sqlcmdComando.Connection = sqlConexion
    '            Dim sqldrDatos As SqlClient.SqlDataReader
    '            sqldrDatos = sqlcmdComando.ExecuteReader
    '            sqldrDatos.Read()

    '            Dim Resultado = sqldrDatos.GetValue(0)

    '            If Resultado = 1 Then
    '                MessageBox.Show("El nombre de usuario ya existe", "Error")
    '            Else
    '                If MessageBox.Show("El usuario '" & txtUsuario.Text & "' Esta disponible, ¿Quieres elegirlo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '                    txtContraseña.Enabled = True
    '                    txtUsuario.Enabled = False
    '                    btnVerificar.Enabled = False
    '                    btnConfirmar.Enabled = True
    '                    CheckAdmin.Enabled = True
    '                    CheckContador.Enabled = True

    '                End If
    '            End If
    '            sqldrDatos.Close()
    '        End If
    '    End If




    'End Sub

    'Private Sub FormUsuariosALTA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Reiniciar()
    'End Sub

    'Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
    '    If MessageBox.Show("Seguro que quieres reiniciar la alta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '        Reiniciar()
    '    End If
    'End Sub

    'Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
    '    If String.IsNullOrWhiteSpace(txtContraseña.Text) Then
    '        MessageBox.Show("Favor de rellenar todos los campos", "Error")
    '    Else
    '        If MessageBox.Show("Tu Usuario va a ser: '" & txtUsuario.Text & "' y tu Contraseña: '" & txtContraseña.Text & "'. Estas seguro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '            UsuarioALTA = txtUsuario.Text
    '            ContraseñaALTA = txtContraseña.Text
    '            If CheckContador.Checked Then
    '                RolALTA = "Contador"
    '            ElseIf CheckAdmin.Checked Then
    '                RolALTA = "Administrador"
    '            Else
    '                RolALTA = "Fotógrafo"
    '            End If
    '            formEmpleadosALTA.Show()
    '            FormSeleccionSucursal.lblNombreUsuario.Text = txtUsuario.Text
    '            Me.Close()
    '        End If
    '    End If


    'End Sub

    'Private Sub CheckAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAdmin.CheckedChanged
    '    If CheckAdmin.Checked Then
    '        CheckContador.Enabled = False
    '    Else
    '        CheckContador.Enabled = True
    '    End If
    'End Sub

    'Private Sub CheckContador_CheckedChanged(sender As Object, e As EventArgs) Handles CheckContador.CheckedChanged
    '    If CheckContador.Checked Then
    '        CheckAdmin.Enabled = False
    '    Else
    '        CheckAdmin.Enabled = True
    '    End If
    'End Sub

    'Private Sub FormUsuariosALTA_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
    '    FormUsuariosVisualizar.Enabled = True
    'End Sub

    'Private Sub btnVerificarEditado_Click(sender As Object, e As EventArgs) Handles btnVerificarEditado.Click
    '    If String.IsNullOrWhiteSpace(txtUsuario.Text) Then
    '        MessageBox.Show("Favor de rellenar todos los campos", "Error")
    '    Else
    '        Dim sqlcmdComando As New SqlClient.SqlCommand
    '        sqlcmdComando.CommandText = "sp_Empleados_Usuarios_ABM 7,NULL," & idALTA & ",NULL,NULL,NULL,NULL,NULL,NULL,'" & txtUsuario.Text & "',NULL"
    '        sqlcmdComando.Connection = sqlConexion
    '        Dim sqldrDatos As SqlClient.SqlDataReader
    '        sqldrDatos = sqlcmdComando.ExecuteReader
    '        sqldrDatos.Read()

    '        Dim Resultado = sqldrDatos.GetValue(0)

    '        If Resultado = 1 Then
    '            MessageBox.Show("El nombre de usuario ya existe", "Error")
    '        Else
    '            If MessageBox.Show("El usuario '" & txtUsuario.Text & "' Esta disponible, ¿Quieres elegirlo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '                txtContraseña.Enabled = True
    '                txtUsuario.Enabled = False
    '                btnVerificar.Enabled = False
    '                btnConfirmar.Enabled = True
    '                CheckAdmin.Enabled = True
    '                CheckContador.Enabled = True

    '            End If
    '        End If
    '        sqldrDatos.Close()
    '    End If
    'End Sub
End Class