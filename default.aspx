<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="AllControls._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Dashboard</title>
 <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet"/>

</head>
<body class="bg-light">
    <form id="form1" runat="server">
       <div class="container">
        <div class="row justify-content-center mt-5">
            <div class="col-md-4">

                <div class="card shadow-lg p-4">
                    <h3 class="text-center mb-4">Login</h3>

                    <div>
                        <!-- Email -->
                        <div class="mb-3">
                            <label class="form-label" >ID</label>
                            <asp:TextBox ID="Textuserid" runat="server" class="form-control"  ></asp:TextBox>
                           
                        </div>

                        <!-- Password -->
                        <div class="mb-3">
                            <label class="form-label">Password</label>

                            <asp:TextBox ID="Textuserpass" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                        </div>

                       

                        <!-- Button -->
                        <asp:Button ID="Buttonlogin" runat="server" Text="Login" class="btn btn-primary w-100" />
                        

                       

                    </div>

                </div>

            </div>
        </div>
    </div>




         <asp:Label ID="totalloginuna" runat="server" Text="Label" CssClass="mt-3 d-block"></asp:Label>
        <br />
        <asp:Button ID="deletecookiesr"   Text="delete cookies" class="btn btn-danger mt-3" runat="server" />
    </form> 
</body>
</html>

