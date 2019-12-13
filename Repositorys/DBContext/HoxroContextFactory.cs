using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Repositorys.DBContext
{
    public class HoxroContextFactory : IDesignTimeDbContextFactory<HoxroDbContext>
    {

        public HoxroDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../HoxroAPI"))
            .AddJsonFile("appsettings.json")
            .Build();
            var builder = new DbContextOptionsBuilder<HoxroDbContext>();
            builder.UseSqlServer(configuration.GetConnectionString("HoxroDB"));
            return new HoxroDbContext(builder.Options);
        }
    }
}
