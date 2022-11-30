﻿// <auto-generated />
using System;
using LibraryBook.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryBook.EF.Migrations
{
    [DbContext(typeof(LibraryBookContext))]
    [Migration("20221130045109_fix-column-ProfilePic")]
    partial class fixcolumnProfilePic
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LibraryBook.Business.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("auhor");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Editor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("editor");

                    b.Property<Guid>("IdGender")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_gender");

                    b.Property<Guid>("IdUser")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_user");

                    b.Property<int>("IsbnNumber")
                        .HasMaxLength(20)
                        .HasColumnType("int")
                        .HasColumnName("isbnNumber");

                    b.Property<string>("PictureBook")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("pictureBook");

                    b.Property<string>("Synopsis")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("synopsis");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.HasIndex("IdGender");

                    b.HasIndex("IdUser");

                    b.ToTable("tb_book", (string)null);
                });

            modelBuilder.Entity("LibraryBook.Business.Entities.Gender", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("tb_gender", (string)null);
                });

            modelBuilder.Entity("LibraryBook.Business.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("fullName");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("password");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("phoneNumber");

                    b.Property<string>("ProfilePic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("profilePic");

                    b.HasKey("Id");

                    b.ToTable("tb_users", (string)null);
                });

            modelBuilder.Entity("LibraryBook.Business.Entities.Book", b =>
                {
                    b.HasOne("LibraryBook.Business.Entities.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("IdGender")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryBook.Business.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
