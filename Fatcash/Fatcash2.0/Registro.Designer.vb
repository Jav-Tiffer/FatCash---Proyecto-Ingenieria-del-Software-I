<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.lbl_fatcash1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_contraR = New System.Windows.Forms.TextBox()
        Me.lbl_contraR = New System.Windows.Forms.Label()
        Me.lbl_emailR = New System.Windows.Forms.Label()
        Me.txt_emailR = New System.Windows.Forms.TextBox()
        Me.lbl_nomR = New System.Windows.Forms.Label()
        Me.btn_aceptarR = New System.Windows.Forms.Button()
        Me.txt_nomR = New System.Windows.Forms.TextBox()
        Me.txt_cedR = New System.Windows.Forms.TextBox()
        Me.lbl_cedR = New System.Windows.Forms.Label()
        Me.btn_volverR = New System.Windows.Forms.Button()
        Me.pb_cash1 = New System.Windows.Forms.PictureBox()
        Me.pb_login1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.pb_cash1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_login1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login.Location = New System.Drawing.Point(139, 70)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(190, 38)
        Me.lbl_login.TabIndex = 19
        Me.lbl_login.Text = "Registrarse"
        '
        'lbl_fatcash1
        '
        Me.lbl_fatcash1.AutoSize = True
        Me.lbl_fatcash1.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fatcash1.Location = New System.Drawing.Point(25, 17)
        Me.lbl_fatcash1.Name = "lbl_fatcash1"
        Me.lbl_fatcash1.Size = New System.Drawing.Size(154, 38)
        Me.lbl_fatcash1.TabIndex = 18
        Me.lbl_fatcash1.Text = "FATCASH"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.Controls.Add(Me.txt_contraR)
        Me.Panel2.Controls.Add(Me.lbl_contraR)
        Me.Panel2.Controls.Add(Me.lbl_emailR)
        Me.Panel2.Controls.Add(Me.txt_emailR)
        Me.Panel2.Controls.Add(Me.lbl_nomR)
        Me.Panel2.Controls.Add(Me.btn_aceptarR)
        Me.Panel2.Controls.Add(Me.txt_nomR)
        Me.Panel2.Controls.Add(Me.txt_cedR)
        Me.Panel2.Controls.Add(Me.lbl_cedR)
        Me.Panel2.Controls.Add(Me.pb_login1)
        Me.Panel2.Location = New System.Drawing.Point(96, 126)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(280, 518)
        Me.Panel2.TabIndex = 17
        '
        'txt_contraR
        '
        Me.txt_contraR.Location = New System.Drawing.Point(32, 422)
        Me.txt_contraR.Name = "txt_contraR"
        Me.txt_contraR.Size = New System.Drawing.Size(191, 20)
        Me.txt_contraR.TabIndex = 15
        '
        'lbl_contraR
        '
        Me.lbl_contraR.AutoSize = True
        Me.lbl_contraR.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contraR.Location = New System.Drawing.Point(28, 379)
        Me.lbl_contraR.Name = "lbl_contraR"
        Me.lbl_contraR.Size = New System.Drawing.Size(90, 22)
        Me.lbl_contraR.TabIndex = 14
        Me.lbl_contraR.Text = "Contraseña"
        '
        'lbl_emailR
        '
        Me.lbl_emailR.AutoSize = True
        Me.lbl_emailR.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_emailR.Location = New System.Drawing.Point(28, 291)
        Me.lbl_emailR.Name = "lbl_emailR"
        Me.lbl_emailR.Size = New System.Drawing.Size(47, 22)
        Me.lbl_emailR.TabIndex = 12
        Me.lbl_emailR.Text = "Email"
        '
        'txt_emailR
        '
        Me.txt_emailR.Location = New System.Drawing.Point(32, 334)
        Me.txt_emailR.Name = "txt_emailR"
        Me.txt_emailR.Size = New System.Drawing.Size(191, 20)
        Me.txt_emailR.TabIndex = 11
        '
        'lbl_nomR
        '
        Me.lbl_nomR.AutoSize = True
        Me.lbl_nomR.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nomR.Location = New System.Drawing.Point(28, 203)
        Me.lbl_nomR.Name = "lbl_nomR"
        Me.lbl_nomR.Size = New System.Drawing.Size(64, 22)
        Me.lbl_nomR.TabIndex = 8
        Me.lbl_nomR.Text = "Nombre"
        '
        'btn_aceptarR
        '
        Me.btn_aceptarR.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_aceptarR.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptarR.ForeColor = System.Drawing.Color.White
        Me.btn_aceptarR.Location = New System.Drawing.Point(91, 474)
        Me.btn_aceptarR.Name = "btn_aceptarR"
        Me.btn_aceptarR.Size = New System.Drawing.Size(100, 32)
        Me.btn_aceptarR.TabIndex = 7
        Me.btn_aceptarR.Text = "Aceptar"
        Me.btn_aceptarR.UseVisualStyleBackColor = False
        '
        'txt_nomR
        '
        Me.txt_nomR.Location = New System.Drawing.Point(32, 246)
        Me.txt_nomR.Name = "txt_nomR"
        Me.txt_nomR.Size = New System.Drawing.Size(191, 20)
        Me.txt_nomR.TabIndex = 6
        '
        'txt_cedR
        '
        Me.txt_cedR.Location = New System.Drawing.Point(32, 158)
        Me.txt_cedR.Name = "txt_cedR"
        Me.txt_cedR.Size = New System.Drawing.Size(191, 20)
        Me.txt_cedR.TabIndex = 4
        '
        'lbl_cedR
        '
        Me.lbl_cedR.AutoSize = True
        Me.lbl_cedR.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cedR.Location = New System.Drawing.Point(28, 115)
        Me.lbl_cedR.Name = "lbl_cedR"
        Me.lbl_cedR.Size = New System.Drawing.Size(58, 22)
        Me.lbl_cedR.TabIndex = 3
        Me.lbl_cedR.Text = "Cédula"
        '
        'btn_volverR
        '
        Me.btn_volverR.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_volverR.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volverR.ForeColor = System.Drawing.Color.White
        Me.btn_volverR.Location = New System.Drawing.Point(18, 665)
        Me.btn_volverR.Name = "btn_volverR"
        Me.btn_volverR.Size = New System.Drawing.Size(100, 32)
        Me.btn_volverR.TabIndex = 20
        Me.btn_volverR.Text = "Volver"
        Me.btn_volverR.UseVisualStyleBackColor = False
        '
        'pb_cash1
        '
        Me.pb_cash1.Image = Global.Fatcash2._0.My.Resources.Resources.image_1
        Me.pb_cash1.Location = New System.Drawing.Point(374, 10)
        Me.pb_cash1.Name = "pb_cash1"
        Me.pb_cash1.Size = New System.Drawing.Size(60, 45)
        Me.pb_cash1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_cash1.TabIndex = 16
        Me.pb_cash1.TabStop = False
        '
        'pb_login1
        '
        Me.pb_login1.Image = Global.Fatcash2._0.My.Resources.Resources.image_2
        Me.pb_login1.Location = New System.Drawing.Point(100, 0)
        Me.pb_login1.Name = "pb_login1"
        Me.pb_login1.Size = New System.Drawing.Size(79, 75)
        Me.pb_login1.TabIndex = 0
        Me.pb_login1.TabStop = False
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 707)
        Me.Controls.Add(Me.pb_cash1)
        Me.Controls.Add(Me.lbl_login)
        Me.Controls.Add(Me.lbl_fatcash1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_volverR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registro"
        Me.Text = "Registro"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pb_cash1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_login1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_cash1 As PictureBox
    Friend WithEvents lbl_login As Label
    Friend WithEvents lbl_fatcash1 As Label
    Friend WithEvents pb_login1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_contraR As TextBox
    Friend WithEvents lbl_contraR As Label
    Friend WithEvents lbl_emailR As Label
    Friend WithEvents txt_emailR As TextBox
    Friend WithEvents lbl_nomR As Label
    Friend WithEvents btn_aceptarR As Button
    Friend WithEvents txt_nomR As TextBox
    Friend WithEvents txt_cedR As TextBox
    Friend WithEvents lbl_cedR As Label
    Friend WithEvents btn_volverR As Button
End Class
