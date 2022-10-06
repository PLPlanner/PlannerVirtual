Public Class FormRelatorioCategoriasMaisRealizadas

    Dim dataInicio As Date
    Dim dataFim As Date

    Enum IntervaloTempo
        Semana
        Mes
        Ano
    End Enum

    Private Sub FormRelatorioCategoriasMaisRealizadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbIntervaloTempo.SelectedIndex = IntervaloTempo.Semana
        cbTipoRelatorio.SelectedIndex = 0
        cbIntervaloTempo.DropDownStyle = ComboBoxStyle.DropDownList
        cbTipoRelatorio.DropDownStyle = ComboBoxStyle.DropDownList
        inicializar()
        PreencherListView()
    End Sub

    Private Function CriarRelatorio(tipo As Integer) As Dictionary(Of String, Integer)
        Dim relatorio As RelatorioMaisRealizadas = New RelatorioMaisRealizadas(dataInicio, dataFim)
        Return relatorio.calcularCategoriasMaisRealizadas(tipo)
    End Function

    Private Sub PreencherListView()
        ListViewRelatorio.Items.Clear()
        Dim categoriasMaisRealizadas As Dictionary(Of String, Integer) = CriarRelatorio(cbTipoRelatorio.SelectedIndex)
        Try
            Dim i As Integer = 1
            For Each categoria As KeyValuePair(Of String, Integer) In categoriasMaisRealizadas
                Console.WriteLine(categoria)
                Dim item = New ListViewItem({i, categoria.Key, categoria.Value})
                i += 1
                item.ForeColor = CategoriaDAO.getSingletonObject().consultar(categoria.Key).cor
                ListViewRelatorio.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os dados: " & ex.Message)
        End Try

        Dim relatorioQuantidade() As Double = CriarRelatorioQuantidade(cbTipoRelatorio.SelectedIndex)
        lblQuantTotal.Text = "Total: " & relatorioQuantidade(0)
        lblQuantConcluidas.Text = "Concluidas: " & relatorioQuantidade(1)
        lblQuantPorcentagem.Text = "Porcentagem concluidas: " & FormatNumber(relatorioQuantidade.GetValue(2).ToString, 2) + "%"

    End Sub

    Private Function CriarRelatorioQuantidade(tipo As Integer) As Double()
        Dim relatorio As RelatorioQuantidade = New RelatorioQuantidade(dataInicio, dataFim)
        Select Case tipo
            Case 0
                Dim quantidadeTarefas As Double = CDbl(relatorio.getQuantidadeDeTarefas())
                Dim quantidadeTarefasExecutadas As Double = CDbl(relatorio.calcularQuantidadeTarefasExecutadas())
                Dim porcentagem As Double = CDbl(relatorio.calcularPorcentagemTarefasExecutadas * 100)
                Dim vetorQuantidade = New Double() {quantidadeTarefas, quantidadeTarefasExecutadas, porcentagem}
                Return vetorQuantidade
            Case 1
                Dim quantidadeMetas As Double = CDbl(relatorio.getQuantidadeDeMetas())
                Dim quantidadeMetasCumpridas As Double = CDbl(relatorio.calcularQuantidadeMetasCumpridas())
                Dim porcentagem As Double = CDbl(relatorio.calcularPorcentagemMetasCumpridas * 100)
                Dim vetorQuantidade = New Double() {quantidadeMetas, quantidadeMetasCumpridas, porcentagem}
                Return vetorQuantidade
        End Select

        Return Nothing
    End Function

    Private Sub inicializar()
        Select Case cbIntervaloTempo.SelectedIndex
            Case IntervaloTempo.Semana
                Dim diaDaSemana = CInt(DateTime.Today.DayOfWeek)
                dataInicio = DateTime.Today.AddDays(-1 * diaDaSemana)
                dataFim = DateTime.Today.AddDays(7 - diaDaSemana).AddSeconds(-1)
            Case IntervaloTempo.Mes
                dataInicio = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
                dataFim = dataInicio.AddMonths(1).AddSeconds(-1)
            Case IntervaloTempo.Ano
                dataInicio = New DateTime(DateTime.Today.Year, 1, 1)
                dataFim = dataInicio.AddYears(1).AddSeconds(-1)
        End Select

        ChangeLabelText()
    End Sub

    Private Sub btnVoltarSemana_Click(sender As Object, e As EventArgs) Handles btnVoltarSemana.Click
        AlterarIntervaloTempo(-1)
        PreencherListView()
        ChangeLabelText()
    End Sub

    Private Sub btnAvancarSemana_Click(sender As Object, e As EventArgs) Handles btnAvancarSemana.Click
        AlterarIntervaloTempo(1)
        PreencherListView()
        ChangeLabelText()
    End Sub

    Private Sub AlterarIntervaloTempo(multiplicador)
        Select Case cbIntervaloTempo.SelectedIndex
            Case IntervaloTempo.Semana
                dataInicio = dataInicio.AddDays(7 * multiplicador)
                dataFim = dataFim.AddDays(7 * multiplicador)
            Case IntervaloTempo.Mes
                dataInicio = dataInicio.AddMonths(multiplicador)
                dataFim = dataFim.AddMonths(multiplicador)
            Case IntervaloTempo.Ano
                dataInicio = dataInicio.AddYears(multiplicador)
                dataFim = dataFim.AddYears(multiplicador)
        End Select
    End Sub


    Private Sub btnIrSemanaAtual_Click(sender As Object, e As EventArgs) Handles btnIrSemanaAtual.Click
        inicializar()
        PreencherListView()
    End Sub

    Private Sub ChangeLabelText()
        Select Case cbIntervaloTempo.SelectedIndex
            Case IntervaloTempo.Semana
                lblSemana.Text = dataInicio.ToString("dd/MM/yyyy") & " - " & dataFim.ToString("dd/MM/yyyy")
            Case IntervaloTempo.Mes
                lblSemana.Text = dataInicio.ToString("MMMM/yyyy")
            Case IntervaloTempo.Ano
                lblSemana.Text = dataInicio.ToString("yyyy")
        End Select
        If cbTipoRelatorio.SelectedIndex = 0 Then
            lblTipo.Text = "Tarefas"
        Else
            lblTipo.Text = "Metas"
        End If
    End Sub

    Private Sub cbIntervaloTempo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIntervaloTempo.SelectedIndexChanged
        ChangeLabelText()
    End Sub

    Private Sub cbTipoRelatorio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoRelatorio.SelectedIndexChanged
        ChangeLabelText()
        PreencherListView()
    End Sub

    Private Sub lblSemana_Click(sender As Object, e As EventArgs) Handles lblSemana.Click

    End Sub


End Class