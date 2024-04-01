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
        Label1 = New Label()
        txtPalabra = New TextBox()
        txtTexto = New TextBox()
        lblMensaje = New Label()
        btnBuscar = New Button()
        btnSiguiente = New Button()
        btnSalir = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(39, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 87)
        Label1.TabIndex = 0
        Label1.Text = "Palabra a buscar:"
        ' 
        ' txtPalabra
        ' 
        txtPalabra.Location = New Point(168, 32)
        txtPalabra.Margin = New Padding(3, 4, 3, 4)
        txtPalabra.Name = "txtPalabra"
        txtPalabra.Size = New Size(114, 27)
        txtPalabra.TabIndex = 1
        ' 
        ' txtTexto
        ' 
        txtTexto.Location = New Point(39, 104)
        txtTexto.Margin = New Padding(3, 4, 3, 4)
        txtTexto.Multiline = True
        txtTexto.Name = "txtTexto"
        txtTexto.ScrollBars = ScrollBars.Vertical
        txtTexto.Size = New Size(465, 184)
        txtTexto.TabIndex = 4
        txtTexto.TabStop = False
        txtTexto.Text = resources.GetString("txtTexto.Text")
        ' 
        ' lblMensaje
        ' 
        lblMensaje.BorderStyle = BorderStyle.FixedSingle
        lblMensaje.Location = New Point(39, 331)
        lblMensaje.Name = "lblMensaje"
        lblMensaje.Size = New Size(465, 46)
        lblMensaje.TabIndex = 5
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(315, 31)
        btnBuscar.Margin = New Padding(3, 4, 3, 4)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(86, 31)
        btnBuscar.TabIndex = 2
        btnBuscar.Text = "&Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Enabled = False
        btnSiguiente.Location = New Point(418, 31)
        btnSiguiente.Margin = New Padding(3, 4, 3, 4)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(86, 31)
        btnSiguiente.TabIndex = 3
        btnSiguiente.Text = "&Siguiente"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(418, 420)
        btnSalir.Margin = New Padding(3, 4, 3, 4)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(86, 31)
        btnSalir.TabIndex = 6
        btnSalir.Text = "&Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' frmString
        ' 
        AcceptButton = btnBuscar
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnSalir
        ClientSize = New Size(542, 503)
        Controls.Add(btnSalir)
        Controls.Add(btnSiguiente)
        Controls.Add(btnBuscar)
        Controls.Add(lblMensaje)
        Controls.Add(txtTexto)
        Controls.Add(txtPalabra)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "frmString"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Busqueda de palabras"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPalabra As TextBox
    Friend WithEvents txtTexto As TextBox
    Friend WithEvents lblMensaje As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnSalir As Button
End Class
