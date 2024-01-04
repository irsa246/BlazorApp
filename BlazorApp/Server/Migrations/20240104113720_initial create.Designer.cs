﻿// <auto-generated />
using BlazorApp.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorApp.Server.Migrations
{
    [DbContext(typeof(WebDbContext))]
    [Migration("20240104113720_initial create")]
    partial class initialcreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorApp.Shared.Course", b =>
                {
                    b.Property<int>("course_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("course_Id"));

                    b.Property<string>("course_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("marks")
                        .HasColumnType("int");

                    b.Property<int>("studentstd_Id")
                        .HasColumnType("int");

                    b.HasKey("course_Id");

                    b.HasIndex("studentstd_Id");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("BlazorApp.Shared.Student", b =>
                {
                    b.Property<int>("std_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("std_Id"));

                    b.Property<string>("std_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("std_Id");

                    b.ToTable("students");
                });

            modelBuilder.Entity("BlazorApp.Shared.Course", b =>
                {
                    b.HasOne("BlazorApp.Shared.Student", "student")
                        .WithMany()
                        .HasForeignKey("studentstd_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("student");
                });
#pragma warning restore 612, 618
        }
    }
}
