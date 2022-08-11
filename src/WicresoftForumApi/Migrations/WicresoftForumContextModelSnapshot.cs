﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WicresoftForumApi.Data;

#nullable disable

namespace WicresoftForumApi.Migrations
{
    [DbContext(typeof(WicresoftForumContext))]
    partial class WicresoftForumContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WicresoftForumApi.Data.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClickCount")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("PostTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("PostTypeId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("WicresoftForumApi.Data.PostType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("PostTypes");
                });

            modelBuilder.Entity("WicresoftForumApi.Data.Reply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("FloorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("PostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("PostId");

                    b.ToTable("Replies");
                });

            modelBuilder.Entity("WicresoftForumApi.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WicresoftForumApi.Data.Post", b =>
                {
                    b.HasOne("WicresoftForumApi.Data.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("WicresoftForumApi.Data.PostType", "PostType")
                        .WithMany()
                        .HasForeignKey("PostTypeId");

                    b.Navigation("Creator");

                    b.Navigation("PostType");
                });

            modelBuilder.Entity("WicresoftForumApi.Data.Reply", b =>
                {
                    b.HasOne("WicresoftForumApi.Data.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("WicresoftForumApi.Data.Post", "Post")
                        .WithMany("Relies")
                        .HasForeignKey("PostId");

                    b.Navigation("Creator");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("WicresoftForumApi.Data.Post", b =>
                {
                    b.Navigation("Relies");
                });
#pragma warning restore 612, 618
        }
    }
}
