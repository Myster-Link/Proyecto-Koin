<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        PanelInfo = New Panel()
        LblLogin = New Label()
        LblUsuario = New Label()
        LblPassword = New Label()
        TbUsuario = New TextBox()
        TbPassword = New TextBox()
        Panel3 = New Panel()
        LinkRegistrarse = New LinkLabel()
        LblNoCuenta = New Label()
        LinkOlvidoPass = New LinkLabel()
        BtnIniciarSesion = New Button()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(0, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(0, 0)
        Panel1.TabIndex = 0
        ' 
        ' PanelInfo
        ' 
        PanelInfo.BackColor = Color.FromArgb(62, 84, 172)
        PanelInfo.Location = New Point(1, 1)
        PanelInfo.Name = "PanelInfo"
        PanelInfo.Size = New Size(500, 570)
        PanelInfo.TabIndex = 1
        ' 
        ' LblLogin
        ' 
        LblLogin.AutoSize = True
        LblLogin.Font = New Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point)
        LblLogin.Location = New Point(565, 51)
        LblLogin.Name = "LblLogin"
        LblLogin.Size = New Size(127, 54)
        LblLogin.TabIndex = 2
        LblLogin.Text = "Login"' LblUsuario
        ' 
        LblUsuario.AutoSize = True
        LblUsuario.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        LblUsuario.Location = New Point(549, 149)
        LblUsuario.Name = "LblUsuario"
        LblUsuario.Size = New Size(102, 32)
        LblUsuario.TabIndex = 3
        LblUsuario.Text = "Usuario"' LblPassword
        ' 
        LblPassword.AutoSize = True
        LblPassword.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        LblPassword.Location = New Point(549, 250)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(143, 32)
        LblPassword.TabIndex = 4
        LblPassword.Text = "Contraseña"' TbUsuario
        ' 
        TbUsuario.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        TbUsuario.Location = New Point(549, 184)
        TbUsuario.Name = "TbUsuario"
        TbUsuario.Size = New Size(395, 39)
        TbUsuario.TabIndex = 5
        ' 
        ' TbPassword
        ' 
        TbPassword.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        TbPassword.Location = New Point(549, 285)
        TbPassword.Name = "TbPassword"
        TbPassword.PasswordChar = "*"c
        TbPassword.Size = New Size(395, 39)
        TbPassword.TabIndex = 6
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(LinkRegistrarse)
        Panel3.Controls.Add(LblNoCuenta)
        Panel3.Location = New Point(549, 464)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(395, 79)
        Panel3.TabIndex = 7
        ' 
        ' LinkRegistrarse
        ' 
        LinkRegistrarse.AutoSize = True
        LinkRegistrarse.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        LinkRegistrarse.Location = New Point(237, 26)
        LinkRegistrarse.Name = "LinkRegistrarse"
        LinkRegistrarse.Size = New Size(90, 25)
        LinkRegistrarse.TabIndex = 9
        LinkRegistrarse.TabStop = True
        LinkRegistrarse.Text = "Regístrate​"' LblNoCuenta
        ' 
        LblNoCuenta.AutoSize = True
        LblNoCuenta.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        LblNoCuenta.Location = New Point(42, 26)
        LblNoCuenta.Name = "LblNoCuenta"
        LblNoCuenta.Size = New Size(199, 25)
        LblNoCuenta.TabIndex = 10
        LblNoCuenta.Text = "¿No tienes una cuenta? "' LinkOlvidoPass
        ' 
        LinkOlvidoPass.AutoSize = True
        LinkOlvidoPass.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        LinkOlvidoPass.LinkColor = Color.Black
        LinkOlvidoPass.Location = New Point(634, 425)
        LinkOlvidoPass.Name = "LinkOlvidoPass"
        LinkOlvidoPass.Size = New Size(214, 25)
        LinkOlvidoPass.TabIndex = 8
        LinkOlvidoPass.TabStop = True
        LinkOlvidoPass.Text = "¿Olvidaste tu contraseña?​"' BtnIniciarSesion
        ' 
        BtnIniciarSesion.BackColor = Color.FromArgb(62, 84, 172)
        BtnIniciarSesion.Cursor = Cursors.Hand
        BtnIniciarSesion.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        BtnIniciarSesion.ForeColor = Color.White
        BtnIniciarSesion.Location = New Point(776, 348)
        BtnIniciarSesion.Name = "BtnIniciarSesion"
        BtnIniciarSesion.Size = New Size(168, 57)
        BtnIniciarSesion.TabIndex = 9
        BtnIniciarSesion.Text = "Iniciar Sesión"
        BtnIniciarSesion.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(984, 571)
        Controls.Add(BtnIniciarSesion)
        Controls.Add(LinkOlvidoPass)
        Controls.Add(Panel3)
        Controls.Add(TbPassword)
        Controls.Add(TbUsuario)
        Controls.Add(LblPassword)
        Controls.Add(LblUsuario)
        Controls.Add(LblLogin)
        Controls.Add(PanelInfo)
        Controls.Add(Panel1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelInfo As Panel
    Friend WithEvents LblLogin As Label
    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents TbUsuario As TextBox
    Friend WithEvents TbPassword As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LinkRegistrarse As LinkLabel
    Friend WithEvents LblNoCuenta As Label
    Friend WithEvents LinkOlvidoPass As LinkLabel
    Friend WithEvents BtnIniciarSesion As Button
End Class
