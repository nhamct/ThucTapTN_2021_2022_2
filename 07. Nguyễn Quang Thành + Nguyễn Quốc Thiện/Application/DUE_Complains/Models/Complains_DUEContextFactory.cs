using DUE_Complains.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.Models
{
    public class Complains_DUEContextFactory : IDesignTimeDbContextFactory<Complains_DUEContext>
    {
        public Complains_DUEContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString(SystemConstants.MainConnectionString);

            var optionsBuilder = new DbContextOptionsBuilder<Complains_DUEContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new Complains_DUEContext(optionsBuilder.Options);
        }
    }
}
