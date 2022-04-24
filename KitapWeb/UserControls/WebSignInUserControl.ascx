<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebSignInUserControl.ascx.cs" Inherits="KitapWeb.UserControls.WebSignInUserControl" %>

      <div class="bg-img">
      <div class="content">
        <header>SignIn Form</header>
        <div> 
                <div class="field"> 
            <span class="fa fa-user"></span>
              <asp:TextBox ID="tbx_FirstName" placeholder="FirstName" runat="server"></asp:TextBox>
          </div>
                <div class="field"> 
            <span class="fa fa-user"></span>
              <asp:TextBox ID="tbx_LastName" placeholder="LastName" runat="server"></asp:TextBox>
          </div>
          <div class="field">  
            <span class="fa fa-user"></span>
              <asp:TextBox ID="tbx_Email" placeholder="Email" runat="server"></asp:TextBox>
          </div>
          <div class="field space">
            <span class="fa fa-lock"></span>
                  <asp:TextBox ID="tbx_Password" placeholder="Password" CssClass="pass-key" runat="server"></asp:TextBox> 
            <span class="show">SHOW</span>
          </div>
                <div class="field"> 
            <span class="fa fa-user"></span>
                    <asp:DropDownList ID="DropDownList_SecurityQuestions" runat="server"></asp:DropDownList>
          </div>
                <div class="field"> 
            <span class="fa fa-user"></span>
              <asp:TextBox ID="tbx_QuestionAnswer" placeholder="QuestionAnswer" runat="server"></asp:TextBox>
          </div> 
          <div class="field">
            <asp:Button ID="Btn_SignInPage" OnClick="Btn_SignInPage_Click" runat="server" Text="Sign In" />
          </div>
          <asp:Label ID="Lbl_SignIn" runat="server" Text=""></asp:Label>
        </div> 
      </div> 
    </div> 