using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;

namespace ConnectionSample
{
    public class AppDbContext : DbContext
    {
        // Конструктор, принимающий настройки подключения к базе данных
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Свойства, представляющие таблицы в базе данных
        public DbSet<Student> YourEntities { get; set; }
    }
}
