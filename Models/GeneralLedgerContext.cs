using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace KAS.Models;

public class GeneralLedgerContext(DbContextOptions<GeneralLedgerContext> options)
    : DbContext(options)
{
    public DbSet<GeneralLedger> GeneralLedgerTransactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=(localdb)\\mssqllocaldb;Database=KAS;Trusted_Connection=True;"
        );
    }
}
