using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace updateAndChangeState.model
{
    internal class context : DbContext
    {
        public context()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=test;Integrated Security=True;TrustServerCertificate=true;").LogTo(s => MyLogger.Log("adfasd" , s));
        }

        public virtual DbSet<course> Courses { get; set;}
        public virtual DbSet<student> Students { get; set;}
    }
}
