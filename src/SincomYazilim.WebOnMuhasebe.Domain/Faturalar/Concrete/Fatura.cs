using SincomYazilim.WebOnMuhasebe.Cariler.Concrete;
using SincomYazilim.WebOnMuhasebe.Donemler.Concrete;
using SincomYazilim.WebOnMuhasebe.FaturaHareketler.Concrete;
using SincomYazilim.WebOnMuhasebe.OzelKodlar.Concrete;
using SincomYazilim.WebOnMuhasebe.Subeler.Concrete;

namespace SincomYazilim.WebOnMuhasebe.Faturalar.Concrete;

public class Fatura : FullAuditedAggregateRoot<Guid>
{// video 15
    public FaturaTuru FaturaTuru { get; set; }
    public string FaturaNO { get; set; }
    public DateTime Tarih { get; set; }
    public decimal BrutTutar { get; set; }
    public decimal IndirimTutar { get; set; }
    public decimal KdvHaricTutar { get; set; }
    public decimal KdvTutar { get; set; }
    public decimal NetTutar { get; set; }
    public int HareketSayisi { get; set; }
    public Guid CariId { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }

    public Cari Cari { get; set; }// video 33
    public OzelKod OzelKod1 { get; set; }// video 33
    public OzelKod OzelKod2 { get; set; }// video 33
    public Sube Sube { get; set; }// video 33
    public Donem Donem { get; set; }// video 33

    public ICollection<FaturaHareket> FaturaHareketler { get; set; }// video 40
}
