using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
      public StoreContext(DbContextOptions option):base(option)  
      {


      }
      public DbSet<Product> Products{ get; set;}
    }
}