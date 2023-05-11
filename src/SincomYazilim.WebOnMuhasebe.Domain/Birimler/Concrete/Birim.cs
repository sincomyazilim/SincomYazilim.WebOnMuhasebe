using SincomYazilim.WebOnMuhasebe.Hizmetler.Concrete;
using SincomYazilim.WebOnMuhasebe.Masraflar.Concrete;
using SincomYazilim.WebOnMuhasebe.OzelKodlar.Concrete;
using SincomYazilim.WebOnMuhasebe.Stoklar.Concrete;

namespace SincomYazilim.WebOnMuhasebe.Birimler.Concrete;

public class Birim : FullAuditedAggregateRoot<Guid>
{// video 11
    public string Kod { get; set; }
    public string Ad { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }

    public OzelKod OzelKod1 { get; set; }// video 29
    public OzelKod OzelKod2 { get; set; }// video 29

    public ICollection<Hizmet> Hizmetler { get; set; }// video 34

    public ICollection<Stok> Stoklar { get; set; }// video 38

    public ICollection<Masraf> Masraflar { get; set; }// video 39
}
