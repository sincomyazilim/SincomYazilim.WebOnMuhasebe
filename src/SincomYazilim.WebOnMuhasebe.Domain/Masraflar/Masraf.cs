

namespace SincomYazilim.WebOnMuhasebe.Masraflar;

public class Masraf : FullAuditedAggregateRoot<Guid>
{// video 19
    public string Kod { get; set; }
    public string Ad { get; set; }
    public int KdvOrani { get; set; }
    public decimal BirimFiyat { get; set; }
    public string Barkod { get; set; }
    public Guid BirimId { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }


    public Birim Birim { get; set; }// video 39
    public OzelKod OzelKod1 { get; set; }// video 39
    public OzelKod OzelKod2 { get; set; }// video 39

    public ICollection<FaturaHareket> FaturaHareketler { get; set; }// video 40
}
