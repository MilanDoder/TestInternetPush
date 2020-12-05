using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomskiRad.Models
{
    public class ManufacturerContext :DbContext
    {
        public ManufacturerContext(DbContextOptions<ManufacturerContext> options): base(options)
        {

        }


        public DbSet<Manufacturer> Manufacturers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
           base.OnConfiguring(optionsBuilder);

           optionsBuilder.UseSqlite("/home/milan/Desktop/Net/SQl/Northwind.db");
        }
    }
}
