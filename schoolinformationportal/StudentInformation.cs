using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
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

        List<Student> StudentList = new List<Student>();
        StudentRepository StudentRepo = new StudentRepository();


        public StudentInformation(String getClassIDtocheck, String getRoleIDtocheck)
        {
            InitializeComponent();
            StudentList = StudentRepo.GetAll();
            //txtStudentID.Text = getClassIDtocheck;
            StudentInfoContext _context = new StudentInfoContext();
            var studentList = _context.Students.Where(Student => Student.ClassId.Contains(getClassIDtocheck)).ToList();
            dataGridView1.DataSource = new BindingSource() { DataSource = studentList };

            foreach (var student in studentList)
            {
                if (student.StudentId == getRoleIDtocheck)
                {
                    txtStudentID.Text = student.StudentId.ToString();
                    txtStudentName.Text = student.StudentName.ToString();
                    txtStudentAge.Text = student.StudentAge.ToString();
                    txtStudentEmail.Text = student.StudentEmail.ToString();
                    txtStudentClass.Text = getClassIDtocheck;
                   
                }
            }


            //var studentName = _context.Students.Where(s => s.ClassId == getRoleIDtocheck).Select(s => s.StudentName).FirstOrDefault();
            //var studentAge = _context.Students.Where(s => s.ClassId == getRoleIDtocheck).Select(s => s.StudentAge).FirstOrDefault();
            //var studentEmail = _context.Students.Where(s => s.ClassId == getRoleIDtocheck).Select(s => s.StudentEmail).FirstOrDefault();

            //txtStudentID.Text = getRoleIDtocheck.ToString();
            //txtStudentName.Text = studentName;
            //txtStudentAge.Text = studentAge.ToString();
            //txtStudentClass.Text = getClassIDtocheck;
            //txtStudentEmail.Text = studentEmail;


        }

        private void StudentInformation_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStudentID.Text = "";
            txtStudentAge.Text = "";
            txtStudentName.Text = "";
            txtStudentEmail.Text = "";
            txtStudentClass.Text = "";
            var studentID = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            var studentName = dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            var studentAge = dataGridView1.Rows[e.RowIndex].Cells[2].Value;
            var studentEmail = dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            var studentClass = dataGridView1.Rows[e.RowIndex].Cells[4].Value;

            txtStudentID.Text = studentID.ToString();
            txtStudentAge.Text = studentAge.ToString();
            txtStudentName.Text = studentName.ToString();
            txtStudentEmail.Text = studentEmail.ToString();
            txtStudentClass.Text = studentClass.ToString();


        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
