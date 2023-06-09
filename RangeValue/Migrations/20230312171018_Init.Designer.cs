﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RangeValue.Data;

#nullable disable

namespace RangeValue.Migrations
{
    [DbContext(typeof(RangeContext))]
    [Migration("20230312171018_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RangeValue.Data.Entities.RangeControl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("firstNumber")
                        .HasColumnType("float");

                    b.Property<string>("firstOperand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("secondNumber")
                        .HasColumnType("float");

                    b.Property<string>("secondOperand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RangeControls");
                });

            modelBuilder.Entity("RangeValue.Data.Entities.Result", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("rangeId")
                        .HasColumnType("int");

                    b.Property<int>("score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("rangeId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("RangeValue.Data.Entities.Result", b =>
                {
                    b.HasOne("RangeValue.Data.Entities.RangeControl", "range")
                        .WithMany()
                        .HasForeignKey("rangeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("range");
                });
#pragma warning restore 612, 618
        }
    }
}
