<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuariosALTA
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
        Label1 = New Label()
        Label2 = New Label()
        txtUsuario = New TextBox()
        txtContraseña = New TextBox()
        btnConfirmar = New Button()
        Label3 = New Label()
        btnVerificar = New Button()
        CheckContador = New CheckBox()
        CheckAdmin = New CheckBox()
        Label4 = New Label()
        btnReiniciar = New Button()
        btnVerificarEditado = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(70, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 21)
        Label1.TabIndex = 0
        Label1.Text = "Usuario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(60, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 21)
        Label2.TabIndex = 1
        Label2.Text = "Contraseña"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(36, 106)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(135, 23)
        txtUsuario.TabIndex = 2
        ' 
        ' txtContraseña
        ' 
        txtContraseña.Location = New Point(36, 186)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.Size = New Size(135, 23)
        txtContraseña.TabIndex = 3
        ' 
        ' btnConfirmar
        ' 
        btnConfirmar.Location = New Point(202, 244)
        btnConfirmar.Name = "btnConfirmar"
        btnConfirmar.Size = New Size(146, 42)
        btnConfirmar.TabIndex = 4
        btnConfirmar.Text = "CONFIRMAR"
        btnConfirmar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(130), CByte(151), CByte(176))
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(54, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(250, 30)
        Label3.TabIndex = 39
        Label3.Text = "VERIFICADOR USUARIO"
        ' 
        ' btnVerificar
        ' 
        btnVerificar.Location = New Point(190, 105)
        btnVerificar.Name = "btnVerificar"
        btnVerificar.Size = New Size(130, 23)
        btnVerificar.TabIndex = 40
        btnVerificar.Text = "Verificar Usuario"
        btnVerificar.UseVisualStyleBackColor = True
        ' 
        ' CheckContador
        ' 
        CheckContador.AutoSize = True
        CheckContador.Location = New Point(202, 208)
        CheckContador.Name = "CheckContador"
        CheckContador.Size = New Size(76, 19)
        CheckContador.TabIndex = 41
        CheckContador.Text = "Contador"
        CheckContador.UseVisualStyleBackColor = True
        ' 
        ' CheckAdmin
        ' 
        CheckAdmin.AutoSize = True
        CheckAdmin.Location = New Point(202, 178)
        CheckAdmin.Name = "CheckAdmin"
        CheckAdmin.Size = New Size(102, 19)
        CheckAdmin.TabIndex = 42
        CheckAdmin.Text = "Administrador"
        CheckAdmin.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(221, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 15)
        Label4.TabIndex = 43
        Label4.Text = "PERMISOS ESPECIALES"
        ' 
        ' btnReiniciar
        ' 
        btnReiniciar.BackColor = Color.Gainsboro
        btnReiniciar.Location = New Point(48, 244)
        btnReiniciar.Name = "btnReiniciar"
        btnReiniciar.Size = New Size(123, 42)
        btnReiniciar.TabIndex = 44
        btnReiniciar.Text = "Reiniciar"
        btnReiniciar.UseVisualStyleBackColor = False
        ' 
        ' btnVerificarEditado
        ' 
        btnVerificarEditado.Location = New Point(190, 105)
        btnVerificarEditado.Name = "btnVerificarEditado"
        btnVerificarEditado.Size = New Size(130, 23)
        btnVerificarEditado.TabIndex = 45
        btnVerificarEditado.Text = "Verificar Usuario"
        btnVerificarEditado.UseVisualStyleBackColor = True
        ' 
        ' FormUsuariosALTA
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(205), CByte(221), CByte(237))
        ClientSize = New Size(397, 328)
        Controls.Add(btnVerificarEditado)
        Controls.Add(btnReiniciar)
        Controls.Add(Label4)
        Controls.Add(CheckAdmin)
        Controls.Add(CheckContador)
        Controls.Add(btnVerificar)
        Controls.Add(Label3)
        Controls.Add(btnConfirmar)
        Controls.Add(txtContraseña)
        Controls.Add(txtUsuario)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormUsuariosALTA"
        Text = "Alta de Usuarios"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnVerificar As Button
    Friend WithEvents CheckContador As CheckBox
    Friend WithEvents CheckAdmin As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents btnVerificarEditado As Button
End Class
