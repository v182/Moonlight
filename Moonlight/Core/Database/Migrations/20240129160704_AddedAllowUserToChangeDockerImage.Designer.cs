﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Moonlight.Core.Database;

#nullable disable

namespace Moonlight.Core.Database.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240129160704_AddedAllowUserToChangeDockerImage")]
    partial class AddedAllowUserToChangeDockerImage
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("Moonlight.Core.Database.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Avatar")
                        .HasColumnType("TEXT");

                    b.Property<double>("Balance")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Flags")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Permissions")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TokenValidTimestamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("TotpKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Moonlight.Features.Community.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Moonlight.Features.Community.Entities.PostComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PostId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PostId");

                    b.ToTable("PostComments");
                });

            modelBuilder.Entity("Moonlight.Features.Community.Entities.PostLike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PostId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("PostLikes");
                });

            modelBuilder.Entity("Moonlight.Features.Community.Entities.WordFilter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Filter")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("WordFilters");
                });

            modelBuilder.Entity("Moonlight.Features.Servers.Entities.Server", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cpu")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Disk")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DockerImageIndex")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ImageId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MainAllocationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Memory")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NodeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OverrideStartupCommand")
                        .HasColumnType("TEXT");

                    b.Property<int>("ServiceId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("MainAllocationId");

                    b.HasIndex("NodeId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Servers");
                });

            modelBuilder.Entity("Moonlight.Features.Servers.Entities.ServerAllocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IpAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Port")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ServerId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ServerNodeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ServerId");

                    b.HasIndex("ServerNodeId");

                    b.ToTable("ServerAllocations");
                });

            modelBuilder.Entity("Moonlight.Features.Servers.Entities.ServerDockerImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AutoPull")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ServerImageId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ServerImageId");

                    b.ToTable("ServerDockerImages");
                });

            modelBuilder.Entity("Moonlight.Features.Servers.Entities.ServerImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AllocationsNeeded")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AllowUserToChangeDockerImage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DefaultDockerImageIndex")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DonateUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("InstallDockerImage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("InstallScript")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("InstallShell")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OnlineDetection")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ParseConfigurations")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StartupCommand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StopCommand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdateUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ServerImages");
                });

            modelBuilder.Entity("Moonlight.Features.Servers.Entities.ServerImageVariable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AllowUserToEdit")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AllowUserToView")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DefaultValue")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ServerImageId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ServerImageId");

                    b.ToTable("ServerImageVariables");
                });

            modelBuilder.Entity("Moonlight.Features.Servers.Entities.ServerNode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Fqdn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("FtpPort")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HttpPort")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("UseSsl")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("ServerNodes");
                });

            modelBuilder.Entity("Moonlight.Features.Servers.Entities.ServerVariable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ServerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ServerId");

                    b.ToTable("ServerVariables");
                });

            modelBuilder.Entity("Moonlight.Features.ServiceManagement.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConfigJsonOverride")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nickname")
                        .HasColumnType("TEXT");

                    b.Property<int>("OwnerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("RenewAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Suspended")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Moonlight.Features.ServiceManagement.Entities.ServiceShare", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.HasIndex("UserId");

                    b.ToTable("ServiceShares");
                });

            modelBuilder.Entity("Moonlight.Features.StoreSystem.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Moonlight.Features.StoreSystem.Entities.Coupon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Percent")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Coupons");
                });

            modelBuilder.Entity("Moonlight.Features.StoreSystem.Entities.CouponUse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CouponId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CouponId");

                    b.HasIndex("UserId");

                    b.ToTable("CouponUses");
                });

            modelBuilder.Entity("Moonlight.Features.StoreSystem.Entities.GiftCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Value")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("GiftCodes");
                });

            modelBuilder.Entity("Moonlight.Features.StoreSystem.Entities.GiftCodeUse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GiftCodeId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GiftCodeId");

                    b.HasIndex("UserId");

                    b.ToTable("GiftCodeUses");
                });

            modelBuilder.Entity("Moonlight.Features.StoreSystem.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConfigJson")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Duration")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxPerUser")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Stock")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Moonlight.Features.StoreSystem.Entities.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("Moonlight.Features.Theming.Entities.Theme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CssUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DonateUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Enabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("JsUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Themes");
                });

            modelBuilder.Entity("Moonlight.Features.Ticketing.Entities.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("CreatorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Open")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tries")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Moonlight.Features.Ticketing.Entities.TicketMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Attachment")
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsSupport")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SenderId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TicketId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SenderId");

                    b.HasIndex("TicketId");

                    b.ToTable("TicketMessages");
                });

            modelBuilder.Entity("Moonlight.Features.Community.Entities.Post", b =>
                {
                    b.HasOne("Moonlight.Core.Database.Entities.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Moonlight.Features.Community.Entities.PostComment", b =>
                {
                    b.HasOne("Moonlight.Core.Database.Entities.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Moonlight.Features.Community.Entities.Post", null)
                        .WithMany("Comments")
                        .HasForeignKey("PostId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Moonlight.Features.Community.Entities.PostLike", b =>
                {
                    b.HasOne("Moonlight.Features.Community.Entities.Post", null)
                        .WithMany("Likes")
                        .HasForeignKey("PostId");

                    b.HasOne("Moonlight.Core.Database.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Moonlight.Features.Servers.Entities.Server", b =>
                {
                    b.HasOne("Moonlight.Features.Servers.Entities.ServerImage", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Moonlight.Features.Servers.Entities.ServerAllocation", "MainAllocation")
                        .WithMany()
                        .HasForeignKey("MainAllocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Moonlight.Features.Servers.Entities.ServerNode", "Node")
                        .WithMany()
                        .HasForeignKey("NodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Moonlight.Features.ServiceManagement.Entities.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");

                    b.Navigation("MainAllocation");

                    b.Navigation("Node");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Moonlight.Features.Servers.Entities.ServerAllocation", b =>
                {
                    b.HasOne("Moonlight.Features.Servers.Entities.Server", null)
                        .WithMany("Allocations")
                        .HasForeignKey("ServerId");

                    b.HasOne("Moonlight.Features.Servers.Entities.ServerNode", null)
                        .WithMany("Allocations")
                        .HasForeignKey("ServerNodeId");
                });

            modelBuilder.Entity("Moonlight.Features.Servers.Entities.ServerDockerImage", b =>
                {
                    b.HasOne("Moonlight.Features.Servers.Entities.ServerImage", null)
                        .WithMany("DockerImages")
                        .HasForeignKey("ServerImageId");
                });

            modelBuilder.Entity("Moonlight.Features.Servers.Entities.ServerImageVariable", b =>
                {
                    b.HasOne("Moonlight.Features.Servers.Entities.ServerImage", null)
                        .WithMany("Variables")
                        .HasForeignKey("ServerImageId");
                });

            modelBuilder.Entity("Moonlight.Features.Servers.Entities.ServerVariable", b =>
                {
                    b.HasOne("Moonlight.Features.Servers.Entities.Server", null)
                        .WithMany("Variables")
                        .HasForeignKey("ServerId");
                });

            modelBuilder.Entity("Moonlight.Features.ServiceManagement.Entities.Service", b =>
                {
                    b.HasOne("Moonlight.Core.Database.Entities.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Moonlight.Features.StoreSystem.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Moonlight.Features.ServiceManagement.Entities.ServiceShare", b =>
                {
                    b.HasOne("Moonlight.Features.ServiceManagement.Entities.Service", null)
                        .WithMany("Shares")
                        .HasForeignKey("ServiceId");

                    b.HasOne("Moonlight.Core.Database.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Moonlight.Features.StoreSystem.Entities.CouponUse", b =>
                {
                    b.HasOne("Moonlight.Features.StoreSystem.Entities.Coupon", "Coupon")
                        .WithMany()
                        .HasForeignKey("CouponId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Moonlight.Core.Database.Entities.User", null)
                        .WithMany("CouponUses")
                        .HasForeignKey("UserId");

                    b.Navigation("Coupon");
                });

            modelBuilder.Entity("Moonlight.Features.StoreSystem.Entities.GiftCodeUse", b =>
                {
                    b.HasOne("Moonlight.Features.StoreSystem.Entities.GiftCode", "GiftCode")
                        .WithMany()
                        .HasForeignKey("GiftCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Moonlight.Core.Database.Entities.User", null)
                        .WithMany("GiftCodeUses")
                        .HasForeignKey("UserId");

                    b.Navigation("GiftCode");
                });

            modelBuilder.Entity("Moonlight.Features.StoreSystem.Entities.Product", b =>
                {
                    b.HasOne("Moonlight.Features.StoreSystem.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Moonlight.Features.StoreSystem.Entities.Transaction", b =>
                {
                    b.HasOne("Moonlight.Core.Database.Entities.User", null)
                        .WithMany("Transactions")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Moonlight.Features.Ticketing.Entities.Ticket", b =>
                {
                    b.HasOne("Moonlight.Core.Database.Entities.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Moonlight.Features.ServiceManagement.Entities.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId");

                    b.Navigation("Creator");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Moonlight.Features.Ticketing.Entities.TicketMessage", b =>
                {
                    b.HasOne("Moonlight.Core.Database.Entities.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId");

                    b.HasOne("Moonlight.Features.Ticketing.Entities.Ticket", null)
                        .WithMany("Messages")
                        .HasForeignKey("TicketId");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("Moonlight.Core.Database.Entities.User", b =>
                {
                    b.Navigation("CouponUses");

                    b.Navigation("GiftCodeUses");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Moonlight.Features.Community.Entities.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Likes");
                });

            modelBuilder.Entity("Moonlight.Features.Servers.Entities.Server", b =>
                {
                    b.Navigation("Allocations");

                    b.Navigation("Variables");
                });

            modelBuilder.Entity("Moonlight.Features.Servers.Entities.ServerImage", b =>
                {
                    b.Navigation("DockerImages");

                    b.Navigation("Variables");
                });

            modelBuilder.Entity("Moonlight.Features.Servers.Entities.ServerNode", b =>
                {
                    b.Navigation("Allocations");
                });

            modelBuilder.Entity("Moonlight.Features.ServiceManagement.Entities.Service", b =>
                {
                    b.Navigation("Shares");
                });

            modelBuilder.Entity("Moonlight.Features.Ticketing.Entities.Ticket", b =>
                {
                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
