using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.IO;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Repo
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext> 
    { 
        public ApplicationDbContext CreateDbContext(string[] args) 
        { 
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(@Directory.GetCurrentDirectory() + "/../MVCPhoneServiceWeb/appsettings.json").Build(); 
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>(); 
            var connectionString = configuration.GetConnectionString("DefaultConnection"); 
            builder.UseSqlServer(connectionString); 
            return new ApplicationDbContext(builder.Options); 
        } 
    }
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<MobilePhone> MobilePhones { get; set; }
        public DbSet<PhoneLine> PhoneLines { get; set; }
        public DbSet<Employee> Employees { get; set; }
        // public DbSet<MobilePhoneWithLine> MobilePhoneWithLines { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<MobilePhoneWithLine>()
                .HasKey(t => new {t.PhoneNumber, t.IMEI});
            builder.Entity<MobilePhoneWithLine>()
                .HasOne(mp => mp.MobilePhone)
                .WithMany(mpl => mpl.MobilePhoneWithLines)
                .HasForeignKey(mp => mp.IMEI);
            builder.Entity<MobilePhoneWithLine>()
                .HasOne(pl => pl.PhoneLine)
                .WithMany(mpl => mpl.MobilePhoneWithLines)
                .HasForeignKey(mp => mp.PhoneNumber);

            builder.Entity<MobilePhoneEmployee>()
                .HasKey(a => a.IMEI);
            builder.Entity<MobilePhoneEmployee>()
                .HasOne(a => a.MobilePhone)
                .WithMany(a => a.MobilePhoneEmployee)
                .HasForeignKey(b => b.IMEI);
            builder.Entity<MobilePhoneEmployee>()
            .HasOne(a => a.Employee)
            .WithMany(a => a.MobilePhoneEmployees)
            .HasForeignKey(a => a.EmployeeId);

            builder.Entity<PhoneLineEmployee>()
                .HasKey(a => a.PhoneNumber);
            //TODO terminar la tabla R3
        }
    }
}