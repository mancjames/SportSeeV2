﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportSeeV2.Server.Data;

#nullable disable

namespace SportSeeV2.Server.Migrations
{
    [DbContext(typeof(SportSeeDbContext))]
    partial class SportSeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("SportSeeV2.Server.Data.KeyDataEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CalorieCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CarbohydrateCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LipidCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProteinCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserMainEntityId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserMainEntityId")
                        .IsUnique();

                    b.ToTable("KeyDataEntities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CalorieCount = 1930,
                            CarbohydrateCount = 290,
                            LipidCount = 50,
                            ProteinCount = 155,
                            UserMainEntityId = 1
                        },
                        new
                        {
                            Id = 2,
                            CalorieCount = 2500,
                            CarbohydrateCount = 150,
                            LipidCount = 120,
                            ProteinCount = 90,
                            UserMainEntityId = 2
                        });
                });

            modelBuilder.Entity("SportSeeV2.Server.Data.UserInfosEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserMainEntityId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserMainEntityId")
                        .IsUnique();

                    b.ToTable("UserInfosEntities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 31,
                            FirstName = "Karl",
                            LastName = "Dovineau",
                            UserMainEntityId = 1
                        },
                        new
                        {
                            Id = 2,
                            Age = 34,
                            FirstName = "Cecilia",
                            LastName = "Ratorez",
                            UserMainEntityId = 2
                        });
                });

            modelBuilder.Entity("SportSeeV2.Server.Data.UserMainEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("TodayScore")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("UserMainEntities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TodayScore = 0.12f
                        },
                        new
                        {
                            Id = 2,
                            TodayScore = 0.3f
                        });
                });

            modelBuilder.Entity("SportSeeV2.Server.Data.KeyDataEntity", b =>
                {
                    b.HasOne("SportSeeV2.Server.Data.UserMainEntity", "UserMainEntity")
                        .WithOne("KeyData")
                        .HasForeignKey("SportSeeV2.Server.Data.KeyDataEntity", "UserMainEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserMainEntity");
                });

            modelBuilder.Entity("SportSeeV2.Server.Data.UserInfosEntity", b =>
                {
                    b.HasOne("SportSeeV2.Server.Data.UserMainEntity", "UserMainEntity")
                        .WithOne("UserInfos")
                        .HasForeignKey("SportSeeV2.Server.Data.UserInfosEntity", "UserMainEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserMainEntity");
                });

            modelBuilder.Entity("SportSeeV2.Server.Data.UserMainEntity", b =>
                {
                    b.Navigation("KeyData")
                        .IsRequired();

                    b.Navigation("UserInfos")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}