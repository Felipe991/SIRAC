﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Razor.Migrations
{
    public partial class Preferencia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Preferencia",
                columns: table => new
                {
                    rut = table.Column<string>(maxLength: 12, nullable: false),
                    Macho = table.Column<int>(nullable: false),
                    Hembra = table.Column<int>(nullable: false),
                    Cachorro = table.Column<int>(nullable: false),
                    Adulto = table.Column<int>(nullable: false),
                    Senior = table.Column<int>(nullable: false),
                    Desconocido = table.Column<int>(nullable: false),
                    Duro = table.Column<int>(nullable: false),
                    Rizado = table.Column<int>(nullable: false),
                    Corto = table.Column<int>(nullable: false),
                    Largo = table.Column<int>(nullable: false),
                    Lampino = table.Column<int>(nullable: false),
                    Negro = table.Column<int>(nullable: false),
                    Blanco = table.Column<int>(nullable: false),
                    Beige = table.Column<int>(nullable: false),
                    Gris = table.Column<int>(nullable: false),
                    Cafe = table.Column<int>(nullable: false),
                    Cafe_Claro = table.Column<int>(nullable: false),
                    Cafe_Oscuro = table.Column<int>(nullable: false),
                    Anaranjado = table.Column<int>(nullable: false),
                    Rubio = table.Column<int>(nullable: false),
                    Otro_Color = table.Column<int>(nullable: false),
                    Pequeno = table.Column<int>(nullable: false),
                    Mediano = table.Column<int>(nullable: false),
                    Grande = table.Column<int>(nullable: false),
                    Perro = table.Column<int>(nullable: false),
                    Gato = table.Column<int>(nullable: false),
                    Pastor_Bergamo = table.Column<int>(nullable: false),
                    Schnoodle = table.Column<int>(nullable: false),
                    Galgo = table.Column<int>(nullable: false),
                    Retiever = table.Column<int>(nullable: false),
                    Elkhound = table.Column<int>(nullable: false),
                    Keeshoun = table.Column<int>(nullable: false),
                    Pastor_Caucasico = table.Column<int>(nullable: false),
                    Basset_Hound = table.Column<int>(nullable: false),
                    Kagnal_Turco = table.Column<int>(nullable: false),
                    Pastor_Australiano = table.Column<int>(nullable: false),
                    Xoloitzcuintle = table.Column<int>(nullable: false),
                    Corgi_Gales = table.Column<int>(nullable: false),
                    Perro_Lobo = table.Column<int>(nullable: false),
                    Alaskan_Malamute = table.Column<int>(nullable: false),
                    Mastin_Tibetano = table.Column<int>(nullable: false),
                    Shar_Pei = table.Column<int>(nullable: false),
                    Galgo_Italiano = table.Column<int>(nullable: false),
                    Spaniel_Breton = table.Column<int>(nullable: false),
                    Ratonero_Andaluz = table.Column<int>(nullable: false),
                    Fox_Terrier = table.Column<int>(nullable: false),
                    Bull_Mastiff = table.Column<int>(nullable: false),
                    Pastor_Yugoslavo = table.Column<int>(nullable: false),
                    Braco_Weimar = table.Column<int>(nullable: false),
                    Setter_Ingles = table.Column<int>(nullable: false),
                    Sabueso_Espanol = table.Column<int>(nullable: false),
                    Boyero_Berna = table.Column<int>(nullable: false),
                    Grifon_Bruselas = table.Column<int>(nullable: false),
                    Dogo_Burdeos = table.Column<int>(nullable: false),
                    Lobero_Irlandes = table.Column<int>(nullable: false),
                    Lhasa_Apso = table.Column<int>(nullable: false),
                    Bulldog_Ingles = table.Column<int>(nullable: false),
                    Cavalier_King = table.Column<int>(nullable: false),
                    Perro_Pequines = table.Column<int>(nullable: false),
                    Pug = table.Column<int>(nullable: false),
                    Parson_Russell = table.Column<int>(nullable: false),
                    Braco_Aleman = table.Column<int>(nullable: false),
                    Jack_Russell = table.Column<int>(nullable: false),
                    Pachon_Navarro = table.Column<int>(nullable: false),
                    Westie = table.Column<int>(nullable: false),
                    Galgo_Espanol = table.Column<int>(nullable: false),
                    Mastin_Espanol = table.Column<int>(nullable: false),
                    San_Bernardo = table.Column<int>(nullable: false),
                    Gran_Danes = table.Column<int>(nullable: false),
                    Pinscher = table.Column<int>(nullable: false),
                    Podenco_Andaluz = table.Column<int>(nullable: false),
                    Braco_Burgos = table.Column<int>(nullable: false),
                    Perro_Aguas_Espanol = table.Column<int>(nullable: false),
                    Dogo_Argentino = table.Column<int>(nullable: false),
                    Pomerania = table.Column<int>(nullable: false),
                    Mastin_Prineo = table.Column<int>(nullable: false),
                    Rottweiler = table.Column<int>(nullable: false),
                    Chow_Chow = table.Column<int>(nullable: false),
                    Samoyedo = table.Column<int>(nullable: false),
                    Bobtail = table.Column<int>(nullable: false),
                    Teckel = table.Column<int>(nullable: false),
                    Shih_Tzu = table.Column<int>(nullable: false),
                    Caniche = table.Column<int>(nullable: false),
                    Pitbull = table.Column<int>(nullable: false),
                    Bichon_Maltes = table.Column<int>(nullable: false),
                    Husky_Siberiano = table.Column<int>(nullable: false),
                    Cocker_Spaniel = table.Column<int>(nullable: false),
                    Border_Collie = table.Column<int>(nullable: false),
                    Dalmata = table.Column<int>(nullable: false),
                    Beagle = table.Column<int>(nullable: false),
                    Dobbermann = table.Column<int>(nullable: false),
                    Yorkshire_Terrier = table.Column<int>(nullable: false),
                    Pastor_Vasco = table.Column<int>(nullable: false),
                    Schnauzer_Enano = table.Column<int>(nullable: false),
                    Vizsla = table.Column<int>(nullable: false),
                    Pastor_Aleman = table.Column<int>(nullable: false),
                    Retriever = table.Column<int>(nullable: false),
                    Boxer = table.Column<int>(nullable: false),
                    Akita_Inu = table.Column<int>(nullable: false),
                    Galgo_Afgano = table.Column<int>(nullable: false),
                    Golden_Retriever = table.Column<int>(nullable: false),
                    Bulldog_Frances = table.Column<int>(nullable: false),
                    Chihuahua = table.Column<int>(nullable: false),
                    LaPerm = table.Column<int>(nullable: false),
                    Burmilla = table.Column<int>(nullable: false),
                    Curl_Americano = table.Column<int>(nullable: false),
                    Montes = table.Column<int>(nullable: false),
                    Burmes = table.Column<int>(nullable: false),
                    Munchkin = table.Column<int>(nullable: false),
                    Shausie = table.Column<int>(nullable: false),
                    Devon_Rex = table.Column<int>(nullable: false),
                    Javanes = table.Column<int>(nullable: false),
                    Scottish_Fold = table.Column<int>(nullable: false),
                    Van_Turco = table.Column<int>(nullable: false),
                    Korat = table.Column<int>(nullable: false),
                    Somali = table.Column<int>(nullable: false),
                    Sphynx = table.Column<int>(nullable: false),
                    Savannah = table.Column<int>(nullable: false),
                    Chartreux = table.Column<int>(nullable: false),
                    Sokoke = table.Column<int>(nullable: false),
                    Selkirk_Rex = table.Column<int>(nullable: false),
                    Nebelung = table.Column<int>(nullable: false),
                    Lykoi = table.Column<int>(nullable: false),
                    Cornish_Rex = table.Column<int>(nullable: false),
                    Ocicat = table.Column<int>(nullable: false),
                    Peterbald = table.Column<int>(nullable: false),
                    Oriental_PeloCorto = table.Column<int>(nullable: false),
                    Siberiano = table.Column<int>(nullable: false),
                    Manx = table.Column<int>(nullable: false),
                    Exotico_Pelocorto = table.Column<int>(nullable: false),
                    Birmano = table.Column<int>(nullable: false),
                    Bosque_Noruega = table.Column<int>(nullable: false),
                    Snowshoe = table.Column<int>(nullable: false),
                    Bengali = table.Column<int>(nullable: false),
                    Ashera = table.Column<int>(nullable: false),
                    Abisinio = table.Column<int>(nullable: false),
                    Balines = table.Column<int>(nullable: false),
                    Maine_Coon = table.Column<int>(nullable: false),
                    British_Shorthair = table.Column<int>(nullable: false),
                    Azul_Ruso = table.Column<int>(nullable: false),
                    Bombay = table.Column<int>(nullable: false),
                    Europeo = table.Column<int>(nullable: false),
                    Mau_Egipcio = table.Column<int>(nullable: false),
                    Australian_Mist = table.Column<int>(nullable: false),
                    Himalayo = table.Column<int>(nullable: false),
                    Habana = table.Column<int>(nullable: false),
                    Persa = table.Column<int>(nullable: false),
                    Siames = table.Column<int>(nullable: false),
                    Ragdoll = table.Column<int>(nullable: false),
                    Otro_Raza = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preferencia", x => x.rut);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Preferencia");
        }
    }
}
