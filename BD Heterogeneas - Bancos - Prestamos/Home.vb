
Imports System.Net
Imports System.Data.SqlClient


Public Class Home
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        FormInfo.Show()
        Me.Enabled = False
    End Sub

    Private Sub btnRegionA_Click(sender As Object, e As EventArgs) Handles btnRegionA.Click
        Me.Enabled = False
        FormOpcionesA.Show()
    End Sub

    Private Sub btnRegionB_Click(sender As Object, e As EventArgs) Handles btnRegionB.Click
        Me.Enabled = False
        FormOpcionesB.Show()
    End Sub

    Private Sub btnRegionC_Click(sender As Object, e As EventArgs) Handles btnRegionC.Click
        Me.Enabled = False
        FormOpcionesC.Show()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load
        sqlConexion = New SqlClient.SqlConnection
        sqlConexion.ConnectionString = "Data Source=localhost;Initial Catalog=BDHeterogenea;Integrated Security=True;"
        sqlConexion.Open()
    End Sub



    'Sub llenadoGrid()
    '    LlenaGrid(sqlConexion, DgvAgendados, "sp_ConsultasAvanzadas 2,''," & IdUsuario)
    '    LlenaGrid(sqlConexion, DgvFinalizados, "sp_ConsultasAvanzadas 1,''," & IdUsuario)
    '    'Configurar DataGridView(Ajuste automático de columnas y fuente)
    '    DgvAgendados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    '    DgvAgendados.DefaultCellStyle.Font = New Font("Arial", 12)
    '    DgvAgendados.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 13, FontStyle.Bold)

    '    DgvAgendados.RowsDefaultCellStyle.BackColor = Color.White
    '    DgvAgendados.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

    '    DgvAgendados.EnableHeadersVisualStyles = False
    '    DgvAgendados.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
    '    DgvAgendados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    '    DgvAgendados.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 14, FontStyle.Bold)



    '    DgvFinalizados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    '    DgvFinalizados.DefaultCellStyle.Font = New Font("Arial", 12)
    '    DgvFinalizados.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 13, FontStyle.Bold)

    '    DgvFinalizados.RowsDefaultCellStyle.BackColor = Color.White
    '    DgvFinalizados.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

    '    DgvFinalizados.EnableHeadersVisualStyles = False
    '    DgvFinalizados.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
    '    DgvFinalizados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    '    DgvFinalizados.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 14, FontStyle.Bold)


    '    DgvAgendados.RowHeadersVisible = False
    '    DgvFinalizados.RowHeadersVisible = False

    '    DgvAgendados.AllowUserToAddRows = False
    '    DgvFinalizados.AllowUserToAddRows = False

    '    DgvAgendados.ReadOnly = True
    '    DgvFinalizados.ReadOnly = True
    'End Sub
    'Private Sub PausaVentana()
    '    Me.Enabled = False
    'End Sub
    'Private Sub Reinicio()
    '    TSMIHome.Visible = False
    'End Sub
    'Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    ' Deshabilita la opción de maximizar (aunque la ventana estará maximizada)
    '    Me.MinimizeBox = False  ' Deshabilita la opción de minimizar
    '    Me.ControlBox = False  ' Deshabilita el cuadro de control (minimizar, maximizar, cerrar)
    '    Me.StartPosition = FormStartPosition.CenterScreen  ' Centra la ventana en la pantalla
    '    Dim pantalla As Screen = Screen.FromControl(Me)
    '    Dim ancho As Integer = pantalla.Bounds.Width
    '    Dim alto As Integer = pantalla.Bounds.Height

    '    Me.MinimumSize = New Size(ancho, alto)

    '    ' Se configura el Titulo de la Ventana del Home
    '    Me.Text = "BIENVENIDO " & NombreUsuario

    '    lblTitulo.Text = "Hola " & NombreUsuario & "!"

    '    llenadoGrid()


    'End Sub

    'Private Sub AltaDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    FormUsuariosVisualizar.Show
    '    PausaVentana
    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGestionSucursal.Click
    '    PausaVentana()
    '    MessageBox.Show("Elige un cliente por favor", "Atencion")
    '    LimpiarRegistros()
    '    FormBusquedaClientes.Show()
    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
    '    FormIniciarSesión.Show
    '    Close
    'End Sub

    'Private Sub Home_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
    '    FormIniciarSesión.Show()
    'End Sub

    'Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    FormClientesVisualizar.Show
    '    Enabled = False
    'End Sub

    'Private Sub DgvFinalizados_SelectionChanged(sender As Object, e As EventArgs)
    '    If DgvFinalizados.CurrentRow IsNot Nothing Then
    '        Dim IdCliente As Integer = DgvFinalizados.CurrentRow.Cells(0).Value
    '        Dim NombreCliente = DgvFinalizados.CurrentRow.Cells(2).Value.ToString
    '        Dim Paquete = DgvFinalizados.CurrentRow.Cells(3).Value.ToString
    '        Dim FechaRealizacion = DgvFinalizados.CurrentRow.Cells(6).Value.ToString
    '        Dim FechaEntrega = DgvFinalizados.CurrentRow.Cells(7).Value.ToString
    '        Dim Faltante As Double = DgvFinalizados.CurrentRow.Cells(9).Value

    '        lblIDPago.Text = IdCliente
    '        lblCliente.Text = NombreCliente
    '        lblPaquete.Text = Paquete
    '        lblRealizacion.Text = Convert.ToDateTime(FechaRealizacion).ToString("yyyy-MM-dd")
    '        lblEntrega.Text = Convert.ToDateTime(FechaEntrega).ToString("yyyy-MM-dd")
    '        lblFaltante.Text = Faltante
    '    End If
    'End Sub

    'Private Sub btnGestionarSesion_Click(sender As Object, e As EventArgs)

    '    If lblIDPago.Text = "default" Then
    '        MessageBox.Show("Selecciona una sesion para realizar el pago", "Atencion")
    '    Else
    '        If MessageBox.Show("Deseas realizar un pago a la sesion seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '            idSesion = DgvFinalizados.CurrentRow.Cells(0).Value
    '            Faltante = DgvFinalizados.CurrentRow.Cells(9).Value
    '            Enabled = False
    '            FormPagos.Show

    '        Else
    '            MessageBox.Show("Pago cancelada", "Atencion")
    '        End If
    '    End If


    'End Sub

    'Private Sub btnGestionImagenes_Click(sender As Object, e As EventArgs) Handles btnGestionImagenes.Click
    '    Me.Enabled = False
    '    GestorImagenesForm.Show()
    'End Sub

    'Private Sub OptPaquetes_Click(sender As Object, e As EventArgs)
    '    FormPaquetesVisualizar.Show
    '    Enabled = False
    'End Sub

    'Private Sub btnEliminarSesionAgendada_Click(sender As Object, e As EventArgs) Handles btnEliminarSesionAgendada.Click
    '    If lblIdEditar.Text = "default" Then
    '        MessageBox.Show("Selecciona una sesion para eliminar", "Atencion")
    '    Else
    '        If MessageBox.Show("Estas seguro de eliminar esa sesion asignada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '            Dim sqlcmdComando As New SqlClient.SqlCommand
    '            sqlcmdComando.CommandText = "sp_Cotizaciones_ABM 3," & lblIdEditar.Text & ",NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL"
    '            sqlcmdComando.Connection = sqlConexion
    '            Dim sqldrDatos As SqlClient.SqlDataReader
    '            sqldrDatos = sqlcmdComando.ExecuteReader
    '            sqldrDatos.Read()
    '            sqldrDatos.Close()
    '            MessageBox.Show("ELIMINACION REALIZADA CON EXITO", "EXITO")
    '            llenadoGrid()
    '        Else
    '            MessageBox.Show("Eliminacion cancelada", "Atencion")
    '        End If
    '    End If

    'End Sub

    'Private Sub DgvAgendados_SelectionChanged(sender As Object, e As EventArgs)
    '    If DgvAgendados.CurrentRow IsNot Nothing Then
    '        Dim IdCliente As Integer = DgvAgendados.CurrentRow.Cells(0).Value
    '        Dim NombreCliente = DgvAgendados.CurrentRow.Cells(2).Value.ToString
    '        Dim Paquete = DgvAgendados.CurrentRow.Cells(3).Value.ToString
    '        Dim FechaRealizacion = DgvAgendados.CurrentRow.Cells(6).Value.ToString
    '        Dim FechaEntrega = DgvAgendados.CurrentRow.Cells(7).Value.ToString
    '        Dim Faltante As Double = DgvAgendados.CurrentRow.Cells(9).Value

    '        lblIdEditar.Text = IdCliente
    '        lblClienteEditar.Text = NombreCliente
    '        lblPaqueteEditar.Text = Paquete
    '        lblRealizadoEditar.Text = Convert.ToDateTime(FechaRealizacion).ToString("yyyy-MM-dd")
    '        lblEntregaEditar.Text = Convert.ToDateTime(FechaEntrega).ToString("yyyy-MM-dd")
    '        lblFaltanteEditar.Text = Faltante
    '    End If
    'End Sub

    'Private Sub OptReportes_Click(sender As Object, e As EventArgs)
    '    FormReportes.Show
    '    Enabled = False
    'End Sub

    'Private Sub lblTitulo_Click(sender As Object, e As EventArgs)

    'End Sub
End Class