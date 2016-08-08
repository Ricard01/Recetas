Imports System.Data.Odbc
Public Class frmRecetas
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRecetas.SelectedIndexChanged

    End Sub

    Private Sub frmRecetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexionBD()

        comando.Connection = miConexion
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT cidprodu01, cnombrep01  FROM mgw10005"

        Try
            dataR = comando.ExecuteReader()


            If dataR.HasRows Then
                While dataR.Read()

                    cboRecetas.Items.Add(dataR.GetString(1).ToString.Trim)
                End While
            Else
                MsgBox("Hubo un problema con la consulta")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class