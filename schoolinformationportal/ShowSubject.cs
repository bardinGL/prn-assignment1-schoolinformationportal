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
        public ShowSubject()
        {
            InitializeComponent();
            var allSubject = _subjectRepository.GetAll();
            foreach(var subject in allSubject)
            {
                if(subject.ClassId == "SE0002")
                {
                    filteredSubjects.Add(subject);
                }
               
            }
            dgvSubject.DataSource = filteredSubjects;
            dgvSubject.Columns["Class"].Visible = false;
        }
    }
}
