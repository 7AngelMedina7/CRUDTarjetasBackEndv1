using aspnet_core_dotnet_core.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace aspnet_core_dotnet_core
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
    }
}
