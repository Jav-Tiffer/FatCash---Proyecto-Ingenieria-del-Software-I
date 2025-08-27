Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Public Class Principal
    Private conexion As New SqlConnection("Data Source=DESKTOP-IA5NJOF;Initial Catalog=Fatcash;Integrated Security=True")
    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Private Sub btn_ingresarM_Click(sender As Object, e As EventArgs) Handles btn_ingresarM.Click
        Me.Hide()
        Ingreso.Show()
    End Sub

    Private Sub btn_metasM_Click(sender As Object, e As EventArgs) Handles btn_metasM.Click
        Me.Hide()
        Metas.Show()
    End Sub

    Private Sub btn_reporteM_Click(sender As Object, e As EventArgs) Handles btn_reporteM.Click
        Me.Hide()
        Reporte.Show()
    End Sub

    Private Sub btn_salirP_Click(sender As Object, e As EventArgs) Handles btn_salirP.Click
        End
    End Sub

    Private Sub btn_logoutP_Click(sender As Object, e As EventArgs) Handles btn_logoutP.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btn_info_Click(sender As Object, e As EventArgs) Handles btn_info.Click

    End Sub

    Private Sub lblGastos_Click(sender As Object, e As EventArgs) Handles lblGastos.Click

        Try
            conexion.Open()
            cmd = New SqlCommand("select sum(ISNULL(Cantidad, 0)) as totalgastos From Finanzas Where TipoI=@tipoI", conexion)
            cmd.Parameters.AddWithValue("@tipoI", "Gastos")
            dr = cmd.ExecuteReader

            If dr.HasRows = True Then
                While dr.Read
                    Dim totalgastos As Integer = 0
                    If Not IsDBNull(dr.Item("totalgastos")) Then
                        totalgastos = CInt(dr.Item("totalgastos"))
                    End If
                    lblGastos.Text = totalgastos.ToString()
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If dr IsNot Nothing Then
                dr.Close()
            End If
            conexion.Close()
        End Try

    End Sub

    Private Sub lblIngresos_Click(sender As Object, e As EventArgs) Handles lblIngresos.Click
        Try
            conexion.Open()
            cmd = New SqlCommand("select sum(ISNULL(Cantidad, 0)) as totalingresos From Finanzas Where TipoI=@tipoI", conexion)
            cmd.Parameters.AddWithValue("@tipoI", "Ingresos")
            dr = cmd.ExecuteReader

            If dr.HasRows = True Then
                While dr.Read
                    Dim totalingresos As Integer = 0
                    If Not IsDBNull(dr.Item("totalingresos")) Then
                        totalingresos = CInt(dr.Item("totalingresos"))
                    End If
                    lblIngresos.Text = totalingresos.ToString()
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If dr IsNot Nothing Then
                dr.Close()
            End If
            conexion.Close()
        End Try
    End Sub
End Class