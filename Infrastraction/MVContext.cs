using Infrastraction.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastraction
{
    public class MVContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-BF349LE\\SQLEXPRESS; database = MovieDataBase;integrated security = true;MultipleActiveResultSets=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        //    modelBuilder.Entity<Movie>()
        //.HasMany(m => m.Actors)
        //.WithMany(a => a.Movies)
        //.UsingEntity(j => j.ToTable("MovieActor"));

        //    // configure many-to-many relationship between Movie and Theater entities
        //    modelBuilder.Entity<Movie>()
        //        .HasMany(m => m.Threaters)
        //        .WithMany(t => t.Movies)
        //        .UsingEntity(j => j.ToTable("MovieTheater"));


        //    // configure primary key for Actor entity
        //    modelBuilder.Entity<Actor>()
        //        .HasKey(a => a.Id);
        //    base.OnModelCreating(modelBuilder);
        }
        DbSet<Actor> Actors { get; set; }
        DbSet<Movie> Movies { get; set; }
        DbSet<UserProfile> Profiles { get; set; }
        DbSet<Threater> Threaters { get; set; }
    }
}
