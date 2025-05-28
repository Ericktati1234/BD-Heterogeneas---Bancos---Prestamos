<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrestamosC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrestamosC))
        PictureBox1 = New PictureBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        lblTitulo = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label1 = New Label()
        Label2 = New Label()
        txtCantidad = New TextBox()
        lblidprestamo = New Label()
        dgvPrestamos = New DataGridView()
        btnSalir = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
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
        TableLayoutPanel1.Location = New Point(346, 53)
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
        lblTitulo.Text = "Gestion de Prestamos C"
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.Controls.Add(Label1, 0, 0)
        TableLayoutPanel3.Controls.Add(Label2, 1, 0)
        TableLayoutPanel3.Controls.Add(txtCantidad, 1, 1)
        TableLayoutPanel3.Controls.Add(lblidprestamo, 0, 1)
        TableLayoutPanel3.Location = New Point(79, 440)
        TableLayoutPanel3.Margin = New Padding(3, 2, 3, 2)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 47.727272F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 52.272728F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(924, 44)
        TableLayoutPanel3.TabIndex = 44
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
        Label1.Size = New Size(258, 21)
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
        Label2.Location = New Point(267, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(654, 21)
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
        txtCantidad.Location = New Point(267, 24)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(654, 25)
        txtCantidad.TabIndex = 6
        ' 
        ' lblidprestamo
        ' 
        lblidprestamo.AutoSize = True
        lblidprestamo.BackColor = Color.White
        lblidprestamo.Dock = DockStyle.Fill
        lblidprestamo.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblidprestamo.Location = New Point(3, 21)
        lblidprestamo.Name = "lblidprestamo"
        lblidprestamo.Size = New Size(258, 23)
        lblidprestamo.TabIndex = 10
        lblidprestamo.Text = "default"
        lblidprestamo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dgvPrestamos
        ' 
        dgvPrestamos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvPrestamos.BackgroundColor = Color.FromArgb(CByte(197), CByte(220), CByte(201))
        dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPrestamos.Location = New Point(79, 115)
        dgvPrestamos.Margin = New Padding(3, 2, 3, 2)
        dgvPrestamos.Name = "dgvPrestamos"
        dgvPrestamos.RowHeadersWidth = 51
        dgvPrestamos.RowTemplate.Height = 29
        dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPrestamos.Size = New Size(924, 311)
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
        ' FormPrestamosC
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(33), CByte(57))
        ClientSize = New Size(1053, 545)
        Controls.Add(btnSalir)
        Controls.Add(PictureBox1)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(dgvPrestamos)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        MinimumSize = New Size(1053, 545)
        Name = "FormPrestamosC"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gestor de Paquetes"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        CType(dgvPrestamos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblidprestamo As Label
    Friend WithEvents dgvPrestamos As DataGridView
    Friend WithEvents btnSalir As Button
End Class
