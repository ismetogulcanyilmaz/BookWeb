<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserQuestionControl.ascx.cs" Inherits="KitapWeb.UserControls.WebUserQuestionControl" %>


       <div class="bg-img">
      <div class="content">
        <header>User Question Form</header>
        <div>
          <div class="field">
            <span class="fa fa-user"></span>
           <asp:Label ID="Lbl_UserEmail" runat="server" Text=""></asp:Label>
          </div>
            <div class="field">
            <span class="fa fa-user"></span>
               <asp:Label ID="Lbl_UserQuestion" runat="server" Text=""></asp:Label>
          </div>
            <div class="field">
            <span class="fa fa-user"></span>
               <asp:TextBox ID="tbx_UserAnswer" placeholder="Question Answer" runat="server"></asp:TextBox>
          </div>
          <div class="field">
               <asp:Button ID="Btn_UserQuestionPage" OnClick="Btn_UserQuestionPage_Click" runat="server" Text="Forgot Password" />
          </div> 
        </div> 
        <div>
              <asp:Label ID="Lbl_UserQuestionPage" runat="server" Text=""></asp:Label>
        </div>
      </div> 
    </div> 