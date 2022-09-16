Imports System.Data.Common
Imports System.Data.SQLite
Imports System.Diagnostics.Eventing

Public Class MetaDAO
    Implements IMetaDAO

    'Constantes estaticas
    Public Shared instancia As MetaDAO
    Public Shared iniciado As Boolean

    Private Sub New()
        'construtor privado de forma a desabilitar outro a criar um objeto
    End Sub
    Friend Shared Function getSingletonObject() As MetaDAO
        If iniciado = False Then
            instancia = New MetaDAO()
            iniciado = True
            Return instancia
        Else
            Return instancia
        End If
    End Function


    Private sConnectionString As String = "Data Source= C:\Users\danie\OneDrive\�rea de Trabalho\PlannerVirtual\PlannerVirtual\database.db; Version=3; New=True; Compress=True;"

    Public Sub inserir(meta As Meta) Implements IMetaDAO.inserir
        Try
            consultar(meta.nome)
            Throw New CategoriaExistenteException
        Catch ex As CategoriaNaoEncontradaException
            Using cn = New SQLiteConnection(sConnectionString)
                cn.Open()
                Using objCommand As SQLiteCommand = cn.CreateCommand()
                    objCommand.CommandText = "INSERT INTO Categorias (nome , cor) VALUES ('" & categoria.nome & "', " & Color.Red.ToArgb & ")"
                    objCommand.ExecuteNonQuery()
                End Using
                cn.Close()
            End Using
        End Try
    End Sub

    Public Sub deletar(nome As String) Implements IMetaDAO.deletar
        Using cn = New SQLiteConnection(sConnectionString)
            cn.Open()
            Using objCommand As SQLiteCommand = cn.CreateCommand()
                objCommand.CommandText = "DELETE FROM Categorias WHERE nome = '" & nome & "'"
                objCommand.ExecuteNonQuery()
            End Using
            cn.Close()
        End Using
    End Sub

    Public Function listar() As List(Of Meta) Implements IMetaDAO.listar

        Dim listaMetas As List(Of Meta) = New List(Of Meta)

        Using cn = New SQLiteConnection(sConnectionString)
            cn.Open()
            Dim sql = "SELECT nome,cor FROM Categorias ORDER BY nome"

            Using cmd = New SQLiteCommand(sql, cn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        While dr.Read()
                            Dim meta As Meta = New Meta(dr("nome"), Color.FromArgb((dr("cor"))))
                            listaMetas.Add(meta)
                        End While

                    End If
                End Using
            End Using

            cn.Close()
        End Using

        Return listaMetas
    End Function

    Public Function consultar(nome As String) As Meta Implements IMetaDAO.consultar
        Using cn = New SQLiteConnection(sConnectionString)
            cn.Open()
            Dim sql = "SELECT nome,cor FROM Categorias WHERE nome = '" & nome & "'"

            Using cmd = New SQLiteCommand(sql, cn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        dr.Read()
                        Dim meta As Meta = New Meta(dr("nome"), Color.FromArgb((dr("cor"))))
                        cn.Close()
                        Return meta
                    Else
                        cn.Close()
                        Throw New CategoriaNaoEncontradaException
                    End If
                End Using
            End Using
        End Using
    End Function

End Class
