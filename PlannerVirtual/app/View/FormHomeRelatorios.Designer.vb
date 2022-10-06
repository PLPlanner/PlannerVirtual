<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHomeRelatorios
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnMaisRealizadas = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelSelecionadoMaisRealizadas = New System.Windows.Forms.Panel()
        Me.PanelSelecionadoProdutividade = New System.Windows.Forms.Panel()
        Me.btnProdutividade = New System.Windows.Forms.Button()
        Me.PanelCentral = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMaisRealizadas
        '
        Me.btnMaisRealizadas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaisRealizadas.BackColor = System.Drawing.Color.Transparent
        Me.btnMaisRealizadas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaisRealizadas.FlatAppearance.BorderSize = 0
        Me.btnMaisRealizadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaisRealizadas.Font = New System.Drawing.Font("Source Code Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaisRealizadas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnMaisRealizadas.Location = New System.Drawing.Point(350, 0)
        Me.btnMaisRealizadas.Name = "btnMaisRealizadas"
        Me.btnMaisRealizadas.Size = New System.Drawing.Size(215, 60)
        Me.btnMaisRealizadas.TabIndex = 20
        Me.btnMaisRealizadas.Text = "Mais Realizadas"
        Me.btnMaisRealizadas.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnMaisRealizadas)
        Me.Panel1.Controls.Add(Me.PanelSelecionadoMaisRealizadas)
        Me.Panel1.Controls.Add(Me.PanelSelecionadoProdutividade)
        Me.Panel1.Controls.Add(Me.btnProdutividade)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(976, 65)
        Me.Panel1.TabIndex = 25
        '
        'PanelSelecionadoMaisRealizadas
        '
        Me.PanelSelecionadoMaisRealizadas.Location = New System.Drawing.Point(350, 60)
        Me.PanelSelecionadoMaisRealizadas.Name = "PanelSelecionadoMaisRealizadas"
        Me.PanelSelecionadoMaisRealizadas.Size = New System.Drawing.Size(200, 5)
        Me.PanelSelecionadoMaisRealizadas.TabIndex = 22
        '
        'PanelSelecionadoProdutividade
        '
        Me.PanelSelecionadoProdutividade.Location = New System.Drawing.Point(12, 60)
        Me.PanelSelecionadoProdutividade.Name = "PanelSelecionadoProdutividade"
        Me.PanelSelecionadoProdutividade.Size = New System.Drawing.Size(200, 5)
        Me.PanelSelecionadoProdutividade.TabIndex = 21
        '
        'btnProdutividade
        '
        Me.btnProdutividade.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProdutividade.BackColor = System.Drawing.Color.Transparent
        Me.btnProdutividade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProdutividade.FlatAppearance.BorderSize = 0
        Me.btnProdutividade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProdutividade.Font = New System.Drawing.Font("Source Code Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProdutividade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnProdutividade.Location = New System.Drawing.Point(0, 0)
        Me.btnProdutividade.Name = "btnProdutividade"
        Me.btnProdutividade.Size = New System.Drawing.Size(259, 60)
        Me.btnProdutividade.TabIndex = 19
        Me.btnProdutividade.Text = "Produtividade"
        Me.btnProdutividade.UseVisualStyleBackColor = False
        '
        'PanelCentral
        '
        Me.PanelCentral.Location = New System.Drawing.Point(0, 63)
        Me.PanelCentral.Name = "PanelCentral"
        Me.PanelCentral.Size = New System.Drawing.Size(976, 848)
        Me.PanelCentral.TabIndex = 26
        '
        'FormHomeRelatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(976, 911)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelCentral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormHomeRelatorios"
        Me.Text = "FormHomeRelatorios"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMaisRealizadas As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelSelecionadoMaisRealizadas As Panel
    Friend WithEvents PanelSelecionadoProdutividade As Panel
    Friend WithEvents btnProdutividade As Button
    Friend WithEvents PanelCentral As Panel
End Class
