<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportesA
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReportesA))
        btnPrestamos = New Button()
        btnSucursales = New Button()
        TableLayoutPanel2 = New TableLayoutPanel()
        btnExportar = New Button()
        btnSalir = New Button()
        PictureBox1 = New PictureBox()
        DatosPersonales = New Label()
        dgvReportes = New DataGridView()
        TableLayoutPanel1 = New TableLayoutPanel()
        lblTitulo = New Label()
        TableLayoutPanel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvReportes, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnPrestamos
        ' 
        btnPrestamos.BackColor = Color.FromArgb(CByte(184), CByte(210), CByte(177))
        btnPrestamos.Dock = DockStyle.Fill
        btnPrestamos.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrestamos.Location = New Point(3, 2)
        btnPrestamos.Margin = New Padding(3, 2, 3, 2)
        btnPrestamos.Name = "btnPrestamos"
        btnPrestamos.Size = New Size(133, 99)
        btnPrestamos.TabIndex = 0
        btnPrestamos.Text = "Prestamos"
        btnPrestamos.UseVisualStyleBackColor = False
        ' 
        ' btnSucursales
        ' 
        btnSucursales.BackColor = Color.FromArgb(CByte(184), CByte(210), CByte(177))
        btnSucursales.Dock = DockStyle.Fill
        btnSucursales.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnSucursales.Location = New Point(3, 105)
        btnSucursales.Margin = New Padding(3, 2, 3, 2)
        btnSucursales.Name = "btnSucursales"
        btnSucursales.Size = New Size(133, 99)
        btnSucursales.TabIndex = 34
        btnSucursales.Text = "Sucursales"
        btnSucursales.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(btnPrestamos, 0, 0)
        TableLayoutPanel2.Controls.Add(btnSucursales, 0, 1)
        TableLayoutPanel2.Controls.Add(btnExportar, 0, 2)
        TableLayoutPanel2.Location = New Point(45, 154)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857132F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857151F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857151F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(139, 311)
        TableLayoutPanel2.TabIndex = 35
        ' 
        ' btnExportar
        ' 
        btnExportar.BackColor = Color.FromArgb(CByte(137), CByte(185), CByte(145))
        btnExportar.Dock = DockStyle.Fill
        btnExportar.Enabled = False
        btnExportar.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnExportar.Location = New Point(3, 208)
        btnExportar.Margin = New Padding(3, 2, 3, 2)
        btnExportar.Name = "btnExportar"
        btnExportar.Size = New Size(133, 101)
        btnExportar.TabIndex = 39
        btnExportar.Text = "Exportar"
        btnExportar.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSalir.BackColor = Color.FromArgb(CByte(137), CByte(185), CByte(145))
        btnSalir.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnSalir.Location = New Point(888, 42)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(95, 32)
        btnSalir.TabIndex = 38
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(64, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 51
        PictureBox1.TabStop = False
        ' 
        ' DatosPersonales
        ' 
        DatosPersonales.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DatosPersonales.AutoSize = True
        DatosPersonales.BackColor = Color.FromArgb(CByte(205), CByte(207), CByte(228))
        DatosPersonales.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        DatosPersonales.ForeColor = Color.FromArgb(CByte(78), CByte(131), CByte(87))
        DatosPersonales.Location = New Point(491, 53)
        DatosPersonales.Name = "DatosPersonales"
        DatosPersonales.Size = New Size(302, 25)
        DatosPersonales.TabIndex = 49
        DatosPersonales.Text = "Favor de seleccionar una opcion:"
        ' 
        ' dgvReportes
        ' 
        dgvReportes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvReportes.BackgroundColor = Color.FromArgb(CByte(197), CByte(220), CByte(201))
        dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReportes.Location = New Point(211, 99)
        dgvReportes.Margin = New Padding(3, 2, 3, 2)
        dgvReportes.Name = "dgvReportes"
        dgvReportes.RowHeadersWidth = 51
        dgvReportes.RowTemplate.Height = 29
        dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReportes.Size = New Size(801, 366)
        dgvReportes.TabIndex = 48
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(lblTitulo, 0, 0)
        TableLayoutPanel1.Location = New Point(211, 30)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(197, 48)
        TableLayoutPanel1.TabIndex = 52
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.BackColor = Color.FromArgb(CByte(236), CByte(237), CByte(244))
        lblTitulo.Dock = DockStyle.Fill
        lblTitulo.Font = New Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitulo.ForeColor = Color.FromArgb(CByte(137), CByte(185), CByte(145))
        lblTitulo.Location = New Point(3, 0)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(191, 48)
        lblTitulo.TabIndex = 13
        lblTitulo.Text = "REPORTES A"
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormReportesA
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(33), CByte(57))
        ClientSize = New Size(1060, 520)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(PictureBox1)
        Controls.Add(DatosPersonales)
        Controls.Add(dgvReportes)
        Controls.Add(btnSalir)
        Controls.Add(TableLayoutPanel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormReportesA"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reportes"
        TableLayoutPanel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvReportes, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnPrestamos As Button
    Friend WithEvents btnSucursales As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DatosPersonales As Label
    Friend WithEvents dgvReportes As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTitulo As Label
End Class
