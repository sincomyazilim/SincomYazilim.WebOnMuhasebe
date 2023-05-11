using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.Makbuzlar;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.MakbuzHareketler.Concrete;//81
public class MakbuzHareketReportDtoSin : EntityDto<Guid>
{

    public string OdemeAdı { get; set; }
    public string TakipNo { get; set; }
    public string CekBankaAdı { get; set; }
    public string CekBankaSubeAdi { get; set; }
    public string CekHesapNo { get; set; }
    public string BelgeNo { get; set; }
    public DateTime Vade { get; set; }
    public string AsilBorclu { get; set; }
    public string Ciranta { get; set; }//cirolayan
    public string KasaAdi { get; set; }
    public string BankaHesapAdi { get; set; }
    public decimal Tutar { get; set; }
    public string BelgeDurumuAdi { get; set; }
    public bool KendiBelgemiz { get; set; }
    public string Aciklama { get; set; }
}
