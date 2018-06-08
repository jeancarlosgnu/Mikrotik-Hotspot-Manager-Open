Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO


Module procedimientos
    Public iprouter As String = System.Configuration.ConfigurationManager.AppSettings("iprb")
    Public loginrouter = System.Configuration.ConfigurationManager.AppSettings("userapi")
    Public passrouter = System.Configuration.ConfigurationManager.AppSettings("passwapi")

    Sub Mensaje_error_conex()
        MessageBox.Show("Problema al conectar a Routerboard  : " + System.Configuration.ConfigurationManager.AppSettings("iprb") + "  Verifique que se encuentre activa la API en su MIKROTIK.",
            "Error de Conexión con Mikrotik",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1)
    End Sub
    Sub Listar_vencidos()
        Dim DS As DataSet = Pruebaconexion.DataSet1
        Dim tabla As DataTable = Pruebaconexion.DataSet1.Tables("Tabla_de_usuarios")
        tabla.Clear()
        Dim mk = New mkAPI(iprouter)

        If Not mk.Login(loginrouter, passrouter) Then
            mk.Close()
            Pruebaconexion.tb_result.Text = "Error"
            Pruebaconexion.Enabled = True
            Exit Sub
        End If

        Pruebaconexion.Enabled = False
        mk.Send("/ip/hotspot/user/print")
        mk.Send("?comment", True)
        Dim comentario_partido As String() = Nothing
        Dim comentario As String
        Pruebaconexion.tb_result.Text = ""
        Dim fila As String
        Dim vector_valores As String() = Nothing
        For Each row In mk.Read()

            Pruebaconexion.tb_result.Text = Pruebaconexion.tb_result.Text + row + vbCrLf
            If (row <> "!done") Then
                fila = row.Replace("!re=.", "")
                vector_valores = Split(fila, "=")
                comentario = vector_valores(Array.IndexOf(vector_valores, "comment") + 1)
                'MsgBox(comentario)
                If comentario.Length > 1 Then
                    comentario_partido = Split(comentario, "-")
                    If comentario_partido.Length > 1 Then


                        If (vector_valores(Array.IndexOf(vector_valores, "limit-uptime") + 1)) = (vector_valores(Array.IndexOf(vector_valores, "uptime") + 1)) Or (CDate(comentario_partido(0)) <= CDate(Format(Today, "dd/MMMM/yyyy"))) Then
                            Dim Fila_data As DataRow = tabla.NewRow()
                            Fila_data("Id") = vector_valores(Array.IndexOf(vector_valores, "id") + 1)
                            Fila_data("Usuario") = vector_valores(Array.IndexOf(vector_valores, "name") + 1)
                            Fila_data("Tiempo_limite") = vector_valores(Array.IndexOf(vector_valores, "limit-uptime") + 1)
                            Fila_data("Tiempo_utilizado") = vector_valores(Array.IndexOf(vector_valores, "uptime") + 1)
                            Fila_data("Tiempo_vence") = comentario_partido(0)
                            Fila_data("Tiempo_sum") = comentario_partido(1)
                            tabla.Rows.Add(Fila_data)
                        End If
                    End If
                End If
            End If
        Next
        For Each row As DataGridViewRow In Pruebaconexion.parrila_usuarios.Rows

            If (row.Cells(1).Value = row.Cells(2).Value) Then
                row.DefaultCellStyle.BackColor = Color.IndianRed
                row.DefaultCellStyle.ForeColor = Color.White

            End If

            Dim fecha_actual As Date = Convert.ToDateTime(Format(Today, "dd/MMMM/yyyy"))
            Dim fecha_fila As Date = Convert.ToDateTime(row.Cells(3).Value)

            If (fecha_fila <= fecha_actual) Then
                row.DefaultCellStyle.BackColor = Color.Red
                row.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
        Pruebaconexion.Enabled = True
    End Sub
    Public Function formato_fechas_espanol(texto_fecha As String)
        Dim texto_retorno As String = ""
        Dim texto_rempla As String = texto_fecha
        Dim fecha_explit() As String



        If texto_fecha.Contains("w") = True Then
            fecha_explit = texto_fecha.Split("w")
            If fecha_explit(0) > 1 Then
                texto_retorno = texto_rempla.Replace("w", " Semanas")
            Else
                texto_retorno = texto_rempla.Replace("w", " Semana")
            End If

        End If
        If texto_fecha.Contains("d") = True Then
            fecha_explit = texto_fecha.Split("d")
            If fecha_explit(0) > 1 Then
                texto_retorno = texto_rempla.Replace("d", " Días")
            Else
                texto_retorno = texto_rempla.Replace("d", " Día")
            End If
        End If
        If texto_fecha.Contains("h") = True Then
            fecha_explit = texto_fecha.Split("h")

            If fecha_explit(0) > 1 Then
                texto_retorno = texto_rempla.Replace("h", " Horas")
            Else
                texto_retorno = texto_rempla.Replace("h", " Hora")
            End If

        End If
        Return (texto_retorno)

    End Function


    Sub resetear_seleccionados()

        If Pruebaconexion.parrila_usuarios.SelectedRows.Count > 0 Then


            Dim respuesta As DialogResult = MessageBox.Show("¿Esta Seguro de Resetear Los Usuarios Seleccionados ?", "Reset a Seleccionados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            Select Case respuesta
                Case Windows.Forms.DialogResult.Yes



                    Pruebaconexion.tb_result.Text = ""

                    Dim numero_filas As Integer
                    numero_filas = Pruebaconexion.parrila_usuarios.Rows.Count




                    Dim iprouter = System.Configuration.ConfigurationManager.AppSettings("iprb")
                    Dim loginrouter = System.Configuration.ConfigurationManager.AppSettings("userapi")
                    Dim passrouter = System.Configuration.ConfigurationManager.AppSettings("passwapi")

                    Pruebaconexion.Enabled = False

                    Dim mk = New mkAPI(iprouter)
                    If Not mk.Login(loginrouter, passrouter) Then
                        mk.Close()
                        Pruebaconexion.tb_result.Text = "Error"
                        Pruebaconexion.Enabled = True
                        Exit Sub
                    End If

                    Dim i As Integer
                    Dim nueva_fecha As String

                    '''For recorrer filas seleccionadas
                    For Each RW As DataGridViewRow In Pruebaconexion.parrila_usuarios.SelectedRows
                        'MsgBox(parrila_usuarios.Rows(i).Cells(0).Value)
                        'mk.Send("/ip/hotspot/user/remove")
                        'mk.Send("=.id=" & parrila_usuarios.Rows(i).Cells(0).Value, True)

                        mk.Send("/ip/hotspot/user/set")
                        mk.Send("=.id=" & RW.Cells("ID_USUARIO").Value)
                        nueva_fecha = Format(DateAdd(DateInterval.Day, RW.Cells("Tiempo_sum_Tiempo_sum").Value, CDate(Format(Today, "dd/MMMM/yyyy"))), "dd/MMMM/yyyy")
                        mk.Send("=comment=" & nueva_fecha & "-" & RW.Cells("Tiempo_sum_Tiempo_sum").Value, True)
                        mk.Send("/ip/hotspot/user/reset-counters")
                        mk.Send("=.id=" & RW.Cells("ID_USUARIO").Value, True)
                    Next


                    '''

                    For Each row In mk.Read()
                        Pruebaconexion.tb_result.Text = Pruebaconexion.tb_result.Text + row + vbCrLf
                    Next

                    Pruebaconexion.Enabled = True



                    listar_todos()
                Case Windows.Forms.DialogResult.No
                    'Descartar los cambios 
            End Select
        End If
    End Sub


    Public Function generar_cadena() As String
        Dim GenerateRandomString As String
        Dim retornar_cadena() As String
        GenerateRandomString = System.Guid.NewGuid.ToString

        ' System.Guid.NewGuid.ToString Genera una cadena assdasda-3423423423 entonces con split la partimos en un vector por el simbolo   "-"
        ' Y tomamos la primera parte del vector(0), Basicamente esto es un truco para no crear una funcion de crear cadenas aleatorias
        retornar_cadena = Split(GenerateRandomString, "-")

        Return UCase(retornar_cadena(0))
        'Pruebaconexion.txt_usuariocliente.Text = GenerateRandomString
    End Function

    Public Function Encrypt(ByVal Word As String, ByVal Key As String,
Optional ByVal Mode As Boolean = False) As String
        Dim w As Long, k As Long, p As Long, j As Long, NuChr As Long
        Dim Cd As String, Kd As String, Rd As String
        w = Len(Word)
        k = Len(Key)
        ' Modalidad de Encripción...
        If Mode = False Then
            For j = 1 To w
                Cd = Mid(Word, j, 1)
                If p = k Then p = 0
                p = p + 1
                Kd = Mid(Key, p, 1)
                NuChr = Asc(Cd) + Asc(Kd)
                If NuChr > 255 Then
                    NuChr = NuChr - 255
                End If
                Rd = Rd & Chr(NuChr)
            Next
            Encrypt = Rd
            Exit Function
        End If
        ' Modalidad de Dencripción...
        If Mode = True Then
            For j = 1 To w
                Cd = Mid(Word, j, 1)
                If p = k Then p = 0
                p = p + 1
                Kd = Mid(Key, p, 1)
                NuChr = Asc(Cd) - Asc(Kd)
                If NuChr < 0 Then
                    NuChr = NuChr + 255
                End If
                Rd = Rd & Chr(NuChr)
            Next
            Encrypt = Rd
            Exit Function
        End If

    End Function




    Sub crear_lote_usuarios(tiempo_uptime, comentario_fecha, cantidad_usuarios, fecha_vencimiento)
        Dim tabla As DataTable = Pruebaconexion.DataSet1.Tables("Tabla_de_usuarios")
        tabla.Clear()
        'Dim fecha_vencimiento As String = comentario_fecha.ToString




        Dim mk = New mkAPI(iprouter)
        If Not mk.Login(loginrouter, passrouter) Then
            mk.Close()
            Pruebaconexion.tb_result.Text = "Error"
            Pruebaconexion.Enabled = True
            Exit Sub
        End If

        Dim usuario_crear As String

        For contador_creados As Integer = 1 To cantidad_usuarios

            If cantidad_usuarios = 999999 Then
                usuario_crear = Pruebaconexion.txt_usuariocliente.Text
                contador_creados = 999999

            Else
                usuario_crear = generar_cadena()

            End If

            mk.Send("/ip/hotspot/user/add")
            mk.Send("=name=" & usuario_crear)
            mk.Send("=password=" & usuario_crear)
            mk.Send("=limit-uptime=" & tiempo_uptime)
            mk.Send("=profile=" & Pruebaconexion.combox_perfil.SelectedItem)
            mk.Send("=comment=" & comentario_fecha, True)

            Dim partido As String() = Nothing

            For Each row In mk.Read()

                Dim vector_valores As String() = Nothing

                If (row <> "!done") Then

                    vector_valores = Split(row, "=")


                    If vector_valores(0) <> "!trap" Then

                        Dim Fila_data As DataRow = tabla.NewRow()
                        Fila_data("Id") = vector_valores(Array.IndexOf(vector_valores, "id") + 1)
                        Fila_data("Usuario") = usuario_crear
                        Fila_data("PERFIL_NAVEGACION_PERFIL") = Pruebaconexion.combox_perfil.SelectedItem
                        Fila_data("Tiempo_limite") = tiempo_uptime
                        Fila_data("Tiempo_vence") = fecha_vencimiento



                        tabla.Rows.Add(Fila_data)
                    Else
                        MsgBox("El Usuario ya Existe")
                    End If

                    Pruebaconexion.tb_result.Text = Pruebaconexion.tb_result.Text + row + vbCrLf

                End If

            Next

            'Pruebaconexion.Enabled = True
            Pruebaconexion.txt_usuariocliente.Text = ""
        Next


        Pruebaconexion.check_lote.Checked = False
        Pruebaconexion.numero_tiempo.Value = 1
        Pruebaconexion.list_hora_dia_mes.ClearSelected()
    End Sub

    Public Function GetDataTable() As DataTable
        Dim dataTable As New DataTable("MyDataTable")
        'Create another DataColumn Name
        Dim dataColumn_1 As New DataColumn(Pruebaconexion.parrila_usuarios.Columns(1).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_1)
        Dim dataColumn_2 As New DataColumn(Pruebaconexion.parrila_usuarios.Columns(2).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_2)
        Dim dataColumn_3 As New DataColumn(Pruebaconexion.parrila_usuarios.Columns(3).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_3)
        'Now Add some row to newly created dataTable
        Dim dataRow As DataRow
        For i As Integer = 0 To Pruebaconexion.parrila_usuarios.Rows.Count - 1

            ' If parrila_usuarios.Rows(i).Selected = True Then
            If Pruebaconexion.parrila_usuarios.Rows(i).Selected = True Then


                dataRow = dataTable.NewRow()
                ' Important you have create New row
                dataRow(Pruebaconexion.parrila_usuarios.Columns(1).HeaderText.ToString()) = Pruebaconexion.parrila_usuarios.Rows(i).Cells(1).Value.ToString()
                dataRow(Pruebaconexion.parrila_usuarios.Columns(2).HeaderText.ToString()) = Pruebaconexion.parrila_usuarios.Rows(i).Cells(1).Value.ToString()
                dataRow(Pruebaconexion.parrila_usuarios.Columns(3).HeaderText.ToString()) = Pruebaconexion.parrila_usuarios.Rows(i).Cells(2).Value.ToString()

                dataTable.Rows.Add(dataRow)
            End If
        Next
        dataTable.AcceptChanges()
        Return dataTable
    End Function

    Sub ExportDataToPDFTable()
        Dim paragraph As New Paragraph
        Dim doc As New Document(iTextSharp.text.PageSize.LETTER, 40, 40, 40, 40)
        Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(Pruebaconexion.SaveFileDialog1.FileName + ".pdf", FileMode.Create))
        doc.Open()

        Dim font12BoldRed As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 25.0F, iTextSharp.text.Font.UNDERLINE Or iTextSharp.text.Font.BOLDITALIC, BaseColor.RED)
        Dim font12Bold As New iTextSharp.text.Font(BaseFont.CreateFont(directoriofuentes() + "\consola.ttf", BaseFont.WINANSI, BaseFont.EMBEDDED), 25.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim fecha_para_ticket As String


        Dim font12Normal As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 25.0F, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)

        Dim p1 As New Phrase

        'Create instance of the pdf table and set the number of column in that table
        Dim PdfTable As New PdfPTable(3)
        PdfTable.TotalWidth = 550.0F
        'fix the absolute width of the table
        PdfTable.LockedWidth = True
        'relative col widths in proportions - 1,4,1,1 and 1
        Dim widths As Single() = New Single() {2.2F, 2.2F, 2.2F}
        PdfTable.SetWidths(widths)
        PdfTable.HorizontalAlignment = 1 ' 0 --> Left, 1 --> Center, 2 --> Right
        PdfTable.SpacingBefore = 2.0F

        'pdfCell Decleration
        Dim PdfPCell As PdfPCell = Nothing

        Dim contador As Integer = 0

        For Each RW As DataGridViewRow In Pruebaconexion.parrila_usuarios.SelectedRows
            'New Paragraph(New Chunk(String.Format("{0} {1}\n", , , font12Bold))
            'MsgBox(RW.Cells("Usuario_Usuario").Value.ToString)
            contador = contador + 1
            Dim Celda As New PdfPCell()




            Dim LINEA1 As New Paragraph(New Chunk("PIN: " + (RW.Cells("Usuario_Usuario").Value.ToString), font12Bold))
            ' MsgBox(formato_fechas_espanol(RW.Cells("Tiempo_limite_Tiempo_limite").Value.ToString))
            fecha_para_ticket = formato_fechas_espanol(RW.Cells("Tiempo_limite_Tiempo_limite").Value.ToString)
            Dim LINEA2 As New Paragraph(New Chunk("Tiempo: " + fecha_para_ticket))
            Dim LINEA3 As New Paragraph(New Chunk("Vence:" + (RW.Cells("Tiempo_vence_Tiempo_vence").Value.ToString)))
            LINEA1.Alignment = Element.ALIGN_LEFT
            LINEA2.Alignment = Element.ALIGN_LEFT
            LINEA3.Alignment = Element.ALIGN_LEFT

            If (System.Configuration.ConfigurationManager.AppSettings("ruta_imagen_tickets").Length > 0) Then
                Dim LOGO As Image = iTextSharp.text.Image.GetInstance(System.Configuration.ConfigurationManager.AppSettings("ruta_imagen_tickets"))
                LOGO.ScaleAbsolute(120, 64)
                LOGO.Alignment = Element.ALIGN_CENTER

                Celda.AddElement(LOGO)
            End If

            Celda.AddElement(LINEA1)
            Celda.AddElement(LINEA2)
            Celda.AddElement(LINEA3)
            PdfTable.AddCell(Celda)



        Next

        While contador Mod 3 <> 0
            Dim Celda As New PdfPCell()
            PdfTable.AddCell(Celda)
            contador = contador + 1

        End While

        '#####################################################



        '#####################################################


        doc.Add(PdfTable)

        doc.Close()
    End Sub


    Sub exportarpdf()
        Dim paragraph As New Paragraph
        Dim doc As New Document(iTextSharp.text.PageSize.LETTER, 40, 40, 40, 40)
        Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(Pruebaconexion.SaveFileDialog1.FileName + ".pdf", FileMode.Create))
        doc.Open()


        Dim unaTabla = New PdfPTable(3)
        unaTabla.SetWidthPercentage({200, 200, 200}, PageSize.LETTER)

        Dim celda1 = New PdfPCell(New Paragraph("Celda 1", FontFactory.GetFont("Arial", 30)))
        Dim celda2 = New PdfPCell(New Paragraph("Celda 2", FontFactory.GetFont("Arial", 30)))
        Dim celda3 = New PdfPCell(New Paragraph("Celda 3", FontFactory.GetFont("Arial", 30)))


        unaTabla.AddCell(celda1)
        unaTabla.AddCell(celda2)
        unaTabla.AddCell(celda3)


        doc.Add(unaTabla)

        doc.Close()
    End Sub



    Public Function directoriofuentes() As String
        Dim strAux As String
        Try
            strAux = System.Environment.GetFolderPath(Environment.SpecialFolder.System).ToUpper
            strAux = strAux.Replace("32", "")
            strAux = strAux.Replace("SYSTEM", "FONTS")
        Catch ex As Exception
            strAux = ""
        End Try

        'MsgBox(strAux)
        Return strAux
        'MsgBox(strAux)
    End Function

    Sub listar_todos()


        'Dim DS As DataSet = Pruebaconexion.DataSet1
        Dim tabla As DataTable = Pruebaconexion.DataSet1.Tables("Tabla_de_usuarios")
        tabla.Clear()
        Dim mk = New mkAPI(iprouter)

        If Not mk.Login(loginrouter, passrouter) Then
            mk.Close()
            Pruebaconexion.tb_result.Text = "Error"
            Pruebaconexion.Enabled = True
            Exit Sub
        End If

        Pruebaconexion.Enabled = False
        mk.Send("/ip/hotspot/user/print")
        mk.Send("?comment", True)
        Dim comentario_partido As String() = Nothing
        Dim comentario As String
        Pruebaconexion.tb_result.Text = ""
        Dim fila As String
        Dim vector_valores As String() = Nothing
        For Each row In mk.Read()

            Pruebaconexion.tb_result.Text = Pruebaconexion.tb_result.Text + row + vbCrLf
            If (row <> "!done") Then
                fila = row.Replace("!re=.", "")
                vector_valores = Split(fila, "=")
                comentario = vector_valores(Array.IndexOf(vector_valores, "comment") + 1)
                'MsgBox(comentario)
                If comentario.Length > 1 Then
                    comentario_partido = Split(comentario, "-")
                    If comentario_partido.Length > 1 Then
                        Dim Fila_data As DataRow = tabla.NewRow()
                        Fila_data("Id") = vector_valores(Array.IndexOf(vector_valores, "id") + 1)
                        Fila_data("Usuario") = vector_valores(Array.IndexOf(vector_valores, "name") + 1)
                        Fila_data("Tiempo_limite") = vector_valores(Array.IndexOf(vector_valores, "limit-uptime") + 1)
                        Fila_data("PERFIL_NAVEGACION_PERFIL") = vector_valores(Array.IndexOf(vector_valores, "profile") + 1)
                        Fila_data("Tiempo_utilizado") = vector_valores(Array.IndexOf(vector_valores, "uptime") + 1)
                        Fila_data("Tiempo_vence") = comentario_partido(0)
                        Fila_data("Tiempo_sum") = comentario_partido(1)
                        tabla.Rows.Add(Fila_data)
                    End If
                End If
            End If
        Next
        For Each row As DataGridViewRow In Pruebaconexion.parrila_usuarios.Rows

            If (row.Cells(1).Value = row.Cells("Tiempo_utilizado_Tiempo_utilizado").Value) Then
                row.DefaultCellStyle.BackColor = Color.IndianRed
                row.DefaultCellStyle.ForeColor = Color.White

            End If

            Dim fecha_actual As Date = Convert.ToDateTime(Format(Today, "dd/MMMM/yyyy"))
            Dim fecha_fila As Date = Convert.ToDateTime(row.Cells("Tiempo_vence_Tiempo_vence").Value)

            If (fecha_fila <= fecha_actual) Then
                row.DefaultCellStyle.BackColor = Color.Red
                row.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
        Pruebaconexion.Enabled = True
    End Sub
    Sub cargar_perfiles_en_configuracion()
        perfiles_navegacion.parrila_perfiles.Rows.Clear()

        Try


            Dim mk = New mkAPI(iprouter)

            If Not mk.Login(loginrouter, passrouter) Then
                mk.Close()
                Pruebaconexion.tb_result.Text = "Error"
                Pruebaconexion.Enabled = True
                Exit Sub
            End If


            mk.Send("/ip/hotspot/user/profile/print", True)
            Pruebaconexion.tb_result.Text = ""
            Dim fila As String
            Dim vector_valores As String() = Nothing
            For Each row In mk.Read()

                Pruebaconexion.tb_result.Text = Pruebaconexion.tb_result.Text + row + vbCrLf
                If (row <> "!done") Then
                    fila = row.Replace("!re=.", "")
                    vector_valores = Split(fila, "=")
                    'MsgBox(comentario)

                    perfiles_navegacion.parrila_perfiles.Rows.Add(vector_valores(Array.IndexOf(vector_valores, "id") + 1), vector_valores(Array.IndexOf(vector_valores, "name") + 1), vector_valores(Array.IndexOf(vector_valores, "rate-limit") + 1))


                End If

            Next

            Pruebaconexion.Enabled = True
        Catch ex As Exception
            Mensaje_error_conex()


        End Try

    End Sub
    Sub cargar_perfiles_en_principal()


        If Pruebaconexion.combox_perfil.Items.Count > 0 Then
            Pruebaconexion.combox_perfil.Items.Clear()
        End If


        Try


            Dim mk = New mkAPI(iprouter)

            If Not mk.Login(loginrouter, passrouter) Then
                mk.Close()
                Pruebaconexion.tb_result.Text = "Error"
                Pruebaconexion.Enabled = True
                Exit Sub
            End If


            mk.Send("/ip/hotspot/user/profile/print", True)
            Pruebaconexion.tb_result.Text = ""
            Dim fila As String
            Dim vector_valores As String() = Nothing
            For Each row In mk.Read()

                Pruebaconexion.tb_result.Text = Pruebaconexion.tb_result.Text + row + vbCrLf
                If (row <> "!done") Then
                    fila = row.Replace("!re=.", "")
                    vector_valores = Split(fila, "=")

                    Pruebaconexion.combox_perfil.Items.Add(vector_valores(Array.IndexOf(vector_valores, "name") + 1))



                End If

            Next

            Pruebaconexion.combox_perfil.SelectedIndex = 0
        Catch ex As Exception
            Mensaje_error_conex()


        End Try

    End Sub
    Public Function Compare(
    t1 As Date,
    t2 As Date
                ) As Integer

    End Function
End Module
