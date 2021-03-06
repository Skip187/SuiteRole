﻿// <auto-generated />
using GroupProject3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GroupProject3.Migrations
{
    [DbContext(typeof(ResidentsContext))]
    partial class ResidentsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("GroupProject3.Models.Resident", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AcctOwner");

                    b.Property<string>("ContactNum1");

                    b.Property<string>("ContactNum2");

                    b.Property<string>("ContactNum3");

                    b.Property<string>("Email1");

                    b.Property<string>("Email2");

                    b.Property<string>("Email3");

                    b.Property<string>("Email4");

                    b.Property<string>("FirstName1");

                    b.Property<string>("LastName1");

                    b.Property<string>("ParkingSpot1");

                    b.Property<string>("ParkingSpot2");

                    b.Property<string>("StorageNum");

                    b.Property<string>("UnitNum");

                    b.HasKey("ID");

                    b.ToTable("Residents");
                });
#pragma warning restore 612, 618
        }
    }
}
