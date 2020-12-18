Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox4.Text = TextBox3.Text Then
            My.Settings.Usuario = TextBox1.Text
            My.Settings.Save()
            My.Settings.Reload()

            My.Settings.Email = TextBox2.Text
            My.Settings.Save()
            My.Settings.Reload()

            My.Settings.Clave = TextBox3.Text
            My.Settings.Save()
            My.Settings.Reload()
            Label5.Visible = False
            Label6.Visible = True
        Else
            Label5.Visible = True

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

            If TextBox5.Text = My.Settings.Usuario And TextBox6.Text = My.Settings.Clave Then

            Me.Visible = False
            Form2.Visible = True


        Else
                Label11.Visible = True

            End If

        End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
