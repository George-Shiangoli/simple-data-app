﻿// <auto-generated />
using MachineSpecs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace MachineSpecs.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180523120422_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MachineSpecs.Models.Computer", b =>
                {
                    b.Property<int>("ComputerID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GraphicsCardID");

                    b.Property<decimal>("Memory");

                    b.Property<int>("Power");

                    b.Property<int>("ProcessorID");

                    b.Property<decimal>("StorageCapacity");

                    b.Property<string>("StorageType");

                    b.Property<decimal>("Weight");

                    b.HasKey("ComputerID");

                    b.HasIndex("GraphicsCardID");

                    b.HasIndex("ProcessorID");

                    b.ToTable("Computer","DEVTASK");
                });

            modelBuilder.Entity("MachineSpecs.Models.Connection", b =>
                {
                    b.Property<int>("ConnectionID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ComputerID");

                    b.Property<int>("PortID");

                    b.Property<int>("Quantity");

                    b.HasKey("ConnectionID");

                    b.HasIndex("ComputerID");

                    b.HasIndex("PortID");

                    b.ToTable("Connection","DEVTASK");
                });

            modelBuilder.Entity("MachineSpecs.Models.GraphicsCard", b =>
                {
                    b.Property<int>("GraphicsCardID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Manufacturer");

                    b.Property<string>("Model");

                    b.HasKey("GraphicsCardID");

                    b.ToTable("GraphicsCard","DEVTASK");
                });

            modelBuilder.Entity("MachineSpecs.Models.Port", b =>
                {
                    b.Property<int>("PortID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("PortID");

                    b.ToTable("Port","DEVTASK");
                });

            modelBuilder.Entity("MachineSpecs.Models.Processor", b =>
                {
                    b.Property<int>("ProcessorID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Manufacturer");

                    b.Property<string>("Model");

                    b.HasKey("ProcessorID");

                    b.ToTable("Processor","DEVTASK");
                });

            modelBuilder.Entity("MachineSpecs.Models.Computer", b =>
                {
                    b.HasOne("MachineSpecs.Models.GraphicsCard", "GraphicsCard")
                        .WithMany()
                        .HasForeignKey("GraphicsCardID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MachineSpecs.Models.Processor", "Processor")
                        .WithMany()
                        .HasForeignKey("ProcessorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MachineSpecs.Models.Connection", b =>
                {
                    b.HasOne("MachineSpecs.Models.Computer", "Computer")
                        .WithMany("Connections")
                        .HasForeignKey("ComputerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MachineSpecs.Models.Port", "Port")
                        .WithMany()
                        .HasForeignKey("PortID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
