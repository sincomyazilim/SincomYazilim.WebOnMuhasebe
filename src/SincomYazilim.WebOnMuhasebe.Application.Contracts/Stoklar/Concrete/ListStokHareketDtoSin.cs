using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.Faturalar;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.Stoklar.Concrete;//85
public class ListStokHareketDtoSin : EntityDto<Guid>
{
    public Guid? StokId { get; set; }
    public Guid? FaturaId { get; set; }
    public DateTime Tarih { get; set; }
    public string BelgeNo { get; set; }
    public FaturaTuru Faturaturu { get; set; }
    public string BelgeTuru { get; set; }
    public FaturaHareketTuru HareketTuru { get; set; }
    public string Aciklama { get; set; }
    public decimal Miktar { get; set; }
    public string Birim { get; set; }
    public decimal Birimfiyat { get; set; }
    public decimal Tutar { get; set; }

}
