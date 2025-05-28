<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInfo))
        TableLayoutPanel1 = New TableLayoutPanel()
        lblTitulo = New Label()
        lblInfo = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        btnVolver = New Button()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(lblTitulo, 0, 0)
        TableLayoutPanel1.Location = New Point(46, 38)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(404, 48)
        TableLayoutPanel1.TabIndex = 44
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
        lblTitulo.Text = "INFORMACION PROYECTO"
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.Dock = DockStyle.Fill
        lblInfo.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblInfo.ForeColor = SystemColors.ControlText
        lblInfo.Location = New Point(3, 0)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(398, 296)
        lblInfo.TabIndex = 45
        lblInfo.Text = resources.GetString("lblInfo.Text")
        lblInfo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.FromArgb(CByte(197), CByte(220), CByte(201))
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(lblInfo, 0, 0)
        TableLayoutPanel2.Location = New Point(46, 119)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(404, 296)
        TableLayoutPanel2.TabIndex = 46
        ' 
        ' btnVolver
        ' 
        btnVolver.BackColor = Color.FromArgb(CByte(137), CByte(185), CByte(145))
        btnVolver.FlatStyle = FlatStyle.Flat
        btnVolver.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnVolver.ForeColor = Color.FromArgb(CByte(30), CByte(33), CByte(57))
        btnVolver.Location = New Point(190, 431)
        btnVolver.Margin = New Padding(3, 2, 3, 2)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(114, 40)
        btnVolver.TabIndex = 47
        btnVolver.Text = "Volver"
        btnVolver.UseVisualStyleBackColor = False
        ' 
        ' FormInfo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(33), CByte(57))
        ClientSize = New Size(500, 500)
        Controls.Add(btnVolver)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(500, 500)
        MinimumSize = New Size(500, 500)
        Name = "FormInfo"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormInfo"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnVolver As Button
End Class
