using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppModel = Service.Models.Application;
using WindowsApp = System.Windows.Forms.Application;
using Service.Repository;
using Service.Models;

namespace schoolinformationportal
{
    public partial class Applicant : Form
    {
        List<Applicant> applicationList = new List<Applicant>();
        ApplicationRepository applicationRepository = new ApplicationRepository();
        StudentInfoContext _studentInfoContext = new StudentInfoContext();

        public Applicant()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvApplication_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String searchValue = txtSearchValue.Text.Trim().ToLower();

            if (String.IsNullOrEmpty(searchValue))
            {
                dgvApplication.DataSource = applicationRepository.GetAll();
            }
            else
            {
                List<AppModel> applications;
                applications = applicationRepository.GetAll().Where(b => b.StudentId.ToLower().Contains(searchValue)).ToList();
                dgvApplication.DataSource = applications;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
