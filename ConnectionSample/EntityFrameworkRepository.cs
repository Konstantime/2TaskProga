using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.SqlServer;

using Model;

namespace ConnectionSample
{
    public class EntityFrameworkRepository<T> : 
        IRepository<T> where T : class, IDomainObject, new() {
        
        public Context _context { get; set; }

        public EntityFrameworkRepository() {
            // Создание объекта DbContextOptionsBuilder
            var optionsBuilder = new DbContextOptionsBuilder<Context>();

            // Настройка опций для использования SQL Server с указанием пути к файлу базы данных
            string databaseFilePath = @"C:\Users\Kostya\source\repos\Semestr3\2TaskProga\ConnectionSample\Database1.mdf";
            optionsBuilder.UseSqlServer($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True;");

            // Получение объекта DbContextOptions
            var options = optionsBuilder.Options;

            _context = new Context(options);
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

        public int GetCountStudents() {
            return _context.Set<T>().Count();
        }

        public void Dispose() {
            GC.SuppressFinalize(this);
        }
    }
}
