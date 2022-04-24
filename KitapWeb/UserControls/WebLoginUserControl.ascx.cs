﻿using Business.Abstract;
using Business.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KitapWeb.UserControls
{
    public partial class WebLoginUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        IAuthService _authService = new AuthManager();
        protected void Btn_LoginPage_Click(object sender, EventArgs e)
        {
            UserForLoginDto userForLoginDto = new UserForLoginDto();
            userForLoginDto.Email = tbx_Email.Text;
            userForLoginDto.Password = tbx_Password.Text;

            var userLogin = _authService.Login(userForLoginDto);
             
            if (userLogin.Success)
            {
                var userAuthorities = _authService.GetUserAuthority(userLogin.Data).Data;
                string authorities = "";

                foreach (var authority in userAuthorities.Authorities)
                {
                    authorities += authority.AuthorityName + ",";
                }

                Session["Authorities"] = authorities;
                Response.Redirect("/Site/SiteBook.aspx");
            }
            Lbl_LoginPage.Text = userLogin.Message;
        }
        protected void LnkBtn_ForgotPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("/WebPage.aspx");
        }

        protected void LnkBtn_SignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("/WebPage.aspx");
        }
    }
}