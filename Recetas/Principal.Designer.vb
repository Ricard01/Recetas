<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cboEmpresa = New System.Windows.Forms.ComboBox()
        Me.cboRutaEmpresa = New System.Windows.Forms.ComboBox()
        Me.btnAbrirEmpresa = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboEmpresa
        '
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(6, 28)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(229, 21)
        Me.cboEmpresa.TabIndex = 0
        '
        'cboRutaEmpresa
        '
        Me.cboRutaEmpresa.FormattingEnabled = True
        Me.cboRutaEmpresa.Location = New System.Drawing.Point(29, 55)
        Me.cboRutaEmpresa.Name = "cboRutaEmpresa"
        Me.cboRutaEmpresa.Size = New System.Drawing.Size(146, 21)
        Me.cboRutaEmpresa.TabIndex = 2
        Me.cboRutaEmpresa.Visible = False
        '
        'btnAbrirEmpresa
        '
        Me.btnAbrirEmpresa.Location = New System.Drawing.Point(241, 28)
        Me.btnAbrirEmpresa.Name = "btnAbrirEmpresa"
        Me.btnAbrirEmpresa.Size = New System.Drawing.Size(75, 23)
        Me.btnAbrirEmpresa.TabIndex = 3
        Me.btnAbrirEmpresa.Text = "Abrir"
        Me.btnAbrirEmpresa.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboEmpresa)
        Me.GroupBox1.Controls.Add(Me.btnAbrirEmpresa)
        Me.GroupBox1.Controls.Add(Me.cboRutaEmpresa)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(441, 280)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar Empresa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Copyright © AnySolution 2016. Todos los derechos reservados."
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 309)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Abrir"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboEmpresa As ComboBox
    Friend WithEvents cboRutaEmpresa As ComboBox
    Friend WithEvents btnAbrirEmpresa As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
End Class
