using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental_App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CarRental_App.Data
{
    public class CarRentalContext : DbContext
    {
        public CarRentalContext(DbContextOptions<CarRentalContext> options) : base(options)
        {

        }

        public DbSet<Auto> Autos { get; set; }
        public DbSet<Automodel> Automodels {get; set;}
        public DbSet<Categorie> Categorieën {get; set;}
        public DbSet<Klant> Klanten {get; set;}
        public DbSet<Merk> Merken { get; set;}
        public DbSet<Reservatie> Reservaties { get; set;}
        public DbSet<ReservatieCategorie> ReservatieCategorieën { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Auto>().ToTable("Auto");
            modelBuilder.Entity<Automodel>().ToTable("Automodel");
            modelBuilder.Entity<Categorie>().ToTable("Categorie");
            modelBuilder.Entity<Categorie>().ToTable("Categorie").Property(p =>
                p.PrijsPerDag).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Klant>().ToTable("Klant");
            modelBuilder.Entity<Klant>().Property(p => p.Voornaam).IsRequired();
            modelBuilder.Entity<Klant>().Property(p => p.Achternaam).IsRequired();
            modelBuilder.Entity<Merk>().ToTable("Merk");
            modelBuilder.Entity<Reservatie>().ToTable("Reservatie");
            modelBuilder.Entity<ReservatieCategorie>().ToTable("ReservatieCategorieën");
        }
    }
}
