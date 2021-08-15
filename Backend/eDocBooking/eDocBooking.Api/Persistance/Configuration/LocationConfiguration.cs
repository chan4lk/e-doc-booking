using System;
using eDocBooking.Api.Persistance.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eDocBooking.Api.Persistance.Configuration
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {        

        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder
                .HasPartitionKey(x => x.Id)
                .OwnsMany(x => x.Addresses);

            builder.OwnsMany(x => x.Contacts);

            builder.Property(x => x.Id)
                .HasConversion<string>();
                
        }
    }
}
