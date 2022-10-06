Public Class FormHomeRelatorios

    Private formularioAtual As Form = Nothing

    Private Sub FormHomeRelatorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnProdutividade.Location = New Point(0, 0)
        btnProdutividade.Size = New Size(Me.Width / 2, 60)

        btnMaisRealizadas.Size = New Size(Me.Width / 2, 60)
        btnMaisRealizadas.Location = New Point(Me.Width - btnMaisRealizadas.Size.Width, 0)
        btnMaisRealizadas.ForeColor = Color.Black

        PanelSelecionadoProdutividade.Size = New Size(btnProdutividade.Size.Width, 5)
        PanelSelecionadoProdutividade.Location = New Point(btnProdutividade.Location.X, btnProdutividade.Location.Y + btnProdutividade.Size.Height)
        PanelSelecionadoProdutividade.BackColor = Color.FromArgb(67, 97, 238)

        PanelSelecionadoMaisRealizadas.Size = New Size(btnMaisRealizadas.Size.Width, 5)
        PanelSelecionadoMaisRealizadas.Location = New Point(btnMaisRealizadas.Location.X, btnMaisRealizadas.Location.Y + btnMaisRealizadas.Size.Height)
        PanelSelecionadoMaisRealizadas.BackColor = Color.LightGray

        loadForm(New FormRelatorioProdutividade)
    End Sub

    Private Sub loadForm(form As Form)

        If formularioAtual IsNot Nothing Then formularioAtual.Close()

        formularioAtual = form
        formularioAtual.TopLevel = False
        formularioAtual.FormBorderStyle = FormBorderStyle.None
        formularioAtual.Dock = DockStyle.Fill

        PanelCentral.Controls.Add(formularioAtual)
        PanelCentral.Tag = formularioAtual
        formularioAtual.BringToFront()
        formularioAtual.Show()

    End Sub

    Private Sub btnProdutividade_Click(sender As Object, e As EventArgs) Handles btnProdutividade.Click
        btnProdutividade.ForeColor = Color.FromArgb(67, 97, 238)
        btnMaisRealizadas.ForeColor = Color.Black

        PanelSelecionadoProdutividade.BackColor = Color.FromArgb(67, 97, 238)
        PanelSelecionadoMaisRealizadas.BackColor = Color.LightGray

        loadForm(New FormRelatorioProdutividade)
    End Sub

    Private Sub btnMaisRealizadas_Click(sender As Object, e As EventArgs) Handles btnMaisRealizadas.Click
        btnMaisRealizadas.ForeColor = Color.FromArgb(67, 97, 238)
        btnProdutividade.ForeColor = Color.Black


        PanelSelecionadoMaisRealizadas.BackColor = Color.FromArgb(67, 97, 238)
        PanelSelecionadoProdutividade.BackColor = Color.LightGray
        loadForm(New FormRelatorioCategoriasMaisRealizadas)
    End Sub

End Class