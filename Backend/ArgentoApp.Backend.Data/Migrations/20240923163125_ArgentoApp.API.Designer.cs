﻿// <auto-generated />
using System;
using ArgentoApp.Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ArgentoApp.Backend.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240923163125_ArgentoApp.Backend.API")]
    partial class ArgentoAppAPI
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("ArgentoApp.Backend.Entity.Concrete.Abstact.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Properties")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(9870),
                            ImageUrl = "",
                            IsActive = true,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(9870),
                            Name = "Kırmızı Jasper",
                            Price = 100m,
                            Properties = "Kırmızı Jasper",
                            Url = "Jasper"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(9880),
                            ImageUrl = "",
                            IsActive = true,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(9880),
                            Name = "Turuncu Kalsit",
                            Price = 200m,
                            Properties = "Turuncu Kalsit",
                            Url = "Kalsit"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(9880),
                            ImageUrl = "",
                            IsActive = true,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(9890),
                            Name = "Kaplan Gözü ",
                            Price = 300m,
                            Properties = "Kaplan Gözü",
                            Url = "KaplanGozu"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(9890),
                            ImageUrl = "",
                            IsActive = true,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(9890),
                            Name = "Moldavit",
                            Price = 400m,
                            Properties = "Moldavit",
                            Url = "Moldavit"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 5,
                            CreatedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(9900),
                            ImageUrl = "",
                            IsActive = true,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(9900),
                            Name = "Larimar",
                            Price = 500m,
                            Properties = "Larimar",
                            Url = "Larimar"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(9910),
                            ImageUrl = "",
                            IsActive = true,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(9910),
                            Name = "Sodalit",
                            Price = 600m,
                            Properties = "Sodalit",
                            Url = "Sodalit"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 7,
                            CreatedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(9910),
                            ImageUrl = "",
                            IsActive = true,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(9920),
                            Name = "Kristal Kuvars",
                            Price = 700m,
                            Properties = "Kristal Kuvars",
                            Url = "KristalKuvars"
                        });
                });

            modelBuilder.Entity("ArgentoApp.Backend.Entity.Concrete.CancelledOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adress")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CancelledOrders");
                });

            modelBuilder.Entity("ArgentoApp.Backend.Entity.Concrete.CancelledOrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CancelledOrderId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CancelledOrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("CancelledOrderItems");
                });

            modelBuilder.Entity("ArgentoApp.Backend.Entity.Concrete.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(7270),
                            UserId = "1"
                        });
                });

            modelBuilder.Entity("ArgentoApp.Backend.Entity.Concrete.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CartId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quentity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ArgentoApp.Backend.Entity.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("date('now')");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("date('now')");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(8900),
                            Description = "Kök çakra ile uyumlu taşlar burada. Kırmızı renk ile ifade edilir.",
                            IsActive = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(8900),
                            Name = "1. Kök Çakra (Muladhara Çakra)",
                            Url = "Kök"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(8910),
                            Description = "Sakral çakra ile uyumlu taşlar burada. Turuncu renk ile ifade edilir.",
                            IsActive = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(8910),
                            Name = "2.Sakral Çakra (Svadhistana Çakra)",
                            Url = "Sakral"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(8910),
                            Description = "Solar Plexus çakra ile uyumlu taşlar burada. Sarı renk ile ifade edilir.",
                            IsActive = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(8910),
                            Name = "3. Solar Pleksus Çakra(Manipura Çakra)",
                            Url = "SolarPlexus"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(8910),
                            Description = "Kalp çakrası ile uyumlu taşlar burada. Yeşil renk ile ifade edilir.",
                            IsActive = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(8910),
                            Name = "4.Kalp Çakrası (Anahata Çakra)",
                            Url = "Kalp"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(8920),
                            Description = "Boğaz çakrası ile uyumlu taşlar burada. Mavi renk ile ifade edilir.",
                            IsActive = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(8920),
                            Name = "5.Boğaz Çakrası (Vishuddha Çakra) ",
                            Url = "Boğaz"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(8920),
                            Description = "3.Göz çakrası ile uyumlu taşlar burada. İndigo mavi ile ifade edilir.",
                            IsActive = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(8920),
                            Name = "6.Üçüncü Göz Çakrası (Ajna Çakra)",
                            Url = "3.Göz"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(8920),
                            Description = "Taç çakra ile uyumlu taşlar burada. Menekşe rengi ile ifade edilir.",
                            IsActive = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 19, 31, 25, 9, DateTimeKind.Local).AddTicks(8930),
                            Name = "7.Taç Çakra (Sahasrara Çakra)",
                            Url = "Taç"
                        });
                });

            modelBuilder.Entity("ArgentoApp.Backend.Entity.Concrete.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adress")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCancel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderState")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PaymentType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ArgentoApp.Backend.Entity.Concrete.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("ArgentoApp.Backend.Entity.Concrete.Abstact.Product", b =>
                {
                    b.HasOne("ArgentoApp.Backend.Entity.Concrete.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ArgentoApp.Backend.Entity.Concrete.CancelledOrderItem", b =>
                {
                    b.HasOne("ArgentoApp.Backend.Entity.Concrete.CancelledOrder", "CancelledOrder")
                        .WithMany("OrderItems")
                        .HasForeignKey("CancelledOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArgentoApp.Backend.Entity.Concrete.Abstact.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CancelledOrder");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ArgentoApp.Backend.Entity.Concrete.CartItem", b =>
                {
                    b.HasOne("ArgentoApp.Backend.Entity.Concrete.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArgentoApp.Backend.Entity.Concrete.Abstact.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ArgentoApp.Backend.Entity.Concrete.OrderItem", b =>
                {
                    b.HasOne("ArgentoApp.Backend.Entity.Concrete.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArgentoApp.Backend.Entity.Concrete.Abstact.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ArgentoApp.Backend.Entity.Concrete.CancelledOrder", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("ArgentoApp.Backend.Entity.Concrete.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("ArgentoApp.Backend.Entity.Concrete.Order", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}