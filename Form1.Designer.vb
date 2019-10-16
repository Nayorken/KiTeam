<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Panel_conteudo
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.panel_cabecalho = New System.Windows.Forms.Panel()
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_maximizar = New System.Windows.Forms.PictureBox()
        Me.btn_fechar = New System.Windows.Forms.PictureBox()
        Me.btn_restaurar = New System.Windows.Forms.PictureBox()
        Me.Panel_menu = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tm_ocultar_menu = New System.Windows.Forms.Timer(Me.components)
        Me.tm_mostrar_menu = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_cont = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.panel_cabecalho.SuspendLayout()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_fechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_restaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_menu.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_cont.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_cabecalho
        '
        Me.panel_cabecalho.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.panel_cabecalho.Controls.Add(Me.btn_minimizar)
        Me.panel_cabecalho.Controls.Add(Me.btn_maximizar)
        Me.panel_cabecalho.Controls.Add(Me.btn_fechar)
        Me.panel_cabecalho.Controls.Add(Me.btn_restaurar)
        Me.panel_cabecalho.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_cabecalho.Location = New System.Drawing.Point(0, 0)
        Me.panel_cabecalho.Name = "panel_cabecalho"
        Me.panel_cabecalho.Size = New System.Drawing.Size(1084, 40)
        Me.panel_cabecalho.TabIndex = 0
        '
        'btn_minimizar
        '
        Me.btn_minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minimizar.Image = Global.KiTeam.My.Resources.Resources.Icono_Minimizar
        Me.btn_minimizar.Location = New System.Drawing.Point(952, 0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(40, 40)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_minimizar.TabIndex = 4
        Me.btn_minimizar.TabStop = False
        '
        'btn_maximizar
        '
        Me.btn_maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_maximizar.Image = Global.KiTeam.My.Resources.Resources.Icono_Maximizar
        Me.btn_maximizar.Location = New System.Drawing.Point(998, 0)
        Me.btn_maximizar.Name = "btn_maximizar"
        Me.btn_maximizar.Size = New System.Drawing.Size(40, 40)
        Me.btn_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_maximizar.TabIndex = 3
        Me.btn_maximizar.TabStop = False
        '
        'btn_fechar
        '
        Me.btn_fechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_fechar.Image = Global.KiTeam.My.Resources.Resources.Icono_cerrar_FN
        Me.btn_fechar.Location = New System.Drawing.Point(1044, 0)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(40, 40)
        Me.btn_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_fechar.TabIndex = 2
        Me.btn_fechar.TabStop = False
        '
        'btn_restaurar
        '
        Me.btn_restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_restaurar.Image = Global.KiTeam.My.Resources.Resources.Icono_Restaurar
        Me.btn_restaurar.Location = New System.Drawing.Point(998, 0)
        Me.btn_restaurar.Name = "btn_restaurar"
        Me.btn_restaurar.Size = New System.Drawing.Size(40, 40)
        Me.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_restaurar.TabIndex = 5
        Me.btn_restaurar.TabStop = False
        '
        'Panel_menu
        '
        Me.Panel_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel_menu.Controls.Add(Me.PictureBox4)
        Me.Panel_menu.Controls.Add(Me.Button5)
        Me.Panel_menu.Controls.Add(Me.Panel6)
        Me.Panel_menu.Controls.Add(Me.Button1)
        Me.Panel_menu.Controls.Add(Me.Panel1)
        Me.Panel_menu.Controls.Add(Me.PictureBox3)
        Me.Panel_menu.Controls.Add(Me.PictureBox2)
        Me.Panel_menu.Controls.Add(Me.PictureBox1)
        Me.Panel_menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_menu.Location = New System.Drawing.Point(0, 40)
        Me.Panel_menu.Name = "Panel_menu"
        Me.Panel_menu.Size = New System.Drawing.Size(220, 501)
        Me.Panel_menu.TabIndex = 0
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.KiTeam.My.Resources.Resources.Imagem11
        Me.PictureBox4.Location = New System.Drawing.Point(7, 279)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(3, 267)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(217, 65)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Ratito"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(0, 273)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(4, 65)
        Me.Panel6.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.KiTeam.My.Resources.Resources.download1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 167)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 65)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "     Labirinto "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(4, 65)
        Me.Panel1.TabIndex = 9
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.KiTeam.My.Resources.Resources.download1
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(3, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(217, 65)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "     Labirinto "
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(4, 65)
        Me.Panel4.TabIndex = 15
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(0, 21)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(4, 65)
        Me.Panel5.TabIndex = 16
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.KiTeam.My.Resources.Resources.download1
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(3, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(217, 65)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "     Labirinto "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(4, 65)
        Me.Panel3.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.KiTeam.My.Resources.Resources.download1
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(-105, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(217, 65)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "     Labirinto "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(-108, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(4, 65)
        Me.Panel2.TabIndex = 11
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.KiTeam.My.Resources.Resources._9a3cdef0_1631_4be5_90c1_46c56f0b4e5e_200x200
        Me.PictureBox3.Location = New System.Drawing.Point(86, 58)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(127, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.KiTeam.My.Resources.Resources._901265e3_f15c_46de_84bb_1f285ca02ab3_200x200
        Me.PictureBox2.Location = New System.Drawing.Point(-4, 58)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(66, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.KiTeam.My.Resources.Resources.Mobile_Menu_Icon
        Me.PictureBox1.Location = New System.Drawing.Point(164, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'tm_ocultar_menu
        '
        '
        'tm_mostrar_menu
        '
        '
        'Panel_cont
        '
        Me.Panel_cont.Controls.Add(Me.Panel7)
        Me.Panel_cont.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_cont.Location = New System.Drawing.Point(220, 40)
        Me.Panel_cont.Name = "Panel_cont"
        Me.Panel_cont.Size = New System.Drawing.Size(864, 501)
        Me.Panel_cont.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.SplitContainer1)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Controls.Add(Me.PictureBox5)
        Me.Panel7.Location = New System.Drawing.Point(6, 6)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(855, 492)
        Me.Panel7.TabIndex = 16
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.PictureBox7)
        Me.Panel8.Controls.Add(Me.PictureBox6)
        Me.Panel8.Location = New System.Drawing.Point(21, 161)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(791, 282)
        Me.Panel8.TabIndex = 2
        '
        'PictureBox6
        '
        Me.PictureBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox6.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(791, 282)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 0
        Me.PictureBox6.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(228, 446)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(398, 45)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Este projeto foi desenvolvido no âmbito da disciplina de Programação E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sistemas " &
    "De Informação, desenvolvido pelo aluno Hugo Ferreira." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(21, 161)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Enabled = False
        Me.SplitContainer1.Size = New System.Drawing.Size(791, 282)
        Me.SplitContainer1.SplitterDistance = 240
        Me.SplitContainer1.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(81, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(663, 72)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Kiteam é uma simples plataforma de jogos offline na qual podemos encontrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "os ma" &
    "is diversos jogos, assim como o jogo do ""labirinto"", o jogo do ""ratito"" etc." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    ""
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.KiTeam.My.Resources.Resources.b3367994_f1dc_4075_b0e4_a31d95a4e038_200x200
        Me.PictureBox5.Location = New System.Drawing.Point(312, -56)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(201, 158)
        Me.PictureBox5.TabIndex = 16
        Me.PictureBox5.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.KiTeam.My.Resources.Resources.image1
        Me.PictureBox7.Location = New System.Drawing.Point(64, -3)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(659, 271)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 14
        Me.PictureBox7.TabStop = False
        '
        'Panel_conteudo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 541)
        Me.Controls.Add(Me.Panel_cont)
        Me.Controls.Add(Me.Panel_menu)
        Me.Controls.Add(Me.panel_cabecalho)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Panel_conteudo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panel_cabecalho.ResumeLayout(False)
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_fechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_restaurar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_menu.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_cont.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_cabecalho As Panel
    Friend WithEvents Panel_menu As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tm_ocultar_menu As Timer
    Friend WithEvents tm_mostrar_menu As Timer
    Friend WithEvents btn_fechar As PictureBox
    Friend WithEvents btn_minimizar As PictureBox
    Friend WithEvents btn_maximizar As PictureBox
    Friend WithEvents btn_restaurar As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel_cont As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
End Class
