<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
    Friend WithEvents ApplicationTitle As Label
    Friend WithEvents Version As Label
    Friend WithEvents Copyright As Label
    Friend WithEvents MainLayoutPanel As TableLayoutPanel
    Friend WithEvents DetailsLayoutPanel As TableLayoutPanel

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        MainLayoutPanel = New TableLayoutPanel()
        DetailsLayoutPanel = New TableLayoutPanel()
        Version = New Label()
        Copyright = New Label()
        ApplicationTitle = New Label()
        Timer1 = New Timer(components)
        PictureBox1 = New PictureBox()
        MainLayoutPanel.SuspendLayout()
        DetailsLayoutPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MainLayoutPanel
        ' 
        MainLayoutPanel.BackColor = Color.FromArgb(CByte(30), CByte(33), CByte(57))
        MainLayoutPanel.BackgroundImageLayout = ImageLayout.Stretch
        MainLayoutPanel.ColumnCount = 2
        MainLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 213F))
        MainLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 88F))
        MainLayoutPanel.Controls.Add(DetailsLayoutPanel, 1, 1)
        MainLayoutPanel.Controls.Add(ApplicationTitle, 1, 0)
        MainLayoutPanel.Dock = DockStyle.Fill
        MainLayoutPanel.Location = New Point(0, 0)
        MainLayoutPanel.Margin = New Padding(3, 2, 3, 2)
        MainLayoutPanel.Name = "MainLayoutPanel"
        MainLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 60F))
        MainLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        MainLayoutPanel.Size = New Size(434, 227)
        MainLayoutPanel.TabIndex = 0
        ' 
        ' DetailsLayoutPanel
        ' 
        DetailsLayoutPanel.AutoSize = True
        DetailsLayoutPanel.BackColor = Color.Transparent
        DetailsLayoutPanel.ColumnCount = 1
        DetailsLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 216F))
        DetailsLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 124F))
        DetailsLayoutPanel.Controls.Add(Copyright, 0, 1)
        DetailsLayoutPanel.Controls.Add(Version, 0, 0)
        DetailsLayoutPanel.Dock = DockStyle.Top
        DetailsLayoutPanel.Location = New Point(216, 138)
        DetailsLayoutPanel.Margin = New Padding(3, 2, 3, 2)
        DetailsLayoutPanel.Name = "DetailsLayoutPanel"
        DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33F))
        DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33F))
        DetailsLayoutPanel.Size = New Size(215, 60)
        DetailsLayoutPanel.TabIndex = 1
        ' 
        ' Version
        ' 
        Version.Anchor = AnchorStyles.None
        Version.BackColor = Color.Transparent
        Version.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Version.ForeColor = Color.FromArgb(CByte(184), CByte(210), CByte(177))
        Version.Location = New Point(3, 7)
        Version.Name = "Version"
        Version.Size = New Size(210, 15)
        Version.TabIndex = 1
        Version.Text = "Versión 0.0"
        ' 
        ' Copyright
        ' 
        Copyright.Anchor = AnchorStyles.None
        Copyright.BackColor = Color.Transparent
        Copyright.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Copyright.ForeColor = Color.FromArgb(CByte(184), CByte(210), CByte(177))
        Copyright.Location = New Point(3, 30)
        Copyright.Name = "Copyright"
        Copyright.Size = New Size(210, 30)
        Copyright.TabIndex = 2
        Copyright.Text = "Copyright"
        ' 
        ' ApplicationTitle
        ' 
        ApplicationTitle.Anchor = AnchorStyles.None
        ApplicationTitle.BackColor = Color.Transparent
        ApplicationTitle.Font = New Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ApplicationTitle.ForeColor = Color.FromArgb(CByte(184), CByte(210), CByte(177))
        ApplicationTitle.Location = New Point(216, 0)
        ApplicationTitle.Name = "ApplicationTitle"
        ApplicationTitle.Size = New Size(215, 136)
        ApplicationTitle.TabIndex = 0
        ApplicationTitle.Text = "EZ BANK"
        ApplicationTitle.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Timer1
        ' 
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(24, 33)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(170, 170)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Splash
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(434, 227)
        ControlBox = False
        Controls.Add(PictureBox1)
        Controls.Add(MainLayoutPanel)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Splash"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        MainLayoutPanel.ResumeLayout(False)
        MainLayoutPanel.PerformLayout()
        DetailsLayoutPanel.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
