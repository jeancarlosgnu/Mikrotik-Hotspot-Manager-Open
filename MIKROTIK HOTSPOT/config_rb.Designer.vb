<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class config_rb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(config_rb))
        Me.txt_rbip = New System.Windows.Forms.TextBox()
        Me.lbl_iprb = New System.Windows.Forms.Label()
        Me.lbl_userapi = New System.Windows.Forms.Label()
        Me.txt_userapi = New System.Windows.Forms.TextBox()
        Me.txt_passwapi = New System.Windows.Forms.TextBox()
        Me.lbl_passapi = New System.Windows.Forms.Label()
        Me.bt_guardarconfig = New System.Windows.Forms.Button()
        Me.login_usuario_store = New System.Windows.Forms.TextBox()
        Me.password_usuario_store = New System.Windows.Forms.TextBox()
        Me.usuario_label_store = New System.Windows.Forms.Label()
        Me.Password_label_store = New System.Windows.Forms.Label()
        Me.txt_ver_pass = New System.Windows.Forms.TextBox()
        Me.Label_Ver_pass = New System.Windows.Forms.Label()
        Me.check_ver_pass = New System.Windows.Forms.CheckBox()
        Me.TextBox_ruta_imagen = New System.Windows.Forms.TextBox()
        Me.Button_buscar_imagen = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_rbip
        '
        Me.txt_rbip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rbip.Location = New System.Drawing.Point(126, 49)
        Me.txt_rbip.Name = "txt_rbip"
        Me.txt_rbip.Size = New System.Drawing.Size(189, 22)
        Me.txt_rbip.TabIndex = 0
        '
        'lbl_iprb
        '
        Me.lbl_iprb.AutoSize = True
        Me.lbl_iprb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_iprb.Location = New System.Drawing.Point(19, 55)
        Me.lbl_iprb.Name = "lbl_iprb"
        Me.lbl_iprb.Size = New System.Drawing.Size(101, 16)
        Me.lbl_iprb.TabIndex = 1
        Me.lbl_iprb.Text = "Ip Routerboard:"
        '
        'lbl_userapi
        '
        Me.lbl_userapi.AutoSize = True
        Me.lbl_userapi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_userapi.Location = New System.Drawing.Point(38, 80)
        Me.lbl_userapi.Name = "lbl_userapi"
        Me.lbl_userapi.Size = New System.Drawing.Size(82, 16)
        Me.lbl_userapi.TabIndex = 1
        Me.lbl_userapi.Text = "Usuario API:"
        '
        'txt_userapi
        '
        Me.txt_userapi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_userapi.Location = New System.Drawing.Point(126, 77)
        Me.txt_userapi.Name = "txt_userapi"
        Me.txt_userapi.Size = New System.Drawing.Size(189, 22)
        Me.txt_userapi.TabIndex = 1
        '
        'txt_passwapi
        '
        Me.txt_passwapi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_passwapi.Location = New System.Drawing.Point(126, 106)
        Me.txt_passwapi.Name = "txt_passwapi"
        Me.txt_passwapi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_passwapi.Size = New System.Drawing.Size(189, 22)
        Me.txt_passwapi.TabIndex = 2
        '
        'lbl_passapi
        '
        Me.lbl_passapi.AutoSize = True
        Me.lbl_passapi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_passapi.Location = New System.Drawing.Point(25, 106)
        Me.lbl_passapi.Name = "lbl_passapi"
        Me.lbl_passapi.Size = New System.Drawing.Size(95, 16)
        Me.lbl_passapi.TabIndex = 1
        Me.lbl_passapi.Text = "Password API:"
        '
        'bt_guardarconfig
        '
        Me.bt_guardarconfig.Location = New System.Drawing.Point(138, 380)
        Me.bt_guardarconfig.Name = "bt_guardarconfig"
        Me.bt_guardarconfig.Size = New System.Drawing.Size(75, 23)
        Me.bt_guardarconfig.TabIndex = 8
        Me.bt_guardarconfig.Text = "Guardar"
        Me.bt_guardarconfig.UseVisualStyleBackColor = True
        '
        'login_usuario_store
        '
        Me.login_usuario_store.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_usuario_store.Location = New System.Drawing.Point(126, 180)
        Me.login_usuario_store.Name = "login_usuario_store"
        Me.login_usuario_store.Size = New System.Drawing.Size(189, 22)
        Me.login_usuario_store.TabIndex = 6
        '
        'password_usuario_store
        '
        Me.password_usuario_store.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_usuario_store.Location = New System.Drawing.Point(126, 208)
        Me.password_usuario_store.Name = "password_usuario_store"
        Me.password_usuario_store.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_usuario_store.Size = New System.Drawing.Size(189, 22)
        Me.password_usuario_store.TabIndex = 7
        '
        'usuario_label_store
        '
        Me.usuario_label_store.AutoSize = True
        Me.usuario_label_store.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usuario_label_store.Location = New System.Drawing.Point(24, 183)
        Me.usuario_label_store.Name = "usuario_label_store"
        Me.usuario_label_store.Size = New System.Drawing.Size(93, 16)
        Me.usuario_label_store.TabIndex = 1
        Me.usuario_label_store.Text = "Login Acceso:"
        '
        'Password_label_store
        '
        Me.Password_label_store.AutoSize = True
        Me.Password_label_store.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_label_store.Location = New System.Drawing.Point(44, 211)
        Me.Password_label_store.Name = "Password_label_store"
        Me.Password_label_store.Size = New System.Drawing.Size(71, 16)
        Me.Password_label_store.TabIndex = 1
        Me.Password_label_store.Text = "Password:"
        '
        'txt_ver_pass
        '
        Me.txt_ver_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ver_pass.Location = New System.Drawing.Point(126, 238)
        Me.txt_ver_pass.Name = "txt_ver_pass"
        Me.txt_ver_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_ver_pass.Size = New System.Drawing.Size(189, 22)
        Me.txt_ver_pass.TabIndex = 7
        '
        'Label_Ver_pass
        '
        Me.Label_Ver_pass.AutoSize = True
        Me.Label_Ver_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Ver_pass.Location = New System.Drawing.Point(2, 241)
        Me.Label_Ver_pass.Name = "Label_Ver_pass"
        Me.Label_Ver_pass.Size = New System.Drawing.Size(123, 16)
        Me.Label_Ver_pass.TabIndex = 1
        Me.Label_Ver_pass.Text = "Verificar Password:"
        '
        'check_ver_pass
        '
        Me.check_ver_pass.AutoSize = True
        Me.check_ver_pass.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.check_ver_pass.Location = New System.Drawing.Point(123, 267)
        Me.check_ver_pass.Name = "check_ver_pass"
        Me.check_ver_pass.Size = New System.Drawing.Size(110, 17)
        Me.check_ver_pass.TabIndex = 9
        Me.check_ver_pass.Text = "Mostrar Password"
        Me.check_ver_pass.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.check_ver_pass.UseVisualStyleBackColor = True
        '
        'TextBox_ruta_imagen
        '
        Me.TextBox_ruta_imagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ruta_imagen.Location = New System.Drawing.Point(123, 336)
        Me.TextBox_ruta_imagen.Name = "TextBox_ruta_imagen"
        Me.TextBox_ruta_imagen.Size = New System.Drawing.Size(162, 22)
        Me.TextBox_ruta_imagen.TabIndex = 7
        '
        'Button_buscar_imagen
        '
        Me.Button_buscar_imagen.Location = New System.Drawing.Point(291, 336)
        Me.Button_buscar_imagen.Name = "Button_buscar_imagen"
        Me.Button_buscar_imagen.Size = New System.Drawing.Size(24, 23)
        Me.Button_buscar_imagen.TabIndex = 10
        Me.Button_buscar_imagen.Text = "..."
        Me.Button_buscar_imagen.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 339)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Imagen Tickets"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Datos API Routerboard:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(123, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Datos Acceso Aplicacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(135, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Imagen para Tickets"
        '
        'config_rb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 531)
        Me.Controls.Add(Me.Button_buscar_imagen)
        Me.Controls.Add(Me.check_ver_pass)
        Me.Controls.Add(Me.bt_guardarconfig)
        Me.Controls.Add(Me.lbl_passapi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label_Ver_pass)
        Me.Controls.Add(Me.Password_label_store)
        Me.Controls.Add(Me.usuario_label_store)
        Me.Controls.Add(Me.lbl_userapi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_iprb)
        Me.Controls.Add(Me.TextBox_ruta_imagen)
        Me.Controls.Add(Me.txt_ver_pass)
        Me.Controls.Add(Me.password_usuario_store)
        Me.Controls.Add(Me.txt_passwapi)
        Me.Controls.Add(Me.login_usuario_store)
        Me.Controls.Add(Me.txt_userapi)
        Me.Controls.Add(Me.txt_rbip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "config_rb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuracion Router Board"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_rbip As System.Windows.Forms.TextBox
    Friend WithEvents lbl_iprb As System.Windows.Forms.Label
    Friend WithEvents lbl_userapi As System.Windows.Forms.Label
    Friend WithEvents txt_userapi As System.Windows.Forms.TextBox
    Friend WithEvents txt_passwapi As System.Windows.Forms.TextBox
    Friend WithEvents lbl_passapi As System.Windows.Forms.Label
    Friend WithEvents bt_guardarconfig As System.Windows.Forms.Button
    Friend WithEvents login_usuario_store As System.Windows.Forms.TextBox
    Friend WithEvents password_usuario_store As System.Windows.Forms.TextBox
    Friend WithEvents usuario_label_store As System.Windows.Forms.Label
    Friend WithEvents Password_label_store As System.Windows.Forms.Label
    Friend WithEvents txt_ver_pass As System.Windows.Forms.TextBox
    Friend WithEvents Label_Ver_pass As System.Windows.Forms.Label
    Friend WithEvents check_ver_pass As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox_ruta_imagen As TextBox
    Friend WithEvents Button_buscar_imagen As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
