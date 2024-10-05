using Microsoft.EntityFrameworkCore;
using ServiceWizard.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Application.Interfaces
{
    public interface IServiceWizardDbContext
    {
        DbSet<Client> Clients { get; set; }
        DbSet<RepairOrder> RepairOrders { get; set; }
        DbSet<Device> Devices { get; set; }
        DbSet<RepairType> RepairTypes { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
