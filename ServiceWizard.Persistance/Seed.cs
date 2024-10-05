using Microsoft.EntityFrameworkCore;
using ServiceWizard.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Persistance
{
    public static class Seed
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RepairType>(d => d.HasData(
            new RepairType
            {
                Id = 1,
                StatusId = 1,
                CreatedBy = "System",
                Name = "Gwarancyjna",
                Description = "Sprzęt przyjęty w ramach naprawy gwarancyjnej"
            },
               new RepairType
               {
                   Id = 2,
                   StatusId = 1,
                   CreatedBy = "System",
                   Name = "Niegwarancyjna",
                   Description = "Standardowa naprawa"
               },
               new RepairType
               {
                   Id = 3,
                   StatusId = 1,
                   CreatedBy = "System",
                   Name = "Warunkowa",
                   Description = "Sprzęt przyjęty warunkowo na naprawę gwarancyjną"
               }
               ));
        }
    }
}
