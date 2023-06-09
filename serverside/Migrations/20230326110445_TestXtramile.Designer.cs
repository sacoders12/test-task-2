﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using serverside.Context;

namespace serverside.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230326110445_TestXtramile")]
    partial class TestXtramile
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("serverside.Model.CityModel", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint(20)");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<long>("countryID")
                        .HasColumnType("bigint(20)");

                    b.Property<int>("dew_point")
                        .HasColumnType("int");

                    b.Property<int>("location")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.Property<int>("pressure")
                        .HasColumnType("int");

                    b.Property<int>("relative_humidility")
                        .HasColumnType("int");

                    b.Property<string>("sky_condition")
                        .HasColumnType("longtext");

                    b.Property<int>("temp_celcius")
                        .HasColumnType("int");

                    b.Property<int>("temp_fahrenheit")
                        .HasColumnType("int");

                    b.Property<DateTime>("time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("uuid")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("visibility")
                        .HasColumnType("int");

                    b.Property<int>("wind")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("countryID");

                    b.HasIndex("uuid")
                        .IsUnique();

                    b.ToTable("cities");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            countryID = 1L,
                            dew_point = 2,
                            location = 222,
                            name = "Bandung",
                            pressure = 203,
                            relative_humidility = 232,
                            sky_condition = "rain",
                            temp_celcius = 20,
                            temp_fahrenheit = 30,
                            time = new DateTime(2023, 3, 26, 20, 4, 44, 921, DateTimeKind.Local).AddTicks(6596),
                            uuid = "d19382ee-0e8a-432f-9bda-a6f2f3a78221",
                            visibility = 7002,
                            wind = 222
                        },
                        new
                        {
                            ID = 2L,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            countryID = 1L,
                            dew_point = 2,
                            location = 232,
                            name = "Jakarta",
                            pressure = 431,
                            relative_humidility = 522,
                            sky_condition = "rain",
                            temp_celcius = 10,
                            temp_fahrenheit = 5,
                            time = new DateTime(2023, 3, 26, 20, 4, 44, 923, DateTimeKind.Local).AddTicks(8042),
                            uuid = "3c676289-ffbc-4e77-a0ed-09f5b435bdbc",
                            visibility = 7003,
                            wind = 2222
                        },
                        new
                        {
                            ID = 3L,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            countryID = 2L,
                            dew_point = 3,
                            location = 231,
                            name = "New York",
                            pressure = 455,
                            relative_humidility = 123,
                            sky_condition = "rain",
                            temp_celcius = 15,
                            temp_fahrenheit = 19,
                            time = new DateTime(2023, 3, 27, 1, 4, 44, 923, DateTimeKind.Local).AddTicks(8122),
                            uuid = "4f088bc8-5a61-4aae-aff8-a5a1ed8ae844",
                            visibility = 703,
                            wind = 222
                        },
                        new
                        {
                            ID = 4L,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            countryID = 2L,
                            dew_point = 3,
                            location = 456,
                            name = "Washington",
                            pressure = 123,
                            relative_humidility = 789,
                            sky_condition = "rain",
                            temp_celcius = 9,
                            temp_fahrenheit = 7,
                            time = new DateTime(2023, 3, 27, 1, 4, 44, 923, DateTimeKind.Local).AddTicks(8128),
                            uuid = "d3e713d2-b7c4-46a8-96e9-d24bc66eb02f",
                            visibility = 7023,
                            wind = 333
                        },
                        new
                        {
                            ID = 5L,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            countryID = 3L,
                            dew_point = 4,
                            location = 555,
                            name = "Maoming",
                            pressure = 444,
                            relative_humidility = 666,
                            sky_condition = "rain",
                            temp_celcius = 13,
                            temp_fahrenheit = 44,
                            time = new DateTime(2023, 3, 26, 22, 4, 44, 923, DateTimeKind.Local).AddTicks(8131),
                            uuid = "ce149021-bbe7-4fec-ba14-bc9205834525",
                            visibility = 7233,
                            wind = 456
                        },
                        new
                        {
                            ID = 6L,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            countryID = 3L,
                            dew_point = 5,
                            location = 666,
                            name = "Beijing",
                            pressure = 555,
                            relative_humidility = 777,
                            sky_condition = "rain",
                            temp_celcius = 14,
                            temp_fahrenheit = 22,
                            time = new DateTime(2023, 3, 26, 22, 4, 44, 923, DateTimeKind.Local).AddTicks(8135),
                            uuid = "5f54d93d-05e1-4964-be49-60b860d824b5",
                            visibility = 7233,
                            wind = 657
                        });
                });

            modelBuilder.Entity("serverside.Model.CountryModel", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint(20)");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("latitude")
                        .HasColumnType("int");

                    b.Property<int>("longtitude")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.Property<string>("uuid")
                        .HasColumnType("varchar(255)");

                    b.HasKey("ID");

                    b.HasIndex("uuid")
                        .IsUnique();

                    b.ToTable("country");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            latitude = 20,
                            longtitude = 203,
                            name = "Indonesia",
                            uuid = "dcb78c2c-208d-4c39-8b49-c3b70318eadb"
                        },
                        new
                        {
                            ID = 2L,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            latitude = 30,
                            longtitude = 303,
                            name = "America",
                            uuid = "9a7164f8-b683-4117-aae1-904cb777e718"
                        },
                        new
                        {
                            ID = 3L,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            latitude = 40,
                            longtitude = 403,
                            name = "China",
                            uuid = "1a4583de-c1b4-4f5b-a44f-bde2ea86b98e"
                        });
                });

            modelBuilder.Entity("serverside.Model.CityModel", b =>
                {
                    b.HasOne("serverside.Model.CountryModel", "country")
                        .WithMany()
                        .HasForeignKey("countryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("country");
                });
#pragma warning restore 612, 618
        }
    }
}
