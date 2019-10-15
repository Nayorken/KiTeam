Public Class ratito

    Dim score As Integer = 0
    Dim Ren As New Random

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Top -= 5
        PictureBox2.Top -= 5
        PictureBox3.Top -= 5
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PictureBox1.Location.Y < -86 Or PictureBox2.Location.Y < -86 Or PictureBox3.Location.Y < -86 Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            Beep()
            MessageBox.Show("Game over", "Fim Do Jogo")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, PictureBox2.Click, PictureBox3.Click
        score += 1
        Label2.Text = score
        Dim X As Integer = Ren.Next(30, 400)
        sender.location = New Point(X, 400)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Devagar" Then
            Timer1.Interval = 200
        ElseIf ComboBox1.Text = "Normal" Then
            Timer1.Interval = 100
        ElseIf ComboBox1.Text = "Rápido" Then
            Timer1.Interval = 50
        ElseIf ComboBox1.Text = "Ultra" Then
            Timer1.Interval = 20
        ElseIf ComboBox1.Text = "Impossível" Then
            Timer1.Interval = 10
        End If

        PictureBox1.Location = New Point(85, 74)
        PictureBox2.Location = New Point(260, 185)
        PictureBox3.Location = New Point(443, 297)



        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    'btn parar'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        Timer2.Enabled = False
    End Sub

    'btn começar'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub
End Class