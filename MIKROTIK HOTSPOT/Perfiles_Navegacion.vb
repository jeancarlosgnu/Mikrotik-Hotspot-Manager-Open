Public Class perfiles_navegacion

    Private Sub bt_listar_usuarios_Click(sender As Object, e As EventArgs) Handles bt_listar_perfiles.Click

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.Height = 444
        Me.tb_result.Location = New Point(x:=4, y:=364)
        Me.tb_result.Visible = True

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.tb_result.Location = New Point(x:=4, y:=200)
        Me.tb_result.Visible = False
        Me.Height = 400
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class