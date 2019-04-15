﻿// <auto-generated />
using System;
using CLAD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CLAD.Migrations
{
    [DbContext(typeof(CLADContext))]
    [Migration("20190412064656_questionscontroller")]
    partial class questionscontroller
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CLAD.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorId");

                    b.Property<string>("Content");

                    b.Property<bool>("IsVisible");

                    b.Property<DateTime>("PublicationDate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("CLAD.Models.ArticleComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArticleId");

                    b.Property<string>("AuthorId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("PublicationDate");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("ArticleComment");
                });

            modelBuilder.Entity("CLAD.Models.ArticleTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArticleId");

                    b.Property<int>("TagId");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("ArticleTag");
                });

            modelBuilder.Entity("CLAD.Models.Consultant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("DisplayName");

                    b.Property<string>("ImgName");

                    b.HasKey("Id");

                    b.ToTable("Consultant");
                });

            modelBuilder.Entity("CLAD.Models.ArticleComment", b =>
                {
                    b.HasOne("CLAD.Models.Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CLAD.Models.ArticleTag", b =>
                {
                    b.HasOne("CLAD.Models.Article")
                        .WithMany("Tags")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
