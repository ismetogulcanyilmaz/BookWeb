using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace KitapWeb
{
    public class Global : System.Web.HttpApplication
    {

        void RouteUser(RouteCollection route)
        {
            route.MapPageRoute("Giriş", "LoginForm/LoginPage", "~/LoginForm/LoginPage.aspx");
            route.MapPageRoute("Kayıt", "Register/Register", "~/Register/Register.aspx");
            route.MapPageRoute("Şifremi Hatırlat", "PasswordReminder/PasswordReminder", "~/PasswordReminder/PasswordReminder.aspx");
            route.MapPageRoute("Güvenlik Sorusu", "PasswordReminder/Question/{Email}", "~/PasswordReminder/Question.aspx");
            route.MapPageRoute("Şifremi Değiştir", "PasswordReminder/PasswordChange", "~/PasswordReminder/PasswordChange.aspx");

            // Admin
            route.MapPageRoute("Book", "Admin/Book", "~/AdminWeb/AdminBook.aspx");
            route.MapPageRoute("BookCategory", "Admin/BookCategory", "~/AdminWeb/AdminBookCategory.aspx");
            route.MapPageRoute("Customer", "Admin/Customer", "~/AdminWeb/AdminCustomer.aspx");
            route.MapPageRoute("Dashboard", "Admin/Dashboard", "~/AdminWeb/AdminDashboard.aspx");
            route.MapPageRoute("BookOrder", "Admin/BookOrder", "~/AdminWeb/AdminBookOrder.aspx");
            route.MapPageRoute("Authority", "Admin/Authority", "~/AdminWeb/AdminAuthority.aspx");
            route.MapPageRoute("User", "Admin/User", "~/AdminWeb/AdminUser.aspx");
            route.MapPageRoute("UserAuthority", "Admin/UserAuthority", "~/AdminWeb/AdminUserAuthority.aspx");

            // User
            //route.MapPageRoute("Product", "User/Product", "~/User/Product.aspx");
            //route.MapPageRoute("Category", "User/Category", "~/User/Category.aspx");
            //route.MapPageRoute("Order", "User/Order", "~/User/Order.aspx");
            //route.MapPageRoute("Cart", "User/Cart", "~/User/Cart.aspx");
        }


        protected void Application_Start(object sender, EventArgs e)
        {
            RouteUser(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}