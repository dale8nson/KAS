using Microsoft.EntityFrameworkCore;

namespace KAS.Models;

public class ChartOfAccountsContext : DbContext
{
    public DbSet<ChartOfAccounts> ChartOfAccounts { get; set; }

    public ChartOfAccountsContext(DbContextOptions<ChartOfAccountsContext> options)
        : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Integrated Security=false;Initial Catalog=KAS;Server=tcp:10.0.0.126,1433;User ID=sa;Password=Sakura_Hana81;Encrypt=False;"
        );
    }
}
