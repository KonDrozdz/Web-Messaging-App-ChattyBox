﻿// <auto-generated />
using System;
using DAL.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(DbChattyBox))]
    partial class DbChattyBoxModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DAL.Database.Entities.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Chats", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2023, 4, 15, 17, 6, 35, 977, DateTimeKind.Local).AddTicks(2031),
                            Name = "Chat1"
                        });
                });

            modelBuilder.Entity("DAL.Database.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ChatId")
                        .HasColumnType("int");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("SenderId");

                    b.ToTable((string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("DAL.Database.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "User"
                        });
                });

            modelBuilder.Entity("DAL.Database.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("LastLog")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2023, 4, 15, 17, 6, 35, 977, DateTimeKind.Local).AddTicks(1877),
                            Email = "marcinq@gmail.com",
                            PasswordHash = new byte[] { 161, 38, 163, 193, 95, 29, 23, 231, 170, 230, 102, 65, 150, 108, 203, 85, 180, 45, 30, 26, 0, 190, 233, 1, 202, 5, 253, 61, 122, 44, 23, 30, 208, 237, 198, 134, 211, 247, 123, 99, 214, 149, 53, 78, 177, 149, 209, 149, 55, 248, 145, 228, 58, 63, 241, 153, 71, 231, 159, 128, 38, 203, 3, 107 },
                            PasswordSalt = new byte[] { 90, 31, 130, 201, 175, 147, 108, 45, 222, 114, 122, 250, 2, 234, 209, 136, 23, 181, 247, 120, 191, 47, 107, 232, 57, 69, 193, 214, 65, 155, 129, 163, 196, 252, 175, 73, 117, 34, 2, 173, 180, 205, 80, 83, 243, 96, 186, 111, 90, 11, 120, 24, 252, 30, 228, 200, 183, 41, 124, 97, 200, 172, 70, 101, 99, 167, 53, 176, 163, 181, 59, 173, 112, 232, 136, 121, 183, 52, 5, 178, 169, 59, 152, 216, 151, 134, 63, 8, 76, 47, 54, 84, 10, 79, 153, 24, 82, 157, 1, 192, 243, 159, 230, 174, 229, 154, 60, 176, 164, 24, 170, 235, 25, 160, 176, 191, 27, 27, 12, 161, 161, 0, 80, 232, 67, 34, 174, 45 },
                            Username = "MarIwin"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2023, 4, 15, 17, 6, 35, 977, DateTimeKind.Local).AddTicks(1909),
                            Email = "tymonq@gmail.com",
                            PasswordHash = new byte[] { 124, 71, 27, 48, 8, 15, 70, 136, 23, 139, 223, 156, 113, 94, 174, 28, 144, 194, 2, 247, 68, 7, 116, 136, 15, 135, 35, 40, 57, 118, 164, 237, 97, 208, 214, 138, 21, 91, 17, 82, 54, 22, 215, 55, 50, 104, 104, 238, 42, 137, 212, 61, 61, 28, 174, 81, 88, 205, 7, 221, 246, 43, 250, 6 },
                            PasswordSalt = new byte[] { 163, 138, 69, 154, 123, 109, 156, 109, 45, 11, 245, 127, 133, 117, 124, 176, 77, 153, 73, 169, 249, 71, 157, 161, 247, 143, 230, 213, 21, 38, 241, 215, 199, 116, 196, 238, 219, 124, 52, 140, 101, 99, 202, 36, 134, 169, 162, 160, 233, 118, 126, 142, 105, 92, 145, 247, 210, 211, 209, 80, 102, 48, 137, 92, 43, 166, 255, 160, 79, 40, 51, 224, 123, 110, 60, 199, 12, 101, 8, 57, 109, 28, 39, 193, 125, 117, 130, 31, 8, 74, 202, 155, 7, 207, 94, 118, 7, 174, 109, 17, 220, 161, 248, 45, 228, 248, 127, 20, 17, 179, 89, 208, 95, 222, 250, 121, 82, 167, 152, 47, 92, 212, 116, 114, 207, 64, 41, 99 },
                            Username = "TymonSme"
                        });
                });

            modelBuilder.Entity("DAL.Database.Entities.UserChat", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ChatId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ChatId");

                    b.HasIndex("ChatId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserChats");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            ChatId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 2,
                            ChatId = 1,
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("DAL.Database.Entities.FileMessage", b =>
                {
                    b.HasBaseType("DAL.Database.Entities.Message");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Size")
                        .HasColumnType("float");

                    b.ToTable("FileMessage", null, t =>
                        {
                            t.Property("Id")
                                .HasAnnotation("SqlServer:IdentityIncrement", 2)
                                .HasAnnotation("SqlServer:IdentitySeed", 2L)
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
                        });

                    b.HasData(
                        new
                        {
                            Id = 2,
                            ChatId = 1,
                            SenderId = 1,
                            TimeStamp = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "stockImage.jpg",
                            Path = "files\\Chat1\\stockImage.jpg",
                            Size = 0.09969329833984375
                        },
                        new
                        {
                            Id = 4,
                            ChatId = 1,
                            SenderId = 2,
                            TimeStamp = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "stockGif.gif",
                            Path = "files\\Chat1\\stockGif.gif",
                            Size = 5.467991828918457
                        });
                });

            modelBuilder.Entity("DAL.Database.Entities.TextMessage", b =>
                {
                    b.HasBaseType("DAL.Database.Entities.Message");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.ToTable("TextMessages", null, t =>
                        {
                            t.Property("Id")
                                .HasAnnotation("SqlServer:IdentityIncrement", 2)
                                .HasAnnotation("SqlServer:IdentitySeed", 1L)
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ChatId = 1,
                            SenderId = 1,
                            TimeStamp = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Content = "Hello1"
                        },
                        new
                        {
                            Id = 3,
                            ChatId = 1,
                            SenderId = 2,
                            TimeStamp = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Content = "Hello2"
                        });
                });

            modelBuilder.Entity("DAL.Database.Entities.Message", b =>
                {
                    b.HasOne("DAL.Database.Entities.Chat", "Chat")
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Database.Entities.User", "Sender")
                        .WithMany("Messages")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("DAL.Database.Entities.UserChat", b =>
                {
                    b.HasOne("DAL.Database.Entities.Chat", "Chat")
                        .WithMany("UserChats")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Database.Entities.Role", "Role")
                        .WithMany("UserChats")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Database.Entities.User", "User")
                        .WithMany("UserChats")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Database.Entities.Chat", b =>
                {
                    b.Navigation("Messages");

                    b.Navigation("UserChats");
                });

            modelBuilder.Entity("DAL.Database.Entities.Role", b =>
                {
                    b.Navigation("UserChats");
                });

            modelBuilder.Entity("DAL.Database.Entities.User", b =>
                {
                    b.Navigation("Messages");

                    b.Navigation("UserChats");
                });
#pragma warning restore 612, 618
        }
    }
}
