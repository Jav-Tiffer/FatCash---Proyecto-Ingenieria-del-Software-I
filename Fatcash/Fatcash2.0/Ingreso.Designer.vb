<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingreso
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
        Me.lbl_ingresarI = New System.Windows.Forms.Label()
        Me.lbl_fatcash3 = New System.Windows.Forms.Label()
        Me.txt_fechaI = New System.Windows.Forms.TextBox()
        Me.lbl_fechaI = New System.Windows.Forms.Label()
        Me.cmb_tingresoI = New System.Windows.Forms.ComboBox()
        Me.txt_gastoI = New System.Windows.Forms.TextBox()
        Me.lbl_tgastoI = New System.Windows.Forms.Label()
        Me.lbl_gastoI = New System.Windows.Forms.Label()
        Me.cmb_tgastoI = New System.Windows.Forms.ComboBox()
        Me.lbl_tingresoI = New System.Windows.Forms.Label()
        Me.btn_aceptarI = New System.Windows.Forms.Button()
        Me.txt_ingresoI = New System.Windows.Forms.TextBox()
        Me.lbl_ingresoI = New System.Windows.Forms.Label()
        Me.btn_volverI = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pb_cash3 = New System.Windows.Forms.PictureBox()
        Me.Panel4.SuspendLayout()
        CType(Me.pb_cash3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_ingresarI
        '
        Me.lbl_ingresarI.AutoSize = True
        Me.lbl_ingresarI.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ingresarI.Location = New System.Drawing.Point(156, 70)
        Me.lbl_ingresarI.Name = "lbl_ingresarI"
        Me.lbl_ingresarI.Size = New System.Drawing.Size(141, 38)
        Me.lbl_ingresarI.TabIndex = 24
        Me.lbl_ingresarI.Text = "Ingresar"
        '
        'lbl_fatcash3
        '
        Me.lbl_fatcash3.AutoSize = True
        Me.lbl_fatcash3.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fatcash3.Location = New System.Drawing.Point(14, 16)
        Me.lbl_fatcash3.Name = "lbl_fatcash3"
        Me.lbl_fatcash3.Size = New System.Drawing.Size(154, 38)
        Me.lbl_fatcash3.TabIndex = 23
        Me.lbl_fatcash3.Text = "FATCASH"
        '
        'txt_fechaI
        '
        Me.txt_fechaI.ForeColor = System.Drawing.Color.Black
        Me.txt_fechaI.Location = New System.Drawing.Point(31, 404)
        Me.txt_fechaI.Name = "txt_fechaI"
        Me.txt_fechaI.Size = New System.Drawing.Size(191, 20)
        Me.txt_fechaI.TabIndex = 21
        '
        'lbl_fechaI
        '
        Me.lbl_fechaI.AutoSize = True
        Me.lbl_fechaI.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fechaI.Location = New System.Drawing.Point(27, 368)
        Me.lbl_fechaI.Name = "lbl_fechaI"
        Me.lbl_fechaI.Size = New System.Drawing.Size(154, 22)
        Me.lbl_fechaI.TabIndex = 20
        Me.lbl_fechaI.Text = "Fecha (YYYY-MM-DD)"
        '
        'cmb_tingresoI
        '
        Me.cmb_tingresoI.FormattingEnabled = True
        Me.cmb_tingresoI.Items.AddRange(New Object() {"Salario", "Prestamos", "Mesada", "Ventas", "Otro"})
        Me.cmb_tingresoI.Location = New System.Drawing.Point(31, 155)
        Me.cmb_tingresoI.Name = "cmb_tingresoI"
        Me.cmb_tingresoI.Size = New System.Drawing.Size(191, 21)
        Me.cmb_tingresoI.TabIndex = 18
        '
        'txt_gastoI
        '
        Me.txt_gastoI.Location = New System.Drawing.Point(31, 241)
        Me.txt_gastoI.Name = "txt_gastoI"
        Me.txt_gastoI.Size = New System.Drawing.Size(191, 20)
        Me.txt_gastoI.TabIndex = 17
        '
        'lbl_tgastoI
        '
        Me.lbl_tgastoI.AutoSize = True
        Me.lbl_tgastoI.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tgastoI.Location = New System.Drawing.Point(27, 288)
        Me.lbl_tgastoI.Name = "lbl_tgastoI"
        Me.lbl_tgastoI.Size = New System.Drawing.Size(105, 22)
        Me.lbl_tgastoI.TabIndex = 16
        Me.lbl_tgastoI.Text = "Tipo de gasto"
        '
        'lbl_gastoI
        '
        Me.lbl_gastoI.AutoSize = True
        Me.lbl_gastoI.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gastoI.Location = New System.Drawing.Point(27, 200)
        Me.lbl_gastoI.Name = "lbl_gastoI"
        Me.lbl_gastoI.Size = New System.Drawing.Size(144, 22)
        Me.lbl_gastoI.TabIndex = 15
        Me.lbl_gastoI.Text = "Cantidad de gastos"
        '
        'cmb_tgastoI
        '
        Me.cmb_tgastoI.FormattingEnabled = True
        Me.cmb_tgastoI.Items.AddRange(New Object() {"Comida", "Deudas", "Compras", "Transporte", "Servicios", "Otro"})
        Me.cmb_tgastoI.Location = New System.Drawing.Point(31, 326)
        Me.cmb_tgastoI.Name = "cmb_tgastoI"
        Me.cmb_tgastoI.Size = New System.Drawing.Size(191, 21)
        Me.cmb_tgastoI.TabIndex = 13
        '
        'lbl_tingresoI
        '
        Me.lbl_tingresoI.AutoSize = True
        Me.lbl_tingresoI.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tingresoI.Location = New System.Drawing.Point(27, 112)
        Me.lbl_tingresoI.Name = "lbl_tingresoI"
        Me.lbl_tingresoI.Size = New System.Drawing.Size(119, 22)
        Me.lbl_tingresoI.TabIndex = 8
        Me.lbl_tingresoI.Text = "Tipo de ingreso"
        '
        'btn_aceptarI
        '
        Me.btn_aceptarI.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_aceptarI.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptarI.ForeColor = System.Drawing.Color.White
        Me.btn_aceptarI.Location = New System.Drawing.Point(87, 445)
        Me.btn_aceptarI.Name = "btn_aceptarI"
        Me.btn_aceptarI.Size = New System.Drawing.Size(100, 32)
        Me.btn_aceptarI.TabIndex = 7
        Me.btn_aceptarI.Text = "Aceptar"
        Me.btn_aceptarI.UseVisualStyleBackColor = False
        '
        'txt_ingresoI
        '
        Me.txt_ingresoI.Location = New System.Drawing.Point(31, 67)
        Me.txt_ingresoI.Name = "txt_ingresoI"
        Me.txt_ingresoI.Size = New System.Drawing.Size(191, 20)
        Me.txt_ingresoI.TabIndex = 4
        '
        'lbl_ingresoI
        '
        Me.lbl_ingresoI.AutoSize = True
        Me.lbl_ingresoI.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ingresoI.Location = New System.Drawing.Point(27, 24)
        Me.lbl_ingresoI.Name = "lbl_ingresoI"
        Me.lbl_ingresoI.Size = New System.Drawing.Size(158, 22)
        Me.lbl_ingresoI.TabIndex = 3
        Me.lbl_ingresoI.Text = "Cantidad de ingresos"
        '
        'btn_volverI
        '
        Me.btn_volverI.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_volverI.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volverI.ForeColor = System.Drawing.Color.White
        Me.btn_volverI.Location = New System.Drawing.Point(12, 622)
        Me.btn_volverI.Name = "btn_volverI"
        Me.btn_volverI.Size = New System.Drawing.Size(100, 32)
        Me.btn_volverI.TabIndex = 25
        Me.btn_volverI.Text = "Volver"
        Me.btn_volverI.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel4.Controls.Add(Me.txt_fechaI)
        Me.Panel4.Controls.Add(Me.lbl_fechaI)
        Me.Panel4.Controls.Add(Me.cmb_tingresoI)
        Me.Panel4.Controls.Add(Me.txt_gastoI)
        Me.Panel4.Controls.Add(Me.lbl_tgastoI)
        Me.Panel4.Controls.Add(Me.lbl_gastoI)
        Me.Panel4.Controls.Add(Me.cmb_tgastoI)
        Me.Panel4.Controls.Add(Me.lbl_tingresoI)
        Me.Panel4.Controls.Add(Me.btn_aceptarI)
        Me.Panel4.Controls.Add(Me.txt_ingresoI)
        Me.Panel4.Controls.Add(Me.lbl_ingresoI)
        Me.Panel4.Location = New System.Drawing.Point(85, 125)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(280, 491)
        Me.Panel4.TabIndex = 22
        '
        'pb_cash3
        '
        Me.pb_cash3.Image = Global.Fatcash2._0.My.Resources.Resources.image_1
        Me.pb_cash3.Location = New System.Drawing.Point(363, 9)
        Me.pb_cash3.Name = "pb_cash3"
        Me.pb_cash3.Size = New System.Drawing.Size(60, 45)
        Me.pb_cash3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_cash3.TabIndex = 21
        Me.pb_cash3.TabStop = False
        '
        'Ingreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 662)
        Me.Controls.Add(Me.pb_cash3)
        Me.Controls.Add(Me.lbl_ingresarI)
        Me.Controls.Add(Me.lbl_fatcash3)
        Me.Controls.Add(Me.btn_volverI)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "Ingreso"
        Me.Text = "Ingreso"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.pb_cash3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_cash3 As PictureBox
    Friend WithEvents lbl_ingresarI As Label
    Friend WithEvents lbl_fatcash3 As Label
    Friend WithEvents txt_fechaI As TextBox
    Friend WithEvents lbl_fechaI As Label
    Friend WithEvents cmb_tingresoI As ComboBox
    Friend WithEvents txt_gastoI As TextBox
    Friend WithEvents lbl_tgastoI As Label
    Friend WithEvents lbl_gastoI As Label
    Friend WithEvents cmb_tgastoI As ComboBox
    Friend WithEvents lbl_tingresoI As Label
    Friend WithEvents btn_aceptarI As Button
    Friend WithEvents txt_ingresoI As TextBox
    Friend WithEvents lbl_ingresoI As Label
    Friend WithEvents btn_volverI As Button
    Friend WithEvents Panel4 As Panel
End Class
