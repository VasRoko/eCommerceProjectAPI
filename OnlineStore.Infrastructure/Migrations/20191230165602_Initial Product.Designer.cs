﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineStore.Persistance;

namespace OnlineStore.Persistance.Migrations
{
    [DbContext(typeof(OS_ProductsDbContext))]
    [Migration("20191230165602_Initial Product")]
    partial class InitialProduct
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("product")
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineStore.Domain.Entities.Product.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("OnlineStore.Domain.Entities.Product.Details", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ItemId");

                    b.Property<string>("PhotoURL");

                    b.Property<string>("Size");

                    b.Property<string>("Tags");

                    b.Property<string>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("ItemId")
                        .IsUnique();

                    b.ToTable("Details");
                });

            modelBuilder.Entity("OnlineStore.Domain.Entities.Product.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CategoryId");

                    b.Property<string>("CountyPrefix");

                    b.Property<DateTime>("DateAdded");

                    b.Property<bool>("Discontinued");

                    b.Property<string>("Name");

                    b.Property<string>("ReferenceNumber");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("OnlineStore.Domain.Entities.Product.Review", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("Comment");

                    b.Property<DateTime>("Date");

                    b.Property<Guid>("ItemId");

                    b.Property<short>("Rate");

                    b.HasKey("Id");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("OnlineStore.Domain.Entities.Product.Details", b =>
                {
                    b.HasOne("OnlineStore.Domain.Entities.Product.Item", "Item")
                        .WithOne("Details")
                        .HasForeignKey("OnlineStore.Domain.Entities.Product.Details", "ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineStore.Domain.Entities.Product.Item", b =>
                {
                    b.HasOne("OnlineStore.Domain.Entities.Product.Category")
                        .WithMany("Items")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineStore.Domain.Entities.Product.Review", b =>
                {
                    b.HasOne("OnlineStore.Domain.Entities.Product.Item", "Item")
                        .WithMany("Reviews")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
