﻿// <auto-generated />
using LinkBoxWeb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace LinkBoxWeb.Migrations
{
    [DbContext(typeof(LinkBoxContext))]
    [Migration("20180204050839_Another bugfix!")]
    partial class Anotherbugfix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LinkBoxWeb.DataModel.Chapter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("TopicId");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("Chapters");
                });

            modelBuilder.Entity("LinkBoxWeb.DataModel.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Contents");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Content");
                });

            modelBuilder.Entity("LinkBoxWeb.DataModel.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("SessionGuid");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("LinkBoxWeb.DataModel.Site", b =>
                {
                    b.Property<int>("SiteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("SiteId");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("LinkBoxWeb.DataModel.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("SiteId");

                    b.HasKey("Id");

                    b.HasIndex("SiteId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("LinkBoxWeb.DataModel.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("LinkBoxWeb.DataModel.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("SubjectId");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("LinkBoxWeb.DataModel.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<int>("Rank");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasFilter("[Username] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LinkBoxWeb.DataModel.UserTags", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ContentId");

                    b.Property<int?>("TagId");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ContentId");

                    b.HasIndex("TagId");

                    b.HasIndex("UserId");

                    b.ToTable("UserTagss");
                });

            modelBuilder.Entity("LinkBoxWeb.DataModel.Exercise", b =>
                {
                    b.HasBaseType("LinkBoxWeb.DataModel.Content");

                    b.Property<int?>("ChapterId");

                    b.Property<string>("Content");

                    b.HasIndex("ChapterId");

                    b.ToTable("Exercise");

                    b.HasDiscriminator().HasValue("Exercise");
                });

            modelBuilder.Entity("LinkBoxWeb.DataModel.Link", b =>
                {
                    b.HasBaseType("LinkBoxWeb.DataModel.Content");

                    b.Property<int?>("ChapterId")
                        .HasColumnName("Link_ChapterId");

                    b.Property<string>("Href");

                    b.HasIndex("ChapterId");

                    b.ToTable("Link");

                    b.HasDiscriminator().HasValue("Link");
                });

            modelBuilder.Entity("LinkBoxWeb.DataModel.Chapter", b =>
                {
                    b.HasOne("LinkBoxWeb.DataModel.Topic", "Topic")
                        .WithMany("Chapters")
                        .HasForeignKey("TopicId");
                });

            modelBuilder.Entity("LinkBoxWeb.DataModel.Session", b =>
                {
                    b.HasOne("LinkBoxWeb.DataModel.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("LinkBoxWeb.DataModel.Subject", b =>
                {
                    b.HasOne("LinkBoxWeb.DataModel.Site", "Site")
                        .WithMany("Subjects")
                        .HasForeignKey("SiteId");
                });

            modelBuilder.Entity("LinkBoxWeb.DataModel.Topic", b =>
                {
                    b.HasOne("LinkBoxWeb.DataModel.Subject", "Subject")
                        .WithMany("Topics")
                        .HasForeignKey("SubjectId");
                });

            modelBuilder.Entity("LinkBoxWeb.DataModel.UserTags", b =>
                {
                    b.HasOne("LinkBoxWeb.DataModel.Content")
                        .WithMany("Tags")
                        .HasForeignKey("ContentId");

                    b.HasOne("LinkBoxWeb.DataModel.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId");

                    b.HasOne("LinkBoxWeb.DataModel.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("LinkBoxWeb.DataModel.Exercise", b =>
                {
                    b.HasOne("LinkBoxWeb.DataModel.Chapter", "Chapter")
                        .WithMany("Exercises")
                        .HasForeignKey("ChapterId");
                });

            modelBuilder.Entity("LinkBoxWeb.DataModel.Link", b =>
                {
                    b.HasOne("LinkBoxWeb.DataModel.Chapter", "Chapter")
                        .WithMany("Links")
                        .HasForeignKey("ChapterId");
                });
#pragma warning restore 612, 618
        }
    }
}
