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
        Beep()
        MessageBox.Show("Perdeu O Jogo", "Fim Do Jogo")
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        If estajogar = False Then Return
        estajogar = False
        MessageBox.Show("Parabéns Ganhou O Jogo", "Fim Do Jogo")
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        estajogar = True
    End Sub
End Class