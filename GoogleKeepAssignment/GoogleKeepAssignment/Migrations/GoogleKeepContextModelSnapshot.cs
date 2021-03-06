﻿// <auto-generated />
using GoogleKeepAssignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GoogleKeepAssignment.Migrations
{
    [DbContext(typeof(GoogleKeepContext))]
    partial class GoogleKeepContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoogleKeepAssignment.Models.CheckList", b =>
                {
                    b.Property<string>("Title")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CheckListData");

                    b.Property<bool>("CheckListStatus");

                    b.Property<string>("NotesTitle");

                    b.HasKey("Title");

                    b.HasIndex("NotesTitle");

                    b.ToTable("CheckList");
                });

            modelBuilder.Entity("GoogleKeepAssignment.Models.Label", b =>
                {
                    b.Property<string>("Title")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LabelString");

                    b.Property<string>("NotesTitle");

                    b.HasKey("Title");

                    b.HasIndex("NotesTitle");

                    b.ToTable("Label");
                });

            modelBuilder.Entity("GoogleKeepAssignment.Models.Note", b =>
                {
                    b.Property<string>("Title")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("PinStatus");

                    b.Property<string>("PlainText");

                    b.HasKey("Title");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("GoogleKeepAssignment.Models.CheckList", b =>
                {
                    b.HasOne("GoogleKeepAssignment.Models.Note", "Notes")
                        .WithMany("CheckLists")
                        .HasForeignKey("NotesTitle");
                });

            modelBuilder.Entity("GoogleKeepAssignment.Models.Label", b =>
                {
                    b.HasOne("GoogleKeepAssignment.Models.Note", "Notes")
                        .WithMany("Labels")
                        .HasForeignKey("NotesTitle");
                });
#pragma warning restore 612, 618
        }
    }
}
