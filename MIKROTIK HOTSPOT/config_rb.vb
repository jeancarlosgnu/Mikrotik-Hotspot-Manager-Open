Public Class config_rb

    Private Sub config_rb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txt_rbip.Text = System.Configuration.ConfigurationManager.AppSettings("iprb")
        Me.txt_userapi.Text = System.Configuration.ConfigurationManager.AppSettings("userapi")
        Me.txt_passwapi.Text = System.Configuration.ConfigurationManager.AppSettings("passwapi")
        Me.login_usuario_store.Text = System.Configuration.ConfigurationManager.AppSettings("usuario_login")
        Me.password_usuario_store.Text = System.Configuration.ConfigurationManager.AppSettings("usuario_password")
        Me.txt_ver_pass.Text = System.Configuration.ConfigurationManager.AppSettings("usuario_password")
        Me.TextBox_ruta_imagen.Text = System.Configuration.ConfigurationManager.AppSettings("ruta_imagen_tickets")

    End Sub

    Private Sub bt_guardarconfig_Click(sender As Object, e As EventArgs) Handles bt_guardarconfig.Click
        'MsgBox(Configuration/con
        'para que funcione la lectura del App.config se debe agregar, click derecho sobre el proyecto en el explorardor de soluciones y agregar referencia seleccionar System.Configuration 4  en Framework
        'MsgBox(System.Configuration.ConfigurationManager.AppSettings("iprb"))

        Dim appconfigsave = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None)

        
        If login_usuario_store.Text = vbNullString Or password_usuario_store.Text = vbNullString Then
            MsgBox("No dejar en Blanco los Campos Login de Usuario y/o Password")
            
        Else
            If password_usuario_store.Text <> txt_ver_pass.Text Then
                MsgBox("Verique que los campos Password sean Idénticos ")
            Else
                appconfigsave.AppSettings.Settings.Remove("iprb")
                appconfigsave.AppSettings.Settings.Add("iprb", txt_rbip.Text)
                appconfigsave.AppSettings.Settings.Remove("userapi")
                appconfigsave.AppSettings.Settings.Add("userapi", txt_userapi.Text)
                appconfigsave.AppSettings.Settings.Remove("passwapi")
                appconfigsave.AppSettings.Settings.Add("passwapi", txt_passwapi.Text)
                appconfigsave.AppSettings.Settings.Remove("usuario_login")
                appconfigsave.AppSettings.Settings.Add("usuario_login", login_usuario_store.Text)
                appconfigsave.AppSettings.Settings.Remove("usuario_password")
                appconfigsave.AppSettings.Settings.Add("usuario_password", password_usuario_store.Text)
                appconfigsave.AppSettings.Settings.Remove("ruta_imagen_tickets")
                appconfigsave.AppSettings.Settings.Add("ruta_imagen_tickets", TextBox_ruta_imagen.Text)
                appconfigsave.Save(System.Configuration.ConfigurationSaveMode.Full)
                MsgBox("La aplicacion sera Cerrada para Guardar cambios,  Vuelva a Abrirla Manualmente")
                End
            End If

        End If






    End Sub

    Private Sub txt_rbip_TextChanged(sender As Object, e As EventArgs) Handles txt_rbip.TextChanged, login_usuario_store.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)


    End Sub


    Private Sub Show_serial_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As Exception
            If ex.GetType.FullName = "System.Net.Sockets.SocketException" Then
                MsgBox("Verifique la Conexión con el Router Mikrotik", MsgBoxStyle.Critical)
            End If
        End Try

    End Sub

    Private Sub check_ver_pass_CheckedChanged(sender As Object, e As EventArgs) Handles check_ver_pass.CheckedChanged
        If check_ver_pass.Checked = True Then
            password_usuario_store.PasswordChar = ""
            txt_ver_pass.PasswordChar = ""
        Else
            password_usuario_store.PasswordChar = "*"
            txt_ver_pass.PasswordChar = "*"
        End If
    End Sub

    Private Sub TextBox_ruta_imagen_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ruta_imagen.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_buscar_imagen.Click
        Dim myStream As IO.Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "Imagenes(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = openFileDialog1.OpenFile()
                If (myStream IsNot Nothing) Then
                    ' Insert code to read the stream here.
                    TextBox_ruta_imagen.Text = openFileDialog1.FileName
                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class