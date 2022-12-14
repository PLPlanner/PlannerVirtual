Public Class FormAdicionarLembrete
    Public tipoLembrete As TipoLembrete
    Private _lembreteDAO As ILembreteDAO

    Public lembrete As Lembrete

    Private Sub FormAdicionarLembrete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        initState()
    End Sub

    Private Sub initState()
        _lembreteDAO = LembreteDAO.getSingletonObject
        'Muda se for para editar o lembrete
        If lembrete IsNot Nothing Then
            txtDescricao.Text = lembrete.descricao
            DatePicker.Value = lembrete.data

            btnAdicionarLembrete.Text = "Atualizar"
            lblTitulo.Text = "Editar - "
        End If

        'Seta o tipo de lembrete
        If (tipoLembrete = TipoLembrete.ligacoesImportantes) Then
            lblTitulo.Text += "Ligação Importante"
        ElseIf (tipoLembrete = TipoLembrete.reunioes) Then
            lblTitulo.Text += "Reunião"
        ElseIf (tipoLembrete = TipoLembrete.compras) Then
            lblTitulo.Text += "Compras"
        End If

    End Sub

    Private Sub btnAdicionarLembrete_Click(sender As Object, e As EventArgs) Handles btnAdicionarLembrete.Click
        Dim descricao As String = txtDescricao.Text
        Dim data As Date = DatePicker.Value

        If descricao <> "" Then
            If lembrete Is Nothing Then
                Dim novoLembrete As New Lembrete(descricao, data, tipoLembrete)
                Try
                    _lembreteDAO.inserir(novoLembrete)
                    txtDescricao.ResetText()
                    Me.Close()
                Catch ex As LembreteExistenteException
                    MsgBox("Lembrete já existente")
                Catch ex As Exception
                    MsgBox("Erro ao adicionar lembrete: " & ex.ToString)
                End Try
            Else
                Try
                    lembrete.descricao = descricao
                    lembrete.data = data
                    _lembreteDAO.atualizar(lembrete)
                    txtDescricao.ResetText()
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Erro ao adicionar lembrete: " & ex.ToString)
                End Try

            End If

        Else
            MsgBox("Digite uma descrição para o lembrete para poder salvar!")
        End If
    End Sub

    Private Sub txtDescricao_TextChanged(sender As Object, e As EventArgs) Handles txtDescricao.TextChanged

    End Sub
End Class