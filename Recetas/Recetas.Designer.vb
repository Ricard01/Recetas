<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecetas
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
        Me.cboRecetas = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cboRecetas
        '
        Me.cboRecetas.Location = New System.Drawing.Point(28, 12)
        Me.cboRecetas.Name = "cboRecetas"
        Me.cboRecetas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboRecetas.Size = New System.Drawing.Size(170, 21)
        Me.cboRecetas.TabIndex = 0
        '
        'frmRecetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 345)
        Me.Controls.Add(Me.cboRecetas)
        Me.Name = "frmRecetas"
        Me.Text = "Recetas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboRecetas As ComboBox
End Class
