using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.EntityFrameworkCore
{
    public static class LibraryManagementSystemDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LibraryManagementSystemDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LibraryManagementSystemDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
