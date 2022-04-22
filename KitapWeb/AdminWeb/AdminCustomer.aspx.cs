using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KitapWeb.AdminWeb
{
    public partial class AdminCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        public void GetAll()
        {
            GridView1.DataSource = _customerService.GetAll().Data;
            GridView1.DataBind();
        }

        ICustomerService _customerService = new CustomerManager();

        protected void LnkBtn_Update_Command(object sender, CommandEventArgs e)
        {
            var customerId = Convert.ToInt32(e.CommandArgument);
            var customerToUpdate = _customerService.GetById(customerId).Data;

            tbx_UpdateId.Text = Convert.ToString(customerToUpdate.Id);
            tbx_UpdateFirstName.Text = customerToUpdate.FirstName;
            tbx_UpdateLastName.Text = customerToUpdate.LastName;
            tbx_UpdateAddress.Text = Convert.ToString(customerToUpdate.Address);
            tbx_UpdateCityName.Text = Convert.ToString(customerToUpdate.CityName);
            tbx_UpdatePhoneNumber.Text = Convert.ToString(customerToUpdate.PhoneNumber);
            tbx_UpdateEmail.Text = Convert.ToString(customerToUpdate.Email);

            GetAll();
        }

        protected void LnkBtn_Delete_Command(object sender, CommandEventArgs e)
        {
            var customerId = Convert.ToInt32(e.CommandArgument);
            var customerToDelete = _customerService.GetById(customerId).Data;

            Delete(customerToDelete);

            GetAll();
        }

        public void Delete(Customer customer)
        {
            _customerService.Delete(customer);
        }
        protected void btn_Update_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Id = Convert.ToInt32(tbx_UpdateId.Text);
            customer.FirstName = tbx_UpdateFirstName.Text;
            customer.LastName = tbx_UpdateLastName.Text;
            customer.Address = tbx_UpdateAddress.Text;
            customer.PhoneNumber = tbx_UpdatePhoneNumber.Text;
            customer.Email = tbx_UpdateEmail.Text;



            _customerService.Update(customer);
            GetAll();
        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FirstName = tbx_AddFirstName.Text;
            customer.LastName = tbx_AddLastName.Text;
            customer.Address = tbx_UpdateAddress.Text;
            customer.PhoneNumber = tbx_UpdatePhoneNumber.Text;
            customer.Email = tbx_UpdateEmail.Text;

            _customerService.Add(customer);
            GetAll();
        }
    }
}