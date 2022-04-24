<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignInPage.aspx.cs" Inherits="KitapWeb.SignInForm.SignInPage" %>

<%@ Register Src="~/UserControls/WebSignInUserControl.ascx" TagPrefix="uc1" TagName="WebSignInUserControl" %>


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
        <uc1:WebSignInUserControl runat="server" id="WebSignInUserControl" />
    </form>
             <script>
              const pass_field = document.querySelector('.pass-key');
              const showBtn = document.querySelector('.show');
              showBtn.addEventListener('click', function () {
                  if (pass_field.type === "password") {
                      pass_field.type = "text";
                      showBtn.textContent = "HIDE";
                      showBtn.style.color = "#3498db";
                  } else {
                      pass_field.type = "password";
                      showBtn.textContent = "SHOW";
                      showBtn.style.color = "#222";
                  }
              });
    </script>
</body>
</html>
