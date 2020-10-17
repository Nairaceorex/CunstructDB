﻿// <auto-generated />
using System;
using CunstructDB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CunstructDB.Migrations
{
    [DbContext(typeof(CunstructDBContext))]
    partial class CunstructDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConstructDB.Models.Brigade", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("OrderID")
                        .HasColumnType("bigint");

                    b.Property<long?>("Staff1")
                        .HasColumnType("bigint");

                    b.Property<long?>("Staff2")
                        .HasColumnType("bigint");

                    b.Property<long?>("Staff3")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.ToTable("Brigade");
                });

            modelBuilder.Entity("ConstructDB.Models.Customer", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FullName")
                        .HasColumnType("bigint");

                    b.Property<long?>("OrderID")
                        .HasColumnType("bigint");

                    b.Property<string>("PassportData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("ConstructDB.Models.Material", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Packaging")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<long?>("TypeOfJobID")
                        .HasColumnType("bigint");

                    b.Property<long?>("TypeOfJobID1")
                        .HasColumnType("bigint");

                    b.Property<long?>("TypeOfJobID2")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("TypeOfJobID");

                    b.HasIndex("TypeOfJobID1");

                    b.HasIndex("TypeOfJobID2");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("ConstructDB.Models.Order", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutPayment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompletionMark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("ConstructDB.Models.Position", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requirements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsibilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<long?>("StaffID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("StaffID");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("ConstructDB.Models.Staff", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<long?>("BrigadeID")
                        .HasColumnType("bigint");

                    b.Property<long?>("BrigadeID1")
                        .HasColumnType("bigint");

                    b.Property<long?>("BrigadeID2")
                        .HasColumnType("bigint");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("OrderID")
                        .HasColumnType("bigint");

                    b.Property<string>("PassportData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("BrigadeID");

                    b.HasIndex("BrigadeID1");

                    b.HasIndex("BrigadeID2");

                    b.HasIndex("OrderID");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("ConstructDB.Models.TypeOfJob", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Material1ID")
                        .HasColumnType("bigint");

                    b.Property<long?>("Material2ID")
                        .HasColumnType("bigint");

                    b.Property<long?>("Material3ID")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("OrderID")
                        .HasColumnType("bigint");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.ToTable("TypeOfJob");
                });

            modelBuilder.Entity("ConstructDB.Models.Brigade", b =>
                {
                    b.HasOne("ConstructDB.Models.Order", null)
                        .WithMany("BrigadeID")
                        .HasForeignKey("OrderID");
                });

            modelBuilder.Entity("ConstructDB.Models.Customer", b =>
                {
                    b.HasOne("ConstructDB.Models.Order", null)
                        .WithMany("CustomerID")
                        .HasForeignKey("OrderID");
                });

            modelBuilder.Entity("ConstructDB.Models.Material", b =>
                {
                    b.HasOne("ConstructDB.Models.TypeOfJob", null)
                        .WithMany("Material1")
                        .HasForeignKey("TypeOfJobID");

                    b.HasOne("ConstructDB.Models.TypeOfJob", null)
                        .WithMany("Material2")
                        .HasForeignKey("TypeOfJobID1");

                    b.HasOne("ConstructDB.Models.TypeOfJob", null)
                        .WithMany("Material3")
                        .HasForeignKey("TypeOfJobID2");
                });

            modelBuilder.Entity("ConstructDB.Models.Position", b =>
                {
                    b.HasOne("ConstructDB.Models.Staff", null)
                        .WithMany("PositionID")
                        .HasForeignKey("StaffID");
                });

            modelBuilder.Entity("ConstructDB.Models.Staff", b =>
                {
                    b.HasOne("ConstructDB.Models.Brigade", null)
                        .WithMany("Staff1ID")
                        .HasForeignKey("BrigadeID");

                    b.HasOne("ConstructDB.Models.Brigade", null)
                        .WithMany("Staff2ID")
                        .HasForeignKey("BrigadeID1");

                    b.HasOne("ConstructDB.Models.Brigade", null)
                        .WithMany("Staff3ID")
                        .HasForeignKey("BrigadeID2");

                    b.HasOne("ConstructDB.Models.Order", null)
                        .WithMany("StaffID")
                        .HasForeignKey("OrderID");
                });

            modelBuilder.Entity("ConstructDB.Models.TypeOfJob", b =>
                {
                    b.HasOne("ConstructDB.Models.Order", null)
                        .WithMany("TypeOfJobID")
                        .HasForeignKey("OrderID");
                });
#pragma warning restore 612, 618
        }
    }
}
