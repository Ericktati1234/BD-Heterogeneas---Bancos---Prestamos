<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        TableLayoutPanel2 = New TableLayoutPanel()
        Label7 = New Label()
        Label8 = New Label()
        btnRegionA = New Button()
        btnSalir = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        lblTitulo = New Label()
        layoutBotones = New TableLayoutPanel()
        btnRegionC = New Button()
        btnRegionB = New Button()
        PictureBox1 = New PictureBox()
        btnInfo = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2.SuspendLayout()
        layoutBotones.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.AutoSize = True
        TableLayoutPanel2.BackColor = Color.Transparent
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel2.Controls.Add(Label7, 0, 0)
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(200, 100)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Location = New Point(3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(47, 15)
        Label7.TabIndex = 10
        Label7.Text = "Usuario"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Location = New Point(3, 15)
        Label8.Name = "Label8"
        Label8.Size = New Size(48, 15)
        Label8.TabIndex = 11
        Label8.Text = "Balance"
        ' 
        ' btnRegionA
        ' 
        btnRegionA.BackColor = Color.FromArgb(CByte(184), CByte(210), CByte(177))
        btnRegionA.Dock = DockStyle.Top
        btnRegionA.FlatStyle = FlatStyle.Flat
        btnRegionA.Font = New Font("Verdana", 12F, FontStyle.Bold)
        btnRegionA.ForeColor = Color.FromArgb(CByte(30), CByte(33), CByte(57))
        btnRegionA.Location = New Point(3, 2)
        btnRegionA.Margin = New Padding(3, 2, 3, 2)
        btnRegionA.Name = "btnRegionA"
        btnRegionA.Size = New Size(237, 70)
        btnRegionA.TabIndex = 21
        btnRegionA.Text = "Gestionar Region A"
        btnRegionA.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnSalir.BackColor = Color.FromArgb(CByte(137), CByte(185), CByte(145))
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalir.ForeColor = Color.White
        btnSalir.Location = New Point(330, 359)
        btnSalir.Margin = New Padding(3, 2, 3, 2)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(145, 43)
        btnSalir.TabIndex = 22
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(38, 314)
        FlowLayoutPanel1.Margin = New Padding(3, 2, 3, 2)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(7, 6)
        FlowLayoutPanel1.TabIndex = 25
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.BackColor = Color.FromArgb(CByte(236), CByte(237), CByte(244))
        lblTitulo.Dock = DockStyle.Fill
        lblTitulo.Font = New Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitulo.ForeColor = Color.FromArgb(CByte(137), CByte(185), CByte(145))
        lblTitulo.Location = New Point(3, 0)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(526, 48)
        lblTitulo.TabIndex = 13
        lblTitulo.Text = "EZ BANK - GESTIONADOR DE BANCO"
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' layoutBotones
        ' 
        layoutBotones.ColumnCount = 1
        layoutBotones.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        layoutBotones.Controls.Add(btnRegionC, 0, 2)
        layoutBotones.Controls.Add(btnRegionA, 0, 0)
        layoutBotones.Controls.Add(btnRegionB, 0, 1)
        layoutBotones.Location = New Point(53, 124)
        layoutBotones.Name = "layoutBotones"
        layoutBotones.RowCount = 3
        layoutBotones.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        layoutBotones.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        layoutBotones.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        layoutBotones.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        layoutBotones.Size = New Size(243, 262)
        layoutBotones.TabIndex = 29
        ' 
        ' btnRegionC
        ' 
        btnRegionC.BackColor = Color.FromArgb(CByte(184), CByte(210), CByte(177))
        btnRegionC.Dock = DockStyle.Top
        btnRegionC.FlatStyle = FlatStyle.Flat
        btnRegionC.Font = New Font("Verdana", 12F, FontStyle.Bold)
        btnRegionC.ForeColor = Color.FromArgb(CByte(30), CByte(33), CByte(57))
        btnRegionC.Location = New Point(3, 176)
        btnRegionC.Margin = New Padding(3, 2, 3, 2)
        btnRegionC.Name = "btnRegionC"
        btnRegionC.Size = New Size(237, 70)
        btnRegionC.TabIndex = 31
        btnRegionC.Text = "Gestionar Region C"
        btnRegionC.UseVisualStyleBackColor = False
        ' 
        ' btnRegionB
        ' 
        btnRegionB.BackColor = Color.FromArgb(CByte(184), CByte(210), CByte(177))
        btnRegionB.Dock = DockStyle.Top
        btnRegionB.FlatStyle = FlatStyle.Flat
        btnRegionB.Font = New Font("Verdana", 12F, FontStyle.Bold)
        btnRegionB.ForeColor = Color.FromArgb(CByte(30), CByte(33), CByte(57))
        btnRegionB.Location = New Point(3, 89)
        btnRegionB.Margin = New Padding(3, 2, 3, 2)
        btnRegionB.Name = "btnRegionB"
        btnRegionB.Size = New Size(237, 70)
        btnRegionB.TabIndex = 32
        btnRegionB.Text = "Gestionar Region B"
        btnRegionB.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(330, 110)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(230, 230)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 30
        PictureBox1.TabStop = False
        ' 
        ' btnInfo
        ' 
        btnInfo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnInfo.BackColor = Color.White
        btnInfo.FlatStyle = FlatStyle.Flat
        btnInfo.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInfo.ForeColor = Color.FromArgb(CByte(30), CByte(33), CByte(57))
        btnInfo.Location = New Point(505, 363)
        btnInfo.Margin = New Padding(3, 2, 3, 2)
        btnInfo.Name = "btnInfo"
        btnInfo.Size = New Size(55, 34)
        btnInfo.TabIndex = 31
        btnInfo.Text = "Info"
        btnInfo.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(lblTitulo, 0, 0)
        TableLayoutPanel1.Location = New Point(41, 43)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(532, 48)
        TableLayoutPanel1.TabIndex = 32
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(33), CByte(57))
        ClientSize = New Size(618, 434)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        Controls.Add(btnInfo)
        Controls.Add(PictureBox1)
        Controls.Add(layoutBotones)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(btnSalir)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        MaximumSize = New Size(618, 434)
        MinimumSize = New Size(618, 434)
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        layoutBotones.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnRegionA As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents layoutBotones As TableLayoutPanel
    Friend WithEvents btnRegionC As Button
    Friend WithEvents btnRegionB As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnInfo As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
