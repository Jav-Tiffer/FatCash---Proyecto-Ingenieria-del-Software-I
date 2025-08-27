Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class Metas
    Private conexion As New SqlConnection("Data Source=DESKTOP-J1AM8OU;Initial Catalog=Fatcash;Integrated Security=True")
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private Sub btn_volverM_Click(sender As Object, e As EventArgs) Handles btn_volverM.Click
        txt_ahorrarM.Text = ""
        txt_fechaM.Text = ""
        Me.Hide()
        Principal.Show()
    End Sub

    Private Sub btn_aceptarM_Click(sender As Object, e As EventArgs) Handles btn_aceptarM.Click
        Dim validar1 As Boolean = True
        Dim validar2 As Boolean = True
        If txt_ahorrarM.Text <> "" And txt_fechaM.Text <> "" Then
            Try
                Dim Ahorrar As Integer = Convert.ToInt32(txt_ahorrarM.Text)
                validar1 = False
            Catch ex As Exception
                MsgBox("El campo ahorros debe ser llenado solo con numeros")
            End Try
            Try
                Dim Fecha As Date = Date.Parse(txt_fechaM.Text)
                validar2 = False
            Catch ex As Exception
                MsgBox("El campo fecha debe tener el formato indicado")
            End Try
            If validar1 = False And validar2 = False Then
                Try
                    conexion.Open()
                    cmd = New SqlCommand("insert into Metas (CantidadM,FechaM) values('" & txt_ahorrarM.Text() & "','" & txt_fechaM.Text() & "')", conexion)
                    If cmd.ExecuteNonQuery() Then
                        MsgBox("Se ingresó su meta con éxito")
                        txt_ahorrarM.Clear()
                        txt_fechaM.Clear()

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    conexion.Close()
                End Try
            End If
        Else
            MsgBox("Hay campos vacíos")
        End If
    End Sub


End Class