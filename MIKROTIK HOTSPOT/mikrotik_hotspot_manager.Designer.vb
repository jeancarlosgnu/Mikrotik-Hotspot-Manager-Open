<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pruebaconexion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pruebaconexion))
        Me.tb_result = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurarParametrosRBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_usuariocliente = New System.Windows.Forms.TextBox()
        Me.lbl_usuario_cli = New System.Windows.Forms.Label()
        Me.list_hora_dia_mes = New System.Windows.Forms.ListBox()
        Me.numero_tiempo = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Grupo_tiempo = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grupo_usuario = New System.Windows.Forms.GroupBox()
        Me.bt_generar_clave = New System.Windows.Forms.Button()
        Me.lbl_fecha_hoy = New System.Windows.Forms.Label()
        Me.lbl_hoy_es = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.check_buscar = New System.Windows.Forms.CheckBox()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.check_lote = New System.Windows.Forms.CheckBox()
        Me.Group_lote = New System.Windows.Forms.GroupBox()
        Me.numeric_cantidad_lote = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grupo_buscar = New System.Windows.Forms.GroupBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.bt_reset = New System.Windows.Forms.Button()
        Me.bt_crear_usuario = New System.Windows.Forms.Button()
        Me.bt_Eliminar = New System.Windows.Forms.Button()
        Me.bt_select_all = New System.Windows.Forms.Button()
        Me.btb_pdf = New System.Windows.Forms.Button()
        Me.bt_shutdown = New System.Windows.Forms.Button()
        Me.bt_listar_usuarios = New System.Windows.Forms.Button()
        Me.Grupo_perfil = New System.Windows.Forms.GroupBox()
        Me.combox_perfil = New System.Windows.Forms.ComboBox()
        Me.lbl_velocidad = New System.Windows.Forms.Label()
        Me.DataSet1 = New System.Data.DataSet()
        Me.Tabla_de_usuarios = New System.Data.DataTable()
        Me.Id = New System.Data.DataColumn()
        Me.Usuario = New System.Data.DataColumn()
        Me.Tiempo_limite = New System.Data.DataColumn()
        Me.Tiempo_utilizado = New System.Data.DataColumn()
        Me.Tiempo_vence = New System.Data.DataColumn()
        Me.Tiempo_sum = New System.Data.DataColumn()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.parrila_usuarios = New System.Windows.Forms.DataGridView()
        Me.Usuario_Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tiempo_limite_Tiempo_limite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PERFIL_NAVEGACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tiempo_utilizado_Tiempo_utilizado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tiempo_vence_Tiempo_vence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tiempo_sum_Tiempo_sum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_USUARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bt_listar_vencidos = New System.Windows.Forms.Button()
        Me.PerfilesHotspotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.numero_tiempo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grupo_tiempo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grupo_usuario.SuspendLayout()
        Me.Group_lote.SuspendLayout()
        CType(Me.numeric_cantidad_lote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo_buscar.SuspendLayout()
        Me.Grupo_perfil.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabla_de_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parrila_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_result
        '
        Me.tb_result.Location = New System.Drawing.Point(4, 404)
        Me.tb_result.Multiline = True
        Me.tb_result.Name = "tb_result"
        Me.tb_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_result.Size = New System.Drawing.Size(735, 40)
        Me.tb_result.TabIndex = 10
        Me.tb_result.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.HerramientasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(742, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguracionToolStripMenuItem, Me.CerrarToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigurarParametrosRBToolStripMenuItem, Me.PerfilesHotspotToolStripMenuItem})
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuración"
        '
        'ConfigurarParametrosRBToolStripMenuItem
        '
        Me.ConfigurarParametrosRBToolStripMenuItem.Name = "ConfigurarParametrosRBToolStripMenuItem"
        Me.ConfigurarParametrosRBToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.ConfigurarParametrosRBToolStripMenuItem.Text = "Configurar Parámetros de RB"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.shutdown_22x22
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DebugToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'DebugToolStripMenuItem
        '
        Me.DebugToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem1})
        Me.DebugToolStripMenuItem.Name = "DebugToolStripMenuItem"
        Me.DebugToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.DebugToolStripMenuItem.Text = "Debug"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(153, 22)
        Me.ToolStripMenuItem2.Text = "Mostrar Debug"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.ToolStripMenuItem1.Text = "Ocultar Debug"
        '
        'txt_usuariocliente
        '
        Me.txt_usuariocliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_usuariocliente.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuariocliente.Location = New System.Drawing.Point(8, 23)
        Me.txt_usuariocliente.MaxLength = 8
        Me.txt_usuariocliente.Name = "txt_usuariocliente"
        Me.txt_usuariocliente.Size = New System.Drawing.Size(117, 30)
        Me.txt_usuariocliente.TabIndex = 0
        '
        'lbl_usuario_cli
        '
        Me.lbl_usuario_cli.AutoSize = True
        Me.lbl_usuario_cli.Location = New System.Drawing.Point(8, 8)
        Me.lbl_usuario_cli.Name = "lbl_usuario_cli"
        Me.lbl_usuario_cli.Size = New System.Drawing.Size(119, 13)
        Me.lbl_usuario_cli.TabIndex = 18
        Me.lbl_usuario_cli.Text = "Digitar Usuario a Crear: "
        '
        'list_hora_dia_mes
        '
        Me.list_hora_dia_mes.FormattingEnabled = True
        Me.list_hora_dia_mes.Items.AddRange(New Object() {"HORA", "DIA", "MES"})
        Me.list_hora_dia_mes.Location = New System.Drawing.Point(81, 10)
        Me.list_hora_dia_mes.Name = "list_hora_dia_mes"
        Me.list_hora_dia_mes.Size = New System.Drawing.Size(50, 43)
        Me.list_hora_dia_mes.TabIndex = 4
        '
        'numero_tiempo
        '
        Me.numero_tiempo.Enabled = False
        Me.numero_tiempo.Location = New System.Drawing.Point(8, 33)
        Me.numero_tiempo.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.numero_tiempo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numero_tiempo.Name = "numero_tiempo"
        Me.numero_tiempo.Size = New System.Drawing.Size(67, 20)
        Me.numero_tiempo.TabIndex = 3
        Me.numero_tiempo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Crear por:"
        '
        'Grupo_tiempo
        '
        Me.Grupo_tiempo.Controls.Add(Me.GroupBox1)
        Me.Grupo_tiempo.Controls.Add(Me.Label1)
        Me.Grupo_tiempo.Controls.Add(Me.numero_tiempo)
        Me.Grupo_tiempo.Controls.Add(Me.list_hora_dia_mes)
        Me.Grupo_tiempo.Location = New System.Drawing.Point(5, 143)
        Me.Grupo_tiempo.Name = "Grupo_tiempo"
        Me.Grupo_tiempo.Size = New System.Drawing.Size(137, 59)
        Me.Grupo_tiempo.TabIndex = 25
        Me.Grupo_tiempo.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 40)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Crear por:"
        '
        'grupo_usuario
        '
        Me.grupo_usuario.Controls.Add(Me.txt_usuariocliente)
        Me.grupo_usuario.Controls.Add(Me.lbl_usuario_cli)
        Me.grupo_usuario.Controls.Add(Me.bt_generar_clave)
        Me.grupo_usuario.Location = New System.Drawing.Point(4, 20)
        Me.grupo_usuario.Name = "grupo_usuario"
        Me.grupo_usuario.Size = New System.Drawing.Size(138, 84)
        Me.grupo_usuario.TabIndex = 26
        Me.grupo_usuario.TabStop = False
        '
        'bt_generar_clave
        '
        Me.bt_generar_clave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_generar_clave.Image = Global.WindowsApplication1.My.Resources.Resources.random
        Me.bt_generar_clave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_generar_clave.Location = New System.Drawing.Point(8, 55)
        Me.bt_generar_clave.Name = "bt_generar_clave"
        Me.bt_generar_clave.Size = New System.Drawing.Size(117, 26)
        Me.bt_generar_clave.TabIndex = 1
        Me.bt_generar_clave.Text = "Generar Auto"
        Me.bt_generar_clave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_generar_clave.UseVisualStyleBackColor = True
        '
        'lbl_fecha_hoy
        '
        Me.lbl_fecha_hoy.AutoSize = True
        Me.lbl_fecha_hoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha_hoy.Location = New System.Drawing.Point(386, 3)
        Me.lbl_fecha_hoy.Name = "lbl_fecha_hoy"
        Me.lbl_fecha_hoy.Size = New System.Drawing.Size(0, 18)
        Me.lbl_fecha_hoy.TabIndex = 27
        '
        'lbl_hoy_es
        '
        Me.lbl_hoy_es.AutoSize = True
        Me.lbl_hoy_es.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hoy_es.Location = New System.Drawing.Point(316, 3)
        Me.lbl_hoy_es.Name = "lbl_hoy_es"
        Me.lbl_hoy_es.Size = New System.Drawing.Size(71, 18)
        Me.lbl_hoy_es.TabIndex = 27
        Me.lbl_hoy_es.Text = "Hoy es :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.IndianRed
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(579, 404)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "* Vencidos por Tiempo Online"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(464, 404)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "* Vencidos por Fecha"
        '
        'check_buscar
        '
        Me.check_buscar.AutoSize = True
        Me.check_buscar.Location = New System.Drawing.Point(39, 9)
        Me.check_buscar.Name = "check_buscar"
        Me.check_buscar.Size = New System.Drawing.Size(59, 17)
        Me.check_buscar.TabIndex = 6
        Me.check_buscar.Text = "Buscar"
        Me.check_buscar.UseVisualStyleBackColor = True
        '
        'txt_buscar
        '
        Me.txt_buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_buscar.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscar.Location = New System.Drawing.Point(8, 29)
        Me.txt_buscar.MaxLength = 8
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(117, 30)
        Me.txt_buscar.TabIndex = 19
        Me.txt_buscar.Visible = False
        '
        'check_lote
        '
        Me.check_lote.AutoSize = True
        Me.check_lote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_lote.Location = New System.Drawing.Point(10, 8)
        Me.check_lote.Name = "check_lote"
        Me.check_lote.Size = New System.Drawing.Size(100, 17)
        Me.check_lote.TabIndex = 2
        Me.check_lote.Text = "Generar Lote"
        Me.check_lote.UseVisualStyleBackColor = True
        '
        'Group_lote
        '
        Me.Group_lote.Controls.Add(Me.numeric_cantidad_lote)
        Me.Group_lote.Controls.Add(Me.Label3)
        Me.Group_lote.Controls.Add(Me.check_lote)
        Me.Group_lote.Location = New System.Drawing.Point(5, 100)
        Me.Group_lote.Name = "Group_lote"
        Me.Group_lote.Size = New System.Drawing.Size(137, 47)
        Me.Group_lote.TabIndex = 36
        Me.Group_lote.TabStop = False
        '
        'numeric_cantidad_lote
        '
        Me.numeric_cantidad_lote.Enabled = False
        Me.numeric_cantidad_lote.Location = New System.Drawing.Point(88, 24)
        Me.numeric_cantidad_lote.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numeric_cantidad_lote.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numeric_cantidad_lote.Name = "numeric_cantidad_lote"
        Me.numeric_cantidad_lote.Size = New System.Drawing.Size(48, 20)
        Me.numeric_cantidad_lote.TabIndex = 99999999
        Me.numeric_cantidad_lote.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Cant de Usuarios"
        '
        'grupo_buscar
        '
        Me.grupo_buscar.Controls.Add(Me.check_buscar)
        Me.grupo_buscar.Controls.Add(Me.txt_buscar)
        Me.grupo_buscar.Location = New System.Drawing.Point(5, 293)
        Me.grupo_buscar.Name = "grupo_buscar"
        Me.grupo_buscar.Size = New System.Drawing.Size(137, 65)
        Me.grupo_buscar.TabIndex = 37
        Me.grupo_buscar.TabStop = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.AddExtension = False
        Me.SaveFileDialog1.DefaultExt = "pdf"
        '
        'bt_reset
        '
        Me.bt_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_reset.Image = Global.WindowsApplication1.My.Resources.Resources.reset
        Me.bt_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_reset.Location = New System.Drawing.Point(467, 420)
        Me.bt_reset.Name = "bt_reset"
        Me.bt_reset.Size = New System.Drawing.Size(84, 30)
        Me.bt_reset.TabIndex = 14
        Me.bt_reset.Text = "Resetear"
        Me.bt_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_reset.UseVisualStyleBackColor = True
        '
        'bt_crear_usuario
        '
        Me.bt_crear_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_crear_usuario.Image = Global.WindowsApplication1.My.Resources.Resources.user_add2_22x22
        Me.bt_crear_usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_crear_usuario.Location = New System.Drawing.Point(11, 257)
        Me.bt_crear_usuario.Name = "bt_crear_usuario"
        Me.bt_crear_usuario.Size = New System.Drawing.Size(125, 30)
        Me.bt_crear_usuario.TabIndex = 5
        Me.bt_crear_usuario.Text = "Crear Usuario"
        Me.bt_crear_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_crear_usuario.UseVisualStyleBackColor = True
        '
        'bt_Eliminar
        '
        Me.bt_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Eliminar.Image = Global.WindowsApplication1.My.Resources.Resources.delete_user2_22x22
        Me.bt_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Eliminar.Location = New System.Drawing.Point(556, 420)
        Me.bt_Eliminar.Name = "bt_Eliminar"
        Me.bt_Eliminar.Size = New System.Drawing.Size(80, 30)
        Me.bt_Eliminar.TabIndex = 21
        Me.bt_Eliminar.Text = " Eliminar"
        Me.bt_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Eliminar.UseVisualStyleBackColor = True
        '
        'bt_select_all
        '
        Me.bt_select_all.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_select_all.Image = Global.WindowsApplication1.My.Resources.Resources.lista
        Me.bt_select_all.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_select_all.Location = New System.Drawing.Point(642, 420)
        Me.bt_select_all.Name = "bt_select_all"
        Me.bt_select_all.Size = New System.Drawing.Size(95, 30)
        Me.bt_select_all.TabIndex = 21
        Me.bt_select_all.Text = "Sel. Todos"
        Me.bt_select_all.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_select_all.UseVisualStyleBackColor = True
        '
        'btb_pdf
        '
        Me.btb_pdf.AccessibleDescription = "  asdasd"
        Me.btb_pdf.AutoEllipsis = True
        Me.btb_pdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btb_pdf.Image = Global.WindowsApplication1.My.Resources.Resources.pdf
        Me.btb_pdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btb_pdf.Location = New System.Drawing.Point(234, 420)
        Me.btb_pdf.Name = "btb_pdf"
        Me.btb_pdf.Size = New System.Drawing.Size(135, 30)
        Me.btb_pdf.TabIndex = 7
        Me.btb_pdf.Text = "Crear PDF de Sel."
        Me.btb_pdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btb_pdf.UseVisualStyleBackColor = True
        '
        'bt_shutdown
        '
        Me.bt_shutdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_shutdown.Image = Global.WindowsApplication1.My.Resources.Resources.shutdown_22x22
        Me.bt_shutdown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_shutdown.Location = New System.Drawing.Point(5, 420)
        Me.bt_shutdown.Name = "bt_shutdown"
        Me.bt_shutdown.Size = New System.Drawing.Size(73, 30)
        Me.bt_shutdown.TabIndex = 19
        Me.bt_shutdown.Text = "Cerrar"
        Me.bt_shutdown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_shutdown.UseVisualStyleBackColor = True
        '
        'bt_listar_usuarios
        '
        Me.bt_listar_usuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_listar_usuarios.Image = Global.WindowsApplication1.My.Resources.Resources.lista
        Me.bt_listar_usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_listar_usuarios.Location = New System.Drawing.Point(375, 420)
        Me.bt_listar_usuarios.Name = "bt_listar_usuarios"
        Me.bt_listar_usuarios.Size = New System.Drawing.Size(86, 30)
        Me.bt_listar_usuarios.TabIndex = 19
        Me.bt_listar_usuarios.Text = "LisTodos"
        Me.bt_listar_usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_listar_usuarios.UseVisualStyleBackColor = True
        '
        'Grupo_perfil
        '
        Me.Grupo_perfil.Controls.Add(Me.combox_perfil)
        Me.Grupo_perfil.Controls.Add(Me.lbl_velocidad)
        Me.Grupo_perfil.Location = New System.Drawing.Point(9, 198)
        Me.Grupo_perfil.Name = "Grupo_perfil"
        Me.Grupo_perfil.Size = New System.Drawing.Size(131, 53)
        Me.Grupo_perfil.TabIndex = 38
        Me.Grupo_perfil.TabStop = False
        '
        'combox_perfil
        '
        Me.combox_perfil.AccessibleDescription = ""
        Me.combox_perfil.AccessibleName = ""
        Me.combox_perfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combox_perfil.FormattingEnabled = True
        Me.combox_perfil.Location = New System.Drawing.Point(7, 23)
        Me.combox_perfil.Name = "combox_perfil"
        Me.combox_perfil.Size = New System.Drawing.Size(121, 21)
        Me.combox_perfil.TabIndex = 1
        Me.combox_perfil.Tag = ""
        '
        'lbl_velocidad
        '
        Me.lbl_velocidad.AutoSize = True
        Me.lbl_velocidad.Location = New System.Drawing.Point(8, 7)
        Me.lbl_velocidad.Name = "lbl_velocidad"
        Me.lbl_velocidad.Size = New System.Drawing.Size(70, 13)
        Me.lbl_velocidad.TabIndex = 0
        Me.lbl_velocidad.Text = "Perfil Hotspot"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "Dataset_usuarios"
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.Tabla_de_usuarios})
        '
        'Tabla_de_usuarios
        '
        Me.Tabla_de_usuarios.Columns.AddRange(New System.Data.DataColumn() {Me.Id, Me.Usuario, Me.Tiempo_limite, Me.Tiempo_utilizado, Me.Tiempo_vence, Me.Tiempo_sum, Me.DataColumn1})
        Me.Tabla_de_usuarios.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"Usuario"}, True)})
        Me.Tabla_de_usuarios.PrimaryKey = New System.Data.DataColumn() {Me.Usuario}
        Me.Tabla_de_usuarios.TableName = "Tabla_de_usuarios"
        '
        'Id
        '
        Me.Id.AllowDBNull = False
        Me.Id.Caption = "Id"
        Me.Id.ColumnName = "Id"
        '
        'Usuario
        '
        Me.Usuario.AllowDBNull = False
        Me.Usuario.Caption = "Usuario"
        Me.Usuario.ColumnName = "Usuario"
        '
        'Tiempo_limite
        '
        Me.Tiempo_limite.Caption = "Tiempo_limite"
        Me.Tiempo_limite.ColumnName = "Tiempo_limite"
        '
        'Tiempo_utilizado
        '
        Me.Tiempo_utilizado.Caption = "Tiempo_utilizado"
        Me.Tiempo_utilizado.ColumnName = "Tiempo_utilizado"
        '
        'Tiempo_vence
        '
        Me.Tiempo_vence.Caption = "Tiempo_vence"
        Me.Tiempo_vence.ColumnName = "Tiempo_vence"
        '
        'Tiempo_sum
        '
        Me.Tiempo_sum.Caption = "Tiempo_sum"
        Me.Tiempo_sum.ColumnName = "Tiempo_sum"
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "PERFIL_NAVEGACION_PERFIL"
        Me.DataColumn1.ColumnName = "PERFIL_NAVEGACION_PERFIL"
        '
        'parrila_usuarios
        '
        Me.parrila_usuarios.AllowUserToAddRows = False
        Me.parrila_usuarios.AllowUserToDeleteRows = False
        Me.parrila_usuarios.AllowUserToOrderColumns = True
        Me.parrila_usuarios.AllowUserToResizeColumns = False
        Me.parrila_usuarios.AllowUserToResizeRows = False
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.parrila_usuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.parrila_usuarios.AutoGenerateColumns = False
        Me.parrila_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.parrila_usuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.parrila_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.parrila_usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Usuario_Usuario, Me.Tiempo_limite_Tiempo_limite, Me.PERFIL_NAVEGACION, Me.Tiempo_utilizado_Tiempo_utilizado, Me.Tiempo_vence_Tiempo_vence, Me.Tiempo_sum_Tiempo_sum, Me.ID_USUARIO})
        Me.parrila_usuarios.DataSource = Me.DataSet1
        Me.parrila_usuarios.Location = New System.Drawing.Point(146, 24)
        Me.parrila_usuarios.Name = "parrila_usuarios"
        Me.parrila_usuarios.ReadOnly = True
        Me.parrila_usuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.parrila_usuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.parrila_usuarios.ShowCellErrors = False
        Me.parrila_usuarios.ShowCellToolTips = False
        Me.parrila_usuarios.ShowEditingIcon = False
        Me.parrila_usuarios.Size = New System.Drawing.Size(593, 370)
        Me.parrila_usuarios.TabIndex = 39
        '
        'Usuario_Usuario
        '
        Me.Usuario_Usuario.DataPropertyName = "Usuario"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario_Usuario.DefaultCellStyle = DataGridViewCellStyle3
        Me.Usuario_Usuario.HeaderText = "Usuario"
        Me.Usuario_Usuario.Name = "Usuario_Usuario"
        Me.Usuario_Usuario.ReadOnly = True
        Me.Usuario_Usuario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Tiempo_limite_Tiempo_limite
        '
        Me.Tiempo_limite_Tiempo_limite.DataPropertyName = "Tiempo_limite"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tiempo_limite_Tiempo_limite.DefaultCellStyle = DataGridViewCellStyle4
        Me.Tiempo_limite_Tiempo_limite.HeaderText = "T.Limite"
        Me.Tiempo_limite_Tiempo_limite.Name = "Tiempo_limite_Tiempo_limite"
        Me.Tiempo_limite_Tiempo_limite.ReadOnly = True
        Me.Tiempo_limite_Tiempo_limite.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'PERFIL_NAVEGACION
        '
        Me.PERFIL_NAVEGACION.DataPropertyName = "PERFIL_NAVEGACION_PERFIL"
        Me.PERFIL_NAVEGACION.HeaderText = "Perfil"
        Me.PERFIL_NAVEGACION.Name = "PERFIL_NAVEGACION"
        Me.PERFIL_NAVEGACION.ReadOnly = True
        '
        'Tiempo_utilizado_Tiempo_utilizado
        '
        Me.Tiempo_utilizado_Tiempo_utilizado.DataPropertyName = "Tiempo_utilizado"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Tiempo_utilizado_Tiempo_utilizado.DefaultCellStyle = DataGridViewCellStyle5
        Me.Tiempo_utilizado_Tiempo_utilizado.HeaderText = "T Utilizado"
        Me.Tiempo_utilizado_Tiempo_utilizado.Name = "Tiempo_utilizado_Tiempo_utilizado"
        Me.Tiempo_utilizado_Tiempo_utilizado.ReadOnly = True
        Me.Tiempo_utilizado_Tiempo_utilizado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Tiempo_vence_Tiempo_vence
        '
        Me.Tiempo_vence_Tiempo_vence.DataPropertyName = "Tiempo_vence"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Tiempo_vence_Tiempo_vence.DefaultCellStyle = DataGridViewCellStyle6
        Me.Tiempo_vence_Tiempo_vence.HeaderText = "Vence"
        Me.Tiempo_vence_Tiempo_vence.Name = "Tiempo_vence_Tiempo_vence"
        Me.Tiempo_vence_Tiempo_vence.ReadOnly = True
        Me.Tiempo_vence_Tiempo_vence.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Tiempo_vence_Tiempo_vence.Width = 150
        '
        'Tiempo_sum_Tiempo_sum
        '
        Me.Tiempo_sum_Tiempo_sum.DataPropertyName = "Tiempo_sum"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Tiempo_sum_Tiempo_sum.DefaultCellStyle = DataGridViewCellStyle7
        Me.Tiempo_sum_Tiempo_sum.HeaderText = "T Sum"
        Me.Tiempo_sum_Tiempo_sum.Name = "Tiempo_sum_Tiempo_sum"
        Me.Tiempo_sum_Tiempo_sum.ReadOnly = True
        Me.Tiempo_sum_Tiempo_sum.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Tiempo_sum_Tiempo_sum.Visible = False
        '
        'ID_USUARIO
        '
        Me.ID_USUARIO.DataPropertyName = "Id"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ID_USUARIO.DefaultCellStyle = DataGridViewCellStyle8
        Me.ID_USUARIO.HeaderText = "Id"
        Me.ID_USUARIO.Name = "ID_USUARIO"
        Me.ID_USUARIO.ReadOnly = True
        Me.ID_USUARIO.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ID_USUARIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ID_USUARIO.Visible = False
        Me.ID_USUARIO.Width = 5
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 60000
        '
        'bt_listar_vencidos
        '
        Me.bt_listar_vencidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_listar_vencidos.Image = Global.WindowsApplication1.My.Resources.Resources.time_expired
        Me.bt_listar_vencidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_listar_vencidos.Location = New System.Drawing.Point(9, 368)
        Me.bt_listar_vencidos.Name = "bt_listar_vencidos"
        Me.bt_listar_vencidos.Size = New System.Drawing.Size(88, 30)
        Me.bt_listar_vencidos.TabIndex = 19
        Me.bt_listar_vencidos.Text = "Vencidos"
        Me.bt_listar_vencidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_listar_vencidos.UseVisualStyleBackColor = True
        Me.bt_listar_vencidos.Visible = False
        '
        'PerfilesHotspotToolStripMenuItem
        '
        Me.PerfilesHotspotToolStripMenuItem.Name = "PerfilesHotspotToolStripMenuItem"
        Me.PerfilesHotspotToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.PerfilesHotspotToolStripMenuItem.Text = "Perfiles Hotspot"
        '
        'Pruebaconexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(742, 460)
        Me.Controls.Add(Me.parrila_usuarios)
        Me.Controls.Add(Me.grupo_buscar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_hoy_es)
        Me.Controls.Add(Me.lbl_fecha_hoy)
        Me.Controls.Add(Me.bt_reset)
        Me.Controls.Add(Me.bt_crear_usuario)
        Me.Controls.Add(Me.grupo_usuario)
        Me.Controls.Add(Me.bt_Eliminar)
        Me.Controls.Add(Me.bt_select_all)
        Me.Controls.Add(Me.btb_pdf)
        Me.Controls.Add(Me.bt_shutdown)
        Me.Controls.Add(Me.bt_listar_vencidos)
        Me.Controls.Add(Me.bt_listar_usuarios)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.tb_result)
        Me.Controls.Add(Me.Group_lote)
        Me.Controls.Add(Me.Grupo_tiempo)
        Me.Controls.Add(Me.Grupo_perfil)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Pruebaconexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotspot Mikrotik Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.numero_tiempo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grupo_tiempo.ResumeLayout(False)
        Me.Grupo_tiempo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grupo_usuario.ResumeLayout(False)
        Me.grupo_usuario.PerformLayout()
        Me.Group_lote.ResumeLayout(False)
        Me.Group_lote.PerformLayout()
        CType(Me.numeric_cantidad_lote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo_buscar.ResumeLayout(False)
        Me.grupo_buscar.PerformLayout()
        Me.Grupo_perfil.ResumeLayout(False)
        Me.Grupo_perfil.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabla_de_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parrila_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_result As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigurarParametrosRBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bt_crear_usuario As System.Windows.Forms.Button
    Friend WithEvents txt_usuariocliente As System.Windows.Forms.TextBox
    Friend WithEvents lbl_usuario_cli As System.Windows.Forms.Label
    Friend WithEvents bt_listar_usuarios As System.Windows.Forms.Button
    Friend WithEvents bt_select_all As System.Windows.Forms.Button
    Friend WithEvents bt_Eliminar As System.Windows.Forms.Button
    Friend WithEvents list_hora_dia_mes As System.Windows.Forms.ListBox
    Friend WithEvents numero_tiempo As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grupo_tiempo As System.Windows.Forms.GroupBox
    Friend WithEvents grupo_usuario As System.Windows.Forms.GroupBox
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_fecha_hoy As System.Windows.Forms.Label
    Friend WithEvents lbl_hoy_es As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bt_shutdown As System.Windows.Forms.Button
    Friend WithEvents bt_generar_clave As System.Windows.Forms.Button
    Friend WithEvents DebugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bt_reset As System.Windows.Forms.Button
    Friend WithEvents check_buscar As System.Windows.Forms.CheckBox
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents check_lote As System.Windows.Forms.CheckBox
    Friend WithEvents Group_lote As System.Windows.Forms.GroupBox
    Friend WithEvents numeric_cantidad_lote As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grupo_buscar As System.Windows.Forms.GroupBox
    Friend WithEvents btb_pdf As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Grupo_perfil As System.Windows.Forms.GroupBox
    Friend WithEvents combox_perfil As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_velocidad As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents Tabla_de_usuarios As DataTable
    Friend WithEvents Id As DataColumn
    Friend WithEvents Usuario As DataColumn
    Friend WithEvents Tiempo_limite As DataColumn
    Friend WithEvents Tiempo_utilizado As DataColumn
    Friend WithEvents Tiempo_vence As DataColumn
    Friend WithEvents Tiempo_sum As DataColumn
    Friend WithEvents parrila_usuarios As DataGridView
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents Usuario_Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Tiempo_limite_Tiempo_limite As DataGridViewTextBoxColumn
    Friend WithEvents PERFIL_NAVEGACION As DataGridViewTextBoxColumn
    Friend WithEvents Tiempo_utilizado_Tiempo_utilizado As DataGridViewTextBoxColumn
    Friend WithEvents Tiempo_vence_Tiempo_vence As DataGridViewTextBoxColumn
    Friend WithEvents Tiempo_sum_Tiempo_sum As DataGridViewTextBoxColumn
    Friend WithEvents ID_USUARIO As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents bt_listar_vencidos As Button
    Friend WithEvents PerfilesHotspotToolStripMenuItem As ToolStripMenuItem
End Class
