using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SincomYazilim.WebOnMuhasebe.Migrations
{
    public partial class kendiTablomuzlariEkliyoruz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SinDonemler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kod = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Ad = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Durum = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinDonemler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SinOzelKodlar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kod = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Ad = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    KodTuru = table.Column<byte>(type: "TinyInt", nullable: false),
                    KartTuru = table.Column<byte>(type: "TinyInt", nullable: false),
                    Aciklama = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Durum = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinOzelKodlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SinSubeler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kod = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Ad = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Durum = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinSubeler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SinBankalar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kod = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Ad = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    OzelKod1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    OzelKod2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Aciklama = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Durum = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinBankalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinBankalar_SinOzelKodlar_OzelKod1Id",
                        column: x => x.OzelKod1Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinBankalar_SinOzelKodlar_OzelKod2Id",
                        column: x => x.OzelKod2Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SinBirimler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kod = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Ad = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    OzelKod1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    OzelKod2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Aciklama = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Durum = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinBirimler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinBirimler_SinOzelKodlar_OzelKod1Id",
                        column: x => x.OzelKod1Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinBirimler_SinOzelKodlar_OzelKod2Id",
                        column: x => x.OzelKod2Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SinCariler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kod = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Ad = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    VergiDairesi = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: true),
                    VergiNo = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: true),
                    TcNo = table.Column<string>(type: "VarChar(11)", maxLength: 11, nullable: true),
                    Telefon = table.Column<string>(type: "VarChar(15)", maxLength: 15, nullable: true),
                    Adres = table.Column<string>(type: "VarChar(150)", maxLength: 150, nullable: true),
                    OzelKod1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    OzelKod2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Aciklama = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Durum = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinCariler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinCariler_SinOzelKodlar_OzelKod1Id",
                        column: x => x.OzelKod1Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinCariler_SinOzelKodlar_OzelKod2Id",
                        column: x => x.OzelKod2Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SinDepolar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kod = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Ad = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    OzelKod1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    OzelKod2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SubeId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    Aciklama = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Durum = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinDepolar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinDepolar_SinOzelKodlar_OzelKod1Id",
                        column: x => x.OzelKod1Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinDepolar_SinOzelKodlar_OzelKod2Id",
                        column: x => x.OzelKod2Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinDepolar_SinSubeler_SubeId",
                        column: x => x.SubeId,
                        principalTable: "SinSubeler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SinKasalar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kod = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Ad = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    OzelKod1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    OzelKod2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SubeId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    Aciklama = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Durum = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinKasalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinKasalar_SinOzelKodlar_OzelKod1Id",
                        column: x => x.OzelKod1Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinKasalar_SinOzelKodlar_OzelKod2Id",
                        column: x => x.OzelKod2Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinKasalar_SinSubeler_SubeId",
                        column: x => x.SubeId,
                        principalTable: "SinSubeler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SinBankaSubeler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kod = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Ad = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    BankaId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    OzelKod1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    OzelKod2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Aciklama = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Durum = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinBankaSubeler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinBankaSubeler_SinBankalar_BankaId",
                        column: x => x.BankaId,
                        principalTable: "SinBankalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SinBankaSubeler_SinOzelKodlar_OzelKod1Id",
                        column: x => x.OzelKod1Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinBankaSubeler_SinOzelKodlar_OzelKod2Id",
                        column: x => x.OzelKod2Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SinHizmetler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kod = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Ad = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    KdvOrani = table.Column<int>(type: "Int", nullable: false),
                    BirimFiyat = table.Column<decimal>(type: "Money", nullable: false),
                    Barkod = table.Column<string>(type: "VarChar(128)", maxLength: 128, nullable: true),
                    BirimId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    OzelKod1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    OzelKod2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Aciklama = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Durum = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinHizmetler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinHizmetler_SinBirimler_BirimId",
                        column: x => x.BirimId,
                        principalTable: "SinBirimler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinHizmetler_SinOzelKodlar_OzelKod1Id",
                        column: x => x.OzelKod1Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinHizmetler_SinOzelKodlar_OzelKod2Id",
                        column: x => x.OzelKod2Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SinMasraflar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kod = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Ad = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    KdvOrani = table.Column<int>(type: "Int", nullable: false),
                    BirimFiyat = table.Column<decimal>(type: "Money", nullable: false),
                    Barkod = table.Column<string>(type: "VarChar(128)", maxLength: 128, nullable: true),
                    BirimId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    OzelKod1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    OzelKod2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Aciklama = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Durum = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinMasraflar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinMasraflar_SinBirimler_BirimId",
                        column: x => x.BirimId,
                        principalTable: "SinBirimler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinMasraflar_SinOzelKodlar_OzelKod1Id",
                        column: x => x.OzelKod1Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinMasraflar_SinOzelKodlar_OzelKod2Id",
                        column: x => x.OzelKod2Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SinStoklar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kod = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Ad = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    KdvOrani = table.Column<int>(type: "Int", nullable: false),
                    BirimFiyat = table.Column<decimal>(type: "Money", nullable: false),
                    Barkod = table.Column<string>(type: "VarChar(128)", maxLength: 128, nullable: true),
                    BirimId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    OzelKod1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    OzelKod2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Aciklama = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Durum = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinStoklar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinStoklar_SinBirimler_BirimId",
                        column: x => x.BirimId,
                        principalTable: "SinBirimler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinStoklar_SinOzelKodlar_OzelKod1Id",
                        column: x => x.OzelKod1Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinStoklar_SinOzelKodlar_OzelKod2Id",
                        column: x => x.OzelKod2Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SinFaturalar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FaturaTuru = table.Column<byte>(type: "TinyInt", nullable: false),
                    FaturaNO = table.Column<string>(type: "VarChar(16)", maxLength: 16, nullable: false),
                    Tarih = table.Column<DateTime>(type: "Date", nullable: false),
                    BrutTutar = table.Column<decimal>(type: "Money", nullable: false),
                    IndirimTutar = table.Column<decimal>(type: "Money", nullable: false),
                    KdvHaricTutar = table.Column<decimal>(type: "Money", nullable: false),
                    KdvTutar = table.Column<decimal>(type: "Money", nullable: false),
                    NetTutar = table.Column<decimal>(type: "Money", nullable: false),
                    HareketSayisi = table.Column<int>(type: "Int", nullable: false),
                    CariId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    OzelKod1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    OzelKod2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SubeId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    DonemId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    Aciklama = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Durum = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinFaturalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinFaturalar_SinCariler_CariId",
                        column: x => x.CariId,
                        principalTable: "SinCariler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinFaturalar_SinDonemler_DonemId",
                        column: x => x.DonemId,
                        principalTable: "SinDonemler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinFaturalar_SinOzelKodlar_OzelKod1Id",
                        column: x => x.OzelKod1Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinFaturalar_SinOzelKodlar_OzelKod2Id",
                        column: x => x.OzelKod2Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinFaturalar_SinSubeler_SubeId",
                        column: x => x.SubeId,
                        principalTable: "SinSubeler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SinFirmaParemetreler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    SubeId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    DonemId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    DepoId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinFirmaParemetreler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinFirmaParemetreler_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SinFirmaParemetreler_SinDepolar_DepoId",
                        column: x => x.DepoId,
                        principalTable: "SinDepolar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinFirmaParemetreler_SinDonemler_DonemId",
                        column: x => x.DonemId,
                        principalTable: "SinDonemler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinFirmaParemetreler_SinSubeler_SubeId",
                        column: x => x.SubeId,
                        principalTable: "SinSubeler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SinBankaHesaplar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kod = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Ad = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    HesapTuru = table.Column<byte>(type: "TinyInt", nullable: false),
                    HesapNo = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    IbanNo = table.Column<string>(type: "VarChar(26)", maxLength: 26, nullable: false),
                    BankaSubeId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    OzelKod1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    OzelKod2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SubeId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    Aciklama = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Durum = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinBankaHesaplar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinBankaHesaplar_SinBankaSubeler_BankaSubeId",
                        column: x => x.BankaSubeId,
                        principalTable: "SinBankaSubeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SinBankaHesaplar_SinOzelKodlar_OzelKod1Id",
                        column: x => x.OzelKod1Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinBankaHesaplar_SinOzelKodlar_OzelKod2Id",
                        column: x => x.OzelKod2Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinBankaHesaplar_SinSubeler_SubeId",
                        column: x => x.SubeId,
                        principalTable: "SinSubeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SinFaturaHareketler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FaturaId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    HareketTuru = table.Column<byte>(type: "TinyInt", nullable: false),
                    StokId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    HizmetId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    MasrafId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    DepoId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Miktar = table.Column<decimal>(type: "Money", nullable: false),
                    BirimFiyat = table.Column<decimal>(type: "Money", nullable: false),
                    BrutTutar = table.Column<decimal>(type: "Money", nullable: false),
                    IndirimTutar = table.Column<decimal>(type: "Money", nullable: false),
                    KdvOrani = table.Column<int>(type: "Int", nullable: false),
                    KdvHaricTutar = table.Column<decimal>(type: "Money", nullable: false),
                    KdvTutar = table.Column<decimal>(type: "Money", nullable: false),
                    NetTutar = table.Column<decimal>(type: "Money", nullable: false),
                    Aciklama = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinFaturaHareketler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinFaturaHareketler_SinDepolar_DepoId",
                        column: x => x.DepoId,
                        principalTable: "SinDepolar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinFaturaHareketler_SinFaturalar_FaturaId",
                        column: x => x.FaturaId,
                        principalTable: "SinFaturalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SinFaturaHareketler_SinHizmetler_HizmetId",
                        column: x => x.HizmetId,
                        principalTable: "SinHizmetler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinFaturaHareketler_SinMasraflar_MasrafId",
                        column: x => x.MasrafId,
                        principalTable: "SinMasraflar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinFaturaHareketler_SinStoklar_StokId",
                        column: x => x.StokId,
                        principalTable: "SinStoklar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SinMakbuzlar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MakbuzTuru = table.Column<byte>(type: "TinyInt", nullable: false),
                    MakbuzNo = table.Column<string>(type: "VarChar(16)", maxLength: 16, nullable: false),
                    Tarih = table.Column<DateTime>(type: "Date", nullable: false),
                    CariId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    KasaId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    BankaHesapId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    HareketSayisi = table.Column<int>(type: "Int", nullable: false),
                    CekToplam = table.Column<decimal>(type: "Money", nullable: false),
                    SenetToplam = table.Column<decimal>(type: "Money", nullable: false),
                    PosToplam = table.Column<decimal>(type: "Money", nullable: false),
                    NakitToplam = table.Column<decimal>(type: "Money", nullable: false),
                    BankaToplam = table.Column<decimal>(type: "Money", nullable: false),
                    OzelKod1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    OzelKod2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SubeId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    DonemId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    Aciklama = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Durum = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinMakbuzlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinMakbuzlar_SinBankaHesaplar_BankaHesapId",
                        column: x => x.BankaHesapId,
                        principalTable: "SinBankaHesaplar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinMakbuzlar_SinCariler_CariId",
                        column: x => x.CariId,
                        principalTable: "SinCariler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinMakbuzlar_SinDonemler_DonemId",
                        column: x => x.DonemId,
                        principalTable: "SinDonemler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinMakbuzlar_SinKasalar_KasaId",
                        column: x => x.KasaId,
                        principalTable: "SinKasalar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinMakbuzlar_SinOzelKodlar_OzelKod1Id",
                        column: x => x.OzelKod1Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinMakbuzlar_SinOzelKodlar_OzelKod2Id",
                        column: x => x.OzelKod2Id,
                        principalTable: "SinOzelKodlar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinMakbuzlar_SinSubeler_SubeId",
                        column: x => x.SubeId,
                        principalTable: "SinSubeler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SinMakbuzHareketler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MakbuzId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    OdemeTuru = table.Column<byte>(type: "TinyInt", nullable: false),
                    TakipNo = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: true),
                    CekBankaId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    CekBankaSubeId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    CekHesapNo = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: true),
                    BelgeNo = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: true),
                    Vade = table.Column<DateTime>(type: "Date", nullable: false),
                    AsilBorclu = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: true),
                    Ciranta = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: true),
                    KasaId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    BankaHesapId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Tutar = table.Column<decimal>(type: "Money", nullable: false),
                    BelgeDurumu = table.Column<byte>(type: "TinyInt", nullable: false),
                    KendiBelgemiz = table.Column<bool>(type: "Bit", nullable: false),
                    Aciklama = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinMakbuzHareketler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinMakbuzHareketler_SinBankaHesaplar_BankaHesapId",
                        column: x => x.BankaHesapId,
                        principalTable: "SinBankaHesaplar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinMakbuzHareketler_SinBankalar_CekBankaId",
                        column: x => x.CekBankaId,
                        principalTable: "SinBankalar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinMakbuzHareketler_SinBankaSubeler_CekBankaSubeId",
                        column: x => x.CekBankaSubeId,
                        principalTable: "SinBankaSubeler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinMakbuzHareketler_SinKasalar_KasaId",
                        column: x => x.KasaId,
                        principalTable: "SinKasalar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SinMakbuzHareketler_SinMakbuzlar_MakbuzId",
                        column: x => x.MakbuzId,
                        principalTable: "SinMakbuzlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SinBankaHesaplar_BankaSubeId",
                table: "SinBankaHesaplar",
                column: "BankaSubeId");

            migrationBuilder.CreateIndex(
                name: "IX_SinBankaHesaplar_Kod",
                table: "SinBankaHesaplar",
                column: "Kod");

            migrationBuilder.CreateIndex(
                name: "IX_SinBankaHesaplar_OzelKod1Id",
                table: "SinBankaHesaplar",
                column: "OzelKod1Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinBankaHesaplar_OzelKod2Id",
                table: "SinBankaHesaplar",
                column: "OzelKod2Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinBankaHesaplar_SubeId",
                table: "SinBankaHesaplar",
                column: "SubeId");

            migrationBuilder.CreateIndex(
                name: "IX_SinBankalar_Kod",
                table: "SinBankalar",
                column: "Kod");

            migrationBuilder.CreateIndex(
                name: "IX_SinBankalar_OzelKod1Id",
                table: "SinBankalar",
                column: "OzelKod1Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinBankalar_OzelKod2Id",
                table: "SinBankalar",
                column: "OzelKod2Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinBankaSubeler_BankaId",
                table: "SinBankaSubeler",
                column: "BankaId");

            migrationBuilder.CreateIndex(
                name: "IX_SinBankaSubeler_Kod",
                table: "SinBankaSubeler",
                column: "Kod");

            migrationBuilder.CreateIndex(
                name: "IX_SinBankaSubeler_OzelKod1Id",
                table: "SinBankaSubeler",
                column: "OzelKod1Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinBankaSubeler_OzelKod2Id",
                table: "SinBankaSubeler",
                column: "OzelKod2Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinBirimler_Kod",
                table: "SinBirimler",
                column: "Kod");

            migrationBuilder.CreateIndex(
                name: "IX_SinBirimler_OzelKod1Id",
                table: "SinBirimler",
                column: "OzelKod1Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinBirimler_OzelKod2Id",
                table: "SinBirimler",
                column: "OzelKod2Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinCariler_Kod",
                table: "SinCariler",
                column: "Kod");

            migrationBuilder.CreateIndex(
                name: "IX_SinCariler_OzelKod1Id",
                table: "SinCariler",
                column: "OzelKod1Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinCariler_OzelKod2Id",
                table: "SinCariler",
                column: "OzelKod2Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinDepolar_Kod",
                table: "SinDepolar",
                column: "Kod");

            migrationBuilder.CreateIndex(
                name: "IX_SinDepolar_OzelKod1Id",
                table: "SinDepolar",
                column: "OzelKod1Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinDepolar_OzelKod2Id",
                table: "SinDepolar",
                column: "OzelKod2Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinDepolar_SubeId",
                table: "SinDepolar",
                column: "SubeId");

            migrationBuilder.CreateIndex(
                name: "IX_SinDonemler_Kod",
                table: "SinDonemler",
                column: "Kod");

            migrationBuilder.CreateIndex(
                name: "IX_SinFaturaHareketler_DepoId",
                table: "SinFaturaHareketler",
                column: "DepoId");

            migrationBuilder.CreateIndex(
                name: "IX_SinFaturaHareketler_FaturaId",
                table: "SinFaturaHareketler",
                column: "FaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_SinFaturaHareketler_HizmetId",
                table: "SinFaturaHareketler",
                column: "HizmetId");

            migrationBuilder.CreateIndex(
                name: "IX_SinFaturaHareketler_MasrafId",
                table: "SinFaturaHareketler",
                column: "MasrafId");

            migrationBuilder.CreateIndex(
                name: "IX_SinFaturaHareketler_StokId",
                table: "SinFaturaHareketler",
                column: "StokId");

            migrationBuilder.CreateIndex(
                name: "IX_SinFaturalar_CariId",
                table: "SinFaturalar",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_SinFaturalar_DonemId",
                table: "SinFaturalar",
                column: "DonemId");

            migrationBuilder.CreateIndex(
                name: "IX_SinFaturalar_FaturaNO",
                table: "SinFaturalar",
                column: "FaturaNO");

            migrationBuilder.CreateIndex(
                name: "IX_SinFaturalar_OzelKod1Id",
                table: "SinFaturalar",
                column: "OzelKod1Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinFaturalar_OzelKod2Id",
                table: "SinFaturalar",
                column: "OzelKod2Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinFaturalar_SubeId",
                table: "SinFaturalar",
                column: "SubeId");

            migrationBuilder.CreateIndex(
                name: "IX_SinFirmaParemetreler_DepoId",
                table: "SinFirmaParemetreler",
                column: "DepoId");

            migrationBuilder.CreateIndex(
                name: "IX_SinFirmaParemetreler_DonemId",
                table: "SinFirmaParemetreler",
                column: "DonemId");

            migrationBuilder.CreateIndex(
                name: "IX_SinFirmaParemetreler_SubeId",
                table: "SinFirmaParemetreler",
                column: "SubeId");

            migrationBuilder.CreateIndex(
                name: "IX_SinFirmaParemetreler_UserId",
                table: "SinFirmaParemetreler",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SinHizmetler_BirimId",
                table: "SinHizmetler",
                column: "BirimId");

            migrationBuilder.CreateIndex(
                name: "IX_SinHizmetler_Kod",
                table: "SinHizmetler",
                column: "Kod");

            migrationBuilder.CreateIndex(
                name: "IX_SinHizmetler_OzelKod1Id",
                table: "SinHizmetler",
                column: "OzelKod1Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinHizmetler_OzelKod2Id",
                table: "SinHizmetler",
                column: "OzelKod2Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinKasalar_Kod",
                table: "SinKasalar",
                column: "Kod");

            migrationBuilder.CreateIndex(
                name: "IX_SinKasalar_OzelKod1Id",
                table: "SinKasalar",
                column: "OzelKod1Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinKasalar_OzelKod2Id",
                table: "SinKasalar",
                column: "OzelKod2Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinKasalar_SubeId",
                table: "SinKasalar",
                column: "SubeId");

            migrationBuilder.CreateIndex(
                name: "IX_SinMakbuzHareketler_BankaHesapId",
                table: "SinMakbuzHareketler",
                column: "BankaHesapId");

            migrationBuilder.CreateIndex(
                name: "IX_SinMakbuzHareketler_CekBankaId",
                table: "SinMakbuzHareketler",
                column: "CekBankaId");

            migrationBuilder.CreateIndex(
                name: "IX_SinMakbuzHareketler_CekBankaSubeId",
                table: "SinMakbuzHareketler",
                column: "CekBankaSubeId");

            migrationBuilder.CreateIndex(
                name: "IX_SinMakbuzHareketler_KasaId",
                table: "SinMakbuzHareketler",
                column: "KasaId");

            migrationBuilder.CreateIndex(
                name: "IX_SinMakbuzHareketler_MakbuzId",
                table: "SinMakbuzHareketler",
                column: "MakbuzId");

            migrationBuilder.CreateIndex(
                name: "IX_SinMakbuzHareketler_TakipNo",
                table: "SinMakbuzHareketler",
                column: "TakipNo");

            migrationBuilder.CreateIndex(
                name: "IX_SinMakbuzlar_BankaHesapId",
                table: "SinMakbuzlar",
                column: "BankaHesapId");

            migrationBuilder.CreateIndex(
                name: "IX_SinMakbuzlar_CariId",
                table: "SinMakbuzlar",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_SinMakbuzlar_DonemId",
                table: "SinMakbuzlar",
                column: "DonemId");

            migrationBuilder.CreateIndex(
                name: "IX_SinMakbuzlar_KasaId",
                table: "SinMakbuzlar",
                column: "KasaId");

            migrationBuilder.CreateIndex(
                name: "IX_SinMakbuzlar_MakbuzNo",
                table: "SinMakbuzlar",
                column: "MakbuzNo");

            migrationBuilder.CreateIndex(
                name: "IX_SinMakbuzlar_OzelKod1Id",
                table: "SinMakbuzlar",
                column: "OzelKod1Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinMakbuzlar_OzelKod2Id",
                table: "SinMakbuzlar",
                column: "OzelKod2Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinMakbuzlar_SubeId",
                table: "SinMakbuzlar",
                column: "SubeId");

            migrationBuilder.CreateIndex(
                name: "IX_SinMasraflar_BirimId",
                table: "SinMasraflar",
                column: "BirimId");

            migrationBuilder.CreateIndex(
                name: "IX_SinMasraflar_Kod",
                table: "SinMasraflar",
                column: "Kod");

            migrationBuilder.CreateIndex(
                name: "IX_SinMasraflar_OzelKod1Id",
                table: "SinMasraflar",
                column: "OzelKod1Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinMasraflar_OzelKod2Id",
                table: "SinMasraflar",
                column: "OzelKod2Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinOzelKodlar_Kod",
                table: "SinOzelKodlar",
                column: "Kod");

            migrationBuilder.CreateIndex(
                name: "IX_SinStoklar_BirimId",
                table: "SinStoklar",
                column: "BirimId");

            migrationBuilder.CreateIndex(
                name: "IX_SinStoklar_Kod",
                table: "SinStoklar",
                column: "Kod");

            migrationBuilder.CreateIndex(
                name: "IX_SinStoklar_OzelKod1Id",
                table: "SinStoklar",
                column: "OzelKod1Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinStoklar_OzelKod2Id",
                table: "SinStoklar",
                column: "OzelKod2Id");

            migrationBuilder.CreateIndex(
                name: "IX_SinSubeler_Kod",
                table: "SinSubeler",
                column: "Kod");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinFaturaHareketler");

            migrationBuilder.DropTable(
                name: "SinFirmaParemetreler");

            migrationBuilder.DropTable(
                name: "SinMakbuzHareketler");

            migrationBuilder.DropTable(
                name: "SinFaturalar");

            migrationBuilder.DropTable(
                name: "SinHizmetler");

            migrationBuilder.DropTable(
                name: "SinMasraflar");

            migrationBuilder.DropTable(
                name: "SinStoklar");

            migrationBuilder.DropTable(
                name: "SinDepolar");

            migrationBuilder.DropTable(
                name: "SinMakbuzlar");

            migrationBuilder.DropTable(
                name: "SinBirimler");

            migrationBuilder.DropTable(
                name: "SinBankaHesaplar");

            migrationBuilder.DropTable(
                name: "SinCariler");

            migrationBuilder.DropTable(
                name: "SinDonemler");

            migrationBuilder.DropTable(
                name: "SinKasalar");

            migrationBuilder.DropTable(
                name: "SinBankaSubeler");

            migrationBuilder.DropTable(
                name: "SinSubeler");

            migrationBuilder.DropTable(
                name: "SinBankalar");

            migrationBuilder.DropTable(
                name: "SinOzelKodlar");
        }
    }
}
