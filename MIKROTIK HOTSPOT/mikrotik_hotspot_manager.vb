
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO


Public Class Pruebaconexion
    Private Sub bt_ejecutar_Click(sender As Object, e As EventArgs)

        Dim iprouter = System.Configuration.ConfigurationManager.AppSettings("iprb")
        Dim loginrouter = System.Configuration.ConfigurationManager.AppSettings("userapi")
        Dim passrouter = System.Configuration.ConfigurationManager.AppSettings("passwapi")

        Me.Enabled = False
        Dim mk = New mkAPI(iprouter)
        If Not mk.Login(loginrouter, passrouter) Then
            mk.Close()
            tb_result.Text = "Error"
            Me.Enabled = True
            Exit Sub
        End If

        'mk.Send(tb_cmd.Text, True)
        For Each row In mk.Read()
            tb_result.Text = tb_result.Text + row + vbCrLf
        Next

        Me.Enabled = True
    End Sub

    Private Sub ConfiguracionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguracionToolStripMenuItem.Click

    End Sub

    Private Sub ConfigurarParametrosRBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurarParametrosRBToolStripMenuItem.Click
        'Me.Visible = False
        config_rb.Show()

    End Sub


    Private Sub bt_crear_usuario_Click(sender As Object, e As EventArgs) Handles bt_crear_usuario.Click

        check_buscar.Checked = False


        Dim cantidad_tiempo As Integer = numero_tiempo.Value
        Dim sumar_dias As Integer
        Dim tiempo_uptime As String = 1
        Dim comentario_fecha As String
        Dim fecha_vencimiento As String = Format(DateAdd(DateInterval.Day, sumar_dias, CDate(lbl_fecha_hoy.Text)), "dd/MMMM/yyyy")
        'Se confirma si se va Crear Lote 
        If check_lote.Checked = True Then

            'Si se selecciona un Rango Hora , dia ,ETc
            If list_hora_dia_mes.SelectedIndex >= 0 Then

                'Si Se crea usuario por Horas, se Suman 2 Dias 
                If list_hora_dia_mes.SelectedIndex = 0 Then
                    tiempo_uptime = cantidad_tiempo & ":00:00"
                    sumar_dias = 2

                End If
                'Si se crea por Dias
                If list_hora_dia_mes.SelectedIndex = 1 Then
                    tiempo_uptime = cantidad_tiempo & "d00:00:00"
                    sumar_dias = cantidad_tiempo + 1


                End If
                'Si se crea por MES
                If list_hora_dia_mes.SelectedIndex = 2 Then
                    tiempo_uptime = (cantidad_tiempo * 4) & "w00:00:00"
                    sumar_dias = (cantidad_tiempo * 30) + 1

                End If


                'Como se Escribio usuario y se selecciono Tiempo, Se crea enviando al sub crear_un_usuario
                comentario_fecha = Format(DateAdd(DateInterval.Day, sumar_dias, CDate(lbl_fecha_hoy.Text)), "dd/MMMM/yyyy") & "-" & sumar_dias



                'Crear LOTE
                crear_lote_usuarios(tiempo_uptime, comentario_fecha, numeric_cantidad_lote.Value, fecha_vencimiento)


            Else
                MsgBox("Debe Seleccionar un Tiempo para Crear el LOTE de Usuarios")

                'End de condicion si se seleciono algun tiempo
            End If




        Else


            If txt_usuariocliente.Text <> "" Then


                'Si se selecciona un Rango Hora , dia ,ETc
                If list_hora_dia_mes.SelectedIndex >= 0 Then

                    'Si Se crea usuario por Horas, se Suman 2 Dias 
                    If list_hora_dia_mes.SelectedIndex = 0 Then
                        tiempo_uptime = cantidad_tiempo & ":00:00"
                        sumar_dias = 2

                    End If
                    'Si se crea por Dias
                    If list_hora_dia_mes.SelectedIndex = 1 Then
                        tiempo_uptime = cantidad_tiempo & "d00:00:00"
                        sumar_dias = cantidad_tiempo + 1


                    End If
                    'Si se crea por MES
                    If list_hora_dia_mes.SelectedIndex = 2 Then
                        tiempo_uptime = (cantidad_tiempo * 4) & "w00:00:00"
                        sumar_dias = (cantidad_tiempo * 30) + 1

                    End If


                    'Como se Escribio usuario y se selecciono Tiempo, Se crea enviando al sub crear_un_usuario
                    comentario_fecha = Format(DateAdd(DateInterval.Day, sumar_dias, CDate(lbl_fecha_hoy.Text)), "dd/MMMM/yyyy") & "-" & sumar_dias

                    crear_lote_usuarios(tiempo_uptime, comentario_fecha, 999999, fecha_vencimiento)

                Else
                    MsgBox("Debe Seleccionar un Tiempo para Crear el Usuario")

                    'End de condicion si se seleciono algun tiempo
                End If

            Else

                MsgBox("Debe Escribir un nombre de Usuario")
                txt_usuariocliente.Focus()
            End If



        End If


    End Sub

    Private Sub txt_listar_usuarios_Click(sender As Object, e As EventArgs) Handles bt_listar_usuarios.Click
        listar_todos()




        ' ir hasta ultima fila
        'Pruebaconexion.parrila_usuarios.FirstDisplayedScrollingRowIndex = Pruebaconexion.parrila_usuarios.RowCount - 1
        'Tuve que Ordenar por Una de las Filas , porque si no lo hago no muestra la ultima Fila y solo se podria ver bajando con el teclado
        Me.Enabled = True






    End Sub


    Private Sub tb_result_TextChanged(sender As Object, e As EventArgs) Handles tb_result.TextChanged

    End Sub

    Private Sub Pruebaconexion_Click(sender As Object, e As EventArgs) Handles Me.Click


    End Sub

    Private Sub Pruebaconexion_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus

    End Sub

    Private Sub Pruebaconexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load, DataSet1.Initialized
        parrila_usuarios.DataSource = DataSet1.Tables("Tabla_de_usuarios")
        Me.Text = "Hotspot Mikrotik Manager - IP Routerboard : " + System.Configuration.ConfigurationManager.AppSettings("iprb")
        lbl_fecha_hoy.Text = Format(Today, "dd/MMMM/yyyy")
        Try


            Dim mk = New mkAPI(iprouter)

            If Not mk.Login(loginrouter, passrouter) Then
                mk.Close()
                Me.tb_result.Text = "Error"
                Exit Sub
            End If


            mk.Send("/ip/hotspot/user/profile/print", True)
            Me.tb_result.Text = ""
            Dim fila As String
            Dim vector_valores As String() = Nothing
            If Me.combox_perfil.Items.Count = 0 Then


                For Each row In mk.Read()

                    Me.tb_result.Text = Me.tb_result.Text + row + vbCrLf
                    If (row <> "!done") Then
                        fila = row.Replace("!re=.", "")
                        vector_valores = Split(fila, "=")

                        Me.combox_perfil.Items.Add(vector_valores(Array.IndexOf(vector_valores, "name") + 1))



                    End If

                Next
                Me.combox_perfil.SelectedIndex = 0
                Me.Enabled = True
            End If
        Catch ex As Exception
            Mensaje_error_conex()


        End Try
    End Sub


    Private Sub bt_select_all_Click(sender As Object, e As EventArgs) Handles bt_select_all.Click
        Me.parrila_usuarios.SelectAll()
    End Sub

    Private Sub bt_Eliminar_Click(sender As Object, e As EventArgs) Handles bt_Eliminar.Click
        Dim partido As String() = Nothing
        If Me.parrila_usuarios.SelectedRows.Count > 0 Then


            Dim respuesta As DialogResult = MessageBox.Show("¿Esta Seguro de Eliminar Los Usuarios Seleccionados ?", "Eliminar Seleccionados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            Select Case respuesta
                Case Windows.Forms.DialogResult.Yes
                    'Me.GuardarArchivoComo()





                    tb_result.Text = ""

                    Dim numero_filas As Integer
                    numero_filas = parrila_usuarios.Rows.Count

                    If (numero_filas > 0) And (Me.parrila_usuarios.SelectedRows.Count > 0) Then


                        Dim iprouter = System.Configuration.ConfigurationManager.AppSettings("iprb")
                        Dim loginrouter = System.Configuration.ConfigurationManager.AppSettings("userapi")
                        Dim passrouter = System.Configuration.ConfigurationManager.AppSettings("passwapi")

                        Me.Enabled = False
                        Dim mk = New mkAPI(iprouter)
                        If Not mk.Login(loginrouter, passrouter) Then
                            mk.Close()
                            tb_result.Text = "Error"
                            Me.Enabled = True
                            Exit Sub
                        End If


                        'MsgBox(numero_filas)

                        'for para Recorrer parrila y borrar
                        Dim i As Integer

                        For i = 0 To numero_filas - 1

                            mk.Send("/ip/hotspot/active/print", True)
                            If parrila_usuarios.Rows(i).Selected = True Then
                                For Each row In mk.Read()

                                    If (row <> "!done") Then
                                        partido = Split(row, "=")
                                        If parrila_usuarios.Rows(i).Cells(1).Value = partido(6) Then
                                            mk.Send("/ip/hotspot/active/print", True)
                                            mk.Send("/ip/hotspot/active/remove")
                                            mk.Send("=.id=" & partido(2), True)
                                        End If

                                    End If

                                Next
                            End If

                            If parrila_usuarios.Rows(i).Selected = True Then

                                mk.Send("/ip/hotspot/active/print", True)





                                'MsgBox(parrila_usuarios.Rows(i).Cells(0).Value)
                                mk.Send("/ip/hotspot/user/remove")
                                mk.Send("=.id=" & parrila_usuarios.Rows(i).Cells(0).Value, True)


                                'MsgBox(i & "Seleccionada")



                            End If





                        Next

                        For Each row In mk.Read()
                            tb_result.Text = tb_result.Text + row + vbCrLf


                        Next



                        Me.Enabled = True


                        listar_todos()



                    End If

                Case Windows.Forms.DialogResult.No
                    'Descartar los cambios 
            End Select

        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles numero_tiempo.ValueChanged
        If numero_tiempo.Value > 1 Then
            list_hora_dia_mes.Items(0) = "HORAS"
            list_hora_dia_mes.Items(1) = "DIAS"
            list_hora_dia_mes.Items(2) = "MESES"

        Else
            list_hora_dia_mes.Items(0) = "HORA"
            list_hora_dia_mes.Items(1) = "DIA"
            list_hora_dia_mes.Items(2) = "MES"
        End If
    End Sub

    Private Sub list_hora_dia_mes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_hora_dia_mes.SelectedIndexChanged

        numero_tiempo.Enabled = True
        If list_hora_dia_mes.SelectedIndex = 0 Then
            numero_tiempo.Maximum = 24
        End If

        If list_hora_dia_mes.SelectedIndex = 1 Then
            numero_tiempo.Maximum = 30
        End If

        If list_hora_dia_mes.SelectedIndex = 2 Then
            numero_tiempo.Maximum = 12
        End If


    End Sub

    Private Sub txt_usuariocliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_usuariocliente.KeyPress, txt_buscar.KeyPress

        'Procedimiento para que cuando se haga un Keypress en el Textbox solo acepte letras y numeros , no acepta espacios


        If Char.IsLetterOrDigit(e.KeyChar) And (e.KeyChar <> "ñ") And (e.KeyChar <> "Ñ") Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub bt_shutdown_Click(sender As Object, e As EventArgs) Handles bt_shutdown.Click, CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub bt_listar_vencidos_Click(sender As Object, e As EventArgs) Handles bt_listar_vencidos.Click
        Listar_vencidos()
    End Sub

    Private Sub bt_generar_clave_Click(sender As Object, e As EventArgs) Handles bt_generar_clave.Click
        txt_usuariocliente.Text = generar_cadena()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.Height = 530
        Me.tb_result.Location = New Point(x:=4, y:=455)
        Me.tb_result.Visible = True
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.tb_result.Location = New Point(x:=4, y:=200)
        Me.tb_result.Visible = False
        Me.Height = 480
    End Sub

    Private Sub bt_reset_Click(sender As Object, e As EventArgs) Handles bt_reset.Click
        resetear_seleccionados()

    End Sub


    Private Sub DeseleccionarTodosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.parrila_usuarios.ClearSelection()
    End Sub

    Private Sub SeleccionarTodosToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Me.parrila_usuarios.SelectAll()
    End Sub

    Private Sub check_buscar_CheckedChanged(sender As Object, e As EventArgs) Handles check_buscar.CheckedChanged
        If Me.check_buscar.Checked = True Then
            Me.txt_buscar.Visible = True
            Me.txt_buscar.Text = ""


            listar_todos()


        End If

        If Me.check_buscar.Checked = False Then
            Me.txt_buscar.Visible = False
            Me.txt_buscar.Text = ""



        End If




    End Sub


    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged



        Me.DataSet1.Tables(0).DefaultView.RowFilter = "Usuario LIKE'%" + Me.txt_buscar.Text + "%' or Tiempo_limite LIKE'%" + Me.txt_buscar.Text + "%' or PERFIL_NAVEGACION_PERFIL LIKE'%" + Me.txt_buscar.Text + "%' or Tiempo_vence LIKE'%" + Me.txt_buscar.Text + "%'"



    End Sub

    Private Sub txt_usuariocliente_TextChanged(sender As Object, e As EventArgs) Handles txt_usuariocliente.TextChanged

    End Sub

    Private Sub check_lote_CheckedChanged(sender As Object, e As EventArgs) Handles check_lote.CheckedChanged

        If check_lote.Checked = True Then
            numeric_cantidad_lote.Value = 1
            txt_usuariocliente.Enabled = False
            txt_usuariocliente.Text = ""
            bt_generar_clave.Enabled = False
            numeric_cantidad_lote.Enabled = True
            bt_crear_usuario.Text = "Crear Lote"
            check_buscar.Checked = False

        End If

        If check_lote.Checked = False Then
            numeric_cantidad_lote.Value = 1
            txt_usuariocliente.Enabled = True
            txt_usuariocliente.Text = ""
            bt_generar_clave.Enabled = True
            numeric_cantidad_lote.Enabled = False
            bt_crear_usuario.Text = "Crear Usuario"
            check_buscar.Checked = False
        End If

    End Sub

    Private Sub numeric_cantidad_lote_ValueChanged(sender As Object, e As EventArgs) Handles numeric_cantidad_lote.ValueChanged

    End Sub

    Private Sub SeleccionarTodosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btb_pdf_Click(sender As Object, e As EventArgs) Handles btb_pdf.Click

        If parrila_usuarios.SelectedRows.Count > 0 Then



            SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.FileName = "" Then
                MsgBox("Digite un nombre para Crear el PDF")
                Exit Sub
            Else
                ExportDataToPDFTable()
                MsgBox("PDF Creado Correctamente")
            End If


        Else
            MsgBox("Debe Seleccionar Al menos Un usuario para Crear el PDF")


        End If
    End Sub

    Private Sub lbl_usuario_cli_Click(sender As Object, e As EventArgs) Handles lbl_usuario_cli.Click

    End Sub

    Private Sub PerfilesNavegacionToolStripMenuItem_Click(sender As Object, e As EventArgs)
        perfiles_navegacion.Show()
    End Sub

    Private Sub combox_perfil_Click(sender As Object, e As EventArgs) Handles combox_perfil.Click
        cargar_perfiles_en_principal()
    End Sub

    Private Sub combox_perfil_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub parrila_usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Listar(sender As Object, e As EventArgs) 

    End Sub

    Private Sub c(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub combox_perfil_GotFocus(sender As Object, e As EventArgs) Handles combox_perfil.GotFocus

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lbl_fecha_hoy.Text = Format(Today, "dd/MMMM/yyyy")
        Me.Text = "Hotspot Mikrotik Manager" + System.Configuration.ConfigurationManager.AppSettings("iprb")

    End Sub

    Private Sub lbl_hoy_es_Click(sender As Object, e As EventArgs) Handles lbl_hoy_es.Click

    End Sub

    Private Sub PerfilesHotspotToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerfilesHotspotToolStripMenuItem.Click
        perfiles_navegacion.Show()

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
End Class


