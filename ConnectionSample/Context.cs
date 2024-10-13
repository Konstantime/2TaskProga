using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;

namespace ConnectionSample
{
    //public class Context : DbContext
    //{
    //    public Context() : base("DbConnection") { } // строка подключения к БД

    //    public DbSet<Student> Students { get; set; } // набор объектов хранящихся в БД
    //}

    public class Context : DbContext {
        private readonly DatabaseConnection _databaseConnection;

        public Context(DatabaseConnection databaseConnection) {
            _databaseConnection = databaseConnection;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer(_databaseConnection.GetConnection().ConnectionString);
            }
        }

        public DbSet<Student> Students { get; set; }
    }

}
