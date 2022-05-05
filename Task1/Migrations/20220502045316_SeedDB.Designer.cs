﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mobilography.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Task1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220502045316_SeedDB")]
    partial class SeedDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Task1.Data.MultiplicationResult", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Result")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("MultiplicationResults");

                    b.HasData(
                        new
                        {
                            Id = new Guid("48e2fd15-c89c-45d5-a3b6-86c5ace54f90"),
                            Result = 4
                        },
                        new
                        {
                            Id = new Guid("367572b0-7767-4611-bd15-0b34f02eefc9"),
                            Result = 5
                        },
                        new
                        {
                            Id = new Guid("fd4a43d5-5b98-484c-9b6c-7a5924815b1d"),
                            Result = 7
                        },
                        new
                        {
                            Id = new Guid("01f4b2a9-6314-4b57-84f9-02ec154f5dba"),
                            Result = 12
                        },
                        new
                        {
                            Id = new Guid("5ac3f5e6-8c3a-4635-a59d-7e80d41493fe"),
                            Result = 21
                        },
                        new
                        {
                            Id = new Guid("b825264d-f263-4589-9072-5fa98bd63e2d"),
                            Result = 24
                        },
                        new
                        {
                            Id = new Guid("7eb83242-297d-4ee3-85fd-f47c422d91fa"),
                            Result = 25
                        },
                        new
                        {
                            Id = new Guid("fc461dcb-f09d-419f-8c56-c8f8a7e485b2"),
                            Result = 32
                        },
                        new
                        {
                            Id = new Guid("9ca6d09b-684e-4479-a9d2-e89c82888a00"),
                            Result = 33
                        },
                        new
                        {
                            Id = new Guid("16a0cecc-0f80-48dc-9476-e1d76a783da2"),
                            Result = 36
                        },
                        new
                        {
                            Id = new Guid("51c1366b-d2e7-4af3-879c-9e6ce410c609"),
                            Result = 39
                        },
                        new
                        {
                            Id = new Guid("6af4dd1b-b9ed-47d6-afed-753cc2bcf92c"),
                            Result = 40
                        },
                        new
                        {
                            Id = new Guid("c3140917-5621-4560-80f7-130bab1b25a8"),
                            Result = 42
                        },
                        new
                        {
                            Id = new Guid("716b6c9b-e84b-4cfd-ad53-e144ff887786"),
                            Result = 44
                        },
                        new
                        {
                            Id = new Guid("6bdac941-7180-4894-bad1-543354f67128"),
                            Result = 45
                        },
                        new
                        {
                            Id = new Guid("a358c338-7e83-4fb6-929b-22dfaefe28e2"),
                            Result = 46
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
