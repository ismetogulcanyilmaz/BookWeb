using Business.Abstract;
using Business.Concrete;
using Core.Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KitapWeb.UserControls
{
    public partial class WebSignInUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList_SecurityQuestions.DataSource = GetAllQuestions();
                DropDownList_SecurityQuestions.DataBind();
            }
        }

        private List<ListItem> GetAllQuestions()
        {
            var securityQuestions = _securityQuestionService.GetAll().Data;

            List<ListItem> list = new List<ListItem>();

            foreach (var question in securityQuestions)
            {
                ListItem item = new ListItem();
                item.Text = question.Question;
                item.Value = Convert.ToString(question.Id);

                list.Add(item);
            }

            return list;
        }

        IAuthService _authService = new AuthManager();

        ISecurityQuestionService _securityQuestionService = new SecurityQuestionManager();

        protected void Btn_SignInPage_Click(object sender, EventArgs e)
        {
            UserForRegisterDto userForRegisterDto = new UserForRegisterDto();

            userForRegisterDto.FirstName = tbx_FirstName.Text;
            userForRegisterDto.LastName = tbx_LastName.Text; 
            userForRegisterDto.Email = tbx_Email.Text;
            userForRegisterDto.Password = tbx_Password.Text;

            UserSecurityQuestionDto userSecurityQuestionDto = new UserSecurityQuestionDto();

            userSecurityQuestionDto.SecurityQuestion = DropDownList_SecurityQuestions.SelectedItem.Text;
            userSecurityQuestionDto.SecurityQuestionAnswer = tbx_QuestionAnswer.Text;

            var result = _authService.Register(userForRegisterDto, userSecurityQuestionDto);

            UserAuthority userAuthority = new UserAuthority();
            userAuthority.AuthorityId = 1;
            userAuthority.UserId = result.Data.Id; 
            
            _authService.AddUserAuthority(userAuthority);

            if (result.Success)
            {
                Lbl_SignIn.Text = result.Message;
                Response.Redirect("/LoginForm/LoginPage");
            }
            
            Lbl_SignIn.Text = result.Message;
        }
    }
}