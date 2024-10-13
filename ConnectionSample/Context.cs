using System;
using System.Collections.Generic;
using System.IdentityModel.Metadata;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Model;

namespace ConnectionSample
{
    public class Context : DbContext {
        public Context(Microsoft.EntityFrameworkCore.DbContextOptions uy) : base(uy) { } // строка подключения к БД
        public DbSet<Student> Students { get; set; }
    }

}
