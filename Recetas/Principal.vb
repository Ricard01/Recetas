Imports System.IO
Imports System.Text

Public Class frmPrincipal
    Dim lError As Integer

    Private Sub frmProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lidEmpresa As Integer
        Dim lNombreEmpresa As StringBuilder = New StringBuilder(61)
        Dim lRutaEmpresa As StringBuilder = New StringBuilder(61)

        ' Inicializar el SDK
        ' Directory.SetCurrentDirectory("C:\AdminPAQ_WIN\AdminPAQ\Binarios")
        Directory.SetCurrentDirectory("C:\Program Files (x86)\Compacw\AdminPAQ")
        lError = fInicializaSDK
        If lError <> 0 Then
            MessageBox.Show(MensajeError(lError))
            End
        End If
        cboEmpresa.Items.Clear()
        cboRutaEmpresa.Items.Clear()
        ' Ir a la primera empresa

        lError = fPosPrimerEmpresa(lidEmpresa, lNombreEmpresa, lRutaEmpresa)

        If lError <> 0 Then
            MessageBox.Show(MensajeError(lError))
            End
        End If

        While lError = 0
            cboEmpresa.Items.Add(lNombreEmpresa.ToString)
            cboRutaEmpresa.Items.Add(lRutaEmpresa.ToString)
            lError = fPosSiguienteEmpresa(lidEmpresa, lNombreEmpresa, lRutaEmpresa)
        End While

        'Omite la empresa predeterminada y selecciona la primera empresa
        cboEmpresa.Items.RemoveAt(0)
        cboEmpresa.SelectedIndex = 0
        cboRutaEmpresa.Items.RemoveAt(0)
        cboRutaEmpresa.SelectedIndex = 0
        '  frmAbreEmpresa.Activa_Botones((True))
        ' frmAbreEmpresa.btnAbrirEmpresa.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAbrirEmpresa.Click

        cboRutaEmpresa.SelectedIndex = cboEmpresa.SelectedIndex
        lRuta = cboRutaEmpresa.SelectedItem

        lError = fAbreEmpresa(lRuta)
        If lError <> 0 Then
            MensajeError(lError)
            End
        End If

        Me.Hide()
        frmRecetas.Show()

    End Sub

End Class
