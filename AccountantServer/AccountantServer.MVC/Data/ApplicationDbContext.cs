namespace AccountantServer.MVC.Data
{
    using AccountantServer.MVC.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Income> Incomes { get; set; }
        public DbSet<CashPos> CashPosIncomes { get; set; }
        public DbSet<CashRegister> CashRegisters { get; set; }
        public DbSet<Shift> Shifts { get; set; }
    }
}