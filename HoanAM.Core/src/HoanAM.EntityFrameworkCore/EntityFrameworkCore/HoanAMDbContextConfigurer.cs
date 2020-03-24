using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HoanAM.EntityFrameworkCore
{
    public static class HoanAMDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HoanAMDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HoanAMDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
