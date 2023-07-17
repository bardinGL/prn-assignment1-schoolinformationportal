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
    public partial class ShowSubject_Admin : Form
    {
        SubjectRepository _subjectRepository = new SubjectRepository();
        List<Subject> _subjects = new List<Subject>();
        StudentInfoContext _studentInfoContext = new StudentInfoContext();
        public ShowSubject_Admin()
        {
            InitializeComponent();
            _subjects = new List<Subject>();
            _subjects = _subjectRepository.GetAll();
            dgvSubject.DataSource = new BindingSource() { DataSource = _subjects };
            dgvSubject.Columns["Class"].Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _studentInfoContext = new StudentInfoContext();
            var searchValue = txtSearch.Text;
            var list = _studentInfoContext.Subjects.Where(subject => subject.SubjectId.StartsWith(searchValue.ToUpper())).ToList();
            if (list.Count > 0)
            {
                dgvSubject.DataSource = new BindingSource() { DataSource = list };
            }
            else
            {
                MessageBox.Show("Subject Not Found!", "Notification", MessageBoxButtons.OK);
                var allSubjects = _subjectRepository.GetAll();
                dgvSubject.DataSource = new BindingSource() { DataSource = allSubjects };
            }
        }

        private void ReloadList()
        {
            _subjectRepository = new SubjectRepository();
            _subjects = _subjectRepository.GetAll();
            dgvSubject.DataSource = new BindingSource() { DataSource = _subjects };
            dgvSubject.Columns["Class"].Visible = false;
        }

        private void dgvSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
         
            if (e.RowIndex >= 0 && e.RowIndex < dgv.Rows.Count)
            {
                if (e.RowIndex == dgv.Rows.Count - 1 && dgv.Rows[e.RowIndex].IsNewRow)
                {
                    ReloadList();
                }
                else
                {
                    var subject = _subjects[e.RowIndex];
                    txtClassId.Text = subject.ClassId.ToString();
                    txtSubjectId.Text = subject.SubjectId.ToString();
                    rtxtDescription.Text = subject.Description.ToString();
                }
            }
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            ReloadList();
            txtSearch.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtClassId.Text = "";
            txtSubjectId.Text = "";
            rtxtDescription.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string classId = txtClassId.Text;
                string subjectId = txtSubjectId.Text;
                string description = rtxtDescription.Text;

                Subject subject = new Subject();
                subject.ClassId = classId;
                subject.SubjectId = subjectId;
                subject.Description = description;

                _subjectRepository = new SubjectRepository();
                _subjectRepository.Create(subject);
                dgvSubject.DataSource = new BindingSource() { DataSource = _subjectRepository.GetAll() };
                ReloadList();
                txtClassId.Text = "";
                txtSubjectId.Text = "";
                rtxtDescription.Text = "";
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
            if (MessageBox.Show("Do you want to remove this subject?", "Remove Subject", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Delete Cach 1
                string deletedId = txtSubjectId.Text;
                _subjectRepository.Delete(_subjects.FirstOrDefault(x => x.SubjectId.Equals(deletedId)));
                _subjects = _subjectRepository.GetAll();
                dgvSubject.DataSource = new BindingSource() { DataSource = _subjects };

                //Delete Cach 2
                var subject = _subjectRepository.GetAll().ToList()[dgvSubject.CurrentRow.Index];
                _subjectRepository.Delete(subject);

                ReloadList();

                txtClassId.Text = "";
                txtSubjectId.Text = "";
                rtxtDescription.Text = "";
            }
        }
    }
}
