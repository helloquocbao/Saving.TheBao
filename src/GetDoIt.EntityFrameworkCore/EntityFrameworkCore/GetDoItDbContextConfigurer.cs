using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace GetDoIt.EntityFrameworkCore
{
    public static class GetDoItDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GetDoItDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<GetDoItDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
