<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cboEmpresa = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboRutaEmpresa = New System.Windows.Forms.ComboBox()
        Me.btnAbrirEmpresa = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboEmpresa
        '
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(161, 59)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(248, 21)
        Me.cboEmpresa.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(107, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Emrpesa"
        '
        'cboRutaEmpresa
        '
        Me.cboRutaEmpresa.FormattingEnabled = True
        Me.cboRutaEmpresa.Location = New System.Drawing.Point(161, 85)
        Me.cboRutaEmpresa.Name = "cboRutaEmpresa"
        Me.cboRutaEmpresa.Size = New System.Drawing.Size(146, 21)
        Me.cboRutaEmpresa.TabIndex = 2
        '
        'btnAbrirEmpresa
        '
        Me.btnAbrirEmpresa.Location = New System.Drawing.Point(161, 112)
        Me.btnAbrirEmpresa.Name = "btnAbrirEmpresa"
        Me.btnAbrirEmpresa.Size = New System.Drawing.Size(75, 23)
        Me.btnAbrirEmpresa.TabIndex = 3
        Me.btnAbrirEmpresa.Text = "Abrir"
        Me.btnAbrirEmpresa.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 381)
        Me.Controls.Add(Me.btnAbrirEmpresa)
        Me.Controls.Add(Me.cboRutaEmpresa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboEmpresa)
        Me.KeyPreview = True
        Me.Name = "frmPrincipal"
        Me.Text = "Recetas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboEmpresa As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboRutaEmpresa As ComboBox
    Friend WithEvents btnAbrirEmpresa As Button
End Class
