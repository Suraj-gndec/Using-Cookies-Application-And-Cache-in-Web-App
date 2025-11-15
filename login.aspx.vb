Imports MySql.Data.MySqlClient

Public Class login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Cache("loggedinuser") IsNot Nothing Then
            Response.Write("Cache Me User Hai: " & Cache("loggedinuser"))
        Else
            Response.Write("Cache Expired Ya User Login Nahi")
        End If
    End Sub


End Class
