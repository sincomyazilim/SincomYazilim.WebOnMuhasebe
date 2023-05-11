using SincomYazilim.WebOnMuhasebe.BankaSubeler.Concrete;
using SincomYazilim.WebOnMuhasebe.MakbuzHareketler.Concrete;
using SincomYazilim.WebOnMuhasebe.Makbuzlar.Concrete;
using SincomYazilim.WebOnMuhasebe.OzelKodlar.Concrete;
using SincomYazilim.WebOnMuhasebe.Subeler.Concrete;

namespace SincomYazilim.WebOnMuhasebe.BankaHesaplar.Concrete;

public class BankaHesap : FullAuditedAggregateRoot<Guid>//burda abp firmasının ıcın Id tanımla clasıdır.burda ıd kım sıldı kım guncelledı vb butün kayıtları tutuyor
{// video 8
    public string Kod { get; set; }
    public string Ad { get; set; }
    public BankaHesapTuru HesapTuru { get; set; }
    public string HesapNo { get; set; }
    public string IbanNo { get; set; }
    public Guid BankaSubeId { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public Guid SubeId { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }

    public BankaSube BankaSube { get; set; }// video 27
    public OzelKod OzelKod1 { get; set; }// video 27
    public OzelKod OzelKod2 { get; set; }// video 27
    public Sube Sube { get; set; }// video 27

    public ICollection<Makbuz> Makbuzlar { get; set; }// video 36
    public ICollection<MakbuzHareket> MakbuzHareketler { get; set; }// video 41


}

