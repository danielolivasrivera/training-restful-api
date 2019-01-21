using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Entities
{
    public class LibraryContext : DbContext
    {
        #region Constructor
        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
            Database.Migrate();
        }
        #endregion

        #region Properties
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        #endregion
    }
}
