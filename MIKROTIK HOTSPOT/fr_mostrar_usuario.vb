Public Class fr_mostrar_usuario

    Private Sub fr_mostrar_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lb_usuario_mostrar.Text = Pruebaconexion.parrila_usuarios.CurrentRow.Cells(1).Value
        Me.lb_password_mostrar.Text = Pruebaconexion.parrila_usuarios.CurrentRow.Cells(1).Value
    End Sub

    Private Sub bt_cessar_usuarioshow_Click(sender As Object, e As EventArgs) Handles bt_cessar_usuarioshow.Click
        Me.Close()
    End Sub
End Class