Imports System.Text
Imports System.Data.Odbc
Module FunGlobales

    Public lruta
    Public miConexionString As String = "; Dsn=Visual FoxPro Tables;sourcetype=DBF;exclusive=No;backgroundfetch=Yes;collate=Machine;null=Yes;deleted=Yes; "
    Public miConexion As New OdbcConnection()
    Public comando As New OdbcCommand
    Public dataR As OdbcDataReader
    Public comando2 As New OdbcCommand
    Public dataR2 As OdbcDataReader

    Sub RutaBD()
        miConexion.ConnectionString = " sourcedb= " & lruta & miConexionString
    End Sub

    Public Sub conexionBD()

        Try
            RutaBD()
            miConexion.Open()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function MensajeError(ByRef aError As Integer) As String
        Dim aMensaje As StringBuilder = New StringBuilder(512)
        ' Recupera el mensaje de error del SDK
        fError(aError, aMensaje, 350)
        Return aMensaje.ToString()
    End Function


End Module
