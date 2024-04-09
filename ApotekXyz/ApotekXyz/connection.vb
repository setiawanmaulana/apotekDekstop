Imports System.Data.SqlClient
Module connection
    Public Conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Ds As DataSet
    Public Rd As SqlDataReader
    Public Cmd As SqlCommand
    Public MyDB As String
    Sub koneksi()
        MyDB = "Data source = LAPTOP-2R5LMKE5\SQLEXPRESS; initial catalog= db_apotek; integrated security = true; "
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
End Module
