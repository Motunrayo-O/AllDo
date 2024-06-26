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
    [Migration("20240315221630_Testmigration")]
    partial class Testmigration
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
                            Id = new Guid("0eabde08-5118-4153-8b56-df78cd85a1d3"),
                            Name = "Jason Derulo"
                        },
                        new
                        {
                            Id = new Guid("cbc116d6-926e-4eae-aa65-84af773f1080"),
                            Name = "Robyn Fenty"
                        },
                        new
                        {
                            Id = new Guid("0d4435d9-6e04-43fa-8da1-ba1c7588bc13"),
                            Name = "Paul Dyson"
                        },
                        new
                        {
                            Id = new Guid("3b060441-bece-4d89-9291-19471e3b76e6"),
                            Name = "Tiwa Savage"
                        },
                        new
                        {
                            Id = new Guid("406a7c7c-3173-4902-8d71-e8f4e0391edc"),
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

                    b.Property<Guid?>("ImageId")
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
                            Id = new Guid("55cb849a-d82b-47ed-949f-a6048a20f7be"),
                            CreatedById = new Guid("0eabde08-5118-4153-8b56-df78cd85a1d3"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 3, 5, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4050), new TimeSpan(0, 0, 0, 0, 0)),
                            IsCompleted = false,
                            IsDeleted = false,
                            Title = "Fix Alignment",
                            DueDate = new DateTimeOffset(new DateTime(2024, 3, 19, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4030), new TimeSpan(0, 0, 0, 0, 0)),
                            AffectedUsers = 5,
                            AffectedVersion = "1.2",
                            Description = "Alignment on second wizard screen uneven",
                            Severity = 2
                        },
                        new
                        {
                            Id = new Guid("a1b39edd-92bd-49f8-9d0b-16f4c4ac36f8"),
                            CreatedById = new Guid("cbc116d6-926e-4eae-aa65-84af773f1080"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 3, 14, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4060), new TimeSpan(0, 0, 0, 0, 0)),
                            IsCompleted = false,
                            IsDeleted = false,
                            Title = "Splash Screen Exception",
                            DueDate = new DateTimeOffset(new DateTime(2024, 3, 16, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4060), new TimeSpan(0, 0, 0, 0, 0)),
                            AffectedUsers = 450,
                            AffectedVersion = "1.2",
                            Description = "Array Index out of bounds ecxeption",
                            Severity = 0
                        },
                        new
                        {
                            Id = new Guid("720b2e86-0626-458b-8fab-0cf8381ef6cb"),
                            CreatedById = new Guid("406a7c7c-3173-4902-8d71-e8f4e0391edc"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 3, 5, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4080), new TimeSpan(0, 0, 0, 0, 0)),
                            IsCompleted = false,
                            IsDeleted = false,
                            Title = "Summary Calculations Wrong",
                            DueDate = new DateTimeOffset(new DateTime(2024, 4, 2, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4080), new TimeSpan(0, 0, 0, 0, 0)),
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
                            Id = new Guid("eaf722ef-06c1-4861-92fd-f0977d4120da"),
                            CreatedById = new Guid("0eabde08-5118-4153-8b56-df78cd85a1d3"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 3, 5, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4110), new TimeSpan(0, 0, 0, 0, 0)),
                            IsCompleted = false,
                            IsDeleted = false,
                            Title = "Fractional Interest Rates",
                            DueDate = new DateTimeOffset(new DateTime(2024, 3, 19, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4100), new TimeSpan(0, 0, 0, 0, 0)),
                            AssignedToId = new Guid("0d4435d9-6e04-43fa-8da1-ba1c7588bc13"),
                            Component = "Component 1",
                            Description = "Tart brownie macaroon wafer bear claw tiramisu apple pie. Cake soufflé cotton candy pudding cheesecake carrot cake cupcake. Danish ice cream chocolate bar sugar plum sugar plum lemon drops. Danish I love donut lemon drops chupa chups. Cake cake marzipan icing cake marzipan oat cake. Cotton candy liquorice toffee caramels wafer jelly beans fruitcake cotton candy. Toffee soufflé chupa chups powder candy gummi bears. Cookie dessert pudding I love gingerbread bear claw fruitcake candy.",
                            Priority = 0
                        },
                        new
                        {
                            Id = new Guid("e2c875b6-61b8-4c23-9ea0-1716e7a58893"),
                            CreatedById = new Guid("cbc116d6-926e-4eae-aa65-84af773f1080"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 3, 14, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4120), new TimeSpan(0, 0, 0, 0, 0)),
                            IsCompleted = false,
                            IsDeleted = false,
                            Title = "Advisor Insights",
                            DueDate = new DateTimeOffset(new DateTime(2024, 3, 16, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4120), new TimeSpan(0, 0, 0, 0, 0)),
                            AssignedToId = new Guid("0d4435d9-6e04-43fa-8da1-ba1c7588bc13"),
                            Component = "Component 2",
                            Description = "Gingerbread cupcake carrot cake dragée chocolate bar chupa chups. Lemon drops cheesecake jelly-o I love dessert ice cream. Sugar plum cheesecake topping candy pie pastry. I love sugar plum bonbon dragée macaroon I love I love.",
                            Priority = 0
                        },
                        new
                        {
                            Id = new Guid("8bb33ab9-f8bc-4698-b302-29b8a1c661f1"),
                            CreatedById = new Guid("406a7c7c-3173-4902-8d71-e8f4e0391edc"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 3, 5, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4130), new TimeSpan(0, 0, 0, 0, 0)),
                            IsCompleted = false,
                            IsDeleted = false,
                            Title = "User Preferences",
                            DueDate = new DateTimeOffset(new DateTime(2024, 4, 2, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4130), new TimeSpan(0, 0, 0, 0, 0)),
                            AssignedToId = new Guid("0d4435d9-6e04-43fa-8da1-ba1c7588bc13"),
                            Component = "Component 3",
                            Description = "Marzipan candy croissant carrot cake sugar plum marzipan jujubes marshmallow sugar plum. Tart marshmallow halvah powder jelly-o wafer macaroo",
                            Priority = 0
                        },
                        new
                        {
                            Id = new Guid("12383f05-427d-4be1-ad51-d268b328626d"),
                            CreatedById = new Guid("406a7c7c-3173-4902-8d71-e8f4e0391edc"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 3, 5, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4150), new TimeSpan(0, 0, 0, 0, 0)),
                            IsCompleted = false,
                            IsDeleted = false,
                            Title = "Split Payments",
                            DueDate = new DateTimeOffset(new DateTime(2024, 4, 2, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4150), new TimeSpan(0, 0, 0, 0, 0)),
                            AssignedToId = new Guid("0d4435d9-6e04-43fa-8da1-ba1c7588bc13"),
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
