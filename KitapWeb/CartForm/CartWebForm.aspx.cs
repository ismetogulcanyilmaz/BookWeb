using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KitapWeb.CartForm
{
    public partial class CartWebForm : System.Web.UI.Page
    {
        IBookService _bookService;
        IBookCategoryService _bookcategoryService;
        ICartService _cartService;
        IUserService _userService;
        IBookOrderService _bookorderService;
        ICustomerService _customerService;

        public CartWebForm()
        {
            _cartService = new CartManager();
            _userService = new UserManager();
            _bookService = new BookManager();
            _customerService = new CustomerManager();
            _bookcategoryService = new BookCategoryManager();
            _bookorderService = new BookOrderManager();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAll();
            GetCarts();
        }

        public void GetAll()
        {
            GridView1.DataSource = GetCarts();
            GridView1.DataBind();

            lbl_TotalPrice.Text = "TotalPrice: " + TotalPrice().ToString() + "TL";
        }

        public List<CartDto> GetCarts()
        {
            if (HttpContext.Current.Session["UserId"] != null)
            {
                var userId = Convert.ToInt32(HttpContext.Current.Session["UserId"]);
                var user = _userService.GetById(userId).Data;
                var result = _cartService.GetAllDtos(user);
                if (result.Success)
                {
                    return result.Data;
                }
            }
            return null;
        }

        public decimal TotalPrice()
        {
            decimal price = 0;
            if (GetCarts()==null)
            {
                return 0;
            }
            foreach (var cartItem in GetCarts())
            {
                price += cartItem.BookUnitPrice * cartItem.Quantity;
            }
            return price;
        }

        public List<BookCategory> GetAllBookCategories()
        {
            return _bookcategoryService.GetAll().Data;
        }

        protected void Lnk_Cart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CartForm/Cart");
        }

        protected void Link_DeleteToCart_Command(object sender, CommandEventArgs e)
        {
            var bookId = Convert.ToInt32(e.CommandArgument);

            Cart cart = new Cart();
            cart.BookId = bookId;
            cart.UserId = Convert.ToInt32(HttpContext.Current.Session["UserId"]);
            cart.Quantity = 1;

            _cartService.CartDelete(cart);
            Response.Redirect("~/CartForm/Cart");
        }

        protected void lnk_BookOrder_Click(object sender, EventArgs e)
        {
            var userCarts = GetCarts();
            var userId = Convert.ToInt32(HttpContext.Current.Session["UserId"]);
            foreach (var cartItem in userCarts)
            {
                BookOrder order = new BookOrder
                {
                    BookId = cartItem.BookId,
                    CustomerId = _customerService.GetByUserId(userId).Data.Id,
                    Quantity = cartItem.Quantity
                };
                _bookorderService.Add(order);

                var book = _bookService.GetById(cartItem.BookId).Data;
                book.UnitsInStock -= cartItem.Quantity;
                _bookService.Update(book);

                var cart = _cartService.GetById(cartItem.CartId).Data;
                _cartService.Delete(cart);
            }
            Response.Redirect("~/Site/SiteBook");
        }

        protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
    }
}