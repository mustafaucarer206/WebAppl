using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebAPP.Models.Sınıflar
{
    public class Context : DbContext

    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Adres> Adres { get; set; }
        
        public DbSet<Blog>Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimisdas { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }





    }
}