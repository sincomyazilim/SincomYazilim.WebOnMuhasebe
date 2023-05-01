

namespace SincomYazilim.WebOnMuhasebe.Makbuzlar;

public class MakbuzHareket:FullAuditedEntity<Guid>
{// video 25
    public Guid MakbuzId { get; set; }
    public OdemeTuru OdemeTuru { get; set; }
    public string TakipNo { get; set; }
    public Guid? CekBankaId { get; set; }
    public Guid? CekBankaSubeId { get; set; }
    public string CekHesapNo { get; set; }
    public string BelgeNo { get; set; }
    public DateTime Vade { get; set; }
    public string AsilBorclu { get; set; }
    public string Ciranta { get; set; }//cirolayan
    public Guid? KasaId { get; set; }
    public Guid? BankaHesapId { get; set; }
    public decimal Tutar { get; set; }
    public BelgeDurum BelgeDurumu { get; set; }
    public bool KendiBelgemiz { get; set; }
    public string Aciklama { get; set; }


    public Makbuz Makbuz { get; set; } // video 41
    public Banka CekBanka { get; set; }// video 41
    public BankaSube CekBankaSube { get; set; }// video 41
    public Kasa Kasa { get; set; }// video 41
    public BankaHesap BankaHesap { get; set; }// video 41
}
