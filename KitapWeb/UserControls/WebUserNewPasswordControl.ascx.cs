using Business.Abstract;
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
    public partial class WebUserNewPasswordControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        IAuthService _authService = new AuthManager();
        ISecurityQuestionService _securityQuestionService = new SecurityQuestionManager();
        protected void Btn_NewPasswordPage_Click(object sender, EventArgs e)
        {
            var userEmail = Session["Email"].ToString();
            var userQuestion = Session["Question"].ToString();
            var userQuestionAnswer = Session["QuestionAnswer"].ToString();

            var question = _securityQuestionService.GetByQuestion(userQuestion).Data;

            UserSecurityQuestionDto userSecurityQuestionDto = new UserSecurityQuestionDto();
            userSecurityQuestionDto.UserEmail = userEmail;
            userSecurityQuestionDto.SecurityQuestion = userQuestion;
            userSecurityQuestionDto.SecurityQuestionAnswer = userQuestionAnswer;

            UserNewPasswordDto userNewPasswordDto = new UserNewPasswordDto();
            userNewPasswordDto.Password = tbx_NewPassword.Text;
            userNewPasswordDto.PasswordVerify = tbx_PasswordCheck.Text;

            var userCheck = _authService.UserCheck(userSecurityQuestionDto, userNewPasswordDto);

            Lbl_NewPasswordPage.Text = userCheck.Message;

            Response.Redirect("~/LoginForm/LoginPage");
        }
      

    }
}