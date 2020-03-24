using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HoanAM.Authorization.Roles;
using HoanAM.Authorization.Users;
using HoanAM.MultiTenancy;

namespace HoanAM.EntityFrameworkCore
{
    public class HoanAMDbContext : AbpZeroDbContext<Tenant, Role, User, HoanAMDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HoanAMDbContext(DbContextOptions<HoanAMDbContext> options)
            : base(options)
        {
        }
    }
}
