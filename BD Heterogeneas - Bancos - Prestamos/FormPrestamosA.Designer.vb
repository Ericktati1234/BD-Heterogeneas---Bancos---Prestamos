<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrestamosA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrestamosA))
        PictureBox1 = New PictureBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        lblTitulo = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        txtidSucursal = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        txtCantidad = New TextBox()
        DatosPersonales = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        btnCancelar = New Button()
        btnNuevo = New Button()
        btnGuardar = New Button()
        dgvPrestamos = New DataGridView()
        btnSalir = New Button()
        lblidprestamo = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        CType(dgvPrestamos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(79, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(80, 80)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 46
        PictureBox1.TabStop = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(lblTitulo, 0, 0)
        TableLayoutPanel1.Location = New Point(207, 53)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(342, 48)
        TableLayoutPanel1.TabIndex = 45
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
        lblTitulo.Size = New Size(336, 48)
        lblTitulo.TabIndex = 13
        lblTitulo.Text = "Gestion de Prestamos A"
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 3
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80F))
        TableLayoutPanel3.Controls.Add(txtidSucursal, 1, 1)
        TableLayoutPanel3.Controls.Add(Label3, 1, 0)
        TableLayoutPanel3.Controls.Add(Label1, 0, 0)
        TableLayoutPanel3.Controls.Add(Label2, 2, 0)
        TableLayoutPanel3.Controls.Add(txtCantidad, 2, 1)
        TableLayoutPanel3.Controls.Add(lblidprestamo, 0, 1)
        TableLayoutPanel3.Location = New Point(204, 440)
        TableLayoutPanel3.Margin = New Padding(3, 2, 3, 2)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(799, 44)
        TableLayoutPanel3.TabIndex = 44
        ' 
        ' txtidSucursal
        ' 
        txtidSucursal.BackColor = Color.White
        txtidSucursal.Dock = DockStyle.Fill
        txtidSucursal.Enabled = False
        txtidSucursal.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtidSucursal.Location = New Point(82, 25)
        txtidSucursal.Name = "txtidSucursal"
        txtidSucursal.Size = New Size(73, 25)
        txtidSucursal.TabIndex = 48
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(137), CByte(185), CByte(145))
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(82, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 22)
        Label3.TabIndex = 11
        Label3.Text = "Id Suc"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(137), CByte(185), CByte(145))
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 22)
        Label1.TabIndex = 0
        Label1.Text = "Id"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(137), CByte(185), CByte(145))
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(161, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(635, 22)
        Label2.TabIndex = 1
        Label2.Text = "Cantidad"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtCantidad
        ' 
        txtCantidad.BackColor = Color.White
        txtCantidad.Dock = DockStyle.Fill
        txtCantidad.Enabled = False
        txtCantidad.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtCantidad.Location = New Point(161, 25)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(635, 25)
        txtCantidad.TabIndex = 6
        ' 
        ' DatosPersonales
        ' 
        DatosPersonales.AutoSize = True
        DatosPersonales.BackColor = Color.FromArgb(CByte(205), CByte(207), CByte(228))
        DatosPersonales.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        DatosPersonales.ForeColor = Color.FromArgb(CByte(78), CByte(131), CByte(87))
        DatosPersonales.Location = New Point(568, 76)
        DatosPersonales.Name = "DatosPersonales"
        DatosPersonales.Size = New Size(302, 25)
        DatosPersonales.TabIndex = 43
        DatosPersonales.Text = "Favor de seleccionar una opcion:"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(btnCancelar, 0, 2)
        TableLayoutPanel2.Controls.Add(btnNuevo, 0, 0)
        TableLayoutPanel2.Controls.Add(btnGuardar, 0, 1)
        TableLayoutPanel2.Location = New Point(61, 113)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.Size = New Size(115, 383)
        TableLayoutPanel2.TabIndex = 42
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = Color.FromArgb(CByte(137), CByte(185), CByte(145))
        btnCancelar.Dock = DockStyle.Fill
        btnCancelar.Enabled = False
        btnCancelar.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancelar.Location = New Point(3, 256)
        btnCancelar.Margin = New Padding(3, 2, 3, 2)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(109, 125)
        btnCancelar.TabIndex = 35
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' btnNuevo
        ' 
        btnNuevo.BackColor = Color.FromArgb(CByte(184), CByte(210), CByte(177))
        btnNuevo.Dock = DockStyle.Fill
        btnNuevo.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnNuevo.Location = New Point(3, 2)
        btnNuevo.Margin = New Padding(3, 2, 3, 2)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(109, 123)
        btnNuevo.TabIndex = 0
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(184), CByte(210), CByte(177))
        btnGuardar.Dock = DockStyle.Fill
        btnGuardar.Enabled = False
        btnGuardar.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnGuardar.Location = New Point(3, 129)
        btnGuardar.Margin = New Padding(3, 2, 3, 2)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(109, 123)
        btnGuardar.TabIndex = 34
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' dgvPrestamos
        ' 
        dgvPrestamos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvPrestamos.BackgroundColor = Color.FromArgb(CByte(197), CByte(220), CByte(201))
        dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPrestamos.Location = New Point(207, 115)
        dgvPrestamos.Margin = New Padding(3, 2, 3, 2)
        dgvPrestamos.Name = "dgvPrestamos"
        dgvPrestamos.RowHeadersWidth = 51
        dgvPrestamos.RowTemplate.Height = 29
        dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPrestamos.Size = New Size(796, 311)
        dgvPrestamos.TabIndex = 41
        ' 
        ' btnSalir
        ' 
        btnSalir.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSalir.BackColor = Color.FromArgb(CByte(137), CByte(185), CByte(145))
        btnSalir.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnSalir.Location = New Point(908, 53)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(95, 32)
        btnSalir.TabIndex = 47
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' lblidprestamo
        ' 
        lblidprestamo.AutoSize = True
        lblidprestamo.BackColor = Color.White
        lblidprestamo.Dock = DockStyle.Fill
        lblidprestamo.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblidprestamo.Location = New Point(3, 22)
        lblidprestamo.Name = "lblidprestamo"
        lblidprestamo.Size = New Size(73, 22)
        lblidprestamo.TabIndex = 10
        lblidprestamo.Text = "default"
        lblidprestamo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormPrestamosA
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(33), CByte(57))
        ClientSize = New Size(1053, 545)
        Controls.Add(btnSalir)
        Controls.Add(PictureBox1)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(DatosPersonales)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(dgvPrestamos)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        MinimumSize = New Size(1053, 545)
        Name = "FormPrestamosA"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gestor de Paquetes"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        CType(dgvPrestamos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents DatosPersonales As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents dgvPrestamos As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtidSucursal As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblidprestamo As Label
End Class
