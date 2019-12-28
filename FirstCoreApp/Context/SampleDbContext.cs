using FirstCoreApp.Context.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Context
{
    public class SampleDbContext : DbContext
    {

        public DbSet<Department> Departments { get; set; }

        public DbSet<Designation> Designations { get; set; }

    }
}
