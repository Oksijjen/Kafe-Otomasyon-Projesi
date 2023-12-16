using KafeProjesi.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace KafeProjesi.DataAccess.Concrate.EntityFramework.context
{
    public class KafeVeriTabanıDbContext:DbContext
    {
        public DbSet<Urun> Urun { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Ustkategori> Ustkategori { get; set; }
        public DbSet<Boyutlar> Boyutlar { get; set; }
        public DbSet<Masalar> Masalar { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-7T2GG7O;database=KafeVeriTabanı;trusted_connection=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
