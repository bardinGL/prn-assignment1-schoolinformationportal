using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.Models;
using Service.Repository;

namespace schoolinformationportal
{
    public partial class StudentInformation : Form
    {
        List<Student> StudentList;
        
        public StudentInformation(String getClassIDtocheck)
        {
            InitializeComponent();
            txtStudentID.Text = getClassIDtocheck;
       StudentInfoContext _context = new StudentInfoContext();
            var studentList = _context.Students.Where(Student => Student.StudentId.Contains(getClassIDtocheck));
            dataGridView1.DataSource = new BindingSource() { DataSource = StudentList};
        }

        private void StudentInformation_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStudentID.Text = "";
            txtStudentName.Text = "";
            txtStudentAge.Text = "";
            txtStudentEmail.Text = "";
            txtStudentClass.Text = "";
            var index = e.RowIndex;
            var searchID = dataGridView1.Rows[index].Cells[0].Value.ToString();
        }
    }
}
