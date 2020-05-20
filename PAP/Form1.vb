Public Class Form1
    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'Abre a página para inserir os jogos'
        Me.Hide()
        Form2.Show()
    End Sub
    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'Abre a página para inserir as modalidades'
        Me.Hide()
        Form3.Show()
    End Sub
    Private Sub Button4_Click_1(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        'Abre a página para inserir as escolas'
        Me.Hide()
        Form5.Show()
    End Sub
    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'Abre a página para inserir os resultados'
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Este botão fecha o menu e o manual(se este estiver aberto) e volta para o iniciar
        Me.Hide()
        Form6.Show()
        Form7.Hide()
        LoginForm1.PasswordTextBox.Text = ""
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Quando o Form1 abre, o timer 1 começa
        Timer1.Start()
        'A label1 vai ser igual á data correspondente no momento
        Label1.Text = Today
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'A label2 vai ser igual á hora do momento (hora:minuto:segundo)
        Label2.Text = TimeString
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        'Este botão irá abrir o manual do programa
        Form7.Show()
    End Sub
End Class