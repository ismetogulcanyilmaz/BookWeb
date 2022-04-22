<%@ Page Title="" Language="C#" MasterPageFile="~/AdminWeb/Admin.Master" AutoEventWireup="true" CodeBehind="AdminUser.aspx.cs" Inherits="KitapWeb.AdminWeb.AdminUser" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Ana" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div>
        <asp:GridView ID="GridView1" runat="server" CssClass="table table-light " AutoGenerateColumns="false"  >
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id"  />
            <asp:BoundField DataField="FirstName" HeaderText="FirstName"  />
            <asp:BoundField DataField="LastName" HeaderText="LastName"  />
            <asp:BoundField DataField="Email" HeaderText="Email"  />
            <asp:BoundField DataField="Password" HeaderText="Password"  />

            <asp:TemplateField>
                <ItemTemplate>

                    <asp:LinkButton id="LnkBtn_Update" Text="Update" CssClass="btn btn-warning" CommandName="Update"  CommandArgument='<%# Eval("Id")%>' OnCommand="LnkBtn_Update_Command" runat="server"/>
                    <asp:LinkButton id="LnkBtn_Delete" Text="Delete" CssClass="btn btn-danger"  CommandName="Delete"  CommandArgument='<%# Eval("Id")%>' OnCommand="LnkBtn_Delete_Command" runat="server"/>

                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>
    </div>
      <div class="form-group row">
          <div class="col-lg-5">
            <label for="exampleFormControlInput1">CategoryFirstName</label>
            <asp:TextBox ID="tbx_AddFirstName" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">LastName</label>
            <asp:TextBox ID="tbx_AddLastName" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">Email</label>
            <asp:TextBox ID="tbx_AddEmail" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">Password</label>
            <asp:TextBox ID="tbx_AddPassword" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">SecurityQuestionId</label>
            <asp:TextBox ID="tbx_AddSecurityQuestionId" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">Status</label>
            <asp:TextBox ID="tbx_AddStatus" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">SecurityQuestionAnswer</label>
            <asp:TextBox ID="tbx_AddSecurityQuestionAnswer" CssClass="form-control" runat="server"></asp:TextBox>

            <asp:Button ID="btn_Add" runat="server" CssClass="btn btn-success" Text="Add" OnClick="btn_Add_Click" />
          </div>

          <div class="col-lg-5">
             <label for="exampleFormControlInput1">Id</label>
            <asp:TextBox ID="tbx_UpdateId" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">FirstName</label>
            <asp:TextBox ID="tbx_UpdateFirstName" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">LastName</label>
            <asp:TextBox ID="tbx_UpdateLastName" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">Email</label>
            <asp:TextBox ID="tbx_UpdateEmail" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">Password</label>
            <asp:TextBox ID="tbx_UpdatePassword" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">SecurityQuestionId</label>
            <asp:TextBox ID="tbx_UpdateSecurityQuestionId" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">Status</label>
            <asp:TextBox ID="tbx_UpdateStatus" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">SecurityQuestionAnswer</label>
            <asp:TextBox ID="tbx_UpdateSecurityQuestionAnswer" CssClass="form-control" runat="server"></asp:TextBox>

            <asp:Button ID="btn_Update" runat="server" CssClass="btn btn-warning" Text="Update" OnClick="btn_Update_Click" />
          </div>
      </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

