﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restoran.models;

namespace Restoran.Migrations
{
    [DbContext(typeof(RestoranDBContext))]
    partial class RestoranDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Restoran.models.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("PDV")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("RestaurantUnitUnitId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("time");

                    b.Property<int>("TotalAmouth")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BillId");

                    b.HasIndex("RestaurantUnitUnitId");

                    b.HasIndex("UserId");

                    b.ToTable("bills");
                });

            modelBuilder.Entity("Restoran.models.BillMeal", b =>
                {
                    b.Property<int>("BillId")
                        .HasColumnType("int");

                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.Property<int>("Col")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("BillId", "MealId");

                    b.HasIndex("MealId");

                    b.ToTable("billMeals");
                });

            modelBuilder.Entity("Restoran.models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("Restoran.models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZIPCode")
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.HasKey("CityId");

                    b.HasIndex("ZIPCode")
                        .IsUnique()
                        .HasFilter("[ZIPCode] IS NOT NULL");

                    b.ToTable("cities");
                });

            modelBuilder.Entity("Restoran.models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CountryId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("countries");
                });

            modelBuilder.Entity("Restoran.models.Location", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityFK")
                        .HasColumnType("int");

                    b.Property<int>("CountryFK")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StreetNo")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("CityFK")
                        .IsUnique();

                    b.HasIndex("CountryFK")
                        .IsUnique();

                    b.ToTable("locations");
                });

            modelBuilder.Entity("Restoran.models.Meal", b =>
                {
                    b.Property<int>("MealId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OfferEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("OfferStart")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("SpecialOffer")
                        .HasColumnType("int");

                    b.HasKey("MealId");

                    b.HasIndex("CategoryId");

                    b.ToTable("meals");
                });

            modelBuilder.Entity("Restoran.models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BillFK")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RestaurantUnitUnitId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("time");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OrderId");

                    b.HasIndex("BillFK")
                        .IsUnique();

                    b.HasIndex("RestaurantUnitUnitId");

                    b.HasIndex("UserId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("Restoran.models.OrderMeal", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.Property<int>("Col")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "MealId");

                    b.HasIndex("MealId");

                    b.ToTable("OrderMeal");
                });

            modelBuilder.Entity("Restoran.models.Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OwnerId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("owners");
                });

            modelBuilder.Entity("Restoran.models.Recipe", b =>
                {
                    b.Property<int>("RecpeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ingredients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MealId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PreparationTime")
                        .HasColumnType("int");

                    b.Property<string>("RecipeText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecpeId");

                    b.HasIndex("MealId");

                    b.ToTable("recipes");
                });

            modelBuilder.Entity("Restoran.models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ClosingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("GeneralEmployeeNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OpeningDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TelOfficial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RestaurantId");

                    b.ToTable("restaurants");
                });

            modelBuilder.Entity("Restoran.models.RestaurantUnit", b =>
                {
                    b.Property<int>("UnitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("ClosingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeNo")
                        .HasColumnType("int");

                    b.Property<int?>("Locationid")
                        .HasColumnType("int");

                    b.Property<DateTime>("OpeningDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UnitId");

                    b.HasIndex("Locationid");

                    b.HasIndex("RestaurantId");

                    b.ToTable("restaurantUnits");
                });

            modelBuilder.Entity("Restoran.models.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OvertimeHours")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int?>("RestaurantUnitUnitId")
                        .HasColumnType("int");

                    b.Property<int?>("ShiftId")
                        .HasColumnType("int");

                    b.Property<int?>("WorkPlaceWPId")
                        .HasColumnType("int");

                    b.HasKey("ScheduleId");

                    b.HasIndex("RestaurantUnitUnitId");

                    b.HasIndex("ShiftId");

                    b.HasIndex("WorkPlaceWPId");

                    b.ToTable("schedules");
                });

            modelBuilder.Entity("Restoran.models.Shift", b =>
                {
                    b.Property<int>("ShiftId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("ShiftId");

                    b.ToTable("shifts");
                });

            modelBuilder.Entity("Restoran.models.SpecialOffer", b =>
                {
                    b.Property<int>("SpecOfferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpecOfferId");

                    b.HasIndex("MealId");

                    b.ToTable("specialOffers");
                });

            modelBuilder.Entity("Restoran.models.Table", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumOfChairs")
                        .HasColumnType("int");

                    b.Property<int?>("RestaurantUnitUnitId")
                        .HasColumnType("int");

                    b.Property<int?>("TablePositionTPId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TableId");

                    b.HasIndex("RestaurantUnitUnitId");

                    b.HasIndex("TablePositionTPId");

                    b.HasIndex("UserId");

                    b.ToTable("tables");
                });

            modelBuilder.Entity("Restoran.models.TablePosition", b =>
                {
                    b.Property<int>("TPId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TPId");

                    b.ToTable("tablePositions");
                });

            modelBuilder.Entity("Restoran.models.UnitMenu", b =>
                {
                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.Property<int?>("AllRestaurantUnitUnitId")
                        .HasColumnType("int");

                    b.HasKey("MealId", "UnitId");

                    b.HasIndex("AllRestaurantUnitUnitId");

                    b.ToTable("unitMenus");
                });

            modelBuilder.Entity("Restoran.models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int?>("RestaurantUnitUnitId")
                        .HasColumnType("int");

                    b.Property<int?>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ShiftId")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("RestaurantUnitUnitId");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("ShiftId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Restoran.models.WorkPlace", b =>
                {
                    b.Property<int>("WPId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OvertimeBonus")
                        .HasColumnType("int");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("WPId");

                    b.ToTable("workPlaces");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Restoran.models.User", null)
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Restoran.models.User", null)
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restoran.models.User", null)
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Restoran.models.User", null)
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restoran.models.Bill", b =>
                {
                    b.HasOne("Restoran.models.RestaurantUnit", "RestaurantUnit")
                        .WithMany("Bills")
                        .HasForeignKey("RestaurantUnitUnitId");

                    b.HasOne("Restoran.models.User", "User")
                        .WithMany("Bills")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Restoran.models.BillMeal", b =>
                {
                    b.HasOne("Restoran.models.Bill", "Bill")
                        .WithMany("BillMeals")
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restoran.models.Meal", "Meal")
                        .WithMany("BillMeals")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restoran.models.Location", b =>
                {
                    b.HasOne("Restoran.models.City", "City")
                        .WithOne("Location")
                        .HasForeignKey("Restoran.models.Location", "CityFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restoran.models.Country", "Country")
                        .WithOne("Location")
                        .HasForeignKey("Restoran.models.Location", "CountryFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restoran.models.Meal", b =>
                {
                    b.HasOne("Restoran.models.Category", "Category")
                        .WithMany("meals")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Restoran.models.Order", b =>
                {
                    b.HasOne("Restoran.models.Bill", "Bill")
                        .WithOne("Order")
                        .HasForeignKey("Restoran.models.Order", "BillFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restoran.models.RestaurantUnit", "RestaurantUnit")
                        .WithMany("Orders")
                        .HasForeignKey("RestaurantUnitUnitId");

                    b.HasOne("Restoran.models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Restoran.models.OrderMeal", b =>
                {
                    b.HasOne("Restoran.models.Meal", "Meal")
                        .WithMany("OrderMeals")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restoran.models.Order", "Order")
                        .WithMany("OrderMeals")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restoran.models.Owner", b =>
                {
                    b.HasOne("Restoran.models.Restaurant", "Restaurant")
                        .WithMany("Owners")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Restoran.models.Recipe", b =>
                {
                    b.HasOne("Restoran.models.Meal", "Meal")
                        .WithMany("Recipe")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Restoran.models.RestaurantUnit", b =>
                {
                    b.HasOne("Restoran.models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("Locationid");

                    b.HasOne("Restoran.models.Restaurant", "Restaurant")
                        .WithMany("RestaurantUnits")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Restoran.models.Schedule", b =>
                {
                    b.HasOne("Restoran.models.RestaurantUnit", "RestaurantUnit")
                        .WithMany("schedules")
                        .HasForeignKey("RestaurantUnitUnitId");

                    b.HasOne("Restoran.models.Shift", "Shift")
                        .WithMany("Schedules")
                        .HasForeignKey("ShiftId");

                    b.HasOne("Restoran.models.WorkPlace", "WorkPlace")
                        .WithMany("Schedules")
                        .HasForeignKey("WorkPlaceWPId");
                });

            modelBuilder.Entity("Restoran.models.SpecialOffer", b =>
                {
                    b.HasOne("Restoran.models.Meal", "Meal")
                        .WithMany("specialOffers")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restoran.models.Table", b =>
                {
                    b.HasOne("Restoran.models.RestaurantUnit", "RestaurantUnit")
                        .WithMany("Tables")
                        .HasForeignKey("RestaurantUnitUnitId");

                    b.HasOne("Restoran.models.TablePosition", "TablePosition")
                        .WithMany("Tables")
                        .HasForeignKey("TablePositionTPId");

                    b.HasOne("Restoran.models.User", "User")
                        .WithMany("Tables")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Restoran.models.UnitMenu", b =>
                {
                    b.HasOne("Restoran.models.RestaurantUnit", "AllRestaurantUnit")
                        .WithMany("UnitMenus")
                        .HasForeignKey("AllRestaurantUnitUnitId");

                    b.HasOne("Restoran.models.Meal", "AllMeals")
                        .WithMany("unitMenus")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restoran.models.User", b =>
                {
                    b.HasOne("Restoran.models.RestaurantUnit", "RestaurantUnit")
                        .WithMany("Users")
                        .HasForeignKey("RestaurantUnitUnitId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Restoran.models.Schedule", "Schedule")
                        .WithMany("Users")
                        .HasForeignKey("ScheduleId");

                    b.HasOne("Restoran.models.Shift", "Shift")
                        .WithMany("Users")
                        .HasForeignKey("ShiftId");
                });
#pragma warning restore 612, 618
        }
    }
}
