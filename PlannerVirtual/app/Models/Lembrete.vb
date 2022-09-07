Imports Microsoft.VisualBasic

Public Class Lembrete
    Private _descricao As String
    Private _tipoLembrete As TipoLembrete
    Private _data As Date
    'TODO ADD ILembreteDAO

    Public Sub New(ByVal descricao As String, ByVal horarioInicio As Date, ByVal data As Integer)
        _descricao = descricao
        _data = data
    End Sub

    Public Function Getdescricao() As System.String
        Return _descricao
    End Function


    Public Sub Setdescricao(value As System.String)
        _descricao = value
    End Sub

    Public Function GettipoLembrete() As TipoLembrete
        Return _tipoLembrete
    End Function

    Public Sub SettipoLembrete(value As TipoLembrete)
        _tipoLembrete = value
    End Sub

    Public Function Getdata() As System.DateTime
        Return _data
    End Function

    Public Sub Setdata(value As System.DateTime)
        _data = value
    End Sub

    Sub salvar()

    End Sub

End Class

Public Enum TipoLembrete
    ligacoesImportantes
    reunioes
    compras
End Enum