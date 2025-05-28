<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOpcionesC
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
        TableLayoutPanel1 = New TableLayoutPanel()
        lblTitulo = New Label()
        layoutBotones = New TableLayoutPanel()
        btnReportes = New Button()
        btnCancelar = New Button()
        btnPrestamos = New Button()
        btnSucursales = New Button()
        TableLayoutPanel1.SuspendLayout()
        layoutBotones.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(lblTitulo, 0, 0)
        TableLayoutPanel1.Location = New Point(40, 44)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(404, 48)
        TableLayoutPanel1.TabIndex = 43
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
        lblTitulo.Size = New Size(398, 48)
        lblTitulo.TabIndex = 13
        lblTitulo.Text = "SELECION DE OPCION - C"
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' layoutBotones
        ' 
        layoutBotones.ColumnCount = 2
        layoutBotones.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        layoutBotones.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        layoutBotones.Controls.Add(btnReportes, 0, 1)
        layoutBotones.Controls.Add(btnCancelar, 1, 1)
        layoutBotones.Controls.Add(btnPrestamos, 1, 0)
        layoutBotones.Controls.Add(btnSucursales, 0, 0)
        layoutBotones.Location = New Point(85, 119)
        layoutBotones.Name = "layoutBotones"
        layoutBotones.RowCount = 2
        layoutBotones.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        layoutBotones.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        layoutBotones.Size = New Size(291, 102)
        layoutBotones.TabIndex = 44
        ' 
        ' btnReportes
        ' 
        btnReportes.BackColor = Color.FromArgb(CByte(137), CByte(185), CByte(145))
        btnReportes.Dock = DockStyle.Left
        btnReportes.FlatStyle = FlatStyle.Flat
        btnReportes.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnReportes.ForeColor = Color.FromArgb(CByte(30), CByte(33), CByte(57))
        btnReportes.Location = New Point(3, 53)
        btnReportes.Margin = New Padding(3, 2, 3, 2)
        btnReportes.Name = "btnReportes"
        btnReportes.Size = New Size(114, 47)
        btnReportes.TabIndex = 47
        btnReportes.Text = "Reportes"
        btnReportes.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = Color.LightGray
        btnCancelar.Dock = DockStyle.Right
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnCancelar.ForeColor = Color.FromArgb(CByte(30), CByte(33), CByte(57))
        btnCancelar.Location = New Point(174, 53)
        btnCancelar.Margin = New Padding(3, 2, 3, 2)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(114, 47)
        btnCancelar.TabIndex = 46
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' btnPrestamos
        ' 
        btnPrestamos.BackColor = Color.FromArgb(CByte(137), CByte(185), CByte(145))
        btnPrestamos.Dock = DockStyle.Right
        btnPrestamos.FlatStyle = FlatStyle.Flat
        btnPrestamos.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrestamos.ForeColor = Color.FromArgb(CByte(30), CByte(33), CByte(57))
        btnPrestamos.Location = New Point(174, 2)
        btnPrestamos.Margin = New Padding(3, 2, 3, 2)
        btnPrestamos.Name = "btnPrestamos"
        btnPrestamos.Size = New Size(114, 47)
        btnPrestamos.TabIndex = 45
        btnPrestamos.Text = "Prestamos"
        btnPrestamos.UseVisualStyleBackColor = False
        ' 
        ' btnSucursales
        ' 
        btnSucursales.BackColor = Color.FromArgb(CByte(137), CByte(185), CByte(145))
        btnSucursales.Dock = DockStyle.Left
        btnSucursales.FlatStyle = FlatStyle.Flat
        btnSucursales.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnSucursales.ForeColor = Color.FromArgb(CByte(30), CByte(33), CByte(57))
        btnSucursales.Location = New Point(3, 2)
        btnSucursales.Margin = New Padding(3, 2, 3, 2)
        btnSucursales.Name = "btnSucursales"
        btnSucursales.Size = New Size(114, 47)
        btnSucursales.TabIndex = 21
        btnSucursales.Text = "Sucursales"
        btnSucursales.UseVisualStyleBackColor = False
        ' 
        ' FormOpcionesC
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(33), CByte(57))
        ClientSize = New Size(474, 250)
        Controls.Add(layoutBotones)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        MaximumSize = New Size(474, 250)
        MinimumSize = New Size(474, 250)
        Name = "FormOpcionesC"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EMPLEADOS"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        layoutBotones.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents AdministradorChBx As CheckBox
    Friend WithEvents FotógrafoChBx As CheckBox
    Friend WithEvents ContadorChBx As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents layoutBotones As TableLayoutPanel
    Friend WithEvents btnSucursales As Button
    Friend WithEvents btnPrestamos As Button
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnCancelar As Button
End Class
