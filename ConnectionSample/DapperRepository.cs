using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace ConnectionSample {
    public class DapperRepository<T> :
            IRepository<T> where T : class, IDomainObject, new() {

        static string databaseFilePath = @"C:\Users\Kostya\source\repos\Semestr3\2TaskProga\ConnectionSample\Database1.mdf";
        static string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;" +
            $"AttachDbFilename={databaseFilePath};Integrated Security=True;";

        IDbConnection db = new SqlConnection(connectionString);

        public DapperRepository() { }

        public void CreateStudent(T t) {
            // SELECT CAST - функция, которая преобразует выражение одного типа данных в другой
            // FirstOrDefault - Возвращает первый элемент последовательности
            var sqlQuery = "INSERT INTO Students (Name, [Group], Speciality)" +
                "VALUES(@Name, @Group, @Speciality); SELECT CAST(SCOPE_IDENTITY() as int)";

            int studentID = db.Query<int>(sqlQuery, t).FirstOrDefault();
            t.Id = studentID;
        }

        public IEnumerable<T> GetStudentList() {
            return db.Query<T>("SELECT * FROM Students").ToList();
        }

        public Student GetStudent(int id) {
            var sqlQuery = "SELECT * FROM Students WHERE Id = @Id";
            return db.QueryFirstOrDefault<Student>(sqlQuery, new { Id = id });
        }

        public void DeleteStudent(int id) {
            var sqlQuery = "DELETE FROM Students WHERE Id = @Id";
            db.Execute(sqlQuery, new { Id = id });
        }

        public void DeleteAllStudents() {
            var sqlQuery = "DELETE FROM Students";
            db.Execute(sqlQuery);
        }

        public void CreateStudent(Student student) {
            var sqlQuery = "INSERT INTO Students (Name, [Group], Speciality) VALUES (@Name, @Group, @Speciality)";
            db.Execute(sqlQuery, new { Name = student.name, Group = student.group, Speciality = student.speciality });
        }

        public int GetCountStudents() {
            var sqlQuery = "SELECT COUNT(*) FROM Students";
            return db.QueryFirstOrDefault<int>(sqlQuery);
        }

        public void Dispose() {
            GC.SuppressFinalize(this);
        }

    }
}
