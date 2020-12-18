<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Gbx_Datosclientes = New System.Windows.Forms.GroupBox()
        Me.Txt_RazonSocial = New System.Windows.Forms.TextBox()
        Me.Txt_Numero = New System.Windows.Forms.TextBox()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Cbo_TipoDocu = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnFactura = New System.Windows.Forms.RadioButton()
        Me.btnBoleta = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Txt_Cantidad = New System.Windows.Forms.TextBox()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.Btn_Limpíar = New System.Windows.Forms.Button()
        Me.Cbo_Producto = New System.Windows.Forms.ComboBox()
        Me.Lbl_Precio = New System.Windows.Forms.Label()
        Me.Cbo_Categoria = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btn_Nuevo = New System.Windows.Forms.Button()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Lbl_Total = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Lbl_IGV = New System.Windows.Forms.Label()
        Me.Lbl_BaseImponible = New System.Windows.Forms.Label()
        Me.Lbx_SubTotal = New System.Windows.Forms.ListBox()
        Me.Lbx_Cantidad = New System.Windows.Forms.ListBox()
        Me.Lbx_Precio = New System.Windows.Forms.ListBox()
        Me.Lbx_Producto = New System.Windows.Forms.ListBox()
        Me.Lbx_Item = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Gbx_Datosclientes.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Datosclientes
        '
        Me.Gbx_Datosclientes.BackColor = System.Drawing.Color.DarkGray
        Me.Gbx_Datosclientes.Controls.Add(Me.Txt_RazonSocial)
        Me.Gbx_Datosclientes.Controls.Add(Me.Txt_Numero)
        Me.Gbx_Datosclientes.Controls.Add(Me.Btn_Limpiar)
        Me.Gbx_Datosclientes.Controls.Add(Me.Cbo_TipoDocu)
        Me.Gbx_Datosclientes.Controls.Add(Me.Label8)
        Me.Gbx_Datosclientes.Controls.Add(Me.Label2)
        Me.Gbx_Datosclientes.Controls.Add(Me.Label1)
        Me.Gbx_Datosclientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbx_Datosclientes.Location = New System.Drawing.Point(12, 12)
        Me.Gbx_Datosclientes.Name = "Gbx_Datosclientes"
        Me.Gbx_Datosclientes.Size = New System.Drawing.Size(463, 128)
        Me.Gbx_Datosclientes.TabIndex = 0
        Me.Gbx_Datosclientes.TabStop = False
        Me.Gbx_Datosclientes.Text = "Datos cliente"
        '
        'Txt_RazonSocial
        '
        Me.Txt_RazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_RazonSocial.Location = New System.Drawing.Point(129, 71)
        Me.Txt_RazonSocial.Name = "Txt_RazonSocial"
        Me.Txt_RazonSocial.Size = New System.Drawing.Size(189, 22)
        Me.Txt_RazonSocial.TabIndex = 8
        '
        'Txt_Numero
        '
        Me.Txt_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Numero.Location = New System.Drawing.Point(352, 30)
        Me.Txt_Numero.Name = "Txt_Numero"
        Me.Txt_Numero.Size = New System.Drawing.Size(104, 22)
        Me.Txt_Numero.TabIndex = 7
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Limpiar.ForeColor = System.Drawing.Color.White
        Me.Btn_Limpiar.Location = New System.Drawing.Point(324, 65)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(104, 33)
        Me.Btn_Limpiar.TabIndex = 6
        Me.Btn_Limpiar.Text = "Limpiar"
        Me.Btn_Limpiar.UseVisualStyleBackColor = False
        '
        'Cbo_TipoDocu
        '
        Me.Cbo_TipoDocu.BackColor = System.Drawing.Color.White
        Me.Cbo_TipoDocu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_TipoDocu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_TipoDocu.FormattingEnabled = True
        Me.Cbo_TipoDocu.Items.AddRange(New Object() {"Elegir", "DNI", "RUC"})
        Me.Cbo_TipoDocu.Location = New System.Drawing.Point(159, 32)
        Me.Cbo_TipoDocu.Name = "Cbo_TipoDocu"
        Me.Cbo_TipoDocu.Size = New System.Drawing.Size(121, 24)
        Me.Cbo_TipoDocu.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(279, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Numero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre/razon"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de documento"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SpringGreen
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.btnFactura)
        Me.GroupBox1.Controls.Add(Me.btnBoleta)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(481, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 128)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "l"
        '
        'lblFecha
        '
        Me.lblFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(67, 8)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(118, 23)
        Me.lblFecha.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(64, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 15)
        Me.Label14.TabIndex = 4
        '
        'btnFactura
        '
        Me.btnFactura.AutoSize = True
        Me.btnFactura.Location = New System.Drawing.Point(55, 89)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(61, 17)
        Me.btnFactura.TabIndex = 3
        Me.btnFactura.TabStop = True
        Me.btnFactura.Text = "Factura"
        Me.btnFactura.UseVisualStyleBackColor = True
        '
        'btnBoleta
        '
        Me.btnBoleta.AutoSize = True
        Me.btnBoleta.Location = New System.Drawing.Point(55, 51)
        Me.btnBoleta.Name = "btnBoleta"
        Me.btnBoleta.Size = New System.Drawing.Size(55, 17)
        Me.btnBoleta.TabIndex = 2
        Me.btnBoleta.TabStop = True
        Me.btnBoleta.Text = "Boleta"
        Me.btnBoleta.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Lipo de documeto"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Txt_Cantidad)
        Me.GroupBox2.Controls.Add(Me.Btn_Limpíar)
        Me.GroupBox2.Controls.Add(Me.Cbo_Producto)
        Me.GroupBox2.Controls.Add(Me.Lbl_Precio)
        Me.GroupBox2.Controls.Add(Me.Cbo_Categoria)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(21, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(767, 119)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de producto"
        '
        'Txt_Cantidad
        '
        Me.Txt_Cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Cantidad.Location = New System.Drawing.Point(442, 74)
        Me.Txt_Cantidad.Name = "Txt_Cantidad"
        Me.Txt_Cantidad.Size = New System.Drawing.Size(88, 22)
        Me.Txt_Cantidad.TabIndex = 14
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Btn_Agregar.ForeColor = System.Drawing.Color.White
        Me.Btn_Agregar.Location = New System.Drawing.Point(661, -1)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(100, 39)
        Me.Btn_Agregar.TabIndex = 13
        Me.Btn_Agregar.Text = "Imprimir"
        Me.Btn_Agregar.UseVisualStyleBackColor = False
        '
        'Btn_Limpíar
        '
        Me.Btn_Limpíar.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn_Limpíar.ForeColor = System.Drawing.Color.White
        Me.Btn_Limpíar.Location = New System.Drawing.Point(655, 29)
        Me.Btn_Limpíar.Name = "Btn_Limpíar"
        Me.Btn_Limpíar.Size = New System.Drawing.Size(82, 34)
        Me.Btn_Limpíar.TabIndex = 12
        Me.Btn_Limpíar.Text = "Limpiar"
        Me.Btn_Limpíar.UseVisualStyleBackColor = False
        '
        'Cbo_Producto
        '
        Me.Cbo_Producto.BackColor = System.Drawing.Color.White
        Me.Cbo_Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Producto.FormattingEnabled = True
        Me.Cbo_Producto.Location = New System.Drawing.Point(425, 29)
        Me.Cbo_Producto.Name = "Cbo_Producto"
        Me.Cbo_Producto.Size = New System.Drawing.Size(187, 24)
        Me.Cbo_Producto.TabIndex = 11
        '
        'Lbl_Precio
        '
        Me.Lbl_Precio.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbl_Precio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Precio.Location = New System.Drawing.Point(117, 74)
        Me.Lbl_Precio.Name = "Lbl_Precio"
        Me.Lbl_Precio.Size = New System.Drawing.Size(72, 23)
        Me.Lbl_Precio.TabIndex = 10
        '
        'Cbo_Categoria
        '
        Me.Cbo_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Categoria.FormattingEnabled = True
        Me.Cbo_Categoria.Items.AddRange(New Object() {"Seleccione una Categoria", "Deportes", "Guerras", "Zombies", "Carreras", "Otros"})
        Me.Cbo_Categoria.Location = New System.Drawing.Point(117, 33)
        Me.Cbo_Categoria.Name = "Cbo_Categoria"
        Me.Cbo_Categoria.Size = New System.Drawing.Size(190, 28)
        Me.Cbo_Categoria.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(338, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cantidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(339, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "precio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Categoria"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Btn_Nuevo)
        Me.GroupBox3.Controls.Add(Me.Btn_Agregar)
        Me.GroupBox3.Controls.Add(Me.Btn_Eliminar)
        Me.GroupBox3.Controls.Add(Me.Lbl_Total)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Lbl_IGV)
        Me.GroupBox3.Controls.Add(Me.Lbl_BaseImponible)
        Me.GroupBox3.Controls.Add(Me.Lbx_SubTotal)
        Me.GroupBox3.Controls.Add(Me.Lbx_Cantidad)
        Me.GroupBox3.Controls.Add(Me.Lbx_Precio)
        Me.GroupBox3.Controls.Add(Me.Lbx_Producto)
        Me.GroupBox3.Controls.Add(Me.Lbx_Item)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 271)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(767, 272)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle venta"
        '
        'Btn_Nuevo
        '
        Me.Btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nuevo.ForeColor = System.Drawing.Color.White
        Me.Btn_Nuevo.Location = New System.Drawing.Point(661, 162)
        Me.Btn_Nuevo.Name = "Btn_Nuevo"
        Me.Btn_Nuevo.Size = New System.Drawing.Size(82, 34)
        Me.Btn_Nuevo.TabIndex = 17
        Me.Btn_Nuevo.Text = "Nuevo"
        Me.Btn_Nuevo.UseVisualStyleBackColor = False
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.BackColor = System.Drawing.Color.Red
        Me.Btn_Eliminar.ForeColor = System.Drawing.Color.White
        Me.Btn_Eliminar.Location = New System.Drawing.Point(663, 112)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(82, 34)
        Me.Btn_Eliminar.TabIndex = 16
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = False
        '
        'Lbl_Total
        '
        Me.Lbl_Total.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbl_Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Total.Location = New System.Drawing.Point(383, 242)
        Me.Lbl_Total.Name = "Lbl_Total"
        Me.Lbl_Total.Size = New System.Drawing.Size(91, 23)
        Me.Lbl_Total.TabIndex = 15
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(233, 241)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(144, 24)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Total a pagar :"
        '
        'Lbl_IGV
        '
        Me.Lbl_IGV.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_IGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_IGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_IGV.Location = New System.Drawing.Point(126, 234)
        Me.Lbl_IGV.Name = "Lbl_IGV"
        Me.Lbl_IGV.Size = New System.Drawing.Size(89, 23)
        Me.Lbl_IGV.TabIndex = 13
        Me.Lbl_IGV.Visible = False
        '
        'Lbl_BaseImponible
        '
        Me.Lbl_BaseImponible.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_BaseImponible.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_BaseImponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_BaseImponible.ForeColor = System.Drawing.Color.Black
        Me.Lbl_BaseImponible.Location = New System.Drawing.Point(17, 234)
        Me.Lbl_BaseImponible.Name = "Lbl_BaseImponible"
        Me.Lbl_BaseImponible.Size = New System.Drawing.Size(84, 23)
        Me.Lbl_BaseImponible.TabIndex = 11
        Me.Lbl_BaseImponible.Visible = False
        '
        'Lbx_SubTotal
        '
        Me.Lbx_SubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbx_SubTotal.FormattingEnabled = True
        Me.Lbx_SubTotal.ItemHeight = 16
        Me.Lbx_SubTotal.Location = New System.Drawing.Point(509, 45)
        Me.Lbx_SubTotal.Name = "Lbx_SubTotal"
        Me.Lbx_SubTotal.Size = New System.Drawing.Size(146, 180)
        Me.Lbx_SubTotal.TabIndex = 9
        '
        'Lbx_Cantidad
        '
        Me.Lbx_Cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbx_Cantidad.FormattingEnabled = True
        Me.Lbx_Cantidad.ItemHeight = 16
        Me.Lbx_Cantidad.Location = New System.Drawing.Point(425, 45)
        Me.Lbx_Cantidad.Name = "Lbx_Cantidad"
        Me.Lbx_Cantidad.Size = New System.Drawing.Size(71, 180)
        Me.Lbx_Cantidad.TabIndex = 8
        '
        'Lbx_Precio
        '
        Me.Lbx_Precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbx_Precio.FormattingEnabled = True
        Me.Lbx_Precio.ItemHeight = 18
        Me.Lbx_Precio.Location = New System.Drawing.Point(345, 45)
        Me.Lbx_Precio.Name = "Lbx_Precio"
        Me.Lbx_Precio.Size = New System.Drawing.Size(74, 184)
        Me.Lbx_Precio.TabIndex = 7
        '
        'Lbx_Producto
        '
        Me.Lbx_Producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbx_Producto.FormattingEnabled = True
        Me.Lbx_Producto.ItemHeight = 18
        Me.Lbx_Producto.Location = New System.Drawing.Point(115, 45)
        Me.Lbx_Producto.Name = "Lbx_Producto"
        Me.Lbx_Producto.Size = New System.Drawing.Size(224, 184)
        Me.Lbx_Producto.TabIndex = 6
        '
        'Lbx_Item
        '
        Me.Lbx_Item.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbx_Item.FormattingEnabled = True
        Me.Lbx_Item.ItemHeight = 20
        Me.Lbx_Item.Location = New System.Drawing.Point(18, 45)
        Me.Lbx_Item.Name = "Lbx_Item"
        Me.Lbx_Item.Size = New System.Drawing.Size(83, 184)
        Me.Lbx_Item.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(537, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 18)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Sub_Total"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(422, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 18)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Cantidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(349, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 18)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Precio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(201, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 18)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Producto"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Item"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(195, 76)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 20)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "Bs"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(480, 247)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 18)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Bs"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.ForeColor = System.Drawing.Color.Gold
        Me.Button1.Location = New System.Drawing.Point(664, 233)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Final_progra2.My.Resources.Resources.fondo_fin_partida
        Me.ClientSize = New System.Drawing.Size(800, 555)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Gbx_Datosclientes)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.Gbx_Datosclientes.ResumeLayout(False)
        Me.Gbx_Datosclientes.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Gbx_Datosclientes As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnFactura As RadioButton
    Friend WithEvents btnBoleta As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Btn_Limpiar As Button
    Friend WithEvents Cbo_TipoDocu As ComboBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Btn_Agregar As Button
    Friend WithEvents Btn_Limpíar As Button
    Friend WithEvents Cbo_Producto As ComboBox
    Friend WithEvents Lbl_Precio As Label
    Friend WithEvents Cbo_Categoria As ComboBox
    Friend WithEvents Btn_Nuevo As Button
    Friend WithEvents Btn_Eliminar As Button
    Friend WithEvents Lbl_Total As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Lbl_IGV As Label
    Friend WithEvents Lbl_BaseImponible As Label
    Friend WithEvents Lbx_SubTotal As ListBox
    Friend WithEvents Lbx_Cantidad As ListBox
    Friend WithEvents Lbx_Precio As ListBox
    Friend WithEvents Lbx_Producto As ListBox
    Friend WithEvents Lbx_Item As ListBox
    Friend WithEvents Txt_Cantidad As TextBox
    Friend WithEvents Txt_Numero As TextBox
    Friend WithEvents Txt_RazonSocial As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label15 As Label
End Class
