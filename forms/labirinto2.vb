Public Class labirinto2

    Private estajogar As Boolean

    Private Sub labirinto2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each c As Control In Me.Controls
            If TypeOf c Is PictureBox Then
                AddHandler c.MouseEnter, AddressOf PictureBox_MouseEnter
            End If
        Next
    End Sub

    Private Sub PictureBox_MouseEnter(sender As Object, e As EventArgs)
        If estajogar = False Then Return

        estajogar = False
        Timer1.Stop()
        TextBox1.Text = "0"
        Beep()
        MessageBox.Show("Perdeu O Jogo", "Fim Do Jogo")
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        If estajogar = False Then Return
        estajogar = False
        Timer1.Stop()
        MessageBox.Show("Parabéns Ganhou O Jogo", "Fim Do Jogo")
        TextBox1.Text = "0"
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        estajogar = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = TextBox1.Text + 1
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Timer1.Start()
    End Sub
End Class