Public Class Form3
    Dim confirmar As MsgBoxResult
    'O try catch é usado para prevenir o erros durante a compilação
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Volta para o menu
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Desporto_escolarDataSet.Modalidade' table. You can move, or remove it, as needed.
        Me.ModalidadeTableAdapter.Fill(Me.Desporto_escolarDataSet.Modalidade)
        Me.ModalidadeTableAdapter.Update(Me.Desporto_escolarDataSet.Modalidade)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            'Adiciona
            ModalidadeBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Ação inválida")
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            'Anterior
            ModalidadeBindingSource.MovePrevious()
        Catch ex As Exception
            MsgBox("Ação inválida")
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            'Seguinte
            ModalidadeBindingSource.MoveNext()
        Catch ex As Exception
            MsgBox("Ação inválida")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            'Guardar
            ModalidadeBindingSource.EndEdit()
            ModalidadeTableAdapter.Update(Desporto_escolarDataSet.Modalidade)
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
                ModalidadeBindingSource.RemoveCurrent()
            End If
        Catch ex As Exception
            MsgBox("Ação inválida")
        End Try

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Try
            ModalidadeBindingSource.CancelEdit()
        Catch ex As Exception
            MsgBox("Ação inválida")
        End Try
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        'Vai filtrar consoante o valor dentro da textbox
        ModalidadeBindingSource.Filter = "Tipo Like '%" & TextBox5.Text & "%'"
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        'Vai filtrar consoante o valor dentro da textbox
        ModalidadeBindingSource.Filter = "Modalidade Like'%" & TextBox4.Text & "%'"
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        'Remove os filtros e limpa todos os campos de filtros
        ModalidadeBindingSource.RemoveFilter()
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
End Class