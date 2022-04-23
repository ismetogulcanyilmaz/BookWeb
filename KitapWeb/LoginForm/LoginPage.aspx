<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="KitapWeb.LoginForm.LoginPage" %>

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
          <div class="bg-img">
      <div class="content">
        <header>Login Form</header>
        <div>
          <div class="field">
            <span class="fa fa-user"></span>
              <asp:TextBox ID="tbx_Email" runat="server"></asp:TextBox>
          </div>
          <div class="field space">
            <span class="fa fa-lock"></span>
                  <asp:TextBox ID="tbx_Password" CssClass="pass-key" runat="server"></asp:TextBox> 
            <span class="show">SHOW</span>
          </div>
          <div class="pass">
            <a href="#">Forgot Password?</a>
          </div>
          <div class="field">
            <asp:Button ID="btn_login" runat="server" Text="Login" />
          </div>
        </div>
        <div class="signup">Don't have account?
          <a href="#">Signup Now</a>
        </div>
      </div>
    </div>
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
