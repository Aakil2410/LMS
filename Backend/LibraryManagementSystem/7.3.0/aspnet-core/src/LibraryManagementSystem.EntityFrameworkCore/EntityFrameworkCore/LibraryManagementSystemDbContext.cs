using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LibraryManagementSystem.Authorization.Roles;
using LibraryManagementSystem.Authorization.Users;
using LibraryManagementSystem.MultiTenancy;
using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.EntityFrameworkCore
{
    public class LibraryManagementSystemDbContext : AbpZeroDbContext<Tenant, Role, User, LibraryManagementSystemDbContext>
    {
        /* Define a DbSet for each entity of the application */


        public DbSet<Book> Books { get; set; }
        public DbSet<Fine> Fines { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; } 
        public DbSet<Person> Persons { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        // bridging entities
        
        public LibraryManagementSystemDbContext(DbContextOptions<LibraryManagementSystemDbContext> options)
            : base(options)
        {
        }
    }
}
