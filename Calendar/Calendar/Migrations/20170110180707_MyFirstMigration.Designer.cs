using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Calendar;

namespace Calendar.Migrations
{
    [DbContext(typeof(CalendarContext))]
    [Migration("20170110180707_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("Calendar.Entry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("Duration");

                    b.Property<string>("Subject");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.ToTable("Entries");
                });
        }
    }
}
