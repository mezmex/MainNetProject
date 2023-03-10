// <auto-generated />
using eShopDashboard.Infrastructure.Data.Ordering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace eShopDashboard.Infrastructure.Migrations.Ordering
{
    [DbContext(typeof(OrderingContext))]
    [Migration("20180429181848_InitialMigration_OrderingContext")]
    partial class InitialMigration_OrderingContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eShopDashboard.EntityModels.Ordering.Order", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Address_Country")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("OrderDate");

                    b.HasKey("Id");

                    b.ToTable("Orders","Ordering");
                });

            modelBuilder.Entity("eShopDashboard.EntityModels.Ordering.OrderItem", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<decimal>("UnitPrice");

                    b.Property<int>("Units");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems","Ordering");
                });

            modelBuilder.Entity("eShopDashboard.EntityModels.Ordering.OrderItem", b =>
                {
                    b.HasOne("eShopDashboard.EntityModels.Ordering.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
