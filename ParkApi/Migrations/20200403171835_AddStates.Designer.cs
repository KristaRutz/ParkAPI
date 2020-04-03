﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkApi.Models;

namespace ParkApi.Migrations
{
    [DbContext(typeof(ParkApiContext))]
    [Migration("20200403171835_AddStates")]
    partial class AddStates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParkApi.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Location");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("StateId");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("ParkId");

                    b.HasIndex("StateId");

                    b.ToTable("Parks");
                });

            modelBuilder.Entity("ParkApi.Models.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("NumberParks");

                    b.HasKey("StateId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("ParkApi.Models.Park", b =>
                {
                    b.HasOne("ParkApi.Models.State", "State")
                        .WithMany("Parks")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
