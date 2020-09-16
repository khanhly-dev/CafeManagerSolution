using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cafe.Data.EF
{
    public class CafeManagerSolutionDbContextFactory : IDesignTimeDbContextFactory<CafeManagerDbContext>
    {
        public CafeManagerDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connetionString = configuration.GetConnectionString("CafeManagerDatabase");

            var optionsBuilder = new DbContextOptionsBuilder<CafeManagerDbContext>();
            optionsBuilder.UseSqlServer(connetionString);
            return new CafeManagerDbContext(optionsBuilder.Options);
        }
    }
}
