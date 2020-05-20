Public Class Form4
    'Dim Escola As String = Desporto_escolarDataSet.Escola.NomeColumn
    Dim confirmar As MsgBoxResult
    'O try catch é usado para prevenir o erros durante a compilação
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Volta para o Menu
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            'Adiciona
            ResultadoBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Ação inválida")
        End Try
    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Try
            'Anterior
            ResultadoBindingSource.MovePrevious()
        Catch ex As Exception
            MsgBox("Ação inválida")
        End Try
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Try
            'Seguinte
            ResultadoBindingSource.MoveNext()
        Catch ex As Exception
            MsgBox("Ação inválida")
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Try
            'Guardar
            ResultadoBindingSource.EndEdit()
            ResultadoTableAdapter.Update(Desporto_escolarDataSet.Resultado)
            MsgBox("Guardado com sucesso", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Ação inválida")
        End Try
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Try
            'A variavel vai ser igual a messagebox de opção sim/não
            confirmar = MsgBox("Tem certeza que pretende eliminar esse registo?", MsgBoxStyle.YesNo)
            'Se a confirmação for igual a sim, então o registo será apagado
            If confirmar = MsgBoxResult.Yes Then
                ResultadoBindingSource.RemoveCurrent()
            End If
        Catch ex As Exception
            MsgBox("Ação inválida")
        End Try
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Try
            ResultadoBindingSource.CancelEdit()
        Catch ex As Exception
            MsgBox("Ação inválida")
        End Try
    End Sub

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Desporto_escolarDataSet.Escola' table. You can move, or remove it, as needed.
        Me.EscolaTableAdapter.Fill(Me.Desporto_escolarDataSet.Escola)
        Me.EscolaTableAdapter.Update(Me.Desporto_escolarDataSet.Escola)
        'TODO: This line of code loads data into the 'Desporto_escolarDataSet.Jogos' table. You can move, or remove it, as needed.
        Me.JogosTableAdapter.Fill(Me.Desporto_escolarDataSet.Jogos)
        Me.JogosTableAdapter.Update(Me.Desporto_escolarDataSet.Jogos)
        'TODO: This line of code loads data into the 'Desporto_escolarDataSet.Resultado' table. You can move, or remove it, as needed.
        Me.ResultadoTableAdapter.Fill(Me.Desporto_escolarDataSet.Resultado)
        Me.ResultadoTableAdapter.Update(Me.Desporto_escolarDataSet.Resultado)
    End Sub

    Private Sub VitóriasToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles VitóriasToolStripMenuItem1.Click
        Try
            Me.ResultadoBindingSource.Filter = ResultadoTableAdapter.FillByVitoria(Desporto_escolarDataSet.Resultado)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub EmpatesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmpatesToolStripMenuItem.Click
        Try
            Me.ResultadoBindingSource.Filter = ResultadoTableAdapter.FillByEmpate(Desporto_escolarDataSet.Resultado)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DerrotasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DerrotasToolStripMenuItem.Click
        Try
            Me.ResultadoBindingSource.Filter = ResultadoTableAdapter.FillByDerrota(Desporto_escolarDataSet.Resultado)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemoverOsFiltrosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoverOsFiltrosToolStripMenuItem.Click
        Try
            Me.ResultadoBindingSource.RemoveFilter()
            Me.ResultadoBindingSource.Filter = ResultadoTableAdapter.Fill(Desporto_escolarDataSet.Resultado)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ResultadosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ResultadosToolStripMenuItem.Click
        'Este botão ao ser clicado, vai para o site do desporto escolar
        Process.Start("http://quadrocompetitivo.desportoescolar.min-edu.pt/index.php?MP=5&d=Jogos%20e%20Resultados")
    End Sub

    Private Sub ClassificaçõesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClassificaçõesToolStripMenuItem.Click
        'Este botão ao ser clicado, vai para o site do desporto escolar
        Process.Start("http://quadrocompetitivo.desportoescolar.min-edu.pt/index.php?MP=6&d=Classifica%C3%A7%C3%B5es")
    End Sub

    Private Sub DerrotasToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles DerrotasToolStripMenuItem1.Click
        MsgBox(ResultadoTableAdapter.ScalarQueryderrota & " derrotas")
    End Sub

    Private Sub EmpatesToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles EmpatesToolStripMenuItem1.Click
        MsgBox(ResultadoTableAdapter.ScalarQueryempate & " empates")
    End Sub

    Private Sub VitoriasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VitoriasToolStripMenuItem.Click
        MsgBox(ResultadoTableAdapter.ScalarQueryvitoria & " vitórias")
    End Sub
End Class