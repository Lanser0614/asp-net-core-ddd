using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Credit.Infrastructure.DbContext;

public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
{

    
    public ApplicationDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
    {
        
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5435;Database=sv_credits;;Username=username>;Password=password");
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}