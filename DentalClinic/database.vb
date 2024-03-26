
Imports MySql.Data.MySqlClient

    Module database
        Public conn As New MySqlConnection
        Public cmd As New MySqlCommand

        Dim status As Boolean = False

        Public i As Integer

    Dim connstring = "server=localhost;database=dental_clinic;user=root;password="



    'Establish connection'
    Public Function dbconnect() As Boolean
            If (conn.State = ConnectionState.Closed) Then
                conn.ConnectionString = connstring

                status = True
            End If
            Return status

        End Function

    End Module

