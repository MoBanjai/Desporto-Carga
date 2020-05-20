Public Class Form2
    Dim confirmar As MsgBoxResult
    'O try catch é usado para prevenir o erros durante a compilação
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Volta para o Menu
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Desporto_escolarDataSet.Escola' table. You can move, or remove it, as needed.
        Me.EscolaTableAdapter.Fill(Me.Desporto_escolarDataSet.Escola)
        Me.EscolaTableAdapter.Update(Me.Desporto_escolarDataSet.Escola)
        'TODO: This line of code loads data into the 'Desporto_escolarDataSet.Modalidade' table. You can move, or remove it, as needed.
        Me.ModalidadeTableAdapter.Fill(Me.Desporto_escolarDataSet.Modalidade)
        Me.ModalidadeTableAdapter.Update(Me.Desporto_escolarDataSet.Modalidade)
        'TODO: This line of code loads data into the 'Desporto_escolarDataSet.Jogos' table. You can move, or remove it, as needed.
        Me.JogosTableAdapter.Fill(Me.Desporto_escolarDataSet.Jogos)
        Me.JogosTableAdapter.Update(Me.Desporto_escolarDataSet.Jogos)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            'Adiciona
            JogosBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Ação inválida")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            'Anterior
            JogosBindingSource.MovePrevious()
        Catch ex As Exception
            MsgBox("Ação inválida")
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            'Seguinte
            JogosBindingSource.MoveNext()
        Catch ex As Exception
            MsgBox("Ação inválida")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            'Guardar
            JogosBindingSource.EndEdit()
            JogosTableAdapter.Update(Desporto_escolarDataSet.Jogos)
            MsgBox("Guardado com sucesso", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Ação inválida")
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            'A variavel vai ser igual a messagebox de opção sim/não
            confirmar = MsgBox("Tem certeza que pretende eliminar esse registo?", MsgBoxStyle.YesNo)
            'Se a confirmação for igual a sim, então o registo será apagado
            If confirmar = MsgBoxResult.Yes Then
                JogosBindingSource.RemoveCurrent()
            End If
        Catch ex As Exception
            MsgBox("Ação inválida")
        End Try
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Try
            JogosBindingSource.CancelEdit()
        Catch ex As Exception
            MsgBox("Ação inválida")
        End Try
    End Sub

    Private Sub JogosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles JogosToolStripMenuItem.Click
        'Este botão ao ser clicado, vai para o site do desporto escolar
        Process.Start("http://quadrocompetitivo.desportoescolar.min-edu.pt/index.php?MP=5&d=Jogos%20e%20Resultados")
    End Sub
End Class