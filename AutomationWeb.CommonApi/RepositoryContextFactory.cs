using System;
using AutomationWeb.Common.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AutomationWeb.Common.Api
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        private const string CONNECTION_STRING_NAME = "DefaultConnection";

        private readonly IConfiguration _configuration;

        public RepositoryContextFactory()
        {
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var basePath = AppContext.BaseDirectory;
            var builder = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{environmentName}.json", true)
                .AddEnvironmentVariables();

            _configuration = builder.Build();
        }

        public RepositoryContextFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public RepositoryContext CreateDbContext(string[] args)
        {
            var connectionString = _configuration.GetConnectionString(CONNECTION_STRING_NAME);
            return Create(connectionString);
        }

        public RepositoryContext CreateDbContext()
        {
            return CreateDbContext(new string[0]);
        }


        private RepositoryContext Create(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentException($"{nameof(connectionString)} is null or empty.", nameof(connectionString));

            var optionsBuilder = new DbContextOptionsBuilder<RepositoryContext>();
            var assemblyName = typeof(RepositoryContext).Namespace;
            optionsBuilder.UseSqlServer(connectionString,
                optionBuilder => optionBuilder.MigrationsAssembly(assemblyName));
            return new RepositoryContext(optionsBuilder.Options);
        }
    }
}