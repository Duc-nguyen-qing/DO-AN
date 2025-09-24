Imports System.Data.SqlClient

Public Class Connection
    Public Shared Function GetConnection() As SqlConnection
        Dim connectionString As String = "Data Source=RUANQINGDE\SQLEXPRESS;Initial Catalog=QUANLYBANHANG;Integrated Security=True"
        Return New SqlConnection(connectionString)
    End Function
End Class