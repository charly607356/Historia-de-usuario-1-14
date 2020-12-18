Public Class Form6
    Dim item As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFecha.Text = Now.Date
        Cbo_Categoria.SelectedIndex = 0
        Cbo_TipoDocu.SelectedIndex = 0
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        If (MsgBox("¿Esta seguro de salir?", vbCritical + vbYesNo) = vbYes) Then
            Me.Close()
        Else
            sender = 1
        End If
    End Sub

    Private Sub Cbo_TipoDocu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_TipoDocu.SelectedIndexChanged

        If (Cbo_TipoDocu.SelectedIndex = 0) Then
            Txt_Numero.Enabled = False
        ElseIf (Cbo_TipoDocu.SelectedIndex = 1) Then
            Txt_Numero.MaxLength = 8
            Txt_Numero.Enabled = True
        ElseIf (Cbo_TipoDocu.SelectedIndex = 2) Then
            Txt_Numero.MaxLength = 11
            Txt_Numero.Enabled = True
        End If
    End Sub

    Private Sub Txt_RazonSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_RazonSocial.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Introduzca solo letras", , "Aviso")
        End If
    End Sub

    Private Sub Txt_Numero_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Numero.KeyDown
        If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue = 8)) Then
            e.Handled = True
            MsgBox("Error solo requiere numeros")
            Txt_Numero.Text = vbNullChar

        End If
    End Sub

    Private Sub Txt_Cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Cantidad.KeyDown
        If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue = 8)) Then
            e.Handled = True
            MsgBox("Error solo requiere numeros")
            Txt_Cantidad.Text = vbNullChar

        End If
    End Sub

    Private Sub Cbo_Categoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Categoria.SelectedIndexChanged
        Dim pos As Integer
        pos = Cbo_Categoria.SelectedIndex
        Select Case (pos)
            Case 0
            Case 1 : llenarDeportes()
            Case 2 : llenarGuerras()
            Case 3 : llenarZombies()
            Case 4 : llenarCarreras()
            Case 5 : llenarOtros()
        End Select
    End Sub
    Private Sub llenarDeportes()
        Cbo_Producto.Items.Clear()
        Cbo_Producto.Items.Add("MLB The Show 20")
        Cbo_Producto.Items.Add("NBA 2K (Serie)")
        Cbo_Producto.Items.Add("FIFA 20")
    End Sub
    Private Sub llenarGuerras()
        Cbo_Producto.Items.Clear()
        Cbo_Producto.Items.Add("Call of Duty: Black Ops - Annihilation")
        Cbo_Producto.Items.Add("Battlefield: Bad Company 2: VIP")
        Cbo_Producto.Items.Add("Karma : Operation Barbarossa")
    End Sub
    Private Sub llenarZombies()
        Cbo_Producto.Items.Clear()
        Cbo_Producto.Items.Add("Zombie Army 4: Dead War")
        Cbo_Producto.Items.Add("SParty Hard")
        Cbo_Producto.Items.Add("Borderlands: La Isla Zombie")
    End Sub
    Private Sub llenarCarreras()
        Cbo_Producto.Items.Clear()
        Cbo_Producto.Items.Add("Rocket LeagueRocket")
        Cbo_Producto.Items.Add("Need for Speed: Hot Pursuit Remastered")
        Cbo_Producto.Items.Add("Mario Kart Live: Home Circuit")
    End Sub
    Private Sub llenarOtros()
        Cbo_Producto.Items.Clear()
        Cbo_Producto.Items.Add("Call of Duty Black Ops Cold War")
        Cbo_Producto.Items.Add("Barbarian Simulator")
        Cbo_Producto.Items.Add("Crossfire 2")
    End Sub

    Private Sub Btn_Limpiar_Click(sender As Object, e As EventArgs) Handles Btn_Limpiar.Click
        Txt_Numero.Text = ""
        Cbo_TipoDocu.SelectedIndex = 0
        Txt_RazonSocial.Text = ""
    End Sub

    Private Sub Cbo_Producto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Producto.SelectedIndexChanged
        If (Cbo_Categoria.SelectedIndex = 1) Then
            If (Cbo_Producto.SelectedIndex = 0) Then
                Lbl_Precio.Text = 160.0.ToString("")
            ElseIf (Cbo_Producto.SelectedIndex = 1) Then
                Lbl_Precio.Text = 150.0.ToString("")
            ElseIf (Cbo_Producto.SelectedIndex = 2) Then
                Lbl_Precio.Text = 140.0.ToString("")
            End If
        End If

        If (Cbo_Categoria.SelectedIndex = 2) Then
            If (Cbo_Producto.SelectedIndex = 0) Then
                Lbl_Precio.Text = 90.0.ToString("")
            ElseIf (Cbo_Producto.SelectedIndex = 1) Then
                Lbl_Precio.Text = 100.0.ToString("")
            ElseIf (Cbo_Producto.SelectedIndex = 2) Then
                Lbl_Precio.Text = 200.0.ToString("")
            End If
        End If

        If (Cbo_Categoria.SelectedIndex = 3) Then
            If (Cbo_Producto.SelectedIndex = 0) Then
                Lbl_Precio.Text = 150.0.ToString("")
            ElseIf (Cbo_Producto.SelectedIndex = 1) Then
                Lbl_Precio.Text = 140.0.ToString("")
            ElseIf (Cbo_Producto.SelectedIndex = 2) Then
                Lbl_Precio.Text = 120.0.ToString("")
            End If
        End If

        If (Cbo_Categoria.SelectedIndex = 4) Then
            If (Cbo_Producto.SelectedIndex = 0) Then
                Lbl_Precio.Text = 180.0.ToString("")
            ElseIf (Cbo_Producto.SelectedIndex = 1) Then
                Lbl_Precio.Text = 150.0.ToString("")
            ElseIf (Cbo_Producto.SelectedIndex = 2) Then
                Lbl_Precio.Text = 120.0.ToString("")
            End If
        End If

        If (Cbo_Categoria.SelectedIndex = 5) Then
            If (Cbo_Producto.SelectedIndex = 0) Then
                Lbl_Precio.Text = 200.0.ToString("")
            ElseIf (Cbo_Producto.SelectedIndex = 1) Then
                Lbl_Precio.Text = 250.0.ToString("")
            ElseIf (Cbo_Producto.SelectedIndex = 2) Then
                Lbl_Precio.Text = 150.0.ToString("")
            End If
        End If

    End Sub

    Private Sub Btn_Limpíar_Click(sender As Object, e As EventArgs) Handles Btn_Limpíar.Click
        Cbo_Categoria.SelectedIndex = 0
        Cbo_Producto.SelectedIndex = -1
        Lbl_Precio.Text = 0.0.ToString("")
        Txt_Cantidad.Text = ""
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        Dim categoria, producto As Integer
        'Dim cantidad As Integer
        'cantidad = Txt_Cantidad.Text
        categoria = Cbo_Categoria.SelectedIndex
        producto = Cbo_Producto.SelectedIndex

        If (Cbo_Categoria.SelectedIndex = 0) Then
            MsgBox("Porfavor Seleccione una Categoria", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Sistema")
            Cbo_Categoria.DroppedDown = True
        ElseIf (Cbo_Producto.SelectedIndex = -1) Then
            MsgBox("Porfavor Seleccione un Producto", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Sistema")
            Cbo_Producto.DroppedDown = True
        ElseIf (Txt_Cantidad.Text = "") Then
            MsgBox("Ingrese la cantidad", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Sistema")
            Txt_Cantidad.Focus()

        ElseIf (Txt_Cantidad.Text <> "0") Then
            item = item + 1
            Lbx_Item.Items.Add(item)
            Lbx_Cantidad.Items.Add(Txt_Cantidad.Text)
            Lbx_Producto.Items.Add(Cbo_Producto.SelectedItem.ToString)
            Lbx_Precio.Items.Add(Lbl_Precio.Text).ToString("c")
            Lbx_SubTotal.Items.Add(CDbl(Lbl_Precio.Text) * Txt_Cantidad.Text)

            If (btnBoleta.Checked = True) Then
                Calcular()
            Else
                Impuesto()
            End If
        Else
            MsgBox("Ingrese cantidad válida!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Sistema")
            Txt_Cantidad.Focus()
        End If
    End Sub
    Private Sub Calcular()
        Dim total As Double
        For i = 0 To Lbx_SubTotal.Items.Count - 1
            total = total + Lbx_SubTotal.Items.Item(i)
        Next
        Lbl_Total.Text = "/. " & total
        Lbl_IGV.Text = "/.0.0"
        Lbl_BaseImponible.Text = "/. " & total

    End Sub

    Private Sub Impuesto()
        Dim igv, baseImponible, total As Double
        For i = 0 To Lbx_SubTotal.Items.Count - 1
            total = total + Lbx_SubTotal.Items.Item(i)
        Next
        Lbl_Total.Text = total.ToString("")
        baseImponible = (total / 1.18).ToString("")
        igv = (total - baseImponible).ToString("")
        Lbl_BaseImponible.Text = baseImponible.ToString("")
        Lbl_IGV.Text = igv.ToString("")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Nuevo.Click
        'Limpiando Datos del Cliente
        Cbo_TipoDocu.SelectedIndex = 0
        Txt_Numero.Text = ""
        Txt_RazonSocial.Text = ""
        'Limpiando Datos de los Productos
        Cbo_Categoria.SelectedIndex = 0
        Cbo_Producto.SelectedIndex = -1
        Txt_Cantidad.Text = ""
        Lbl_Precio.Text = ""
        'Limpiando Datos del Detalle
        Lbx_Item.Items.Clear()
        Lbx_Producto.Items.Clear()
        Lbx_Precio.Items.Clear()
        Lbx_Cantidad.Items.Clear()
        Lbx_SubTotal.Items.Clear()
        'Limpiando Costos
        Lbl_BaseImponible.Text = ""
        Lbl_IGV.Text = ""
        Lbl_Total.Text = ""

    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Dim i As Integer
        i = Lbx_Item.SelectedIndex()
        If (i >= 0) Then
            item = item - 1
            Lbx_Producto.Items.RemoveAt(i)
            Lbx_Precio.Items.RemoveAt(i)
            Lbx_SubTotal.Items.RemoveAt(i)
            Lbx_Cantidad.Items.RemoveAt(i)
            Lbx_Item.Items.RemoveAt(item)

            If (btnBoleta.Checked = True) Then
                Calcular()
            Else
                Impuesto()
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
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
