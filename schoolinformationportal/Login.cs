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
        {   if (radioButton1.Checked)
            {







            }
            else {

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
                    StudentInfoContext _studentInfoContext = new StudentInfoContext();
                    var StudentName = (from a in _studentInfoContext.Accounts
                                       join
                                   c in _studentInfoContext.Students on a.Email equals c.StudentEmail
                                       where c.StudentEmail == username
                                       select c.StudentName).SingleOrDefault();
                    var roleID = (from a in _studentInfoContext.Accounts
                                  join
                                   c in _studentInfoContext.Students on a.Email equals c.StudentEmail
                                  where c.StudentEmail == username
                                  select c.StudentId).SingleOrDefault();

                    var fullname = (from a in _studentInfoContext.Accounts
                                    join
                                c in _studentInfoContext.Students on a.Email equals c.StudentEmail
                                    where c.StudentEmail == username
                                    select c.StudentName).SingleOrDefault();

                    var ClassID = (from a in _studentInfoContext.Accounts
                                   join
                               c in _studentInfoContext.Students on a.Email equals c.StudentEmail
                                   where c.StudentEmail == username
                                   select c.ClassId).SingleOrDefault();
                    this.Hide();
                    Form1 form1 = new Form1(roleID, fullname, ClassID);
                    form1.Show();
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
}
