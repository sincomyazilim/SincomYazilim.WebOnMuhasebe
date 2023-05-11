using SincomYazilim.WebOnMuhasebe.Faturalar.Concrete;
using SincomYazilim.WebOnMuhasebe.Makbuzlar.Concrete;
using SincomYazilim.WebOnMuhasebe.Parametreler.Concrete;

namespace SincomYazilim.WebOnMuhasebe.Donemler.Concrete;

public class Donem : FullAuditedAggregateRoot<Guid>
{// video 14
    public string Kod { get; set; }
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }


    public ICollection<Fatura> Faturalar { get; set; }// video 33
    public ICollection<Makbuz> Makbuzlar { get; set; }// video 36
    public ICollection<FirmaParemetre> FirmaParemetreler { get; set; }// video 37

}
