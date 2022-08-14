using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using GetDoIt.Authorization.Roles;
using GetDoIt.Authorization.Users;
using GetDoIt.MultiTenancy;

namespace GetDoIt.EntityFrameworkCore
{
    public class GetDoItDbContext : AbpZeroDbContext<Tenant, Role, User, GetDoItDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public virtual DbSet<CategorySpending.Entities.CategorySpending> CategorySpending { get; set; }
        public virtual DbSet<Spending.Entities.Spending> Spending { get; set; }
        public virtual DbSet<StatusSpending.Entities.StatusSpending> StatusSpending { get; set; }
        public virtual DbSet<Status.Entities.Status> Status { get; set; }

        public GetDoItDbContext(DbContextOptions<GetDoItDbContext> options)
            : base(options)
        {
        }
    }
}
