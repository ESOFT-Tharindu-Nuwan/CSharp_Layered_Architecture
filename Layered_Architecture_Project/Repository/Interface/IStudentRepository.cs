using Layered_Architecture_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layered_Architecture_Project.Repository.Interface
{
    public interface IStudentRepository
    {
        void AddStudent(StudentModel Student);

        List<StudentModel> GetStudents();
    }
}
