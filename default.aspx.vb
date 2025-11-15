Imports MySql.Data.MySqlClient
Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        dbconn()


    End Sub

    Private Sub Buttonlogin_Click(sender As Object, e As EventArgs) Handles Buttonlogin.Click
        Try
            If acsconn.State = ConnectionState.Closed Then
                acsconn.Open()

            End If

            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM adminlogin WHERE adminid=@loginid AND adminpass=@loginpass", acsconn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@loginid", Textuserid.Text.Trim())
            cmd.Parameters.AddWithValue("@loginpass", Textuserpass.Text.Trim())

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())



            If count > 0 Then
                ' Create cookies to remember the user

                ' aab hum cache me store karenge

                Cache("loggedinuser") = Textuserid.Text.Trim()
                Cache.Insert("loggedinuser", Textuserid.Text.Trim(),
                 Nothing,
                 DateTime.Now.AddMinutes(20),
                 TimeSpan.Zero)

                Dim loginCookie As New HttpCookie("loginuser")
                loginCookie("jadminid") = Textuserid.Text.Trim()
                loginCookie("adminpass") = Textuserpass.Text.Trim()
                loginCookie.Expires = DateTime.Now.AddDays(30) ' cookies kab kahtam hogi
                Response.Cookies.Add(loginCookie)
                Textuserid.Text = ""
                Textuserpass.Text = ""
                Response.Write("<script>alert('⚠️ Login Successfully!');</script>")
                Response.Redirect("login.aspx")

                If Application("logincountkaro") IsNot Nothing Then
                    Application("logincountkaro") = Convert.ToInt32(Application("logincountkaro")) + 1
                Else
                    Application("logincountkaro") = 1

                End If

                totalloginuna.Text = Application("logincountkaro").ToString()
            End If
        Catch ex As Exception
            Response.Write("<script>alert('Error: " & ex.Message & "');</script>")
        Finally
            If acsconn.State = ConnectionState.Open Then
                acsconn.Close()
            End If
        End Try
    End Sub

    Private Sub deletecookiesr_Click(sender As Object, e As EventArgs) Handles deletecookiesr.Click
        Try
            Dim deleteCookie As New HttpCookie("loginuser")
            deleteCookie.Expires = DateTime.Now.AddDays(-1)
            Response.Cookies.Add(deleteCookie)

            Response.Write("<script>alert('⚠️ Cookies Deleted Successfully!');</script>")

        Catch ex As Exception
            Response.Write("<script>alert('Error: " & ex.Message & "');</script>")
        End Try
    End Sub
End Class
