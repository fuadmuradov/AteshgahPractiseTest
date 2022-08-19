using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PractisalTest.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PractisalTest.Data.Configurations
{
    class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x => x.InterestRate).IsRequired().HasMaxLength(100);
            builder.Property(x => x.PayoutDate).IsRequired();
            builder.Property(x => x.ClientId).IsRequired();
        }
    }
}
