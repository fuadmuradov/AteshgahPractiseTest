using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PractisalTest.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PractisalTest.Data.Configurations
{
    public class InvoiceConfiguration: IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x => x.OrderNr).IsRequired().HasMaxLength(24);
            builder.Property(x => x.DueDate).IsRequired();
            builder.Property(x => x.LoanId).IsRequired();
        }
    }
}
