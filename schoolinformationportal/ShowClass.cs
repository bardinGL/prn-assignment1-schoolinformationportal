using Service.Models;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schoolinformationportal
{
    public partial class ShowClass : Form
    {
        StudentRepository studentRepository = new StudentRepository();
        StudentInfoContext _studentInfoContext = new StudentInfoContext();
        List<Student> _studentList = new List<Student>();

        BindingList<Student> filteredStudents = new BindingList<Student>();
        public ShowClass()
        {
            InitializeComponent();
            //_studentList = _studentInfoContext.Classes.Where(Class => Class.ClassId.Contains()).ToString();
            //_studentList = studentRepository.GetAll().Where(student => student.Class != null && student.Class.ClassId == "SE0001").ToList();
            //var listStudent = studentRepository.GetAll();

            //dgvClass.DataSource = new BindingSource() { DataSource = _studentList };



            var allStudents = studentRepository.GetAll();
            foreach (var student in allStudents)
            {
                if (student.ClassId == "SE0002")
                {
                    filteredStudents.Add(student);
                }
            }

            // Set the filtered students as the data source for the DataGridView
            dgvClass.DataSource = filteredStudents;


            // Hide the 'Class' column
            dgvClass.Columns["Class"].Visible = false;

            // Hide the 'Major' column
            dgvClass.Columns["Major"].Visible = false;

            // Hide the 'StudentEmailNavigation' column
            dgvClass.Columns["StudentEmailNavigation"].Visible = false;

            // Hide the 'Applications' column
            dgvClass.Columns["Applications"].Visible = false;


        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            _studentInfoContext = new StudentInfoContext();
            var searchValue = txtSearchID.Text;
            var list = _studentInfoContext.Students.Where(student => student.StudentId.Equals(searchValue) && student.ClassId == "SE0002").ToList();

            if(list.Count > 0)
            {
                dgvClass.DataSource = new BindingSource() { DataSource = list };
            }
            else
            {
                MessageBox.Show("Student Not Found!","Notification",MessageBoxButtons.OK);

                var filteredStudents = studentRepository.GetAll() .Where(student => student.ClassId == "SE0002").ToList();

                dgvClass.DataSource = new BindingSource() { DataSource = filteredStudents };
                //    var listAll = studentRepository.GetAll();
                //    dgvClass.DataSource = new BindingSource() { DataSource = listAll };
            }
        }

        private void viewSubj_Click(object sender, EventArgs e)
        {
            Form frSubject = new ShowSubject();
            frSubject.ShowDialog();
        }
    }
}
