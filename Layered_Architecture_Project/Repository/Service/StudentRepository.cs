using Layered_Architecture_Project.Models;
using Layered_Architecture_Project.Repository.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layered_Architecture_Project.Repository.Service
{
    public class StudentRepository : IStudentRepository
    {
        string connectionString = "Server=DESKTOP-O15MUK7\\SQLEXPRESS;Database=db_student;Integrated Security=True;Encrypt=False";
        public void AddStudent(StudentModel Student)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "INSERT INTO students(name) VALUES(@name)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", Student.Name);
                command.ExecuteNonQuery();
            }
        }

        public List<StudentModel> GetStudents()
        {
            var Students = new List<StudentModel>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM students";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StudentModel student = new StudentModel
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name")
                        };

                        Students.Add(student);
                    }
                    return Students;
                }
            }
        }
    }
}
