using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using schoolinformationportal;
using Service.Models;
using Service.Repository;
//using Repository.Models;
//using Services.ServicesBase;

namespace PE_PRN
{
    public partial class Login : Form
    {
        AccountRepository repositoryBase = new AccountRepository();
        //UserServices userService = new UserServices();
        public Login()
        {
            InitializeComponent();
            var userList = repositoryBase.GetAll();
//            var userList = userService.GetAll();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            var check = repositoryBase.GetAll().Where(p =>
            p.Password.Equals(username) &&
            p.Email.Equals(password));
            //p.UserRole == 1)
                //.FirstOrDefault();

            if (check != null)
            {
                this.Hide();
                //Management management = new Management();
                //management.Show();

            }
            else
            {
                MessageBox.Show("You are not allowed to access this function!",
                    "Notification",
                    MessageBoxButtons.OK);
            }
            btnLogin.Enabled = true;

        }
    }
}
