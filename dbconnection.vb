Imports MySql.Data.MySqlClient
Module dbconnection
    Public acsconn As New MySqlConnection()
    Public acsdr As MySqlDataReader
    Public acsda As MySqlDataAdapter
    Public acscmd As New MySqlCommand
    Public strsql As String
    Public acsds As DataSet

    Dim connectionstring As String = System.Configuration.ConfigurationManager.ConnectionStrings("mydatabase").ConnectionString
    Public Function dbconn() As Boolean
        Dim result As Boolean
        Try
            If acsconn.State = ConnectionState.Closed Then
                acsconn.ConnectionString = connectionstring
                acsconn.Open()
            End If
            result = True
        Catch ex As Exception
            result = False
            HttpContext.Current.Response.Write("<script>alert('Server Not Connected!! " & ex.Message.Replace("'", "\'") & "');</script>")
        End Try
        Return result
    End Function
End Module
