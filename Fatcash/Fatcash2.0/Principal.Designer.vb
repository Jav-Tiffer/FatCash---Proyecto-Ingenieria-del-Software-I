<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btn_info = New System.Windows.Forms.Button()
        Me.btn_logoutP = New System.Windows.Forms.Button()
        Me.btn_salirP = New System.Windows.Forms.Button()
        Me.btn_metasM = New System.Windows.Forms.Button()
        Me.btn_ingresarM = New System.Windows.Forms.Button()
        Me.btn_reporteM = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblIngresos = New System.Windows.Forms.Label()
        Me.lblGastos = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_fatcash = New System.Windows.Forms.Label()
        Me.pb_cash = New System.Windows.Forms.PictureBox()
        Me.gbOpciones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pb_cash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbOpciones
        '
        Me.gbOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gbOpciones.Controls.Add(Me.btn_info)
        Me.gbOpciones.Controls.Add(Me.btn_logoutP)
        Me.gbOpciones.Controls.Add(Me.btn_salirP)
        Me.gbOpciones.Controls.Add(Me.btn_metasM)
        Me.gbOpciones.Controls.Add(Me.btn_ingresarM)
        Me.gbOpciones.Controls.Add(Me.btn_reporteM)
        Me.gbOpciones.Location = New System.Drawing.Point(22, 12)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(210, 426)
        Me.gbOpciones.TabIndex = 31
        Me.gbOpciones.TabStop = False
        Me.gbOpciones.Text = "Lista de Opciones"
        '
        'btn_info
        '
        Me.btn_info.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_info.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_info.ForeColor = System.Drawing.Color.White
        Me.btn_info.Location = New System.Drawing.Point(6, 51)
        Me.btn_info.Name = "btn_info"
        Me.btn_info.Size = New System.Drawing.Size(189, 40)
        Me.btn_info.TabIndex = 9
        Me.btn_info.Text = "Información"
        Me.btn_info.UseVisualStyleBackColor = False
        '
        'btn_logoutP
        '
        Me.btn_logoutP.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_logoutP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logoutP.ForeColor = System.Drawing.Color.White
        Me.btn_logoutP.Location = New System.Drawing.Point(96, 388)
        Me.btn_logoutP.Name = "btn_logoutP"
        Me.btn_logoutP.Size = New System.Drawing.Size(99, 32)
        Me.btn_logoutP.TabIndex = 22
        Me.btn_logoutP.Text = "Cerrar Sesión"
        Me.btn_logoutP.UseVisualStyleBackColor = False
        '
        'btn_salirP
        '
        Me.btn_salirP.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_salirP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salirP.ForeColor = System.Drawing.Color.White
        Me.btn_salirP.Location = New System.Drawing.Point(6, 388)
        Me.btn_salirP.Name = "btn_salirP"
        Me.btn_salirP.Size = New System.Drawing.Size(59, 32)
        Me.btn_salirP.TabIndex = 21
        Me.btn_salirP.Text = "Salir"
        Me.btn_salirP.UseVisualStyleBackColor = False
        '
        'btn_metasM
        '
        Me.btn_metasM.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_metasM.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_metasM.ForeColor = System.Drawing.Color.White
        Me.btn_metasM.Location = New System.Drawing.Point(6, 106)
        Me.btn_metasM.Name = "btn_metasM"
        Me.btn_metasM.Size = New System.Drawing.Size(189, 40)
        Me.btn_metasM.TabIndex = 8
        Me.btn_metasM.Text = "Metas"
        Me.btn_metasM.UseVisualStyleBackColor = False
        '
        'btn_ingresarM
        '
        Me.btn_ingresarM.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_ingresarM.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ingresarM.ForeColor = System.Drawing.Color.White
        Me.btn_ingresarM.Location = New System.Drawing.Point(6, 161)
        Me.btn_ingresarM.Name = "btn_ingresarM"
        Me.btn_ingresarM.Size = New System.Drawing.Size(189, 40)
        Me.btn_ingresarM.TabIndex = 7
        Me.btn_ingresarM.Text = "Ingresar"
        Me.btn_ingresarM.UseVisualStyleBackColor = False
        '
        'btn_reporteM
        '
        Me.btn_reporteM.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_reporteM.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_reporteM.ForeColor = System.Drawing.Color.White
        Me.btn_reporteM.Location = New System.Drawing.Point(6, 218)
        Me.btn_reporteM.Name = "btn_reporteM"
        Me.btn_reporteM.Size = New System.Drawing.Size(189, 40)
        Me.btn_reporteM.TabIndex = 10
        Me.btn_reporteM.Text = "Reportes"
        Me.btn_reporteM.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lblIngresos)
        Me.GroupBox1.Controls.Add(Me.lblGastos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(275, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 352)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resumen"
        '
        'lblIngresos
        '
        Me.lblIngresos.AutoSize = True
        Me.lblIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblIngresos.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblIngresos.Location = New System.Drawing.Point(155, 208)
        Me.lblIngresos.Name = "lblIngresos"
        Me.lblIngresos.Size = New System.Drawing.Size(261, 25)
        Me.lblIngresos.TabIndex = 3
        Me.lblIngresos.Text = "Tu total de ingresos es:"
        '
        'lblGastos
        '
        Me.lblGastos.AutoSize = True
        Me.lblGastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGastos.ForeColor = System.Drawing.Color.Red
        Me.lblGastos.Location = New System.Drawing.Point(155, 92)
        Me.lblGastos.Name = "lblGastos"
        Me.lblGastos.Size = New System.Drawing.Size(241, 25)
        Me.lblGastos.TabIndex = 2
        Me.lblGastos.Text = "Tu total de gastos es:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(201, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Ingresos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(205, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Gastos"
        '
        'lbl_fatcash
        '
        Me.lbl_fatcash.AutoSize = True
        Me.lbl_fatcash.Font = New System.Drawing.Font("Arial Black", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_fatcash.Location = New System.Drawing.Point(416, 12)
        Me.lbl_fatcash.Name = "lbl_fatcash"
        Me.lbl_fatcash.Size = New System.Drawing.Size(227, 56)
        Me.lbl_fatcash.TabIndex = 33
        Me.lbl_fatcash.Text = "FATCASH"
        '
        'pb_cash
        '
        Me.pb_cash.Image = Global.Fatcash2._0.My.Resources.Resources.image_1
        Me.pb_cash.Location = New System.Drawing.Point(649, 12)
        Me.pb_cash.Name = "pb_cash"
        Me.pb_cash.Size = New System.Drawing.Size(81, 56)
        Me.pb_cash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_cash.TabIndex = 32
        Me.pb_cash.TabStop = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 450)
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pb_cash)
        Me.Controls.Add(Me.lbl_fatcash)
        Me.Name = "Principal"
        Me.Text = "Menu"
        Me.gbOpciones.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pb_cash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbOpciones As GroupBox
    Friend WithEvents btn_info As Button
    Friend WithEvents btn_logoutP As Button
    Friend WithEvents btn_salirP As Button
    Friend WithEvents btn_metasM As Button
    Friend WithEvents btn_ingresarM As Button
    Friend WithEvents btn_reporteM As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pb_cash As PictureBox
    Friend WithEvents lbl_fatcash As Label
    Friend WithEvents lblGastos As Label
    Friend WithEvents lblIngresos As Label
End Class
