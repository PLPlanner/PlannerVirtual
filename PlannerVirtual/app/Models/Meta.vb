Imports Microsoft.VisualBasic

Public Class Meta
    Private _descricao As String
    Private _categoria As Categoria
    Private _tipo As TipoMeta
    Private _estado As EstadoMeta
    Private _data As Date
    'TODO ADD IMetaDAO

    Public Sub New(ByVal descricao As String, ByVal data As Date, ByVal tipo As TipoMeta)
        _descricao = descricao
        _data = data
        _tipo = tipo
        _estado = EstadoMeta.naoCumprida
    End Sub


    Public Function Getdescricao() As System.String
        Return _descricao
    End Function


    Public Sub Setdescricao(value As System.String)
        _descricao = value
    End Sub

    Public Property estado() As EstadoMeta
        Get
            Return _estado
        End Get
        Set(ByVal value As EstadoMeta)
            _estado = value
        End Set
    End Property

    Public Property tipo() As TipoMeta
        Get
            Return _tipo
        End Get
        Set(ByVal value As TipoMeta)
            _tipo = value
        End Set
    End Property

    Public Property categoria() As Categoria
        Get
            Return _categoria
        End Get
        Set(ByVal value As Categoria)
            _categoria = value
        End Set
    End Property

    Public Function Getdata() As System.DateTime
        Return _data
    End Function

    Public Sub Setdata(value As System.DateTime)
        _data = value
    End Sub

    Sub alterarEstado(est As EstadoMeta)
        _estado = est
    End Sub

    Sub salvar()

    End Sub

    Sub concluir()
        _estado = EstadoMeta.cumprida
    End Sub
End Class

Public Enum TipoMeta
    semanal
    mensal
    anual
End Enum

Public Enum EstadoMeta
    cumprida
    naoCumprida
    parcialmenteCumprida
End Enum