﻿// <auto-generated />
using System;
using Deal.Migration.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Deal.Migration.Migrations
{
    [DbContext(typeof(MigrationContext))]
    class MigrationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Deal.Data.Dtos.CardDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RankId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SuitId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RankId");

                    b.HasIndex("SuitId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("Deal.Data.Dtos.DealerDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dealers");
                });

            modelBuilder.Entity("Deal.Data.Dtos.ErrorReasonDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ErrorReasonGroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ErrorReasonGroupId");

                    b.ToTable("ErrorReasons");
                });

            modelBuilder.Entity("Deal.Data.Dtos.ErrorReasonGroupDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ErrorReasonGroups");
                });

            modelBuilder.Entity("Deal.Data.Dtos.EventDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("HandCopies")
                        .HasColumnType("int");

                    b.Property<bool>("IsDoubleSidedHandCopies")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SeasonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SubName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SeasonId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Deal.Data.Dtos.EventSetDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DealerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Dealt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsBoardsReturnedOutOfSequence")
                        .HasColumnType("bit");

                    b.Property<Guid>("SetId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DealerId");

                    b.HasIndex("EventId");

                    b.HasIndex("SetId");

                    b.ToTable("EventSets");
                });

            modelBuilder.Entity("Deal.Data.Dtos.OrganiserDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Organisers");
                });

            modelBuilder.Entity("Deal.Data.Dtos.OwnerDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsClub")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("Deal.Data.Dtos.PackColourDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Colour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PackColours");
                });

            modelBuilder.Entity("Deal.Data.Dtos.PackDealErrorDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ActualCardId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClaimedCardId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ErrorReasonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EventSetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PackId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ActualCardId");

                    b.HasIndex("ClaimedCardId");

                    b.HasIndex("ErrorReasonId");

                    b.HasIndex("EventSetId");

                    b.HasIndex("PackId");

                    b.ToTable("PackDealErrors");
                });

            modelBuilder.Entity("Deal.Data.Dtos.PackDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BoardNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("EnteredService")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PackColourId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SetId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PackColourId");

                    b.HasIndex("SetId");

                    b.ToTable("Packs");
                });

            modelBuilder.Entity("Deal.Data.Dtos.RankDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("SortOrder")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("Ranks");
                });

            modelBuilder.Entity("Deal.Data.Dtos.SeasonDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("OrganiserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrganiserId");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("Deal.Data.Dtos.SetColourDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SetColours");
                });

            modelBuilder.Entity("Deal.Data.Dtos.SetDealErrorDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("EastCount")
                        .HasColumnType("int");

                    b.Property<Guid>("ErrorReasonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EventSetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("NorthCount")
                        .HasColumnType("int");

                    b.Property<int?>("SouthCount")
                        .HasColumnType("int");

                    b.Property<int?>("WestCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ErrorReasonId");

                    b.HasIndex("EventSetId");

                    b.ToTable("SetDealErrors");
                });

            modelBuilder.Entity("Deal.Data.Dtos.SetDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HighBoardNumber")
                        .HasColumnType("int");

                    b.Property<int>("LowBoardNumber")
                        .HasColumnType("int");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SetColourId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SetPurposeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("SetColourId");

                    b.HasIndex("SetPurposeId");

                    b.ToTable("Sets");
                });

            modelBuilder.Entity("Deal.Data.Dtos.SetPurposeDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SetPurposes");
                });

            modelBuilder.Entity("Deal.Data.Dtos.SuitDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("SortOrder")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("Suits");
                });

            modelBuilder.Entity("Deal.Data.Dtos.CardDto", b =>
                {
                    b.HasOne("Deal.Data.Dtos.RankDto", "Rank")
                        .WithMany()
                        .HasForeignKey("RankId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Deal.Data.Dtos.SuitDto", "Suit")
                        .WithMany()
                        .HasForeignKey("SuitId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Deal.Data.Dtos.ErrorReasonDto", b =>
                {
                    b.HasOne("Deal.Data.Dtos.ErrorReasonGroupDto", "ErrorReasonGroup")
                        .WithMany()
                        .HasForeignKey("ErrorReasonGroupId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Deal.Data.Dtos.EventDto", b =>
                {
                    b.HasOne("Deal.Data.Dtos.SeasonDto", "Season")
                        .WithMany()
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Deal.Data.Dtos.EventSetDto", b =>
                {
                    b.HasOne("Deal.Data.Dtos.DealerDto", "Dealer")
                        .WithMany()
                        .HasForeignKey("DealerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Deal.Data.Dtos.EventDto", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Deal.Data.Dtos.SetDto", "Set")
                        .WithMany()
                        .HasForeignKey("SetId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Deal.Data.Dtos.PackDealErrorDto", b =>
                {
                    b.HasOne("Deal.Data.Dtos.CardDto", "ActualCard")
                        .WithMany()
                        .HasForeignKey("ActualCardId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Deal.Data.Dtos.CardDto", "ClaimedCard")
                        .WithMany()
                        .HasForeignKey("ClaimedCardId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Deal.Data.Dtos.ErrorReasonDto", "ErrorReason")
                        .WithMany()
                        .HasForeignKey("ErrorReasonId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Deal.Data.Dtos.EventSetDto", "EventSet")
                        .WithMany()
                        .HasForeignKey("EventSetId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Deal.Data.Dtos.PackDto", "Pack")
                        .WithMany()
                        .HasForeignKey("PackId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Deal.Data.Dtos.PackDto", b =>
                {
                    b.HasOne("Deal.Data.Dtos.PackColourDto", "PackColour")
                        .WithMany()
                        .HasForeignKey("PackColourId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Deal.Data.Dtos.SetDto", "Set")
                        .WithMany()
                        .HasForeignKey("SetId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Deal.Data.Dtos.SeasonDto", b =>
                {
                    b.HasOne("Deal.Data.Dtos.OrganiserDto", "Organiser")
                        .WithMany()
                        .HasForeignKey("OrganiserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Deal.Data.Dtos.SetDealErrorDto", b =>
                {
                    b.HasOne("Deal.Data.Dtos.ErrorReasonDto", "ErrorReason")
                        .WithMany()
                        .HasForeignKey("ErrorReasonId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Deal.Data.Dtos.EventSetDto", "EventSet")
                        .WithMany()
                        .HasForeignKey("EventSetId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Deal.Data.Dtos.SetDto", b =>
                {
                    b.HasOne("Deal.Data.Dtos.OwnerDto", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Deal.Data.Dtos.SetColourDto", "SetColour")
                        .WithMany()
                        .HasForeignKey("SetColourId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Deal.Data.Dtos.SetPurposeDto", "SetPurpose")
                        .WithMany()
                        .HasForeignKey("SetPurposeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
