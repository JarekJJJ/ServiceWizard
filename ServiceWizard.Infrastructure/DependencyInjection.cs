using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceWizard.Application.Interfaces;
using ServiceWizard.Infrastructure.Services;
using ServiceWizard.Application.Interfaces.IFile;
using ServiceWizard.Infrastructure.FileStore;

namespace ServiceWizard.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDateTime, DateTimeService>();
            services.AddTransient<IFileWrapper, FileWrapper>();
            services.AddTransient<IDirectoryWrapper, DirectoryWrapper>();
            services.AddTransient<IFileStore, FileStore.FileStore>();

            return services;
        }
    }
}
