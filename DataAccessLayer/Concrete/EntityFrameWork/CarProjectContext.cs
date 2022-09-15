using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameWork
{
    public class CarProjectContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-PHRFHT3;Database=ReCapProject;Trusted_Connection=true");
        }
        public DbSet<Brand> Tb_Brand { get; set; }
        public DbSet<Car> Tb_Car { get; set; }
        public DbSet<Color> Tb_Color { get; set; }
        public DbSet<Users> Tb_User { get; set; }
        public DbSet<Customers> Tb_Customer { get; set; }
    }
}
