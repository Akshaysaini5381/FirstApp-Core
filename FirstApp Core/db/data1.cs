using FirstApp_Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp_Core.db
{
    public class data1:DbContext
    {
       public data1(DbContextOptions<data1>options):base(options)
        {

        }


        public DbSet<student> students { get; set; }
    }
}
