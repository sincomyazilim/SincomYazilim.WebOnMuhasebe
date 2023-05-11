using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.Faturalar;
using SincomYazilim.WebOnMuhasebe.Makbuzlar;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.Cariler.Concrete;//75
public class ListCariHaraketDtoSin : EntityDto<Guid>
{
    public Guid CariId { get; set; }
    public Guid? FaturaId { get; set; }
    public Guid? MakbuzId { get; set; }
    public DateTime Tarih { get; set; }
    public string BelgeNo { get; set; }
    public string BelgeTuru { get; set; }
    public FaturaTuru FaturaTuru { get; set; }
    public MakbuzTuru MakbuzTuru { get; set; }
    public string HaraketTuru { get; set; }
    public string Aciklama { get; set; }
    public decimal Tutar { get; set; }
}
