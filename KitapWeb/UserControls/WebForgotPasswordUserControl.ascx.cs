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
    public partial class WebForgotPasswordUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        IAuthService _authService = new AuthManager();

        protected void Btn_ForgotPassword_Click(object sender, EventArgs e)
        {
            var result = _authService.UserExists(tbx_Email.Text);
            if (!result.Success)
            {
                Lbl_EmailError.Text = result.Message;
            }

            Session["Email"] = tbx_Email.Text;
            Response.Redirect("~/ForgotPassword/UserQuestion");
        }
    }
} 