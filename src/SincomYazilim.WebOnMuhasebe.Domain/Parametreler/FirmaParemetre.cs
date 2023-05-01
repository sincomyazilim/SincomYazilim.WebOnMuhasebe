
namespace SincomYazilim.WebOnMuhasebe.Parametreler;

public class FirmaParemetre:Entity<Guid>// entity clasından kalıtım alıyor. oncekı kalıtım kım sıldı kım guncelledı benzer kayıtlar aldıgı ıcın buna grek yok
{// video 21
    public Guid UserId { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public Guid? DepoId { get; set; }

    public IdentityUser User { get; set; } // video 37
    public Sube Sube { get; set; }// video 37
    public Donem Donem { get; set; }// video 37
    public Depo Depo { get; set; }// video 37

}
