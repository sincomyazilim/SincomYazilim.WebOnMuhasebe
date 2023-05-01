using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SincomYazilim.WebOnMuhasebe.BankaHesaplar;
using SincomYazilim.WebOnMuhasebe.Bankalar;
using SincomYazilim.WebOnMuhasebe.BankaSubeler;
using SincomYazilim.WebOnMuhasebe.Birimler;
using SincomYazilim.WebOnMuhasebe.Cariler;
using SincomYazilim.WebOnMuhasebe.Consts;
using SincomYazilim.WebOnMuhasebe.Depolar;
using SincomYazilim.WebOnMuhasebe.Donemler;
using SincomYazilim.WebOnMuhasebe.Faturalar;
using SincomYazilim.WebOnMuhasebe.Hizmetler;
using SincomYazilim.WebOnMuhasebe.Kasalar;
using SincomYazilim.WebOnMuhasebe.Parametreler;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace SincomYazilim.WebOnMuhasebe.SinConfigurations;

public static class WebOnMuhasebeDbContextModelBuilderExtensions
{ //Video 45 WebOnMuhasebeDbContext clası kodlar karısmasın dıye her bır entıtye funksıyon olusturduk burda

    public static void Configure(this ModelBuilder builder)
    {
        builder.Entity<Banka>(b =>
        {
            b.ToTable(WebOnMuhasebeConsts.DbTablePrefix + "Bankalar", WebOnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            // properties // video


            // Index // video
           

            // Relations // video
            
           
        });
    }

    public static void ConfigureBanka(this ModelBuilder builder )
    {
        builder.Entity<Banka>(b =>
        {
            b.ToTable(WebOnMuhasebeConsts.DbTablePrefix + "Bankalar", WebOnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            // properties
            //44 video
            b.Property(x => x.Kod).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxKodLength);
            b.Property(x => x.Ad).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxAdLength);
            b.Property(x => x.OzelKod1Id).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.OzelKod2Id).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.Aciklama).HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxAciklamaLength);
            b.Property(x => x.Durum).HasColumnType(SqlDbType.Bit.ToString());
            // Index
            //44 video
            b.HasIndex(x => x.Kod);
            // Relations
            //44 video
            b.HasOne(x => x.OzelKod1).WithMany(x => x.OzelKod1Bankalar).OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.OzelKod2).WithMany(x => x.OzelKod2Bankalar).OnDelete(DeleteBehavior.NoAction);
        });
    }

    public static void ConfigureBankaSube(this ModelBuilder builder)
    {
        builder.Entity<BankaSube>(b =>
        {
            b.ToTable(WebOnMuhasebeConsts.DbTablePrefix + "BankaSubeler", WebOnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
                // properties //46 video
                b.Property(x=>x.Kod).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxKodLength);
                b.Property(x => x.Ad).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxAdLength);
                b.Property(x => x.BankaId).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
                b.Property(x => x.OzelKod1Id).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
                b.Property(x => x.OzelKod2Id).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
                b.Property(x => x.Aciklama).HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxAciklamaLength);
                b.Property(x => x.Durum).HasColumnType(SqlDbType.Bit.ToString());

            // Index //46 video

                b.HasIndex(x => x.Kod);
            // Relations //46 video
                b.HasOne(x => x.Banka).WithMany(x => x.BankaSubeler).OnDelete(DeleteBehavior.Cascade);
                b.HasOne(x => x.OzelKod1).WithMany(x => x.OzelKod1BankaSubeler).OnDelete(DeleteBehavior.NoAction);
                b.HasOne(x => x.OzelKod2).WithMany(x => x.OzelKod2BankaSubeler).OnDelete(DeleteBehavior.NoAction);

            //b.HasOne<Banka>().WithMany().HasForeignKey(x => x.BankaId); boyle tanımlda olur ancak BankaSubede ozellık olara tanımladıgı ıcın onun uzerinden ulasılabılır
        });
    }
    public static void ConfigureBankaHesap(this ModelBuilder builder)
    {//vıdo 47
        builder.Entity<BankaHesap>(b =>
        {
            b.ToTable(WebOnMuhasebeConsts.DbTablePrefix + "BankaHesaplar", WebOnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            // properties // video
            b.Property(x => x.Kod).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxKodLength);
            b.Property(x => x.Ad).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxAdLength);
            //b.Property(x => x.BankaHesapTuru).IsRequired().HasColumnType(SqlDbType.TinyInt.ToString());
            b.Property(x => x.HesapNo).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(BankaHesapConsts.MaxHesapNoLength);
            b.Property(x => x.IbanNo).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(BankaHesapConsts.MaxIbanNoLength);
            b.Property(x => x.BankaSubeId).IsRequired().HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.OzelKod1Id).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.OzelKod2Id).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.SubeId).IsRequired().HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.Aciklama).HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxAciklamaLength);
            b.Property(x => x.Durum).HasColumnType(SqlDbType.Bit.ToString());

            // Index // video
            b.HasIndex(x => x.Kod);

            // Relations // video
            b.HasOne(x => x.BankaSube).WithMany(x => x.BankaHesaplar).OnDelete(DeleteBehavior.Cascade);
            b.HasOne(x => x.OzelKod1).WithMany(x => x.OzelKod1BankaHesaplar).OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.OzelKod2).WithMany(x => x.OzelKod2BankaHesaplar).OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.Sube).WithMany(x => x.BankaHesaplar).OnDelete(DeleteBehavior.Cascade);

        });
    }
    public static void ConfigureBirim(this ModelBuilder builder)
    {// video 48
        builder.Entity<Birim>(b =>
        {
            b.ToTable(WebOnMuhasebeConsts.DbTablePrefix + "Birimler", WebOnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            // properties 
            b.Property(x => x.Kod).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxKodLength);
            b.Property(x => x.Ad).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxAdLength);
            b.Property(x => x.OzelKod1Id).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.OzelKod2Id).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.Aciklama).HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxAciklamaLength);
            b.Property(x => x.Durum).HasColumnType(SqlDbType.Bit.ToString());

            // Index // video
            b.HasIndex(x => x.Kod);

            // Relations // video
            b.HasOne(x => x.OzelKod1).WithMany(x => x.OzelKod1Birimler).OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.OzelKod2).WithMany(x => x.OzelKod2Birimler).OnDelete(DeleteBehavior.NoAction);
        });
    }
    public static void ConfigureCari(this ModelBuilder builder)
    {// video 49
        builder.Entity<Cari>(b =>
        {
            b.ToTable(WebOnMuhasebeConsts.DbTablePrefix + "Cariler", WebOnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            // properties // video
            b.Property(x => x.Kod).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxKodLength);
            b.Property(x => x.Ad).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxAdLength);
            b.Property(x => x.VergiDairesi).HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(CariConsts.MaxVergiDairesiLength);
            b.Property(x => x.VergiNo).HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(CariConsts.MaxVergiNoLength);
            b.Property(x => x.Telefon).HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxTelefonLength);
            b.Property(x => x.TcNo).HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(CariConsts.MaxTcNoLength);
            b.Property(x => x.Adres).HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxAdresLength);
            b.Property(x => x.OzelKod1Id).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.OzelKod2Id).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.Aciklama).HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxAciklamaLength);
            b.Property(x => x.Durum).HasColumnType(SqlDbType.Bit.ToString());

            // Index // video
            b.HasIndex(x => x.Kod);

            // Relations // video
            b.HasOne(x => x.OzelKod1).WithMany(x => x.OzelKod1Cariler).OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.OzelKod2).WithMany(x => x.OzelKod2Cariler).OnDelete(DeleteBehavior.NoAction);

        });
    }
    public static void ConfigureDepo(this ModelBuilder builder)
    {//v 50
        builder.Entity<Depo>(b =>
        {
            b.ToTable(WebOnMuhasebeConsts.DbTablePrefix + "Depolar", WebOnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            // properties //50 video
            b.Property(x => x.Kod).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxKodLength);
            b.Property(x => x.Ad).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxAdLength);
            b.Property(x => x.OzelKod1Id).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.OzelKod2Id).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.SubeId).IsRequired().HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.Aciklama).HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxAciklamaLength);
            b.Property(x => x.Durum).HasColumnType(SqlDbType.Bit.ToString());

            // Index // video

            b.HasIndex(x => x.Kod);


            // Relations // video
            b.HasOne(x => x.OzelKod1).WithMany(x => x.OzelKod1Depolar).OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.OzelKod2).WithMany(x => x.OzelKod2Depolar).OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.Sube).WithMany(x => x.Depolar).OnDelete(DeleteBehavior.NoAction);

        });


    }
    public static void ConfigureDonem(this ModelBuilder builder)
    {//v 51
        builder.Entity<Donem>(b =>
        {
            b.ToTable(WebOnMuhasebeConsts.DbTablePrefix + "Donemler", WebOnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            // properties // video
            b.Property(x => x.Kod).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxKodLength);
            b.Property(x => x.Ad).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxAdLength);
            b.Property(x => x.Aciklama).HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxAciklamaLength);
            b.Property(x => x.Durum).HasColumnType(SqlDbType.Bit.ToString());


            // Index // video
            b.HasIndex(x => x.Kod);

            // Relations // video


        });
    }

    public static void ConfigureFatura(this ModelBuilder builder)
    {//v 52
        builder.Entity<Fatura>(b =>
        {
            b.ToTable(WebOnMuhasebeConsts.DbTablePrefix + "Faturalar", WebOnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            // properties // video
            b.Property(x => x.FaturaTuru).IsRequired().HasColumnType(SqlDbType.TinyInt.ToString());
            b.Property(x => x.FaturaNO).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(FaturaConsts.MaxFaturaNoLength);
            b.Property(x=>x.Tarih).IsRequired().HasColumnType(SqlDbType.Date.ToString());
            b.Property(x=>x.BrutTutar).IsRequired().HasColumnType(SqlDbType.Money.ToString());
            b.Property(x=>x.IndirimTutar).IsRequired().HasColumnType(SqlDbType.Money.ToString());
            b.Property(x=>x.KdvHaricTutar).IsRequired().HasColumnType(SqlDbType.Money.ToString());
            b.Property(x=>x.KdvTutar).IsRequired().HasColumnType(SqlDbType.Money.ToString());
            b.Property(x=>x.NetTutar).IsRequired().HasColumnType(SqlDbType.Money.ToString());
            b.Property(x=>x.HareketSayisi).IsRequired().HasColumnType(SqlDbType.Int.ToString());

            b.Property(x => x.CariId).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.OzelKod1Id).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.OzelKod2Id).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.SubeId).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.DonemId).HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Aciklama).HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxAciklamaLength);
            b.Property(x => x.Durum).HasColumnType(SqlDbType.Bit.ToString());

            // Index // video

            b.HasIndex(x=> x.FaturaNO);
            // Relations // video
            b.HasOne(x => x.Cari).WithMany(x => x.Faturalar).OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.OzelKod1).WithMany(x => x.OzelKod1Faturalar).OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.OzelKod2).WithMany(x => x.OzelKod2Faturalar).OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.Sube).WithMany(x => x.Faturalar).OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.Donem).WithMany(x => x.Faturalar).OnDelete(DeleteBehavior.NoAction);
        });
    }
    public static void ConfigureFaturaHareket(this ModelBuilder builder)
    {
        builder.Entity<FaturaHareket>(b =>
        {//video 53
            b.ToTable(WebOnMuhasebeConsts.DbTablePrefix + "FaturaHareketler", WebOnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            // properties // video
            b.Property(x => x.FaturaId).IsRequired().HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.HareketTuru).IsRequired().HasColumnType(SqlDbType.TinyInt.ToString());
            b.Property(x => x.StokId).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.HizmetId).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.MasrafId).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.DepoId).HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Miktar).IsRequired().HasColumnType(SqlDbType.Money.ToString());
            b.Property(x => x.BirimFiyat).IsRequired().HasColumnType(SqlDbType.Money.ToString());
            b.Property(x => x.BrutTutar).IsRequired().HasColumnType(SqlDbType.Money.ToString());
            b.Property(x => x.IndirimTutar).IsRequired().HasColumnType(SqlDbType.Money.ToString());
            b.Property(x => x.KdvOrani).IsRequired().HasColumnType(SqlDbType.Int.ToString());
            b.Property(x => x.KdvHaricTutar).IsRequired().HasColumnType(SqlDbType.Money.ToString());
            b.Property(x => x.KdvTutar).IsRequired().HasColumnType(SqlDbType.Money.ToString());
            b.Property(x => x.NetTutar).IsRequired().HasColumnType(SqlDbType.Money.ToString());
            b.Property(x => x.Aciklama).HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxAciklamaLength);
            // Index // video


            // Relations // video
            b.HasOne(x => x.Fatura).WithMany(x => x.FaturaHareketler).OnDelete(DeleteBehavior.Cascade);
            b.HasOne(x => x.Stok).WithMany(x => x.FaturaHareketler).OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.Hizmet).WithMany(x => x.FaturaHareketler).OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.Masraf).WithMany(x => x.FaturaHareketler).OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.Depo).WithMany(x => x.FaturaHareketler).OnDelete(DeleteBehavior.NoAction);

        });
    }
    public static void ConfigureFirmaParemetre(this ModelBuilder builder)
    {
        builder.Entity<FirmaParemetre>(b =>
        {//video 54
            b.ToTable(WebOnMuhasebeConsts.DbTablePrefix + "FirmaParemetreler", WebOnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            // properties // video
            b.Property(x => x.UserId).IsRequired().HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.SubeId).IsRequired().HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.DonemId).IsRequired().HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.DepoId).HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            // Index // video


            // Relations // video
            b.HasOne(x=>x.User).WithOne().HasForeignKey<FirmaParemetre>(x=> x.UserId);
            b.HasOne(x => x.Sube).WithMany(x => x.FirmaParemetreler).OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.Donem).WithMany(x => x.FirmaParemetreler).OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.Depo).WithMany(x => x.FirmaParemetreler).OnDelete(DeleteBehavior.NoAction);
        });
    }
    public static void ConfigureHizmet(this ModelBuilder builder)
    {//video 55
        builder.Entity<Hizmet>(b =>
        {
            b.ToTable(WebOnMuhasebeConsts.DbTablePrefix + "Hizmetler", WebOnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            // properties // video
            b.Property(x => x.Kod).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxKodLength);
            b.Property(x => x.Ad).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxAdLength);

            b.Property(x => x.KdvOrani).IsRequired().HasColumnType(SqlDbType.Int.ToString());
            b.Property(x => x.BirimFiyat).IsRequired().HasColumnType(SqlDbType.Money.ToString());
            
            b.Property(x => x.Barkod).HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxBarkodLength);
           
            b.Property(x => x.BirimId).IsRequired().HasColumnType(SqlDbType.UniqueIdentifier.ToString());
          


            b.Property(x => x.OzelKod1).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.OzelKod2).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.Aciklama).HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxAciklamaLength);
            b.Property(x => x.Durum).HasColumnType(SqlDbType.Bit.ToString());

            // Index // video
            b.HasIndex(x => x.Kod);

            // Relations // video
            b.HasOne(x => x.Birim).WithMany(x => x.Hizmetler).OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.OzelKod1).WithMany(x => x.OzelKod1Hizmetler).OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.OzelKod2).WithMany(x => x.OzelKod2Hizmetler).OnDelete(DeleteBehavior.NoAction);

        });
    }
    public static void ConfigureKasa(this ModelBuilder builder)
    {//v 56
        builder.Entity<Kasa>(b =>
        {
            b.ToTable(WebOnMuhasebeConsts.DbTablePrefix + "Kasalar", WebOnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();
            // properties // video
            b.Property(x => x.Kod).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxKodLength);
            b.Property(x => x.Ad).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxAdLength);


            b.Property(x => x.OzelKod1).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.OzelKod2).HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.Sube).IsRequired().HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.Aciklama).HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(EntityConsts.MaxAciklamaLength);
            b.Property(x => x.Durum).HasColumnType(SqlDbType.Bit.ToString());

            // Index // video
            b.HasIndex(x => x.Kod);

            // Relations // video

            b.HasOne(x => x.Sube).WithMany(x => x.Kasalar).OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.OzelKod1).WithMany(x => x.OzelKod1Kasalar).OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.OzelKod2).WithMany(x => x.OzelKod2Kasalar).OnDelete(DeleteBehavior.NoAction);
        });
    }
}
