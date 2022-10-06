<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRelatorioCategoriasMaisRealizadas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListViewRelatorio = New System.Windows.Forms.ListView()
        Me.Posição = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Categoria = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cbIntervaloTempo = New System.Windows.Forms.ComboBox()
        Me.btnIrSemanaAtual = New System.Windows.Forms.Button()
        Me.btnAvancarSemana = New System.Windows.Forms.Button()
        Me.lblSemana = New System.Windows.Forms.Label()
        Me.btnVoltarSemana = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblTipoRelatorio = New System.Windows.Forms.Label()
        Me.cbTipoRelatorio = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblQuantTotal = New System.Windows.Forms.Label()
        Me.lblQuantConcluidas = New System.Windows.Forms.Label()
        Me.lblQuantPorcentagem = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewRelatorio
        '
        Me.ListViewRelatorio.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Posição, Me.Categoria, Me.Quantidade})
        Me.ListViewRelatorio.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewRelatorio.HideSelection = False
        Me.ListViewRelatorio.Location = New System.Drawing.Point(263, 178)
        Me.ListViewRelatorio.Name = "ListViewRelatorio"
        Me.ListViewRelatorio.Size = New System.Drawing.Size(447, 254)
        Me.ListViewRelatorio.TabIndex = 0
        Me.ListViewRelatorio.UseCompatibleStateImageBehavior = False
        Me.ListViewRelatorio.View = System.Windows.Forms.View.Details
        '
        'Posição
        '
        Me.Posição.Text = "Posição"
        '
        'Categoria
        '
        Me.Categoria.Text = "Categoria"
        Me.Categoria.Width = 200
        '
        'Quantidade
        '
        Me.Quantidade.Text = "Quantidade"
        Me.Quantidade.Width = 183
        '
        'cbIntervaloTempo
        '
        Me.cbIntervaloTempo.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbIntervaloTempo.FormattingEnabled = True
        Me.cbIntervaloTempo.Items.AddRange(New Object() {"Semana", "Mês", "Ano"})
        Me.cbIntervaloTempo.Location = New System.Drawing.Point(0, 0)
        Me.cbIntervaloTempo.Name = "cbIntervaloTempo"
        Me.cbIntervaloTempo.Size = New System.Drawing.Size(250, 21)
        Me.cbIntervaloTempo.TabIndex = 2
        '
        'btnIrSemanaAtual
        '
        Me.btnIrSemanaAtual.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnIrSemanaAtual.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnIrSemanaAtual.FlatAppearance.BorderSize = 0
        Me.btnIrSemanaAtual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIrSemanaAtual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIrSemanaAtual.Location = New System.Drawing.Point(0, 27)
        Me.btnIrSemanaAtual.Name = "btnIrSemanaAtual"
        Me.btnIrSemanaAtual.Size = New System.Drawing.Size(250, 22)
        Me.btnIrSemanaAtual.TabIndex = 25
        Me.btnIrSemanaAtual.Text = "Atual"
        Me.btnIrSemanaAtual.UseVisualStyleBackColor = False
        '
        'btnAvancarSemana
        '
        Me.btnAvancarSemana.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnAvancarSemana.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAvancarSemana.FlatAppearance.BorderSize = 0
        Me.btnAvancarSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAvancarSemana.Location = New System.Drawing.Point(215, 0)
        Me.btnAvancarSemana.Name = "btnAvancarSemana"
        Me.btnAvancarSemana.Size = New System.Drawing.Size(35, 49)
        Me.btnAvancarSemana.TabIndex = 24
        Me.btnAvancarSemana.Text = ">"
        Me.btnAvancarSemana.UseVisualStyleBackColor = False
        '
        'lblSemana
        '
        Me.lblSemana.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemana.Location = New System.Drawing.Point(35, 0)
        Me.lblSemana.Name = "lblSemana"
        Me.lblSemana.Size = New System.Drawing.Size(180, 49)
        Me.lblSemana.TabIndex = 23
        Me.lblSemana.Text = "Semana"
        Me.lblSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVoltarSemana
        '
        Me.btnVoltarSemana.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnVoltarSemana.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnVoltarSemana.FlatAppearance.BorderSize = 0
        Me.btnVoltarSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltarSemana.Location = New System.Drawing.Point(0, 0)
        Me.btnVoltarSemana.Name = "btnVoltarSemana"
        Me.btnVoltarSemana.Size = New System.Drawing.Size(35, 49)
        Me.btnVoltarSemana.TabIndex = 21
        Me.btnVoltarSemana.Text = "<"
        Me.btnVoltarSemana.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblTipoRelatorio)
        Me.Panel3.Controls.Add(Me.cbTipoRelatorio)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(976, 121)
        Me.Panel3.TabIndex = 26
        '
        'lblTipoRelatorio
        '
        Me.lblTipoRelatorio.AutoSize = True
        Me.lblTipoRelatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoRelatorio.Location = New System.Drawing.Point(260, 44)
        Me.lblTipoRelatorio.Name = "lblTipoRelatorio"
        Me.lblTipoRelatorio.Size = New System.Drawing.Size(116, 16)
        Me.lblTipoRelatorio.TabIndex = 28
        Me.lblTipoRelatorio.Text = "Selecionar tipo:"
        '
        'cbTipoRelatorio
        '
        Me.cbTipoRelatorio.FormattingEnabled = True
        Me.cbTipoRelatorio.Items.AddRange(New Object() {"Tarefas", "Metas"})
        Me.cbTipoRelatorio.Location = New System.Drawing.Point(263, 63)
        Me.cbTipoRelatorio.Name = "cbTipoRelatorio"
        Me.cbTipoRelatorio.Size = New System.Drawing.Size(121, 21)
        Me.cbTipoRelatorio.TabIndex = 27
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.Controls.Add(Me.Panel5)
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Location = New System.Drawing.Point(460, 10)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(250, 100)
        Me.Panel6.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnIrSemanaAtual)
        Me.Panel5.Controls.Add(Me.cbIntervaloTempo)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 51)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(250, 49)
        Me.Panel5.TabIndex = 27
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lblSemana)
        Me.Panel4.Controls.Add(Me.btnAvancarSemana)
        Me.Panel4.Controls.Add(Me.btnVoltarSemana)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(250, 49)
        Me.Panel4.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(259, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 24)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Categorias mais realizadas:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(259, 471)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(79, 24)
        Me.lblTipo.TabIndex = 31
        Me.lblTipo.Text = "Tarefas"
        '
        'lblQuantTotal
        '
        Me.lblQuantTotal.AutoSize = True
        Me.lblQuantTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantTotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblQuantTotal.Location = New System.Drawing.Point(259, 511)
        Me.lblQuantTotal.Name = "lblQuantTotal"
        Me.lblQuantTotal.Size = New System.Drawing.Size(54, 20)
        Me.lblQuantTotal.TabIndex = 32
        Me.lblQuantTotal.Text = "Total:"
        '
        'lblQuantConcluidas
        '
        Me.lblQuantConcluidas.AutoSize = True
        Me.lblQuantConcluidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantConcluidas.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblQuantConcluidas.Location = New System.Drawing.Point(259, 545)
        Me.lblQuantConcluidas.Name = "lblQuantConcluidas"
        Me.lblQuantConcluidas.Size = New System.Drawing.Size(102, 20)
        Me.lblQuantConcluidas.TabIndex = 33
        Me.lblQuantConcluidas.Text = "Concluidas:"
        '
        'lblQuantPorcentagem
        '
        Me.lblQuantPorcentagem.AutoSize = True
        Me.lblQuantPorcentagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantPorcentagem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblQuantPorcentagem.Location = New System.Drawing.Point(259, 576)
        Me.lblQuantPorcentagem.Name = "lblQuantPorcentagem"
        Me.lblQuantPorcentagem.Size = New System.Drawing.Size(209, 20)
        Me.lblQuantPorcentagem.TabIndex = 34
        Me.lblQuantPorcentagem.Text = "Porcentagem Realizadas"
        '
        'FormRelatorioCategoriasMaisRealizadas
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(976, 911)
        Me.Controls.Add(Me.lblQuantPorcentagem)
        Me.Controls.Add(Me.lblQuantConcluidas)
        Me.Controls.Add(Me.lblQuantTotal)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ListViewRelatorio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(976, 911)
        Me.MinimumSize = New System.Drawing.Size(976, 911)
        Me.Name = "FormRelatorioCategoriasMaisRealizadas"
        Me.Text = "Form2"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListViewRelatorio As ListView
    Friend WithEvents Categoria As ColumnHeader
    Friend WithEvents Quantidade As ColumnHeader
    Friend WithEvents cbIntervaloTempo As ComboBox
    Friend WithEvents btnIrSemanaAtual As Button
    Friend WithEvents btnAvancarSemana As Button
    Friend WithEvents lblSemana As Label
    Friend WithEvents btnVoltarSemana As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cbTipoRelatorio As ComboBox
    Friend WithEvents lblTipoRelatorio As Label
    Friend WithEvents Posição As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblQuantTotal As Label
    Friend WithEvents lblQuantConcluidas As Label
    Friend WithEvents lblQuantPorcentagem As Label
End Class
