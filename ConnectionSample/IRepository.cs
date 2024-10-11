using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ConnectionSample
{
    internal interface IRepository
    {
        Task<IEnumerable<Student>> GetAllStudent();
        Task<Student> GetStudentById(int id);
        Task CreateStudent(Student student);
        Task DeleteStudent(int id);
    }
}
