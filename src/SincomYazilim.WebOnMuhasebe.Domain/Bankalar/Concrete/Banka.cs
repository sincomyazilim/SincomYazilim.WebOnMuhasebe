using SincomYazilim.WebOnMuhasebe.BankaSubeler.Concrete;
using SincomYazilim.WebOnMuhasebe.MakbuzHareketler.Concrete;
using SincomYazilim.WebOnMuhasebe.OzelKodlar.Concrete;

namespace SincomYazilim.WebOnMuhasebe.Bankalar.Concrete;

public class Banka : FullAuditedAggregateRoot<Guid>//burda abp firmasının ıcın Id tanımla clasıdır
{// video 9
    public string Kod { get; set; }
    public string Ad { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }

    public OzelKod OzelKod1 { get; set; }// video 28
    public OzelKod OzelKod2 { get; set; }// video 28



    public ICollection<BankaSube> BankaSubeler { get; set; }// video 28
    public ICollection<MakbuzHareket> MakbuzHareketler { get; set; }// video 41

}
