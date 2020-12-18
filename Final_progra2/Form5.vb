Imports ClassLibrary1
Public Class Form5
    Dim obj As New Class1

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView2.DataSource = obj.ListarEmpleados
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        Form4.Visible = True
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class
