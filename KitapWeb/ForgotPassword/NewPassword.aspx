<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewPassword.aspx.cs" Inherits="KitapWeb.ForgotPassword.NewPassword" %>

<%@ Register Src="~/UserControls/WebUserNewPasswordControl.ascx" TagPrefix="uc1" TagName="WebUserNewPasswordControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
   <link rel="stylesheet" href="/LoginForm/style.css"/>
   <script src="https://kit.fontawesome.com/a076d05399.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:WebUserNewPasswordControl runat="server" ID="WebUserNewPasswordControl" />
        </div>
    </form>
</body>
</html>
