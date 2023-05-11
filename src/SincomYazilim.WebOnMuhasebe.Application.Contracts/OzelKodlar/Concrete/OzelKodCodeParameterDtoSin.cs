using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Abstract;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.OzelKodlar.Concrete;//83
public class OzelKodCodeParameterDtoSin : IEntityDto, IDurumSin
{
    public OzelKodTuru OzelKodTuru { get; set; }
    public KartTuru KartTuru { get; set; }
    public bool Durum { get; set; }
}
