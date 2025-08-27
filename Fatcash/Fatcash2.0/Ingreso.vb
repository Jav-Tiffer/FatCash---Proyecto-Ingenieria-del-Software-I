Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class Ingreso
    Private conexion As New SqlConnection("Data Source=DESKTOP-IA5NJOF;Initial Catalog=Fatcash;Integrated Security=True")
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private Sub btn_volverI_Click(sender As Object, e As EventArgs) Handles btn_volverI.Click
        txt_ingresoI.Text = ""
        cmb_tingresoI.Text = ""
        txt_gastoI.Text = ""
        cmb_tgastoI.Text = ""
        txt_fechaI.Text = ""
        txt_ingresoI.Enabled = True
        cmb_tingresoI.Enabled = True
        txt_gastoI.Enabled = True
        cmb_tgastoI.Enabled = True
        Me.Hide()
        Principal.Show()

    End Sub

    Private Sub btn_aceptarI_Click(sender As Object, e As EventArgs) Handles btn_aceptarI.Click
        Dim validar1 As Boolean = True
        Dim validar2 As Boolean = True

        If txt_ingresoI.Text <> "" And cmb_tingresoI.Text <> "" And txt_fechaI.Text <> "" Then
            Try
                Dim Ingresos As Integer = Convert.ToInt32(txt_ingresoI.Text)
                validar1 = False
            Catch ex As Exception
                MsgBox("El campo ingresos debe ser llenado solo con numeros")
            End Try
            Try
                Dim Fecha As Date = Date.Parse(txt_fechaI.Text)
                validar2 = False
            Catch ex As Exception
                MsgBox("El campo fecha debe tener el formato indicado")
            End Try
            If validar1 = False And validar2 = False Then
                Try
                    conexion.Open()
                    cmd = New SqlCommand("insert into Finanzas (TipoI,Tipo,Cantidad,FechaI) values('Ingresos','" & cmb_tingresoI.Text() & "','" & txt_ingresoI.Text() & "','" & txt_fechaI.Text() & "')", conexion)
                    If cmd.ExecuteNonQuery() Then
                        MsgBox("Se ingresaron los datos con éxito")
                        txt_ingresoI.Clear()
                        txt_fechaI.Clear()
                        cmb_tingresoI.Text = ""

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    conexion.Close()
                End Try
            End If
        Else
            If txt_gastoI.Text <> "" And cmb_tgastoI.Text <> "" And txt_fechaI.Text <> "" Then

                Try
                    Dim Gastos As Integer = Convert.ToInt32(txt_gastoI.Text)
                    validar1 = False
                Catch ex As Exception
                    MsgBox("El campo ingresos debe ser llenado solo con numeros")
                End Try
                Try
                    Dim Fecha As Date = Date.Parse(txt_fechaI.Text)
                    validar2 = False
                Catch ex As Exception
                    MsgBox("El campo fecha debe tener el formato indicado")
                End Try
                If validar1 = False And validar2 = False Then
                    Try
                        conexion.Open()
                        cmd = New SqlCommand("insert into Finanzas (TipoI,Tipo,Cantidad,FechaI) values('Gastos','" & cmb_tgastoI.Text() & "','" & txt_gastoI.Text() & "','" & txt_fechaI.Text() & "')", conexion)
                        If cmd.ExecuteNonQuery() Then
                            MsgBox("Se ingresaron los datos con éxito")
                            txt_gastoI.Clear()
                            txt_fechaI.Clear()
                            cmb_tgastoI.Text = ""

                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        conexion.Close()
                    End Try
                End If
            Else
                If txt_gastoI.Enabled = True And cmb_tgastoI.Enabled = True Then
                    MsgBox("Hay campos vacíos")
                End If

            End If
            If txt_ingresoI.Enabled = True And cmb_tingresoI.Enabled = True Then
                MsgBox("Hay campos vacíos")
            End If
        End If
        If txt_ingresoI.Text <> "" And cmb_tingresoI.Text <> "" And txt_fechaI.Text <> "" And txt_gastoI.Text <> "" And cmb_tgastoI.Text <> "" Then
            MsgBox("Todos los campos están vacíos")
        End If
    End Sub

    Private Sub txt_fechaI_TextChanged(sender As Object, e As EventArgs) Handles txt_fechaI.TextChanged

    End Sub

    Private Sub txt_ingresoI_TextChanged(sender As Object, e As EventArgs) Handles txt_ingresoI.TextChanged
        txt_gastoI.Enabled = False
        cmb_tgastoI.Enabled = False

    End Sub

    Private Sub cmb_tingresoI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tingresoI.SelectedIndexChanged
        txt_gastoI.Enabled = False
        cmb_tgastoI.Enabled = False

    End Sub

    Private Sub txt_gastoI_TextChanged(sender As Object, e As EventArgs) Handles txt_gastoI.TextChanged
        txt_ingresoI.Enabled = False
        cmb_tingresoI.Enabled = False

    End Sub

    Private Sub cmb_tgastoI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tgastoI.SelectedIndexChanged
        txt_ingresoI.Enabled = False
        cmb_tingresoI.Enabled = False
    End Sub
End Class