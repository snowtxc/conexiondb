Imports MySql.Data.MySqlClient



Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As MySqlConnection
        conexion = New MySqlConnection

        Dim cmd As New MySqlCommand

        conexion.ConnectionString = "server=localhost;database=encuesta;Uid=root;Pwd=;"
        If txtNombre.Text <> "" And txtApellido.Text <> "" Then
            Try
                conexion.Open()
                cmd.Connection = conexion


                cmd.CommandText = "INSERT INTO encuesta_series(nombre,apellido,serie_favorita) VALUES(@nombre,@apellido,@seriefavorita)"
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
                cmd.Parameters.AddWithValue("@apellido", txtApellido.Text)
                cmd.Parameters.AddWithValue("@seriefavorita", ComboBox.Text)

                cmd.ExecuteNonQuery()

                MsgBox("Datos registrados correctamente.")



            Catch ex As Exception
                MsgBox(ex.Message)






            End Try
        Else
            MsgBox("No pueden haber campos vacíos")

        End If

    End Sub


End Class
