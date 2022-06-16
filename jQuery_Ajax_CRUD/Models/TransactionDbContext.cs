using Microsoft.EntityFrameworkCore;

namespace jQuery_Ajax_CRUD.Models
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
        { }
        public DbSet<TransactionModel> Transactions { get; set; }   
    }
}
