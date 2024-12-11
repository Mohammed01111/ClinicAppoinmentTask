﻿// <auto-generated />
using System;
using ClinicAppoinmentTask;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClinicAppoinmentTask.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241211062409_initialize")]
    partial class initialize
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClinicAppoinmentTask.Model.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<int>("PID")
                        .HasColumnType("int");

                    b.Property<int>("CID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("SlotNumber")
                        .HasColumnType("int");

                    b.HasKey("BookingId", "PID", "CID");

                    b.HasIndex("CID");

                    b.HasIndex("PID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("ClinicAppoinmentTask.Model.Clinic", b =>
                {
                    b.Property<int>("CID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CID"));

                    b.Property<int>("NumberOfSlots")
                        .HasColumnType("int");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CID");

                    b.HasIndex("Specialization")
                        .IsUnique();

                    b.ToTable("Clinics");
                });

            modelBuilder.Entity("ClinicAppoinmentTask.Model.Patient", b =>
                {
                    b.Property<int>("PID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PID"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PID");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("ClinicAppoinmentTask.Model.Booking", b =>
                {
                    b.HasOne("ClinicAppoinmentTask.Model.Clinic", "Clinic")
                        .WithMany("Bookings")
                        .HasForeignKey("CID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicAppoinmentTask.Model.Patient", "Patient")
                        .WithMany("Bookings")
                        .HasForeignKey("PID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("ClinicAppoinmentTask.Model.Clinic", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("ClinicAppoinmentTask.Model.Patient", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
