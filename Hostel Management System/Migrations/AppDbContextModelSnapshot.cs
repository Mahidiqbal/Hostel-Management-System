﻿// <auto-generated />
using Hostel_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hostel_Management_System.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hostel_Management_System.Models.LookUpCollection", b =>
                {
                    b.Property<int>("LookUpCollectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LookUpCollectionId"), 1L, 1);

                    b.Property<string>("IsDeleted")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LookUpCollectionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("LookUpCollectionId");

                    b.ToTable("lookUpCollections");
                });

            modelBuilder.Entity("Hostel_Management_System.Models.LookUpCollectionValues", b =>
                {
                    b.Property<int>("LookUpCollectionValueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LookUpCollectionValueId"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedOn")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IsDeleted")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LookUpCollectionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LookUpCollectionId1")
                        .HasColumnType("int");

                    b.Property<string>("LookUpCollectionValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ModifiedOn")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("LookUpCollectionValueId");

                    b.HasIndex("LookUpCollectionId1");

                    b.ToTable("lookUpCollectionValues");
                });

            modelBuilder.Entity("Hostel_Management_System.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedOn")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IsDeleted")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ModifiedOn")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserBD")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserCNIC")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserLogin")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Hostel_Management_System.Models.LookUpCollectionValues", b =>
                {
                    b.HasOne("Hostel_Management_System.Models.LookUpCollection", "LookUpCollection")
                        .WithMany()
                        .HasForeignKey("LookUpCollectionId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LookUpCollection");
                });
#pragma warning restore 612, 618
        }
    }
}
