﻿// <auto-generated />
using System;
using Testability.Presidents.Api.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Testability.Presidents.Api.Migrations
{
    [DbContext(typeof(PresidentsDbContext))]
    [Migration("20181120180930_SubscriptionInfo")]
    partial class SubscriptionInfo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Testability.Presidents.Api.DataAccess.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Feature");
                });

            modelBuilder.Entity("Testability.Presidents.Api.DataAccess.LogEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FeatureName");

                    b.Property<DateTime>("LogDate");

                    b.Property<string>("LogType");

                    b.Property<string>("Message");

                    b.Property<string>("ReferrerUrl");

                    b.Property<string>("RequestIpAddress");

                    b.Property<string>("RequestUrl");

                    b.Property<string>("UserAgent");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("LogEntry");
                });

            modelBuilder.Entity("Testability.Presidents.Api.DataAccess.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Testability.Presidents.Api.DataAccess.PersonFact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("FactType");

                    b.Property<string>("FactValue");

                    b.Property<int>("PersonId");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("PersonFact");
                });

            modelBuilder.Entity("Testability.Presidents.Api.DataAccess.Relationship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FromPersonId");

                    b.Property<string>("RelationshipType")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("ToPersonId");

                    b.HasKey("Id");

                    b.HasIndex("FromPersonId");

                    b.HasIndex("ToPersonId");

                    b.ToTable("Relationship");
                });

            modelBuilder.Entity("Testability.Presidents.Api.DataAccess.Subscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubscriptionLevel");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("Testability.Presidents.Api.DataAccess.PersonFact", b =>
                {
                    b.HasOne("Testability.Presidents.Api.DataAccess.Person", "Person")
                        .WithMany("Facts")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Testability.Presidents.Api.DataAccess.Relationship", b =>
                {
                    b.HasOne("Testability.Presidents.Api.DataAccess.Person", "FromPerson")
                        .WithMany("Relationships")
                        .HasForeignKey("FromPersonId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Testability.Presidents.Api.DataAccess.Person", "ToPerson")
                        .WithMany()
                        .HasForeignKey("ToPersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
