<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class perfiles_navegacion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(perfiles_navegacion))
        Me.parrila_perfiles = New System.Windows.Forms.DataGridView()
        Me.id_user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.perfil_navegacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.velocidades = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bt_listar_perfiles = New System.Windows.Forms.Button()
        Me.tb_result = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.parrila_perfiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'parrila_perfiles
        '
        Me.parrila_perfiles.AllowUserToAddRows = False
        Me.parrila_perfiles.AllowUserToDeleteRows = False
        Me.parrila_perfiles.AllowUserToResizeColumns = False
        Me.parrila_perfiles.AllowUserToResizeRows = False
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.parrila_perfiles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.parrila_perfiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.parrila_perfiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.parrila_perfiles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.parrila_perfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.parrila_perfiles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_user, Me.perfil_navegacion, Me.velocidades})
        Me.parrila_perfiles.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.parrila_perfiles.DefaultCellStyle = DataGridViewCellStyle6
        Me.parrila_perfiles.Location = New System.Drawing.Point(119, 29)
        Me.parrila_perfiles.Margin = New System.Windows.Forms.Padding(1)
        Me.parrila_perfiles.Name = "parrila_perfiles"
        Me.parrila_perfiles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.parrila_perfiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.parrila_perfiles.RowHeadersVisible = False
        Me.parrila_perfiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.parrila_perfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.parrila_perfiles.Size = New System.Drawing.Size(245, 323)
        Me.parrila_perfiles.TabIndex = 21
        '
        'id_user
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_user.DefaultCellStyle = DataGridViewCellStyle3
        Me.id_user.HeaderText = "Id"
        Me.id_user.MinimumWidth = 50
        Me.id_user.Name = "id_user"
        Me.id_user.ReadOnly = True
        Me.id_user.Visible = False
        Me.id_user.Width = 50
        '
        'perfil_navegacion
        '
        Me.perfil_navegacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.perfil_navegacion.DefaultCellStyle = DataGridViewCellStyle4
        Me.perfil_navegacion.HeaderText = "Perfil"
        Me.perfil_navegacion.MaxInputLength = 8
        Me.perfil_navegacion.MinimumWidth = 50
        Me.perfil_navegacion.Name = "perfil_navegacion"
        Me.perfil_navegacion.ReadOnly = True
        Me.perfil_navegacion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.perfil_navegacion.Width = 61
        '
        'velocidades
        '
        Me.velocidades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.velocidades.DefaultCellStyle = DataGridViewCellStyle5
        Me.velocidades.HeaderText = "Velocidad Bajada / Subida"
        Me.velocidades.MinimumWidth = 130
        Me.velocidades.Name = "velocidades"
        Me.velocidades.ReadOnly = True
        Me.velocidades.Width = 184
        '
        'bt_listar_perfiles
        '
        Me.bt_listar_perfiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_listar_perfiles.Image = Global.WindowsApplication1.My.Resources.Resources.lista
        Me.bt_listar_perfiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_listar_perfiles.Location = New System.Drawing.Point(3, 29)
        Me.bt_listar_perfiles.Name = "bt_listar_perfiles"
        Me.bt_listar_perfiles.Size = New System.Drawing.Size(111, 30)
        Me.bt_listar_perfiles.TabIndex = 22
        Me.bt_listar_perfiles.Text = "Listar Perfiles"
        Me.bt_listar_perfiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_listar_perfiles.UseVisualStyleBackColor = True
        '
        'tb_result
        '
        Me.tb_result.Location = New System.Drawing.Point(12, 364)
        Me.tb_result.Multiline = True
        Me.tb_result.Name = "tb_result"
        Me.tb_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_result.Size = New System.Drawing.Size(353, 40)
        Me.tb_result.TabIndex = 23
        Me.tb_result.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.HerramientasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(371, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.shutdown_22x22
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
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
        'perfiles_navegacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 360)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.tb_result)
        Me.Controls.Add(Me.bt_listar_perfiles)
        Me.Controls.Add(Me.parrila_perfiles)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "perfiles_navegacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perfiles Navegacion"
        Me.TopMost = True
        CType(Me.parrila_perfiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents parrila_perfiles As System.Windows.Forms.DataGridView
    Friend WithEvents id_user As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents perfil_navegacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents velocidades As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bt_listar_perfiles As System.Windows.Forms.Button
    Friend WithEvents tb_result As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DebugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
