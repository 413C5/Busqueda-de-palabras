<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmString
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmString))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPalabra = New System.Windows.Forms.TextBox()
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(34, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Palabra a buscar:"
        '
        'txtPalabra
        '
        Me.txtPalabra.Location = New System.Drawing.Point(147, 24)
        Me.txtPalabra.Name = "txtPalabra"
        Me.txtPalabra.Size = New System.Drawing.Size(100, 23)
        Me.txtPalabra.TabIndex = 1
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(34, 78)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.ReadOnly = True
        Me.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTexto.Size = New System.Drawing.Size(407, 139)
        Me.txtTexto.TabIndex = 4
        Me.txtTexto.TabStop = False
        Me.txtTexto.Text = resources.GetString("txtTexto.Text")
        '
        'lblMensaje
        '
        Me.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMensaje.Location = New System.Drawing.Point(34, 248)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(407, 35)
        Me.lblMensaje.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(276, 23)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Enabled = False
        Me.btnSiguiente.Location = New System.Drawing.Point(366, 23)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguiente.TabIndex = 3
        Me.btnSiguiente.Text = "&Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(366, 315)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmString
        '
        Me.AcceptButton = Me.btnBuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(474, 377)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.txtTexto)
        Me.Controls.Add(Me.txtPalabra)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmString"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de palabras"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPalabra As TextBox
    Friend WithEvents txtTexto As TextBox
    Friend WithEvents lblMensaje As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnSalir As Button
End Class
