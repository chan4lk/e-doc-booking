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
                .HasPartitionKey(x => x.Id);

            builder
                .OwnsMany(x => x.Addresses)
                .Property(x => x.LocationId)
                .HasConversion<string>(); ;

            builder.OwnsMany(x => x.Contacts)
                .Property(x => x.LocationId)
                .HasConversion<string>();

            builder.Property(x => x.Id)
                .HasConversion<string>();

            builder.Property(x => x.OrganizationId)
                .HasConversion<string>();
        }
    }
}
