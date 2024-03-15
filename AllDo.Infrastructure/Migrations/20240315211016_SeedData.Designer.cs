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
    [Migration("20240315211016_SeedData")]
    partial class SeedData
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

                    b.Property<Guid?>("BugId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageData")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BugId");

                    b.ToTable("Images");
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
                            Id = new Guid("9ef0e7ec-5336-4242-8a4b-64b081078ca3"),
                            Name = "Jason Derulo"
                        },
                        new
                        {
                            Id = new Guid("392731cb-8a70-4719-b63c-0a30951d7679"),
                            Name = "Robyn Fenty"
                        },
                        new
                        {
                            Id = new Guid("ec0c4be6-6054-4cf4-a7f8-6c59e5f178ca"),
                            Name = "Paul Dyson"
                        },
                        new
                        {
                            Id = new Guid("f5f362f6-4bb2-4671-bc42-0bdaceac1563"),
                            Name = "Tiwa Savage"
                        },
                        new
                        {
                            Id = new Guid("6ef8dd83-a5f5-4850-b32d-5fabe3b68d60"),
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
                            Id = new Guid("89657dc5-6ff1-43ce-844e-783e5cd9e94a"),
                            CreatedById = new Guid("9ef0e7ec-5336-4242-8a4b-64b081078ca3"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 3, 5, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6180), new TimeSpan(0, 0, 0, 0, 0)),
                            IsCompleted = false,
                            IsDeleted = false,
                            Title = "Fix Alignment!",
                            DueDate = new DateTimeOffset(new DateTime(2024, 3, 19, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6160), new TimeSpan(0, 0, 0, 0, 0)),
                            AffectedUsers = 5,
                            AffectedVersion = "1.2",
                            Description = "Alignment on second wizard screen uneven",
                            Severity = 2
                        },
                        new
                        {
                            Id = new Guid("1f4da944-7fe6-4636-89d7-60acaa684410"),
                            CreatedById = new Guid("392731cb-8a70-4719-b63c-0a30951d7679"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 3, 14, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6190), new TimeSpan(0, 0, 0, 0, 0)),
                            IsCompleted = false,
                            IsDeleted = false,
                            Title = "Splash Screen Exception",
                            DueDate = new DateTimeOffset(new DateTime(2024, 3, 16, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6190), new TimeSpan(0, 0, 0, 0, 0)),
                            AffectedUsers = 450,
                            AffectedVersion = "1.2",
                            Description = "Array Index out of bounds ecxeption",
                            Severity = 0
                        },
                        new
                        {
                            Id = new Guid("69ee876a-2852-4c17-b5d4-1a680e09d32e"),
                            CreatedById = new Guid("6ef8dd83-a5f5-4850-b32d-5fabe3b68d60"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 3, 5, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6210), new TimeSpan(0, 0, 0, 0, 0)),
                            IsCompleted = false,
                            IsDeleted = false,
                            Title = "Summary Calculations Wrong",
                            DueDate = new DateTimeOffset(new DateTime(2024, 4, 2, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6210), new TimeSpan(0, 0, 0, 0, 0)),
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
                            Id = new Guid("9319f7a3-a051-4af9-b295-e91c077bb0fa"),
                            CreatedById = new Guid("9ef0e7ec-5336-4242-8a4b-64b081078ca3"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 3, 5, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6240), new TimeSpan(0, 0, 0, 0, 0)),
                            IsCompleted = false,
                            IsDeleted = false,
                            Title = "Fractional Interest Rates",
                            DueDate = new DateTimeOffset(new DateTime(2024, 3, 19, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6240), new TimeSpan(0, 0, 0, 0, 0)),
                            AssignedToId = new Guid("ec0c4be6-6054-4cf4-a7f8-6c59e5f178ca"),
                            Component = "Component 1",
                            Description = "Tart brownie macaroon wafer bear claw tiramisu apple pie. Cake soufflé cotton candy pudding cheesecake carrot cake cupcake. Danish ice cream chocolate bar sugar plum sugar plum lemon drops. Danish I love donut lemon drops chupa chups. Cake cake marzipan icing cake marzipan oat cake. Cotton candy liquorice toffee caramels wafer jelly beans fruitcake cotton candy. Toffee soufflé chupa chups powder candy gummi bears. Cookie dessert pudding I love gingerbread bear claw fruitcake candy.",
                            Priority = 0
                        },
                        new
                        {
                            Id = new Guid("b9137577-6fc0-4847-8ad5-4f26c806cd2a"),
                            CreatedById = new Guid("392731cb-8a70-4719-b63c-0a30951d7679"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 3, 14, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6250), new TimeSpan(0, 0, 0, 0, 0)),
                            IsCompleted = false,
                            IsDeleted = false,
                            Title = "Advisor Insights",
                            DueDate = new DateTimeOffset(new DateTime(2024, 3, 16, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6250), new TimeSpan(0, 0, 0, 0, 0)),
                            AssignedToId = new Guid("ec0c4be6-6054-4cf4-a7f8-6c59e5f178ca"),
                            Component = "Component 2",
                            Description = "Gingerbread cupcake carrot cake dragée chocolate bar chupa chups. Lemon drops cheesecake jelly-o I love dessert ice cream. Sugar plum cheesecake topping candy pie pastry. I love sugar plum bonbon dragée macaroon I love I love.",
                            Priority = 0
                        },
                        new
                        {
                            Id = new Guid("afb3b228-5f6b-456f-abf2-600ce1a7ebf9"),
                            CreatedById = new Guid("6ef8dd83-a5f5-4850-b32d-5fabe3b68d60"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 3, 5, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6270), new TimeSpan(0, 0, 0, 0, 0)),
                            IsCompleted = false,
                            IsDeleted = false,
                            Title = "User Preferences",
                            DueDate = new DateTimeOffset(new DateTime(2024, 4, 2, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6270), new TimeSpan(0, 0, 0, 0, 0)),
                            AssignedToId = new Guid("ec0c4be6-6054-4cf4-a7f8-6c59e5f178ca"),
                            Component = "Component 3",
                            Description = "Marzipan candy croissant carrot cake sugar plum marzipan jujubes marshmallow sugar plum. Tart marshmallow halvah powder jelly-o wafer macaroo",
                            Priority = 0
                        },
                        new
                        {
                            Id = new Guid("e5d34104-6a81-4e63-8859-4808e30f7b3b"),
                            CreatedById = new Guid("6ef8dd83-a5f5-4850-b32d-5fabe3b68d60"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 3, 5, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6280), new TimeSpan(0, 0, 0, 0, 0)),
                            IsCompleted = false,
                            IsDeleted = false,
                            Title = "Split Payments",
                            DueDate = new DateTimeOffset(new DateTime(2024, 4, 2, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6280), new TimeSpan(0, 0, 0, 0, 0)),
                            AssignedToId = new Guid("ec0c4be6-6054-4cf4-a7f8-6c59e5f178ca"),
                            Component = "Component 2",
                            Description = "Shortbread shortbread I love cake chocolate marzipan.. Tart marshmallow halvah powder jelly-o wafer macaroo",
                            Priority = 0
                        });
                });

            modelBuilder.Entity("AllDo.Infrastructure.Data.Models.Image", b =>
                {
                    b.HasOne("AllDo.Infrastructure.Data.Models.Bug", null)
                        .WithMany("Images")
                        .HasForeignKey("BugId");
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
