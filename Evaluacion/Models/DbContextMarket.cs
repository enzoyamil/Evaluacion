using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evaluacion.Models
{
    public class DbContextMarket:DbContext
    {
        public DbContextMarket(DbContextOptions<DbContextMarket> options) : base(options)
        {

        }
        //protected override void  OnConfiguring(DbContextOptionsBuilder builder)
        //{
          //  string cnx = "Server=DESKTOP-92J872H;Database=Product;Trusted_Connection=true;MultipleActiveResultSets=true";
           // builder.UseSqlServer(cnx).LogTo(Console.WriteLine,LogLevel.Information);
           // base.OnConfiguring(builder);
       // }
        public virtual DbSet<Product> product {get; set;}
    }
}
