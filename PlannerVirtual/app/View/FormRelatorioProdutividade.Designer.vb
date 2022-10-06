<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRelatorioProdutividade
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ChartTurnos = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnIrSemanaAtual = New System.Windows.Forms.Button()
        Me.cbIntervaloTempo = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblSemana = New System.Windows.Forms.Label()
        Me.btnAvancarSemana = New System.Windows.Forms.Button()
        Me.btnVoltarSemana = New System.Windows.Forms.Button()
        Me.ChartSemanas = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSemanaMesProdutivo = New System.Windows.Forms.Label()
        CType(Me.ChartTurnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.ChartSemanas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartTurnos
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChartTurnos.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Turnos"
        Me.ChartTurnos.Legends.Add(Legend1)
        Me.ChartTurnos.Location = New System.Drawing.Point(36, 130)
        Me.ChartTurnos.Name = "ChartTurnos"
        Me.ChartTurnos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.ChartTurnos.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(235, Byte), Integer))}
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series1.Legend = "Turnos"
        Series1.Name = "Turnos"
        Series1.YValuesPerPoint = 4
        Me.ChartTurnos.Series.Add(Series1)
        Me.ChartTurnos.Size = New System.Drawing.Size(893, 313)
        Me.ChartTurnos.TabIndex = 0
        Me.ChartTurnos.Text = "Chart1"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(976, 124)
        Me.Panel3.TabIndex = 27
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.Controls.Add(Me.Panel5)
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Location = New System.Drawing.Point(549, 21)
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
        'btnAvancarSemana
        '
        Me.btnAvancarSemana.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnAvancarSemana.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAvancarSemana.FlatAppearance.BorderSize = 0
        Me.btnAvancarSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAvancarSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvancarSemana.Location = New System.Drawing.Point(215, 0)
        Me.btnAvancarSemana.Name = "btnAvancarSemana"
        Me.btnAvancarSemana.Size = New System.Drawing.Size(35, 49)
        Me.btnAvancarSemana.TabIndex = 24
        Me.btnAvancarSemana.Text = ">"
        Me.btnAvancarSemana.UseVisualStyleBackColor = False
        '
        'btnVoltarSemana
        '
        Me.btnVoltarSemana.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnVoltarSemana.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnVoltarSemana.FlatAppearance.BorderSize = 0
        Me.btnVoltarSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltarSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltarSemana.Location = New System.Drawing.Point(0, 0)
        Me.btnVoltarSemana.Name = "btnVoltarSemana"
        Me.btnVoltarSemana.Size = New System.Drawing.Size(35, 49)
        Me.btnVoltarSemana.TabIndex = 21
        Me.btnVoltarSemana.Text = "<"
        Me.btnVoltarSemana.UseVisualStyleBackColor = False
        '
        'ChartSemanas
        '
        ChartArea2.Name = "ChartArea1"
        Me.ChartSemanas.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.ChartSemanas.Legends.Add(Legend2)
        Me.ChartSemanas.Location = New System.Drawing.Point(84, 505)
        Me.ChartSemanas.Name = "ChartSemanas"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series2.Legend = "Legend1"
        Series2.Name = "Semanas"
        Me.ChartSemanas.Series.Add(Series2)
        Me.ChartSemanas.Size = New System.Drawing.Size(820, 312)
        Me.ChartSemanas.TabIndex = 28
        Me.ChartSemanas.Text = "Chart1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Turnos mais produtivos:"
        '
        'lblSemanaMesProdutivo
        '
        Me.lblSemanaMesProdutivo.AutoSize = True
        Me.lblSemanaMesProdutivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemanaMesProdutivo.Location = New System.Drawing.Point(89, 455)
        Me.lblSemanaMesProdutivo.Name = "lblSemanaMesProdutivo"
        Me.lblSemanaMesProdutivo.Size = New System.Drawing.Size(234, 24)
        Me.lblSemanaMesProdutivo.TabIndex = 2
        Me.lblSemanaMesProdutivo.Text = "Turnos mais produtivos:"
        '
        'FormRelatorioProdutividade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(976, 846)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSemanaMesProdutivo)
        Me.Controls.Add(Me.ChartSemanas)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ChartTurnos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRelatorioProdutividade"
        Me.Text = "FormRelatorioProdutividade"
        CType(Me.ChartTurnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.ChartSemanas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChartTurnos As DataVisualization.Charting.Chart
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnIrSemanaAtual As Button
    Friend WithEvents cbIntervaloTempo As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblSemana As Label
    Friend WithEvents btnAvancarSemana As Button
    Friend WithEvents btnVoltarSemana As Button
    Friend WithEvents ChartSemanas As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSemanaMesProdutivo As Label
End Class
