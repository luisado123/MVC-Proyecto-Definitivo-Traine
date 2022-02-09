﻿// <auto-generated />
using System;
using Infraestructure.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infraestructure.Core.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220125171109_luis2")]
    partial class luis2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Infraestructure.Entity.Model.Master.StateEntity", b =>
                {
                    b.Property<int>("IdState")
                        .HasColumnType("int");

                    b.Property<int>("IdTypeState")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdState");

                    b.HasIndex("IdTypeState");

                    b.ToTable("State","Master");
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.Master.TypeStateEntity", b =>
                {
                    b.Property<int>("IdTypeState")
                        .HasColumnType("int");

                    b.Property<string>("TypeState")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdTypeState");

                    b.ToTable("TypeStateEntity","Master");
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.PermissionEntity", b =>
                {
                    b.Property<int>("IdPermission")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("IdTypePermission")
                        .HasColumnType("int");

                    b.Property<string>("Permission")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdPermission");

                    b.HasIndex("IdTypePermission");

                    b.ToTable("Permission","Security");
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.RolEntity", b =>
                {
                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.Property<string>("Rol")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdRol");

                    b.ToTable("Rol","Security");
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.RolPermissionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdPermission")
                        .HasColumnType("int");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPermission");

                    b.HasIndex("IdRol");

                    b.ToTable("RolesPermissions","Security");
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.RolUserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdRol");

                    b.HasIndex("IdUser");

                    b.ToTable("RolUser","Security");
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.TypePermissionEntity", b =>
                {
                    b.Property<int>("IdTypePermission")
                        .HasColumnType("int");

                    b.Property<string>("TypePermission")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("IdTypePermission");

                    b.ToTable("TypePermission","Security");
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.UserEntity", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("IdUser");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("User","Security");
                });

            modelBuilder.Entity("Infraestructure.Entity.Vet.DatesEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CLosingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<int>("IdPet")
                        .HasColumnType("int");

                    b.Property<int>("IdServices")
                        .HasColumnType("int");

                    b.Property<int>("IdState")
                        .HasColumnType("int");

                    b.Property<int?>("IdUserVet")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPet");

                    b.HasIndex("IdServices");

                    b.HasIndex("IdState");

                    b.HasIndex("IdUserVet");

                    b.ToTable("Dates","Vet");
                });

            modelBuilder.Entity("Infraestructure.Entity.Vet.PetEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateBorns")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdSex")
                        .HasColumnType("int");

                    b.Property<int>("IdTypePet")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("IdSex");

                    b.HasIndex("IdTypePet");

                    b.ToTable("Pet","Vet");
                });

            modelBuilder.Entity("Infraestructure.Entity.Vet.ServicesEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Services")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Services","Vet");
                });

            modelBuilder.Entity("Infraestructure.Entity.Vet.SexEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Sex","Vet");
                });

            modelBuilder.Entity("Infraestructure.Entity.Vet.TypePetEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypePet")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("TypePet","Vet");
                });

            modelBuilder.Entity("Infraestructure.Entity.Vet.UserPetEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdPet")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPet")
                        .IsUnique();

                    b.HasIndex("IdUser");

                    b.ToTable("UserPet","Vet");
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.Master.StateEntity", b =>
                {
                    b.HasOne("Infraestructure.Entity.Model.Master.TypeStateEntity", "TypeStateEntity")
                        .WithMany()
                        .HasForeignKey("IdTypeState")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.PermissionEntity", b =>
                {
                    b.HasOne("Infraestructure.Entity.Model.TypePermissionEntity", "TypePermissionEntity")
                        .WithMany("PermissionEntities")
                        .HasForeignKey("IdTypePermission")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.RolPermissionEntity", b =>
                {
                    b.HasOne("Infraestructure.Entity.Model.PermissionEntity", "PermissionEntity")
                        .WithMany("RolPermissionEntities")
                        .HasForeignKey("IdPermission")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infraestructure.Entity.Model.RolEntity", "RolEntity")
                        .WithMany("RolPermissionEntities")
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.RolUserEntity", b =>
                {
                    b.HasOne("Infraestructure.Entity.Model.RolEntity", "RolEntity")
                        .WithMany("RolUserEntities")
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infraestructure.Entity.Model.UserEntity", "UserEntity")
                        .WithMany("RolUserEntities")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infraestructure.Entity.Vet.DatesEntity", b =>
                {
                    b.HasOne("Infraestructure.Entity.Vet.PetEntity", "PetEntity")
                        .WithMany()
                        .HasForeignKey("IdPet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infraestructure.Entity.Vet.ServicesEntity", "ServicesEntity")
                        .WithMany()
                        .HasForeignKey("IdServices")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infraestructure.Entity.Model.Master.StateEntity", "StateEntity")
                        .WithMany()
                        .HasForeignKey("IdState")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infraestructure.Entity.Model.UserEntity", "UserVetEntity")
                        .WithMany()
                        .HasForeignKey("IdUserVet");
                });

            modelBuilder.Entity("Infraestructure.Entity.Vet.PetEntity", b =>
                {
                    b.HasOne("Infraestructure.Entity.Vet.SexEntity", "SexEntity")
                        .WithMany()
                        .HasForeignKey("IdSex")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infraestructure.Entity.Vet.TypePetEntity", "TypePetEntity")
                        .WithMany()
                        .HasForeignKey("IdTypePet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infraestructure.Entity.Vet.UserPetEntity", b =>
                {
                    b.HasOne("Infraestructure.Entity.Vet.PetEntity", "PetEntity")
                        .WithOne("UserPetEntity")
                        .HasForeignKey("Infraestructure.Entity.Vet.UserPetEntity", "IdPet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infraestructure.Entity.Model.UserEntity", "UserEntity")
                        .WithMany("UserPetEntities")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
