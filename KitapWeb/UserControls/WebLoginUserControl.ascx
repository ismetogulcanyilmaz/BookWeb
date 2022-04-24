<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebLoginUserControl.ascx.cs" Inherits="KitapWeb.UserControls.WebLoginUserControl" %>

       <div class="bg-img">
      <div class="content">
        <header>Login Form</header>
        <div>
          <div class="field">
            <span class="fa fa-user"></span>
              <asp:TextBox ID="tbx_Email" placeholder="Email" runat="server"></asp:TextBox>
          </div>
          <div class="field space">
            <span class="fa fa-lock"></span>
                  <asp:TextBox ID="tbx_Password" placeholder="Password" CssClass="pass-key" runat="server"></asp:TextBox> 
            <span class="show">SHOW</span>
          </div>
          <div class="pass">
             <asp:LinkButton ID="LnkBtn_ForgotPassword" OnClick="LnkBtn_ForgotPassword_Click" runat="server">Forgot Password</asp:LinkButton>
          </div>
          <div class="field">
            <asp:Button ID="Btn_LoginPage" OnClick="Btn_LoginPage_Click" runat="server" Text="Login" />
          </div> 
        </div> 
        <div class="signup">Don't have account?
            <asp:LinkButton ID="LnkBtn_SignUp" OnClick="LnkBtn_SignUp_Click" runat="server">Sign Up</asp:LinkButton>
                 <asp:Label ID="Lbl_LoginPage" runat="server" Text=""></asp:Label>
        </div>
      </div>
    </div>