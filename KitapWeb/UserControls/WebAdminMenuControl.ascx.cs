using Business.Abstract;
using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KitapWeb.UserControls
{
    public partial class WebAdminMenuControl : System.Web.UI.UserControl
    {
        IAuthService authService = new AuthManager();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Authorities"] == null)
            {
                Response.Redirect("~/Site/SiteBook");
            }

            if (Session["Authorities"] != null)
            {
                var userAuthorities = Session["Authorities"].ToString();
                var authorities = userAuthorities.Split(',');

                if (!authorities.Contains("Admin"))
                {
                    Response.Redirect("~/Site/SiteBook");
                }

                MenuAdminManager menuAdminManager = new MenuAdminManager();

                var menus = menuAdminManager.GetAll().Data;

                string myMenu = "";

                foreach (var menu in menus)
                {
                    myMenu += "<li>";
                    myMenu += "<a href = " + "" + menu.Name + " ><i class='fa fa-table'></i> " + " " + menu.Name + "</a>";
                    myMenu += "</li>";
                }
                Ltl_Menu.Text = myMenu;
            }
        }
    }
}