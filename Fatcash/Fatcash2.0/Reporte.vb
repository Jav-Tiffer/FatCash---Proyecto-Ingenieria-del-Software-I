Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class Reporte
    Private conexion As New SqlConnection("Data Source=DESKTOP-IA5NJOF;Initial Catalog=Fatcash;Integrated Security=True")
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private Sub btn_volverR2_Click(sender As Object, e As EventArgs) Handles btn_volverR2.Click
        txt_fechaR.Text = ""
        lbl_Ingresos.Text = "Ingresos"
        lbl_gastos.Text = "Gastos"
        Me.Hide()
        Principal.Show()
    End Sub

    Private Sub btn_aceptarR2_Click(sender As Object, e As EventArgs) Handles btn_aceptarR2.Click
        lbl_Ingresos.Text = ("Ingresos")
        lbl_gastos.Text = ("Gastos")
        Dim validar1 As Boolean = True
        If txt_fechaR.Text <> "" Then
            Try
                Dim Fecha As Date = Date.Parse(txt_fechaR.Text)
                validar1 = False
            Catch ex As Exception
                MsgBox("El campo fecha debe tener el formato indicado")
            End Try
            If validar1 = False Then
                Try
                    conexion.Open()
                    cmd = New SqlCommand("select * from Finanzas Where FechaI='" & txt_fechaR.Text() & "'", conexion)
                    If cmd.ExecuteNonQuery() Then
                        dr = cmd.ExecuteReader
                        If dr.HasRows = True Then
                            While dr.Read
                                If dr.Item("TipoI") = "Ingresos" Then
                                    lbl_Ingresos.Text = lbl_Ingresos.Text + vbCrLf & dr.Item("Tipo") & " " & dr.Item("Cantidad")

                                Else

                                    lbl_gastos.Text = lbl_gastos.Text + vbCrLf & dr.Item("Tipo") & " " & dr.Item("Cantidad")
                                End If

                            End While

                        End If
                    Else
                        MsgBox("No se encontraron ingresos o gastos en esa fecha")
                    End If


                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    conexion.Close()

                End Try
            End If
        Else
            MsgBox("El campo está vacío")
        End If
    End Sub
End Class