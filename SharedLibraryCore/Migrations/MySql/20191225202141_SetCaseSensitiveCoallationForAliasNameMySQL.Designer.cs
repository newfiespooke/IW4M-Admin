﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SharedLibraryCore.Database.MigrationContext;

namespace SharedLibraryCore.Migrations.MySql
{
    [DbContext(typeof(MySqlDatabaseContext))]
    [Migration("20191225202141_SetCaseSensitiveCoallationForAliasNameMySQL")]
    partial class SetCaseSensitiveCoallationForAliasNameMySQL
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFACSnapshot", b =>
                {
                    b.Property<int>("SnapshotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CurrentSessionLength")
                        .HasColumnType("INTEGER");

                    b.Property<double>("CurrentStrain")
                        .HasColumnType("REAL");

                    b.Property<int>("CurrentViewAngleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Deaths")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Distance")
                        .HasColumnType("REAL");

                    b.Property<double>("EloRating")
                        .HasColumnType("REAL");

                    b.Property<int>("HitDestinationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HitLocation")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HitOriginId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HitType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Hits")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Kills")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LastStrainAngleId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("RecoilOffset")
                        .HasColumnType("REAL");

                    b.Property<double>("SessionAngleOffset")
                        .HasColumnType("REAL");

                    b.Property<double>("SessionAverageSnapValue")
                        .HasColumnType("REAL");

                    b.Property<double>("SessionSPM")
                        .HasColumnType("REAL");

                    b.Property<int>("SessionScore")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SessionSnapHits")
                        .HasColumnType("INTEGER");

                    b.Property<double>("StrainAngleBetween")
                        .HasColumnType("REAL");

                    b.Property<int>("TimeSinceLastEvent")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WeaponId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("When")
                        .HasColumnType("TEXT");

                    b.HasKey("SnapshotId");

                    b.HasIndex("ClientId");

                    b.HasIndex("CurrentViewAngleId");

                    b.HasIndex("HitDestinationId");

                    b.HasIndex("HitOriginId");

                    b.HasIndex("LastStrainAngleId");

                    b.ToTable("EFACSnapshot");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFACSnapshotVector3", b =>
                {
                    b.Property<int>("ACSnapshotVector3Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SnapshotId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Vector3Id")
                        .HasColumnType("INTEGER");

                    b.HasKey("ACSnapshotVector3Id");

                    b.HasIndex("SnapshotId");

                    b.HasIndex("Vector3Id");

                    b.ToTable("EFACSnapshotVector3");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFClientKill", b =>
                {
                    b.Property<long>("KillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AttackerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Damage")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DeathOriginVector3Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DeathType")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Fraction")
                        .HasColumnType("REAL");

                    b.Property<int>("HitLoc")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsKill")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("KillOriginVector3Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Map")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ServerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VictimId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ViewAnglesVector3Id")
                        .HasColumnType("INTEGER");

                    b.Property<double>("VisibilityPercentage")
                        .HasColumnType("REAL");

                    b.Property<int>("Weapon")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("When")
                        .HasColumnType("TEXT");

                    b.HasKey("KillId");

                    b.HasIndex("AttackerId");

                    b.HasIndex("DeathOriginVector3Id");

                    b.HasIndex("KillOriginVector3Id");

                    b.HasIndex("ServerId");

                    b.HasIndex("VictimId");

                    b.HasIndex("ViewAnglesVector3Id");

                    b.ToTable("EFClientKills");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFClientMessage", b =>
                {
                    b.Property<long>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Message")
                        .HasColumnType("TEXT");

                    b.Property<long>("ServerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeSent")
                        .HasColumnType("TEXT");

                    b.HasKey("MessageId");

                    b.HasIndex("ClientId");

                    b.HasIndex("ServerId");

                    b.HasIndex("TimeSent");

                    b.ToTable("EFClientMessages");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFClientRatingHistory", b =>
                {
                    b.Property<int>("RatingHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.HasKey("RatingHistoryId");

                    b.HasIndex("ClientId");

                    b.ToTable("EFClientRatingHistory");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFClientStatistics", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ServerId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<double>("AverageRecoilOffset")
                        .HasColumnType("REAL");

                    b.Property<double>("AverageSnapValue")
                        .HasColumnType("REAL");

                    b.Property<int>("Deaths")
                        .HasColumnType("INTEGER");

                    b.Property<double>("EloRating")
                        .HasColumnType("REAL");

                    b.Property<int>("Kills")
                        .HasColumnType("INTEGER");

                    b.Property<double>("MaxStrain")
                        .HasColumnType("REAL");

                    b.Property<double>("RollingWeightedKDR")
                        .HasColumnType("REAL");

                    b.Property<double>("SPM")
                        .HasColumnType("REAL");

                    b.Property<double>("Skill")
                        .HasColumnType("REAL");

                    b.Property<int>("SnapHitCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TimePlayed")
                        .HasColumnType("INTEGER");

                    b.Property<double>("VisionAverage")
                        .HasColumnType("REAL");

                    b.HasKey("ClientId", "ServerId");

                    b.HasIndex("ServerId");

                    b.ToTable("EFClientStatistics");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFHitLocationCount", b =>
                {
                    b.Property<int>("HitLocationCountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EFClientStatisticsClientId")
                        .HasColumnName("EFClientStatisticsClientId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("EFClientStatisticsServerId")
                        .HasColumnName("EFClientStatisticsServerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HitCount")
                        .HasColumnType("INTEGER");

                    b.Property<float>("HitOffsetAverage")
                        .HasColumnType("REAL");

                    b.Property<int>("Location")
                        .HasColumnType("INTEGER");

                    b.Property<float>("MaxAngleDistance")
                        .HasColumnType("REAL");

                    b.HasKey("HitLocationCountId");

                    b.HasIndex("EFClientStatisticsServerId");

                    b.HasIndex("EFClientStatisticsClientId", "EFClientStatisticsServerId");

                    b.ToTable("EFHitLocationCounts");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFRating", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ActivityAmount")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Newest")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Performance")
                        .HasColumnType("REAL");

                    b.Property<int>("Ranking")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RatingHistoryId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("ServerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("When")
                        .HasColumnType("TEXT");

                    b.HasKey("RatingId");

                    b.HasIndex("RatingHistoryId");

                    b.HasIndex("ServerId");

                    b.HasIndex("Performance", "Ranking", "When");

                    b.ToTable("EFRating");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFServer", b =>
                {
                    b.Property<long>("ServerId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EndPoint")
                        .HasColumnType("TEXT");

                    b.Property<int?>("GameName")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Port")
                        .HasColumnType("INTEGER");

                    b.HasKey("ServerId");

                    b.ToTable("EFServers");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFServerStatistics", b =>
                {
                    b.Property<int>("StatisticId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ServerId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TotalKills")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TotalPlayTime")
                        .HasColumnType("INTEGER");

                    b.HasKey("StatisticId");

                    b.HasIndex("ServerId");

                    b.ToTable("EFServerStatistics");
                });

            modelBuilder.Entity("SharedLibraryCore.Database.Models.EFAlias", b =>
                {
                    b.Property<int>("AliasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<int?>("IPAddress")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LinkId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(24);

                    b.Property<string>("SearchableName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(24);

                    b.HasKey("AliasId");

                    b.HasIndex("IPAddress");

                    b.HasIndex("LinkId");

                    b.HasIndex("Name");

                    b.HasIndex("SearchableName");

                    b.HasIndex("Name", "IPAddress")
                        .IsUnique();

                    b.ToTable("EFAlias");
                });

            modelBuilder.Entity("SharedLibraryCore.Database.Models.EFAliasLink", b =>
                {
                    b.Property<int>("AliasLinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.HasKey("AliasLinkId");

                    b.ToTable("EFAliasLinks");
                });

            modelBuilder.Entity("SharedLibraryCore.Database.Models.EFChangeHistory", b =>
                {
                    b.Property<int>("ChangeHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("CurrentValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("OriginEntityId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PreviousValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("TargetEntityId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeChanged")
                        .HasColumnType("TEXT");

                    b.Property<int>("TypeOfChange")
                        .HasColumnType("INTEGER");

                    b.HasKey("ChangeHistoryId");

                    b.ToTable("EFChangeHistory");
                });

            modelBuilder.Entity("SharedLibraryCore.Database.Models.EFClient", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AliasLinkId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Connections")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CurrentAliasId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FirstConnection")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastConnection")
                        .HasColumnType("TEXT");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Masked")
                        .HasColumnType("INTEGER");

                    b.Property<long>("NetworkId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordSalt")
                        .HasColumnType("TEXT");

                    b.Property<int>("TotalConnectionTime")
                        .HasColumnType("INTEGER");

                    b.HasKey("ClientId");

                    b.HasIndex("AliasLinkId");

                    b.HasIndex("CurrentAliasId");

                    b.HasIndex("NetworkId")
                        .IsUnique();

                    b.ToTable("EFClients");
                });

            modelBuilder.Entity("SharedLibraryCore.Database.Models.EFMeta", b =>
                {
                    b.Property<int>("MetaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Extra")
                        .HasColumnType("TEXT");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(32);

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MetaId");

                    b.HasIndex("ClientId");

                    b.HasIndex("Key");

                    b.ToTable("EFMeta");
                });

            modelBuilder.Entity("SharedLibraryCore.Database.Models.EFPenalty", b =>
                {
                    b.Property<int>("PenaltyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AutomatedOffense")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Expires")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsEvadedOffense")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LinkId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OffenderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Offense")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PunisherId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("When")
                        .HasColumnType("TEXT");

                    b.HasKey("PenaltyId");

                    b.HasIndex("LinkId");

                    b.HasIndex("OffenderId");

                    b.HasIndex("PunisherId");

                    b.ToTable("EFPenalties");
                });

            modelBuilder.Entity("SharedLibraryCore.Helpers.Vector3", b =>
                {
                    b.Property<int>("Vector3Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("X")
                        .HasColumnType("REAL");

                    b.Property<float>("Y")
                        .HasColumnType("REAL");

                    b.Property<float>("Z")
                        .HasColumnType("REAL");

                    b.HasKey("Vector3Id");

                    b.ToTable("Vector3");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFACSnapshot", b =>
                {
                    b.HasOne("SharedLibraryCore.Database.Models.EFClient", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedLibraryCore.Helpers.Vector3", "CurrentViewAngle")
                        .WithMany()
                        .HasForeignKey("CurrentViewAngleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedLibraryCore.Helpers.Vector3", "HitDestination")
                        .WithMany()
                        .HasForeignKey("HitDestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedLibraryCore.Helpers.Vector3", "HitOrigin")
                        .WithMany()
                        .HasForeignKey("HitOriginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedLibraryCore.Helpers.Vector3", "LastStrainAngle")
                        .WithMany()
                        .HasForeignKey("LastStrainAngleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFACSnapshotVector3", b =>
                {
                    b.HasOne("IW4MAdmin.Plugins.Stats.Models.EFACSnapshot", "Snapshot")
                        .WithMany("PredictedViewAngles")
                        .HasForeignKey("SnapshotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedLibraryCore.Helpers.Vector3", "Vector")
                        .WithMany()
                        .HasForeignKey("Vector3Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFClientKill", b =>
                {
                    b.HasOne("SharedLibraryCore.Database.Models.EFClient", "Attacker")
                        .WithMany()
                        .HasForeignKey("AttackerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedLibraryCore.Helpers.Vector3", "DeathOrigin")
                        .WithMany()
                        .HasForeignKey("DeathOriginVector3Id");

                    b.HasOne("SharedLibraryCore.Helpers.Vector3", "KillOrigin")
                        .WithMany()
                        .HasForeignKey("KillOriginVector3Id");

                    b.HasOne("IW4MAdmin.Plugins.Stats.Models.EFServer", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedLibraryCore.Database.Models.EFClient", "Victim")
                        .WithMany()
                        .HasForeignKey("VictimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedLibraryCore.Helpers.Vector3", "ViewAngles")
                        .WithMany()
                        .HasForeignKey("ViewAnglesVector3Id");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFClientMessage", b =>
                {
                    b.HasOne("SharedLibraryCore.Database.Models.EFClient", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IW4MAdmin.Plugins.Stats.Models.EFServer", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFClientRatingHistory", b =>
                {
                    b.HasOne("SharedLibraryCore.Database.Models.EFClient", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFClientStatistics", b =>
                {
                    b.HasOne("SharedLibraryCore.Database.Models.EFClient", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IW4MAdmin.Plugins.Stats.Models.EFServer", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFHitLocationCount", b =>
                {
                    b.HasOne("SharedLibraryCore.Database.Models.EFClient", "Client")
                        .WithMany()
                        .HasForeignKey("EFClientStatisticsClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IW4MAdmin.Plugins.Stats.Models.EFServer", "Server")
                        .WithMany()
                        .HasForeignKey("EFClientStatisticsServerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IW4MAdmin.Plugins.Stats.Models.EFClientStatistics", null)
                        .WithMany("HitLocations")
                        .HasForeignKey("EFClientStatisticsClientId", "EFClientStatisticsServerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFRating", b =>
                {
                    b.HasOne("IW4MAdmin.Plugins.Stats.Models.EFClientRatingHistory", "RatingHistory")
                        .WithMany("Ratings")
                        .HasForeignKey("RatingHistoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IW4MAdmin.Plugins.Stats.Models.EFServer", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFServerStatistics", b =>
                {
                    b.HasOne("IW4MAdmin.Plugins.Stats.Models.EFServer", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SharedLibraryCore.Database.Models.EFAlias", b =>
                {
                    b.HasOne("SharedLibraryCore.Database.Models.EFAliasLink", "Link")
                        .WithMany("Children")
                        .HasForeignKey("LinkId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("SharedLibraryCore.Database.Models.EFClient", b =>
                {
                    b.HasOne("SharedLibraryCore.Database.Models.EFAliasLink", "AliasLink")
                        .WithMany()
                        .HasForeignKey("AliasLinkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedLibraryCore.Database.Models.EFAlias", "CurrentAlias")
                        .WithMany()
                        .HasForeignKey("CurrentAliasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SharedLibraryCore.Database.Models.EFMeta", b =>
                {
                    b.HasOne("SharedLibraryCore.Database.Models.EFClient", "Client")
                        .WithMany("Meta")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SharedLibraryCore.Database.Models.EFPenalty", b =>
                {
                    b.HasOne("SharedLibraryCore.Database.Models.EFAliasLink", "Link")
                        .WithMany("ReceivedPenalties")
                        .HasForeignKey("LinkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedLibraryCore.Database.Models.EFClient", "Offender")
                        .WithMany("ReceivedPenalties")
                        .HasForeignKey("OffenderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SharedLibraryCore.Database.Models.EFClient", "Punisher")
                        .WithMany("AdministeredPenalties")
                        .HasForeignKey("PunisherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}