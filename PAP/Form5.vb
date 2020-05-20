Public Class Form5
    Dim confirmar As MsgBoxResult
    'O try catch é usado para prevenir o erros durante a compilação
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Volta para o Menu
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Desporto_escolarDataSet.Escola' table. You can move, or remove it, as needed.
        Me.EscolaTableAdapter.Fill(Me.Desporto_escolarDataSet.Escola)
        Me.EscolaTableAdapter.Update(Me.Desporto_escolarDataSet.Escola)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            'Adiciona
            EscolaBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Ação inválida")
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            'Anterior
            EscolaBindingSource.MovePrevious()
        Catch ex As Exception
            MsgBox("Ação inválida")
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            'Seguinte
            EscolaBindingSource.MoveNext()
        Catch ex As Exception
            MsgBox("Ação inválida")
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            'Guardar
            EscolaBindingSource.EndEdit()
            EscolaTableAdapter.Update(Desporto_escolarDataSet.Escola)
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
                EscolaBindingSource.RemoveCurrent()
            End If
        Catch ex As Exception
            MsgBox("Ação inválida")
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            EscolaBindingSource.CancelEdit()
        Catch ex As Exception
            MsgBox("Ação inválida")
        End Try
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        EscolaBindingSource.Filter = "Nome Like '%" & TextBox4.Text & "%'"
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        'Remove os filtros e limpa todos os campos de filtros
        EscolaBindingSource.RemoveFilter()
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        EscolaBindingSource.Filter = "Localidade Like '%" & TextBox5.Text & "%'"
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs)
        EscolaBindingSource.Filter = "Nome Like '%" & TextBox4.Text & "%'"
        EscolaBindingSource.Filter = "Localidade Like '%" & TextBox5.Text & "%'"
    End Sub
End Class