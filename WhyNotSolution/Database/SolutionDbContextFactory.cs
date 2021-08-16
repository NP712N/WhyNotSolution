using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WhyNotSolution.Models.Database;

namespace WhyNotSolution.Database {
    public class SolutionDbContextFactory : IDesignTimeDbContextFactory<SolutionDbContext>{
        public SolutionDbContext CreateDbContext(string[] args) {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("WhyNotSolution");

            var optionBuilder = new DbContextOptionsBuilder<SolutionDbContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new SolutionDbContext(optionBuilder.Options);
        }
    }
}
