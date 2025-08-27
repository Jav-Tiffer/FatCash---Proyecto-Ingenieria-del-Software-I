Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Public Class Registro
    Private conexion As New SqlConnection("Data Source=DESKTOP-IA5NJOF;Initial Catalog=Fatcash;Integrated Security=True")
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private Sub btn_volverR_Click(sender As Object, e As EventArgs) Handles btn_volverR.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btn_aceptarR_Click(sender As Object, e As EventArgs) Handles btn_aceptarR.Click

        Dim validar As Boolean = True
        Dim validar2 As Boolean = True

        If txt_cedR.Text <> "" And txt_contraR.Text <> "" And txt_emailR.Text <> "" And txt_nomR.Text <> "" Then
            Try
                Dim Cedula As Integer = Convert.ToInt32(txt_cedR.Text)
                validar2 = False
            Catch ex As Exception
                MsgBox("El campo cedula debe ser llenado solo con numeros")
            End Try
            If validar2 = False Then
                Try
                    conexion.Open()
                    cmd = New SqlCommand("select * from DatosPersonales", conexion)

                    dr = cmd.ExecuteReader

                    If dr.HasRows = True Then
                        While dr.Read
                            If txt_cedR.Text() = dr.Item("Cedula") Or txt_emailR.Text() = dr.Item("Email") Then

                                validar = False

                            End If

                        End While

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    conexion.Close()

                End Try
                If validar = False Then
                    MsgBox("Ya existe un usuario con esa cedula o email")
                Else
                    Try
                        conexion.Open()
                        cmd = New SqlCommand("insert into DatosPersonales (Cedula,Email,Nombre,Contrasena) values('" & txt_cedR.Text() & "','" & txt_emailR.Text() & "','" & txt_nomR.Text() & "','" & txt_contraR.Text() & "')", conexion)
                        If cmd.ExecuteNonQuery() Then
                            MsgBox("Se registró con éxito")
                            txt_cedR.Clear()
                            txt_contraR.Clear()
                            txt_emailR.Clear()
                            txt_nomR.Clear()
                            Form1.Show()
                            Me.Hide()

                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        conexion.Close()
                    End Try

                End If
            End If

        Else
            MsgBox("Hay algun campo vacío")
        End If


    End Sub
End Class