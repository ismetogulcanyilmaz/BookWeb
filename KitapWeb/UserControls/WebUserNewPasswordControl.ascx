<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserNewPasswordControl.ascx.cs" Inherits="KitapWeb.UserControls.WebUserNewPasswordControl" %>

     <div class="bg-img">
      <div class="content">
        <header>New Password Form</header>
        <div>
          <div class="field space">
            <span class="fa fa-lock"></span>
                  <asp:TextBox ID="tbx_NewPassword" placeholder="New Password" CssClass="pass-key" runat="server"></asp:TextBox> 
            <span class="show">SHOW</span>
          </div>
             <div class="field space">
            <span class="fa fa-lock"></span>
                  <asp:TextBox ID="tbx_PasswordCheck" placeholder="Password Check" CssClass="pass-key" runat="server"></asp:TextBox> 
            <span class="show">SHOW</span>
          </div>
          <div class="field">
            <asp:Button ID="Btn_NewPasswordPage" OnClick="Btn_NewPasswordPage_Click" runat="server" Text="New Password" />
          </div> 
        </div> 
        <div>
                 <asp:Label ID="Lbl_NewPasswordPage" runat="server" Text=""></asp:Label>
        </div>
      </div>
    </div>