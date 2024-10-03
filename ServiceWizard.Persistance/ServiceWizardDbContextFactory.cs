using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Persistance
{
    public class ServiceWizardDbContextFactory: DesignTimeDbContextFactoryBase<ServiceWizardDbContext>
    {
        protected override ServiceWizardDbContext CreateNewInstance(DbContextOptions<ServiceWizardDbContext> options)
        {
            return new ServiceWizardDbContext(options);
        }
    }
}
