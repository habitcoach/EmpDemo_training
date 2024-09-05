using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDemo
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> DemoStudent { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>

          options.UseSqlServer("database=demoStudentTest;server=Endurance;" +
              "TrustServerCertificate=true;Persist Security Info=False;" +
              "Integrated Security=SSPI;"); 


    }
}
