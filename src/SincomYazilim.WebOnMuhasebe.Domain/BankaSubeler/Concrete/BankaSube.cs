using SincomYazilim.WebOnMuhasebe.BankaHesaplar.Concrete;
using SincomYazilim.WebOnMuhasebe.Bankalar.Concrete;
using SincomYazilim.WebOnMuhasebe.MakbuzHareketler.Concrete;
using SincomYazilim.WebOnMuhasebe.OzelKodlar.Concrete;

namespace SincomYazilim.WebOnMuhasebe.BankaSubeler.Concrete;

public class BankaSube : FullAuditedAggregateRoot<Guid>//burda abp firmasının ıcın Id tanımla clasıdır
{// video 10
    public string Kod { get; set; }
    public string Ad { get; set; }
    public Guid BankaId { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }

    public Banka Banka { get; set; }// video 28
    public OzelKod OzelKod1 { get; set; }// video 28
    public OzelKod OzelKod2 { get; set; }// video 28



    public ICollection<BankaHesap> BankaHesaplar { get; set; }// video 27
    public ICollection<MakbuzHareket> MakbuzHareketler { get; set; }// video 41
}
