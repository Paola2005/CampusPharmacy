using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class PersonContactConfiguration : IEntityTypeConfiguration<PersonContact>
    {
        public void Configure(EntityTypeBuilder<PersonContact> builder)
        {
            builder.ToTable("PersonContact");
        builder.HasKey(e=>e.Id);
        builder.Property(e=>e.Id);

        builder.HasOne(p=>p.Persons)
        .WithMany(p=>p.PersonsContacts)
        .HasForeignKey(p=>p.IdPerson);

        builder.HasOne(p=>p.TypeContact)
        .WithMany(p=>p.PersonsContacts)
        .HasForeignKey(p=>p.IdTypeContact);
        }
    }
}
