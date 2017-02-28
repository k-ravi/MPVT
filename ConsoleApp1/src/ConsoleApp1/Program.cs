using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DataBaseContext : DbContext
    {
        public DbSet<MyModel> MyModels { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        { }
    }
    public class MyModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
        
        }
    }
}
