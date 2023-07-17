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
    public partial class StudentInformation_Admin : Form
    {
        StudentRepository studentRepository = new StudentRepository();
        List<Student> _studentList = new List<Student>();
        StudentInfoContext _studentInfoContext = new StudentInfoContext();

        ClassRepository classRepository = new ClassRepository();

        AccountRepository accountRepository = new AccountRepository();


        public StudentInformation_Admin()
        {
            InitializeComponent();
            _studentList = new List<Student>();
            _studentList = studentRepository.GetAll();
            dgvStudentAdmin.DataSource = new BindingSource() { DataSource = _studentList};

            txtStudentID.ReadOnly = true;

            // Hide the 'Class' column
            dgvStudentAdmin.Columns["Class"].Visible = false;

            // Hide the 'Major' column
            dgvStudentAdmin.Columns["Major"].Visible = false;

            // Hide the 'StudentEmailNavigation' column
            dgvStudentAdmin.Columns["StudentEmailNavigation"].Visible = false;

            // Hide the 'Applications' column
            dgvStudentAdmin.Columns["Applications"].Visible = false;

        }


        private void ReloadList()
        {
            //classRepository = new ClassRepository();
            studentRepository = new StudentRepository();

            //_studentList = studentRepository.GetAll()
            //.Select(p =>
            // {
            //     p.Class = classRepository.GetAll().FirstOrDefault(t => t.ClassId == p.ClassId);
            //     return p;
            // })
            //.ToList();

            //var list = studentRepository.GetAll();
            //var selectedList = list.Select(p => new { p.StudentId, p.StudentName, p.StudentAge, p.StudentEmail, p.MajorId, p.ClassId }).ToList();

            //dgvStudentAdmin.DataSource = new BindingSource() { DataSource = selectedList };

            //txtStudentID.ReadOnly = true;

            _studentList = studentRepository.GetAll();
            dgvStudentAdmin.DataSource = new BindingSource() { DataSource = _studentList };

            txtStudentID.ReadOnly = true;

            // Hide the 'Class' column
            dgvStudentAdmin.Columns["Class"].Visible = false;

            // Hide the 'Major' column
            dgvStudentAdmin.Columns["Major"].Visible = false;

            // Hide the 'StudentEmailNavigation' column
            dgvStudentAdmin.Columns["StudentEmailNavigation"].Visible = false;

            // Hide the 'Applications' column
            dgvStudentAdmin.Columns["Applications"].Visible = false;
        }


        private void dgvStudentAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            //if (e.RowIndex == dgv.Rows.Count - 1 || e.RowIndex == -1)
            //{
            //    ReloadList();
            //}
            if (e.RowIndex >= 0 && e.RowIndex < dgv.Rows.Count)
            {
                if (e.RowIndex == dgv.Rows.Count - 1 && dgv.Rows[e.RowIndex].IsNewRow)
                {
                    ReloadList();
                }
                else
                {
                    var student = _studentList[e.RowIndex];
                    txtStudentID.Text = student.StudentId.ToString();
                    txtStudentName.Text = student.StudentName.ToString();
                    nudAge.Value = student.StudentAge;
                    txtEmail.Text = student.StudentEmail.ToString();
                    txtMajorID.Text = student.MajorId.ToString();
                    txtClassID.Text = student.ClassId.ToString();
                }
            }



            //else
            //{
            //    var student = _studentList[e.RowIndex];
            //    txtStudentID.Text = student.StudentId.ToString();
            //    txtStudentName.Text = student.StudentName.ToString();
            //    nudAge.Value = student.StudentAge;
            //    txtEmail.Text = student.StudentEmail.ToString();
            //    txtMajorID.Text = student.MajorId.ToString();
            //    txtClassID.Text = student.ClassId.ToString();
            //}

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtStudentID.Text = "";
            txtStudentName.Text = "";
            nudAge.Value = 18;
            txtEmail.Text = "";
            txtMajorID.Text = "";
            txtClassID.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _studentInfoContext = new StudentInfoContext();
            var searchValue = txtSearchID.Text;
            var list = _studentInfoContext.Students.Where(student => student.StudentId.Equals(searchValue)).ToList();
            
            if (list.Count > 0)
            {
                dgvStudentAdmin.DataSource = new BindingSource() { DataSource = list };
            }
            else
            {
                MessageBox.Show("Student Not Found!", "Notification", MessageBoxButtons.OK);
                var studentAllList = studentRepository.GetAll();
                dgvStudentAdmin.DataSource = new BindingSource() { DataSource = studentAllList };
            }
            

        }

        private void btnSearchReset_Click(object sender, EventArgs e)
        {
            var studentAllList = studentRepository.GetAll();
            dgvStudentAdmin.DataSource = new BindingSource() { DataSource = studentAllList };
            txtSearchID.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                Validation validation = new Validation();

                

                string studentName = txtStudentName.Text;
                string studenId = validation.createStudentID("SE", studentName);
                //string studenId = "SE69";

                int studentAge = (int) nudAge.Value;
                //string email = txtEmail.Text;
                string majorId = txtMajorID.Text;
                string classId = txtClassID.Text;

                //Student student = new Student
                //{
                //    StudentId = studenId,
                //    StudentName = studentName,
                //    StudentAge = studentAge,
                //    StudentEmail = email,
                //    MajorId = majorId,
                //    ClassId = classId,
                //};

                string password = validation.createPassword(studentName);
                string email = validation.createEmail(studenId);

                Account account = new Account();

                account.Email = email;
                account.Password = password;

                

                Student student = new Student();

                student.StudentId = studenId;
                student.StudentName = studentName;
                student.StudentAge = studentAge;
                student.StudentEmail = email;
                student.MajorId = majorId;
                student.ClassId = classId;

                //foreach (Student stu in _studentList)
                //{
                //    if (stu.StudentId.Equals(student.StudentId))
                //    {

                //    }
                //}

                StudentRepository _studentRepository = new StudentRepository();
                accountRepository.Create(account);
                _studentRepository.Create(student);

                dgvStudentAdmin.DataSource = new BindingSource() { DataSource = _studentRepository.GetAll() };
                ReloadList();
                txtStudentID.Text = "";
                txtStudentName.Text = "";
                nudAge.Value = 18;
                txtEmail.Text = "";
                txtMajorID.Text = "";
                txtClassID.Text = "";
            }
            catch (Exception ex)
            {
                string message = ex.InnerException.Message;
                MessageBox.Show(message, "Notification", MessageBoxButtons.OK);
                Console.WriteLine(message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to remove this student?", "Remove Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Delete Cach 1
                string deletedId = txtStudentID.Text;
                studentRepository.Delete(_studentList.FirstOrDefault(x => x.StudentId.Equals(deletedId)));
                _studentList = studentRepository.GetAll();
                dgvStudentAdmin.DataSource = new BindingSource() { DataSource = _studentList };

                //Delete Cach 2
                var student = studentRepository.GetAll().ToList()[dgvStudentAdmin.CurrentRow.Index];
                studentRepository.Delete(student);

                ReloadList();

                txtStudentID.Text = "";
                txtStudentName.Text = "";
                nudAge.Value = 18;
                txtEmail.Text = "";
                txtMajorID.Text = "";
                txtClassID.Text = "";
            }
        }
    }
}
