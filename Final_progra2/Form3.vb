Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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