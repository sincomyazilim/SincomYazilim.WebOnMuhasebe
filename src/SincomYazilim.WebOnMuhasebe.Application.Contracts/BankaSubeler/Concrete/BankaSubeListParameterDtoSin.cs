using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Abstract;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.BankaSubeler.Concrete;//73
public class BankaSubeListParameterDtoSin : PagedResultRequestDto, IDurumSin, IEntityDto
{
    public Guid BankaId { get; set; }
    public bool Durum { get; set; }
}
