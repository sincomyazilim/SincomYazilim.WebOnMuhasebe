using SincomYazilim.WebOnMuhasebe.FaturaHareketler.Concrete;
using SincomYazilim.WebOnMuhasebe.OzelKodlar.Concrete;
using SincomYazilim.WebOnMuhasebe.Parametreler.Concrete;
using SincomYazilim.WebOnMuhasebe.Subeler.Concrete;

namespace SincomYazilim.WebOnMuhasebe.Depolar.Concrete;

public class Depo : FullAuditedAggregateRoot<Guid>
{// video 13
    public string Kod { get; set; }
    public string Ad { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public Guid SubeId { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }

    public OzelKod OzelKod1 { get; set; }// video 32
    public OzelKod OzelKod2 { get; set; }// video 32
    public Sube Sube { get; set; }// video 32


    public ICollection<FirmaParemetre> FirmaParemetreler { get; set; }// video 37
    public ICollection<FaturaHareket> FaturaHareketler { get; set; }// video 40
}
