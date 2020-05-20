Public Class Form6
    Dim sair As MsgBoxResult
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Este botão vai fechar este formulário e irá abrir o formulário do login
        LoginForm1.Show()
        Me.Hide()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Cria uma msgbox a perguntar se quer fechar a aplicação'
        sair = MsgBox("Tem certeza que quer fechar a aplicação?", MsgBoxStyle.YesNo)
        'Se disser que sim, então o programa irá fechar'
        If sair = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub ProgramadorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramadorToolStripMenuItem.Click
        'Este botão irá abrir uma página a falar sobre o programador
        AboutBox2.Show()
    End Sub
End Class