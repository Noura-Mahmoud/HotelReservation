﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Start.Context;

#nullable disable

namespace Start.Migrations
{
    [DbContext(typeof(HotelContext))]
    [Migration("20230310155825_CreateRservationV2")]
    partial class CreateRservationV2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Start.Entites.Kitchen", b =>
                {
                    b.Property<string>("User_name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Pass_word")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("User_name");

                    b.ToTable("Kitchens");
                });

            modelBuilder.Entity("Start.Entites.Manager", b =>
                {
                    b.Property<string>("User_name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Pass_word")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("User_name");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("Start.Entites.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AptSuite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("apt_suite");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("arrival_time");

                    b.Property<string>("BirthDay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("birth_day");

                    b.Property<int>("BreakFast")
                        .HasColumnType("int")
                        .HasColumnName("break_fast");

                    b.Property<string>("CardCvc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("card_cvc");

                    b.Property<string>("CardExp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("card_exp");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("card_number");

                    b.Property<string>("CardType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("card_type");

                    b.Property<bool>("CheckIn")
                        .HasColumnType("bit")
                        .HasColumnName("check_in");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("city");

                    b.Property<bool>("Cleaning")
                        .HasColumnType("bit")
                        .HasColumnName("cleaning");

                    b.Property<int>("Dinner")
                        .HasColumnType("int")
                        .HasColumnName("dinner");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email_address");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("first_name");

                    b.Property<int>("FoodBill")
                        .HasColumnType("int")
                        .HasColumnName("food_bill");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_name");

                    b.Property<DateTime>("LeavingTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("leaving_time");

                    b.Property<int>("Lunch")
                        .HasColumnType("int")
                        .HasColumnName("lunch");

                    b.Property<int>("NumberGuest")
                        .HasColumnType("int")
                        .HasColumnName("number_guest");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("payment_type");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phone_number");

                    b.Property<string>("RoomFloor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("room_floor");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("room_number");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("room_type");

                    b.Property<bool>("SSurprise")
                        .HasColumnType("bit")
                        .HasColumnName("s_surprise");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("state");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("street_address");

                    b.Property<bool>("SupplyStatus")
                        .HasColumnType("bit")
                        .HasColumnName("supply_status");

                    b.Property<float>("TotalBill")
                        .HasColumnType("real")
                        .HasColumnName("total_bill");

                    b.Property<bool>("Towel")
                        .HasColumnType("bit")
                        .HasColumnName("towel");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("zip_code");

                    b.HasKey("Id");

                    b.ToTable("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
