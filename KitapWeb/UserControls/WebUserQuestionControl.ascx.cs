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
    public partial class WebUserQuestionControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var userEmail = Session["Email"].ToString();
                var userSecurityQuestionDto = _userService.GetUserSecurityQuestion(userEmail);

                if (!userSecurityQuestionDto.Success)
                {
                    Lbl_UserQuestionPage.Text = userSecurityQuestionDto.Message;
                    Response.Redirect("~/SignInForm/SignInPage");
                }

                Session["Question"] = userSecurityQuestionDto.Data.SecurityQuestion;

                Lbl_UserEmail.Text = userEmail;
                Lbl_UserQuestion.Text = userSecurityQuestionDto.Data.SecurityQuestion;
            }
        }

        IUserService _userService = new UserManager();

        protected void Btn_UserQuestionPage_Click(object sender, EventArgs e)
        {
            var userEmail = Session["Email"].ToString();
            var userSecurityQuestionDto = _userService.GetUserSecurityQuestion(userEmail);

            var userQuestionAnswer = tbx_UserAnswer.Text;

            if (userQuestionAnswer == userSecurityQuestionDto.Data.SecurityQuestionAnswer)
            {
                Session["QuestionAnswer"] = userQuestionAnswer;
                Response.Redirect("~/ForgotPassword/NewPassword");
            }
            Lbl_UserQuestionPage.Text = "Tekrar Deneyiniz.";
        }
    }
}
