using Business.Abstract;
using Business.Concrete;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KitapWeb.AdminWeb
{
    public partial class AdminUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        public void GetAll()
        {
            GridView1.DataSource = _userService.GetAll().Data;
            GridView1.DataBind();
        }

        IUserService _userService = new UserManager();

        protected void LnkBtn_Update_Command(object sender, CommandEventArgs e)
        {
            var userId = Convert.ToInt32(e.CommandArgument);
            var userToUpdate = _userService.GetById(userId).Data;

            tbx_UpdateId.Text = Convert.ToString(userToUpdate.Id);
            tbx_UpdateFirstName.Text = userToUpdate.FirstName;
            tbx_UpdateLastName.Text = userToUpdate.LastName;
            tbx_UpdateEmail.Text = Convert.ToString(userToUpdate.Email);
            tbx_UpdatePassword.Text = Convert.ToString(userToUpdate.Password);
            tbx_UpdateSecurityQuestionId.Text = Convert.ToString(userToUpdate.SecurityQuestionId);
            tbx_UpdateSecurityQuestionAnswer.Text = userToUpdate.SecurityQuestionAnswer;
            tbx_UpdateStatus.Text =tbx_UpdateStatus.Text;



            GetAll();
        }

        protected void LnkBtn_Delete_Command(object sender, CommandEventArgs e)
        {
            var userId = Convert.ToInt32(e.CommandArgument);
            var userToDelete = _userService.GetById(userId).Data;

            Delete(userToDelete);

            GetAll();
        }

        public void Delete(User user)
        {
            _userService.Delete(user);
        }
        protected void btn_Update_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Id = Convert.ToInt32(tbx_UpdateId.Text);
            user.FirstName = tbx_UpdateFirstName.Text;
            user.LastName = tbx_UpdateLastName.Text;
            user.Email = tbx_UpdateEmail.Text;
            user.Password = tbx_UpdatePassword.Text;
            user.SecurityQuestionId = Convert.ToInt32(tbx_UpdateSecurityQuestionId.Text);
            user.SecurityQuestionAnswer = tbx_UpdateSecurityQuestionAnswer.Text;
            user.Status = Convert.ToBoolean(tbx_UpdateStatus.Text);



            _userService.Update(user);
            GetAll();
        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.FirstName = tbx_AddFirstName.Text;
            user.LastName = tbx_AddLastName.Text;
            user.Email = tbx_UpdateEmail.Text;
            user.Password = tbx_UpdatePassword.Text;
            user.SecurityQuestionId = Convert.ToInt32(tbx_UpdateSecurityQuestionId.Text);
            user.SecurityQuestionAnswer = tbx_UpdateSecurityQuestionAnswer.Text;
            user.Status =Convert.ToBoolean(tbx_UpdateStatus.Text);

            _userService.Add(user);
            GetAll();
        }
    }
}