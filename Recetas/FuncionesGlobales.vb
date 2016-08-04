Imports System.Text
Module FuncionesGlobales
    Public Function MensajeError(ByRef aError As Integer) As String
        Dim aMensaje As StringBuilder = New StringBuilder(512)
        ' Recupera el mensaje de error del SDK
        fError(aError, aMensaje, 350)
        Return aMensaje.ToString()

    End Function




End Module

