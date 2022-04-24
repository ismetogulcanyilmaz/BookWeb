<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebForgotPasswordUserControl.ascx.cs" Inherits="KitapWeb.UserControls.WebForgotPasswordUserControl" %>

      <div class="bg-img">
      <div class="content">
        <header>Forgot Password Form</header>
        <div>
          <div class="field">
            <span class="fa fa-user"></span>
              <asp:TextBox ID="tbx_Email" placeholder="Email" runat="server"></asp:TextBox>
          </div> 
          <div class="field">
            <asp:Button ID="Btn_ForgotPassword" OnClick="Btn_PorgotPassword_Click" runat="server" Text="Forgot Password"/>
          </div> 
        </div> 
      </div>
    </div> 