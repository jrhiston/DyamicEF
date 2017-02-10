using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using efexample;

namespace efexample.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20170209161558_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Designation");

                    b.Property<int>("EmployeeID");

                    b.Property<string>("EmployeeName");

                    b.HasKey("Id");

                    b.ToTable("News");
                });
        }
    }
}
