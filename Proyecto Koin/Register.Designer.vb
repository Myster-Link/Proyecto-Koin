<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Panel1 = New Panel()
        BtnRegister = New Button()
        LblRegister = New Label()
        LblNombre = New Label()
        LblCedula = New Label()
        LblPassword = New Label()
        TbNombre = New TextBox()
        TbCedula = New TextBox()
        TbCorreo = New TextBox()
        TbPassword = New TextBox()
        TbApellidos = New TextBox()
        LblCorreo = New Label()
        LblApellidos = New Label()
        Panel2 = New Panel()
        LinkLabel1 = New LinkLabel()
        LblYaCuenta = New Label()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(62, 84, 172)
        Panel1.Location = New Point(484, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(500, 663)
        Panel1.TabIndex = 0
        ' 
        ' BtnRegister
        ' 
        BtnRegister.BackColor = Color.FromArgb(62, 84, 172)
        BtnRegister.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        BtnRegister.ForeColor = Color.Transparent
        BtnRegister.Location = New Point(274, 487)
        BtnRegister.Name = "BtnRegister"
        BtnRegister.Size = New Size(168, 57)
        BtnRegister.TabIndex = 17
        BtnRegister.Text = "Registrarse"
        BtnRegister.UseVisualStyleBackColor = False
        ' 
        ' LblRegister
        ' 
        LblRegister.AutoSize = True
        LblRegister.Font = New Font("Segoe UI", 30.0F, FontStyle.Bold, GraphicsUnit.Point)
        LblRegister.Location = New Point(89, 25)
        LblRegister.Name = "LblRegister"
        LblRegister.Size = New Size(203, 54)
        LblRegister.TabIndex = 1
        LblRegister.Text = "REGISTER" ' LblNombre
        ' 
        LblNombre.AutoSize = True
        LblNombre.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
        LblNombre.Location = New Point(47, 254)
        LblNombre.Name = "LblNombre"
        LblNombre.Size = New Size(108, 32)
        LblNombre.TabIndex = 2
        LblNombre.Text = "Nombre" ' LblCedula
        ' 
        LblCedula.AutoSize = True
        LblCedula.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
        LblCedula.Location = New Point(47, 108)
        LblCedula.Name = "LblCedula"
        LblCedula.Size = New Size(92, 32)
        LblCedula.TabIndex = 3
        LblCedula.Text = "Cedula" ' LblPassword
        ' 
        LblPassword.AutoSize = True
        LblPassword.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
        LblPassword.Location = New Point(47, 398)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(143, 32)
        LblPassword.TabIndex = 4
        LblPassword.Text = "Contraseña" ' TbNombre
        ' 
        TbNombre.Font = New Font("Segoe UI", 15.0F, FontStyle.Regular, GraphicsUnit.Point)
        TbNombre.Location = New Point(47, 289)
        TbNombre.Name = "TbNombre"
        TbNombre.Size = New Size(395, 34)
        TbNombre.TabIndex = 6
        ' 
        ' TbCedula
        ' 
        TbCedula.Font = New Font("Segoe UI", 15.0F, FontStyle.Regular, GraphicsUnit.Point)
        TbCedula.Location = New Point(47, 143)
        TbCedula.Name = "TbCedula"
        TbCedula.Size = New Size(395, 34)
        TbCedula.TabIndex = 7
        ' 
        ' TbCorreo
        ' 
        TbCorreo.Font = New Font("Segoe UI", 15.0F, FontStyle.Regular, GraphicsUnit.Point)
        TbCorreo.Location = New Point(47, 217)
        TbCorreo.Name = "TbCorreo"
        TbCorreo.Size = New Size(395, 34)
        TbCorreo.TabIndex = 8
        ' 
        ' TbPassword
        ' 
        TbPassword.Font = New Font("Segoe UI", 15.0F, FontStyle.Regular, GraphicsUnit.Point)
        TbPassword.Location = New Point(47, 433)
        TbPassword.Name = "TbPassword"
        TbPassword.PasswordChar = "*"c
        TbPassword.Size = New Size(395, 34)
        TbPassword.TabIndex = 9
        ' 
        ' TbApellidos
        ' 
        TbApellidos.Font = New Font("Segoe UI", 15.0F, FontStyle.Regular, GraphicsUnit.Point)
        TbApellidos.Location = New Point(47, 361)
        TbApellidos.Name = "TbApellidos"
        TbApellidos.Size = New Size(395, 34)
        TbApellidos.TabIndex = 10
        ' 
        ' LblCorreo
        ' 
        LblCorreo.AutoSize = True
        LblCorreo.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
        LblCorreo.Location = New Point(47, 180)
        LblCorreo.Name = "LblCorreo"
        LblCorreo.Size = New Size(92, 32)
        LblCorreo.TabIndex = 14
        LblCorreo.Text = "Correo" ' LblApellidos
        ' 
        LblApellidos.AutoSize = True
        LblApellidos.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
        LblApellidos.Location = New Point(47, 326)
        LblApellidos.Name = "LblApellidos"
        LblApellidos.Size = New Size(121, 32)
        LblApellidos.TabIndex = 15
        LblApellidos.Text = "Apellidos" ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(LinkLabel1)
        Panel2.Controls.Add(LblYaCuenta)
        Panel2.Location = New Point(47, 570)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(395, 79)
        Panel2.TabIndex = 16
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel1.Location = New Point(234, 28)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(115, 25)
        LinkLabel1.TabIndex = 1
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Iniciar Sesión" ' LblYaCuenta
        ' 
        LblYaCuenta.AutoSize = True
        LblYaCuenta.Font = New Font("Segoe UI", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        LblYaCuenta.Location = New Point(41, 28)
        LblYaCuenta.Name = "LblYaCuenta"
        LblYaCuenta.Size = New Size(187, 25)
        LblYaCuenta.TabIndex = 0
        LblYaCuenta.Text = "¿Ya tienes una cuenta?" ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 661)
        Controls.Add(BtnRegister)
        Controls.Add(LblPassword)
        Controls.Add(LblApellidos)
        Controls.Add(LblCorreo)
        Controls.Add(LblCedula)
        Controls.Add(Panel2)
        Controls.Add(LblRegister)
        Controls.Add(TbApellidos)
        Controls.Add(TbPassword)
        Controls.Add(TbCorreo)
        Controls.Add(TbCedula)
        Controls.Add(TbNombre)
        Controls.Add(LblNombre)
        Controls.Add(Panel1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LblRegister As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblCedula As Label
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents TbCedula As TextBox
    Friend WithEvents TbCorreo As TextBox
    Friend WithEvents LblCorreo As Label
    Friend WithEvents BtnRegister As Button
    Friend WithEvents LblPassword As Label
    Friend WithEvents TbPassword As TextBox
    Friend WithEvents TbApellidos As TextBox
    Friend WithEvents LblApellidos As Label
    Friend WithEvents LblYaCuenta As Label
End Class
