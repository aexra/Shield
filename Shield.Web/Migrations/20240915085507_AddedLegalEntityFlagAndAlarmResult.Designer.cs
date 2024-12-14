﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shield.Web.Data.Contexts;

#nullable disable

namespace Shield.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240915085507_AddedLegalEntityFlagAndAlarmResult")]
    partial class AddedLegalEntityFlagAndAlarmResult
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Shield.DataAccess.Models.Alarm", b =>
                {
                    b.Property<int>("AlarmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ContractId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("Result")
                        .HasColumnType("INTEGER");

                    b.HasKey("AlarmId");

                    b.HasIndex("ContractId");

                    b.ToTable("Alarms");
                });

            modelBuilder.Entity("Shield.DataAccess.Models.Contract", b =>
                {
                    b.Property<int>("ContractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Bailee")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsLegalEntity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Organization")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Owners")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("SignDate")
                        .HasColumnType("TEXT");

                    b.HasKey("ContractId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("Shield.DataAccess.Models.Picture", b =>
                {
                    b.Property<int>("PictureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ContractId")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PictureId");

                    b.HasIndex("ContractId")
                        .IsUnique();

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("Shield.DataAccess.Models.Plan", b =>
                {
                    b.Property<int>("PlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ContractId")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PlanId");

                    b.HasIndex("ContractId")
                        .IsUnique();

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("Shield.DataAccess.Models.Alarm", b =>
                {
                    b.HasOne("Shield.DataAccess.Models.Contract", "Contract")
                        .WithMany("Alarms")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contract");
                });

            modelBuilder.Entity("Shield.DataAccess.Models.Picture", b =>
                {
                    b.HasOne("Shield.DataAccess.Models.Contract", "Contract")
                        .WithOne("Picture")
                        .HasForeignKey("Shield.DataAccess.Models.Picture", "ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contract");
                });

            modelBuilder.Entity("Shield.DataAccess.Models.Plan", b =>
                {
                    b.HasOne("Shield.DataAccess.Models.Contract", "Contract")
                        .WithOne("Plan")
                        .HasForeignKey("Shield.DataAccess.Models.Plan", "ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contract");
                });

            modelBuilder.Entity("Shield.DataAccess.Models.Contract", b =>
                {
                    b.Navigation("Alarms");

                    b.Navigation("Picture")
                        .IsRequired();

                    b.Navigation("Plan")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
