Public Class LoginForm1
    Dim passwordantiga As String
    Dim passwordnova As String
    Dim passwordnovaconfirma As String
    Dim password As String = My.Settings.passwordbd
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Verifica se o nome do utilizador ou a password corresponde as variáveis'
        'Se corresponder, então vai para formulário do administrador'
        'Caso contrário, ele mostra uma msgbox a  dizer que a password está incorreta '
        If PasswordTextBox.Text = password Then
            MsgBox("Bem vindo ao Desporto Escolar Carga")
            Me.Hide()
            Form1.Show()
        Else
            MsgBox("A password está incorreta", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        'Fecha este formulário e volta para o formulário prinncipal
        Me.Close()
        Form6.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        'A textbox da password está a utilizar o sistema de carater da password

        If CheckBox1.Checked = True Then
            PasswordTextBox.UseSystemPasswordChar = False
        Else
            PasswordTextBox.UseSystemPasswordChar = True
        End If
        'Se a Checkbox estiver ativada então o sistema de carater da password será desativado e os carateres serão visiveis
        'Se a Checkbox estiver desativada então o sistema de carater da password será ativado e os carateres serão ocultados por sistema
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'O utilizador vai introduzir a password antiga
        'O programa verifica se a variavel passwordantiga é igual a password
        'Se for igual, o programa irá pedir uma nova password e a confirmação da nova password
        'Se a passwordnova for igual a passwordconfirma, então a password passa a ser atualizada
        passwordantiga = InputBox("Introduza a password antiga")
        If passwordantiga = password Then
            passwordnova = InputBox("Introduza a password nova")
            passwordnovaconfirma = InputBox("Confirme a password")
            If passwordnova = passwordnovaconfirma Then
                password = passwordnova
                My.Settings.passwordbd = password
                My.Settings.Save()
                MsgBox("A sua password foi alterada com sucesso")
            Else
                MsgBox("As duas passwords não correspondem", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("A password que introduziu está incorreta")
        End If
    End Sub
End Class
