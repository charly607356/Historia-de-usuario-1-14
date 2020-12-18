Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = My.Settings.Usuario
        Label6.Text = My.Settings.Email
        Label5.Text = My.Settings.Clave
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim texto As String
        Dim Estilo As MsgBoxStyle
        Dim Respuesta As MsgBoxResult
        Dim titu As String

        texto = "Esta seguro que desea salir"
        Estilo = MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo
        titu = "saliendo......"

        Respuesta = MsgBox(texto, Estilo, titu)
        If Respuesta = MsgBoxResult.Yes Then

        End If


        Me.Visible = False
        Form2.Visible = True
    End Sub
End Class