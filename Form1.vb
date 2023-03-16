Public Class frmString
#Region "Atributos"
    Private posicion As Integer
#End Region
#Region "Metodos"
    ''' <summary>
    ''' Funcion que busca un string dentro de otro y envia los mensajes correspondientes
    ''' </summary>
    ''' <param name="palabra">Es el string que se va a buscar</param>
    ''' <param name="texto">Es el string donde se va a buscar la palabra</param>
    Private Sub Buscar(ByVal palabra As String, ByVal texto As String)
        posicion = texto.IndexOf(palabra, posicion)
        If posicion < 0 Then
            Beep()
            lblMensaje.Text = "La palabra " & palabra & " no se encuentra en el texto"
            lblMensaje.ForeColor = Color.Red
            btnBuscar.Enabled = True
            btnSiguiente.Enabled = False
            txtPalabra.Focus()
            txtPalabra.SelectAll()
        Else
            lblMensaje.Text = "La palabra " & palabra & " esta en la posicion " & posicion
            lblMensaje.ForeColor = Color.Green
            txtTexto.Focus()
            txtTexto.Select(posicion, palabra.Length)
            btnSiguiente.Enabled = True
            btnBuscar.Enabled = False
        End If
    End Sub
#End Region
#Region "Eventos"
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        posicion = 0
        Buscar(txtPalabra.Text, txtTexto.Text)
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        posicion += 1
        Buscar(txtPalabra.Text, txtTexto.Text)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
#End Region

End Class
