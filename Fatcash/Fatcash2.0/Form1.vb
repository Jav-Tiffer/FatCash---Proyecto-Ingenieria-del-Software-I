Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports Microsoft.Win32

Public Class Form1
    Private conexion As New SqlConnection("Data Source=DESKTOP-IA5NJOF;Initial Catalog=Fatcash;Integrated Security=True")
    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Private Sub btn_regist_Click(sender As Object, e As EventArgs) Handles btn_regist.Click
        Me.Hide()
        Registro.Show()
    End Sub


    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Try
            conexion.Open()
            Dim validar As Boolean = False
            cmd = New SqlCommand("select Email,Contrasena from DatosPersonales", conexion)

            dr = cmd.ExecuteReader

            If dr.HasRows = True Then
                While dr.Read
                    If txt_email.Text() = dr.Item("Email") And txt_contra.Text() = dr.Item("Contrasena") Then
                        Me.Hide()
                        MsgBox("Bienvenido al sistema")
                        Principal.Show()
                        txt_email.Clear()
                        txt_contra.Clear()
                        validar = True
                    End If

                End While

            End If
            If validar = False Then
                MsgBox("Error al ingresar a su cuenta")
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()

        End Try

    End Sub
End Class
