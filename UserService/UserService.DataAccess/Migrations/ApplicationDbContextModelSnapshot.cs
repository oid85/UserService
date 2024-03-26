﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserService.DataAccess.Db;

#nullable disable

namespace UserService.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.28");

            modelBuilder.Entity("UserService.Domain.Entities.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Domain")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = new Guid("091c5601-8648-4f43-8a46-cb1662023058"),
                            Domain = "example1.com",
                            Value = "value1"
                        },
                        new
                        {
                            Id = new Guid("443cd29d-86c8-4dc0-821a-3b2f262f18aa"),
                            Domain = "example2.com",
                            Value = "value2"
                        },
                        new
                        {
                            Id = new Guid("28163433-c281-4e02-8330-6163aa6795dc"),
                            Domain = "example3.com",
                            Value = "value3"
                        });
                });

            modelBuilder.Entity("UserService.Domain.Entities.TagToUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("TagId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TagId");

                    b.HasIndex("UserId");

                    b.ToTable("TagToUsers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("819b2781-9d76-48d7-bcb9-085da8c44205"),
                            TagId = new Guid("091c5601-8648-4f43-8a46-cb1662023058"),
                            UserId = new Guid("d8d51a5e-1350-4bb0-b96b-190406924a68")
                        },
                        new
                        {
                            Id = new Guid("506ae79f-0690-447c-925b-66517d206309"),
                            TagId = new Guid("443cd29d-86c8-4dc0-821a-3b2f262f18aa"),
                            UserId = new Guid("c635ff1a-11f3-40d5-99f7-7f53886e5d82")
                        },
                        new
                        {
                            Id = new Guid("4472f9de-d200-4c9f-95a1-ae11f4b66cc1"),
                            TagId = new Guid("28163433-c281-4e02-8330-6163aa6795dc"),
                            UserId = new Guid("76d9b3bb-5251-42fa-aa82-d325e7283f17")
                        });
                });

            modelBuilder.Entity("UserService.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Domain")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d8d51a5e-1350-4bb0-b96b-190406924a68"),
                            Domain = "example1.com",
                            Name = "user1"
                        },
                        new
                        {
                            Id = new Guid("c635ff1a-11f3-40d5-99f7-7f53886e5d82"),
                            Domain = "example2.com",
                            Name = "user2"
                        },
                        new
                        {
                            Id = new Guid("76d9b3bb-5251-42fa-aa82-d325e7283f17"),
                            Domain = "example3.com",
                            Name = "user3"
                        });
                });

            modelBuilder.Entity("UserService.Domain.Entities.TagToUser", b =>
                {
                    b.HasOne("UserService.Domain.Entities.Tag", "Tag")
                        .WithMany("TagToUsers")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UserService.Domain.Entities.User", "User")
                        .WithMany("TagToUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tag");

                    b.Navigation("User");
                });

            modelBuilder.Entity("UserService.Domain.Entities.Tag", b =>
                {
                    b.Navigation("TagToUsers");
                });

            modelBuilder.Entity("UserService.Domain.Entities.User", b =>
                {
                    b.Navigation("TagToUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
