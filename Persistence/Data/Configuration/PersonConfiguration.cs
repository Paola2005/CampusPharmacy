using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person");
        builder.HasKey(e=>e.Id);
        builder.Property(e=>e.Id);

        builder.Property(p=>p.Name)
        .HasMaxLength(50);
        builder.Property(p=>p.RegistrationDate);

        builder.HasOne(p=>p.RolesPersons)
        .WithMany(p=>p.Persons)
        .HasForeignKey(p=>p.IdRolePerson);

        builder.HasOne(p=>p.TypesPersons)
        .WithMany(p=>p.Persons)
        .HasForeignKey(p=>p.IdTypePerson);

        builder.HasOne(p=>p.DocumentsTypes)
        .WithMany(p=>p.Persons)
        .HasForeignKey(p=>p.IdDocument);
        }
    }
}