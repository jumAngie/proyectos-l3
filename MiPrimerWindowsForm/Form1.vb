Public Class Form1

#Region "Formulario"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Select()
    End Sub
#End Region

#Region "Validaciones"
    Private Sub ValidacionDeVacio()
        If (txtNombre.Text = "") Then
            lblErrorNombre.Show()
            pnNombre.Show()
            MsjWarning()
        End If

        If (txtApellido.Text = "") Then
            lblErrorApellido.Show()
            pnApellido.Show()
            MsjWarning()
        End If

        If (txtNombre.Text <> "") Then
            lblErrorNombre.Visible() = False
            pnNombre.Hide()
        End If

        If (txtApellido.Text <> "") Then
            lblErrorApellido.Visible() = False
            pnApellido.Hide()
        End If

    End Sub
#End Region

#Region "Mensajes y TextBoxs"
    Private Sub LimpiarTextBox()
        txtNombre.Clear()
        txtApellido.Clear()
    End Sub

    Private Sub MsjSuccess()
        pctSuccess.Show()
        lblSuccess.Show()
    End Sub

    Private Sub MsjSuccessHide()
        pctSuccess.Hide()
        lblSuccess.Hide()
    End Sub

    Private Sub MsjWarning()
        pctWarning.Show()
        lblWarning.Show()
    End Sub

    Private Sub MsjWarningHide()
        pctWarning.Hide()
        lblWarning.Hide()
    End Sub
#End Region

#Region "Objetos del Formulario"
    Private Async Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        ValidacionDeVacio()

        If (txtNombre.Text <> "" And txtApellido.Text <> "") Then
            MsjWarningHide()
            lstDatos.Items.Add(txtNombre.Text + " " + txtApellido.Text)
            MsjSuccess()
            LimpiarTextBox()
            Await Task.Delay(3000)
            MsjSuccessHide()
        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTextBox()
    End Sub

#End Region

End Class
