using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Singleton.Data
{
    public class MyFileDatabase : DbContext
    {
        public MyFileDatabase()
        {
            //Якщо файла БД немає, то його створити
            Database.EnsureCreated();
        }
        public DbSet<Girl> Girls { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source=myData.sqlite;");
        }
    }
}
