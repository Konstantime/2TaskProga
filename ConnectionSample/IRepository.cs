using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ConnectionSample
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> GetStudentList();
        Student GetStudent(int id);
        void CreateStudent(T student);
        void DeleteStudent(int id);
        void DeleteAllStudents();

        int GetCountStudents();

    }
}
