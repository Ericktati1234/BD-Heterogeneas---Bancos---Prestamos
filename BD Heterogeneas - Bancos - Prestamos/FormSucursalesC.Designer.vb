<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSucursalesC
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSucursalesC))
        TableLayoutPanel1 = New TableLayoutPanel()
        lblTitulo = New Label()
        dgvSucursales = New DataGridView()
        PictureBox1 = New PictureBox()
        btnSalir = New Button()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtNombre = New TextBox()
        txtCiudad = New TextBox()
        txtActivos = New TextBox()
        txtRegion = New TextBox()
        lblIdSucursal = New Label()
        TableLayoutPanel1.SuspendLayout()
        CType(dgvSucursales, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
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
        TableLayoutPanel1.TabIndex = 39
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
        lblTitulo.Text = "Gestion de sucursales C"
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dgvSucursales
        ' 
        dgvSucursales.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvSucursales.BackgroundColor = Color.FromArgb(CByte(197), CByte(220), CByte(201))
        dgvSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSucursales.Location = New Point(79, 115)
        dgvSucursales.Margin = New Padding(3, 2, 3, 2)
        dgvSucursales.Name = "dgvSucursales"
        dgvSucursales.RowHeadersWidth = 51
        dgvSucursales.RowTemplate.Height = 29
        dgvSucursales.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSucursales.Size = New Size(924, 311)
        dgvSucursales.TabIndex = 35
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(79, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(80, 80)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 40
        PictureBox1.TabStop = False
        ' 
        ' btnSalir
        ' 
        btnSalir.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSalir.BackColor = Color.FromArgb(CByte(137), CByte(185), CByte(145))
        btnSalir.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnSalir.Location = New Point(920, 32)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(95, 32)
        btnSalir.TabIndex = 48
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 5
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.Controls.Add(Label1, 0, 0)
        TableLayoutPanel3.Controls.Add(Label2, 1, 0)
        TableLayoutPanel3.Controls.Add(Label4, 2, 0)
        TableLayoutPanel3.Controls.Add(Label5, 3, 0)
        TableLayoutPanel3.Controls.Add(Label6, 4, 0)
        TableLayoutPanel3.Controls.Add(txtNombre, 1, 1)
        TableLayoutPanel3.Controls.Add(txtCiudad, 2, 1)
        TableLayoutPanel3.Controls.Add(txtActivos, 3, 1)
        TableLayoutPanel3.Controls.Add(txtRegion, 4, 1)
        TableLayoutPanel3.Controls.Add(lblIdSucursal, 0, 1)
        TableLayoutPanel3.Location = New Point(79, 441)
        TableLayoutPanel3.Margin = New Padding(3, 2, 3, 2)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(924, 44)
        TableLayoutPanel3.TabIndex = 50
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
        Label1.Size = New Size(86, 22)
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
        Label2.Location = New Point(95, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(225, 22)
        Label2.TabIndex = 1
        Label2.Text = "Nombre"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(137), CByte(185), CByte(145))
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(326, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(178, 22)
        Label4.TabIndex = 2
        Label4.Text = "Ciudad"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(137), CByte(185), CByte(145))
        Label5.Dock = DockStyle.Fill
        Label5.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(510, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(178, 22)
        Label5.TabIndex = 3
        Label5.Text = "Activos"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(137), CByte(185), CByte(145))
        Label6.Dock = DockStyle.Fill
        Label6.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(694, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(227, 22)
        Label6.TabIndex = 4
        Label6.Text = "Region"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtNombre
        ' 
        txtNombre.BackColor = Color.White
        txtNombre.Dock = DockStyle.Fill
        txtNombre.Enabled = False
        txtNombre.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtNombre.Location = New Point(95, 25)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(225, 25)
        txtNombre.TabIndex = 6
        ' 
        ' txtCiudad
        ' 
        txtCiudad.BackColor = Color.White
        txtCiudad.Dock = DockStyle.Fill
        txtCiudad.Enabled = False
        txtCiudad.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtCiudad.Location = New Point(326, 25)
        txtCiudad.Name = "txtCiudad"
        txtCiudad.Size = New Size(178, 25)
        txtCiudad.TabIndex = 7
        ' 
        ' txtActivos
        ' 
        txtActivos.BackColor = Color.White
        txtActivos.Dock = DockStyle.Fill
        txtActivos.Enabled = False
        txtActivos.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtActivos.Location = New Point(510, 25)
        txtActivos.Name = "txtActivos"
        txtActivos.Size = New Size(178, 25)
        txtActivos.TabIndex = 8
        ' 
        ' txtRegion
        ' 
        txtRegion.BackColor = Color.White
        txtRegion.Dock = DockStyle.Fill
        txtRegion.Enabled = False
        txtRegion.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtRegion.Location = New Point(694, 25)
        txtRegion.Name = "txtRegion"
        txtRegion.Size = New Size(227, 25)
        txtRegion.TabIndex = 9
        ' 
        ' lblIdSucursal
        ' 
        lblIdSucursal.AutoSize = True
        lblIdSucursal.BackColor = Color.White
        lblIdSucursal.Dock = DockStyle.Fill
        lblIdSucursal.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblIdSucursal.Location = New Point(3, 22)
        lblIdSucursal.Name = "lblIdSucursal"
        lblIdSucursal.Size = New Size(86, 22)
        lblIdSucursal.TabIndex = 10
        lblIdSucursal.Text = "default"
        lblIdSucursal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormSucursalesC
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(33), CByte(57))
        ClientSize = New Size(1053, 545)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(btnSalir)
        Controls.Add(PictureBox1)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(dgvSucursales)
        FormBorderStyle = FormBorderStyle.None
        MinimumSize = New Size(1053, 545)
        Name = "FormSucursalesC"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gestor de Clientes"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(dgvSucursales, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents dgvSucursales As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents txtActivos As TextBox
    Friend WithEvents txtRegion As TextBox
    Friend WithEvents lblIdSucursal As Label
End Class
