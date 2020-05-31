﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OwnerPropertyManagement.Data.Context;

namespace OwnerPropertyManagement.Data.Migrations
{
    [DbContext(typeof(OwnerPropertyDbContext))]
    [Migration("20200531094348_remove-audittable")]
    partial class removeaudittable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OwnerPropertyManagement.Data.Entities.Facility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("TypeFacilityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeFacilityId");

                    b.ToTable("Facility");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Beach towels",
                            TypeFacilityId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Linen",
                            TypeFacilityId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "Towels",
                            TypeFacilityId = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "Private pool",
                            TypeFacilityId = 2
                        },
                        new
                        {
                            Id = 5,
                            Description = "Heated pool",
                            TypeFacilityId = 2
                        },
                        new
                        {
                            Id = 6,
                            Description = "Outside jacuzzi",
                            TypeFacilityId = 2
                        },
                        new
                        {
                            Id = 7,
                            Description = "Garden",
                            TypeFacilityId = 2
                        },
                        new
                        {
                            Id = 8,
                            Description = "Parking",
                            TypeFacilityId = 2
                        },
                        new
                        {
                            Id = 9,
                            Description = "Barbecue",
                            TypeFacilityId = 2
                        },
                        new
                        {
                            Id = 10,
                            Description = "Sunbeds",
                            TypeFacilityId = 2
                        },
                        new
                        {
                            Id = 11,
                            Description = "Wi-Fi",
                            TypeFacilityId = 3
                        },
                        new
                        {
                            Id = 12,
                            Description = "Satellite",
                            TypeFacilityId = 3
                        },
                        new
                        {
                            Id = 13,
                            Description = "Tv",
                            TypeFacilityId = 3
                        },
                        new
                        {
                            Id = 14,
                            Description = "Cot",
                            TypeFacilityId = 3
                        },
                        new
                        {
                            Id = 15,
                            Description = "Iron",
                            TypeFacilityId = 3
                        },
                        new
                        {
                            Id = 16,
                            Description = "Safe",
                            TypeFacilityId = 3
                        },
                        new
                        {
                            Id = 17,
                            Description = "Air conditioning",
                            TypeFacilityId = 3
                        },
                        new
                        {
                            Id = 18,
                            Description = "Dishwasher",
                            TypeFacilityId = 4
                        },
                        new
                        {
                            Id = 19,
                            Description = "Freezer",
                            TypeFacilityId = 4
                        },
                        new
                        {
                            Id = 20,
                            Description = "Fridge",
                            TypeFacilityId = 4
                        },
                        new
                        {
                            Id = 21,
                            Description = "Coffee machine",
                            TypeFacilityId = 4
                        },
                        new
                        {
                            Id = 22,
                            Description = "Grill",
                            TypeFacilityId = 4
                        },
                        new
                        {
                            Id = 23,
                            Description = "Hob",
                            TypeFacilityId = 4
                        },
                        new
                        {
                            Id = 24,
                            Description = "Microwave",
                            TypeFacilityId = 4
                        },
                        new
                        {
                            Id = 25,
                            Description = "Jacuzzi",
                            TypeFacilityId = 5
                        },
                        new
                        {
                            Id = 26,
                            Description = "Shower",
                            TypeFacilityId = 5
                        },
                        new
                        {
                            Id = 27,
                            Description = "Bath tub",
                            TypeFacilityId = 5
                        },
                        new
                        {
                            Id = 28,
                            Description = "Hair dryer",
                            TypeFacilityId = 5
                        },
                        new
                        {
                            Id = 29,
                            Description = "Sea views",
                            TypeFacilityId = 6
                        },
                        new
                        {
                            Id = 30,
                            Description = "Mountain views",
                            TypeFacilityId = 6
                        },
                        new
                        {
                            Id = 31,
                            Description = "Pool views",
                            TypeFacilityId = 6
                        },
                        new
                        {
                            Id = 32,
                            Description = "Wheelchair accessible",
                            TypeFacilityId = 7
                        },
                        new
                        {
                            Id = 33,
                            Description = "Suitable for the elderly",
                            TypeFacilityId = 7
                        },
                        new
                        {
                            Id = 34,
                            Description = "Pets considered",
                            TypeFacilityId = 7
                        },
                        new
                        {
                            Id = 35,
                            Description = "No smoking inside",
                            TypeFacilityId = 7
                        },
                        new
                        {
                            Id = 36,
                            Description = "Car not necessary",
                            TypeFacilityId = 7
                        },
                        new
                        {
                            Id = 37,
                            Description = "Car recommended",
                            TypeFacilityId = 7
                        });
                });

            modelBuilder.Entity("OwnerPropertyManagement.Data.Entities.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutMe")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ContactPhoneProperty")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Nick")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PersonalPhoneNumber")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("OwnerPropertyManagement.Data.Entities.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<short>("Bathrooms")
                        .HasColumnType("smallint");

                    b.Property<short>("Bedrooms")
                        .HasColumnType("smallint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<short>("DistanceAirport")
                        .HasColumnType("smallint");

                    b.Property<short>("DistanceBeach")
                        .HasColumnType("smallint");

                    b.Property<bool>("Garden")
                        .HasColumnType("bit");

                    b.Property<bool>("HeatedPool")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LivingArea")
                        .HasColumnType("int");

                    b.Property<string>("LocalActivities")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("LocalLeisure")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<bool>("PrivatePool")
                        .HasColumnType("bit");

                    b.Property<short>("Sleeps")
                        .HasColumnType("smallint");

                    b.Property<int>("TownId")
                        .HasColumnType("int");

                    b.Property<bool>("Wifi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("TownId");

                    b.ToTable("Property");
                });

            modelBuilder.Entity("OwnerPropertyManagement.Data.Entities.PropertyFacility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FacilityId")
                        .HasColumnType("int");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FacilityId");

                    b.HasIndex("PropertyId");

                    b.ToTable("PropertyFacility");
                });

            modelBuilder.Entity("OwnerPropertyManagement.Data.Entities.Town", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("ZoneId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ZoneId");

                    b.ToTable("Town");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Fuenguirola",
                            ZoneId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Estepona",
                            ZoneId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "Benalmadena",
                            ZoneId = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "Begur",
                            ZoneId = 2
                        },
                        new
                        {
                            Id = 5,
                            Description = "Blanes",
                            ZoneId = 2
                        },
                        new
                        {
                            Id = 6,
                            Description = "Denia",
                            ZoneId = 3
                        },
                        new
                        {
                            Id = 7,
                            Description = "Altea",
                            ZoneId = 3
                        });
                });

            modelBuilder.Entity("OwnerPropertyManagement.Data.Entities.TypesFacility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("TypesFacility");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "General"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Outside"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Inside"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Kitchen"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Bathroom"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Views"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Relevant information"
                        });
                });

            modelBuilder.Entity("OwnerPropertyManagement.Data.Entities.Zone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Zone");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Costa del Sol"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Costa Brava"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Costa Blanco"
                        });
                });

            modelBuilder.Entity("OwnerPropertyManagement.Data.Entities.Facility", b =>
                {
                    b.HasOne("OwnerPropertyManagement.Data.Entities.TypesFacility", "TypesFacility")
                        .WithMany("Facilities")
                        .HasForeignKey("TypeFacilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OwnerPropertyManagement.Data.Entities.Property", b =>
                {
                    b.HasOne("OwnerPropertyManagement.Data.Entities.Owner", "Owner")
                        .WithMany("Properties")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OwnerPropertyManagement.Data.Entities.Town", "Town")
                        .WithMany("Properties")
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OwnerPropertyManagement.Data.Entities.PropertyFacility", b =>
                {
                    b.HasOne("OwnerPropertyManagement.Data.Entities.Facility", "Facility")
                        .WithMany("PropertyFacilities")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OwnerPropertyManagement.Data.Entities.Property", "Property")
                        .WithMany("PropertyFacilities")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OwnerPropertyManagement.Data.Entities.Town", b =>
                {
                    b.HasOne("OwnerPropertyManagement.Data.Entities.Zone", "Zone")
                        .WithMany("Towns")
                        .HasForeignKey("ZoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
