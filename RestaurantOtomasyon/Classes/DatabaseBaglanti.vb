Imports System.Data.SqlClient

Public Class DatabaseBaglanti
    Private ReadOnly _connectionString As String
    Private _connection As SqlConnection

    Public Sub New(connectionString As String)
        _connectionString = connectionString
    End Sub

    Public Function OpenConnection() As SqlConnection
        If _connection Is Nothing Then
            _connection = New SqlConnection(_connectionString)
            _connection.Open()
        ElseIf _connection.State <> ConnectionState.Open Then
            _connection.Open()
        End If
        Return _connection
    End Function

    Public Sub CloseConnection()
        If _connection IsNot Nothing AndAlso _connection.State = ConnectionState.Open Then
            _connection.Close()
        End If
    End Sub

    Public ReadOnly Property Connection As SqlConnection
        Get
            Return _connection
        End Get
    End Property
End Class