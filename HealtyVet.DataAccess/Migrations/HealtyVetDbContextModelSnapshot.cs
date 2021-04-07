﻿// <auto-generated />
using System;
using HealtyVet.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HealtyVet.DataAccess.Migrations
{
    [DbContext(typeof(HealtyVetDbContext))]
    partial class HealtyVetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HealtyVet.ApplicationLogic.Data.Appointment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PetOwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PetOwnerId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("HealtyVet.ApplicationLogic.Data.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("FeedbacksId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FeedbacksId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("HealtyVet.ApplicationLogic.Data.Feedback", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("HealtyVet.ApplicationLogic.Data.Pet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PetOwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PetOwnerId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("HealtyVet.ApplicationLogic.Data.PetOwner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("FeedbacksId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FeedbacksId");

                    b.ToTable("PetOwners");
                });

            modelBuilder.Entity("HealtyVet.ApplicationLogic.Data.Servicii", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AppointmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("HealtyVet.ApplicationLogic.Data.Appointment", b =>
                {
                    b.HasOne("HealtyVet.ApplicationLogic.Data.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId");

                    b.HasOne("HealtyVet.ApplicationLogic.Data.PetOwner", "PetOwner")
                        .WithMany("Appointments")
                        .HasForeignKey("PetOwnerId");
                });

            modelBuilder.Entity("HealtyVet.ApplicationLogic.Data.Doctor", b =>
                {
                    b.HasOne("HealtyVet.ApplicationLogic.Data.Feedback", "Feedbacks")
                        .WithMany()
                        .HasForeignKey("FeedbacksId");
                });

            modelBuilder.Entity("HealtyVet.ApplicationLogic.Data.Pet", b =>
                {
                    b.HasOne("HealtyVet.ApplicationLogic.Data.PetOwner", null)
                        .WithMany("Pets")
                        .HasForeignKey("PetOwnerId");
                });

            modelBuilder.Entity("HealtyVet.ApplicationLogic.Data.PetOwner", b =>
                {
                    b.HasOne("HealtyVet.ApplicationLogic.Data.Feedback", "Feedbacks")
                        .WithMany()
                        .HasForeignKey("FeedbacksId");
                });

            modelBuilder.Entity("HealtyVet.ApplicationLogic.Data.Servicii", b =>
                {
                    b.HasOne("HealtyVet.ApplicationLogic.Data.Appointment", null)
                        .WithMany("Services")
                        .HasForeignKey("AppointmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
