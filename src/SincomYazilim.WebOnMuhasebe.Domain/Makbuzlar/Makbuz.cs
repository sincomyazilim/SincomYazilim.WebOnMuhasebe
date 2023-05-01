

namespace SincomYazilim.WebOnMuhasebe.Makbuzlar;

public class Makbuz : FullAuditedAggregateRoot<Guid>
{// video 18
    public MakbuzTuru MakbuzTuru { get; set; }
    public string MakbuzNo { get; set; }
    public DateTime Tarih { get; set; }
    public Guid?  CariId { get; set; }
    public Guid?  KasaId { get; set; }
    public Guid?  BankaHesapId { get; set; }
    public int HareketSayisi { get; set; }
    public decimal CekToplam { get; set; }
    public decimal SenetToplam { get; set; }
    public decimal PosToplam { get; set; }
    public decimal NakitToplam { get; set; }
    public decimal BankaToplam { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }

    public Cari Cari { get; set; }// video 36
    public Kasa Kasa { get; set; }// video 36
    public BankaHesap BankaHesap { get; set; }// video 36
    public OzelKod OzelKod1 { get; set; }// video 36
    public OzelKod OzelKod2 { get; set; }// video 36
    public Sube Sube { get; set; }// video 36
    public Donem Donem { get; set; }// video 36

    public ICollection<MakbuzHareket> MakbuzHareketler { get; set; }// video 41

}
