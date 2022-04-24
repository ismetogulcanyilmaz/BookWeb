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
            route.MapPageRoute("Kayıt", "SignInForm/SignInPage", "~/SignInForm/SignInPage.aspx");
            route.MapPageRoute("Şifremi Hatırlat", "ForgotPassword/ForgotPassword", "~/ForgotPassword/ForgotPassword.aspx");
            route.MapPageRoute("Güvenlik Sorusu", "ForgotPassword/UserQuestion", "~/ForgotPassword/UserQuestion.aspx");
            route.MapPageRoute("Şifremi Değiştir", "ForgotPassword/NewPassword", "~/ForgotPassword/NewPassword.aspx");

            // Admin
            route.MapPageRoute("Book", "Admin/Book", "~/AdminWeb/AdminBook.aspx");
            route.MapPageRoute("BookCategory", "Admin/BookCategory", "~/AdminWeb/AdminBookCategory.aspx");
            route.MapPageRoute("Customer", "Admin/Customer", "~/AdminWeb/AdminCustomer.aspx");
            route.MapPageRoute("Dashboard", "Admin/Dashboard", "~/AdminWeb/AdminDashboard.aspx");
            route.MapPageRoute("BookOrder", "Admin/BookOrder", "~/AdminWeb/AdminBookOrder.aspx");
            route.MapPageRoute("Authority", "Admin/Authority", "~/AdminWeb/AdminAuthority.aspx");
            route.MapPageRoute("User", "Admin/User", "~/AdminWeb/AdminUser.aspx");
            route.MapPageRoute("UserAuthority", "Admin/UserAuthority", "~/AdminWeb/AdminUserAuthority.aspx");

            //User
            route.MapPageRoute("UserBook", "Site/SiteBook", "~/Site/SiteBook.aspx");
            route.MapPageRoute("UserBookCategory", "Site/SiteBookCategory", "~/Site/SiteBookCategory.aspx");
            route.MapPageRoute("UserBookOrder", "Site/SiteBookOrder", "~/Site/SiteBookOrder.aspx");
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