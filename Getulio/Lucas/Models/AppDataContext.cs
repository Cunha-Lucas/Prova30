using Microsoft.EntityFrameworkCore;

namespace Lucas.Models;

public class AppDataContext : DbContext
{
    public DbSet<Funcionario> Funcionarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=getulio_lucas.db");
    }

}