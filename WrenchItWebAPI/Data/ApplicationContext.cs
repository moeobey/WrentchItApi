using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WrenchItWebAPI.Models;

namespace WrenchItWebAPI.Data
{
    public class ApplicationContext : DbContext

    {
        public ApplicationContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Service>().HasData(
                new Service { ServiceId = 1, ServiceName = "Oil Change", EstimatedTimeToComplete = .5, Labor = 30},
                new Service { ServiceId = 2, ServiceName = "Head Gasket", EstimatedTimeToComplete = 1.5, Labor = 30},
                new Service { ServiceId = 3, ServiceName = "Brake Pads", EstimatedTimeToComplete = 1, Labor = 30},
                new Service { ServiceId = 4, ServiceName = "Exhaust", EstimatedTimeToComplete = 2.5, Labor = 30},
                new Service { ServiceId = 5, ServiceName = "Struts", EstimatedTimeToComplete = 2, Labor = 30},
                new Service { ServiceId = 6, ServiceName = "Spark Plugs", EstimatedTimeToComplete = 1, Labor = 30}
                
                );       
        
        }

        public DbSet<Service> Services { get; set; }
        
    }
}
