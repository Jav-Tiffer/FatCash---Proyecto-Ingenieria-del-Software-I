<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Metas
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
        Me.lbl_metasM = New System.Windows.Forms.Label()
        Me.lbl_fatcash4 = New System.Windows.Forms.Label()
        Me.txt_fechaM = New System.Windows.Forms.TextBox()
        Me.lbl_ahorrarM = New System.Windows.Forms.Label()
        Me.btn_aceptarM = New System.Windows.Forms.Button()
        Me.txt_ahorrarM = New System.Windows.Forms.TextBox()
        Me.lbl_tipoM = New System.Windows.Forms.Label()
        Me.btn_volverM = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.pb_cash4 = New System.Windows.Forms.PictureBox()
        Me.Panel5.SuspendLayout()
        CType(Me.pb_cash4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_metasM
        '
        Me.lbl_metasM.AutoSize = True
        Me.lbl_metasM.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_metasM.Location = New System.Drawing.Point(163, 70)
        Me.lbl_metasM.Name = "lbl_metasM"
        Me.lbl_metasM.Size = New System.Drawing.Size(107, 38)
        Me.lbl_metasM.TabIndex = 29
        Me.lbl_metasM.Text = "Metas"
        '
        'lbl_fatcash4
        '
        Me.lbl_fatcash4.AutoSize = True
        Me.lbl_fatcash4.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fatcash4.Location = New System.Drawing.Point(11, 20)
        Me.lbl_fatcash4.Name = "lbl_fatcash4"
        Me.lbl_fatcash4.Size = New System.Drawing.Size(154, 38)
        Me.lbl_fatcash4.TabIndex = 28
        Me.lbl_fatcash4.Text = "FATCASH"
        '
        'txt_fechaM
        '
        Me.txt_fechaM.ForeColor = System.Drawing.Color.Black
        Me.txt_fechaM.Location = New System.Drawing.Point(15, 180)
        Me.txt_fechaM.Name = "txt_fechaM"
        Me.txt_fechaM.Size = New System.Drawing.Size(191, 20)
        Me.txt_fechaM.TabIndex = 9
        '
        'lbl_ahorrarM
        '
        Me.lbl_ahorrarM.AutoSize = True
        Me.lbl_ahorrarM.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ahorrarM.Location = New System.Drawing.Point(11, 41)
        Me.lbl_ahorrarM.Name = "lbl_ahorrarM"
        Me.lbl_ahorrarM.Size = New System.Drawing.Size(203, 22)
        Me.lbl_ahorrarM.TabIndex = 8
        Me.lbl_ahorrarM.Text = "Cantidad que desea ahorrar"
        '
        'btn_aceptarM
        '
        Me.btn_aceptarM.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_aceptarM.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptarM.ForeColor = System.Drawing.Color.White
        Me.btn_aceptarM.Location = New System.Drawing.Point(115, 242)
        Me.btn_aceptarM.Name = "btn_aceptarM"
        Me.btn_aceptarM.Size = New System.Drawing.Size(100, 32)
        Me.btn_aceptarM.TabIndex = 7
        Me.btn_aceptarM.Text = "Aceptar"
        Me.btn_aceptarM.UseVisualStyleBackColor = False
        '
        'txt_ahorrarM
        '
        Me.txt_ahorrarM.Location = New System.Drawing.Point(15, 87)
        Me.txt_ahorrarM.Name = "txt_ahorrarM"
        Me.txt_ahorrarM.Size = New System.Drawing.Size(191, 20)
        Me.txt_ahorrarM.TabIndex = 6
        '
        'lbl_tipoM
        '
        Me.lbl_tipoM.AutoSize = True
        Me.lbl_tipoM.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipoM.Location = New System.Drawing.Point(11, 137)
        Me.lbl_tipoM.Name = "lbl_tipoM"
        Me.lbl_tipoM.Size = New System.Drawing.Size(314, 22)
        Me.lbl_tipoM.TabIndex = 3
        Me.lbl_tipoM.Text = "Fecha en que termina la meta (YYYY-MM-DD)"
        '
        'btn_volverM
        '
        Me.btn_volverM.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_volverM.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volverM.ForeColor = System.Drawing.Color.White
        Me.btn_volverM.Location = New System.Drawing.Point(11, 523)
        Me.btn_volverM.Name = "btn_volverM"
        Me.btn_volverM.Size = New System.Drawing.Size(100, 32)
        Me.btn_volverM.TabIndex = 30
        Me.btn_volverM.Text = "Volver"
        Me.btn_volverM.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel5.Controls.Add(Me.txt_fechaM)
        Me.Panel5.Controls.Add(Me.lbl_ahorrarM)
        Me.Panel5.Controls.Add(Me.btn_aceptarM)
        Me.Panel5.Controls.Add(Me.txt_ahorrarM)
        Me.Panel5.Controls.Add(Me.lbl_tipoM)
        Me.Panel5.Location = New System.Drawing.Point(54, 131)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(341, 296)
        Me.Panel5.TabIndex = 27
        '
        'pb_cash4
        '
        Me.pb_cash4.Image = Global.Fatcash2._0.My.Resources.Resources.image_1
        Me.pb_cash4.Location = New System.Drawing.Point(360, 13)
        Me.pb_cash4.Name = "pb_cash4"
        Me.pb_cash4.Size = New System.Drawing.Size(60, 45)
        Me.pb_cash4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_cash4.TabIndex = 26
        Me.pb_cash4.TabStop = False
        '
        'Metas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 568)
        Me.Controls.Add(Me.pb_cash4)
        Me.Controls.Add(Me.lbl_metasM)
        Me.Controls.Add(Me.lbl_fatcash4)
        Me.Controls.Add(Me.btn_volverM)
        Me.Controls.Add(Me.Panel5)
        Me.Name = "Metas"
        Me.Text = "Metas"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.pb_cash4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_cash4 As PictureBox
    Friend WithEvents lbl_metasM As Label
    Friend WithEvents lbl_fatcash4 As Label
    Friend WithEvents txt_fechaM As TextBox
    Friend WithEvents lbl_ahorrarM As Label
    Friend WithEvents btn_aceptarM As Button
    Friend WithEvents txt_ahorrarM As TextBox
    Friend WithEvents lbl_tipoM As Label
    Friend WithEvents btn_volverM As Button
    Friend WithEvents Panel5 As Panel
End Class
