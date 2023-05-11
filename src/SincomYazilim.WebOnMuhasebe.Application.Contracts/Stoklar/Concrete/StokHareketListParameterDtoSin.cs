using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Abstract;
using SincomYazilim.WebOnMuhasebe.Faturalar;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.Stoklar.Concrete;//85
public class StokHareketListParameterDtoSin : PagedResultRequestDto, IDurumSin, IEntityDto
{
    public FaturaHareketTuru Hareketturu { get; set; }
    public Guid EntityId { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public bool Durum { get; set; }
}
