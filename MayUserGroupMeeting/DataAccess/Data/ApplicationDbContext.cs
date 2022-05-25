namespace DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Code First:
        // 1). add-migration initialCommit
        // 2). update-database

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; } = null!;

    }
}
