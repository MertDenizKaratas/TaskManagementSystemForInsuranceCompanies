
using Domain.Entities;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Domain.Entities.Common;
using ETicaretAPI.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class TMSDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public TMSDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Endpoint> Endpoints { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<ETicaretAPI.Domain.Entities.File> Files { get; set; }
        public DbSet<BranchOffice> BranchOffices { get; set; }
        public DbSet<BranchOfficeContracts> BranchOfficesContracts { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompaniesContracts> CompaniesContracts { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomersContracts> CustomersContracts { get; set; }
        public DbSet<Demand> Demands { get; set; }
        public DbSet<Departmant> Departmants { get; set; }
        public DbSet<Duty> Duties { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<ContactPerson> ContactPerson { get; set; }
        public DbSet<Organization> Organization { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /////Implement the n-n relationship between contracts and branchoffices

            modelBuilder.Entity<BranchOfficeContracts>()
                .HasKey(pi => new { pi.BranchOfficeId, pi.ContractId });

            modelBuilder.Entity<BranchOfficeContracts>()
                .HasOne(pi => pi.BranchOffice)
                .WithMany(p => p.BranchOfficeContracts)
                .HasForeignKey(pi => pi.BranchOfficeId);

            modelBuilder.Entity<BranchOfficeContracts>()
                .HasOne(pi => pi.Contract)
                .WithMany(i => i.BranchOfficeContracts)
                .HasForeignKey(pi => pi.ContractId);

            /////Implement the n-n relationship between contracts and companies
            modelBuilder.Entity<CompaniesContracts>()
                .HasKey(pi => new { pi.CompanyId, pi.ContractId });

            modelBuilder.Entity<CompaniesContracts>()
                .HasOne(pi => pi.Company)
                .WithMany(p => p.CompaniesContracts)
                .HasForeignKey(pi => pi.CompanyId);

            modelBuilder.Entity<CompaniesContracts>()
                .HasOne(pi => pi.Contract)
                .WithMany(i => i.CompaniesContracts)
                .HasForeignKey(pi => pi.ContractId);

            /////Implement the n-n relationship between contracts and customers
            modelBuilder.Entity<CustomersContracts>()
               .HasKey(pi => new { pi.CustomerId, pi.ContractId });

            modelBuilder.Entity<CustomersContracts>()
                .HasOne(pi => pi.Customer)
                .WithMany(p => p.CustomersContracts)
                .HasForeignKey(pi => pi.CustomerId);

            modelBuilder.Entity<CustomersContracts>()
                .HasOne(pi => pi.Contract)
                .WithMany(i => i.CustomersContracts)
                .HasForeignKey(pi => pi.ContractId);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {


            var datas = ChangeTracker
                 .Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
