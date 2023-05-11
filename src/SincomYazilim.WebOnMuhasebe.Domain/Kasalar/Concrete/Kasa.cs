using SincomYazilim.WebOnMuhasebe.MakbuzHareketler.Concrete;
using SincomYazilim.WebOnMuhasebe.Makbuzlar.Concrete;
using SincomYazilim.WebOnMuhasebe.OzelKodlar.Concrete;
using SincomYazilim.WebOnMuhasebe.Subeler.Concrete;

namespace SincomYazilim.WebOnMuhasebe.Kasalar.Concrete;

public class Kasa : FullAuditedAggregateRoot<Guid>
{// video 17
    public string Kod { get; set; }
    public string Ad { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public Guid SubeId { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }

    public OzelKod OzelKod1 { get; set; }// video 35
    public OzelKod OzelKod2 { get; set; }// video 35
    public Sube Sube { get; set; }// video 35


    public ICollection<Makbuz> Makbuzlar { get; set; }// video 36
    public ICollection<MakbuzHareket> MakbuzHareketler { get; set; }// video 41
}
