<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte
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
        Me.pb_cash5 = New System.Windows.Forms.PictureBox()
        Me.lbl_reporteR2 = New System.Windows.Forms.Label()
        Me.lbl_gastos = New System.Windows.Forms.Label()
        Me.lbl_Ingresos = New System.Windows.Forms.Label()
        Me.txt_fechaR = New System.Windows.Forms.TextBox()
        Me.btn_aceptarR2 = New System.Windows.Forms.Button()
        Me.lbl_fechaR = New System.Windows.Forms.Label()
        Me.lbl_fatcash5 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btn_volverR2 = New System.Windows.Forms.Button()
        CType(Me.pb_cash5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'pb_cash5
        '
        Me.pb_cash5.Image = Global.Fatcash2._0.My.Resources.Resources.image_1
        Me.pb_cash5.Location = New System.Drawing.Point(360, 11)
        Me.pb_cash5.Name = "pb_cash5"
        Me.pb_cash5.Size = New System.Drawing.Size(60, 45)
        Me.pb_cash5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_cash5.TabIndex = 31
        Me.pb_cash5.TabStop = False
        '
        'lbl_reporteR2
        '
        Me.lbl_reporteR2.AutoSize = True
        Me.lbl_reporteR2.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_reporteR2.Location = New System.Drawing.Point(151, 74)
        Me.lbl_reporteR2.Name = "lbl_reporteR2"
        Me.lbl_reporteR2.Size = New System.Drawing.Size(134, 38)
        Me.lbl_reporteR2.TabIndex = 34
        Me.lbl_reporteR2.Text = "Reporte"
        '
        'lbl_gastos
        '
        Me.lbl_gastos.AutoSize = True
        Me.lbl_gastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gastos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_gastos.Location = New System.Drawing.Point(24, 301)
        Me.lbl_gastos.Name = "lbl_gastos"
        Me.lbl_gastos.Size = New System.Drawing.Size(61, 20)
        Me.lbl_gastos.TabIndex = 20
        Me.lbl_gastos.Text = "Gastos"
        '
        'lbl_Ingresos
        '
        Me.lbl_Ingresos.AutoSize = True
        Me.lbl_Ingresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Ingresos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Ingresos.Location = New System.Drawing.Point(24, 184)
        Me.lbl_Ingresos.Name = "lbl_Ingresos"
        Me.lbl_Ingresos.Size = New System.Drawing.Size(75, 20)
        Me.lbl_Ingresos.TabIndex = 19
        Me.lbl_Ingresos.Text = "Ingresos:"
        '
        'txt_fechaR
        '
        Me.txt_fechaR.ForeColor = System.Drawing.Color.Black
        Me.txt_fechaR.Location = New System.Drawing.Point(28, 75)
        Me.txt_fechaR.Name = "txt_fechaR"
        Me.txt_fechaR.Size = New System.Drawing.Size(153, 20)
        Me.txt_fechaR.TabIndex = 18
        '
        'btn_aceptarR2
        '
        Me.btn_aceptarR2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_aceptarR2.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptarR2.ForeColor = System.Drawing.Color.White
        Me.btn_aceptarR2.Location = New System.Drawing.Point(27, 117)
        Me.btn_aceptarR2.Name = "btn_aceptarR2"
        Me.btn_aceptarR2.Size = New System.Drawing.Size(100, 32)
        Me.btn_aceptarR2.TabIndex = 7
        Me.btn_aceptarR2.Text = "Aceptar"
        Me.btn_aceptarR2.UseVisualStyleBackColor = False
        '
        'lbl_fechaR
        '
        Me.lbl_fechaR.AutoSize = True
        Me.lbl_fechaR.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fechaR.Location = New System.Drawing.Point(23, 31)
        Me.lbl_fechaR.Name = "lbl_fechaR"
        Me.lbl_fechaR.Size = New System.Drawing.Size(154, 22)
        Me.lbl_fechaR.TabIndex = 3
        Me.lbl_fechaR.Text = "Fecha (YYYY-MM-DD)"
        '
        'lbl_fatcash5
        '
        Me.lbl_fatcash5.AutoSize = True
        Me.lbl_fatcash5.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fatcash5.Location = New System.Drawing.Point(11, 18)
        Me.lbl_fatcash5.Name = "lbl_fatcash5"
        Me.lbl_fatcash5.Size = New System.Drawing.Size(154, 38)
        Me.lbl_fatcash5.TabIndex = 33
        Me.lbl_fatcash5.Text = "FATCASH"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel6.Controls.Add(Me.lbl_gastos)
        Me.Panel6.Controls.Add(Me.lbl_Ingresos)
        Me.Panel6.Controls.Add(Me.txt_fechaR)
        Me.Panel6.Controls.Add(Me.btn_aceptarR2)
        Me.Panel6.Controls.Add(Me.lbl_fechaR)
        Me.Panel6.Location = New System.Drawing.Point(82, 127)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(280, 449)
        Me.Panel6.TabIndex = 32
        '
        'btn_volverR2
        '
        Me.btn_volverR2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_volverR2.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volverR2.ForeColor = System.Drawing.Color.White
        Me.btn_volverR2.Location = New System.Drawing.Point(12, 608)
        Me.btn_volverR2.Name = "btn_volverR2"
        Me.btn_volverR2.Size = New System.Drawing.Size(100, 32)
        Me.btn_volverR2.TabIndex = 35
        Me.btn_volverR2.Text = "Volver"
        Me.btn_volverR2.UseVisualStyleBackColor = False
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 650)
        Me.Controls.Add(Me.pb_cash5)
        Me.Controls.Add(Me.lbl_reporteR2)
        Me.Controls.Add(Me.lbl_fatcash5)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.btn_volverR2)
        Me.Name = "Reporte"
        Me.Text = "Reporte"
        CType(Me.pb_cash5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_cash5 As PictureBox
    Friend WithEvents lbl_reporteR2 As Label
    Friend WithEvents lbl_gastos As Label
    Friend WithEvents lbl_Ingresos As Label
    Friend WithEvents txt_fechaR As TextBox
    Friend WithEvents btn_aceptarR2 As Button
    Friend WithEvents lbl_fechaR As Label
    Friend WithEvents lbl_fatcash5 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btn_volverR2 As Button
End Class
