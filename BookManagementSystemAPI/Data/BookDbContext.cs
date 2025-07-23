using BookManagementSystemAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookManagementSystemAPI.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class BookDbContext:IdentityDbContext //BookDb database
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        //public DbSet<User> Users { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContextOptions"></param>
        public BookDbContext(DbContextOptions<BookDbContext> dbContextOptions)
            :base(dbContextOptions)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //define relation, define constraints
            //define data seeding
            modelBuilder.Entity<Book>().HasMany<Publisher>(x => x.Publishers);



            base.OnModelCreating(modelBuilder); 
        }
    }
}
