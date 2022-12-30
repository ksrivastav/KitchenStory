﻿// <auto-generated />
using KitchenStoryInfrastructure.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KitchenStoryInfrastructure.Migrations
{
    [DbContext(typeof(KitchenStory_DbContext))]
    [Migration("20221230152200_initialdata")]
    partial class initialdata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KitchenStoryCore.DomainModel.ProductCategory", b =>
                {
                    b.Property<int>("ProductCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductCategoryId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tags")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductCategoryId");

                    b.ToTable("Productcategory", (string)null);

                    b.HasData(
                        new
                        {
                            ProductCategoryId = 1,
                            Description = "Shoes for all needs",
                            Name = "Shoes",
                            tags = "shoes"
                        },
                        new
                        {
                            ProductCategoryId = 2,
                            Description = "Shoes for all needs",
                            Name = "Sandals",
                            tags = "shoes"
                        },
                        new
                        {
                            ProductCategoryId = 3,
                            Description = "Shoes for all needs",
                            Name = "slip ons",
                            tags = "shoes"
                        },
                        new
                        {
                            ProductCategoryId = 4,
                            Description = "Shoes for all needs",
                            Name = "Test Prod Cat1",
                            tags = "shoes"
                        },
                        new
                        {
                            ProductCategoryId = 5,
                            Description = "Shoes for all needs",
                            Name = "Test Prod Cat2",
                            tags = "shoes"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
