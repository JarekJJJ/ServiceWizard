using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ServiceWizard.Application.Common.Models;
using ServiceWizard.Application.Interfaces;
using ServiceWizard.Domain.Common;
using ServiceWizard.Domain.Entities;
using System.Reflection;

namespace ServiceWizard.Persistance
{
    public class ServiceWizardDbContext : IdentityDbContext<ApiUser>, IServiceWizardDbContext
    {
        public ServiceWizardDbContext(DbContextOptions<ServiceWizardDbContext> options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<RepairOrder> RepairOrders { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<RepairType> RepairTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserLogin<string>>().HasNoKey();
            modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey();
            modelBuilder.Entity<IdentityUserToken<string>>().HasNoKey();

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());  
            modelBuilder.SeedData();
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = "";
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.StatusId = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = "";
                        entry.Entity.LastModified = DateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.LastModifiedBy = "";
                        entry.Entity.LastModified = DateTime.Now;
                        entry.Entity.InactivatedBy = "";
                        entry.Entity.Inactivated = DateTime.Now;
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

    }

}