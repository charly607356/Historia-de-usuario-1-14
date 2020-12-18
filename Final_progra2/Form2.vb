Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = My.Settings.Usuario
        Label6.Text = My.Settings.Email

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Visible = False
        Form3.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        Form4.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        Form6.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False
        Form7.Visible = True
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
        Form1.Visible = True
    End Sub
End Class