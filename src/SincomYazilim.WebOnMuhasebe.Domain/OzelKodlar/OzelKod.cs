
namespace SincomYazilim.WebOnMuhasebe.OzelKodlar;

public class OzelKod : FullAuditedAggregateRoot<Guid>
{// video 20
    public string Kod { get; set; }
    public string Ad { get; set; }
    public OzelKodTuru KodTuru { get; set; }
    public KartTuru KartTuru { get; set; }

    public string Aciklama { get; set; }
    public bool Durum { get; set; }

    public ICollection<BankaHesap> OzelKod1BankaHesaplar { get; set; }// video 27
    public ICollection<BankaHesap> OzelKod2BankaHesaplar { get; set; }// video 27

    public ICollection<Banka> OzelKod1Bankalar { get; set; }// video 28
    public ICollection<Banka> OzelKod2Bankalar { get; set; }// video 28

    public ICollection<BankaSube> OzelKod1BankaSubeler { get; set; }// video 28
    public ICollection<BankaSube> OzelKod2BankaSubeler { get; set; }// video 28

    public ICollection<Birim> OzelKod1Birimler{ get; set; }// video 29
    public ICollection<Birim> OzelKod2Birimler{ get; set; }// video 29

    public ICollection<Cari> OzelKod1Cariler { get; set; }// video 31
    public ICollection<Cari> OzelKod2Cariler { get; set; }// video 31

    public ICollection<Depo> OzelKod1Depolar { get; set; }// video 32
    public ICollection<Depo> OzelKod2Depolar { get; set; }// video 32

    public ICollection<Fatura> OzelKod1Faturalar { get; set; }// video 33
    public ICollection<Fatura> OzelKod2Faturalar { get; set; }// video 33

    public ICollection<Hizmet> OzelKod1Hizmetler { get; set; }// video 34
    public ICollection<Hizmet> OzelKod2Hizmetler { get; set; }// video 34

    public ICollection<Kasa> OzelKod1Kasalar { get; set; }// video 35
    public ICollection<Kasa> OzelKod2Kasalar { get; set; }// video 35

    public ICollection<Makbuz> OzelKod1Makbuzlar { get; set; }// video 36
    public ICollection<Makbuz> OzelKod2Makbuzlar { get; set; }// video 36

    public ICollection<Stok> OzelKod1Stoklar { get; set; }// video 38
    public ICollection<Stok> OzelKod2Stoklar { get; set; }// video 38

    public ICollection<Masraf> OzelKod1Masraflar { get; set; }// video 39
    public ICollection<Masraf> OzelKod2Masraflar { get; set; }// video 39



}
