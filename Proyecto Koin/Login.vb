Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Login

    Dim conexion As New MySqlConnection()

#Region "Conexion a la base de datos"
    Public Sub Conectar()

        Try

            conexion.ConnectionString = "server=localhost;user=root;password=admin;database=sistema_taller"
            conexion.Open()

        Catch ex As Exception
            MsgBox("No se pudo conectar a la bbdd" & ex.Message)
            Me.Close()

        End Try

    End Sub
#End Region

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkRegistrarse_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkRegistrarse.LinkClicked
        Me.Hide()
        Register.Show()


    End Sub

    Private Sub BtnIniciarSesion_Click(sender As Object, e As EventArgs) Handles BtnIniciarSesion.Click

        Try
            If conexion.State = ConnectionState.Closed Then
                Conectar()
            End If

            Dim query As String = String.Empty

            query = "SELECT * FROM categorias_productos WHERE nombre='" & TbUsuario.Text & "' AND codigo='" & TbPassword.Text & "'"

            Dim mysqlcommand As MySqlCommand
            mysqlcommand = New MySqlCommand(query, conexion)

            Dim tabla As MySqlDataReader

            tabla = mysqlcommand.ExecuteReader

            Dim cantidad As Integer = 0

            While tabla.Read
                cantidad += 1
            End While

            If cantidad = 1 Then
                MsgBox("USUARIO Y PASSWORD CORRECTAS")
                Me.Hide()
                Home.Show()

            ElseIf cantidad > 1 Then

                MsgBox("Error: hay datos duplicados")

            ElseIf TbUsuario.Text = "" Or TbPassword.Text = "" Then

                MsgBox("Digite sus credenciales por favor!!!!!!")

            Else
                MsgBox("Error usuario y contraseña no validos")

            End If
            conexion.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)

        Finally
            conexion.Dispose()
        End Try


        TbUsuario.Text = ""
        TbPassword.Text = ""

    End Sub

End Class
