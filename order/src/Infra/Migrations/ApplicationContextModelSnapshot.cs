﻿// <auto-generated />
using System;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infra.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Customers.Entity.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Infra.Models.EFCore.AddressModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("city");

                    b.Property<string>("Complement")
                        .HasColumnType("text")
                        .HasColumnName("complement");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("country");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uuid")
                        .HasColumnName("customer_id");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("'neighborhood");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("number");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("state");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("street");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("zip_code");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("addresses", (string)null);
                });

            modelBuilder.Entity("Infra.Models.EFCore.CategoryModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("Infra.Models.EFCore.CouponModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("ExpiressAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("expiress_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<double>("Value")
                        .HasColumnType("double precision")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.ToTable("coupons", (string)null);
                });

            modelBuilder.Entity("Infra.Models.EFCore.CustomerModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date")
                        .HasColumnName("birth_date");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)")
                        .HasColumnName("cpf");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)")
                        .HasColumnName("phone");

                    b.HasKey("Id");

                    b.ToTable("customers", (string)null);
                });

            modelBuilder.Entity("Infra.Models.EFCore.LineItemModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<double>("Amount")
                        .HasColumnType("double precision")
                        .HasColumnName("price_amount");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)")
                        .HasColumnName("price_currency");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid")
                        .HasColumnName("order_id");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid")
                        .HasColumnName("product_id");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer")
                        .HasColumnName("quantity");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("line_items", (string)null);
                });

            modelBuilder.Entity("Infra.Models.EFCore.OrderModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid?>("BillingAddressId")
                        .HasColumnType("uuid")
                        .HasColumnName("billing_address_id");

                    b.Property<Guid?>("CouponId")
                        .HasColumnType("uuid")
                        .HasColumnName("coupon_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uuid")
                        .HasColumnName("customer_id");

                    b.Property<Guid?>("ShippingAddressId")
                        .HasColumnType("uuid")
                        .HasColumnName("shipping_address_id");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("status");

                    b.Property<double>("Total")
                        .HasColumnType("double precision")
                        .HasColumnName("total");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("BillingAddressId");

                    b.HasIndex("CouponId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ShippingAddressId");

                    b.ToTable("orders", (string)null);
                });

            modelBuilder.Entity("Infra.Models.EFCore.ProductsModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double>("Amount")
                        .HasColumnType("double precision")
                        .HasColumnName("price_amount");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid")
                        .HasColumnName("category_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)")
                        .HasColumnName("price_currency");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)")
                        .HasColumnName("description");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("name");

                    b.Property<string>("Sku")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("sku");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("products", (string)null);
                });

            modelBuilder.Entity("Infra.Models.EFCore.AddressModel", b =>
                {
                    b.HasOne("Infra.Models.EFCore.CustomerModel", null)
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infra.Models.EFCore.LineItemModel", b =>
                {
                    b.HasOne("Infra.Models.EFCore.OrderModel", null)
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infra.Models.EFCore.ProductsModel", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infra.Models.EFCore.OrderModel", b =>
                {
                    b.HasOne("Infra.Models.EFCore.AddressModel", null)
                        .WithMany()
                        .HasForeignKey("BillingAddressId");

                    b.HasOne("Infra.Models.EFCore.CouponModel", "Coupon")
                        .WithMany()
                        .HasForeignKey("CouponId");

                    b.HasOne("Infra.Models.EFCore.CustomerModel", null)
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infra.Models.EFCore.AddressModel", null)
                        .WithMany()
                        .HasForeignKey("ShippingAddressId");

                    b.Navigation("Coupon");
                });

            modelBuilder.Entity("Infra.Models.EFCore.ProductsModel", b =>
                {
                    b.HasOne("Infra.Models.EFCore.CategoryModel", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Infra.Models.EFCore.OrderModel", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
