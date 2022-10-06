Imports System.Windows.Forms.DataVisualization.Charting
Imports PlannerVirtual.FormRelatorioProdutividade

Public Class FormRelatorioProdutividade

    Dim dataInicio As Date
    Dim dataFim As Date

    Enum IntervaloTempo
        Semana
        Mes
        Ano
    End Enum

    Enum TipoRelatorio
        Turno
        Semana
        Mes
    End Enum

    Private Sub FormRelatorioProdutividade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar()
        cbIntervaloTempo.SelectedIndex = IntervaloTempo.Ano
        cbIntervaloTempo.DropDownStyle = ComboBoxStyle.DropDownList
        PopularGraficoTurnos()
        PopularGraficoSemanas()
        ChangeLabelText()
    End Sub

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

    Private Function CriarRelatorioTurno(intervalo As Integer) As Dictionary(Of String, Integer)
        Dim relatorio As RelatorioProdutividade = New RelatorioProdutividade(dataInicio, dataFim)
        Select Case intervalo
            Case IntervaloTempo.Semana
                Return relatorio.calcularTurnosMaisProdutivos(intervalo)
            Case IntervaloTempo.Mes
                Return relatorio.calcularTurnosMaisProdutivos(intervalo)
        End Select
        Return relatorio.calcularTurnosMaisProdutivos(intervalo)
    End Function

    Private Function CriarRelatorioSemana(intervalo As Integer) As Dictionary(Of String, Integer)
        Dim relatorio As RelatorioProdutividade = New RelatorioProdutividade(dataInicio, dataFim)
        Select Case intervalo
            Case IntervaloTempo.Semana
                ChartSemanas.Series(0).IsVisibleInLegend = False
            Case IntervaloTempo.Mes
                ChartSemanas.Series(0).IsVisibleInLegend = True
                ChartSemanas.Series(0).LegendText = "Semana"
                Return relatorio.calcularSemanasMaisProdutivas(intervalo)
            Case IntervaloTempo.Ano
                ChartSemanas.Series(0).IsVisibleInLegend = True
                ChartSemanas.Series(0).LegendText = "Meses"
                Return relatorio.calcularSemanasMaisProdutivas(intervalo)
        End Select
        Return relatorio.calcularSemanasMaisProdutivas(intervalo)
    End Function

    Private Sub PopularGraficoTurnos()
        Dim turnosMaisProdutivos As Dictionary(Of String, Integer) = CriarRelatorioTurno(cbIntervaloTempo.SelectedIndex)
        ChartTurnos.Series("Turnos").Points.Clear()
        If (turnosMaisProdutivos IsNot Nothing) Then
            Dim i As Integer = 0
            For Each turno As KeyValuePair(Of String, Integer) In turnosMaisProdutivos
                ChartTurnos.Series("Turnos").Points.AddXY(turno.Key & "\n(" & turno.Value.ToString & ")", turno.Value)
                ChartTurnos.Series("Turnos").Points(i).LegendText = turno.Key
                ChartTurnos.Series("Turnos").Points(i).LabelForeColor = Color.FromArgb(255, 255, 255)
                i += 1
            Next
        End If
    End Sub

    Private Sub PopularGraficoSemanas()
        Dim semanasMaisProdutivas As Dictionary(Of String, Integer) = CriarRelatorioSemana(cbIntervaloTempo.SelectedIndex)
        ChartSemanas.Series("Semanas").Points.Clear()
        If (cbIntervaloTempo.SelectedIndex <> IntervaloTempo.Semana) Then
            Dim i As Integer = 0
            For Each semana As KeyValuePair(Of String, Integer) In semanasMaisProdutivas
                ChartSemanas.Series("Semanas").Points.AddXY(semana.Key, semana.Value)
                ChartSemanas.Series("Semanas").Points(i).LegendText = semana.Key
                ChartSemanas.Series("Semanas").Points(i).LabelForeColor = Color.FromArgb(255, 255, 255)
                i += 1
            Next
        End If

    End Sub

    Private Sub btnVoltarSemana_Click(sender As Object, e As EventArgs) Handles btnVoltarSemana.Click
        AlterarIntervaloTempo(-1)
        PopularGraficoSemanas()
        PopularGraficoTurnos()
        ChangeLabelText()
    End Sub

    Private Sub btnAvancarSemana_Click(sender As Object, e As EventArgs) Handles btnAvancarSemana.Click
        AlterarIntervaloTempo(1)
        PopularGraficoSemanas()
        PopularGraficoTurnos()
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
        PopularGraficoSemanas()
        PopularGraficoTurnos()
        ChangeLabelText()
    End Sub

    Private Sub ChangeLabelText()
        Select Case cbIntervaloTempo.SelectedIndex
            Case IntervaloTempo.Semana
                lblSemana.Text = dataInicio.ToString("dd/MM/yyyy") & " - " & dataFim.ToString("dd/MM/yyyy")
                lblSemanaMesProdutivo.Text = ""
            Case IntervaloTempo.Mes
                lblSemana.Text = dataInicio.ToString("MMMM/yyyy")
                lblSemanaMesProdutivo.Text = "Semanas mais produtivas:"
            Case IntervaloTempo.Ano
                lblSemana.Text = dataInicio.ToString("yyyy")
                lblSemanaMesProdutivo.Text = "Meses mais produtivas:"
        End Select


    End Sub

    Private Sub cbIntervaloTempo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIntervaloTempo.SelectedIndexChanged
        inicializar()
        PopularGraficoSemanas()
        PopularGraficoTurnos()
        ChangeLabelText()
    End Sub


End Class