<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbl_fatcash = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.txt_contra = New System.Windows.Forms.TextBox()
        Me.lbl_contra = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.pb_login = New System.Windows.Forms.PictureBox()
        Me.btn_regist = New System.Windows.Forms.Button()
        Me.lbl_O = New System.Windows.Forms.Label()
        Me.pb_cash = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pb_login, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_cash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login.Location = New System.Drawing.Point(189, 100)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(98, 38)
        Me.lbl_login.TabIndex = 14
        Me.lbl_login.Text = "Login"
        '
        'lbl_fatcash
        '
        Me.lbl_fatcash.AutoSize = True
        Me.lbl_fatcash.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fatcash.Location = New System.Drawing.Point(19, 27)
        Me.lbl_fatcash.Name = "lbl_fatcash"
        Me.lbl_fatcash.Size = New System.Drawing.Size(154, 38)
        Me.lbl_fatcash.TabIndex = 13
        Me.lbl_fatcash.Text = "FATCASH"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.btn_aceptar)
        Me.Panel1.Controls.Add(Me.txt_contra)
        Me.Panel1.Controls.Add(Me.lbl_contra)
        Me.Panel1.Controls.Add(Me.txt_email)
        Me.Panel1.Controls.Add(Me.lbl_email)
        Me.Panel1.Controls.Add(Me.pb_login)
        Me.Panel1.Location = New System.Drawing.Point(96, 158)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(280, 334)
        Me.Panel1.TabIndex = 12
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_aceptar.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.White
        Me.btn_aceptar.Location = New System.Drawing.Point(91, 287)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(100, 32)
        Me.btn_aceptar.TabIndex = 7
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'txt_contra
        '
        Me.txt_contra.Location = New System.Drawing.Point(32, 246)
        Me.txt_contra.Name = "txt_contra"
        Me.txt_contra.Size = New System.Drawing.Size(191, 20)
        Me.txt_contra.TabIndex = 6
        '
        'lbl_contra
        '
        Me.lbl_contra.AutoSize = True
        Me.lbl_contra.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contra.Location = New System.Drawing.Point(28, 203)
        Me.lbl_contra.Name = "lbl_contra"
        Me.lbl_contra.Size = New System.Drawing.Size(90, 22)
        Me.lbl_contra.TabIndex = 5
        Me.lbl_contra.Text = "Contraseña"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(32, 158)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(191, 20)
        Me.txt_email.TabIndex = 4
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(28, 115)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(47, 22)
        Me.lbl_email.TabIndex = 3
        Me.lbl_email.Text = "Email"
        '
        'pb_login
        '
        Me.pb_login.Image = Global.Fatcash2._0.My.Resources.Resources.image_2
        Me.pb_login.Location = New System.Drawing.Point(100, 0)
        Me.pb_login.Name = "pb_login"
        Me.pb_login.Size = New System.Drawing.Size(79, 75)
        Me.pb_login.TabIndex = 0
        Me.pb_login.TabStop = False
        '
        'btn_regist
        '
        Me.btn_regist.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_regist.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_regist.ForeColor = System.Drawing.Color.White
        Me.btn_regist.Location = New System.Drawing.Point(156, 559)
        Me.btn_regist.Name = "btn_regist"
        Me.btn_regist.Size = New System.Drawing.Size(155, 32)
        Me.btn_regist.TabIndex = 16
        Me.btn_regist.Text = "Registrarse"
        Me.btn_regist.UseVisualStyleBackColor = False
        '
        'lbl_O
        '
        Me.lbl_O.AutoSize = True
        Me.lbl_O.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_O.Location = New System.Drawing.Point(216, 509)
        Me.lbl_O.Name = "lbl_O"
        Me.lbl_O.Size = New System.Drawing.Size(39, 38)
        Me.lbl_O.TabIndex = 15
        Me.lbl_O.Text = "O"
        '
        'pb_cash
        '
        Me.pb_cash.Image = Global.Fatcash2._0.My.Resources.Resources.image_1
        Me.pb_cash.Location = New System.Drawing.Point(368, 20)
        Me.pb_cash.Name = "pb_cash"
        Me.pb_cash.Size = New System.Drawing.Size(60, 45)
        Me.pb_cash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_cash.TabIndex = 11
        Me.pb_cash.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 634)
        Me.Controls.Add(Me.pb_cash)
        Me.Controls.Add(Me.lbl_login)
        Me.Controls.Add(Me.lbl_fatcash)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_regist)
        Me.Controls.Add(Me.lbl_O)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pb_login, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_cash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_cash As PictureBox
    Friend WithEvents lbl_login As Label
    Friend WithEvents lbl_fatcash As Label
    Friend WithEvents pb_login As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents txt_contra As TextBox
    Friend WithEvents lbl_contra As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents btn_regist As Button
    Friend WithEvents lbl_O As Label
End Class
