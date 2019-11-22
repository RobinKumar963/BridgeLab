﻿// <auto-generated />
using System;
using FundooRepos.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FundooRepos.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20191122051529_reminder")]
    partial class reminder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Common.Models.CollabratorModels.CollabratorModel", b =>
                {
                    b.Property<int>("COLLABRATIONID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NOTEID");

                    b.Property<string>("RECIEVEDEMAIL")
                        .IsRequired();

                    b.Property<string>("SENDEREMAIL")
                        .IsRequired();

                    b.HasKey("COLLABRATIONID");

                    b.ToTable("Collabration");
                });

            modelBuilder.Entity("Common.Models.LabelledNoteModels.LabelledNote", b =>
                {
                    b.Property<int>("LABELNOTEID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LABELID");

                    b.Property<int>("NOTEID");

                    b.HasKey("LABELNOTEID");

                    b.ToTable("Labelnotes");
                });

            modelBuilder.Entity("Common.Models.LabelModels.LabelModel", b =>
                {
                    b.Property<int>("LABELID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LABEL")
                        .IsRequired();

                    b.Property<string>("USEREMAIL")
                        .IsRequired();

                    b.HasKey("LABELID");

                    b.ToTable("Labels");
                });

            modelBuilder.Entity("Common.Models.NoteModels.NoteModel", b =>
                {
                    b.Property<int>("NOTEID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("COLOR");

                    b.Property<DateTime?>("CREATEDDATE");

                    b.Property<string>("DESCRIPTION");

                    b.Property<string>("IMAGES");

                    b.Property<bool>("ISARCHIVE");

                    b.Property<bool>("ISPIN");

                    b.Property<bool>("ISTRASH");

                    b.Property<DateTime?>("MODIFIEDDATA");

                    b.Property<string>("REMINDER");

                    b.Property<string>("TITLE");

                    b.Property<string>("USEREMAIL")
                        .IsRequired();

                    b.HasKey("NOTEID");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("Common.Models.ReminderModel.ReminderModel", b =>
                {
                    b.Property<int>("REMINDERID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NOTEID");

                    b.Property<DateTime?>("REMINDERTIME")
                        .IsRequired();

                    b.Property<string>("USEREMAIL")
                        .IsRequired();

                    b.HasKey("REMINDERID");

                    b.ToTable("Reminders");
                });

            modelBuilder.Entity("Common.Models.UserModels.UserModel", b =>
                {
                    b.Property<string>("USEREMAIL")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CARDTYPE");

                    b.Property<string>("PASSWORD")
                        .IsRequired();

                    b.Property<string>("PROFILEIMAGE");

                    b.Property<string>("USERNAME")
                        .IsRequired();

                    b.HasKey("USEREMAIL");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
