using SincomYazilim.WebOnMuhasebe.Faturalar.Concrete;
using SincomYazilim.WebOnMuhasebe.Makbuzlar.Concrete;
using SincomYazilim.WebOnMuhasebe.OzelKodlar.Concrete;

namespace SincomYazilim.WebOnMuhasebe.Cariler.Concrete;

public class Cari : FullAuditedAggregateRoot<Guid>//burda abp firmasının ıcın Id tanımla clasıdır
{// video 12
    public string Kod { get; set; }
    public string Ad { get; set; }
    public string VergiDairesi { get; set; }
    public string VergiNo { get; set; }
    public string TcNo { get; set; }
    public string Telefon { get; set; }
    public string Adres { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }


    public OzelKod OzelKod1 { get; set; }// video 31
    public OzelKod OzelKod2 { get; set; }// video 31

    public ICollection<Fatura> Faturalar { get; set; }// video 33
    public ICollection<Makbuz> Makbuzlar { get; set; }// video 36


}
