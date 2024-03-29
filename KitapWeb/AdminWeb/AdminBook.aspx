﻿<%@ Page Title="" Language="C#" MasterPageFile="~/AdminWeb/Admin.Master" AutoEventWireup="true" CodeBehind="AdminBook.aspx.cs" Inherits="KitapWeb.AdminWeb.AdminBook" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Ana" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div>
        <asp:GridView ID="GridView1" runat="server" CssClass="table table-light " AutoGenerateColumns="false"  >
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id"  />
            <asp:BoundField DataField="BookCategoryId" HeaderText="BookCategoryId"  />
            <asp:BoundField DataField="Name" HeaderText="Name"  />
            <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice"  />
            <asp:BoundField DataField="UnitsInStock" HeaderText="UnitsInStock"  />
            <asp:BoundField DataField="WriterName" HeaderText="WriterName"  />
            <asp:BoundField DataField="BooksPage" HeaderText="BooksPage"  />
            <asp:BoundField DataField="Photo" HeaderText="Photo"  />

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
            <label for="exampleFormControlInput1">BookCategoryId</label>
            <asp:TextBox ID="tbx_AddBookCategoryId" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">Name</label>
            <asp:TextBox ID="tbx_AddName" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">UnitPrice</label>
            <asp:TextBox ID="tbx_AddUnitPrice" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">UnitsInStock</label>
            <asp:TextBox ID="tbx_AddUnitsInStock" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">WriterName</label>
            <asp:TextBox ID="tbx_AddWriterName" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">BooksPage</label>
            <asp:TextBox ID="tbx_AddBooksPage" CssClass="form-control" runat="server"></asp:TextBox>
              
            <label for="exampleFormControlInput1">Photo</label>
            <asp:TextBox ID="tbx_AddPhoto" CssClass="form-control" runat="server"></asp:TextBox>

            <asp:Button ID="btn_Add" runat="server" CssClass="btn btn-success" Text="Add" OnClick="btn_Add_Click" />
          </div>

          <div class="col-lg-5">
             <label for="exampleFormControlInput1">Id</label>
            <asp:TextBox ID="tbx_UpdateId" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">CategoryId</label>
            <asp:TextBox ID="tbx_UpdateCategoryId" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">Name</label>
            <asp:TextBox ID="tbx_UpdateName" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">UnitPrice</label>
            <asp:TextBox ID="tbx_UpdateUnitPrice" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">UnitsInStock</label>
            <asp:TextBox ID="tbx_UpdateUnitsInStock" CssClass="form-control" runat="server"></asp:TextBox>

            <label for="exampleFormControlInput1">BooksPage</label>
            <asp:TextBox ID="tbx_UpdateBooksPage" CssClass="form-control" runat="server"></asp:TextBox>
            
            <label for="exampleFormControlInput1">WriterName</label>
            <asp:TextBox ID="tbx_UpdateWriterName" CssClass="form-control" runat="server"></asp:TextBox>
            
            <label for="exampleFormControlInput1">Photo</label>
            <asp:TextBox ID="tbx_UpdatePhoto" CssClass="form-control" runat="server"></asp:TextBox>

            <asp:Button ID="btn_Update" runat="server" CssClass="btn btn-warning" Text="Update" OnClick="btn_Update_Click" />
          </div>
      </div>
        </ContentTemplate>
    </asp:UpdatePanel>

        
</asp:Content>
