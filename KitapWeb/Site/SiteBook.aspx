<%@ Page Title="" Language="C#" MasterPageFile="~/Site/Site.Master" AutoEventWireup="true" CodeBehind="SiteBook.aspx.cs" Inherits="KitapWeb.Site.SiteBook" %>


<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
      .hiddencol
      {
        display: none;
      }
    </style>

    <style>
 tr.GridPager td {
    height: 26px;
    width: 30px;
    margin: 0;
    padding: 0;
    border: 0;
}

.GridPager a, .GridPager span {
    display: block;
    width: 30px;
    height: 30px;
    font-weight: bold;
    text-align: center;
    text-decoration: none;
    margin: 0;
    padding: 0;
    font-size:80%;
}

.GridPager a {
    background-color: #f5f5f5;
    color: #969696;
    border: 1px solid #dddddd;
    height: 30px;
    font-size:80%;
}

.GridPager span {
    background-color: #ccdef4;
    color: #000;
    border: 3px solid #969696;
    height: 30px;
}
    </style>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="Books" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:GridView ID="Grd_BookDtos" runat="server" AutoGenerateColumns="false" AllowPaging="true" OnPageIndexChanging="Grd_BookDtos_PageIndexChanging" PagerStyle-CssClass="GridPager span"  Width="545%" PageSize="1" >
                <Columns>
                     
                    <asp:BoundField DataField="Id"  ItemStyle-CssClass="hiddencol" />
                    <asp:BoundField DataField="BookCategoryName" ItemStyle-CssClass="hiddencol"  />
                    <asp:BoundField DataField="Name"  ItemStyle-CssClass="hiddencol" />
                    <asp:BoundField DataField="UnitPrice" ItemStyle-CssClass="hiddencol"  />
                    <asp:BoundField DataField="UnitsInStock" ItemStyle-CssClass="hiddencol"  />
                    <asp:BoundField DataField="BooksPage" ItemStyle-CssClass="hiddencol"  />
                    <asp:BoundField DataField="WriterName" ItemStyle-CssClass="hiddencol"  />
                    <asp:BoundField DataField="Photo" ItemStyle-CssClass="hiddencol"  />

              
                    <asp:TemplateField>
                        <ItemTemplate>

                                        <div class="swiper-slide box">
                                            <div class="image">
                                                <img src="/image/<%#Eval("Photo")%>" alt="">
                                            </div>
                                            <div class="content">
                                                <h3><%#Eval("Name")%></h3>
                                                <h3><%#Eval("BookCategoryName")%></h3>
                                                <div class="price"><%#Eval("UnitPrice")%> TL</div>  
                                                <h3><%#Eval("UnitsInStock")%> Adet</h3>
                                                <h3><%#Eval("BooksPage")%> Sayfa</h3>
                                                <h3><%#Eval("WriterName")%></h3>
                                                <asp:LinkButton ID="Link_AddToCart" CssClass="btn" Width="100%" OnCommand="Link_AddToCart_Command" CommandArgument='<%#Eval("Id")%>' runat="server">AddToCart</asp:LinkButton>
                                            </div>
                                            </div>
                        </ItemTemplate> 
                    </asp:TemplateField>

                </Columns>
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
