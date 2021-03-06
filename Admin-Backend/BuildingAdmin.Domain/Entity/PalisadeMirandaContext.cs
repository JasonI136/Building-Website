﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BuildingAdmin.Domain.Entity
{
    public partial class PalisadeMirandaContext : DbContext
    {
  

        public PalisadeMirandaContext(DbContextOptions<PalisadeMirandaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<ContactUsForm> ContactUsForms { get; set; }
        public virtual DbSet<User> Users { get; set; }

     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Building>(entity =>
            {
                entity.ToTable("Building");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.BuildingName).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.DisplayPrice).HasMaxLength(100);

                entity.Property(e => e.Postcode).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.StreetNumber).HasMaxLength(50);

                entity.Property(e => e.Suburb).HasMaxLength(100);
            });

            modelBuilder.Entity<ContactUsForm>(entity =>
            {
                entity.ToTable("ContactUsForm");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("lastName");

                entity.Property(e => e.Subject)
                    .HasMaxLength(50)
                    .HasColumnName("subject");

                entity.Property(e => e.TextArea).HasColumnName("textArea");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Dob).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.IsSuccess).HasColumnName("isSuccess");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
