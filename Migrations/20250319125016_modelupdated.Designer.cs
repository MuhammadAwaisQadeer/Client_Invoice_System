﻿// <auto-generated />
using System;
using Client_Invoice_System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Client_Invoice_System.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250319125016_modelupdated")]
    partial class modelupdated
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Client_Invoice_System.Models.ActiveClient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("ActiveClients");
                });

            modelBuilder.Entity("Client_Invoice_System.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientIdentifier")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<int>("CountryCurrencyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomCurrency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("N/A");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ClientId");

                    b.HasIndex("CountryCurrencyId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Client_Invoice_System.Models.ClientProfileCrossTable", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("ClientId", "EmployeeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("ClientProfileCrosses");
                });

            modelBuilder.Entity("Client_Invoice_System.Models.CountryCurrency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrencyCode")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("CurrencyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CountryCurrencies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryName = "United States",
                            CurrencyCode = "USD",
                            CurrencyName = "US Dollar",
                            Symbol = "$"
                        },
                        new
                        {
                            Id = 2,
                            CountryName = "United Kingdom",
                            CurrencyCode = "GBP",
                            CurrencyName = "Pound Sterling",
                            Symbol = "£"
                        },
                        new
                        {
                            Id = 3,
                            CountryName = "European Union",
                            CurrencyCode = "EUR",
                            CurrencyName = "Euro",
                            Symbol = "€"
                        },
                        new
                        {
                            Id = 4,
                            CountryName = "Japan",
                            CurrencyCode = "JPY",
                            CurrencyName = "Japanese Yen",
                            Symbol = "¥"
                        },
                        new
                        {
                            Id = 5,
                            CountryName = "India",
                            CurrencyCode = "INR",
                            CurrencyName = "Indian Rupee",
                            Symbol = "₹"
                        },
                        new
                        {
                            Id = 6,
                            CountryName = "Canada",
                            CurrencyCode = "CAD",
                            CurrencyName = "Canadian Dollar",
                            Symbol = "C$"
                        },
                        new
                        {
                            Id = 7,
                            CountryName = "Australia",
                            CurrencyCode = "AUD",
                            CurrencyName = "Australian Dollar",
                            Symbol = "A$"
                        });
                });

            modelBuilder.Entity("Client_Invoice_System.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreditExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("CreditLimit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CreditUsed")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Designation")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("HourlyRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Client_Invoice_System.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceId"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("CountryCurrencyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("InvoiceId");

                    b.HasIndex("ClientId");

                    b.HasIndex("CountryCurrencyId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Client_Invoice_System.Models.OwnerProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BeneficeryAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillingEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryCurrencyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomCurrency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IBANNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Swiftcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CountryCurrencyId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("Client_Invoice_System.Models.Resource", b =>
                {
                    b.Property<int>("ResourceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResourceId"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("ConsumedTotalHours")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsInvoiced")
                        .HasColumnType("bit");

                    b.Property<string>("ResourceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ResourceId");

                    b.HasIndex("ClientId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("Client_Invoice_System.Models.ActiveClient", b =>
                {
                    b.HasOne("Client_Invoice_System.Models.Client", "Client")
                        .WithOne("ActiveClient")
                        .HasForeignKey("Client_Invoice_System.Models.ActiveClient", "ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Client_Invoice_System.Models.Client", b =>
                {
                    b.HasOne("Client_Invoice_System.Models.CountryCurrency", "CountryCurrency")
                        .WithMany()
                        .HasForeignKey("CountryCurrencyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CountryCurrency");
                });

            modelBuilder.Entity("Client_Invoice_System.Models.ClientProfileCrossTable", b =>
                {
                    b.HasOne("Client_Invoice_System.Models.Client", "Client")
                        .WithMany("ClientProfileCrosses")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Client_Invoice_System.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Client_Invoice_System.Models.Invoice", b =>
                {
                    b.HasOne("Client_Invoice_System.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Client_Invoice_System.Models.CountryCurrency", "CountryCurrency")
                        .WithMany()
                        .HasForeignKey("CountryCurrencyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("CountryCurrency");
                });

            modelBuilder.Entity("Client_Invoice_System.Models.OwnerProfile", b =>
                {
                    b.HasOne("Client_Invoice_System.Models.CountryCurrency", "CountryCurrency")
                        .WithMany()
                        .HasForeignKey("CountryCurrencyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CountryCurrency");
                });

            modelBuilder.Entity("Client_Invoice_System.Models.Resource", b =>
                {
                    b.HasOne("Client_Invoice_System.Models.Client", "Client")
                        .WithMany("Resources")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Client_Invoice_System.Models.Employee", "Employee")
                        .WithMany("Resources")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Client_Invoice_System.Models.Client", b =>
                {
                    b.Navigation("ActiveClient")
                        .IsRequired();

                    b.Navigation("ClientProfileCrosses");

                    b.Navigation("Resources");
                });

            modelBuilder.Entity("Client_Invoice_System.Models.Employee", b =>
                {
                    b.Navigation("Resources");
                });
#pragma warning restore 612, 618
        }
    }
}
