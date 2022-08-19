using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PractisalTest.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PractisalTest.Data.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.Property(x => x.ClientUniqueId).IsRequired();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Surname).IsRequired().IsRequired().HasMaxLength(100);
            builder.Property(x => x.TelephoneNr).IsRequired().HasMaxLength(40);
        }
    }
}
