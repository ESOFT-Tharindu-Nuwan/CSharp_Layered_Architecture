using Layered_Architecture_Project.Models;
using Layered_Architecture_Project.Repository.Interface;
using Layered_Architecture_Project.Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layered_Architecture_Project.Forms
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var student = new StudentModel
            {
                Name = txtName.Text
            };

            IStudentRepository studentRepository = new StudentRepository();
            studentRepository.AddStudent(student);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
