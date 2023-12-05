﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test_Razor.Models;

namespace Test_Razor.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211212040632_scoreContenido")]
    partial class scoreContenido
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Test_Razor.Models.Preferencia", b =>
                {
                    b.Property<string>("rut")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<float>("Abisinio")
                        .HasColumnType("real");

                    b.Property<float>("Adulto")
                        .HasColumnType("real");

                    b.Property<float>("Akita_Inu")
                        .HasColumnType("real");

                    b.Property<float>("Alaskan_Malamute")
                        .HasColumnType("real");

                    b.Property<float>("Anaranjado")
                        .HasColumnType("real");

                    b.Property<float>("Ashera")
                        .HasColumnType("real");

                    b.Property<float>("Australian_Mist")
                        .HasColumnType("real");

                    b.Property<float>("Azul_Ruso")
                        .HasColumnType("real");

                    b.Property<float>("Balines")
                        .HasColumnType("real");

                    b.Property<float>("Basset_Hound")
                        .HasColumnType("real");

                    b.Property<float>("Beagle")
                        .HasColumnType("real");

                    b.Property<float>("Beige")
                        .HasColumnType("real");

                    b.Property<float>("Bengali")
                        .HasColumnType("real");

                    b.Property<float>("Bichon_Maltes")
                        .HasColumnType("real");

                    b.Property<float>("Birmano")
                        .HasColumnType("real");

                    b.Property<float>("Blanco")
                        .HasColumnType("real");

                    b.Property<float>("Bobtail")
                        .HasColumnType("real");

                    b.Property<float>("Bombay")
                        .HasColumnType("real");

                    b.Property<float>("Border_Collie")
                        .HasColumnType("real");

                    b.Property<float>("Bosque_Noruega")
                        .HasColumnType("real");

                    b.Property<float>("Boxer")
                        .HasColumnType("real");

                    b.Property<float>("Boyero_Berna")
                        .HasColumnType("real");

                    b.Property<float>("Braco_Aleman")
                        .HasColumnType("real");

                    b.Property<float>("Braco_Burgos")
                        .HasColumnType("real");

                    b.Property<float>("Braco_Weimar")
                        .HasColumnType("real");

                    b.Property<float>("British_Shorthair")
                        .HasColumnType("real");

                    b.Property<float>("Bull_Mastiff")
                        .HasColumnType("real");

                    b.Property<float>("Bulldog_Frances")
                        .HasColumnType("real");

                    b.Property<float>("Bulldog_Ingles")
                        .HasColumnType("real");

                    b.Property<float>("Burmes")
                        .HasColumnType("real");

                    b.Property<float>("Burmilla")
                        .HasColumnType("real");

                    b.Property<float>("Cachorro")
                        .HasColumnType("real");

                    b.Property<float>("Cafe")
                        .HasColumnType("real");

                    b.Property<float>("Cafe_Claro")
                        .HasColumnType("real");

                    b.Property<float>("Cafe_Oscuro")
                        .HasColumnType("real");

                    b.Property<float>("Caniche")
                        .HasColumnType("real");

                    b.Property<float>("Cavalier_King")
                        .HasColumnType("real");

                    b.Property<float>("Chartreux")
                        .HasColumnType("real");

                    b.Property<float>("Chihuahua")
                        .HasColumnType("real");

                    b.Property<float>("Chow_Chow")
                        .HasColumnType("real");

                    b.Property<float>("Cocker_Spaniel")
                        .HasColumnType("real");

                    b.Property<float>("Corgi_Gales")
                        .HasColumnType("real");

                    b.Property<float>("Cornish_Rex")
                        .HasColumnType("real");

                    b.Property<float>("Corto")
                        .HasColumnType("real");

                    b.Property<float>("Curl_Americano")
                        .HasColumnType("real");

                    b.Property<float>("Dalmata")
                        .HasColumnType("real");

                    b.Property<float>("Desconocido")
                        .HasColumnType("real");

                    b.Property<float>("Devon_Rex")
                        .HasColumnType("real");

                    b.Property<float>("Dobbermann")
                        .HasColumnType("real");

                    b.Property<float>("Dogo_Argentino")
                        .HasColumnType("real");

                    b.Property<float>("Dogo_Burdeos")
                        .HasColumnType("real");

                    b.Property<float>("Duro")
                        .HasColumnType("real");

                    b.Property<float>("Elkhound")
                        .HasColumnType("real");

                    b.Property<float>("Europeo")
                        .HasColumnType("real");

                    b.Property<float>("Exotico_Pelocorto")
                        .HasColumnType("real");

                    b.Property<float>("Fox_Terrier")
                        .HasColumnType("real");

                    b.Property<float>("Galgo")
                        .HasColumnType("real");

                    b.Property<float>("Galgo_Afgano")
                        .HasColumnType("real");

                    b.Property<float>("Galgo_Espanol")
                        .HasColumnType("real");

                    b.Property<float>("Galgo_Italiano")
                        .HasColumnType("real");

                    b.Property<float>("Gato")
                        .HasColumnType("real");

                    b.Property<float>("Golden_Retriever")
                        .HasColumnType("real");

                    b.Property<float>("Gran_Danes")
                        .HasColumnType("real");

                    b.Property<float>("Grande")
                        .HasColumnType("real");

                    b.Property<float>("Grifon_Bruselas")
                        .HasColumnType("real");

                    b.Property<float>("Gris")
                        .HasColumnType("real");

                    b.Property<float>("Habana")
                        .HasColumnType("real");

                    b.Property<float>("Hembra")
                        .HasColumnType("real");

                    b.Property<float>("Himalayo")
                        .HasColumnType("real");

                    b.Property<float>("Husky_Siberiano")
                        .HasColumnType("real");

                    b.Property<float>("Jack_Russell")
                        .HasColumnType("real");

                    b.Property<float>("Javanes")
                        .HasColumnType("real");

                    b.Property<float>("Kagnal_Turco")
                        .HasColumnType("real");

                    b.Property<float>("Keeshoun")
                        .HasColumnType("real");

                    b.Property<float>("Korat")
                        .HasColumnType("real");

                    b.Property<float>("LaPerm")
                        .HasColumnType("real");

                    b.Property<float>("Labrador_Retriever")
                        .HasColumnType("real");

                    b.Property<float>("Lampino")
                        .HasColumnType("real");

                    b.Property<float>("Largo")
                        .HasColumnType("real");

                    b.Property<float>("Lhasa_Apso")
                        .HasColumnType("real");

                    b.Property<float>("Lobero_Irlandes")
                        .HasColumnType("real");

                    b.Property<float>("Lykoi")
                        .HasColumnType("real");

                    b.Property<float>("Macho")
                        .HasColumnType("real");

                    b.Property<float>("Maine_Coon")
                        .HasColumnType("real");

                    b.Property<float>("Manx")
                        .HasColumnType("real");

                    b.Property<float>("Mastin_Espanol")
                        .HasColumnType("real");

                    b.Property<float>("Mastin_Prineo")
                        .HasColumnType("real");

                    b.Property<float>("Mastin_Tibetano")
                        .HasColumnType("real");

                    b.Property<float>("Mau_Egipcio")
                        .HasColumnType("real");

                    b.Property<float>("Mediano")
                        .HasColumnType("real");

                    b.Property<float>("Montes")
                        .HasColumnType("real");

                    b.Property<float>("Munchkin")
                        .HasColumnType("real");

                    b.Property<float>("Nebelung")
                        .HasColumnType("real");

                    b.Property<float>("Negro")
                        .HasColumnType("real");

                    b.Property<float>("Ocicat")
                        .HasColumnType("real");

                    b.Property<float>("Oriental_PeloCorto")
                        .HasColumnType("real");

                    b.Property<float>("Otro_Color")
                        .HasColumnType("real");

                    b.Property<float>("Otro_Raza")
                        .HasColumnType("real");

                    b.Property<float>("Pachon_Navarro")
                        .HasColumnType("real");

                    b.Property<float>("Parson_Russell")
                        .HasColumnType("real");

                    b.Property<float>("Pastor_Aleman")
                        .HasColumnType("real");

                    b.Property<float>("Pastor_Australiano")
                        .HasColumnType("real");

                    b.Property<float>("Pastor_Bergamo")
                        .HasColumnType("real");

                    b.Property<float>("Pastor_Caucasico")
                        .HasColumnType("real");

                    b.Property<float>("Pastor_Vasco")
                        .HasColumnType("real");

                    b.Property<float>("Pastor_Yugoslavo")
                        .HasColumnType("real");

                    b.Property<float>("Pequeno")
                        .HasColumnType("real");

                    b.Property<float>("Perro")
                        .HasColumnType("real");

                    b.Property<float>("Perro_Aguas_Espanol")
                        .HasColumnType("real");

                    b.Property<float>("Perro_Lobo")
                        .HasColumnType("real");

                    b.Property<float>("Perro_Pequines")
                        .HasColumnType("real");

                    b.Property<float>("Persa")
                        .HasColumnType("real");

                    b.Property<float>("Peterbald")
                        .HasColumnType("real");

                    b.Property<float>("Pinscher")
                        .HasColumnType("real");

                    b.Property<float>("Pitbull")
                        .HasColumnType("real");

                    b.Property<float>("Podenco_Andaluz")
                        .HasColumnType("real");

                    b.Property<float>("Pomerania")
                        .HasColumnType("real");

                    b.Property<float>("Pug")
                        .HasColumnType("real");

                    b.Property<float>("Ragdoll")
                        .HasColumnType("real");

                    b.Property<float>("Ratonero_Andaluz")
                        .HasColumnType("real");

                    b.Property<float>("Retriever")
                        .HasColumnType("real");

                    b.Property<float>("Rizado")
                        .HasColumnType("real");

                    b.Property<float>("Rottweiler")
                        .HasColumnType("real");

                    b.Property<float>("Rubio")
                        .HasColumnType("real");

                    b.Property<float>("Sabueso_Espanol")
                        .HasColumnType("real");

                    b.Property<float>("Samoyedo")
                        .HasColumnType("real");

                    b.Property<float>("San_Bernardo")
                        .HasColumnType("real");

                    b.Property<float>("Savannah")
                        .HasColumnType("real");

                    b.Property<float>("Schnauzer_Enano")
                        .HasColumnType("real");

                    b.Property<float>("Schnoodle")
                        .HasColumnType("real");

                    b.Property<float>("Scottish_Fold")
                        .HasColumnType("real");

                    b.Property<float>("Selkirk_Rex")
                        .HasColumnType("real");

                    b.Property<float>("Senior")
                        .HasColumnType("real");

                    b.Property<float>("Setter_Ingles")
                        .HasColumnType("real");

                    b.Property<float>("Shar_Pei")
                        .HasColumnType("real");

                    b.Property<float>("Shausie")
                        .HasColumnType("real");

                    b.Property<float>("Shih_Tzu")
                        .HasColumnType("real");

                    b.Property<float>("Siames")
                        .HasColumnType("real");

                    b.Property<float>("Siberiano")
                        .HasColumnType("real");

                    b.Property<float>("Snowshoe")
                        .HasColumnType("real");

                    b.Property<float>("Sokoke")
                        .HasColumnType("real");

                    b.Property<float>("Somali")
                        .HasColumnType("real");

                    b.Property<float>("Spaniel_Breton")
                        .HasColumnType("real");

                    b.Property<float>("Sphynx")
                        .HasColumnType("real");

                    b.Property<float>("Teckel")
                        .HasColumnType("real");

                    b.Property<float>("Van_Turco")
                        .HasColumnType("real");

                    b.Property<float>("Vizsla")
                        .HasColumnType("real");

                    b.Property<float>("Westie")
                        .HasColumnType("real");

                    b.Property<float>("Xoloitzcuintle")
                        .HasColumnType("real");

                    b.Property<float>("Yorkshire_Terrier")
                        .HasColumnType("real");

                    b.HasKey("rut");

                    b.ToTable("Preferencia");
                });

            modelBuilder.Entity("Test_Razor.Models.Publicacion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("actualizacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("edad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("especie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("pelaje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("raza")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rutaimg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("score")
                        .HasColumnType("float");

                    b.Property<double>("scoreContenido")
                        .HasColumnType("float");

                    b.Property<string>("tamano")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ubicacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("id");

                    b.ToTable("Publicacion");
                });

            modelBuilder.Entity("Test_Razor.Models.Reporte", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("causal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("idPublicacion")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Reporte");
                });

            modelBuilder.Entity("Test_Razor.Models.Usuario", b =>
                {
                    b.Property<string>("rut")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(16)")
                        .HasMaxLength(16);

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.HasKey("rut");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Test_Razor.Models.Visita", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idPublicacion")
                        .HasColumnType("int");

                    b.Property<int>("ranking")
                        .HasColumnType("int");

                    b.Property<string>("rut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Visita");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}