using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ConnectionSample
{
    internal class StudentRepositoryEF : IRepository
    {
        private readonly AppDbContext _dbContext;

        public StudentRepositoryEF(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Student>> GetAllStudent()
        {
            return await _dbContext.FindAsync<Student>();
        }

        public async Task<Student> GetStudentById(int id)
        {
            return await _dbContext.FindAsync(id);
        } 

        public async Task CreateStudent(Student student)
        {
            _dbContext.Employees.Add(student);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteStudent(int id)
        {
            var student = await _dbContext.Employees.FindAsync(id);
            _dbContext.Employees.Remove(student);
            await _dbContext.SaveChangesAsync();
        }
    }
}
