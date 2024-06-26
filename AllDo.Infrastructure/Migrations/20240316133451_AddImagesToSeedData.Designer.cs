﻿// <auto-generated />
using System;
using AllDo.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AllDo.Infrastructure.Migrations
{
    [DbContext(typeof(AllDoDbContext))]
    [Migration("20240316133451_AddImagesToSeedData")]
    partial class AddImagesToSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("AllDo.Infrastructure.Data.Models.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BugId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageData")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BugId");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4f894d7b-bb3b-47da-b220-2762420c8f70"),
                            BugId = new Guid("3e8d5d50-6727-40c1-b9fc-4817b27aedcc"),
                            ImageData = "iVBORw0KGgoAAAANSUhEUgAAAQAAAAEACAIAAADTED8xAAADMElEQVR4nOzVwQnAIBQFQYXff81RUkQCOyDj1YOPnbXWPmeTRef+/3O/OyBjzh3CD95BfqICMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMO0TAAD//2Anhf4QtqobAAAAAElFTkSuQmCC"
                        });
                });

            modelBuilder.Entity("AllDo.Infrastructure.Data.Models.Todo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ParentId");

                    b.ToTable("Todo");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Todo");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("AllDo.Infrastructure.Data.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("644d7218-42f9-479c-8436-ebe5224af97e"),
                            Name = "Jason Derulo"
                        },
                        new
                        {
                            Id = new Guid("61c091a8-534a-4330-b468-43223dd79f0c"),
                            Name = "Robyn Fenty"
                        },
                        new
                        {
                            Id = new Guid("898e833d-6519-420a-8792-061c5d3d4e1e"),
                            Name = "Paul Dyson"
                        },
                        new
                        {
                            Id = new Guid("8e04647a-8ce1-413d-a6b1-c3623cb74e95"),
                            Name = "Tiwa Savage"
                        },
                        new
                        {
                            Id = new Guid("72e1d4c7-ceff-44db-b9b6-d177813941ff"),
                            Name = "Mohbad "
                        });
                });

            modelBuilder.Entity("AllDo.Infrastructure.Data.Models.TodoTask", b =>
                {
                    b.HasBaseType("AllDo.Infrastructure.Data.Models.Todo");

                    b.Property<DateTimeOffset>("DueDate")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("TodoTask");
                });

            modelBuilder.Entity("AllDo.Infrastructure.Data.Models.Bug", b =>
                {
                    b.HasBaseType("AllDo.Infrastructure.Data.Models.TodoTask");

                    b.Property<int>("AffectedUsers")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AffectedVersion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("AssignedToId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Severity")
                        .HasColumnType("INTEGER");

                    b.HasIndex("AssignedToId");

                    b.ToTable("Todo", t =>
                        {
                            t.Property("AssignedToId")
                                .HasColumnName("Bug_AssignedToId");

                            t.Property("Description")
                                .HasColumnName("Bug_Description");
                        });

                    b.HasDiscriminator().HasValue("Bug");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3e8d5d50-6727-40c1-b9fc-4817b27aedcc"),
                            CreatedById = new Guid("644d7218-42f9-479c-8436-ebe5224af97e"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 3, 6, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 0, 0, 0, 0)),
                            IsCompleted = false,
                            IsDeleted = false,
                            Title = "Fix Alignment",
                            DueDate = new DateTimeOffset(new DateTime(2024, 3, 20, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7660), new TimeSpan(0, 0, 0, 0, 0)),
                            AffectedUsers = 5,
                            AffectedVersion = "1.2",
                            Description = "Alignment on second wizard screen uneven",
                            Severity = 2
                        },
                        new
                        {
                            Id = new Guid("9f2a863d-c7af-4b61-9bff-765d6f26dca2"),
                            CreatedById = new Guid("61c091a8-534a-4330-b468-43223dd79f0c"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 3, 15, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)),
                            IsCompleted = false,
                            IsDeleted = false,
                            Title = "Splash Screen Exception",
                            DueDate = new DateTimeOffset(new DateTime(2024, 3, 17, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)),
                            AffectedUsers = 450,
                            AffectedVersion = "1.2",
                            Description = "Array Index out of bounds ecxeption",
                            Severity = 0
                        },
                        new
                        {
                            Id = new Guid("cdc8bcbb-a2da-4818-8c0f-c729269c00eb"),
                            CreatedById = new Guid("72e1d4c7-ceff-44db-b9b6-d177813941ff"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 3, 6, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)),
                            IsCompleted = false,
                            IsDeleted = false,
                            Title = "Summary Calculations Wrong",
                            DueDate = new DateTimeOffset(new DateTime(2024, 4, 3, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)),
                            AffectedUsers = 200,
                            AffectedVersion = "1.2",
                            Description = "Incorrect Result calculated for Interest repayments",
                            Severity = 0
                        });
                });

            modelBuilder.Entity("AllDo.Infrastructure.Data.Models.Feature", b =>
                {
                    b.HasBaseType("AllDo.Infrastructure.Data.Models.TodoTask");

                    b.Property<Guid>("AssignedToId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Component")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.HasIndex("AssignedToId");

                    b.HasDiscriminator().HasValue("Feature");

                    b.HasData(
                        new
                        {
                            Id = new Guid("336bdb86-29c7-4a45-91ae-404886969a36"),
                            CreatedById = new Guid("644d7218-42f9-479c-8436-ebe5224af97e"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 3, 6, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7860), new TimeSpan(0, 0, 0, 0, 0)),
                            IsCompleted = false,
                            IsDeleted = false,
                            Title = "Fractional Interest Rates",
                            DueDate = new DateTimeOffset(new DateTime(2024, 3, 20, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7850), new TimeSpan(0, 0, 0, 0, 0)),
                            AssignedToId = new Guid("898e833d-6519-420a-8792-061c5d3d4e1e"),
                            Component = "Component 1",
                            Description = "Tart brownie macaroon wafer bear claw tiramisu apple pie. Cake soufflé cotton candy pudding cheesecake carrot cake cupcake. Danish ice cream chocolate bar sugar plum sugar plum lemon drops. Danish I love donut lemon drops chupa chups. Cake cake marzipan icing cake marzipan oat cake. Cotton candy liquorice toffee caramels wafer jelly beans fruitcake cotton candy. Toffee soufflé chupa chups powder candy gummi bears. Cookie dessert pudding I love gingerbread bear claw fruitcake candy.",
                            Priority = 0
                        },
                        new
                        {
                            Id = new Guid("5708c5aa-4430-4f79-bd2a-fd23bab7f640"),
                            CreatedById = new Guid("61c091a8-534a-4330-b468-43223dd79f0c"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 3, 15, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7870), new TimeSpan(0, 0, 0, 0, 0)),
                            IsCompleted = false,
                            IsDeleted = false,
                            Title = "Advisor Insights",
                            DueDate = new DateTimeOffset(new DateTime(2024, 3, 17, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7870), new TimeSpan(0, 0, 0, 0, 0)),
                            AssignedToId = new Guid("898e833d-6519-420a-8792-061c5d3d4e1e"),
                            Component = "Component 2",
                            Description = "Gingerbread cupcake carrot cake dragée chocolate bar chupa chups. Lemon drops cheesecake jelly-o I love dessert ice cream. Sugar plum cheesecake topping candy pie pastry. I love sugar plum bonbon dragée macaroon I love I love.",
                            Priority = 0
                        },
                        new
                        {
                            Id = new Guid("5e2cef00-7800-4d0c-abf4-2ff25d060076"),
                            CreatedById = new Guid("72e1d4c7-ceff-44db-b9b6-d177813941ff"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 3, 6, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7890), new TimeSpan(0, 0, 0, 0, 0)),
                            IsCompleted = false,
                            IsDeleted = false,
                            Title = "User Preferences",
                            DueDate = new DateTimeOffset(new DateTime(2024, 4, 3, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7890), new TimeSpan(0, 0, 0, 0, 0)),
                            AssignedToId = new Guid("898e833d-6519-420a-8792-061c5d3d4e1e"),
                            Component = "Component 3",
                            Description = "Marzipan candy croissant carrot cake sugar plum marzipan jujubes marshmallow sugar plum. Tart marshmallow halvah powder jelly-o wafer macaroo",
                            Priority = 0
                        },
                        new
                        {
                            Id = new Guid("fc553fdb-1f79-48cc-b360-3d824a408283"),
                            CreatedById = new Guid("72e1d4c7-ceff-44db-b9b6-d177813941ff"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 3, 6, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7900), new TimeSpan(0, 0, 0, 0, 0)),
                            IsCompleted = false,
                            IsDeleted = false,
                            Title = "Split Payments",
                            DueDate = new DateTimeOffset(new DateTime(2024, 4, 3, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7900), new TimeSpan(0, 0, 0, 0, 0)),
                            AssignedToId = new Guid("898e833d-6519-420a-8792-061c5d3d4e1e"),
                            Component = "Component 2",
                            Description = "Shortbread shortbread I love cake chocolate marzipan.. Tart marshmallow halvah powder jelly-o wafer macaroo",
                            Priority = 0
                        });
                });

            modelBuilder.Entity("AllDo.Infrastructure.Data.Models.Image", b =>
                {
                    b.HasOne("AllDo.Infrastructure.Data.Models.Bug", "Bug")
                        .WithMany("Images")
                        .HasForeignKey("BugId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bug");
                });

            modelBuilder.Entity("AllDo.Infrastructure.Data.Models.Todo", b =>
                {
                    b.HasOne("AllDo.Infrastructure.Data.Models.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AllDo.Infrastructure.Data.Models.Todo", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.Navigation("CreatedBy");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("AllDo.Infrastructure.Data.Models.Bug", b =>
                {
                    b.HasOne("AllDo.Infrastructure.Data.Models.User", "AssignedTo")
                        .WithMany()
                        .HasForeignKey("AssignedToId");

                    b.Navigation("AssignedTo");
                });

            modelBuilder.Entity("AllDo.Infrastructure.Data.Models.Feature", b =>
                {
                    b.HasOne("AllDo.Infrastructure.Data.Models.User", "AssignedTo")
                        .WithMany()
                        .HasForeignKey("AssignedToId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignedTo");
                });

            modelBuilder.Entity("AllDo.Infrastructure.Data.Models.Bug", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
