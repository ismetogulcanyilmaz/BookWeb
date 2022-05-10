using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KitapWeb.Site
{
    public partial class SiteBook : System.Web.UI.Page
    {
        IBookService _bookService;
        ICartService _cartService;
        public SiteBook()
        {
            _bookService = new BookManager();
            _cartService = new CartManager();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Grd_BookDtos.DataSource = _bookService.GetAllDtos().Data;
            Grd_BookDtos.DataBind();
        }

        protected void Grd_BookDtos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Grd_BookDtos.PageIndex = e.NewPageIndex;
            Grd_BookDtos.DataBind();
        }

        protected void Link_AddToCart_Command(object sender, CommandEventArgs e)
        {
            var bookId = Convert.ToInt32( e.CommandArgument);
            var userId = Convert.ToInt32(HttpContext.Current.Session["UserId"]);
            Cart cart = new Cart();
            cart.BookId= bookId;
            cart.UserId=userId;
            _cartService.Add(cart);
        }
    }
}