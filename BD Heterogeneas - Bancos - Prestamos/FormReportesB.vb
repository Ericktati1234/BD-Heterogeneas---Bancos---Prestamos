
Imports ClosedXML.Excel
Imports System.IO
Public Class FormReportesB
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        FormOpcionesB.Enabled = True
    End Sub
    Private Sub btnPrestamos_Click(sender As Object, e As EventArgs) Handles btnPrestamos.Click
        LlenaGrid(sqlConexion, dgvReportes, "use BDHeterogenea exec sp_SeleccionarPrestamoPorRegion 2")
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
        LlenaGrid(sqlConexion, dgvReportes, "use BDHeterogenea exec sp_SeleccionarSucursalPorRegion 2")

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
End Class