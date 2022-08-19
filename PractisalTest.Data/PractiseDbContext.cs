using Microsoft.EntityFrameworkCore;
using PractisalTest.Core.Entities;
using PractisalTest.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace PractisalTest.Data
{
    public class PractiseDbContext:DbContext
    {
        public PractiseDbContext(DbContextOptions<PractiseDbContext> options):base(options)
        { 

        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Loan>()
               .HasOne(a => a.Client)
               .WithMany(b => b.Loans)
               .HasForeignKey(a => a.ClientId);
            modelBuilder.Entity<Invoice>()
           .HasOne(a => a.Loan)
           .WithMany(b => b.Invoices)
           .HasForeignKey(a => a.LoanId);
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new LoanConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
