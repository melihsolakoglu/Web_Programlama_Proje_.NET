﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebProje1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    kullaniciAdi = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    KullaniciSoyadi = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    kullaniciEmail = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    kullaniciSifre = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Locked = table.Column<bool>(type: "boolean", nullable: false),
                    KayitTarih = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kullanici");
        }
    }
}
