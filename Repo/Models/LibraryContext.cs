using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Repo.Models
{
    public class LibraryContext : IdentityDbContext
    {
        public LibraryContext()
            : base("DefaultConnection")
        {
        }

        public static LibraryContext Create()
        {
            return new LibraryContext();
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Limit> Limits { get; set; }
        public DbSet<Queue> Queues { get; set; }
        public DbSet<Search> Search { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}