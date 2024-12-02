﻿// <auto-generated />
using System;
using BlazorDynamicApp.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorDynamicApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241125220748_AddResources")]
    partial class AddResources
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorDynamicApp.Models.Identity.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "de820986-a707-4cc5-8306-776812617837",
                            ConcurrencyStamp = "68cfd492-e5d9-4942-be8d-d83cf2f133cb",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = "8815f0d6-db8e-4606-8acb-12844e7b796b",
                            ConcurrencyStamp = "58e76bc7-5f25-4140-9883-bc1b5de5c0e9",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "11c174c2-94cc-4615-8d46-4655dee45ea7",
                            ConcurrencyStamp = "a1f0e591-dd95-4aa4-a48d-8b7d83c97c9c",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "d140eb54-ed6e-4ff2-9199-71fcbe722ef7",
                            ConcurrencyStamp = "e9543a42-af9a-4b47-815e-69576f8d90d1",
                            Name = "Member",
                            NormalizedName = "MEMBER"
                        });
                });

            modelBuilder.Entity("BlazorDynamicApp.Models.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "256ac0cc-c4b0-458d-957d-24cbfd49225b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3aa34fbc-6ab0-4873-a760-56c5933de26b",
                            Email = "pirmatovalisher000@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "PIRMATOVALISHER000@GMAIL.COM",
                            NormalizedUserName = "PIRMATOVALISHER000@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEGmD+z3l3Xfr5zGZaFSgIPqPsdb6N2LGCFBtSSaNgSUxI1WGr3/k7tyqZc1E5eFtbw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c6bb6bac-da86-499f-9bbe-75e332656068",
                            TwoFactorEnabled = false,
                            UserName = "pirmatovalisher000@gmail.com"
                        },
                        new
                        {
                            Id = "bb49ce85-c5c9-41d9-9665-321d430b7e2e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fe44a99b-438e-4a2e-aa52-f11521d8efdc",
                            Email = "pirmatovalisher2000@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "PIRMATOVALISHER2000@GMAIL.COM",
                            NormalizedUserName = "PIRMATOVALISHER2000@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDvZJXwsPvyUpd/Yx+zXT4ArCpuP4frNfxmhSKLW5lTo5R+4gYYU1CVdflqu9u/32Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ad1b5b03-cfc8-44cc-ab68-275a21d98375",
                            TwoFactorEnabled = false,
                            UserName = "pirmatovalisher2000@gmail.com"
                        },
                        new
                        {
                            Id = "d7ebd93d-0642-4ab9-8da3-4b6b2046e540",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "befb8a30-868f-4e53-b5c3-0c05761d2b18",
                            Email = "pirmatovalisher0000@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "PIRMATOVALISHER0000@GMAIL.COM",
                            NormalizedUserName = "PIRMATOVALISHER0000@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAECJYAlY1AzdP+zP2yXNTKcmJBBk4oHoa7nU5U8Qkgb8Ts/KZXG+Nd8jY3er/wlPuRA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c5438082-1104-45f7-8342-703ca1f5c2f6",
                            TwoFactorEnabled = false,
                            UserName = "pirmatovalisher0000@gmail.com"
                        },
                        new
                        {
                            Id = "2ade9cc9-9152-4209-ae22-f2e9e57b09a7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f107de0e-221e-40b0-948b-0ffb92e20d11",
                            Email = "pirmatovalisher@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "PIRMATOVALISHER@GMAIL.COM",
                            NormalizedUserName = "PIRMATOVALISHER@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAECEiwJElxp/2/v4NaB01elcrmAlmEe5rnCb718kkeIHbpHQTENb9NsCENIGAHP03SQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2b1043c8-7e3a-4461-807e-a984137ee8b8",
                            TwoFactorEnabled = false,
                            UserName = "pirmatovalisher@gmail.com"
                        });
                });

            modelBuilder.Entity("BlazorDynamicApp.Models.WebApp.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 31,
                            DateOfBirth = new DateTime(1994, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "DMA",
                            Name = "Arjun",
                            PhoneNumber = "+998943619925"
                        },
                        new
                        {
                            Id = 2,
                            Age = 42,
                            DateOfBirth = new DateTime(1983, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "Welding FD",
                            Name = "Satya",
                            PhoneNumber = "+998943568941"
                        },
                        new
                        {
                            Id = 3,
                            Age = 46,
                            DateOfBirth = new DateTime(1979, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "LCS",
                            Name = "Prashant",
                            PhoneNumber = "+998939784578"
                        },
                        new
                        {
                            Id = 4,
                            Age = 56,
                            DateOfBirth = new DateTime(1979, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "LCS",
                            Name = "Test4",
                            PhoneNumber = "+998939784578"
                        },
                        new
                        {
                            Id = 5,
                            Age = 22,
                            DateOfBirth = new DateTime(1979, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "LCS",
                            Name = "Test5",
                            PhoneNumber = "+998939784578"
                        },
                        new
                        {
                            Id = 6,
                            Age = 26,
                            DateOfBirth = new DateTime(1979, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "LCS",
                            Name = "Test6",
                            PhoneNumber = "+998939784578"
                        },
                        new
                        {
                            Id = 7,
                            Age = 31,
                            DateOfBirth = new DateTime(1979, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "LCS",
                            Name = "Test7",
                            PhoneNumber = "+998939784578"
                        });
                });

            modelBuilder.Entity("BlazorDynamicApp.Models.WebApp.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Sweet one",
                            Name = "Pumpkin",
                            Price = 9990
                        },
                        new
                        {
                            Id = 2,
                            Description = "Juicy tomato",
                            Name = "Tomato",
                            Price = 5990
                        },
                        new
                        {
                            Id = 3,
                            Description = "Zero sugar",
                            Name = "Coca-Cola",
                            Price = 12990
                        },
                        new
                        {
                            Id = 4,
                            Description = "From Vietnam",
                            Name = "Orange",
                            Price = 7190
                        },
                        new
                        {
                            Id = 5,
                            Description = "Small one",
                            Name = "Cucumber",
                            Price = 3990
                        },
                        new
                        {
                            Id = 6,
                            Description = "Green one",
                            Name = "Pear",
                            Price = 5990
                        },
                        new
                        {
                            Id = 7,
                            Description = "Double peach",
                            Name = "Peach",
                            Price = 7790
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUserRole<string>");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BlazorDynamicApp.Models.Identity.ApplicationUserRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUserRole<string>");

                    b.HasDiscriminator().HasValue("ApplicationUserRole");

                    b.HasData(
                        new
                        {
                            UserId = "256ac0cc-c4b0-458d-957d-24cbfd49225b",
                            RoleId = "de820986-a707-4cc5-8306-776812617837"
                        },
                        new
                        {
                            UserId = "256ac0cc-c4b0-458d-957d-24cbfd49225b",
                            RoleId = "8815f0d6-db8e-4606-8acb-12844e7b796b"
                        },
                        new
                        {
                            UserId = "256ac0cc-c4b0-458d-957d-24cbfd49225b",
                            RoleId = "11c174c2-94cc-4615-8d46-4655dee45ea7"
                        },
                        new
                        {
                            UserId = "256ac0cc-c4b0-458d-957d-24cbfd49225b",
                            RoleId = "d140eb54-ed6e-4ff2-9199-71fcbe722ef7"
                        },
                        new
                        {
                            UserId = "bb49ce85-c5c9-41d9-9665-321d430b7e2e",
                            RoleId = "8815f0d6-db8e-4606-8acb-12844e7b796b"
                        },
                        new
                        {
                            UserId = "bb49ce85-c5c9-41d9-9665-321d430b7e2e",
                            RoleId = "11c174c2-94cc-4615-8d46-4655dee45ea7"
                        },
                        new
                        {
                            UserId = "bb49ce85-c5c9-41d9-9665-321d430b7e2e",
                            RoleId = "d140eb54-ed6e-4ff2-9199-71fcbe722ef7"
                        },
                        new
                        {
                            UserId = "d7ebd93d-0642-4ab9-8da3-4b6b2046e540",
                            RoleId = "11c174c2-94cc-4615-8d46-4655dee45ea7"
                        },
                        new
                        {
                            UserId = "d7ebd93d-0642-4ab9-8da3-4b6b2046e540",
                            RoleId = "d140eb54-ed6e-4ff2-9199-71fcbe722ef7"
                        },
                        new
                        {
                            UserId = "2ade9cc9-9152-4209-ae22-f2e9e57b09a7",
                            RoleId = "d140eb54-ed6e-4ff2-9199-71fcbe722ef7"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("BlazorDynamicApp.Models.Identity.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BlazorDynamicApp.Models.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BlazorDynamicApp.Models.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("BlazorDynamicApp.Models.Identity.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorDynamicApp.Models.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BlazorDynamicApp.Models.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}