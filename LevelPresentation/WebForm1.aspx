<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LevelPresentation.WebForm1" %>

<!DOCTYPE html>

<html class="bg-black" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Acceso al Sistema</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="css/AdminLTE.css" rel="stylesheet" type="text/css"/>
</head>
<body class="bg-black">
    <div class="form-box" id="login-box">
       <div class="header bg-red">Log In</div>
    <form id="form1" runat="server">
        <div class="body bg-gray">
            <div class="form-group">
                <asp:TextBox ID="txtUser" CssClass="form-control" placeholder="Input the User" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtPassword" CssClass="form-control" placeholder="Input the Password" TextMode="Password" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="footer">
            <asp:Button ID="btnLogIn" CssClass="btn bg-red btn-block" runat="server" Text="Log In" OnClick="btnLogIn_Click" />
        </div>
    </form>
   </div>
<script src="js/jquery-3.1.0.min.js"></script>
<script src="js/bootstrap.min.js" type="text/javascript"></script>
</body>
</html>
