﻿// <auto-generated />
using System;
using Betgrab.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Betgrab.Domain.Migrations
{
    [DbContext(typeof(BetgrabContext))]
    [Migration("20210109121311_Event_Result")]
    partial class Event_Result
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Betgrab.Domain.Entities.Analog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Json")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Service")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ServiceId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Type", "Service", "ServiceId")
                        .IsUnique()
                        .HasFilter("[Type] IS NOT NULL AND [Service] IS NOT NULL AND [ServiceId] IS NOT NULL");

                    b.ToTable("Analogs");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.ClubLeague", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ClubId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.HasIndex("LeagueId");

                    b.ToTable("ClubLeague");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.ClubMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ClubId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsLeasing")
                        .HasColumnType("bit");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.HasIndex("PersonId");

                    b.ToTable("ClubMember");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Club1Id")
                        .HasColumnType("int");

                    b.Property<int?>("Club2Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FinishDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("bit");

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Result")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Club1Id");

                    b.HasIndex("Club2Id");

                    b.HasIndex("LeagueId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.EventStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BlockedShots")
                        .HasColumnType("int");

                    b.Property<int>("ClubId")
                        .HasColumnType("int");

                    b.Property<int>("CornerKicks")
                        .HasColumnType("int");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("Fouls")
                        .HasColumnType("int");

                    b.Property<int>("GoalKicks")
                        .HasColumnType("int");

                    b.Property<int>("Offsides")
                        .HasColumnType("int");

                    b.Property<int>("Possession")
                        .HasColumnType("int");

                    b.Property<int>("ShotsOffTarget")
                        .HasColumnType("int");

                    b.Property<int>("ShotsOnTarget")
                        .HasColumnType("int");

                    b.Property<int>("ThrowIns")
                        .HasColumnType("int");

                    b.Property<int>("YellowCards")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.HasIndex("EventId");

                    b.ToTable("EventStats");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.GoalScoredFact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ClubId")
                        .HasColumnType("int");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("JsonData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.HasIndex("EventId");

                    b.HasIndex("PersonId");

                    b.ToTable("Goals");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsInternational")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NationId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NationId");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.Nation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Nations");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.PenaltyCardFact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EventId")
                        .HasColumnType("int");

                    b.Property<bool>("IsRed")
                        .HasColumnType("bit");

                    b.Property<string>("JsonData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("PersonId");

                    b.ToTable("PenaltyCards");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.PenaltyFact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Club1Id")
                        .HasColumnType("int");

                    b.Property<int>("Club2Id")
                        .HasColumnType("int");

                    b.Property<int?>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("JsonData")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Club1Id");

                    b.HasIndex("Club2Id");

                    b.HasIndex("EventId");

                    b.ToTable("Penalties");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("LivescoreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.PlayerDeletionFact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("JsonData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("PersonId");

                    b.ToTable("PlayerDeletions");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.PlayerSubstitutionFact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("InId")
                        .HasColumnType("int");

                    b.Property<string>("JsonData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OutId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("InId");

                    b.HasIndex("OutId");

                    b.ToTable("PlayerSubstitutions");
                });

            modelBuilder.Entity("NationPerson", b =>
                {
                    b.Property<int>("CitizensId")
                        .HasColumnType("int");

                    b.Property<int>("NationalityId")
                        .HasColumnType("int");

                    b.HasKey("CitizensId", "NationalityId");

                    b.HasIndex("NationalityId");

                    b.ToTable("NationPerson");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.Club", b =>
                {
                    b.HasOne("Betgrab.Domain.Entities.Nation", "Country")
                        .WithMany("Clubs")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.ClubLeague", b =>
                {
                    b.HasOne("Betgrab.Domain.Entities.Club", "Club")
                        .WithMany("Leagues")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Betgrab.Domain.Entities.League", "League")
                        .WithMany("Clubs")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Club");

                    b.Navigation("League");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.ClubMember", b =>
                {
                    b.HasOne("Betgrab.Domain.Entities.Club", "Club")
                        .WithMany("Members")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Betgrab.Domain.Entities.Person", "Person")
                        .WithMany("ClubParticipation")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Club");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.Event", b =>
                {
                    b.HasOne("Betgrab.Domain.Entities.Club", "Club1")
                        .WithMany()
                        .HasForeignKey("Club1Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Betgrab.Domain.Entities.Club", "Club2")
                        .WithMany()
                        .HasForeignKey("Club2Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Betgrab.Domain.Entities.League", "League")
                        .WithMany()
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Club1");

                    b.Navigation("Club2");

                    b.Navigation("League");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.EventStats", b =>
                {
                    b.HasOne("Betgrab.Domain.Entities.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Betgrab.Domain.Entities.Event", "Event")
                        .WithMany("Stats")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Club");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.GoalScoredFact", b =>
                {
                    b.HasOne("Betgrab.Domain.Entities.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Betgrab.Domain.Entities.Event", "Event")
                        .WithMany("Goals")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Betgrab.Domain.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.Navigation("Club");

                    b.Navigation("Event");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.League", b =>
                {
                    b.HasOne("Betgrab.Domain.Entities.Nation", "Nation")
                        .WithMany()
                        .HasForeignKey("NationId");

                    b.Navigation("Nation");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.PenaltyCardFact", b =>
                {
                    b.HasOne("Betgrab.Domain.Entities.Event", null)
                        .WithMany("PenaltyCards")
                        .HasForeignKey("EventId");

                    b.HasOne("Betgrab.Domain.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.PenaltyFact", b =>
                {
                    b.HasOne("Betgrab.Domain.Entities.Club", "Club1")
                        .WithMany()
                        .HasForeignKey("Club1Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Betgrab.Domain.Entities.Club", "Club2")
                        .WithMany()
                        .HasForeignKey("Club2Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Betgrab.Domain.Entities.Event", null)
                        .WithMany("Penalties")
                        .HasForeignKey("EventId");

                    b.Navigation("Club1");

                    b.Navigation("Club2");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.PlayerDeletionFact", b =>
                {
                    b.HasOne("Betgrab.Domain.Entities.Event", null)
                        .WithMany("PlayerDeletions")
                        .HasForeignKey("EventId");

                    b.HasOne("Betgrab.Domain.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.PlayerSubstitutionFact", b =>
                {
                    b.HasOne("Betgrab.Domain.Entities.Event", null)
                        .WithMany("PlayerSubstitutions")
                        .HasForeignKey("EventId");

                    b.HasOne("Betgrab.Domain.Entities.Person", "In")
                        .WithMany()
                        .HasForeignKey("InId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Betgrab.Domain.Entities.Person", "Out")
                        .WithMany()
                        .HasForeignKey("OutId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("In");

                    b.Navigation("Out");
                });

            modelBuilder.Entity("NationPerson", b =>
                {
                    b.HasOne("Betgrab.Domain.Entities.Person", null)
                        .WithMany()
                        .HasForeignKey("CitizensId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Betgrab.Domain.Entities.Nation", null)
                        .WithMany()
                        .HasForeignKey("NationalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.Club", b =>
                {
                    b.Navigation("Leagues");

                    b.Navigation("Members");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.Event", b =>
                {
                    b.Navigation("Goals");

                    b.Navigation("Penalties");

                    b.Navigation("PenaltyCards");

                    b.Navigation("PlayerDeletions");

                    b.Navigation("PlayerSubstitutions");

                    b.Navigation("Stats");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.League", b =>
                {
                    b.Navigation("Clubs");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.Nation", b =>
                {
                    b.Navigation("Clubs");
                });

            modelBuilder.Entity("Betgrab.Domain.Entities.Person", b =>
                {
                    b.Navigation("ClubParticipation");
                });
#pragma warning restore 612, 618
        }
    }
}