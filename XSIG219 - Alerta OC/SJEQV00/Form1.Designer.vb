<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Update1 = New Interop.SAF.SAFUpdate
        Me.SAFHelpProvider = New System.Windows.Forms.HelpProvider
        Me.btnProcesar = New System.Windows.Forms.Button
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Update1
        '
        Me.Update1.Enabled = True
        Me.Update1.Location = New System.Drawing.Point(220, 238)
        Me.Update1.Name = "Update1"
        Me.Update1.OcxState = CType(resources.GetObject("Update1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Update1.Size = New System.Drawing.Size(26, 26)
        Me.Update1.TabIndex = 0
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(118, 31)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesar.TabIndex = 1
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 99)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.Update1)
        Me.Name = "Form1"
        Me.Text = "Alerta Ordenes de Compra(XS.IG2.19)"
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Update1 As Interop.SAF.SAFUpdate
    Friend WithEvents SAFHelpProvider As System.Windows.Forms.HelpProvider
    Friend WithEvents btnProcesar As System.Windows.Forms.Button

End Class
