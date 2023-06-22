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
    public partial class ShowSubject : Form
    {
        SubjectRepository _subjectRepository = new SubjectRepository();
        BindingList<Subject> filteredSubjects = new BindingList<Subject>();
        StudentInfoContext _studentInfoContext = new StudentInfoContext();

        string getId;

        public ShowSubject(string getClassId)
        {
            InitializeComponent();
            var allSubject = _subjectRepository.GetAll();
            foreach(var subject in allSubject)
            {
                if(subject.ClassId == getClassId)
                {
                    filteredSubjects.Add(subject);
                }
               
            }

            getId = getClassId;

            dgvSubject.DataSource = filteredSubjects;
            dgvSubject.Columns["Class"].Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _studentInfoContext = new StudentInfoContext();
            var searchValue = txtSearch.Text;
            var list = _studentInfoContext.Subjects.Where(subject => subject.SubjectId.Equals(searchValue) && subject.ClassId == getId).ToList();

            if (list.Count > 0)
            {
                dgvSubject.DataSource = new BindingSource() { DataSource = list };
            }
            else
            {
                MessageBox.Show("Subject Not Found!", "Notification", MessageBoxButtons.OK);

                var filteredStudents = _subjectRepository.GetAll().Where(subject => subject.ClassId == getId).ToList();

                dgvSubject.DataSource = new BindingSource() { DataSource = filteredStudents };
                //    var listAll = studentRepository.GetAll();
                //    dgvClass.DataSource = new BindingSource() { DataSource = listAll };
            }
        }
    }
}
