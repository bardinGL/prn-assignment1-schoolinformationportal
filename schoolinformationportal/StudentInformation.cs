﻿using System;
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

        
        public StudentInformation(String getClassIDtocheck, String getEmailIDtocheck)
        {
            InitializeComponent();
            StudentList = StudentRepo.GetAll();
            //txtStudentID.Text = getClassIDtocheck;
            StudentInfoContext _context = new StudentInfoContext();
            var studentList = _context.Students.Where(Student => Student.ClassId.Contains(getClassIDtocheck)).ToList();
            dataGridView1.DataSource = new BindingSource() { DataSource = studentList};

            //foreach (var student in studentList)
            //{
            //    if (student.StudentEmail == getEmailIDtocheck)
            //    {
            //        txtStudentID.Text = student.StudentId.ToString();
            //        txtStudentName.Text = student.StudentName.ToString();
            //        txtStudentAge.Text = student.StudentAge.ToString();
            //        txtStudentEmail.Text = getEmailIDtocheck;
            //        txtStudentClass.Text = getClassIDtocheck;
            //        break;
            //    }
            //}

            var studentID = _context.Students.Where(Student => Student.StudentEmail == getEmailIDtocheck).Select(s => s.StudentId).FirstOrDefault();
            var studentName = _context.Students.Where(Student => Student.StudentEmail.Contains(getEmailIDtocheck)).Select(s => s.StudentName).FirstOrDefault();
            var studentAge = _context.Students.Where(Student => Student.StudentEmail.Contains(getEmailIDtocheck)).Select(s => s.StudentAge).FirstOrDefault();
            txtStudentID.Text = studentID;
            txtStudentName.Text = studentName;
            txtStudentAge.Text = studentAge.ToString();
            txtStudentClass.Text = getClassIDtocheck;
            txtStudentEmail.Text = getEmailIDtocheck;


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