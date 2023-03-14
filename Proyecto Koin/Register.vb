Public Class Register
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        TbCedula.Text = ""
        TbCorreo.Text = ""
        TbNombre.Text = ""
        TbApellidos.Text = ""
        TbPassword.Text = ""

    End Sub
End Class