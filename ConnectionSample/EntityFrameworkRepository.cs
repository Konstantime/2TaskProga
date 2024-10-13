using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ConnectionSample
{
    public class EntityFrameworkRepository<T> : 
        IRepository<T> where T : class, IDomainObject, new() {
        
        public Context _context { get; set; }
        
        //public EntityFrameworkRepository() {
        //    _context = new Context();
        //}
        public EntityFrameworkRepository() {
            // Создаем экземпляр DatabaseConnection с нужной строкой подключения
            string connectionString = "server=myserver;database=mydatabase;user id=myuser;password=mypassword;";
            using (var databaseConnection = new DatabaseConnection(connectionString)) {
                // Создаем экземпляр Context, передавая ему экземпляр DatabaseConnection
                using ( _context = new Context(databaseConnection)) {}
            }
        }

        public IEnumerable<T> GetStudentList() {
            return _context.Set<T>();
        }

        public Student GetStudent(int id) {
            return _context.Set<Student>().Find(id);
        }

        public void DeleteStudent(int id) {
            var student = GetStudent(id);
            if (student != null) {
                _context.Set<Student>().Remove(student);
                _context.SaveChanges();
            }
        }

        public void DeleteAllStudents() {
            var students = _context.Set<Student>().ToList();
            _context.Set<Student>().RemoveRange(students);
            _context.SaveChanges();
        }

        public void CreateStudent(T obj) {
            _context.Set<T>().Add(obj);
        }

        public void Save() {
            _context.SaveChanges();
        }

        public int GetCountStudents() {
            return _context.Set<T>().Count();
        }

        public void Dispose() {
            GC.SuppressFinalize(this);
        }
    }
}
