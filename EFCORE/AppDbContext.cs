using EntityFramwork.ETT;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Hocvien> hocviens { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=TUANNM\\TUANNM; database = quanlyhocvien; integrated security = sspi; encrypt = true; trustservercertificate = true;");
        }
    }
}
