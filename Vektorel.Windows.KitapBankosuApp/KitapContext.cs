using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Vektorel.Windows.KitapBankosuApp.Models;

namespace Vektorel.Windows.KitapBankosuApp
{
    public class KitapContext:DbContext
    {
        public KitapContext():base("Data Source=.;Initial Catalog=KitapBankosuDb;Integrated Security=true") 
        {

        }
        public DbSet<Yazar> Yazarlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Fluent Api
            modelBuilder.Entity<Yazar>().ToTable("tblYazarlar");
            modelBuilder.Entity<Yazar>().Property(yz => yz.YazarAd).HasColumnName("yazarad").HasMaxLength(75).IsRequired().HasColumnType("varchar");
            
        }

    }
}