Imports System.Data.Common
Imports System.Data.SQLite
Imports System.Diagnostics.Eventing

Public Class LembreteDAO
    Implements ILembreteDAO

    'Constantes estaticas
    Public Shared instancia As LembreteDAO
    Public Shared iniciado As Boolean

    Private Sub New()
        'construtor privado de forma a desabilitar outro a criar um objeto
    End Sub
    Friend Shared Function getSingletonObject() As LembreteDAO
        If iniciado = False Then
            instancia = New LembreteDAO()
            iniciado = True
            Return instancia
        Else
            Return instancia
        End If
    End Function


    Public Sub inserir(lembrete As Lembrete) Implements ILembreteDAO.inserir
        Try
            consultar(lembrete.descricao)
            Throw New LembreteExistenteException
        Catch ex As LembreteNaoEncontradaException
            Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
                cn.Open()
                Using objCommand As SQLiteCommand = cn.CreateCommand()
                    objCommand.CommandText = "INSERT INTO Lembretes (descricao, tipoLembrete, data) VALUES ('" & lembrete.descricao & "', '" & lembrete.tipoLembrete & "', '" & lembrete.data & "')"
                    objCommand.ExecuteNonQuery()
                End Using
                cn.Close()
            End Using
        End Try
    End Sub

    Public Sub deletar(nome As String) Implements ILembreteDAO.deletar
        Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
            cn.Open()
            Using objCommand As SQLiteCommand = cn.CreateCommand()
                objCommand.CommandText = "DELETE FROM Lembretes WHERE nome = '" & nome & "'"
                objCommand.ExecuteNonQuery()
            End Using
            cn.Close()
        End Using
    End Sub

    Public Function listar() As List(Of Lembrete) Implements ILembreteDAO.listar

        Dim listaLembretes As List(Of Lembrete) = New List(Of Lembrete)

        Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
            cn.Open()
            Dim sql = "descricao, tipoLembrete, data FROM Lembretes ORDER BY nome"

            Using cmd = New SQLiteCommand(sql, cn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        While dr.Read()
                            Dim lembrete As Lembrete = New Lembrete(dr("descricao"), dr("tipoLembrete"), dr("data"))
                            listaLembretes.Add(lembrete)
                        End While

                    End If
                End Using
            End Using

            cn.Close()
        End Using

        Return listaLembretes
    End Function

    Public Function consultar(descricao As String) As Lembrete Implements ILembreteDAO.consultar
        Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
            cn.Open()
            Dim sql = "SELECT descricao, tipoLembrete, data FROM Lembretes WHERE descricao = '" & descricao & "'"

            Using cmd = New SQLiteCommand(sql, cn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        dr.Read()
                        Dim lembrete As Lembrete = New Lembrete(dr("descricao"), dr("tipoLembrete"), dr("data"))
                        cn.Close()
                        Return lembrete
                    Else
                        cn.Close()
                        Throw New LembreteNaoEncontradaException
                    End If
                End Using
            End Using
        End Using
    End Function

End Class