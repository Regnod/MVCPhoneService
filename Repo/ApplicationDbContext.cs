using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.IO;
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
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}