﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230906220726_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("Domain.WeighIn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Bmi")
                        .HasColumnType("TEXT");

                    b.Property<int>("BodyAge")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("BodyFatPercent")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("MusclePercent")
                        .HasColumnType("TEXT");

                    b.Property<int>("RestingMetabolismCalories")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VisceralFat")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Weight")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("WeighIns");
                });
#pragma warning restore 612, 618
        }
    }
}