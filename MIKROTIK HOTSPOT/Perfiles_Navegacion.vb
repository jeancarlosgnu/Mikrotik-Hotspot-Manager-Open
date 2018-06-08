Public Class perfiles_navegacion

    Private Sub bt_listar_usuarios_Click(sender As Object, e As EventArgs) Handles bt_listar_perfiles.Click
        cargar_perfiles_en_configuracion()

    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub perfiles_navegacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargar_perfiles_en_configuracion()

    End Sub
End Class