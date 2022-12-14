Imports System.Data.SQLite

Public Class FormMeta
    Private _metaDAO As IMetaDAO
    Public metaSelecionada As Meta
    'Semana
    Dim dataInicioSemana As Date
    Dim dataFimSemana As Date

    'Mes
    Dim dataInicioMes As Date
    Dim dataFimMes As Date

    'Ano
    Dim dataInicioAno As Date
    Dim dataFimAno As Date

    Private Sub FormMeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarSemana()
        inicializarMes()
        inicializarAno()
        _metaDAO = MetaDAO.getSingletonObject
        carregarTodasMetas()
        'inicializa filtros
        cbFiltroEstadoSemanal.SelectedIndex = 0
        cbFiltroEstadoMensal.SelectedIndex = 0
        cbFiltroEstadoAnual.SelectedIndex = 0
    End Sub

    Private Sub carregarTodasMetas()
        carregarMetasSemanais()
        carregarMetasMensais()
        carregarMetasAnuais()
    End Sub

    Private Sub inicializarSemana()
        Dim diaDaSemana = CInt(DateTime.Today.DayOfWeek)
        dataInicioSemana = DateTime.Today.AddDays(-1 * diaDaSemana)
        dataFimSemana = DateTime.Today.AddDays(7 - diaDaSemana).AddSeconds(-1)

        lblSemana.Text = dataInicioSemana.ToString("dd/MM/yyyy") & " - " & dataFimSemana.ToString("dd/MM/yyyy")
    End Sub

    Private Sub inicializarMes()
        dataInicioMes = New Date(DateTime.Today.Year, DateTime.Today.Month, 1)
        dataFimMes = dataInicioMes.AddMonths(1).AddSeconds(-1)

        lblMes.Text = dataInicioMes.ToString("MMMM/yyyy")
    End Sub

    Private Sub inicializarAno()
        dataInicioAno = New Date(DateTime.Today.Year, 1, 1)
        dataFimAno = dataInicioAno.AddYears(1).AddSeconds(-1)

        lblAno.Text = dataInicioAno.ToString("yyyy")
    End Sub


    Private Sub carregarMetasSemanais()
        'limpar listview
        listViewSemanais.Items.Clear()
        'Busca os dados
        Dim lista As List(Of Meta) = _metaDAO.listarPorTipo(TipoMeta.semanal).FindAll(Function(x) x.data >= dataInicioSemana And x.data <= dataFimSemana)

        'filtra a lista
        Select Case cbFiltroEstadoSemanal.SelectedIndex
            Case 0
                'todos
            Case 1
                'cumprida
                lista = lista.FindAll(Function(x) x.estado = EstadoMeta.cumprida)
            Case 2
                'não cumprida
                lista = lista.FindAll(Function(x) x.estado = EstadoMeta.naoCumprida)
            Case 3
                'parcialmente cumprida
                lista = lista.FindAll(Function(x) x.estado = EstadoMeta.parcialmenteCumprida)
        End Select

        'Preencher o listview
        Try
            For Each meta As Meta In lista
                Console.WriteLine(meta)
                Dim item = New ListViewItem({meta.id, meta.descricao, meta.categoria.nome, meta.estado.ToString, meta.data})
                item.ForeColor = meta.categoria.cor
                listViewSemanais.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os dados: " & ex.Message)
        End Try
    End Sub

    Private Sub carregarMetasMensais()
        'limpar listview
        ListViewMensais.Items.Clear()
        'Busca os dados
        Dim lista As List(Of Meta) = _metaDAO.listarPorTipo(TipoMeta.mensal).FindAll(Function(x) x.data >= dataInicioMes And x.data <= dataFimMes)

        'filtra a lista
        Select Case cbFiltroEstadoMensal.SelectedIndex
            Case 0
                'todos
            Case 1
                'cumprida
                lista = lista.FindAll(Function(x) x.estado = EstadoMeta.cumprida)
            Case 2
                'não cumprida
                lista = lista.FindAll(Function(x) x.estado = EstadoMeta.naoCumprida)
            Case 3
                'parcialmente cumprida
                lista = lista.FindAll(Function(x) x.estado = EstadoMeta.parcialmenteCumprida)
        End Select

        'Preencher o listview
        Try
            For Each meta As Meta In lista
                Console.WriteLine(meta)
                Dim item = New ListViewItem({meta.id, meta.descricao, meta.categoria.nome, meta.estado.ToString, meta.data})
                item.ForeColor = meta.categoria.cor
                ListViewMensais.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os dados: " & ex.Message)
        End Try
    End Sub

    Private Sub carregarMetasAnuais()
        'limpar listview
        ListViewAnuais.Items.Clear()
        'Busca os dados
        Dim lista As List(Of Meta) = _metaDAO.listarPorTipo(TipoMeta.anual).FindAll(Function(x) x.data >= dataInicioAno And x.data <= dataFimAno)

        'filtra a lista
        Select Case cbFiltroEstadoAnual.SelectedIndex
            Case 0
                'todos
            Case 1
                'cumprida
                lista = lista.FindAll(Function(x) x.estado = EstadoMeta.cumprida)
            Case 2
                'não cumprida
                lista = lista.FindAll(Function(x) x.estado = EstadoMeta.naoCumprida)
            Case 3
                'parcialmente cumprida
                lista = lista.FindAll(Function(x) x.estado = EstadoMeta.parcialmenteCumprida)
        End Select

        'Preencher o listview
        Try
            For Each meta As Meta In lista
                Console.WriteLine(meta)
                Dim item = New ListViewItem({meta.id, meta.descricao, meta.categoria.nome, meta.estado.ToString, meta.data})
                item.ForeColor = meta.categoria.cor
                ListViewAnuais.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os dados: " & ex.Message)
        End Try
    End Sub


    Private Sub btnSemanaAtual_Click(sender As Object, e As EventArgs) Handles btnSemanaAtual.Click
        inicializarSemana()
        carregarMetasSemanais()
    End Sub

    Private Sub btnVoltarSemana_Click(sender As Object, e As EventArgs) Handles btnVoltarSemana.Click
        dataInicioSemana = dataInicioSemana.AddDays(-7)
        dataFimSemana = dataFimSemana.AddDays(-7)
        lblSemana.Text = dataInicioSemana.ToString("dd/MM/yyyy") & " - " & dataFimSemana.ToString("dd/MM/yyyy")
        carregarMetasSemanais()
    End Sub

    Private Sub btnAvancarSemana_Click(sender As Object, e As EventArgs) Handles btnAvancarSemana.Click
        dataInicioSemana = dataInicioSemana.AddDays(7)
        dataFimSemana = dataFimSemana.AddDays(7)
        lblSemana.Text = dataInicioSemana.ToString("dd/MM/yyyy") & " - " & dataFimSemana.ToString("dd/MM/yyyy")
        carregarMetasSemanais()
    End Sub

    Private Sub btnMesAtual_Click(sender As Object, e As EventArgs) Handles btnMesAtual.Click
        inicializarMes()
        carregarMetasMensais()
    End Sub

    Private Sub btnVoltarMes_Click(sender As Object, e As EventArgs) Handles btnVoltarMes.Click
        dataInicioMes = dataInicioMes.AddMonths(-1)
        dataFimMes = dataFimMes.AddMonths(-1)
        lblMes.Text = dataInicioMes.ToString("MMMM/yyyy")
        carregarMetasMensais()
    End Sub

    Private Sub btnAvancarMes_Click(sender As Object, e As EventArgs) Handles btnAvancarMes.Click
        dataInicioMes = dataInicioMes.AddMonths(1)
        dataFimMes = dataFimMes.AddMonths(1)
        lblMes.Text = dataInicioMes.ToString("MMMM/yyyy")
        carregarMetasMensais()
    End Sub

    Private Sub btnAnoAtual_Click(sender As Object, e As EventArgs) Handles btnAnoAtual.Click
        inicializarAno()
        carregarMetasAnuais()
    End Sub

    Private Sub btnVoltarAno_Click(sender As Object, e As EventArgs) Handles btnVoltarAno.Click
        dataInicioAno = dataInicioAno.AddYears(-1)
        dataFimAno = dataFimAno.AddYears(-1)
        lblAno.Text = dataInicioAno.ToString("yyyy")
        carregarMetasAnuais()
    End Sub

    Private Sub btnAvancarAno_Click(sender As Object, e As EventArgs) Handles btnAvancarAno.Click
        dataInicioAno = dataInicioAno.AddYears(1)
        dataFimAno = dataFimAno.AddYears(1)
        lblAno.Text = dataInicioAno.ToString("yyyy")
        carregarMetasAnuais()
    End Sub

    Private Sub btnAdicionarMetaSemanal_Click(sender As Object, e As EventArgs) Handles btnAdicionarMetaSemanal.Click
        Dim form As New FormAdicionarMeta
        form.tipo = TipoMeta.semanal
        form.ShowDialog()
        carregarMetasSemanais()
    End Sub

    Private Sub btnAdicionarMetaMensal_Click(sender As Object, e As EventArgs) Handles btnAdicionarMetaMensal.Click
        Dim form As New FormAdicionarMeta
        form.tipo = TipoMeta.mensal
        form.ShowDialog()
        carregarMetasMensais()
    End Sub

    Private Sub btnAdicionarMetaAnual_Click(sender As Object, e As EventArgs) Handles btnAdicionarMetaAnual.Click
        Dim form As New FormAdicionarMeta
        form.tipo = TipoMeta.anual
        form.ShowDialog()
        carregarMetasAnuais()
    End Sub

    Private Sub btnEditarSemanal_Click(sender As Object, e As EventArgs) Handles btnEditarSemanal.Click
        Dim result = editarMeta(listViewSemanais, TipoMeta.semanal)
        If result Then carregarMetasSemanais()
    End Sub

    Private Sub btnEditarMensal_Click(sender As Object, e As EventArgs) Handles btnEditarMensal.Click
        Dim result = editarMeta(ListViewMensais, TipoMeta.mensal)
        If result Then carregarMetasMensais()
    End Sub

    Private Sub btnEditarAnual_Click(sender As Object, e As EventArgs) Handles btnEditarAnual.Click
        Dim result = editarMeta(ListViewAnuais, TipoMeta.anual)
        If result Then carregarMetasAnuais()
    End Sub

    Private Function editarMeta(listview As ListView, tipo As TipoMeta) As Boolean
        If listview.SelectedItems.Count > 0 Then
            Dim id As Integer = listview.SelectedItems(0).Text
            Dim form As New FormAdicionarMeta
            form.tipo = tipo
            form.meta = MetaDAO.getSingletonObject().consultar(id)
            form.ShowDialog()
            Return True
        Else
            MsgBox("Selecione uma meta para editar")
        End If
        Return False
    End Function

    Private Sub btnApagarSemanal_Click(sender As Object, e As EventArgs) Handles btnApagarSemanal.Click
        Dim result = apagarMeta(listViewSemanais)
        If result Then carregarMetasSemanais()
    End Sub

    Private Sub btnApagarMensal_Click(sender As Object, e As EventArgs) Handles btnApagarMensal.Click
        Dim result = apagarMeta(ListViewMensais)
        If result Then carregarMetasMensais()
    End Sub

    Private Sub btnApagarAnual_Click(sender As Object, e As EventArgs) Handles btnApagarAnual.Click
        Dim result = apagarMeta(ListViewAnuais)
        If result Then carregarMetasAnuais()
    End Sub

    Private Function apagarMeta(listview As ListView) As Boolean
        If listview.SelectedItems.Count > 0 Then
            Dim descricaoSelecionada = listview.SelectedItems(0).SubItems(1).Text
            Dim idSelecionao = Integer.Parse(listview.SelectedItems(0).SubItems(0).Text)
            Dim result As DialogResult = MessageBox.Show("Deseja apagar a meta: " & descricaoSelecionada & " ?", "Apagar Lembrete", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Return False
            ElseIf result = DialogResult.Yes Then
                MetaDAO.getSingletonObject().deletar(idSelecionao)
                Return True
            End If
        Else
            MsgBox("Selecione uma meta para apagar!")
        End If
        Return False
    End Function

    Private Sub cbFiltroEstadoSemanal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltroEstadoSemanal.SelectedIndexChanged
        carregarMetasSemanais()
    End Sub

    Private Sub cbFiltroEstadoMensal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltroEstadoMensal.SelectedIndexChanged
        carregarMetasMensais()
    End Sub

    Private Sub cbFiltroEstadoAnual_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltroEstadoAnual.SelectedIndexChanged
        carregarMetasAnuais()
    End Sub
End Class
