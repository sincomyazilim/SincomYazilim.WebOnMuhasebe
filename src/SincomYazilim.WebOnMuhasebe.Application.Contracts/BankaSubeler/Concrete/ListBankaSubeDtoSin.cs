using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.BankaSubeler.Concrete;
public class ListBankaSubeDtoSin : EntityDto<Guid>//73
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public string BankaAdi { get; set; }
    public string OzelKod1Adi { get; set; }
    public string OzelKod2Adi { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
}
