
Imports ClosedXML.Excel
Imports System.IO
Public Class FormReportesA
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        FormOpcionesA.Enabled = True
    End Sub

    Private Sub btnPrestamos_Click(sender As Object, e As EventArgs) Handles btnPrestamos.Click
        LlenaGrid(sqlConexion, dgvReportes, "use BDHeterogenea exec sp_SeleccionarPrestamoPorRegion 1")
        btnExportar.Enabled = True
    End Sub

    Private Sub FormReportesA_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnExportar.Enabled = False

        dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvReportes.DefaultCellStyle.Font = New Font("Arial", 12)
        dgvReportes.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 13, FontStyle.Bold)

        dgvReportes.RowsDefaultCellStyle.BackColor = Color.White
        dgvReportes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        dgvReportes.EnableHeadersVisualStyles = False
        dgvReportes.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
        dgvReportes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvReportes.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 14, FontStyle.Bold)



        dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvReportes.DefaultCellStyle.Font = New Font("Arial", 12)
        dgvReportes.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 13, FontStyle.Bold)

        dgvReportes.RowsDefaultCellStyle.BackColor = Color.White
        dgvReportes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        dgvReportes.EnableHeadersVisualStyles = False
        dgvReportes.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
        dgvReportes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvReportes.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 14, FontStyle.Bold)


        dgvReportes.RowHeadersVisible = False
        dgvReportes.RowHeadersVisible = False

        dgvReportes.AllowUserToAddRows = False
        dgvReportes.AllowUserToAddRows = False

        dgvReportes.ReadOnly = True
        dgvReportes.ReadOnly = True
        btnExportar.Enabled = True
    End Sub

    Private Sub btnSucursales_Click(sender As Object, e As EventArgs) Handles btnSucursales.Click
        LlenaGrid(sqlConexion, dgvReportes, "use BDHeterogenea exec sp_SeleccionarSucursalPorRegion 1")

    End Sub

    Private Sub ExportarDataGridViewAExcel(dgv As DataGridView, filePath As String)
        Using workbook As New XLWorkbook()
            Dim worksheet = workbook.Worksheets.Add("Datos")

            ' Encabezados
            For col As Integer = 0 To dgv.Columns.Count - 1
                worksheet.Cell(1, col + 1).Value = dgv.Columns(col).HeaderText
            Next

            ' Contenido
            For row As Integer = 0 To dgv.Rows.Count - 1
                For col As Integer = 0 To dgv.Columns.Count - 1
                    worksheet.Cell(row + 2, col + 1).Value = dgv.Rows(row).Cells(col).Value?.ToString()
                Next
            Next

            workbook.SaveAs(filePath)
        End Using
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click

        Using folderDialog As New FolderBrowserDialog
            If folderDialog.ShowDialog = DialogResult.OK Then
                Dim folderPath = folderDialog.SelectedPath

                Dim fileName = InputBox("Escribe el nombre del archivo:", "Nombre del archivo", "Exportacion")
                If Not String.IsNullOrWhiteSpace(fileName) Then
                    Dim fullPath = Path.Combine(folderPath, fileName & ".xlsx")
                    ExportarDataGridViewAExcel(dgvReportes, fullPath)
                    MessageBox.Show("Archivo guardado en:" & vbCrLf & fullPath, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End Using

    End Sub






    'Private Sub FormReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    '    Me.MinimizeBox = False  ' Deshabilita la opción de minimizar
    '    Me.ControlBox = False  ' Deshabilita el cuadro de control (minimizar, maximizar, cerrar)
    '    Me.StartPosition = FormStartPosition.CenterScreen  ' Centra la ventana en la pantalla
    '    Dim pantalla As Screen = Screen.FromControl(Me)
    '    Dim ancho As Integer = pantalla.Bounds.Width
    '    Dim alto As Integer = pantalla.Bounds.Height

    '    Me.MinimumSize = New Size(ancho, alto)


    '    dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    '    dgvReportes.DefaultCellStyle.Font = New Font("Arial", 12)
    '    dgvReportes.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 13, FontStyle.Bold)

    '    dgvReportes.RowsDefaultCellStyle.BackColor = Color.White
    '    dgvReportes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

    '    dgvReportes.EnableHeadersVisualStyles = False
    '    dgvReportes.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
    '    dgvReportes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    '    dgvReportes.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 14, FontStyle.Bold)



    '    dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    '    dgvReportes.DefaultCellStyle.Font = New Font("Arial", 12)
    '    dgvReportes.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 13, FontStyle.Bold)

    '    dgvReportes.RowsDefaultCellStyle.BackColor = Color.White
    '    dgvReportes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

    '    dgvReportes.EnableHeadersVisualStyles = False
    '    dgvReportes.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
    '    dgvReportes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    '    dgvReportes.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 14, FontStyle.Bold)


    '    dgvReportes.RowHeadersVisible = False
    '    dgvReportes.RowHeadersVisible = False

    '    dgvReportes.AllowUserToAddRows = False
    '    dgvReportes.AllowUserToAddRows = False

    '    dgvReportes.ReadOnly = True
    '    dgvReportes.ReadOnly = True

    '    btnExportar.Enabled = False
    'End Sub

    'Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
    '    LlenaGrid(sqlConexion, dgvReportes, "sp_BusquedaClientes 1,NULL")
    '    btnExportar.Enabled = True
    'End Sub

    'Private Sub btnPaquetes_Click(sender As Object, e As EventArgs) Handles btnPaquetes.Click
    '    LlenaGrid(sqlConexion, dgvReportes, "sp_BusquedaPaquetes 1,''")
    '    btnExportar.Enabled = True
    'End Sub

    'Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
    '    LlenaGrid(sqlConexion, dgvReportes, "sp_Empleados_Usuarios_ABM 6,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL")
    '    btnExportar.Enabled = True
    'End Sub

    'Private Sub btnCotizaciones_Click(sender As Object, e As EventArgs)
    '    LlenaGrid(sqlConexion, dgvReportes, "sp_ConsultasAvanzadas 6,NULL,NULL")
    '    btnExportar.Enabled = True
    'End Sub

    'Private Sub btnPagos_Click(sender As Object, e As EventArgs)
    '    LlenaGrid(sqlConexion, dgvReportes, "sp_ConsultasAvanzadas 12,NULL,NULL")
    '    btnExportar.Enabled = True
    'End Sub

    'Private Sub btnAnticipos_Click(sender As Object, e As EventArgs)
    '    LlenaGrid(sqlConexion, dgvReportes, "sp_ConsultasAvanzadas 13,NULL,NULL")
    '    btnExportar.Enabled = True
    'End Sub

    'Private Sub btnExportar_Click(sender As Object, e As EventArgs)
    '    Using folderDialog As New FolderBrowserDialog
    '        If folderDialog.ShowDialog = DialogResult.OK Then
    '            Dim folderPath = folderDialog.SelectedPath

    '            Dim fileName = InputBox("Escribe el nombre del archivo:", "Nombre del archivo", "Exportacion")
    '            If Not String.IsNullOrWhiteSpace(fileName) Then
    '                Dim fullPath = Path.Combine(folderPath, fileName & ".xlsx")
    '                ExportarDataGridViewAExcel(dgvReportes, fullPath)
    '                MessageBox.Show("Archivo guardado en:" & vbCrLf & fullPath, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End If
    '        End If
    '    End Using
    'End Sub

    'Private Sub ExportarDataGridViewAExcel(dgv As DataGridView, filePath As String)
    '    Using workbook As New XLWorkbook()
    '        Dim worksheet = workbook.Worksheets.Add("Datos")

    '        ' Encabezados
    '        For col As Integer = 0 To dgv.Columns.Count - 1
    '            worksheet.Cell(1, col + 1).Value = dgv.Columns(col).HeaderText
    '        Next

    '        ' Contenido
    '        For row As Integer = 0 To dgv.Rows.Count - 1
    '            For col As Integer = 0 To dgv.Columns.Count - 1
    '                worksheet.Cell(row + 2, col + 1).Value = dgv.Rows(row).Cells(col).Value?.ToString()
    '            Next
    '        Next

    '        workbook.SaveAs(filePath)
    '    End Using
    'End Sub

    'Private Sub FormReportes_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
    '    Home.Enabled = True
    'End Sub

    'Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
    '    Close
    '    Home.Enabled = True
    'End Sub
End Class