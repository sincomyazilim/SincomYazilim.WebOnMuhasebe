using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.Makbuzlar;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.MakbuzHareketler.Concrete;//81
public class MakbuzHareketDtoSin : EntityDto<Guid>
{
    public OdemeTuru? OdemeTuru { get; set; }
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
}
