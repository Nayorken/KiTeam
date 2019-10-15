Public Class Panel_conteudo
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Panel_menu.Width = 220 Then
            tm_ocultar_menu.Enabled = True
        ElseIf Panel_menu.Width = 60 Then
            tm_mostrar_menu.Enabled = True
        End If
    End Sub

    Private Sub Tm_ocultar_menu_Tick(sender As Object, e As EventArgs) Handles tm_ocultar_menu.Tick
        If Panel_menu.Width <= 60 Then
            Me.tm_ocultar_menu.Enabled = False
        Else
            Me.Panel_menu.Width = Panel_menu.Width - 20
        End If
    End Sub

    Private Sub Tm_mostrar_menu_Tick(sender As Object, e As EventArgs) Handles tm_mostrar_menu.Tick
        If Panel_menu.Width >= 220 Then
            Me.tm_mostrar_menu.Enabled = False
        Else
            Me.Panel_menu.Width = Panel_menu.Width + 20
        End If
    End Sub

    Private Sub Btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Me.Close()
    End Sub

    Private Sub Btn_maximizar_Click(sender As Object, e As EventArgs) Handles btn_maximizar.Click
        btn_maximizar.Visible = False
        btn_restaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btn_restaurar_Click(sender As Object, e As EventArgs) Handles btn_restaurar.Click
        btn_restaurar.Visible = False
        btn_maximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub
    Private Sub AbrirFormNoPanel(ByVal Formhijo As Object)
        If Me.Panel_cont.Controls.Count > 0 Then
            Me.Panel_cont.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.Panel_cont.Controls.Add(fh)
        Me.Panel_cont.Tag = fh
        fh.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFormNoPanel(New labirinto)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AbrirFormNoPanel(New ratito)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        AbrirFormNoPanel(New ratito)
    End Sub
End Class
